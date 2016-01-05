using System;
using System.Collections.Generic;

namespace  mz.betainteractive.sigeas.Models.Entities {

    public partial class VerifyMode {
        public static string PASSWORD_NAME = "Password";
        public static string FINGERPRINT_NAME = "Fingerprint";
        public static string CARD_NAME = "Cartão";
        public static int PASSWORD_NUMBER = 0;
        public static int FINGERPRINT_NUMBER = 1;
        public static int CARD_NUMBER = 2;
        
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
                
    }

}
