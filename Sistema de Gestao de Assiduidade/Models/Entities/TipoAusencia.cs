using System;
using System.Collections.Generic;

namespace mz.betainteractive.sigeas.Models.Entities
{
    public partial class TipoAusencia {
        public static string CASAMENTO = "Doença";
        public static string FALECIMENTO = "Falecimento (Pais, filhos, avos, etc)";
        public static string FALECIMENTO_2 = "Falecimento (Sogros, Tios, primos, etc)";
        public static string DOENCA_ACIDENTE = "Doença / Acidente";        
        public static string TRABALHO = "Trabalho fora do escritorio";
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
