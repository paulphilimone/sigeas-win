using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {
    
    public class FuncionarioHorarioConfiguration : EntityTypeConfiguration<FuncionarioHorario> {
        
        public FuncionarioHorarioConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.HasRequired(t => t.Funcionario).WithMany();
            this.HasOptional(t => t.Horario).WithMany();
            this.HasOptional(t => t.Periodo).WithMany();            
        }
    }
}
