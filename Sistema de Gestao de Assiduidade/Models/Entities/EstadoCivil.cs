using System;
using System.Collections.Generic;

namespace  mz.betainteractive.sigeas.Models.Entities {
    
    public partial class EstadoCivil {
        public static String SOLTEIRO = "Solteiro(a)";
        public static String CASADO = "Casado(a)";
        public static String DIVORCIADO = "Divorciado(a)";
        public static String VIUVO = "Viuvo(a)";

        /* Properties */
        public int Id { get; set; }
        public string Nome { get; set; }
        /* Properties */

        public static string[] GetAll() {
            return new string[] { SOLTEIRO, CASADO, DIVORCIADO, VIUVO };
        }

        public override string ToString() {
            return this.Nome;
        }

        public override bool Equals(object obj) {
            if (obj is EstadoCivil) {
                EstadoCivil cast = (EstadoCivil)obj;
                return this.Id == cast.Id;
            }

            return false;
        }

        public override int GetHashCode() {
            return 0;
        }
    }
}
