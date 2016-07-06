using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration
{
    public class AusenciaConfiguration : EntityTypeConfiguration<Ausencia>
    {
        public AusenciaConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            
            this.Property(t => t.Motivo).HasMaxLength(1000);
            
            // Relationships
            this.HasOptional(t => t.CreatedBy).WithMany();
            this.HasOptional(t => t.UpdatedBy).WithMany();
            this.HasRequired(t => t.Funcionario).WithMany(t => t.Ausencias);
            this.HasRequired(t => t.Tipo).WithMany();
        }
    }
}
