using System;
using System.Collections.Generic;

namespace mz.betainteractive.sigeas.Models.Entities
{
    public partial class Ferias {
        public long Id { get; set; }
                
        public System.DateTime DataFinal { get; set; }
        public System.DateTime DataInicial { get; set; }
        
        public virtual Funcionario Funcionario { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }
        public virtual ApplicationUser UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}
