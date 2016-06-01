using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace mz.betainteractive.sigeas.Models.Entities
{
    public partial class Funcionario : User, IComparable {

        [StringLength(10)]
        [Index("IX_Code", 1, IsUnique = true)]
        public string Code { get; set; }

        public string Nome { get; set; }
        public string Apelido { get; set; }
        public Nullable<System.DateTime> DataDeNascimento { get; set; }
        public string AvenidaRua { get; set; }
        public string Bairro { get; set; }
        public Nullable<int> NumeroCasa { get; set; }
        public string NumeroDI { get; set; }
        public byte[] Photo { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public bool CompleteRegistered { get; set; }

        public virtual Departamento Departamento { get; set; }
        public virtual Categoria Categoria { get; set; }
        public Nullable<System.DateTime> DataDeIngresso { get; set; }                       
        
        public virtual string EstadoCivil { get; set; }
        public virtual string Sexo { get; set; }
        public virtual string DocumentoIdentificacao { get; set; }

        public virtual Pais Nacionalidade { get; set; }
        public virtual Distrito Distrito { get; set; }
        public virtual Localidade Localidade { get; set; }
        public virtual PostoAdministrativo PostoAdministrativo { get; set; }
        public virtual Provincia Provincia { get; set; }                       
        
        public virtual ApplicationUser CreatedBy { get; set; }
        public virtual ApplicationUser UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }

        public virtual List<Ausencia> Ausencias { get; set; }
        public virtual List<Ferias> Ferias { get; set; }
        public virtual List<UserClock> UserClocks { get; set; }
        public virtual List<AttCalcs> AttCalculos { get; set; }
        public virtual List<DeviceUser> DeviceUsers { get; set; }

        public Funcionario() {
            this.Ausencias = new List<Ausencia>();
            this.Ferias = new List<Ferias>();
            this.UserClocks = new List<UserClock>();
            this.AttCalculos = new List<AttCalcs>();
            this.DeviceUsers = new List<DeviceUser>();
            this.CompleteRegistered = false;
        }

        public string CreateCode(Empresa empresa) {
            long contract = 0;
            if (empresa != null) {
                contract = empresa.Id;
            }

            string code = "";
            
            code = "F" + contract.ToString("X3") + "-" + this.Id.ToString("D3");

            return code;
        }

        //Default Methods
        public override string ToString() {
            return this.Nome; /*+ " " + this.Apelido;*/
        }

        public override bool Equals(object obj) {
            if (obj is Funcionario) {
                Funcionario e = (Funcionario)obj;
                return e.Id == this.Id;
            }
            return false;
        }

        public override int GetHashCode() {
            return 0;
        }


        public int CompareTo(object obj) {
            return obj.ToString().CompareTo(this.ToString());
        }
    }
}
