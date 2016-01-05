using System;
using System.Collections.Generic;

namespace  mz.betainteractive.sigeas.Models.Entities {

    public partial class DeviceType {

        public static String IN = "Entrada";
        public static String OUT = "Saída";
        public static String IN_OUT = "Entrada/Saida";
        public static int TYPE_IN = 1;
        public static int TYPE_OUT = 2;
        public static int TYPE_IN_OUT = 3;
                
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeNumber { get; set; }

        public override string ToString() {
            return this.Name;
        }

        public override bool Equals(object obj) {
            if (obj is DeviceType) {
                DeviceType cast = (DeviceType)obj;
                return this.Id == cast.Id;
            }

            return false;
        }

        public override int GetHashCode() {
            return 0;
        }
    }
}
