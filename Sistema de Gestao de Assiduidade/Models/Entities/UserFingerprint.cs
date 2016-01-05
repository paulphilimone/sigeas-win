using System;
using System.Collections.Generic;

namespace  mz.betainteractive.sigeas.Models.Entities {

    public partial class UserFingerprint {
        public int Id { get; set; }
        public int FingerIndex { get; set; }
        public string TemplateData { get; set; }
        
        public virtual User User { get; set; }
    }
}
