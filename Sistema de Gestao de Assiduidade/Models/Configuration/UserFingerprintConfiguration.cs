using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {
    public class UserFingerprintConfiguration : EntityTypeConfiguration<UserFingerprint> {
        public UserFingerprintConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TemplateData).IsRequired().HasMaxLength(1073741823);

            
            // Relationships
            this.HasRequired(t => t.User).WithMany(t => t.UserFingerprints);

        }
    }
}
