using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {
    
    public class DepartamentoConfiguration : EntityTypeConfiguration<Departamento> {
        
        public DepartamentoConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties            
            this.Property(t => t.Descricao).IsRequired().HasMaxLength(255);
            this.Property(t => t.Nome).IsRequired().HasMaxLength(255);

            //Relationships
            this.HasOptional(t => t.CreatedBy).WithMany();
            this.HasOptional(t => t.UpdatedBy).WithMany();

            this.HasRequired(t => t.Empresa).WithMany(t => t.Departamentos);
            this.HasMany(t => t.Funcionarios).WithOptional(t => t.Departamento);
        }

    }
}
