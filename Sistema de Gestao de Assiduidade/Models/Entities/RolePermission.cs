using System;
using System.Collections.Generic;

namespace  mz.betainteractive.sigeas.Models.Entities {

    public partial class RolePermission {
        public int Id { get; set; }
        public int FormCode { get; set; }
        public int ActionCode { get; set; }
        public string Name { get; set; }
        public virtual List<Role> Roles { get; set; }

        public RolePermission() {
            this.Roles = new List<Role>();
        }

        public override string ToString() {
            return this.Name;
        }

        public override bool Equals(object obj) {
            if (obj is RolePermission) {
                RolePermission rp = (RolePermission)obj;
                return this.Id == rp.Id;
            }

            return false;
        }

        public override int GetHashCode() {
            return 0;
        }
    }

}
