using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {
    public class VerifyModeConfiguration : EntityTypeConfiguration<VerifyMode> {
        public VerifyModeConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name).IsRequired().HasMaxLength(1000);

            
        }
    }
}
