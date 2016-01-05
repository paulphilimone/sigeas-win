using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {

    public class EmpresaConfiguration : EntityTypeConfiguration<Empresa> {
        public EmpresaConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome).IsRequired().HasMaxLength(255);
            this.Property(t => t.AvenidaRua).HasMaxLength(255);
            //this.Property(t => t.Email).IsRequired().HasMaxLength(255);
            //this.Property(t => t.Fax).IsRequired().HasMaxLength(255);
            //this.Property(t => t.Numero);
            //this.Property(t => t.Telefone).IsRequired().HasMaxLength(255);

            // Relationships
            this.HasOptional(t => t.CreatedBy).WithMany();
            this.HasOptional(t => t.UpdatedBy).WithMany();                        

            this.HasMany(t => t.Departamentos).WithRequired(t => t.Empresa).WillCascadeOnDelete(true);
            this.HasMany(t => t.Categorias).WithRequired(t => t.Empresa).WillCascadeOnDelete(true);
        }
    }
}
