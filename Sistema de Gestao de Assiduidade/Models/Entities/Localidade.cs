using System;
using System.Collections.Generic;

namespace  mz.betainteractive.sigeas.Models.Entities {

    public partial class Localidade {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Nome { get; set; }

        public virtual PostoAdministrativo PostoAdministrativo { get; set; }

        public override string ToString() {
            return this.Nome;
        }

        public override bool Equals(object obj) {
            if (obj is Localidade) {
                Localidade cast = (Localidade)obj;
                return this.Id == cast.Id;
            }

            return false;
        }

        public override int GetHashCode() {
            return 0;
        }
    }

}
