using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {
    public class DoorConfiguration : EntityTypeConfiguration<Door> {
        public DoorConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

            this.Property(t => t.Name).IsRequired();

            // Relationships
            //this.HasOptional(t => t.FirstDevice).WithOptionalPrincipal(t => t.Door);
            //this.HasOptional(t => t.SecondDevice).WithOptionalPrincipal(t => t.Door);
            
            this.HasMany(t => t.Devices).WithOptional(t => t.Door);

            this.HasOptional(t => t.Departamento).WithOptionalDependent(t => t.RegisteredDoor);

            this.HasOptional(t => t.CreatedBy).WithMany();
            this.HasOptional(t => t.UpdatedBy).WithMany();
        }
    }
}
