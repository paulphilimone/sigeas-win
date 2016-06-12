using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mz.betainteractive.sigeas.zdbx.models;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.zdbx;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.DeviceSystem;

namespace mz.betainteractive.sigeas.Utilities {
    public class DeviceDataConvertions {

        #region UserClock Convertions

        public bool ConvertAttendanceDataToDatabase(SigeasDatabaseContext context, List<RawUserClock> listRawClocks, out List<UserClock> clocks) {
            clocks = null;

            if (listRawClocks == null) {
                return false;
            }

            try {
                ConvertAttendanceData(context, listRawClocks, out clocks);
                context.SaveChanges();
            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Device IO");
                return false;
            }

            return true;
        }

        public void ConvertAttendanceData(SigeasDatabaseContext context, List<RawUserClock> listRawClocks, out List<UserClock> clocks) {
            clocks = new List<UserClock>();

            if (listRawClocks == null) {
                return;
            }

            var createdBy = SystemManager.GetCurrentUser(context);
            
            /* //analisaremos num futuro breve
            var verifyModes = new List<VerifyMode>();

            verifyModes.Add(context.VerifyMode.First(v => v.Number == VerifyMode.PASSWORD_NUMBER));
            verifyModes.Add(context.VerifyMode.First(v => v.Number == VerifyMode.FINGERPRINT_NUMBER));
            verifyModes.Add(context.VerifyMode.First(v => v.Number == VerifyMode.CARD_NUMBER));
            */

            foreach (RawUserClock rawClock in listRawClocks){                           
                
                int dwEnrollNumber = Int32.Parse(rawClock.EnrollNumber);
                //Console.WriteLine("en: "+rawClock.EnrollNumber+", sn: "+rawClock.DeviceSerialNumber+", "+rawClock.DateAndTime);
                //Search by EnrollNumber
                DeviceUser  devUser = context.DeviceUser.FirstOrDefault(d => d.Device.SerialNumber == rawClock.DeviceSerialNumber && d.EnrollNumber == dwEnrollNumber);                    
                
                if (devUser == null) {
                    //Create Log Download Errors
                    LogErrors.AddErrorLog(null, "Usuario com userId=" + dwEnrollNumber + " não se encontra registado no sistema");
                    continue;
                }

                Funcionario funcionario = devUser.Funcionario;
                Device dev = devUser.Device;

                //Verificar se ja existe este clock no sistema
                var uclock = context.UserClock.FirstOrDefault(u => u.Funcionario.Id == funcionario.Id && u.Device.SerialNumber == dev.SerialNumber && u.DateAndTime == rawClock.DateAndTime);

                if (uclock != null) { //Se existe
                    Console.WriteLine("Already exists clock: " + uclock.DateAndTime.ToString() + ", " + uclock.Funcionario.ToString());
                    continue;
                }

                UserClock userClock = new UserClock();
                userClock.Device = dev;
                userClock.VerifyMode = context.VerifyMode.FirstOrDefault(v => v.Number == rawClock.VerifyMode);
                userClock.InOutMode = context.InOutMode.FirstOrDefault(i => i.Number == rawClock.InOutMode);
                userClock.DateAndTime = rawClock.DateAndTime;
                userClock.CreatedBy = createdBy;
                userClock.CreationDate = DateTime.Now;
                funcionario.UserClocks.Add(userClock);

                clocks.Add(userClock);

                Console.WriteLine("uc : "+userClock.Funcionario);
            }

        }
        
        #endregion


        #region ZXDB Convertions

        public void GetZDBxDatabase(List<Device> devices, out ZDBxDatabase database) {

            database = new ZDBxDatabase();

            SigeasDatabaseContext context = new SigeasDatabaseContext();

            foreach (Device device in devices) {
                ZDevice zdevice = null;

                GetZDevice(context, device, out zdevice);

                if (zdevice != null) {
                    database.Devices.Add(zdevice);
                }
            }

            if (database.Devices.Count == 0 && database.Clocks.Count == 0) {
                database = null;
            }

        }

