using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mz.betainteractive.sigeas.settings {
    public class Constants {

        public static string LONG_DATETIME_FORMAT = "yyyy-MM-dd hh:mm:ss";
        /*
        public static Sexo MASCULINO;
        public static Sexo FEMENINO;

        public static DeviceType DEVICE_TYPE_IN;
        public static DeviceType DEVICE_TYPE_OUT;
        public static DeviceType DEVICE_TYPE_INOUT;

        public static DoorType DOOR_TYPE_ONEFP;
        public static DoorType DOOR_TYPE_TWOFP;

        public static UserClockVerifyMode VERIFY_MODE_PASSWORD;
        public static UserClockVerifyMode VERIFY_MODE_FINGERPRINT;

        public static UserClockState STATE_CLOCK_IN;
        public static UserClockState STATE_CLOCK_OUT;
        public static UserClockState STATE_CHECK_OUT;
        public static UserClockState STATE_CHECK_OUT_BACK;
        public static UserClockState STATE_OVERTIME_CHECK_IN;
        public static UserClockState STATE_OVERTIME_CHECK_OUT;
        public static UserClockState STATE_UNKNOWN_STATE;
        public static UserClockState STATE_OPEN_FOR_OUT;
        public static UserClockState STATE_INVALID_STATE;

        public static TipoFalta TIPO_FALTA_DOENCA;
        public static TipoFalta TIPO_FALTA_EM_FERIAS;
        public static TipoFalta TIPO_FALTA_TRABALHO;
        public static TipoFalta TIPO_FALTA_OUTRO;
        */

        public Constants() {
            /*
            MASCULINO = Sexo.GetMasculino();
            FEMENINO = Sexo.GetFemenino();
            
            DEVICE_TYPE_IN = DeviceType.GetTypeIn();
            DEVICE_TYPE_OUT = DeviceType.GetTypeOut();
            DEVICE_TYPE_INOUT = DeviceType.GetTypeInOut();
            
            DOOR_TYPE_ONEFP = DoorType.GetTypeOneFP();
            DOOR_TYPE_TWOFP = DoorType.GetTypeTwoFP();
            
            VERIFY_MODE_PASSWORD = UserClockVerifyMode.GetVerifyModeByPassaword();
            VERIFY_MODE_FINGERPRINT = UserClockVerifyMode.GetVerifyModeByFingerprint();

            STATE_CLOCK_IN = UserClockState.GetStateClockIn();
            STATE_CLOCK_OUT = UserClockState.GetStateClockOut();
            STATE_CHECK_OUT = UserClockState.GetStateCheckOut();
            STATE_CHECK_OUT_BACK = UserClockState.GetStateCheckOutBack();
            STATE_OVERTIME_CHECK_IN = UserClockState.GetStateOverTimeCheckIn();
            STATE_OVERTIME_CHECK_OUT = UserClockState.GetStateOverTimeCheckOut();
            STATE_UNKNOWN_STATE = UserClockState.GetStateUnknownState();
            STATE_OPEN_FOR_OUT = UserClockState.GetStateOpenForOut();
            STATE_INVALID_STATE = UserClockState.GetStateInvalidState();;
                
            TIPO_FALTA_DOENCA = TipoFalta.GetTipoDoenca();
            TIPO_FALTA_EM_FERIAS = TipoFalta.GetTipoEmFerias();
            TIPO_FALTA_TRABALHO = TipoFalta.GetTipoTrabalho();
            TIPO_FALTA_OUTRO = TipoFalta.GetTipoOutro();
             */
        }

        /*
        public static UserClockVerifyMode GetVerifyMode(long id) {
            if (id == VERIFY_MODE_PASSWORD.ID) {
                return VERIFY_MODE_PASSWORD;
            } else {
                return VERIFY_MODE_FINGERPRINT;
            }
        }

        public static UserClockState GetClockSate(long id) {
            if (id == STATE_CLOCK_IN.ID) {
                return STATE_CLOCK_IN;
            }
            if (id == STATE_CLOCK_OUT.ID) {
                return STATE_CLOCK_OUT;
            }
            if (id == STATE_CHECK_OUT.ID) {
                return STATE_CHECK_OUT;
            }
            if (id == STATE_CHECK_OUT_BACK.ID) {
                return STATE_CHECK_OUT_BACK;
            }
            if (id == STATE_OVERTIME_CHECK_IN.ID) {
                return STATE_OVERTIME_CHECK_IN;
            }
            if (id == STATE_OVERTIME_CHECK_OUT.ID) {
                return STATE_OVERTIME_CHECK_OUT;
            }
            if (id == STATE_UNKNOWN_STATE.ID) {
                return STATE_UNKNOWN_STATE;
            }
            if (id == STATE_OPEN_FOR_OUT.ID) {
                return STATE_OPEN_FOR_OUT;
            }

            return STATE_INVALID_STATE;
        }
        */

        /*
         * Get the default time, started with 2012,1,1
         */
        public static DateTime GetTime(int hour, int minute, int second) {
            return new DateTime(2012, 1, 1, hour, minute, second);
        }

        public static DateTime GetTime(DateTime date, int hour, int minute, int second) {
            return new DateTime(date.Year, date.Month, date.Day, hour, minute, second);
        }

        public static DateTime GetTime(DateTime date, DateTime time) {
            return new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
        }

        public static DateTime GetTime(DateTime date, TimeSpan time) {
            return new DateTime(date.Year, date.Month, date.Day, time.Hours, time.Minutes, time.Seconds);
        }

        /*
         * Get the default time, started with 2012,1,1,0,0,0
         */
        public static DateTime GetDefaultTime() {
            return new DateTime(2012, 1, 1, 0, 0, 0);
        }

        internal static DateTime GetTime(TimeSpan ts) {
            return GetTime(ts.Hours, ts.Minutes, 0);
        }
    }
}
