using System;
using System.Collections.Generic;

namespace  mz.betainteractive.sigeas.Models.Entities {
    
    public partial class DocumentoIdentificacao {
        public static String BI = "B.I";
        public static String PASSAPORTE = "Passaporte";
        public static String CEDULA_PESSOAL = "Cedula Pessoal";
        public static String CERTIDAO_DE_NASCIMENTO = "Certidão de Nascimento";

        public int Id { get; set; }
        public string Nome { get; set; }
        public string ExpressaoPadrao { get; set; }

        public override string ToString() {
            return this.Nome;
        }

        public override bool Equals(object obj) {
            if (obj is DocumentoIdentificacao) {
                DocumentoIdentificacao cast = (DocumentoIdentificacao)obj;
                return this.Id == cast.Id;
            }

            return false;
        }

        public override int GetHashCode() {
            return 0;
        }
    }
}
