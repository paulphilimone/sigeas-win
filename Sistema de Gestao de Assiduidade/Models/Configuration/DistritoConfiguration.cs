using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {
    public class DistritoConfiguration : EntityTypeConfiguration<Distrito> {
        public DistritoConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome).IsRequired().HasMaxLength(1000);

            //Relationships
            this.HasOptional(t => t.Provincia).WithMany(t => t.Distritos);
            this.HasMany(t => t.PostoAdministrativos).WithOptional(t => t.Distrito);
        }
    }
}
