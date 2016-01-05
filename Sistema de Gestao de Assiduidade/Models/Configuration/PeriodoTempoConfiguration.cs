using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {
    public class PeriodoTempoConfiguration : EntityTypeConfiguration<PeriodoTempo> {
        public PeriodoTempoConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Descricao).IsRequired().HasMaxLength(1000);
                     
            //RelationsShips            
        }
    }
}
