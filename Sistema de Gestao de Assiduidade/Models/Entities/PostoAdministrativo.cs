using System;
using System.Collections.Generic;

namespace  mz.betainteractive.sigeas.Models.Entities {

    public partial class PostoAdministrativo {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Nome { get; set; }

        public virtual Distrito Distrito { get; set; }
        public virtual List<Localidade> Localidades { get; set; }

        public PostoAdministrativo() {
            this.Localidades = new List<Localidade>();
        }

        public override string ToString() {
            return this.Nome;
        }

        public override bool Equals(object obj) {
            if (obj is PostoAdministrativo) {
                PostoAdministrativo cast = (PostoAdministrativo)obj;
                return this.Id == cast.Id;
            }

            return false;
        }

        public override int GetHashCode() {
            return 0;
        }
    }

}
