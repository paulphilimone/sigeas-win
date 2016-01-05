using System;
using System.Collections.Generic;

namespace mz.betainteractive.sigeas.Models.Entities
{
    public partial class HorarioDia {

        public static int DOMINGO = 0;
        public static int SEGUNDA = 1;
        public static int TERCA   = 2;
        public static int QUARTA  = 3;
        public static int QUINTA  = 4;
        public static int SEXTA   = 5;
        public static int SABADO  = 6;

        public long Id { get; set; }                
        public bool Enabled { get; set; }
        public int WeekDay { get; set; }
        public System.DateTime Entrada1 { get; set; }
        public System.DateTime Entrada2 { get; set; }
        
        public bool HasIntervalo { get; set; }
        public int HorasTrabalho { get; set; }
        public int IntervaloMinutos { get; set; }
        public int MinsTrabalho { get; set; }
        
        public System.DateTime Saida1 { get; set; }
        public System.DateTime Saida2 { get; set; }
        public int ToleranciaNaEntrada1 { get; set; }
        public int ToleranciaNaSaida2 { get; set; }

        public virtual HorarioSemana HorarioSemana { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }
        public virtual ApplicationUser UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}
