using System;
using System.Collections.Generic;

namespace mz.betainteractive.sigeas.Models.Entities {

    public partial class Continente {

        public int Id { get; set; }
        public int Code { get; set; }
        public string Nome { get; set; }
        public virtual List<Pais> Paises { get; set; }

        public Continente() {
            this.Paises = new List<Pais>();
        }  

        public override string ToString() {
            return this.Nome;
        }

        public override bool Equals(object obj) {
            if (obj is Continente) {
                Continente cast = (Continente)obj;
                return this.Id == cast.Id;
            }

            return false;
        }

        public override int GetHashCode() {
            return 0;
        }
      
    }

}
