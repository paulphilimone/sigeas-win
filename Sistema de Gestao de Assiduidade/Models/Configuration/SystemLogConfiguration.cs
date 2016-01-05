using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration
{
    public class SystemLogConfiguration : EntityTypeConfiguration<SystemLog>  {
        public SystemLogConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties            
            this.Property(t => t.Description).IsRequired().HasMaxLength(255);
                        
            // Relationships
            this.HasOptional(t => t.User).WithMany();
        }
    }
}
