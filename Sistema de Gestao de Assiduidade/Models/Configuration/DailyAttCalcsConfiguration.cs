using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {
    public class DailyAttCalcsConfiguration : EntityTypeConfiguration<DailyAttCalcs> {

        public DailyAttCalcsConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Relationships
            this.HasOptional(t => t.CreatedBy).WithMany();
            this.HasOptional(t => t.UpdatedBy).WithMany();
            this.HasRequired(t => t.Funcionario).WithMany(t => t.AttCalculos);
            this.HasRequired(t => t.HorarioDia).WithMany();
            this.HasRequired(t => t.Month);
        }
    }
}
