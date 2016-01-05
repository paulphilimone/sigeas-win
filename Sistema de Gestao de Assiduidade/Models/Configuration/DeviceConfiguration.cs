using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {
    public class DeviceConfiguration : EntityTypeConfiguration<Device> {
        public DeviceConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name).IsRequired().HasMaxLength(1000);
            this.Property(t => t.SerialNumber).HasMaxLength(1000);
            this.Property(t => t.IpAddress).IsRequired().HasMaxLength(1000);
                        
            // Relationships
            this.HasOptional(t => t.CreatedBy).WithMany();
            this.HasOptional(t => t.UpdatedBy).WithMany();
                        
            //this.HasOptional(t => t.RegisteredAutoCarro).WithOptionalDependent(t => t.RegisteredDevice);
            //this.HasOptional(t => t.RegisteredLocal).WithOptionalDependent(t => t.RegisteredDevice);
            
            this.HasMany(t => t.DeviceUsers).WithRequired(t => t.Device).WillCascadeOnDelete(true);
            this.HasMany(t => t.UserClocks).WithRequired(t => t.Device).WillCascadeOnDelete(true);
            
        }
    }
}
