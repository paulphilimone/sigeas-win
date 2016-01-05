using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {
    public class LocalidadeConfiguration : EntityTypeConfiguration<Localidade> {
        public LocalidadeConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome).IsRequired().HasMaxLength(1000);

            //Relationships
            this.HasOptional(t => t.PostoAdministrativo).WithMany(t => t.Localidades);
        }
    }
}
