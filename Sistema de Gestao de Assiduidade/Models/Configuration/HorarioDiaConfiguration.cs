using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {
    public class HorarioDiaConfiguration : EntityTypeConfiguration<HorarioDia> {
        
        public HorarioDiaConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            
            // Relationships
            this.HasOptional(t => t.CreatedBy).WithMany();
            this.HasOptional(t => t.UpdatedBy).WithMany();
                        
            /*
            this.HasRequired(t => t.HorarioSemana).WithOptional(t => t.Domingo).WillCascadeOnDelete(true);
            this.HasRequired(t => t.HorarioSemana).WithOptional(t => t.Segunda).WillCascadeOnDelete(true);
            this.HasRequired(t => t.HorarioSemana).WithOptional(t => t.Terca).WillCascadeOnDelete(true); ;
            this.HasRequired(t => t.HorarioSemana).WithOptional(t => t.Quarta).WillCascadeOnDelete(true);
            this.HasRequired(t => t.HorarioSemana).WithOptional(t => t.Quinta).WillCascadeOnDelete(true);;
            this.HasRequired(t => t.HorarioSemana).WithOptional(t => t.Sexta).WillCascadeOnDelete(true); ;
            this.HasRequired(t => t.HorarioSemana).WithOptional(t => t.Sabado).WillCascadeOnDelete(true); ;
            */
            
        }
    }
}
