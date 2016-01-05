using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models.Configuration {
    public class UserConfiguration : EntityTypeConfiguration<User> {
        public UserConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.UserName).HasMaxLength(1000);
            this.Property(t => t.Password).HasMaxLength(1000);
            this.Property(t => t.CardNumber).HasMaxLength(1000);

            this.ToTable("user");

            // Relationships
            this.HasOptional(t => t.DeviceGroupTimezone).WithMany(t => t.Users);
            this.HasOptional(t => t.DeviceTimezone1).WithMany();
            this.HasOptional(t => t.DeviceTimezone2).WithMany();
            this.HasOptional(t => t.DeviceTimezone3).WithMany();
            this.HasMany(t => t.UserFingerprints).WithRequired(t => t.User).WillCascadeOnDelete(true);

        }
    }
}
