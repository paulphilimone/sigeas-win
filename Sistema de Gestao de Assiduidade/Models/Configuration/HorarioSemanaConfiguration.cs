using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration
{
    public class HorarioSemanaConfiguration : EntityTypeConfiguration<HorarioSemana>
    {
        public HorarioSemanaConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties            
            //this.Property(t => t.Codigo).IsRequired();
            this.Property(t => t.Descricao).IsRequired().HasMaxLength(255);


            // Relationships
            this.HasOptional(t => t.CreatedBy).WithMany();
            this.HasOptional(t => t.UpdatedBy).WithMany();

            this.HasMany(t => t.Dias).WithRequired(t => t.HorarioSemana).WillCascadeOnDelete(true);

            //this.HasOptional(t => t.Domingo).WithRequired(t => t.HorarioSemana).WillCascadeOnDelete(true);
            //this.HasOptional(t => t.Segunda).WithRequired(t => t.HorarioSemana).WillCascadeOnDelete(true);
            //this.HasOptional(t => t.Terca).WithRequired(t => t.HorarioSemana).WillCascadeOnDelete(true);
            //this.HasOptional(t => t.Quarta).WithRequired(t => t.HorarioSemana).WillCascadeOnDelete(true);
            //this.HasOptional(t => t.Quinta).WithRequired(t => t.HorarioSemana).WillCascadeOnDelete(true);
            //this.HasOptional(t => t.Sexta).WithRequired(t => t.HorarioSemana).WillCascadeOnDelete(true);
            //this.HasOptional(t => t.Sabado).WithRequired(t => t.HorarioSemana).WillCascadeOnDelete(true);
            
        }
    }
}
