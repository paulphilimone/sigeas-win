using System;
using System.Collections.Generic;

namespace mz.betainteractive.sigeas.Models.Entities
{
    public partial class TipoAusencia {
        public static string DOENCA = "Doença";
        public static string EM_FERIAS = "Em Férias";
        public static string TRABALHO = "Trabalho";
        public static string OUTRO = "Outro";
        
        public long Id { get; set; }        
        public string Nome { get; set; }

        public override string ToString() {
            return this.Nome;
        }

        public override bool Equals(object obj) {
            if (obj is TipoAusencia) {
                TipoAusencia o = (TipoAusencia)obj;
                return o.Id == this.Id;
            }
            return false;
        }

        public override int GetHashCode() {
            return 0;//base.GetHashCode();
        }
    }
}