        private void GetZDevice(SigeasDatabaseContext context, Device device, out ZDevice zdevice) {

            Device dev = context.Device.FirstOrDefault(t => t.SerialNumber == device.SerialNumber);

            if (dev == null) {
                zdevice = null;
                return;
            }

            zdevice = new ZDevice();
            zdevice.Id = dev.Id;
            zdevice.Name = dev.Name;
            zdevice.SerialNumber = dev.SerialNumber;
            zdevice.ConnectionType = dev.ConnectionType;
            zdevice.IpAddress = dev.IpAddress;
            zdevice.Port = dev.Port;
            zdevice.BaudRate = dev.BaudRate;
            zdevice.ComPort = dev.ComPort;
            zdevice.MaxUsers = dev.MaxUsers;

            foreach (var devUser in dev.DeviceUsers) {
                ZDeviceUser zdevUser = GetZDeviceUser(devUser);

                if (zdevUser != null) {
                    zdevUser.Device = zdevice;
                    zdevice.DeviceUsers.Add(zdevUser);
                }
            }
        }

        public void GetZDevice(Device device, out ZDevice zdevice) {
                        
            zdevice = new ZDevice();

            zdevice.Id = device.Id;
            zdevice.Name = device.Name;
            zdevice.SerialNumber = device.SerialNumber;
            zdevice.ConnectionType = device.ConnectionType;
            zdevice.IpAddress = device.IpAddress;
            zdevice.Port = device.Port;
            zdevice.BaudRate = device.BaudRate;
            zdevice.ComPort = device.ComPort;
            zdevice.MaxUsers = device.MaxUsers;                        
        }

        private ZDeviceUser GetZDeviceUser(DeviceUser devUser) {

            ZDeviceUser zdevUser = new ZDeviceUser();

            zdevUser.Id = devUser.Id;

            //if (devUser.EnrollNumber.HasValue) {
            zdevUser.EnrollNumber = devUser.EnrollNumber;
            zdevUser.CardNumber = devUser.CardNumber;
            
            //}

            ZUser zuser = GetZUser(devUser.Funcionario);

            if (zuser != null) {
                zdevUser.User = zuser;
            }

            return zdevUser;
        }

        private ZUser GetZUser(Funcionario funcionario) {
            ZUser zuser = new ZUser();

            zuser.Id = funcionario.Id;
            if (funcionario.EnrollNumber.HasValue) {
                zuser.EnrollNumber = funcionario.EnrollNumber.Value;
            }

            if (funcionario.Privilege.HasValue) {
                zuser.Previlege = funcionario.Privilege.Value;
            }

            zuser.FullName = funcionario.ToString();
            zuser.UserName = funcionario.Username;
            zuser.Password = funcionario.Password;
            zuser.CardNumber = funcionario.Cardnumber;

            if (funcionario.Enabled.HasValue) {
                zuser.Enabled = funcionario.Enabled.Value;
            }
            //Malta TimeZone Fazer depois
            if (funcionario.DeviceGroupTimezone != null) {
                zuser.DeviceGroupTimezone = GetZDeviceGroupTimezone(funcionario.DeviceGroupTimezone);
            }

            if (funcionario.DeviceTimezone1 != null) {
                zuser.DeviceTimezone1 = GetZDeviceTimezone(funcionario.DeviceTimezone1);
            }

            if (funcionario.DeviceTimezone2 != null) {
                zuser.DeviceTimezone2 = GetZDeviceTimezone(funcionario.DeviceTimezone2);
            }

            if (funcionario.DeviceTimezone3 != null) {
                zuser.DeviceTimezone3 = GetZDeviceTimezone(funcionario.DeviceTimezone3);
            }
            
            foreach (var fingerPrint in funcionario.UserFingerprints) {
                ZUserFingerprint zfinger = GetZFingerprint(fingerPrint);

                if (zfinger != null) {
                    zfinger.User = zuser;
                    zuser.UserFingerprints.Add(zfinger);
                }
            }

            return zuser;
        }

