using mz.betainteractive.sigeas.Models.Entities;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace mz.betainteractive.sigeas.Models.Configuration {
    
    public class AttendanceRulesConfiguration : EntityTypeConfiguration<AttendanceRules> {
        public AttendanceRulesConfiguration() {
            // Primary Key
            this.HasKey(t => t.Id);

        }
    }
}
