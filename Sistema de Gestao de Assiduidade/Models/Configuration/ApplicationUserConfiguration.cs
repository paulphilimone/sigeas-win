using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {

    public class ApplicationUserConfiguration : EntityTypeConfiguration<ApplicationUser> {

        public ApplicationUserConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

            this.Property(t => t.FirstName).IsRequired();
            this.Property(t => t.LastName).IsRequired();                        
            this.Property(t => t.Email).IsRequired();
            this.Property(t => t.LastUserAction);
            this.Property(t => t.UserName).IsRequired();
            this.Property(t => t.Password).IsRequired();

            // Relationships
            this.HasOptional(t => t.CreatedBy).WithMany();
            this.HasOptional(t => t.UpdatedBy).WithMany();

            this.HasMany(t => t.Roles).WithMany(t => t.ApplicationUsers);            

            
        }
    }
}