        public ZUser GetZUserOnly(Funcionario funcionario) {
            ZUser zuser = new ZUser();

            zuser.Id = funcionario.Id;
            if (funcionario.EnrollNumber.HasValue) {
                zuser.EnrollNumber = funcionario.EnrollNumber.Value;
            }

            if (funcionario.Privilege.HasValue) {
                zuser.Previlege = funcionario.Privilege.Value;
            }

            zuser.FullName = funcionario.ToString();
            zuser.UserName = funcionario.Username;
            zuser.Password = funcionario.Password;
            zuser.CardNumber = funcionario.Cardnumber;

            if (funcionario.Enabled.HasValue) {
                zuser.Enabled = funcionario.Enabled.Value;
            }
            
            return zuser;
        }

        public ZUserFingerprint GetZFingerprint(UserFingerprint fingerPrint) {
            ZUserFingerprint zfinger = new ZUserFingerprint();

            zfinger.Id = fingerPrint.Id;
            zfinger.FingerIndex = fingerPrint.FingerIndex;
            zfinger.TemplateData = fingerPrint.TemplateData;

            return zfinger;
        }

        public ZDeviceTimezone GetZDeviceTimezone(DeviceTimezone timezone) {
            ZDeviceTimezone ztimezone = new ZDeviceTimezone();

            ztimezone.Id = timezone.Id;
            ztimezone.Name = timezone.Name;
            ztimezone.MondayIn = timezone.MondayIn.Value;
            ztimezone.MondayOut = timezone.MondayOut.Value;
            ztimezone.TuesdayIn = timezone.TuesdayIn.Value;
            ztimezone.TuesdayOut = timezone.TuesdayOut.Value;
            ztimezone.WednesdayIn = timezone.WednesdayIn.Value;
            ztimezone.WednesdayOut = timezone.WednesdayOut.Value;
            ztimezone.ThursdayIn = timezone.ThursdayIn.Value;
            ztimezone.ThursdayOut = timezone.ThursdayOut.Value;
            ztimezone.FridayIn = timezone.FridayIn.Value;
            ztimezone.FridayOut = timezone.FridayOut.Value;
            ztimezone.SaturdayIn = timezone.SaturdayIn.Value;
            ztimezone.SaturdayOut = timezone.SaturdayOut.Value;
            ztimezone.SundayIn = timezone.SundayIn.Value;
            ztimezone.SundayOut = timezone.SundayOut.Value;


            return ztimezone;
        }

        public ZDeviceGroupTimezone GetZDeviceGroupTimezone(DeviceGroupTimezone groupTimezone) {
            ZDeviceGroupTimezone zgroupTimezone = new ZDeviceGroupTimezone();

            zgroupTimezone.Id = groupTimezone.Id;
            zgroupTimezone.Name = groupTimezone.Name;
            zgroupTimezone.GroupIndex = groupTimezone.GroupIndex;

            if (groupTimezone.ValidHolyday.HasValue) {
                zgroupTimezone.ValidHolyday = groupTimezone.ValidHolyday.Value;
            }

            if (groupTimezone.VerifyStyle.HasValue) {
                zgroupTimezone.VerifyStyle = groupTimezone.VerifyStyle.Value;
            }

            if (groupTimezone.DeviceTimezone1 != null) {
                zgroupTimezone.DeviceTimezone1 = GetZDeviceTimezone(groupTimezone.DeviceTimezone1);
            }
            if (groupTimezone.DeviceTimezone2 != null) {
                zgroupTimezone.DeviceTimezone2 = GetZDeviceTimezone(groupTimezone.DeviceTimezone2);
            }
            if (groupTimezone.DeviceTimezone3 != null) {
                zgroupTimezone.DeviceTimezone3 = GetZDeviceTimezone(groupTimezone.DeviceTimezone3);
            }
            return zgroupTimezone;
        }

        #endregion

    }
}
