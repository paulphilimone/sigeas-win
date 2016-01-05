using System;
using System.Collections.Generic;

namespace mz.betainteractive.sigeas.Models.Entities {
    public partial class ApplicationUser {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Enabled { get; set; }
        
        public Nullable<System.DateTime> CreationDate { get; set; }        
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<System.DateTime> LastLoginDate { get; set; }
        public string LastUserAction { get; set; }
        
        public virtual ApplicationUser CreatedBy { get; set; }
        public virtual ApplicationUser UpdatedBy { get; set; }
        public virtual List<Role> Roles { get; set; }

        public ApplicationUser() {            
            this.Roles = new List<Role>();
        }

        public override string ToString() {
            return this.FirstName + " " + this.LastName;
        }

        public override bool Equals(object obj) {
            if (obj is ApplicationUser) {
                ApplicationUser user = (ApplicationUser)obj;
                return this.Id == user.Id;
            }

            return false;
        }

        public override int GetHashCode() {
            return 0;
        }

        
    }
}
