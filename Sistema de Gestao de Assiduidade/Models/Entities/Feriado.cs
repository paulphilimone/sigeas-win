using System;
using System.Collections.Generic;

namespace mz.betainteractive.sigeas.Models.Entities
{
    public partial class Feriado {

        public const int TIPO_NACIONAL = 1;
        public const int TIPO_LOCAL = 2;

        public long Id { get; set; }
                
        public System.DateTime Data { get; set; }
        public int Duracao { get; set; }
        public string Nome { get; set; }
        public int Tipo { get; set; }
        public string Descricao { get; set; }
        public bool Default { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }
        public virtual ApplicationUser UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }


        public string GetTipoText() {
            switch (Tipo) { 
                case TIPO_NACIONAL: return "Nacional";
                case TIPO_LOCAL: return "Local/Regional";
            }

            return "";
        }
    }
}
