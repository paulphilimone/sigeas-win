using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {
    public class DeviceGroupTimezoneConfiguration : EntityTypeConfiguration<DeviceGroupTimezone> {
        public DeviceGroupTimezoneConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name).HasMaxLength(1000);
                     
            // Relationships
            this.HasOptional(t => t.DeviceTimezone1).WithMany();                
            this.HasOptional(t => t.DeviceTimezone2).WithMany();
            this.HasOptional(t => t.DeviceTimezone3).WithMany();
        }
    }
}
