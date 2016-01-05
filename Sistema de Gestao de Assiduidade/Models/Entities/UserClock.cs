using System;
using System.Collections.Generic;

namespace  mz.betainteractive.sigeas.Models.Entities {

    public partial class UserClock {

        public int Id { get; set; }
        public System.DateTime DateAndTime { get; set; }
        public string CorrectState { get; set; }
        public string Result { get; set; }
        public bool IsControleGeral { get; set; }
        
        public Nullable<System.DateTime> CreationDate { get; set; }        
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        
        public virtual ApplicationUser CreatedBy { get; set; }
        public virtual ApplicationUser UpdatedBy { get; set; }
        public virtual Device Device { get; set; }
        public virtual InOutMode InOutMode { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual VerifyMode VerifyMode { get; set; }

        public bool isHoraExtra;
        public DateTime HoraExtra;
        public string Observacoes = "";

        
    }
}
