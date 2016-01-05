using System;
using System.Collections.Generic;

namespace mz.betainteractive.sigeas.Models.Entities
{
    public partial class SystemLog  {
        public long Id { get; set; }        
        public string Description { get; set; }
        public System.DateTime LogTime { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
