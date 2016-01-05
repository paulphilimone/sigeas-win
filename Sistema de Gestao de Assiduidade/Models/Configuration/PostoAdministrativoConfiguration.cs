using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {
    public class PostoAdministrativoConfiguration : EntityTypeConfiguration<PostoAdministrativo> {
        public PostoAdministrativoConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome).IsRequired().HasMaxLength(1000);

            //Relationships
            this.HasMany(t => t.Localidades).WithOptional(t => t.PostoAdministrativo);
            this.HasOptional(t => t.Distrito).WithMany(t => t.PostoAdministrativos);
        }
    }
}
