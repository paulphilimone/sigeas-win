using System;
using System.Collections.Generic;

namespace  mz.betainteractive.sigeas.Models.Entities {

    public partial class Distrito {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Nome { get; set; }

        public virtual Provincia Provincia { get; set; }
        public virtual List<PostoAdministrativo> PostoAdministrativos { get; set; }

        public Distrito() {
            this.PostoAdministrativos = new List<PostoAdministrativo>();
        }

        public override string ToString() {
            return this.Nome;
        }

        public override bool Equals(object obj) {
            if (obj is Distrito) {
                Distrito cast = (Distrito)obj;
                return this.Id == cast.Id;
            }

            return false;
        }

        public override int GetHashCode() {
            return 0;
        }
    }
    
}
