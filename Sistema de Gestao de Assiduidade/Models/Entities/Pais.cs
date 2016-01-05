using System;
using System.Collections.Generic;

namespace  mz.betainteractive.sigeas.Models.Entities {

    public partial class Pais {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Nome { get; set; }
        public string Capital { get; set; }
    
        public virtual Continente Continente { get; set; }

        public override string ToString() {
            return this.Nome;
        }

        public override bool Equals(object obj) {
            if (obj is Pais) {
                Pais cast = (Pais)obj;
                return this.Id == cast.Id;
            }

            return false;
        }

        public override int GetHashCode() {
            return 0;
        }
    }

}
