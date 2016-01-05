using System;
using System.Collections.Generic;

namespace mz.betainteractive.sigeas.Models.Entities {

    public partial class Device : IDevice {

        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }

        public virtual Door Door { get; set; }
        public virtual DeviceType DeviceType { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }
        public virtual ApplicationUser UpdatedBy { get; set; }
        public virtual List<DeviceUser> DeviceUsers { get; set; }
        public virtual List<UserClock> UserClocks { get; set; }
        
        public Device() {            
            this.DeviceUsers = new List<DeviceUser>();
            this.UserClocks = new List<UserClock>();
            
        }


    }
}
