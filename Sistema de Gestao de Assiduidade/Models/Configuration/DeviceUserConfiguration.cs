using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {
    public class DeviceUserConfiguration : EntityTypeConfiguration<DeviceUser> {
        public DeviceUserConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
           

            // Relationships
            this.HasRequired(t => t.Device).WithMany(t => t.DeviceUsers);
            this.HasRequired(t => t.Funcionario).WithMany(t => t.DeviceUsers);
                

        }
    }
}
