using System;
using System.Collections.Generic;


namespace mz.betainteractive.sigeas.Models.Entities
{
    public partial class Categoria {
        
        public long Id { get; set; }                                
        public string Funcoes { get; set; }
        public string Nome { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }
        public virtual ApplicationUser UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }

        public virtual List<Funcionario> Funcionarios { get; set; }


        public Categoria() {
            this.Funcionarios = new List<Funcionario>();
        }

        public override string ToString() {
            return this.Nome;
        }

        public override bool Equals(object obj) {
            if (obj is Categoria) {
                Categoria o = (Categoria)obj;
                return o.Id == this.Id;
            }
            return false;
        }

        public override int GetHashCode() {
            return 0;//base.GetHashCode();
        }
    }
}
