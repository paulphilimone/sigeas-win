using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using mz.betainteractive.utilities.module.General;

namespace mz.betainteractive.sigeas.Models.Entities
{
    public partial class MonthWork {

        public long Id { get; set; }

        [Index("IX_YearAndMonthOrder", 1, IsUnique = true)]
        public int Year { get; set; }
        [Index("IX_YearAndMonthOrder", 2, IsUnique = true)]
        public int Order { get; set; }
        public string Name { get; set; } 
        public DateTime First { get; set; }
        public DateTime Last { get; set; }        
        //public int TotalWorkDays { get; set; }
        public int TotalDays { get; set; }

        public bool Enabled; /* if the enterprise changes his initial date for calculations all current data is disabled and new ones a created*/
       
        public virtual ApplicationUser CreatedBy { get; set; }
        public virtual ApplicationUser UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }

        public MonthWork() { }

        public MonthWork(DateBounds dateBound) { 
            this.Year = dateBound.Year;
            this.Order = dateBound.Order;
            this.Name = dateBound.Name;
            this.First = dateBound.First;
            this.Last = dateBound.Last;
            this.TotalDays = dateBound.Days;
        }

    }
}
