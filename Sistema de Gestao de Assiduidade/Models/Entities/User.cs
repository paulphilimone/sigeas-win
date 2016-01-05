using System;
using System.Collections.Generic;

namespace  mz.betainteractive.sigeas.Models.Entities {
    public abstract class User {

        public int Id { get; set; }
        public Nullable<int> EnrollNumber { get; set; }
        public Nullable<int> Previlege { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CardNumber { get; set; }
        public Nullable<bool> Enabled { get; set; }               
        
        public virtual DeviceGroupTimezone DeviceGroupTimezone { get; set; }
        public virtual DeviceTimezone DeviceTimezone1 { get; set; }
        public virtual DeviceTimezone DeviceTimezone2 { get; set; }
        public virtual DeviceTimezone DeviceTimezone3 { get; set; }
        public virtual List<UserFingerprint> UserFingerprints { get; set; }        

        public User() {
            this.UserFingerprints = new List<UserFingerprint>();
        }
        
    }
}
