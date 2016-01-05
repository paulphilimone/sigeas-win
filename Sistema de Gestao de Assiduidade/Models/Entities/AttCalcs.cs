using System;
using System.Collections.Generic;

namespace mz.betainteractive.sigeas.Models.Entities
{
    public partial class AttCalcs {

        public long Id { get; set; }        
        public int Ano { get; set; }
        public bool Ausente { get; set; }
        public int AusenteHoras { get; set; }
        public int AusenteMins { get; set; }
        public virtual TipoAusencia TipoAusencia { get; set; }

        public Nullable<System.DateTime> Data { get; set; }
        public int Dia { get; set; }
        public bool IsEmFerias { get; set; }
        public System.DateTime Entrada { get; set; }

        public bool IsFeriado { get; set; }        
        public bool IsDayWork { get; set; }
        public bool IsPresente { get; set; }
        public bool IsAusenciaAutorizada { get; set; }

        public virtual Funcionario Funcionario { get; set; }        
        public virtual HorarioDia HorarioDia { get; set; }

        public int HrExtrasHoras { get; set; }
        public int HrExtrasMins { get; set; }
        
        public int Mes { get; set; }
        public System.DateTime Saida { get; set; }
        public System.DateTime EntradaAtrasada { get; set; }
        public System.DateTime SaidaAdiantada { get; set; }
        public int TrabalhouHoras { get; set; }
        public int TrabalhouMins { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }
        public virtual ApplicationUser UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}
