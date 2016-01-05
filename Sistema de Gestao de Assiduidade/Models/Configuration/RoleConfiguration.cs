using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {
    public class RoleConfiguration : EntityTypeConfiguration<Role> {
        public RoleConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name).IsRequired().HasMaxLength(1000);                       

            // Relationships
            this.HasMany(t => t.ApplicationUsers).WithMany(t => t.Roles);
            this.HasMany(t => t.RolePermissions).WithMany(t => t.Roles);

        }
    }
}
