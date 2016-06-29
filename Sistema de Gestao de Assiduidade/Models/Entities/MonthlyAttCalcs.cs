using System;
using System.Collections.Generic;

namespace mz.betainteractive.sigeas.Models.Entities
{
    public partial class MonthlyAttCalcs {

        public long Id { get; set; }        
        public int Ano { get; set; }
        public int Order { get; set; }
        public DateTime First { get; set; }
        public DateTime Last { get; set; } 
        
        public bool OnVacation { get; set; }

        public int Holidays { get; set; }

        public int TotalWorkDays { get; set; }
        public int TotalWorkHours { get; set; }
        public int TotalWorkMins { get; set; }
                
        public int WorkedDays { get; set; }
        public int WorkedHours { get; set; }
        public int WorkedMins { get; set; }

        public int AbsentDays { get; set; }
        public int AbsentHours { get; set; }
        public int AbsentMins { get; set; }

        public int TotalOvertimeHours { get; set; }
        public int TotalOvertimeMins { get; set; }

        public virtual MonthWork Month { get; set; }   

        public virtual Funcionario Funcionario { get; set; }   

        public virtual ApplicationUser CreatedBy { get; set; }
        public virtual ApplicationUser UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}
