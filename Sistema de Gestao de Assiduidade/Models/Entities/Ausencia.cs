using System;
using System.Collections.Generic;

namespace mz.betainteractive.sigeas.Models.Entities
{
    public partial class Ausencia   {
        public long Id { get; set; }
        
        public string Descricao { get; set; }
        public System.DateTime Dia { get; set; }        
        public System.DateTime HoraFim { get; set; }
        public System.DateTime HoraInicio { get; set; }
        public bool Justificada { get; set; }
        public bool Valida { get; set; }

        public virtual Funcionario Funcionario { get; set; }
        public virtual TipoAusencia Tipo { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }
        public virtual ApplicationUser UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        
    }
}
