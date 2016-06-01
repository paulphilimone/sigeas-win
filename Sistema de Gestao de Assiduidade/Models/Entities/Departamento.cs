using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace mz.betainteractive.sigeas.Models.Entities
{
    public partial class Departamento  {
        
        public long Id { get; set; }
        [StringLength(10)]
        [Index("IX_Code", 1, IsUnique = true)]
        public string Code { get; set; }
        public string Descricao { get; set; }        
        public string Nome { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual Door RegisteredDoor { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }
        public virtual ApplicationUser UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }

        public virtual List<Funcionario> Funcionarios { get; set; }

        public Departamento() {
            this.Funcionarios = new List<Funcionario>();
        }

        public override string ToString() {
            return this.Nome;
        }

        public override bool Equals(object obj) {
            if (obj is Departamento) {
                Departamento o = (Departamento)obj;
                return o.Id == this.Id;
            }
            return false;
        }

        public override int GetHashCode() {
            return 0;//base.GetHashCode();
        }
    }
}
