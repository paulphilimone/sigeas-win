using System;
using System.Collections.Generic;

namespace  mz.betainteractive.sigeas.Models.Entities {

    public partial class Provincia {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Nome { get; set; }

        public virtual List<Distrito> Distritos { get; set; }

        public Provincia() {
            this.Distritos = new List<Distrito>();
        }

        public override string ToString() {
            return this.Nome;
        }

        public override bool Equals(object obj) {
            if (obj is Provincia) {
                Provincia cast = (Provincia)obj;
                return this.Id == cast.Id;
            }

            return false;
        }

        public override int GetHashCode() {
            return 0;
        }
    }


}
