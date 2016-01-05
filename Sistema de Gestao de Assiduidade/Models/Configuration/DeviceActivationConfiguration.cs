using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration
{
    public class DeviceActivationConfiguration : EntityTypeConfiguration<DeviceActivation>
    {
        public DeviceActivationConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties            
            this.Property(t => t.Company).IsRequired().HasMaxLength(255);
            this.Property(t => t.ProductKey).IsRequired().HasMaxLength(255);

            
        }
    }
}
