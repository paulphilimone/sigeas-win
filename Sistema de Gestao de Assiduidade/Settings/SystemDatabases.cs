using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.model.ca;
using mz.betainteractive.sigeas.Utilities;
using MySql.Data;
using MySql.Data.MySqlClient;
using mz.betainteractive.sigeas.Properties;

namespace mz.betainteractive.sigeas.settings{
    public class SystemDatabases    {                

        Constants constants;              
        /*

        public Dictionary<long, Device> Devices;
        public Dictionary<Door, List<Device>> Doors_And_Devices;
        public Dictionary<Departamento, List<Funcionario>> DepartFuncionarios;
        public List<Device> ConnectedDevices;
        public Device SelectedDevice;
        public List<Feriado> Feriados;

        public SystemDatabases() {                                   
            Devices = new Dictionary<long, Device>();
            Doors_And_Devices = new Dictionary<Door, List<Device>>(new EqualityComparerObjectAtt<Door>());
            ConnectedDevices = new List<Device>();
            DepartFuncionarios = new Dictionary<Departamento, List<Funcionario>>();
            Feriados = new List<Feriado>();
        }

        public void Init() {
            InitConstants();
            ReadAllFeriados();
            GetDevicesFromDatabase();
        }

        public void InitConstants() {
            constants = new Constants();
        }

        public void ReadAllFeriados() {
            List<Feriado> list = Download.FindAllFeriados();
            this.Feriados.Clear();
            this.Feriados.AddRange(list);
        }

        public bool isFeriado(DateTime dia) {
            DateTime date = dia.Date;

            var frs = from fe in this.Feriados
                      where fe.Data == date
                      select fe;

            if (frs.Count() > 0) {
                return true;
            }

            return false;
        }

        #region Obtain data from Database

        public void GetDevicesFromDatabase() {
            try
            {
                using (var DB = new SisgaDatabaseContext())
                {
                    var doorDevs = from dr in DB.Door                                   
                                   select dr;

                    List<Device> newDevices = new List<Device>();
                    
                    //Upgrade This

                    //this.Doors_And_Devices.Clear();
                    //this.Devices.Clear();

                    //Se houver um device no sistema, k não exta na nova pesquisa remover

                    foreach (Door dr in doorDevs) {                     
                        Door door = dr;
                        Device fdev = null;
                        Device sdev = null;
                        List<Device> listDev = null;

                        if (door.FirstDeviceID != null) {
                            fdev = Device.GetDevice((long)door.FirstDeviceID);
                        }
                        if (door.SecondDeviceID != null) {
                            sdev = Device.GetDevice((long)door.SecondDeviceID);
                        }
                        
                        if (this.Doors_And_Devices.ContainsKey(door)) {
                            this.Doors_And_Devices.TryGetValue(door, out listDev);
                        } else {
                            listDev = new List<Device>();                            
                            this.Doors_And_Devices.Add(door, listDev);
                        }                        
                                                
                        if (fdev != null) {
                            if (!this.Devices.ContainsKey(fdev.ID)) {
                                this.Devices.Add(fdev.ID, fdev);
                            }
                            if (!listDev.Contains(fdev)) {
                                listDev.Add(fdev);
                            }
                            
                            newDevices.Add(fdev);
                        }
                        if (sdev != null) {
                            if (!this.Devices.ContainsKey(sdev.ID)) {
                                this.Devices.Add(sdev.ID, sdev);
                            }
                            if (!listDev.Contains(sdev)) {
                                listDev.Add(sdev);
                            }
                            newDevices.Add(sdev);
                        }
                    }

                    //Console.WriteLine("Updated devices");  
                    RemoveOldDevicesAndDoors(doorDevs.ToList<Door>(), newDevices);
                    RemoveDisconnectedDevices();
                    Console.WriteLine("Updated devices "+Devices.Count);  
                }
            }catch (Exception ex) {
                MessageBox.Show("Não foi possivel ler os dispositivos na base de dados");
            }
        }

        private void RemoveOldDevicesAndDoors(List<Door> newDoors, List<Device> newDevices) { 
            foreach (Door dr in this.Doors_And_Devices.Keys){
                if (!newDoors.Contains(dr)) {
                    this.Doors_And_Devices.Remove(dr);
                }
            }
            foreach (long key in this.Devices.Keys) {
                Device dev = null;
                this.Devices.TryGetValue(key, out dev);

                if (dev != null)
                if (!newDevices.Contains(dev)) {
                    RemoveFromDoorDevice(dev);
                    this.Devices.Remove(key);
                }
            }
        }

        private void RemoveFromDoorDevice(Device dev) {
            foreach (List<Device> ldev in this.Doors_And_Devices.Values) { 
                if (ldev.Contains(dev)){
                    ldev.Remove(dev);
                }
            }
        }

        private void RemoveDisconnectedDevices() {
            foreach (Device device in this.Devices.Values) {
                if (ConnectedDevices.Contains(device) && device.Connected == false) {
                    this.ConnectedDevices.Remove(device);
                }
            }
        }

        public void GetFuncionariosFromDatabase() {
            try {
                using (var DB = new SisgaDatabaseContext()) {
                    var depFuncs = from dp in DB.Departamento
                                   join fc in DB.Funcionario on dp.ID equals fc.DepartamentoID
                                   group fc by dp;


                    this.DepartFuncionarios.Clear();

                    foreach (var dp in depFuncs) {
                        string dName = dp.Key.Nome;
                        Departamento depart = dp.Key;

                        foreach (var func in dp) {
                            
                            //update doors_and_devices

                            if (this.DepartFuncionarios.ContainsKey(depart)) {
                                List<Funcionario> lfunc = null;
                                this.DepartFuncionarios.TryGetValue(depart, out lfunc);
                                lfunc.Add(func);
                            } else {
                                List<Funcionario> lfunc = new List<Funcionario>();
                                lfunc.Add(func);
                                this.DepartFuncionarios.Add(depart, lfunc);
                            }
                        }
                    }
                                        
                }
            } catch (Exception ex) {
                MessageBox.Show("Não foi possivel ler os funcionarios na base de dados");
            }
        }                            
        
        public void GetApplicationUsersFromDatabase(out List<ApplicationUser> appusers) {

            appusers = new List<ApplicationUser>();

            var DB = new SisgaDatabaseContext();

            var users = from apu in DB.ApplicationUser
                        select apu;

            if (users.Count() == 0) {
                return;
            }

            foreach (var user in users)   {
                appusers.Add(user);
            }

        }                              
        
        #endregion

        #region Create Database From SQL File

        public static bool CreateDatabase() {

            try {
                string connStr = "server=localhost;user=root;port=3306;";
                MySqlConnection conn = new MySqlConnection(connStr);                                

                String sqlCreate = Resources.create;

                MySqlCommand cmd = new MySqlCommand(sqlCreate, conn);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();                

                Console.WriteLine("Created And Inserted");
                return true;
                
            } catch (Exception ex) {
                Console.WriteLine("Errorx: "+ex.ToString());
                return false;
            }

            
        }

        internal static bool DatabaseExists() {
            try {
                string connStr = "server=localhost;user=sisga;password=transistor47;database=beta_interactive_sisga;port=3306;";
                
                MySqlConnection conn = new MySqlConnection(connStr);

                conn.Open();                
                conn.Close();

                return true;
               
            } catch (Exception ex) {                
                return false;
            }
        }

        #endregion



        internal void AddConnectedDevice(Device device) {
            if (!this.ConnectedDevices.Contains(device) && device.Connected) {
                this.ConnectedDevices.Add(device);
            }
        }

        public void RemoveConnectedDevice(Device device) {
            this.ConnectedDevices.Remove(device);
        }
        */
    }
         
}
