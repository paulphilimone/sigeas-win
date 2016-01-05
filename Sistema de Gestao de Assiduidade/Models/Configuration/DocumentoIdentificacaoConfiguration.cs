using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {
    public class DocumentoIdentificacaoConfiguration : EntityTypeConfiguration<DocumentoIdentificacao> {
        public DocumentoIdentificacaoConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome).IsRequired().HasMaxLength(1000);
            this.Property(t => t.ExpressaoPadrao).HasMaxLength(1000);                                                

        }
    }
}
