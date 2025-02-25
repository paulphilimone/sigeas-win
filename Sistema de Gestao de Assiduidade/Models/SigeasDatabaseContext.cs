
using mz.betainteractive.sigeas.Models.Configuration;
using System;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text.RegularExpressions;
using System.Reflection;
using mz.betainteractive.sigeas.Models.Override;
using MySql.Data.EntityFramework;
using System.Data.Entity;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Models {
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public partial class SigeasDatabaseContext : DbContext {
        static SigeasDatabaseContext() {
            DbConfiguration.SetConfiguration(new MySqlEFConfiguration());
            Database.SetInitializer<SigeasDatabaseContext>(new SigeasDatabaseInitializer());
        }

        public SigeasDatabaseContext() 
            : base("Name=sigeas_database_context_mysql_kserver") { //postgres or mysql here we can change the connection string

        }

        public DbSet<ApplicationParam> ApplicationParam { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<MonthWork> MonthWork { get; set; }
        public DbSet<DailyAttCalcs> DailyAttCalcs { get; set; }
        public DbSet<MonthlyAttCalcs> MonthlyAttCalcs { get; set; }
        public DbSet<AttendanceRules> AttendanceRules { get; set; }
        public DbSet<Ausencia> Ausencia { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Continente> Continente { get; set; }
        public DbSet<Pais> Countries { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Device> Device { get; set; }
        public DbSet<DeviceUser> DeviceUser { get; set; }
        public DbSet<DeviceActivation> DeviceActivation { get; set; }
        public DbSet<UserFingerprint> DeviceFingerprint { get; set; }
        public DbSet<DeviceTimezone> DeviceTimezone { get; set; }
        public DbSet<DeviceGroupTimezone> DeviceGroupTimezone { get; set; }
        public DbSet<DeviceType> DeviceType { get; set; }
        public DbSet<Distrito> Distrito { get; set; }
        //public DbSet<DocumentoIdentificacao> DocumentoIdentificacao { get; set; }
        public DbSet<Door> Door { get; set; }
        public DbSet<DoorType> DoorType { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        //public DbSet<EstadoCivil> EstadoCivil { get; set; }
        public DbSet<Feriado> Feriado { get; set; }
        public DbSet<Ferias> Ferias { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<FuncionarioHorario> FuncionarioHorario { get; set; }
        public DbSet<HorarioDia> HorarioDia { get; set; }
        public DbSet<HorarioSemana> HorarioSemana { get; set; }
        public DbSet<Localidade> Localidade { get; set; }
        public DbSet<PostoAdministrativo> PostoAdministrativo { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        //public DbSet<Sexo> Sexo { get; set; }
        public DbSet<SystemLog> SystemLog { get; set; }
        public DbSet<TipoAusencia> TipoAusencia { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserClock> UserClock { get; set; }
        public DbSet<InOutMode> InOutMode { get; set; }
        public DbSet<VerifyMode> VerifyMode { get; set; }
        public DbSet<RolePermission> RolePermission { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<PeriodoTempo> PeriodoTempo { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();                                    
            modelBuilder.Conventions.AddBefore<System.Data.Entity.ModelConfiguration.Conventions.ForeignKeyIndexConvention>(new ColumnNamingConvention());
            
            modelBuilder.Types().Configure(c => c.ToTable(GetColumnName(c.ClrType.Name)));
            modelBuilder.Properties().Configure(config => config.HasColumnName(GetColumnName(config.ClrPropertyInfo)));
            
            modelBuilder.Configurations.Add(new ApplicationParamConfiguration());
            modelBuilder.Configurations.Add(new ApplicationUserConfiguration());
            modelBuilder.Configurations.Add(new MonthWorkConfiguration());
            modelBuilder.Configurations.Add(new DailyAttCalcsConfiguration());
            modelBuilder.Configurations.Add(new MonthlyAttCalcsConfiguration());
            modelBuilder.Configurations.Add(new AttendanceRulesConfiguration());
            modelBuilder.Configurations.Add(new AusenciaConfiguration());
            modelBuilder.Configurations.Add(new CategoriaConfiguration());
            modelBuilder.Configurations.Add(new DepartamentoConfiguration());
            modelBuilder.Configurations.Add(new DeviceConfiguration());
            modelBuilder.Configurations.Add(new DeviceUserConfiguration());
            modelBuilder.Configurations.Add(new DeviceActivationConfiguration());
            modelBuilder.Configurations.Add(new DeviceTimezoneConfiguration());
            modelBuilder.Configurations.Add(new DeviceGroupTimezoneConfiguration());
            modelBuilder.Configurations.Add(new DeviceTypeConfiguration());
            //modelBuilder.Configurations.Add(new DocumentoIdentificacaoConfiguration());
            modelBuilder.Configurations.Add(new DoorConfiguration());
            modelBuilder.Configurations.Add(new DoorTypeConfiguration());
            modelBuilder.Configurations.Add(new EmpresaConfiguration());
            //modelBuilder.Configurations.Add(new EstadoCivilConfiguration());
            modelBuilder.Configurations.Add(new FeriadoConfiguration());
            modelBuilder.Configurations.Add(new FeriaConfiguration());
            modelBuilder.Configurations.Add(new FuncionarioConfiguration());
            modelBuilder.Configurations.Add(new FuncionarioHorarioConfiguration());
            modelBuilder.Configurations.Add(new HorarioDiaConfiguration());
            modelBuilder.Configurations.Add(new HorarioSemanaConfiguration());
            modelBuilder.Configurations.Add(new ContinenteConfiguration());
            modelBuilder.Configurations.Add(new PaisConfiguration());
            modelBuilder.Configurations.Add(new ProvinciaConfiguration());
            modelBuilder.Configurations.Add(new PostoAdministrativoConfiguration());
            modelBuilder.Configurations.Add(new LocalidadeConfiguration());
            modelBuilder.Configurations.Add(new DistritoConfiguration());
            modelBuilder.Configurations.Add(new PeriodoTempoConfiguration());
            //modelBuilder.Configurations.Add(new SexoConfiguration());
            modelBuilder.Configurations.Add(new SystemLogConfiguration());
            modelBuilder.Configurations.Add(new TipoAusenciaConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new UserClockConfiguration());
            modelBuilder.Configurations.Add(new UserFingerprintConfiguration());
            modelBuilder.Configurations.Add(new InOutModeConfiguration());
            modelBuilder.Configurations.Add(new VerifyModeConfiguration());
        }

        private static string GetColumnName(PropertyInfo property) {
            var result = "";
            result += Regex.Replace(property.Name, ".[A-Z]", m => m.Value[0] + "_" + m.Value[1]);

            return result.ToLower();
        }

        private static string GetColumnName(String property) {
            var result = "";
            result += Regex.Replace(property, ".[A-Z]", m => m.Value[0] + "_" + m.Value[1]);

            return result.ToLower();
        }

        private static string GetColumnNameWithTable(PropertyInfo property) {
            var result = property.DeclaringType.Name + "_";
            result += Regex.Replace(property.Name, ".[A-Z]", m => m.Value[0] + "_" + m.Value[1]);

            return result.ToLower();
        }
    }
}
