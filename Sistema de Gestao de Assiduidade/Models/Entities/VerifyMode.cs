using System;
using System.Collections.Generic;

namespace  mz.betainteractive.sigeas.Models.Entities {

    public partial class VerifyMode {
                
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }


        public override string ToString() {
            return this.Name;
        }

        public override bool Equals(object obj) {
            if (obj is VerifyMode) {
                VerifyMode cast = (VerifyMode)obj;
                return this.Id == cast.Id;
            }

            return false;
        }

        public override int GetHashCode() {
            return 0;
        }


        public static string PASSWORD_NAME = "Password";
        public static string FINGERPRINT_NAME = "Fingerprint";
        public static string CARD_NAME = "Cartão";
        public static int PASSWORD_NUMBER = 0;
        public static int FINGERPRINT_NUMBER = 1;
        public static int CARD_NUMBER = 2;

        public static int MULTI_1_FP_OR_PW_OR_RF = 0;
        public static int MULTI_2_FP = 1;
        public static int MULTI_3_PIN = 2;
        public static int MULTI_4_PW = 3;
        public static int MULTI_5_RF = 4;
        public static int MULTI_6_FP_AND_RF = 5;
        public static int MULTI_7_FP_OR_PW = 6;
        public static int MULTI_8_FP_OR_RF = 7;
        public static int MULTI_9_PW_OR_RF = 8;
        public static int MULTI_10_PIN_AND_FP = 9;
        public static int MULTI_11_FP_AND_PW = 10;
        public static int MULTI_12_PW_AND_RF = 11;
        public static int MULTI_13_FP_AND_PW_AND_RF = 12;
        public static int MULTI_14_PIN_AND_FP_AND_PW = 13;
        public static int MULTI_15_FP_AND_RF_OR_PIN = 14;
        public static int MULTI_16_FACE = 15;
        public static int MULTI_17_FACE_AND_FP = 16;
        public static int MULTI_18_FACE_AND_PW = 17;
        public static int MULTI_19_FACE_AND_RF = 18;
        public static int MULTI_20_FACE_AND_FP_AND_RF = 19;
        public static int MULTI_21_FACE_AND_FP_AND_PW = 20;
    }

}
