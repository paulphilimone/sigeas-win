using System;
using System.Collections.Generic;


namespace  mz.betainteractive.sigeas.Models.Entities
{
    public partial class Empresa {

        public int Id { get; set; }

        public string Nome { get; set; }
        public int Numero { get; set; }
        public string Telefone { get; set; }
        public string AvenidaRua { get; set; }                        
        public string Email { get; set; }
        public string Fax { get; set; }

        public virtual Distrito Distrito { get; set; }
        public virtual Localidade Localidade { get; set; }
        public virtual PostoAdministrativo PostoAdministrativo { get; set; }
        public virtual Provincia Provincia { get; set; }
                        
        public virtual AttendanceRules AttendanceRules { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }
        public virtual ApplicationUser UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }

        public virtual List<Departamento> Departamentos { get; set; }
        public virtual List<Categoria> Categorias { get; set; }

        //public virtual List<Door>

        public Empresa() {
            this.Departamentos = new List<Departamento>();
            this.Categorias = new List<Categoria>();
        }

        public override string ToString() {
            return this.Nome;
        }

        public override bool Equals(object obj) {
            if (obj is Empresa) {
                Empresa cast = (Empresa)obj;
                return this.Id == cast.Id;
            }

            return false;
        }

        public override int GetHashCode() {
            return 0;
        }
    }
}
