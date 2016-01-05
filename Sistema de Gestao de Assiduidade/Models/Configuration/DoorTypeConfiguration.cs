using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration
{
    public class DoorTypeConfiguration : EntityTypeConfiguration<DoorType>
    {
        public DoorTypeConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties            
            //this.Property(t => t.Fingerprints);

            this.Property(t => t.Nome).IsRequired().HasMaxLength(255);

            
        }
    }
}
