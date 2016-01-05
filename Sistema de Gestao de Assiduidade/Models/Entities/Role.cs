using System;
using System.Collections.Generic;

namespace  mz.betainteractive.sigeas.Models.Entities {
    
    public partial class Role {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<RolePermission> RolePermissions { get; set; }
        public virtual List<ApplicationUser> ApplicationUsers { get; set; }

        public Role() {
            this.RolePermissions = new List<RolePermission>();
            this.ApplicationUsers = new List<ApplicationUser>();
        }

        public override string ToString() {
            return this.Name;
        }

        public override bool Equals(object obj) {
            if (obj is Role) {
                Role role = (Role)obj;
                return this.Id == role.Id;
            }

            return false;
        }

        public override int GetHashCode() {
            return 0;
        }
    }

}
