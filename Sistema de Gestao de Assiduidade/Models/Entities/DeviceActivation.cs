using System;
using System.Collections.Generic;

namespace mz.betainteractive.sigeas.Models.Entities
{
    public partial class DeviceActivation {
        public long Id { get; set; }        
        public string Company { get; set; }
        public string ProductKey { get; set; }
    }
}
