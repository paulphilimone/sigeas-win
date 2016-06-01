using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration
{
    public class FuncionarioConfiguration : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioConfiguration()
        {
            this.ToTable("funcionario");

            // Primary Key
            //this.HasKey(t => t.Id);
            this.Property(t => t.Code).IsRequired();
            this.Property(t => t.Nome).IsRequired().HasMaxLength(255);
            //this.Property(t => t.Apelido).IsRequired().HasMaxLength(255); //we will use only name
            this.Property(t => t.AvenidaRua).HasMaxLength(255);
            this.Property(t => t.Bairro).HasMaxLength(1000);            
            this.Property(t => t.Email).HasMaxLength(255);                                    
            this.Property(t => t.NumeroDI).HasMaxLength(255);                        
            this.Property(t => t.Telefone).HasMaxLength(255);

            this.Property(t => t.Sexo).IsRequired().HasMaxLength(4);
            //this.Property(t => t.EstadoCivil).WithMany();
            //this.Property(t => t.DocumentoIdentificacao).WithMany();                    
                      

            // Relationships
            this.HasOptional(t => t.CreatedBy).WithMany();
            this.HasOptional(t => t.UpdatedBy).WithMany();

            //this.HasOptional(t => t.ContaCartao).WithRequired(t => t.Beneficiario).WillCascadeOnDelete(true);                       

            this.HasMany(t => t.DeviceUsers).WithRequired(t => t.Funcionario).WillCascadeOnDelete(true);
            this.HasMany(t => t.Ausencias).WithRequired(t => t.Funcionario).WillCascadeOnDelete(true);
            this.HasMany(t => t.Ferias).WithRequired(t => t.Funcionario).WillCascadeOnDelete(true);
            this.HasMany(t => t.UserClocks).WithRequired(t => t.Funcionario).WillCascadeOnDelete(true);
            this.HasMany(t => t.AttCalculos).WithRequired(t => t.Funcionario).WillCascadeOnDelete(true);
        }
    }
}
