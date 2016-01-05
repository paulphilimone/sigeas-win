using System;
using System.Collections.Generic;

namespace mz.betainteractive.sigeas.Models.Entities{
    public partial class AttendanceRules {

        public long Id { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }
        public virtual ApplicationUser UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }

        public int CountAtrasoAfter { get; set; }
        public int CountHorasExtrasAfter { get; set; }
        public int MinIfNoClockIn { get; set; }
        public int MinIfNoClockOut { get; set; }
        public bool IsClockingOverHorarioDia { get; set; }
    }
}
