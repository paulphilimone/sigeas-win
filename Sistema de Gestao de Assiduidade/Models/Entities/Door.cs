using System;
using System.Collections.Generic;


namespace mz.betainteractive.sigeas.Models.Entities
{
    public partial class Door {

        public long Id { get; set; }

        public string Name { get; set; }
        public int NumberOfDevices { get; set; }
        public virtual DoorType Type { get; set; }
                
        public virtual Departamento Departamento { get; set; }
        public virtual List<Device> Devices { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }
        public virtual ApplicationUser UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }


        public Door() {
            this.Devices = new List<Device>();
        }

        public override string ToString() {
            return this.Name;
        }

        public override bool Equals(object obj) {
            if (obj is Door) {
                Door s = (Door)obj;
                return s.Id == this.Id;
            }
            return false;
        }

        public override int GetHashCode() {
            return 0;//base.GetHashCode();
        }
    }
}
