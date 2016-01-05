using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {
    public class ProvinciaConfiguration : EntityTypeConfiguration<Provincia> {
        public ProvinciaConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome).IsRequired().HasMaxLength(1000);

            //Relationships
            this.HasMany(t => t.Distritos).WithOptional(t => t.Provincia);
        }
    }
}
