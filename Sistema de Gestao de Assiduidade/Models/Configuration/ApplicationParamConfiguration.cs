using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {
    public class ApplicationParamConfiguration : EntityTypeConfiguration<ApplicationParam> {
        public ApplicationParamConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);
            
            this.Property(t => t.Name).IsRequired().HasMaxLength(255);
            this.Property(t => t.Type).IsRequired().HasMaxLength(255);
            this.Property(t => t.Value).IsRequired().HasMaxLength(255);
                        
            // Relationships
            this.HasOptional(t => t.CreatedBy).WithMany();
            this.HasOptional(t => t.UpdatedBy).WithMany();
        }
    }
}
