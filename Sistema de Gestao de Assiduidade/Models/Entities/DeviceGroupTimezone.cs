using System;
using System.Collections.Generic;

namespace  mz.betainteractive.sigeas.Models.Entities {
    public partial class DeviceGroupTimezone  {

        public int Id { get; set; }
        public int GroupIndex { get; set; }
        public string Name { get; set; }
        public Nullable<int> ValidHolyday { get; set; }
        public Nullable<int> VerifyStyle { get; set; }        

        public virtual DeviceTimezone DeviceTimezone1 { get; set; }
        public virtual DeviceTimezone DeviceTimezone2 { get; set; }
        public virtual DeviceTimezone DeviceTimezone3 { get; set; }
        public virtual List<User> Users { get; set; }
        
        public DeviceGroupTimezone() {
            this.Users = new List<User>();
        }

        public override string ToString() {
            return this.Name;
        }

        public override bool Equals(object obj) {
            if (obj is DeviceGroupTimezone) {
                DeviceGroupTimezone cast = (DeviceGroupTimezone)obj;
                return this.Id == cast.Id;
            }

            return false;
        }

        public override int GetHashCode() {
            return 0;
        }
    }
}
