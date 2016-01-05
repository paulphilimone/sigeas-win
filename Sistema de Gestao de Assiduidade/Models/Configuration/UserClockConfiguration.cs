using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {
    public class UserClockConfiguration : EntityTypeConfiguration<UserClock> {
        public UserClockConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CorrectState).HasMaxLength(1000);
            this.Property(t => t.Result).HasMaxLength(1000);
                        
            // Relationships
            this.HasOptional(t => t.CreatedBy).WithMany();                
            this.HasOptional(t => t.UpdatedBy).WithMany();
            this.HasRequired(t => t.Device).WithMany(t => t.UserClocks);
            this.HasOptional(t => t.InOutMode).WithMany();                            
            this.HasOptional(t => t.VerifyMode).WithMany();
            this.HasRequired(t => t.Funcionario).WithMany(t => t.UserClocks);
        }
    }
}
