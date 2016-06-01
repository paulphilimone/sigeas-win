using System;
using System.Collections.Generic;

namespace  mz.betainteractive.sigeas.Models.Entities {
        
    public partial class Sexo {
        public static String MASCULINO = "Masculino";
        public static String FEMENINO = "Femenino";

        public int Id { get; set; }
        public string Nome { get; set; }

        public static string GetString(char gender) {
            switch (gender) {
                case 'M': return MASCULINO;
                case 'm': return MASCULINO;
                case 'F': return FEMENINO;
                case 'f': return FEMENINO;
                default: return MASCULINO;
            }                        
        }

        public override string ToString() {
            return this.Nome;
        }

        public override bool Equals(object obj) {
            if (obj is Sexo) {
                Sexo cast = (Sexo)obj;
                return this.Id == cast.Id;
            }

            return false;
        }

        public override int GetHashCode() {
            return 0;
        }
    }
}
