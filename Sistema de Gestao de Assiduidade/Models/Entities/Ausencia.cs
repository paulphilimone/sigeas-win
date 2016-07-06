using System;
using System.Collections.Generic;

namespace mz.betainteractive.sigeas.Models.Entities
{
    public partial class Ausencia   {
        public long Id { get; set; }
        
        public string Motivo { get; set; }     
        public System.DateTime DataInicial { get; set; }
        public System.DateTime DataFinal { get; set; }
        public bool Justificada { get; set; }
        
        public virtual Funcionario Funcionario { get; set; }
        public virtual TipoAusencia Tipo { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }
        public virtual ApplicationUser UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }

        public override string ToString() {
            return Funcionario.ToString() + " - PA (" + DataInicial.ToString("yyyy-MM-dd") + " á " + DataFinal.ToString("yyyy-MM-dd") + ")";
        }
    }
}
