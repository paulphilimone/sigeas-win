using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {
    public class MonthWorkConfiguration : EntityTypeConfiguration<MonthWork> {

        public MonthWorkConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Relationships            
            this.HasOptional(t => t.CreatedBy).WithMany();
            this.HasOptional(t => t.UpdatedBy).WithMany();            
        }
    }
}
