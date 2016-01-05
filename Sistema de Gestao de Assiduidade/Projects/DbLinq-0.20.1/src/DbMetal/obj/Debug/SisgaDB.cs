// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from beta_interactive_sisga on 2012-10-17 08:57:20Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//
namespace mz.betainteractive.sisga
{
	using System;
	using System.ComponentModel;
	using System.Data;
#if MONO_STRICT
	using System.Data.Linq;
#else   // MONO_STRICT
	using DbLinq.Data.Linq;
	using DbLinq.Vendor;
#endif  // MONO_STRICT
	using System.Data.Linq.Mapping;
	using System.Diagnostics;
	using mz.betainteractive.sisga.Properties;
	using MySql.Data.MySqlClient;
	
	
	public partial class BetaInteractiveSisga : DbLinq.MySql.MySqlDataContext
	{
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		#endregion
		
		
		public BetaInteractiveSisga() : 
				base(new MySqlConnection(Settings.Default.SisgaConnectionString))
		{
			this.OnCreated();
		}
		
		public Table<ApplicationParam> ApplicationParam
		{
			get
			{
				return this.GetTable<ApplicationParam>();
			}
		}
		
		public Table<ApplicationUser> ApplicationUser
		{
			get
			{
				return this.GetTable<ApplicationUser>();
			}
		}
		
		public Table<ApplicationUserRole> ApplicationUserRole
		{
			get
			{
				return this.GetTable<ApplicationUserRole>();
			}
		}
		
		public Table<AttCalcs> AttCalcs
		{
			get
			{
				return this.GetTable<AttCalcs>();
			}
		}
		
		public Table<AttendanceRules> AttendanceRules
		{
			get
			{
				return this.GetTable<AttendanceRules>();
			}
		}
		
		public Table<Categoria> Categoria
		{
			get
			{
				return this.GetTable<Categoria>();
			}
		}
		
		public Table<Continent> Continent
		{
			get
			{
				return this.GetTable<Continent>();
			}
		}
		
		public Table<Country> Country
		{
			get
			{
				return this.GetTable<Country>();
			}
		}
		
		public Table<Departamento> Departamento
		{
			get
			{
				return this.GetTable<Departamento>();
			}
		}
		
		public Table<Device> Device
		{
			get
			{
				return this.GetTable<Device>();
			}
		}
		
		public Table<DeviceAuthorization> DeviceAuthorization
		{
			get
			{
				return this.GetTable<DeviceAuthorization>();
			}
		}
		
		public Table<DeviceFingerprint> DeviceFingerprint
		{
			get
			{
				return this.GetTable<DeviceFingerprint>();
			}
		}
		
		public Table<DeviceTimeZone> DeviceTimeZone
		{
			get
			{
				return this.GetTable<DeviceTimeZone>();
			}
		}
		
		public Table<DeviceTimeZoneGroup> DeviceTimeZoneGroup
		{
			get
			{
				return this.GetTable<DeviceTimeZoneGroup>();
			}
		}
		
		public Table<DeviceType> DeviceType
		{
			get
			{
				return this.GetTable<DeviceType>();
			}
		}
		
		public Table<Distrito> Distrito
		{
			get
			{
				return this.GetTable<Distrito>();
			}
		}
		
		public Table<DocumentoIdentificacao> DocumentoIdentificacao
		{
			get
			{
				return this.GetTable<DocumentoIdentificacao>();
			}
		}
		
		public Table<Door> Door
		{
			get
			{
				return this.GetTable<Door>();
			}
		}
		
		public Table<DoorType> DoorType
		{
			get
			{
				return this.GetTable<DoorType>();
			}
		}
		
		public Table<Empresa> Empresa
		{
			get
			{
				return this.GetTable<Empresa>();
			}
		}
		
		public Table<EstadoCivil> EstadoCivil
		{
			get
			{
				return this.GetTable<EstadoCivil>();
			}
		}
		
		public Table<Falta> Falta
		{
			get
			{
				return this.GetTable<Falta>();
			}
		}
		
		public Table<Feriado> Feriado
		{
			get
			{
				return this.GetTable<Feriado>();
			}
		}
		
		public Table<Ferias> Ferias
		{
			get
			{
				return this.GetTable<Ferias>();
			}
		}
		
		public Table<Funcionario> Funcionario
		{
			get
			{
				return this.GetTable<Funcionario>();
			}
		}
		
		public Table<FuncionarioHorario> FuncionarioHorario
		{
			get
			{
				return this.GetTable<FuncionarioHorario>();
			}
		}
		
		public Table<HorarioDia> HorarioDia
		{
			get
			{
				return this.GetTable<HorarioDia>();
			}
		}
		
		public Table<HorarioSemana> HorarioSemana
		{
			get
			{
				return this.GetTable<HorarioSemana>();
			}
		}
		
		public Table<Localidade> Localidade
		{
			get
			{
				return this.GetTable<Localidade>();
			}
		}
		
		public Table<MesAno> MesAno
		{
			get
			{
				return this.GetTable<MesAno>();
			}
		}
		
		public Table<PostoAdministrativo> PostoAdministrativo
		{
			get
			{
				return this.GetTable<PostoAdministrativo>();
			}
		}
		
		public Table<Provincia> Provincia
		{
			get
			{
				return this.GetTable<Provincia>();
			}
		}
		
		public Table<RegistrationCode> RegistrationCode
		{
			get
			{
				return this.GetTable<RegistrationCode>();
			}
		}
		
		public Table<Role> Role
		{
			get
			{
				return this.GetTable<Role>();
			}
		}
		
		public Table<SecurityMap> SecurityMap
		{
			get
			{
				return this.GetTable<SecurityMap>();
			}
		}
		
		public Table<SemanaAno> SemanaAno
		{
			get
			{
				return this.GetTable<SemanaAno>();
			}
		}
		
		public Table<Sexo> Sexo
		{
			get
			{
				return this.GetTable<Sexo>();
			}
		}
		
		public Table<SystemLog> SystemLog
		{
			get
			{
				return this.GetTable<SystemLog>();
			}
		}
		
		public Table<TipoFalta> TipoFalta
		{
			get
			{
				return this.GetTable<TipoFalta>();
			}
		}
		
		public Table<UserClock> UserClock
		{
			get
			{
				return this.GetTable<UserClock>();
			}
		}
		
		public Table<UserClockState> UserClockState
		{
			get
			{
				return this.GetTable<UserClockState>();
			}
		}
		
		public Table<UserClockVerifyMode> UserClockVerifyMode
		{
			get
			{
				return this.GetTable<UserClockVerifyMode>();
			}
		}
	}
	
	[Table(Name="beta_interactive_sisga.application_param")]
	public partial class ApplicationParam : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<long> _createdByID;
		
		private System.Nullable<System.DateTime> _creationDate;
		
		private long _id;
		
		private string _name;
		
		private string _type;
		
		private System.Nullable<long> _updatedByID;
		
		private System.Nullable<System.DateTime> _updatedDate;
		
		private string _value;
		
		private long _version;
		
		private EntityRef<ApplicationUser> _applicationUser = new EntityRef<ApplicationUser>();
		
		private EntityRef<ApplicationUser> _applicationUser1 = new EntityRef<ApplicationUser>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedByIDChanged();
		
		partial void OnCreatedByIDChanging(System.Nullable<long> value);
		
		partial void OnCreationDateChanged();
		
		partial void OnCreationDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnTypeChanged();
		
		partial void OnTypeChanging(string value);
		
		partial void OnUpdatedByIDChanged();
		
		partial void OnUpdatedByIDChanging(System.Nullable<long> value);
		
		partial void OnUpdatedDateChanged();
		
		partial void OnUpdatedDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(string value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public ApplicationParam()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdByID", Name="created_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CreatedByID
		{
			get
			{
				return this._createdByID;
			}
			set
			{
				if ((_createdByID != value))
				{
					this.OnCreatedByIDChanging(value);
					this.SendPropertyChanging();
					this._createdByID = value;
					this.SendPropertyChanged("CreatedByID");
					this.OnCreatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_creationDate", Name="creation_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreationDate
		{
			get
			{
				return this._creationDate;
			}
			set
			{
				if ((_creationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._creationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_type", Name="type", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				if (((_type == value) 
							== false))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[Column(Storage="_updatedByID", Name="updated_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UpdatedByID
		{
			get
			{
				return this._updatedByID;
			}
			set
			{
				if ((_updatedByID != value))
				{
					this.OnUpdatedByIDChanging(value);
					this.SendPropertyChanging();
					this._updatedByID = value;
					this.SendPropertyChanged("UpdatedByID");
					this.OnUpdatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedDate", Name="updated_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> UpdatedDate
		{
			get
			{
				return this._updatedDate;
			}
			set
			{
				if ((_updatedDate != value))
				{
					this.OnUpdatedDateChanging(value);
					this.SendPropertyChanging();
					this._updatedDate = value;
					this.SendPropertyChanged("UpdatedDate");
					this.OnUpdatedDateChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="value", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if (((_value == value) 
							== false))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_applicationUser", OtherKey="ID", ThisKey="UpdatedByID", Name="FK13344DE13D9D401", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser
		{
			get
			{
				return this._applicationUser.Entity;
			}
			set
			{
				if (((this._applicationUser.Entity == value) 
							== false))
				{
					if ((this._applicationUser.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser.Entity;
						this._applicationUser.Entity = null;
						previousApplicationUser.ApplicationParam.Remove(this);
					}
					this._applicationUser.Entity = value;
					if ((value != null))
					{
						value.ApplicationParam.Add(this);
						_updatedByID = value.ID;
					}
					else
					{
						_updatedByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_applicationUser1", OtherKey="ID", ThisKey="CreatedByID", Name="FK13344DEF2EB5C6E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser1
		{
			get
			{
				return this._applicationUser1.Entity;
			}
			set
			{
				if (((this._applicationUser1.Entity == value) 
							== false))
				{
					if ((this._applicationUser1.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser1.Entity;
						this._applicationUser1.Entity = null;
						previousApplicationUser.ApplicationParam1.Remove(this);
					}
					this._applicationUser1.Entity = value;
					if ((value != null))
					{
						value.ApplicationParam1.Add(this);
						_createdByID = value.ID;
					}
					else
					{
						_createdByID = null;
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="beta_interactive_sisga.application_user")]
	public partial class ApplicationUser : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private bool _accountExpired;
		
		private bool _accountLocked;
		
		private System.DateTime _birthDate;
		
		private bool _enabled;
		
		private string _fullName;
		
		private long _id;
		
		private bool _isOnlyAppUser;
		
		private System.Nullable<System.DateTime> _lastLoginDate;
		
		private string _lastUserAction;
		
		private string _password;
		
		private bool _passwordExpired;
		
		private long _permission;
		
		private System.Nullable<long> _userCreatedByID;
		
		private System.Nullable<System.DateTime> _userCreationDate;
		
		private string _userEmail;
		
		private string _userName;
		
		private long _userSexoID;
		
		private System.Nullable<long> _userUpdatedByID;
		
		private System.Nullable<System.DateTime> _userUpdatedDate;
		
		private long _version;
		
		private EntitySet<AttendanceRules> _attendanceRules;
		
		private EntitySet<AttendanceRules> _attendanceRules1;
		
		private EntitySet<ApplicationParam> _applicationParam;
		
		private EntitySet<ApplicationParam> _applicationParam1;
		
		private EntitySet<HorarioSemana> _horarioSemana;
		
		private EntitySet<HorarioSemana> _horarioSemana1;
		
		private EntitySet<HorarioDia> _horarioDia;
		
		private EntitySet<HorarioDia> _horarioDia1;
		
		private EntitySet<SystemLog> _systemLog;
		
		private EntitySet<Door> _door;
		
		private EntitySet<Door> _door1;
		
		private EntitySet<Funcionario> _funcionario;
		
		private EntitySet<Funcionario> _funcionario1;
		
		private EntitySet<DeviceTimeZoneGroup> _deviceTimeZoneGroup;
		
		private EntitySet<DeviceTimeZoneGroup> _deviceTimeZoneGroup1;
		
		private EntitySet<Falta> _falta;
		
		private EntitySet<Falta> _falta1;
		
		private EntitySet<Categoria> _categoria;
		
		private EntitySet<Categoria> _categoria1;
		
		private EntitySet<DeviceFingerprint> _deviceFingerprint;
		
		private EntitySet<DeviceFingerprint> _deviceFingerprint1;
		
		private EntitySet<UserClock> _userClock;
		
		private EntitySet<UserClock> _userClock1;
		
		private EntitySet<ApplicationUserRole> _applicationUserRole;
		
		private EntitySet<Empresa> _empresa;
		
		private EntitySet<Empresa> _empresa1;
		
		private EntitySet<Device> _device;
		
		private EntitySet<Device> _device1;
		
		private EntitySet<Ferias> _ferias;
		
		private EntitySet<Ferias> _ferias1;
		
		private EntitySet<Departamento> _departamento;
		
		private EntitySet<Departamento> _departamento1;
		
		private EntitySet<Feriado> _feriado;
		
		private EntitySet<Feriado> _feriado1;
		
		private EntitySet<ApplicationUser> _idaPplicationUser;
		
		private EntitySet<ApplicationUser> _idaPplicationUser1;
		
		private EntitySet<DeviceTimeZone> _deviceTimeZone;
		
		private EntitySet<DeviceTimeZone> _deviceTimeZone1;
		
		private EntitySet<AttCalcs> _attCalcs;
		
		private EntitySet<AttCalcs> _attCalcs1;
		
		private EntityRef<ApplicationUser> _userCreatedByIdaPplicationUser = new EntityRef<ApplicationUser>();
		
		private EntityRef<ApplicationUser> _userUpdatedByIdaPplicationUser = new EntityRef<ApplicationUser>();
		
		private EntityRef<Sexo> _sexo = new EntityRef<Sexo>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAccountExpiredChanged();
		
		partial void OnAccountExpiredChanging(bool value);
		
		partial void OnAccountLockedChanged();
		
		partial void OnAccountLockedChanging(bool value);
		
		partial void OnBirthDateChanged();
		
		partial void OnBirthDateChanging(System.DateTime value);
		
		partial void OnEnabledChanged();
		
		partial void OnEnabledChanging(bool value);
		
		partial void OnFullNameChanged();
		
		partial void OnFullNameChanging(string value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnIsOnlyAppUserChanged();
		
		partial void OnIsOnlyAppUserChanging(bool value);
		
		partial void OnLastLoginDateChanged();
		
		partial void OnLastLoginDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnLastUserActionChanged();
		
		partial void OnLastUserActionChanging(string value);
		
		partial void OnPasswordChanged();
		
		partial void OnPasswordChanging(string value);
		
		partial void OnPasswordExpiredChanged();
		
		partial void OnPasswordExpiredChanging(bool value);
		
		partial void OnPermissionChanged();
		
		partial void OnPermissionChanging(long value);
		
		partial void OnUserCreatedByIDChanged();
		
		partial void OnUserCreatedByIDChanging(System.Nullable<long> value);
		
		partial void OnUserCreationDateChanged();
		
		partial void OnUserCreationDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnUserEmailChanged();
		
		partial void OnUserEmailChanging(string value);
		
		partial void OnUserNameChanged();
		
		partial void OnUserNameChanging(string value);
		
		partial void OnUserSexoIDChanged();
		
		partial void OnUserSexoIDChanging(long value);
		
		partial void OnUserUpdatedByIDChanged();
		
		partial void OnUserUpdatedByIDChanging(System.Nullable<long> value);
		
		partial void OnUserUpdatedDateChanged();
		
		partial void OnUserUpdatedDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public ApplicationUser()
		{
			_attendanceRules = new EntitySet<AttendanceRules>(new Action<AttendanceRules>(this.AttendanceRules_Attach), new Action<AttendanceRules>(this.AttendanceRules_Detach));
			_attendanceRules1 = new EntitySet<AttendanceRules>(new Action<AttendanceRules>(this.AttendanceRules1_Attach), new Action<AttendanceRules>(this.AttendanceRules1_Detach));
			_applicationParam = new EntitySet<ApplicationParam>(new Action<ApplicationParam>(this.ApplicationParam_Attach), new Action<ApplicationParam>(this.ApplicationParam_Detach));
			_applicationParam1 = new EntitySet<ApplicationParam>(new Action<ApplicationParam>(this.ApplicationParam1_Attach), new Action<ApplicationParam>(this.ApplicationParam1_Detach));
			_horarioSemana = new EntitySet<HorarioSemana>(new Action<HorarioSemana>(this.HorarioSemana_Attach), new Action<HorarioSemana>(this.HorarioSemana_Detach));
			_horarioSemana1 = new EntitySet<HorarioSemana>(new Action<HorarioSemana>(this.HorarioSemana1_Attach), new Action<HorarioSemana>(this.HorarioSemana1_Detach));
			_horarioDia = new EntitySet<HorarioDia>(new Action<HorarioDia>(this.HorarioDia_Attach), new Action<HorarioDia>(this.HorarioDia_Detach));
			_horarioDia1 = new EntitySet<HorarioDia>(new Action<HorarioDia>(this.HorarioDia1_Attach), new Action<HorarioDia>(this.HorarioDia1_Detach));
			_systemLog = new EntitySet<SystemLog>(new Action<SystemLog>(this.SystemLog_Attach), new Action<SystemLog>(this.SystemLog_Detach));
			_door = new EntitySet<Door>(new Action<Door>(this.Door_Attach), new Action<Door>(this.Door_Detach));
			_door1 = new EntitySet<Door>(new Action<Door>(this.Door1_Attach), new Action<Door>(this.Door1_Detach));
			_funcionario = new EntitySet<Funcionario>(new Action<Funcionario>(this.Funcionario_Attach), new Action<Funcionario>(this.Funcionario_Detach));
			_funcionario1 = new EntitySet<Funcionario>(new Action<Funcionario>(this.Funcionario1_Attach), new Action<Funcionario>(this.Funcionario1_Detach));
			_deviceTimeZoneGroup = new EntitySet<DeviceTimeZoneGroup>(new Action<DeviceTimeZoneGroup>(this.DeviceTimeZoneGroup_Attach), new Action<DeviceTimeZoneGroup>(this.DeviceTimeZoneGroup_Detach));
			_deviceTimeZoneGroup1 = new EntitySet<DeviceTimeZoneGroup>(new Action<DeviceTimeZoneGroup>(this.DeviceTimeZoneGroup1_Attach), new Action<DeviceTimeZoneGroup>(this.DeviceTimeZoneGroup1_Detach));
			_falta = new EntitySet<Falta>(new Action<Falta>(this.Falta_Attach), new Action<Falta>(this.Falta_Detach));
			_falta1 = new EntitySet<Falta>(new Action<Falta>(this.Falta1_Attach), new Action<Falta>(this.Falta1_Detach));
			_categoria = new EntitySet<Categoria>(new Action<Categoria>(this.Categoria_Attach), new Action<Categoria>(this.Categoria_Detach));
			_categoria1 = new EntitySet<Categoria>(new Action<Categoria>(this.Categoria1_Attach), new Action<Categoria>(this.Categoria1_Detach));
			_deviceFingerprint = new EntitySet<DeviceFingerprint>(new Action<DeviceFingerprint>(this.DeviceFingerprint_Attach), new Action<DeviceFingerprint>(this.DeviceFingerprint_Detach));
			_deviceFingerprint1 = new EntitySet<DeviceFingerprint>(new Action<DeviceFingerprint>(this.DeviceFingerprint1_Attach), new Action<DeviceFingerprint>(this.DeviceFingerprint1_Detach));
			_userClock = new EntitySet<UserClock>(new Action<UserClock>(this.UserClock_Attach), new Action<UserClock>(this.UserClock_Detach));
			_userClock1 = new EntitySet<UserClock>(new Action<UserClock>(this.UserClock1_Attach), new Action<UserClock>(this.UserClock1_Detach));
			_applicationUserRole = new EntitySet<ApplicationUserRole>(new Action<ApplicationUserRole>(this.ApplicationUserRole_Attach), new Action<ApplicationUserRole>(this.ApplicationUserRole_Detach));
			_empresa = new EntitySet<Empresa>(new Action<Empresa>(this.Empresa_Attach), new Action<Empresa>(this.Empresa_Detach));
			_empresa1 = new EntitySet<Empresa>(new Action<Empresa>(this.Empresa1_Attach), new Action<Empresa>(this.Empresa1_Detach));
			_device = new EntitySet<Device>(new Action<Device>(this.Device_Attach), new Action<Device>(this.Device_Detach));
			_device1 = new EntitySet<Device>(new Action<Device>(this.Device1_Attach), new Action<Device>(this.Device1_Detach));
			_ferias = new EntitySet<Ferias>(new Action<Ferias>(this.Ferias_Attach), new Action<Ferias>(this.Ferias_Detach));
			_ferias1 = new EntitySet<Ferias>(new Action<Ferias>(this.Ferias1_Attach), new Action<Ferias>(this.Ferias1_Detach));
			_departamento = new EntitySet<Departamento>(new Action<Departamento>(this.Departamento_Attach), new Action<Departamento>(this.Departamento_Detach));
			_departamento1 = new EntitySet<Departamento>(new Action<Departamento>(this.Departamento1_Attach), new Action<Departamento>(this.Departamento1_Detach));
			_feriado = new EntitySet<Feriado>(new Action<Feriado>(this.Feriado_Attach), new Action<Feriado>(this.Feriado_Detach));
			_feriado1 = new EntitySet<Feriado>(new Action<Feriado>(this.Feriado1_Attach), new Action<Feriado>(this.Feriado1_Detach));
			_idaPplicationUser = new EntitySet<ApplicationUser>(new Action<ApplicationUser>(this.IDApplicationUser_Attach), new Action<ApplicationUser>(this.IDApplicationUser_Detach));
			_idaPplicationUser1 = new EntitySet<ApplicationUser>(new Action<ApplicationUser>(this.IDApplicationUser1_Attach), new Action<ApplicationUser>(this.IDApplicationUser1_Detach));
			_deviceTimeZone = new EntitySet<DeviceTimeZone>(new Action<DeviceTimeZone>(this.DeviceTimeZone_Attach), new Action<DeviceTimeZone>(this.DeviceTimeZone_Detach));
			_deviceTimeZone1 = new EntitySet<DeviceTimeZone>(new Action<DeviceTimeZone>(this.DeviceTimeZone1_Attach), new Action<DeviceTimeZone>(this.DeviceTimeZone1_Detach));
			_attCalcs = new EntitySet<AttCalcs>(new Action<AttCalcs>(this.AttCalcs_Attach), new Action<AttCalcs>(this.AttCalcs_Detach));
			_attCalcs1 = new EntitySet<AttCalcs>(new Action<AttCalcs>(this.AttCalcs1_Attach), new Action<AttCalcs>(this.AttCalcs1_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_accountExpired", Name="account_expired", DbType="bit(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool AccountExpired
		{
			get
			{
				return this._accountExpired;
			}
			set
			{
				if ((_accountExpired != value))
				{
					this.OnAccountExpiredChanging(value);
					this.SendPropertyChanging();
					this._accountExpired = value;
					this.SendPropertyChanged("AccountExpired");
					this.OnAccountExpiredChanged();
				}
			}
		}
		
		[Column(Storage="_accountLocked", Name="account_locked", DbType="bit(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool AccountLocked
		{
			get
			{
				return this._accountLocked;
			}
			set
			{
				if ((_accountLocked != value))
				{
					this.OnAccountLockedChanging(value);
					this.SendPropertyChanging();
					this._accountLocked = value;
					this.SendPropertyChanged("AccountLocked");
					this.OnAccountLockedChanged();
				}
			}
		}
		
		[Column(Storage="_birthDate", Name="birth_date", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime BirthDate
		{
			get
			{
				return this._birthDate;
			}
			set
			{
				if ((_birthDate != value))
				{
					this.OnBirthDateChanging(value);
					this.SendPropertyChanging();
					this._birthDate = value;
					this.SendPropertyChanged("BirthDate");
					this.OnBirthDateChanged();
				}
			}
		}
		
		[Column(Storage="_enabled", Name="enabled", DbType="bit(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				if ((_enabled != value))
				{
					this.OnEnabledChanging(value);
					this.SendPropertyChanging();
					this._enabled = value;
					this.SendPropertyChanged("Enabled");
					this.OnEnabledChanged();
				}
			}
		}
		
		[Column(Storage="_fullName", Name="full_name", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string FullName
		{
			get
			{
				return this._fullName;
			}
			set
			{
				if (((_fullName == value) 
							== false))
				{
					this.OnFullNameChanging(value);
					this.SendPropertyChanging();
					this._fullName = value;
					this.SendPropertyChanged("FullName");
					this.OnFullNameChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_isOnlyAppUser", Name="is_only_app_user", DbType="bit(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool IsOnlyAppUser
		{
			get
			{
				return this._isOnlyAppUser;
			}
			set
			{
				if ((_isOnlyAppUser != value))
				{
					this.OnIsOnlyAppUserChanging(value);
					this.SendPropertyChanging();
					this._isOnlyAppUser = value;
					this.SendPropertyChanged("IsOnlyAppUser");
					this.OnIsOnlyAppUserChanged();
				}
			}
		}
		
		[Column(Storage="_lastLoginDate", Name="last_login_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastLoginDate
		{
			get
			{
				return this._lastLoginDate;
			}
			set
			{
				if ((_lastLoginDate != value))
				{
					this.OnLastLoginDateChanging(value);
					this.SendPropertyChanging();
					this._lastLoginDate = value;
					this.SendPropertyChanged("LastLoginDate");
					this.OnLastLoginDateChanged();
				}
			}
		}
		
		[Column(Storage="_lastUserAction", Name="last_user_action", DbType="varchar(255)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LastUserAction
		{
			get
			{
				return this._lastUserAction;
			}
			set
			{
				if (((_lastUserAction == value) 
							== false))
				{
					this.OnLastUserActionChanging(value);
					this.SendPropertyChanging();
					this._lastUserAction = value;
					this.SendPropertyChanged("LastUserAction");
					this.OnLastUserActionChanged();
				}
			}
		}
		
		[Column(Storage="_password", Name="password", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Password
		{
			get
			{
				return this._password;
			}
			set
			{
				if (((_password == value) 
							== false))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[Column(Storage="_passwordExpired", Name="password_expired", DbType="bit(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool PasswordExpired
		{
			get
			{
				return this._passwordExpired;
			}
			set
			{
				if ((_passwordExpired != value))
				{
					this.OnPasswordExpiredChanging(value);
					this.SendPropertyChanging();
					this._passwordExpired = value;
					this.SendPropertyChanged("PasswordExpired");
					this.OnPasswordExpiredChanged();
				}
			}
		}
		
		[Column(Storage="_permission", Name="permission", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Permission
		{
			get
			{
				return this._permission;
			}
			set
			{
				if ((_permission != value))
				{
					this.OnPermissionChanging(value);
					this.SendPropertyChanging();
					this._permission = value;
					this.SendPropertyChanged("Permission");
					this.OnPermissionChanged();
				}
			}
		}
		
		[Column(Storage="_userCreatedByID", Name="user_created_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UserCreatedByID
		{
			get
			{
				return this._userCreatedByID;
			}
			set
			{
				if ((_userCreatedByID != value))
				{
					this.OnUserCreatedByIDChanging(value);
					this.SendPropertyChanging();
					this._userCreatedByID = value;
					this.SendPropertyChanged("UserCreatedByID");
					this.OnUserCreatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_userCreationDate", Name="user_creation_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> UserCreationDate
		{
			get
			{
				return this._userCreationDate;
			}
			set
			{
				if ((_userCreationDate != value))
				{
					this.OnUserCreationDateChanging(value);
					this.SendPropertyChanging();
					this._userCreationDate = value;
					this.SendPropertyChanged("UserCreationDate");
					this.OnUserCreationDateChanged();
				}
			}
		}
		
		[Column(Storage="_userEmail", Name="user_email", DbType="varchar(255)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UserEmail
		{
			get
			{
				return this._userEmail;
			}
			set
			{
				if (((_userEmail == value) 
							== false))
				{
					this.OnUserEmailChanging(value);
					this.SendPropertyChanging();
					this._userEmail = value;
					this.SendPropertyChanged("UserEmail");
					this.OnUserEmailChanged();
				}
			}
		}
		
		[Column(Storage="_userName", Name="username", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string UserName
		{
			get
			{
				return this._userName;
			}
			set
			{
				if (((_userName == value) 
							== false))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._userName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[Column(Storage="_userSexoID", Name="user_sexo_id", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long UserSexoID
		{
			get
			{
				return this._userSexoID;
			}
			set
			{
				if ((_userSexoID != value))
				{
					this.OnUserSexoIDChanging(value);
					this.SendPropertyChanging();
					this._userSexoID = value;
					this.SendPropertyChanged("UserSexoID");
					this.OnUserSexoIDChanged();
				}
			}
		}
		
		[Column(Storage="_userUpdatedByID", Name="user_updated_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UserUpdatedByID
		{
			get
			{
				return this._userUpdatedByID;
			}
			set
			{
				if ((_userUpdatedByID != value))
				{
					this.OnUserUpdatedByIDChanging(value);
					this.SendPropertyChanging();
					this._userUpdatedByID = value;
					this.SendPropertyChanged("UserUpdatedByID");
					this.OnUserUpdatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_userUpdatedDate", Name="user_updated_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> UserUpdatedDate
		{
			get
			{
				return this._userUpdatedDate;
			}
			set
			{
				if ((_userUpdatedDate != value))
				{
					this.OnUserUpdatedDateChanging(value);
					this.SendPropertyChanging();
					this._userUpdatedDate = value;
					this.SendPropertyChanged("UserUpdatedDate");
					this.OnUserUpdatedDateChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_attendanceRules", OtherKey="UpdatedByID", ThisKey="ID", Name="FK124BFC2113D9D401")]
		[DebuggerNonUserCode()]
		public EntitySet<AttendanceRules> AttendanceRules
		{
			get
			{
				return this._attendanceRules;
			}
			set
			{
				this._attendanceRules = value;
			}
		}
		
		[Association(Storage="_attendanceRules1", OtherKey="CreatedByID", ThisKey="ID", Name="FK124BFC21F2EB5C6E")]
		[DebuggerNonUserCode()]
		public EntitySet<AttendanceRules> AttendanceRules1
		{
			get
			{
				return this._attendanceRules1;
			}
			set
			{
				this._attendanceRules1 = value;
			}
		}
		
		[Association(Storage="_applicationParam", OtherKey="UpdatedByID", ThisKey="ID", Name="FK13344DE13D9D401")]
		[DebuggerNonUserCode()]
		public EntitySet<ApplicationParam> ApplicationParam
		{
			get
			{
				return this._applicationParam;
			}
			set
			{
				this._applicationParam = value;
			}
		}
		
		[Association(Storage="_applicationParam1", OtherKey="CreatedByID", ThisKey="ID", Name="FK13344DEF2EB5C6E")]
		[DebuggerNonUserCode()]
		public EntitySet<ApplicationParam> ApplicationParam1
		{
			get
			{
				return this._applicationParam1;
			}
			set
			{
				this._applicationParam1 = value;
			}
		}
		
		[Association(Storage="_horarioSemana", OtherKey="UpdatedByID", ThisKey="ID", Name="FK13850E9613D9D401")]
		[DebuggerNonUserCode()]
		public EntitySet<HorarioSemana> HorarioSemana
		{
			get
			{
				return this._horarioSemana;
			}
			set
			{
				this._horarioSemana = value;
			}
		}
		
		[Association(Storage="_horarioSemana1", OtherKey="CreatedByID", ThisKey="ID", Name="FK13850E96F2EB5C6E")]
		[DebuggerNonUserCode()]
		public EntitySet<HorarioSemana> HorarioSemana1
		{
			get
			{
				return this._horarioSemana1;
			}
			set
			{
				this._horarioSemana1 = value;
			}
		}
		
		[Association(Storage="_horarioDia", OtherKey="UpdatedByID", ThisKey="ID", Name="FK13883A9F13D9D401")]
		[DebuggerNonUserCode()]
		public EntitySet<HorarioDia> HorarioDia
		{
			get
			{
				return this._horarioDia;
			}
			set
			{
				this._horarioDia = value;
			}
		}
		
		[Association(Storage="_horarioDia1", OtherKey="CreatedByID", ThisKey="ID", Name="FK13883A9FF2EB5C6E")]
		[DebuggerNonUserCode()]
		public EntitySet<HorarioDia> HorarioDia1
		{
			get
			{
				return this._horarioDia1;
			}
			set
			{
				this._horarioDia1 = value;
			}
		}
		
		[Association(Storage="_systemLog", OtherKey="UserID", ThisKey="ID", Name="FK2656953475CEC491")]
		[DebuggerNonUserCode()]
		public EntitySet<SystemLog> SystemLog
		{
			get
			{
				return this._systemLog;
			}
			set
			{
				this._systemLog = value;
			}
		}
		
		[Association(Storage="_door", OtherKey="UpdatedByID", ThisKey="ID", Name="FK2F23AE13D9D401")]
		[DebuggerNonUserCode()]
		public EntitySet<Door> Door
		{
			get
			{
				return this._door;
			}
			set
			{
				this._door = value;
			}
		}
		
		[Association(Storage="_door1", OtherKey="CreatedByID", ThisKey="ID", Name="FK2F23AEF2EB5C6E")]
		[DebuggerNonUserCode()]
		public EntitySet<Door> Door1
		{
			get
			{
				return this._door1;
			}
			set
			{
				this._door1 = value;
			}
		}
		
		[Association(Storage="_funcionario", OtherKey="UpdatedByID", ThisKey="ID", Name="FK50401DDB13D9D401")]
		[DebuggerNonUserCode()]
		public EntitySet<Funcionario> Funcionario
		{
			get
			{
				return this._funcionario;
			}
			set
			{
				this._funcionario = value;
			}
		}
		
		[Association(Storage="_funcionario1", OtherKey="CreatedByID", ThisKey="ID", Name="FK50401DDBF2EB5C6E")]
		[DebuggerNonUserCode()]
		public EntitySet<Funcionario> Funcionario1
		{
			get
			{
				return this._funcionario1;
			}
			set
			{
				this._funcionario1 = value;
			}
		}
		
		[Association(Storage="_deviceTimeZoneGroup", OtherKey="UpdatedByID", ThisKey="ID", Name="FK52FD1BC213D9D401")]
		[DebuggerNonUserCode()]
		public EntitySet<DeviceTimeZoneGroup> DeviceTimeZoneGroup
		{
			get
			{
				return this._deviceTimeZoneGroup;
			}
			set
			{
				this._deviceTimeZoneGroup = value;
			}
		}
		
		[Association(Storage="_deviceTimeZoneGroup1", OtherKey="CreatedByID", ThisKey="ID", Name="FK52FD1BC2F2EB5C6E")]
		[DebuggerNonUserCode()]
		public EntitySet<DeviceTimeZoneGroup> DeviceTimeZoneGroup1
		{
			get
			{
				return this._deviceTimeZoneGroup1;
			}
			set
			{
				this._deviceTimeZoneGroup1 = value;
			}
		}
		
		[Association(Storage="_falta", OtherKey="AcceptedConfirmedBy1ID", ThisKey="ID", Name="FK5CB193E4452BDBA")]
		[DebuggerNonUserCode()]
		public EntitySet<Falta> Falta
		{
			get
			{
				return this._falta;
			}
			set
			{
				this._falta = value;
			}
		}
		
		[Association(Storage="_falta1", OtherKey="AcceptedConfirmedBy2ID", ThisKey="ID", Name="FK5CB193E44533219")]
		[DebuggerNonUserCode()]
		public EntitySet<Falta> Falta1
		{
			get
			{
				return this._falta1;
			}
			set
			{
				this._falta1 = value;
			}
		}
		
		[Association(Storage="_categoria", OtherKey="UpdatedByID", ThisKey="ID", Name="FK5D54E13313D9D401")]
		[DebuggerNonUserCode()]
		public EntitySet<Categoria> Categoria
		{
			get
			{
				return this._categoria;
			}
			set
			{
				this._categoria = value;
			}
		}
		
		[Association(Storage="_categoria1", OtherKey="CreatedByID", ThisKey="ID", Name="FK5D54E133F2EB5C6E")]
		[DebuggerNonUserCode()]
		public EntitySet<Categoria> Categoria1
		{
			get
			{
				return this._categoria1;
			}
			set
			{
				this._categoria1 = value;
			}
		}
		
		[Association(Storage="_deviceFingerprint", OtherKey="UpdatedByID", ThisKey="ID", Name="FK6B9B947B13D9D401")]
		[DebuggerNonUserCode()]
		public EntitySet<DeviceFingerprint> DeviceFingerprint
		{
			get
			{
				return this._deviceFingerprint;
			}
			set
			{
				this._deviceFingerprint = value;
			}
		}
		
		[Association(Storage="_deviceFingerprint1", OtherKey="CreatedByID", ThisKey="ID", Name="FK6B9B947BF2EB5C6E")]
		[DebuggerNonUserCode()]
		public EntitySet<DeviceFingerprint> DeviceFingerprint1
		{
			get
			{
				return this._deviceFingerprint1;
			}
			set
			{
				this._deviceFingerprint1 = value;
			}
		}
		
		[Association(Storage="_userClock", OtherKey="UpdatedByID", ThisKey="ID", Name="FK726DE69A13D9D401")]
		[DebuggerNonUserCode()]
		public EntitySet<UserClock> UserClock
		{
			get
			{
				return this._userClock;
			}
			set
			{
				this._userClock = value;
			}
		}
		
		[Association(Storage="_userClock1", OtherKey="CreatedByID", ThisKey="ID", Name="FK726DE69AF2EB5C6E")]
		[DebuggerNonUserCode()]
		public EntitySet<UserClock> UserClock1
		{
			get
			{
				return this._userClock1;
			}
			set
			{
				this._userClock1 = value;
			}
		}
		
		[Association(Storage="_applicationUserRole", OtherKey="ApplicationUserID", ThisKey="ID", Name="FK9A16903B269020A2")]
		[DebuggerNonUserCode()]
		public EntitySet<ApplicationUserRole> ApplicationUserRole
		{
			get
			{
				return this._applicationUserRole;
			}
			set
			{
				this._applicationUserRole = value;
			}
		}
		
		[Association(Storage="_empresa", OtherKey="UpdatedByID", ThisKey="ID", Name="FK9F35408913D9D401")]
		[DebuggerNonUserCode()]
		public EntitySet<Empresa> Empresa
		{
			get
			{
				return this._empresa;
			}
			set
			{
				this._empresa = value;
			}
		}
		
		[Association(Storage="_empresa1", OtherKey="CreatedByID", ThisKey="ID", Name="FK9F354089F2EB5C6E")]
		[DebuggerNonUserCode()]
		public EntitySet<Empresa> Empresa1
		{
			get
			{
				return this._empresa1;
			}
			set
			{
				this._empresa1 = value;
			}
		}
		
		[Association(Storage="_device", OtherKey="UpdatedByID", ThisKey="ID", Name="FKB06B1E5613D9D401")]
		[DebuggerNonUserCode()]
		public EntitySet<Device> Device
		{
			get
			{
				return this._device;
			}
			set
			{
				this._device = value;
			}
		}
		
		[Association(Storage="_device1", OtherKey="CreatedByID", ThisKey="ID", Name="FKB06B1E56F2EB5C6E")]
		[DebuggerNonUserCode()]
		public EntitySet<Device> Device1
		{
			get
			{
				return this._device1;
			}
			set
			{
				this._device1 = value;
			}
		}
		
		[Association(Storage="_ferias", OtherKey="UpdatedByID", ThisKey="ID", Name="FKB3D2FDE813D9D401")]
		[DebuggerNonUserCode()]
		public EntitySet<Ferias> Ferias
		{
			get
			{
				return this._ferias;
			}
			set
			{
				this._ferias = value;
			}
		}
		
		[Association(Storage="_ferias1", OtherKey="CreatedByID", ThisKey="ID", Name="FKB3D2FDE8F2EB5C6E")]
		[DebuggerNonUserCode()]
		public EntitySet<Ferias> Ferias1
		{
			get
			{
				return this._ferias1;
			}
			set
			{
				this._ferias1 = value;
			}
		}
		
		[Association(Storage="_departamento", OtherKey="UpdatedByID", ThisKey="ID", Name="FKB3FD2C0413D9D401")]
		[DebuggerNonUserCode()]
		public EntitySet<Departamento> Departamento
		{
			get
			{
				return this._departamento;
			}
			set
			{
				this._departamento = value;
			}
		}
		
		[Association(Storage="_departamento1", OtherKey="CreatedByID", ThisKey="ID", Name="FKB3FD2C04F2EB5C6E")]
		[DebuggerNonUserCode()]
		public EntitySet<Departamento> Departamento1
		{
			get
			{
				return this._departamento1;
			}
			set
			{
				this._departamento1 = value;
			}
		}
		
		[Association(Storage="_feriado", OtherKey="UpdatedByID", ThisKey="ID", Name="FKC68CBDB613D9D401")]
		[DebuggerNonUserCode()]
		public EntitySet<Feriado> Feriado
		{
			get
			{
				return this._feriado;
			}
			set
			{
				this._feriado = value;
			}
		}
		
		[Association(Storage="_feriado1", OtherKey="CreatedByID", ThisKey="ID", Name="FKC68CBDB6F2EB5C6E")]
		[DebuggerNonUserCode()]
		public EntitySet<Feriado> Feriado1
		{
			get
			{
				return this._feriado1;
			}
			set
			{
				this._feriado1 = value;
			}
		}
		
		[Association(Storage="_idaPplicationUser", OtherKey="UserCreatedByID", ThisKey="ID", Name="FKC715AD9761AFA")]
		[DebuggerNonUserCode()]
		public EntitySet<ApplicationUser> IDApplicationUser
		{
			get
			{
				return this._idaPplicationUser;
			}
			set
			{
				this._idaPplicationUser = value;
			}
		}
		
		[Association(Storage="_idaPplicationUser1", OtherKey="UserUpdatedByID", ThisKey="ID", Name="FKC715AFA64928D")]
		[DebuggerNonUserCode()]
		public EntitySet<ApplicationUser> IDApplicationUser1
		{
			get
			{
				return this._idaPplicationUser1;
			}
			set
			{
				this._idaPplicationUser1 = value;
			}
		}
		
		[Association(Storage="_deviceTimeZone", OtherKey="UpdatedByID", ThisKey="ID", Name="FKCD871BC213D9D401")]
		[DebuggerNonUserCode()]
		public EntitySet<DeviceTimeZone> DeviceTimeZone
		{
			get
			{
				return this._deviceTimeZone;
			}
			set
			{
				this._deviceTimeZone = value;
			}
		}
		
		[Association(Storage="_deviceTimeZone1", OtherKey="CreatedByID", ThisKey="ID", Name="FKCD871BC2F2EB5C6E")]
		[DebuggerNonUserCode()]
		public EntitySet<DeviceTimeZone> DeviceTimeZone1
		{
			get
			{
				return this._deviceTimeZone1;
			}
			set
			{
				this._deviceTimeZone1 = value;
			}
		}
		
		[Association(Storage="_attCalcs", OtherKey="UpdatedByID", ThisKey="ID", Name="FKE00671A013D9D401")]
		[DebuggerNonUserCode()]
		public EntitySet<AttCalcs> AttCalcs
		{
			get
			{
				return this._attCalcs;
			}
			set
			{
				this._attCalcs = value;
			}
		}
		
		[Association(Storage="_attCalcs1", OtherKey="CreatedByID", ThisKey="ID", Name="FKE00671A0F2EB5C6E")]
		[DebuggerNonUserCode()]
		public EntitySet<AttCalcs> AttCalcs1
		{
			get
			{
				return this._attCalcs1;
			}
			set
			{
				this._attCalcs1 = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_userCreatedByIdaPplicationUser", OtherKey="ID", ThisKey="UserCreatedByID", Name="FKC715AD9761AFA", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser UserCreatedByIDApplicationUser
		{
			get
			{
				return this._userCreatedByIdaPplicationUser.Entity;
			}
			set
			{
				if (((this._userCreatedByIdaPplicationUser.Entity == value) 
							== false))
				{
					if ((this._userCreatedByIdaPplicationUser.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._userCreatedByIdaPplicationUser.Entity;
						this._userCreatedByIdaPplicationUser.Entity = null;
						previousApplicationUser.IDApplicationUser.Remove(this);
					}
					this._userCreatedByIdaPplicationUser.Entity = value;
					if ((value != null))
					{
						value.IDApplicationUser.Add(this);
						_userCreatedByID = value.ID;
					}
					else
					{
						_userCreatedByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_userUpdatedByIdaPplicationUser", OtherKey="ID", ThisKey="UserUpdatedByID", Name="FKC715AFA64928D", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser UserUpdatedByIDApplicationUser
		{
			get
			{
				return this._userUpdatedByIdaPplicationUser.Entity;
			}
			set
			{
				if (((this._userUpdatedByIdaPplicationUser.Entity == value) 
							== false))
				{
					if ((this._userUpdatedByIdaPplicationUser.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._userUpdatedByIdaPplicationUser.Entity;
						this._userUpdatedByIdaPplicationUser.Entity = null;
						previousApplicationUser.IDApplicationUser1.Remove(this);
					}
					this._userUpdatedByIdaPplicationUser.Entity = value;
					if ((value != null))
					{
						value.IDApplicationUser1.Add(this);
						_userUpdatedByID = value.ID;
					}
					else
					{
						_userUpdatedByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_sexo", OtherKey="ID", ThisKey="UserSexoID", Name="FKC715AFB67CA01", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Sexo Sexo
		{
			get
			{
				return this._sexo.Entity;
			}
			set
			{
				if (((this._sexo.Entity == value) 
							== false))
				{
					if ((this._sexo.Entity != null))
					{
						Sexo previousSexo = this._sexo.Entity;
						this._sexo.Entity = null;
						previousSexo.ApplicationUser.Remove(this);
					}
					this._sexo.Entity = value;
					if ((value != null))
					{
						value.ApplicationUser.Add(this);
						_userSexoID = value.ID;
					}
					else
					{
						_userSexoID = default(long);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void AttendanceRules_Attach(AttendanceRules entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = this;
		}
		
		private void AttendanceRules_Detach(AttendanceRules entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = null;
		}
		
		private void AttendanceRules1_Attach(AttendanceRules entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = this;
		}
		
		private void AttendanceRules1_Detach(AttendanceRules entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = null;
		}
		
		private void ApplicationParam_Attach(ApplicationParam entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = this;
		}
		
		private void ApplicationParam_Detach(ApplicationParam entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = null;
		}
		
		private void ApplicationParam1_Attach(ApplicationParam entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = this;
		}
		
		private void ApplicationParam1_Detach(ApplicationParam entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = null;
		}
		
		private void HorarioSemana_Attach(HorarioSemana entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = this;
		}
		
		private void HorarioSemana_Detach(HorarioSemana entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = null;
		}
		
		private void HorarioSemana1_Attach(HorarioSemana entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = this;
		}
		
		private void HorarioSemana1_Detach(HorarioSemana entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = null;
		}
		
		private void HorarioDia_Attach(HorarioDia entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = this;
		}
		
		private void HorarioDia_Detach(HorarioDia entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = null;
		}
		
		private void HorarioDia1_Attach(HorarioDia entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = this;
		}
		
		private void HorarioDia1_Detach(HorarioDia entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = null;
		}
		
		private void SystemLog_Attach(SystemLog entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = this;
		}
		
		private void SystemLog_Detach(SystemLog entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = null;
		}
		
		private void Door_Attach(Door entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = this;
		}
		
		private void Door_Detach(Door entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = null;
		}
		
		private void Door1_Attach(Door entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = this;
		}
		
		private void Door1_Detach(Door entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = null;
		}
		
		private void Funcionario_Attach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = this;
		}
		
		private void Funcionario_Detach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = null;
		}
		
		private void Funcionario1_Attach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = this;
		}
		
		private void Funcionario1_Detach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = null;
		}
		
		private void DeviceTimeZoneGroup_Attach(DeviceTimeZoneGroup entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = this;
		}
		
		private void DeviceTimeZoneGroup_Detach(DeviceTimeZoneGroup entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = null;
		}
		
		private void DeviceTimeZoneGroup1_Attach(DeviceTimeZoneGroup entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = this;
		}
		
		private void DeviceTimeZoneGroup1_Detach(DeviceTimeZoneGroup entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = null;
		}
		
		private void Falta_Attach(Falta entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = this;
		}
		
		private void Falta_Detach(Falta entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = null;
		}
		
		private void Falta1_Attach(Falta entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = this;
		}
		
		private void Falta1_Detach(Falta entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = null;
		}
		
		private void Categoria_Attach(Categoria entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = this;
		}
		
		private void Categoria_Detach(Categoria entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = null;
		}
		
		private void Categoria1_Attach(Categoria entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = this;
		}
		
		private void Categoria1_Detach(Categoria entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = null;
		}
		
		private void DeviceFingerprint_Attach(DeviceFingerprint entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = this;
		}
		
		private void DeviceFingerprint_Detach(DeviceFingerprint entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = null;
		}
		
		private void DeviceFingerprint1_Attach(DeviceFingerprint entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = this;
		}
		
		private void DeviceFingerprint1_Detach(DeviceFingerprint entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = null;
		}
		
		private void UserClock_Attach(UserClock entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = this;
		}
		
		private void UserClock_Detach(UserClock entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = null;
		}
		
		private void UserClock1_Attach(UserClock entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = this;
		}
		
		private void UserClock1_Detach(UserClock entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = null;
		}
		
		private void ApplicationUserRole_Attach(ApplicationUserRole entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = this;
		}
		
		private void ApplicationUserRole_Detach(ApplicationUserRole entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = null;
		}
		
		private void Empresa_Attach(Empresa entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = this;
		}
		
		private void Empresa_Detach(Empresa entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = null;
		}
		
		private void Empresa1_Attach(Empresa entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = this;
		}
		
		private void Empresa1_Detach(Empresa entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = null;
		}
		
		private void Device_Attach(Device entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = this;
		}
		
		private void Device_Detach(Device entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = null;
		}
		
		private void Device1_Attach(Device entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = this;
		}
		
		private void Device1_Detach(Device entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = null;
		}
		
		private void Ferias_Attach(Ferias entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = this;
		}
		
		private void Ferias_Detach(Ferias entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = null;
		}
		
		private void Ferias1_Attach(Ferias entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = this;
		}
		
		private void Ferias1_Detach(Ferias entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = null;
		}
		
		private void Departamento_Attach(Departamento entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = this;
		}
		
		private void Departamento_Detach(Departamento entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = null;
		}
		
		private void Departamento1_Attach(Departamento entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = this;
		}
		
		private void Departamento1_Detach(Departamento entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = null;
		}
		
		private void Feriado_Attach(Feriado entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = this;
		}
		
		private void Feriado_Detach(Feriado entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = null;
		}
		
		private void Feriado1_Attach(Feriado entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = this;
		}
		
		private void Feriado1_Detach(Feriado entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = null;
		}
		
		private void IDApplicationUser_Attach(ApplicationUser entity)
		{
			this.SendPropertyChanging();
			entity.UserCreatedByIDApplicationUser = this;
		}
		
		private void IDApplicationUser_Detach(ApplicationUser entity)
		{
			this.SendPropertyChanging();
			entity.UserCreatedByIDApplicationUser = null;
		}
		
		private void IDApplicationUser1_Attach(ApplicationUser entity)
		{
			this.SendPropertyChanging();
			entity.UserUpdatedByIDApplicationUser = this;
		}
		
		private void IDApplicationUser1_Detach(ApplicationUser entity)
		{
			this.SendPropertyChanging();
			entity.UserUpdatedByIDApplicationUser = null;
		}
		
		private void DeviceTimeZone_Attach(DeviceTimeZone entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = this;
		}
		
		private void DeviceTimeZone_Detach(DeviceTimeZone entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = null;
		}
		
		private void DeviceTimeZone1_Attach(DeviceTimeZone entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = this;
		}
		
		private void DeviceTimeZone1_Detach(DeviceTimeZone entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = null;
		}
		
		private void AttCalcs_Attach(AttCalcs entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = this;
		}
		
		private void AttCalcs_Detach(AttCalcs entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser = null;
		}
		
		private void AttCalcs1_Attach(AttCalcs entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = this;
		}
		
		private void AttCalcs1_Detach(AttCalcs entity)
		{
			this.SendPropertyChanging();
			entity.ApplicationUser1 = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.application_user_role")]
	public partial class ApplicationUserRole : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private long _applicationUserID;
		
		private long _roleID;
		
		private EntityRef<ApplicationUser> _applicationUser = new EntityRef<ApplicationUser>();
		
		private EntityRef<Role> _role = new EntityRef<Role>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnApplicationUserIDChanged();
		
		partial void OnApplicationUserIDChanging(long value);
		
		partial void OnRoleIDChanged();
		
		partial void OnRoleIDChanging(long value);
		#endregion
		
		
		public ApplicationUserRole()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_applicationUserID", Name="application_user_id", DbType="bigint(20)", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ApplicationUserID
		{
			get
			{
				return this._applicationUserID;
			}
			set
			{
				if ((_applicationUserID != value))
				{
					this.OnApplicationUserIDChanging(value);
					this.SendPropertyChanging();
					this._applicationUserID = value;
					this.SendPropertyChanged("ApplicationUserID");
					this.OnApplicationUserIDChanged();
				}
			}
		}
		
		[Column(Storage="_roleID", Name="role_id", DbType="bigint(20)", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long RoleID
		{
			get
			{
				return this._roleID;
			}
			set
			{
				if ((_roleID != value))
				{
					this.OnRoleIDChanging(value);
					this.SendPropertyChanging();
					this._roleID = value;
					this.SendPropertyChanged("RoleID");
					this.OnRoleIDChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_applicationUser", OtherKey="ID", ThisKey="ApplicationUserID", Name="FK9A16903B269020A2", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser
		{
			get
			{
				return this._applicationUser.Entity;
			}
			set
			{
				if (((this._applicationUser.Entity == value) 
							== false))
				{
					if ((this._applicationUser.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser.Entity;
						this._applicationUser.Entity = null;
						previousApplicationUser.ApplicationUserRole.Remove(this);
					}
					this._applicationUser.Entity = value;
					if ((value != null))
					{
						value.ApplicationUserRole.Add(this);
						_applicationUserID = value.ID;
					}
					else
					{
						_applicationUserID = default(long);
					}
				}
			}
		}
		
		[Association(Storage="_role", OtherKey="ID", ThisKey="RoleID", Name="FK9A16903B961F8313", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Role Role
		{
			get
			{
				return this._role.Entity;
			}
			set
			{
				if (((this._role.Entity == value) 
							== false))
				{
					if ((this._role.Entity != null))
					{
						Role previousRole = this._role.Entity;
						this._role.Entity = null;
						previousRole.ApplicationUserRole.Remove(this);
					}
					this._role.Entity = value;
					if ((value != null))
					{
						value.ApplicationUserRole.Add(this);
						_roleID = value.ID;
					}
					else
					{
						_roleID = default(long);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="beta_interactive_sisga.att_calcs")]
	public partial class AttCalcs : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<long> _createdByID;
		
		private System.Nullable<System.DateTime> _creationDate;
		
		private System.Nullable<System.DateTime> _data;
		
		private System.DateTime _entrada;
		
		private System.DateTime _entradaAtrasada;
		
		private long _funcionarioID;
		
		private long _horarioDiaID;
		
		private System.DateTime _horasAusente;
		
		private System.DateTime _horasExtras;
		
		private System.DateTime _horasTrabalho;
		
		private long _id;
		
		private bool _isAusenciaAutorizada;
		
		private bool _isDayWork;
		
		private bool _isEmFerias;
		
		private bool _isFeriado;
		
		private bool _isPresente;
		
		private System.DateTime _saida;
		
		private System.DateTime _saidaAdiantada;
		
		private System.Nullable<long> _tipoFaltaID;
		
		private System.Nullable<long> _updatedByID;
		
		private System.Nullable<System.DateTime> _updatedDate;
		
		private long _version;
		
		private EntityRef<ApplicationUser> _applicationUser = new EntityRef<ApplicationUser>();
		
		private EntityRef<TipoFalta> _tipoFalta = new EntityRef<TipoFalta>();
		
		private EntityRef<HorarioDia> _horarioDia = new EntityRef<HorarioDia>();
		
		private EntityRef<ApplicationUser> _applicationUser1 = new EntityRef<ApplicationUser>();
		
		private EntityRef<Funcionario> _funcionario = new EntityRef<Funcionario>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedByIDChanged();
		
		partial void OnCreatedByIDChanging(System.Nullable<long> value);
		
		partial void OnCreationDateChanged();
		
		partial void OnCreationDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnDataChanged();
		
		partial void OnDataChanging(System.Nullable<System.DateTime> value);
		
		partial void OnEntradaChanged();
		
		partial void OnEntradaChanging(System.DateTime value);
		
		partial void OnEntradaAtrasadaChanged();
		
		partial void OnEntradaAtrasadaChanging(System.DateTime value);
		
		partial void OnFuncionarioIDChanged();
		
		partial void OnFuncionarioIDChanging(long value);
		
		partial void OnHorarioDiaIDChanged();
		
		partial void OnHorarioDiaIDChanging(long value);
		
		partial void OnHorasAusenteChanged();
		
		partial void OnHorasAusenteChanging(System.DateTime value);
		
		partial void OnHorasExtrasChanged();
		
		partial void OnHorasExtrasChanging(System.DateTime value);
		
		partial void OnHorasTrabalhoChanged();
		
		partial void OnHorasTrabalhoChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnIsAusenciaAutorizadaChanged();
		
		partial void OnIsAusenciaAutorizadaChanging(bool value);
		
		partial void OnIsDayWorkChanged();
		
		partial void OnIsDayWorkChanging(bool value);
		
		partial void OnIsEmFeriasChanged();
		
		partial void OnIsEmFeriasChanging(bool value);
		
		partial void OnIsFeriadoChanged();
		
		partial void OnIsFeriadoChanging(bool value);
		
		partial void OnIsPresenteChanged();
		
		partial void OnIsPresenteChanging(bool value);
		
		partial void OnSaidaChanged();
		
		partial void OnSaidaChanging(System.DateTime value);
		
		partial void OnSaidaAdiantadaChanged();
		
		partial void OnSaidaAdiantadaChanging(System.DateTime value);
		
		partial void OnTipoFaltaIDChanged();
		
		partial void OnTipoFaltaIDChanging(System.Nullable<long> value);
		
		partial void OnUpdatedByIDChanged();
		
		partial void OnUpdatedByIDChanging(System.Nullable<long> value);
		
		partial void OnUpdatedDateChanged();
		
		partial void OnUpdatedDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public AttCalcs()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdByID", Name="created_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CreatedByID
		{
			get
			{
				return this._createdByID;
			}
			set
			{
				if ((_createdByID != value))
				{
					this.OnCreatedByIDChanging(value);
					this.SendPropertyChanging();
					this._createdByID = value;
					this.SendPropertyChanged("CreatedByID");
					this.OnCreatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_creationDate", Name="creation_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreationDate
		{
			get
			{
				return this._creationDate;
			}
			set
			{
				if ((_creationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._creationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[Column(Storage="_data", Name="data", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> Data
		{
			get
			{
				return this._data;
			}
			set
			{
				if ((_data != value))
				{
					this.OnDataChanging(value);
					this.SendPropertyChanging();
					this._data = value;
					this.SendPropertyChanged("Data");
					this.OnDataChanged();
				}
			}
		}
		
		[Column(Storage="_entrada", Name="entrada", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime Entrada
		{
			get
			{
				return this._entrada;
			}
			set
			{
				if ((_entrada != value))
				{
					this.OnEntradaChanging(value);
					this.SendPropertyChanging();
					this._entrada = value;
					this.SendPropertyChanged("Entrada");
					this.OnEntradaChanged();
				}
			}
		}
		
		[Column(Storage="_entradaAtrasada", Name="entrada_atrasada", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime EntradaAtrasada
		{
			get
			{
				return this._entradaAtrasada;
			}
			set
			{
				if ((_entradaAtrasada != value))
				{
					this.OnEntradaAtrasadaChanging(value);
					this.SendPropertyChanging();
					this._entradaAtrasada = value;
					this.SendPropertyChanged("EntradaAtrasada");
					this.OnEntradaAtrasadaChanged();
				}
			}
		}
		
		[Column(Storage="_funcionarioID", Name="funcionario_id", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long FuncionarioID
		{
			get
			{
				return this._funcionarioID;
			}
			set
			{
				if ((_funcionarioID != value))
				{
					this.OnFuncionarioIDChanging(value);
					this.SendPropertyChanging();
					this._funcionarioID = value;
					this.SendPropertyChanged("FuncionarioID");
					this.OnFuncionarioIDChanged();
				}
			}
		}
		
		[Column(Storage="_horarioDiaID", Name="horario_dia_id", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long HorarioDiaID
		{
			get
			{
				return this._horarioDiaID;
			}
			set
			{
				if ((_horarioDiaID != value))
				{
					this.OnHorarioDiaIDChanging(value);
					this.SendPropertyChanging();
					this._horarioDiaID = value;
					this.SendPropertyChanged("HorarioDiaID");
					this.OnHorarioDiaIDChanged();
				}
			}
		}
		
		[Column(Storage="_horasAusente", Name="horas_ausente", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime HorasAusente
		{
			get
			{
				return this._horasAusente;
			}
			set
			{
				if ((_horasAusente != value))
				{
					this.OnHorasAusenteChanging(value);
					this.SendPropertyChanging();
					this._horasAusente = value;
					this.SendPropertyChanged("HorasAusente");
					this.OnHorasAusenteChanged();
				}
			}
		}
		
		[Column(Storage="_horasExtras", Name="horas_extras", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime HorasExtras
		{
			get
			{
				return this._horasExtras;
			}
			set
			{
				if ((_horasExtras != value))
				{
					this.OnHorasExtrasChanging(value);
					this.SendPropertyChanging();
					this._horasExtras = value;
					this.SendPropertyChanged("HorasExtras");
					this.OnHorasExtrasChanged();
				}
			}
		}
		
		[Column(Storage="_horasTrabalho", Name="horas_trabalho", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime HorasTrabalho
		{
			get
			{
				return this._horasTrabalho;
			}
			set
			{
				if ((_horasTrabalho != value))
				{
					this.OnHorasTrabalhoChanging(value);
					this.SendPropertyChanging();
					this._horasTrabalho = value;
					this.SendPropertyChanged("HorasTrabalho");
					this.OnHorasTrabalhoChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_isAusenciaAutorizada", Name="is_ausencia_autorizada", DbType="bit(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool IsAusenciaAutorizada
		{
			get
			{
				return this._isAusenciaAutorizada;
			}
			set
			{
				if ((_isAusenciaAutorizada != value))
				{
					this.OnIsAusenciaAutorizadaChanging(value);
					this.SendPropertyChanging();
					this._isAusenciaAutorizada = value;
					this.SendPropertyChanged("IsAusenciaAutorizada");
					this.OnIsAusenciaAutorizadaChanged();
				}
			}
		}
		
		[Column(Storage="_isDayWork", Name="is_day_work", DbType="bit(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool IsDayWork
		{
			get
			{
				return this._isDayWork;
			}
			set
			{
				if ((_isDayWork != value))
				{
					this.OnIsDayWorkChanging(value);
					this.SendPropertyChanging();
					this._isDayWork = value;
					this.SendPropertyChanged("IsDayWork");
					this.OnIsDayWorkChanged();
				}
			}
		}
		
		[Column(Storage="_isEmFerias", Name="is_em_ferias", DbType="bit(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool IsEmFerias
		{
			get
			{
				return this._isEmFerias;
			}
			set
			{
				if ((_isEmFerias != value))
				{
					this.OnIsEmFeriasChanging(value);
					this.SendPropertyChanging();
					this._isEmFerias = value;
					this.SendPropertyChanged("IsEmFerias");
					this.OnIsEmFeriasChanged();
				}
			}
		}
		
		[Column(Storage="_isFeriado", Name="is_feriado", DbType="bit(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool IsFeriado
		{
			get
			{
				return this._isFeriado;
			}
			set
			{
				if ((_isFeriado != value))
				{
					this.OnIsFeriadoChanging(value);
					this.SendPropertyChanging();
					this._isFeriado = value;
					this.SendPropertyChanged("IsFeriado");
					this.OnIsFeriadoChanged();
				}
			}
		}
		
		[Column(Storage="_isPresente", Name="is_presente", DbType="bit(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool IsPresente
		{
			get
			{
				return this._isPresente;
			}
			set
			{
				if ((_isPresente != value))
				{
					this.OnIsPresenteChanging(value);
					this.SendPropertyChanging();
					this._isPresente = value;
					this.SendPropertyChanged("IsPresente");
					this.OnIsPresenteChanged();
				}
			}
		}
		
		[Column(Storage="_saida", Name="saida", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime Saida
		{
			get
			{
				return this._saida;
			}
			set
			{
				if ((_saida != value))
				{
					this.OnSaidaChanging(value);
					this.SendPropertyChanging();
					this._saida = value;
					this.SendPropertyChanged("Saida");
					this.OnSaidaChanged();
				}
			}
		}
		
		[Column(Storage="_saidaAdiantada", Name="saida_adiantada", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime SaidaAdiantada
		{
			get
			{
				return this._saidaAdiantada;
			}
			set
			{
				if ((_saidaAdiantada != value))
				{
					this.OnSaidaAdiantadaChanging(value);
					this.SendPropertyChanging();
					this._saidaAdiantada = value;
					this.SendPropertyChanged("SaidaAdiantada");
					this.OnSaidaAdiantadaChanged();
				}
			}
		}
		
		[Column(Storage="_tipoFaltaID", Name="tipo_falta_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> TipoFaltaID
		{
			get
			{
				return this._tipoFaltaID;
			}
			set
			{
				if ((_tipoFaltaID != value))
				{
					this.OnTipoFaltaIDChanging(value);
					this.SendPropertyChanging();
					this._tipoFaltaID = value;
					this.SendPropertyChanged("TipoFaltaID");
					this.OnTipoFaltaIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedByID", Name="updated_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UpdatedByID
		{
			get
			{
				return this._updatedByID;
			}
			set
			{
				if ((_updatedByID != value))
				{
					this.OnUpdatedByIDChanging(value);
					this.SendPropertyChanging();
					this._updatedByID = value;
					this.SendPropertyChanged("UpdatedByID");
					this.OnUpdatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedDate", Name="updated_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> UpdatedDate
		{
			get
			{
				return this._updatedDate;
			}
			set
			{
				if ((_updatedDate != value))
				{
					this.OnUpdatedDateChanging(value);
					this.SendPropertyChanging();
					this._updatedDate = value;
					this.SendPropertyChanged("UpdatedDate");
					this.OnUpdatedDateChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_applicationUser", OtherKey="ID", ThisKey="UpdatedByID", Name="FKE00671A013D9D401", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser
		{
			get
			{
				return this._applicationUser.Entity;
			}
			set
			{
				if (((this._applicationUser.Entity == value) 
							== false))
				{
					if ((this._applicationUser.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser.Entity;
						this._applicationUser.Entity = null;
						previousApplicationUser.AttCalcs.Remove(this);
					}
					this._applicationUser.Entity = value;
					if ((value != null))
					{
						value.AttCalcs.Add(this);
						_updatedByID = value.ID;
					}
					else
					{
						_updatedByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_tipoFalta", OtherKey="ID", ThisKey="TipoFaltaID", Name="FKE00671A0D6A89BFB", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public TipoFalta TipoFalta
		{
			get
			{
				return this._tipoFalta.Entity;
			}
			set
			{
				if (((this._tipoFalta.Entity == value) 
							== false))
				{
					if ((this._tipoFalta.Entity != null))
					{
						TipoFalta previousTipoFalta = this._tipoFalta.Entity;
						this._tipoFalta.Entity = null;
						previousTipoFalta.AttCalcs.Remove(this);
					}
					this._tipoFalta.Entity = value;
					if ((value != null))
					{
						value.AttCalcs.Add(this);
						_tipoFaltaID = value.ID;
					}
					else
					{
						_tipoFaltaID = null;
					}
				}
			}
		}
		
		[Association(Storage="_horarioDia", OtherKey="ID", ThisKey="HorarioDiaID", Name="FKE00671A0E8D8400B", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public HorarioDia HorarioDia
		{
			get
			{
				return this._horarioDia.Entity;
			}
			set
			{
				if (((this._horarioDia.Entity == value) 
							== false))
				{
					if ((this._horarioDia.Entity != null))
					{
						HorarioDia previousHorarioDia = this._horarioDia.Entity;
						this._horarioDia.Entity = null;
						previousHorarioDia.AttCalcs.Remove(this);
					}
					this._horarioDia.Entity = value;
					if ((value != null))
					{
						value.AttCalcs.Add(this);
						_horarioDiaID = value.ID;
					}
					else
					{
						_horarioDiaID = default(long);
					}
				}
			}
		}
		
		[Association(Storage="_applicationUser1", OtherKey="ID", ThisKey="CreatedByID", Name="FKE00671A0F2EB5C6E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser1
		{
			get
			{
				return this._applicationUser1.Entity;
			}
			set
			{
				if (((this._applicationUser1.Entity == value) 
							== false))
				{
					if ((this._applicationUser1.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser1.Entity;
						this._applicationUser1.Entity = null;
						previousApplicationUser.AttCalcs1.Remove(this);
					}
					this._applicationUser1.Entity = value;
					if ((value != null))
					{
						value.AttCalcs1.Add(this);
						_createdByID = value.ID;
					}
					else
					{
						_createdByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_funcionario", OtherKey="ID", ThisKey="FuncionarioID", Name="FKE00671A0FA7F0284", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Funcionario Funcionario
		{
			get
			{
				return this._funcionario.Entity;
			}
			set
			{
				if (((this._funcionario.Entity == value) 
							== false))
				{
					if ((this._funcionario.Entity != null))
					{
						Funcionario previousFuncionario = this._funcionario.Entity;
						this._funcionario.Entity = null;
						previousFuncionario.AttCalcs.Remove(this);
					}
					this._funcionario.Entity = value;
					if ((value != null))
					{
						value.AttCalcs.Add(this);
						_funcionarioID = value.ID;
					}
					else
					{
						_funcionarioID = default(long);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="beta_interactive_sisga.attendance_rules")]
	public partial class AttendanceRules : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _countAtrasoAfter;
		
		private int _countHorasExtrasAfter;
		
		private System.Nullable<long> _createdByID;
		
		private System.Nullable<System.DateTime> _creationDate;
		
		private long _id;
		
		private bool _isClockingOverHorarioDia;
		
		private int _minIfNoClockIn;
		
		private int _minIfNoClockOut;
		
		private System.Nullable<long> _updatedByID;
		
		private System.Nullable<System.DateTime> _updatedDate;
		
		private long _version;
		
		private EntitySet<Empresa> _empresa;
		
		private EntityRef<ApplicationUser> _applicationUser = new EntityRef<ApplicationUser>();
		
		private EntityRef<ApplicationUser> _applicationUser1 = new EntityRef<ApplicationUser>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCountAtrasoAfterChanged();
		
		partial void OnCountAtrasoAfterChanging(int value);
		
		partial void OnCountHorasExtrasAfterChanged();
		
		partial void OnCountHorasExtrasAfterChanging(int value);
		
		partial void OnCreatedByIDChanged();
		
		partial void OnCreatedByIDChanging(System.Nullable<long> value);
		
		partial void OnCreationDateChanged();
		
		partial void OnCreationDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnIsClockingOverHorarioDiaChanged();
		
		partial void OnIsClockingOverHorarioDiaChanging(bool value);
		
		partial void OnMinIfNoClockInChanged();
		
		partial void OnMinIfNoClockInChanging(int value);
		
		partial void OnMinIfNoClockOutChanged();
		
		partial void OnMinIfNoClockOutChanging(int value);
		
		partial void OnUpdatedByIDChanged();
		
		partial void OnUpdatedByIDChanging(System.Nullable<long> value);
		
		partial void OnUpdatedDateChanged();
		
		partial void OnUpdatedDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public AttendanceRules()
		{
			_empresa = new EntitySet<Empresa>(new Action<Empresa>(this.Empresa_Attach), new Action<Empresa>(this.Empresa_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_countAtrasoAfter", Name="count_atraso_after", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CountAtrasoAfter
		{
			get
			{
				return this._countAtrasoAfter;
			}
			set
			{
				if ((_countAtrasoAfter != value))
				{
					this.OnCountAtrasoAfterChanging(value);
					this.SendPropertyChanging();
					this._countAtrasoAfter = value;
					this.SendPropertyChanged("CountAtrasoAfter");
					this.OnCountAtrasoAfterChanged();
				}
			}
		}
		
		[Column(Storage="_countHorasExtrasAfter", Name="count_horas_extras_after", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CountHorasExtrasAfter
		{
			get
			{
				return this._countHorasExtrasAfter;
			}
			set
			{
				if ((_countHorasExtrasAfter != value))
				{
					this.OnCountHorasExtrasAfterChanging(value);
					this.SendPropertyChanging();
					this._countHorasExtrasAfter = value;
					this.SendPropertyChanged("CountHorasExtrasAfter");
					this.OnCountHorasExtrasAfterChanged();
				}
			}
		}
		
		[Column(Storage="_createdByID", Name="created_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CreatedByID
		{
			get
			{
				return this._createdByID;
			}
			set
			{
				if ((_createdByID != value))
				{
					this.OnCreatedByIDChanging(value);
					this.SendPropertyChanging();
					this._createdByID = value;
					this.SendPropertyChanged("CreatedByID");
					this.OnCreatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_creationDate", Name="creation_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreationDate
		{
			get
			{
				return this._creationDate;
			}
			set
			{
				if ((_creationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._creationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_isClockingOverHorarioDia", Name="is_clocking_over_horario_dia", DbType="bit(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool IsClockingOverHorarioDia
		{
			get
			{
				return this._isClockingOverHorarioDia;
			}
			set
			{
				if ((_isClockingOverHorarioDia != value))
				{
					this.OnIsClockingOverHorarioDiaChanging(value);
					this.SendPropertyChanging();
					this._isClockingOverHorarioDia = value;
					this.SendPropertyChanged("IsClockingOverHorarioDia");
					this.OnIsClockingOverHorarioDiaChanged();
				}
			}
		}
		
		[Column(Storage="_minIfNoClockIn", Name="min_if_no_clock_in", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int MinIfNoClockIn
		{
			get
			{
				return this._minIfNoClockIn;
			}
			set
			{
				if ((_minIfNoClockIn != value))
				{
					this.OnMinIfNoClockInChanging(value);
					this.SendPropertyChanging();
					this._minIfNoClockIn = value;
					this.SendPropertyChanged("MinIfNoClockIn");
					this.OnMinIfNoClockInChanged();
				}
			}
		}
		
		[Column(Storage="_minIfNoClockOut", Name="min_if_no_clock_out", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int MinIfNoClockOut
		{
			get
			{
				return this._minIfNoClockOut;
			}
			set
			{
				if ((_minIfNoClockOut != value))
				{
					this.OnMinIfNoClockOutChanging(value);
					this.SendPropertyChanging();
					this._minIfNoClockOut = value;
					this.SendPropertyChanged("MinIfNoClockOut");
					this.OnMinIfNoClockOutChanged();
				}
			}
		}
		
		[Column(Storage="_updatedByID", Name="updated_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UpdatedByID
		{
			get
			{
				return this._updatedByID;
			}
			set
			{
				if ((_updatedByID != value))
				{
					this.OnUpdatedByIDChanging(value);
					this.SendPropertyChanging();
					this._updatedByID = value;
					this.SendPropertyChanged("UpdatedByID");
					this.OnUpdatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedDate", Name="updated_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> UpdatedDate
		{
			get
			{
				return this._updatedDate;
			}
			set
			{
				if ((_updatedDate != value))
				{
					this.OnUpdatedDateChanging(value);
					this.SendPropertyChanging();
					this._updatedDate = value;
					this.SendPropertyChanged("UpdatedDate");
					this.OnUpdatedDateChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_empresa", OtherKey="AttendanceRulesID", ThisKey="ID", Name="FK9F35408967319331")]
		[DebuggerNonUserCode()]
		public EntitySet<Empresa> Empresa
		{
			get
			{
				return this._empresa;
			}
			set
			{
				this._empresa = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_applicationUser", OtherKey="ID", ThisKey="UpdatedByID", Name="FK124BFC2113D9D401", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser
		{
			get
			{
				return this._applicationUser.Entity;
			}
			set
			{
				if (((this._applicationUser.Entity == value) 
							== false))
				{
					if ((this._applicationUser.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser.Entity;
						this._applicationUser.Entity = null;
						previousApplicationUser.AttendanceRules.Remove(this);
					}
					this._applicationUser.Entity = value;
					if ((value != null))
					{
						value.AttendanceRules.Add(this);
						_updatedByID = value.ID;
					}
					else
					{
						_updatedByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_applicationUser1", OtherKey="ID", ThisKey="CreatedByID", Name="FK124BFC21F2EB5C6E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser1
		{
			get
			{
				return this._applicationUser1.Entity;
			}
			set
			{
				if (((this._applicationUser1.Entity == value) 
							== false))
				{
					if ((this._applicationUser1.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser1.Entity;
						this._applicationUser1.Entity = null;
						previousApplicationUser.AttendanceRules1.Remove(this);
					}
					this._applicationUser1.Entity = value;
					if ((value != null))
					{
						value.AttendanceRules1.Add(this);
						_createdByID = value.ID;
					}
					else
					{
						_createdByID = null;
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Empresa_Attach(Empresa entity)
		{
			this.SendPropertyChanging();
			entity.AttendanceRules = this;
		}
		
		private void Empresa_Detach(Empresa entity)
		{
			this.SendPropertyChanging();
			entity.AttendanceRules = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.categoria")]
	public partial class Categoria : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<long> _createdByID;
		
		private System.Nullable<System.DateTime> _creationDate;
		
		private long _empresaID;
		
		private string _funcoes;
		
		private long _id;
		
		private string _nome;
		
		private System.Nullable<long> _updatedByID;
		
		private System.Nullable<System.DateTime> _updatedDate;
		
		private long _version;
		
		private EntitySet<Funcionario> _funcionario;
		
		private EntityRef<ApplicationUser> _applicationUser = new EntityRef<ApplicationUser>();
		
		private EntityRef<Empresa> _empresa = new EntityRef<Empresa>();
		
		private EntityRef<ApplicationUser> _applicationUser1 = new EntityRef<ApplicationUser>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedByIDChanged();
		
		partial void OnCreatedByIDChanging(System.Nullable<long> value);
		
		partial void OnCreationDateChanged();
		
		partial void OnCreationDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnEmpresaIDChanged();
		
		partial void OnEmpresaIDChanging(long value);
		
		partial void OnFuncoesChanged();
		
		partial void OnFuncoesChanging(string value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnNomeChanged();
		
		partial void OnNomeChanging(string value);
		
		partial void OnUpdatedByIDChanged();
		
		partial void OnUpdatedByIDChanging(System.Nullable<long> value);
		
		partial void OnUpdatedDateChanged();
		
		partial void OnUpdatedDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public Categoria()
		{
			_funcionario = new EntitySet<Funcionario>(new Action<Funcionario>(this.Funcionario_Attach), new Action<Funcionario>(this.Funcionario_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_createdByID", Name="created_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CreatedByID
		{
			get
			{
				return this._createdByID;
			}
			set
			{
				if ((_createdByID != value))
				{
					this.OnCreatedByIDChanging(value);
					this.SendPropertyChanging();
					this._createdByID = value;
					this.SendPropertyChanged("CreatedByID");
					this.OnCreatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_creationDate", Name="creation_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreationDate
		{
			get
			{
				return this._creationDate;
			}
			set
			{
				if ((_creationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._creationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[Column(Storage="_empresaID", Name="empresa_id", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long EmpresaID
		{
			get
			{
				return this._empresaID;
			}
			set
			{
				if ((_empresaID != value))
				{
					this.OnEmpresaIDChanging(value);
					this.SendPropertyChanging();
					this._empresaID = value;
					this.SendPropertyChanged("EmpresaID");
					this.OnEmpresaIDChanged();
				}
			}
		}
		
		[Column(Storage="_funcoes", Name="funcoes", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Funcoes
		{
			get
			{
				return this._funcoes;
			}
			set
			{
				if (((_funcoes == value) 
							== false))
				{
					this.OnFuncoesChanging(value);
					this.SendPropertyChanging();
					this._funcoes = value;
					this.SendPropertyChanged("Funcoes");
					this.OnFuncoesChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_nome", Name="nome", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if (((_nome == value) 
							== false))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[Column(Storage="_updatedByID", Name="updated_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UpdatedByID
		{
			get
			{
				return this._updatedByID;
			}
			set
			{
				if ((_updatedByID != value))
				{
					this.OnUpdatedByIDChanging(value);
					this.SendPropertyChanging();
					this._updatedByID = value;
					this.SendPropertyChanged("UpdatedByID");
					this.OnUpdatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedDate", Name="updated_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> UpdatedDate
		{
			get
			{
				return this._updatedDate;
			}
			set
			{
				if ((_updatedDate != value))
				{
					this.OnUpdatedDateChanging(value);
					this.SendPropertyChanging();
					this._updatedDate = value;
					this.SendPropertyChanged("UpdatedDate");
					this.OnUpdatedDateChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_funcionario", OtherKey="CategoriaID", ThisKey="ID", Name="FK50401DDB1DA8C604")]
		[DebuggerNonUserCode()]
		public EntitySet<Funcionario> Funcionario
		{
			get
			{
				return this._funcionario;
			}
			set
			{
				this._funcionario = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_applicationUser", OtherKey="ID", ThisKey="UpdatedByID", Name="FK5D54E13313D9D401", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser
		{
			get
			{
				return this._applicationUser.Entity;
			}
			set
			{
				if (((this._applicationUser.Entity == value) 
							== false))
				{
					if ((this._applicationUser.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser.Entity;
						this._applicationUser.Entity = null;
						previousApplicationUser.Categoria.Remove(this);
					}
					this._applicationUser.Entity = value;
					if ((value != null))
					{
						value.Categoria.Add(this);
						_updatedByID = value.ID;
					}
					else
					{
						_updatedByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_empresa", OtherKey="ID", ThisKey="EmpresaID", Name="FK5D54E1336BA2C0C4", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Empresa Empresa
		{
			get
			{
				return this._empresa.Entity;
			}
			set
			{
				if (((this._empresa.Entity == value) 
							== false))
				{
					if ((this._empresa.Entity != null))
					{
						Empresa previousEmpresa = this._empresa.Entity;
						this._empresa.Entity = null;
						previousEmpresa.Categoria.Remove(this);
					}
					this._empresa.Entity = value;
					if ((value != null))
					{
						value.Categoria.Add(this);
						_empresaID = value.ID;
					}
					else
					{
						_empresaID = default(long);
					}
				}
			}
		}
		
		[Association(Storage="_applicationUser1", OtherKey="ID", ThisKey="CreatedByID", Name="FK5D54E133F2EB5C6E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser1
		{
			get
			{
				return this._applicationUser1.Entity;
			}
			set
			{
				if (((this._applicationUser1.Entity == value) 
							== false))
				{
					if ((this._applicationUser1.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser1.Entity;
						this._applicationUser1.Entity = null;
						previousApplicationUser.Categoria1.Remove(this);
					}
					this._applicationUser1.Entity = value;
					if ((value != null))
					{
						value.Categoria1.Add(this);
						_createdByID = value.ID;
					}
					else
					{
						_createdByID = null;
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Funcionario_Attach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = this;
		}
		
		private void Funcionario_Detach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.continent")]
	public partial class Continent : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private long _code;
		
		private long _id;
		
		private string _nome;
		
		private long _version;
		
		private EntitySet<Country> _country;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCodeChanged();
		
		partial void OnCodeChanging(long value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnNomeChanged();
		
		partial void OnNomeChanging(string value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public Continent()
		{
			_country = new EntitySet<Country>(new Action<Country>(this.Country_Attach), new Action<Country>(this.Country_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_code", Name="code", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Code
		{
			get
			{
				return this._code;
			}
			set
			{
				if ((_code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_nome", Name="nome", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if (((_nome == value) 
							== false))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_country", OtherKey="ContinentID", ThisKey="ID", Name="FK391757965AB5DC86")]
		[DebuggerNonUserCode()]
		public EntitySet<Country> Country
		{
			get
			{
				return this._country;
			}
			set
			{
				this._country = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Country_Attach(Country entity)
		{
			this.SendPropertyChanging();
			entity.Continent = this;
		}
		
		private void Country_Detach(Country entity)
		{
			this.SendPropertyChanging();
			entity.Continent = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.country")]
	public partial class Country : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _capital;
		
		private long _code;
		
		private long _continentID;
		
		private long _id;
		
		private string _nome;
		
		private long _version;
		
		private EntitySet<Funcionario> _funcionario;
		
		private EntityRef<Continent> _continent = new EntityRef<Continent>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCapitalChanged();
		
		partial void OnCapitalChanging(string value);
		
		partial void OnCodeChanged();
		
		partial void OnCodeChanging(long value);
		
		partial void OnContinentIDChanged();
		
		partial void OnContinentIDChanging(long value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnNomeChanged();
		
		partial void OnNomeChanging(string value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public Country()
		{
			_funcionario = new EntitySet<Funcionario>(new Action<Funcionario>(this.Funcionario_Attach), new Action<Funcionario>(this.Funcionario_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_capital", Name="capital", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Capital
		{
			get
			{
				return this._capital;
			}
			set
			{
				if (((_capital == value) 
							== false))
				{
					this.OnCapitalChanging(value);
					this.SendPropertyChanging();
					this._capital = value;
					this.SendPropertyChanged("Capital");
					this.OnCapitalChanged();
				}
			}
		}
		
		[Column(Storage="_code", Name="code", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Code
		{
			get
			{
				return this._code;
			}
			set
			{
				if ((_code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[Column(Storage="_continentID", Name="continent_id", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ContinentID
		{
			get
			{
				return this._continentID;
			}
			set
			{
				if ((_continentID != value))
				{
					this.OnContinentIDChanging(value);
					this.SendPropertyChanging();
					this._continentID = value;
					this.SendPropertyChanged("ContinentID");
					this.OnContinentIDChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_nome", Name="nome", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if (((_nome == value) 
							== false))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_funcionario", OtherKey="NacionalidadeID", ThisKey="ID", Name="FK50401DDB7CB50CB8")]
		[DebuggerNonUserCode()]
		public EntitySet<Funcionario> Funcionario
		{
			get
			{
				return this._funcionario;
			}
			set
			{
				this._funcionario = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_continent", OtherKey="ID", ThisKey="ContinentID", Name="FK391757965AB5DC86", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Continent Continent
		{
			get
			{
				return this._continent.Entity;
			}
			set
			{
				if (((this._continent.Entity == value) 
							== false))
				{
					if ((this._continent.Entity != null))
					{
						Continent previousContinent = this._continent.Entity;
						this._continent.Entity = null;
						previousContinent.Country.Remove(this);
					}
					this._continent.Entity = value;
					if ((value != null))
					{
						value.Country.Add(this);
						_continentID = value.ID;
					}
					else
					{
						_continentID = default(long);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Funcionario_Attach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.Country = this;
		}
		
		private void Funcionario_Detach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.Country = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.departamento")]
	public partial class Departamento : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<long> _createdByID;
		
		private System.Nullable<System.DateTime> _creationDate;
		
		private string _descricao;
		
		private long _empresaID;
		
		private long _id;
		
		private string _nome;
		
		private System.Nullable<long> _updatedByID;
		
		private System.Nullable<System.DateTime> _updatedDate;
		
		private long _version;
		
		private EntitySet<Funcionario> _funcionario;
		
		private EntityRef<ApplicationUser> _applicationUser = new EntityRef<ApplicationUser>();
		
		private EntityRef<Empresa> _empresa = new EntityRef<Empresa>();
		
		private EntityRef<ApplicationUser> _applicationUser1 = new EntityRef<ApplicationUser>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedByIDChanged();
		
		partial void OnCreatedByIDChanging(System.Nullable<long> value);
		
		partial void OnCreationDateChanged();
		
		partial void OnCreationDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnDescricaoChanged();
		
		partial void OnDescricaoChanging(string value);
		
		partial void OnEmpresaIDChanged();
		
		partial void OnEmpresaIDChanging(long value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnNomeChanged();
		
		partial void OnNomeChanging(string value);
		
		partial void OnUpdatedByIDChanged();
		
		partial void OnUpdatedByIDChanging(System.Nullable<long> value);
		
		partial void OnUpdatedDateChanged();
		
		partial void OnUpdatedDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public Departamento()
		{
			_funcionario = new EntitySet<Funcionario>(new Action<Funcionario>(this.Funcionario_Attach), new Action<Funcionario>(this.Funcionario_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_createdByID", Name="created_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CreatedByID
		{
			get
			{
				return this._createdByID;
			}
			set
			{
				if ((_createdByID != value))
				{
					this.OnCreatedByIDChanging(value);
					this.SendPropertyChanging();
					this._createdByID = value;
					this.SendPropertyChanged("CreatedByID");
					this.OnCreatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_creationDate", Name="creation_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreationDate
		{
			get
			{
				return this._creationDate;
			}
			set
			{
				if ((_creationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._creationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[Column(Storage="_descricao", Name="descricao", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Descricao
		{
			get
			{
				return this._descricao;
			}
			set
			{
				if (((_descricao == value) 
							== false))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[Column(Storage="_empresaID", Name="empresa_id", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long EmpresaID
		{
			get
			{
				return this._empresaID;
			}
			set
			{
				if ((_empresaID != value))
				{
					this.OnEmpresaIDChanging(value);
					this.SendPropertyChanging();
					this._empresaID = value;
					this.SendPropertyChanged("EmpresaID");
					this.OnEmpresaIDChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_nome", Name="nome", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if (((_nome == value) 
							== false))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[Column(Storage="_updatedByID", Name="updated_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UpdatedByID
		{
			get
			{
				return this._updatedByID;
			}
			set
			{
				if ((_updatedByID != value))
				{
					this.OnUpdatedByIDChanging(value);
					this.SendPropertyChanging();
					this._updatedByID = value;
					this.SendPropertyChanged("UpdatedByID");
					this.OnUpdatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedDate", Name="updated_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> UpdatedDate
		{
			get
			{
				return this._updatedDate;
			}
			set
			{
				if ((_updatedDate != value))
				{
					this.OnUpdatedDateChanging(value);
					this.SendPropertyChanging();
					this._updatedDate = value;
					this.SendPropertyChanged("UpdatedDate");
					this.OnUpdatedDateChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_funcionario", OtherKey="DepartamentoID", ThisKey="ID", Name="FK50401DDBFF5CF5D0")]
		[DebuggerNonUserCode()]
		public EntitySet<Funcionario> Funcionario
		{
			get
			{
				return this._funcionario;
			}
			set
			{
				this._funcionario = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_applicationUser", OtherKey="ID", ThisKey="UpdatedByID", Name="FKB3FD2C0413D9D401", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser
		{
			get
			{
				return this._applicationUser.Entity;
			}
			set
			{
				if (((this._applicationUser.Entity == value) 
							== false))
				{
					if ((this._applicationUser.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser.Entity;
						this._applicationUser.Entity = null;
						previousApplicationUser.Departamento.Remove(this);
					}
					this._applicationUser.Entity = value;
					if ((value != null))
					{
						value.Departamento.Add(this);
						_updatedByID = value.ID;
					}
					else
					{
						_updatedByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_empresa", OtherKey="ID", ThisKey="EmpresaID", Name="FKB3FD2C046BA2C0C4", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Empresa Empresa
		{
			get
			{
				return this._empresa.Entity;
			}
			set
			{
				if (((this._empresa.Entity == value) 
							== false))
				{
					if ((this._empresa.Entity != null))
					{
						Empresa previousEmpresa = this._empresa.Entity;
						this._empresa.Entity = null;
						previousEmpresa.Departamento.Remove(this);
					}
					this._empresa.Entity = value;
					if ((value != null))
					{
						value.Departamento.Add(this);
						_empresaID = value.ID;
					}
					else
					{
						_empresaID = default(long);
					}
				}
			}
		}
		
		[Association(Storage="_applicationUser1", OtherKey="ID", ThisKey="CreatedByID", Name="FKB3FD2C04F2EB5C6E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser1
		{
			get
			{
				return this._applicationUser1.Entity;
			}
			set
			{
				if (((this._applicationUser1.Entity == value) 
							== false))
				{
					if ((this._applicationUser1.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser1.Entity;
						this._applicationUser1.Entity = null;
						previousApplicationUser.Departamento1.Remove(this);
					}
					this._applicationUser1.Entity = value;
					if ((value != null))
					{
						value.Departamento1.Add(this);
						_createdByID = value.ID;
					}
					else
					{
						_createdByID = null;
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Funcionario_Attach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.Departamento = this;
		}
		
		private void Funcionario_Detach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.Departamento = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.device")]
	public partial class Device : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _baudRate;
		
		private int _comPort;
		
		private int _connectionType;
		
		private System.Nullable<long> _createdByID;
		
		private System.Nullable<System.DateTime> _creationDate;
		
		private System.Nullable<long> _doorID;
		
		private long _id;
		
		private string _ipaDdress;
		
		private string _name;
		
		private int _port;
		
		private string _serialNumber;
		
		private long _typeID;
		
		private System.Nullable<long> _updatedByID;
		
		private System.Nullable<System.DateTime> _updatedDate;
		
		private long _version;
		
		private EntitySet<Door> _door;
		
		private EntitySet<Door> _door1;
		
		private EntitySet<UserClock> _userClock;
		
		private EntityRef<ApplicationUser> _applicationUser = new EntityRef<ApplicationUser>();
		
		private EntityRef<DeviceType> _deviceType = new EntityRef<DeviceType>();
		
		private EntityRef<Door> _door2 = new EntityRef<Door>();
		
		private EntityRef<ApplicationUser> _applicationUser1 = new EntityRef<ApplicationUser>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnBaudRateChanged();
		
		partial void OnBaudRateChanging(int value);
		
		partial void OnComPortChanged();
		
		partial void OnComPortChanging(int value);
		
		partial void OnConnectionTypeChanged();
		
		partial void OnConnectionTypeChanging(int value);
		
		partial void OnCreatedByIDChanged();
		
		partial void OnCreatedByIDChanging(System.Nullable<long> value);
		
		partial void OnCreationDateChanged();
		
		partial void OnCreationDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnDoorIDChanged();
		
		partial void OnDoorIDChanging(System.Nullable<long> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnIPAddressChanged();
		
		partial void OnIPAddressChanging(string value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnPortChanged();
		
		partial void OnPortChanging(int value);
		
		partial void OnSerialNumberChanged();
		
		partial void OnSerialNumberChanging(string value);
		
		partial void OnTypeIDChanged();
		
		partial void OnTypeIDChanging(long value);
		
		partial void OnUpdatedByIDChanged();
		
		partial void OnUpdatedByIDChanging(System.Nullable<long> value);
		
		partial void OnUpdatedDateChanged();
		
		partial void OnUpdatedDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public Device()
		{
			_door = new EntitySet<Door>(new Action<Door>(this.Door_Attach), new Action<Door>(this.Door_Detach));
			_door1 = new EntitySet<Door>(new Action<Door>(this.Door1_Attach), new Action<Door>(this.Door1_Detach));
			_userClock = new EntitySet<UserClock>(new Action<UserClock>(this.UserClock_Attach), new Action<UserClock>(this.UserClock_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_baudRate", Name="baud_rate", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int BaudRate
		{
			get
			{
				return this._baudRate;
			}
			set
			{
				if ((_baudRate != value))
				{
					this.OnBaudRateChanging(value);
					this.SendPropertyChanging();
					this._baudRate = value;
					this.SendPropertyChanged("BaudRate");
					this.OnBaudRateChanged();
				}
			}
		}
		
		[Column(Storage="_comPort", Name="com_port", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ComPort
		{
			get
			{
				return this._comPort;
			}
			set
			{
				if ((_comPort != value))
				{
					this.OnComPortChanging(value);
					this.SendPropertyChanging();
					this._comPort = value;
					this.SendPropertyChanged("ComPort");
					this.OnComPortChanged();
				}
			}
		}
		
		[Column(Storage="_connectionType", Name="connection_type", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ConnectionType
		{
			get
			{
				return this._connectionType;
			}
			set
			{
				if ((_connectionType != value))
				{
					this.OnConnectionTypeChanging(value);
					this.SendPropertyChanging();
					this._connectionType = value;
					this.SendPropertyChanged("ConnectionType");
					this.OnConnectionTypeChanged();
				}
			}
		}
		
		[Column(Storage="_createdByID", Name="created_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CreatedByID
		{
			get
			{
				return this._createdByID;
			}
			set
			{
				if ((_createdByID != value))
				{
					this.OnCreatedByIDChanging(value);
					this.SendPropertyChanging();
					this._createdByID = value;
					this.SendPropertyChanged("CreatedByID");
					this.OnCreatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_creationDate", Name="creation_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreationDate
		{
			get
			{
				return this._creationDate;
			}
			set
			{
				if ((_creationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._creationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[Column(Storage="_doorID", Name="door_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> DoorID
		{
			get
			{
				return this._doorID;
			}
			set
			{
				if ((_doorID != value))
				{
					this.OnDoorIDChanging(value);
					this.SendPropertyChanging();
					this._doorID = value;
					this.SendPropertyChanged("DoorID");
					this.OnDoorIDChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_ipaDdress", Name="ip_address", DbType="varchar(255)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string IPAddress
		{
			get
			{
				return this._ipaDdress;
			}
			set
			{
				if (((_ipaDdress == value) 
							== false))
				{
					this.OnIPAddressChanging(value);
					this.SendPropertyChanging();
					this._ipaDdress = value;
					this.SendPropertyChanged("IPAddress");
					this.OnIPAddressChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_port", Name="port", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int Port
		{
			get
			{
				return this._port;
			}
			set
			{
				if ((_port != value))
				{
					this.OnPortChanging(value);
					this.SendPropertyChanging();
					this._port = value;
					this.SendPropertyChanged("Port");
					this.OnPortChanged();
				}
			}
		}
		
		[Column(Storage="_serialNumber", Name="serial_number", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string SerialNumber
		{
			get
			{
				return this._serialNumber;
			}
			set
			{
				if (((_serialNumber == value) 
							== false))
				{
					this.OnSerialNumberChanging(value);
					this.SendPropertyChanging();
					this._serialNumber = value;
					this.SendPropertyChanged("SerialNumber");
					this.OnSerialNumberChanged();
				}
			}
		}
		
		[Column(Storage="_typeID", Name="type_id", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long TypeID
		{
			get
			{
				return this._typeID;
			}
			set
			{
				if ((_typeID != value))
				{
					this.OnTypeIDChanging(value);
					this.SendPropertyChanging();
					this._typeID = value;
					this.SendPropertyChanged("TypeID");
					this.OnTypeIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedByID", Name="updated_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UpdatedByID
		{
			get
			{
				return this._updatedByID;
			}
			set
			{
				if ((_updatedByID != value))
				{
					this.OnUpdatedByIDChanging(value);
					this.SendPropertyChanging();
					this._updatedByID = value;
					this.SendPropertyChanged("UpdatedByID");
					this.OnUpdatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedDate", Name="updated_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> UpdatedDate
		{
			get
			{
				return this._updatedDate;
			}
			set
			{
				if ((_updatedDate != value))
				{
					this.OnUpdatedDateChanging(value);
					this.SendPropertyChanging();
					this._updatedDate = value;
					this.SendPropertyChanged("UpdatedDate");
					this.OnUpdatedDateChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_door", OtherKey="FirstDeviceID", ThisKey="ID", Name="FK2F23AE83CD9B19")]
		[DebuggerNonUserCode()]
		public EntitySet<Door> Door
		{
			get
			{
				return this._door;
			}
			set
			{
				this._door = value;
			}
		}
		
		[Association(Storage="_door1", OtherKey="SecondDeviceID", ThisKey="ID", Name="FK2F23AEF2F9A7DD")]
		[DebuggerNonUserCode()]
		public EntitySet<Door> Door1
		{
			get
			{
				return this._door1;
			}
			set
			{
				this._door1 = value;
			}
		}
		
		[Association(Storage="_userClock", OtherKey="DeviceID", ThisKey="ID", Name="FK726DE69A486169E8")]
		[DebuggerNonUserCode()]
		public EntitySet<UserClock> UserClock
		{
			get
			{
				return this._userClock;
			}
			set
			{
				this._userClock = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_applicationUser", OtherKey="ID", ThisKey="UpdatedByID", Name="FKB06B1E5613D9D401", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser
		{
			get
			{
				return this._applicationUser.Entity;
			}
			set
			{
				if (((this._applicationUser.Entity == value) 
							== false))
				{
					if ((this._applicationUser.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser.Entity;
						this._applicationUser.Entity = null;
						previousApplicationUser.Device.Remove(this);
					}
					this._applicationUser.Entity = value;
					if ((value != null))
					{
						value.Device.Add(this);
						_updatedByID = value.ID;
					}
					else
					{
						_updatedByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_deviceType", OtherKey="ID", ThisKey="TypeID", Name="FKB06B1E561D5EDFDE", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public DeviceType DeviceType
		{
			get
			{
				return this._deviceType.Entity;
			}
			set
			{
				if (((this._deviceType.Entity == value) 
							== false))
				{
					if ((this._deviceType.Entity != null))
					{
						DeviceType previousDeviceType = this._deviceType.Entity;
						this._deviceType.Entity = null;
						previousDeviceType.Device.Remove(this);
					}
					this._deviceType.Entity = value;
					if ((value != null))
					{
						value.Device.Add(this);
						_typeID = value.ID;
					}
					else
					{
						_typeID = default(long);
					}
				}
			}
		}
		
		[Association(Storage="_door2", OtherKey="ID", ThisKey="DoorID", Name="FKB06B1E567726E68", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Door Door2
		{
			get
			{
				return this._door2.Entity;
			}
			set
			{
				if (((this._door2.Entity == value) 
							== false))
				{
					if ((this._door2.Entity != null))
					{
						Door previousDoor = this._door2.Entity;
						this._door2.Entity = null;
						previousDoor.Device2.Remove(this);
					}
					this._door2.Entity = value;
					if ((value != null))
					{
						value.Device2.Add(this);
						_doorID = value.ID;
					}
					else
					{
						_doorID = null;
					}
				}
			}
		}
		
		[Association(Storage="_applicationUser1", OtherKey="ID", ThisKey="CreatedByID", Name="FKB06B1E56F2EB5C6E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser1
		{
			get
			{
				return this._applicationUser1.Entity;
			}
			set
			{
				if (((this._applicationUser1.Entity == value) 
							== false))
				{
					if ((this._applicationUser1.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser1.Entity;
						this._applicationUser1.Entity = null;
						previousApplicationUser.Device1.Remove(this);
					}
					this._applicationUser1.Entity = value;
					if ((value != null))
					{
						value.Device1.Add(this);
						_createdByID = value.ID;
					}
					else
					{
						_createdByID = null;
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Door_Attach(Door entity)
		{
			this.SendPropertyChanging();
			entity.Device = this;
		}
		
		private void Door_Detach(Door entity)
		{
			this.SendPropertyChanging();
			entity.Device = null;
		}
		
		private void Door1_Attach(Door entity)
		{
			this.SendPropertyChanging();
			entity.Device1 = this;
		}
		
		private void Door1_Detach(Door entity)
		{
			this.SendPropertyChanging();
			entity.Device1 = null;
		}
		
		private void UserClock_Attach(UserClock entity)
		{
			this.SendPropertyChanging();
			entity.Device = this;
		}
		
		private void UserClock_Detach(UserClock entity)
		{
			this.SendPropertyChanging();
			entity.Device = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.device_authorization")]
	public partial class DeviceAuthorization : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _company;
		
		private long _id;
		
		private string _productKey;
		
		private long _version;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCompanyChanged();
		
		partial void OnCompanyChanging(string value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnProductKeyChanged();
		
		partial void OnProductKeyChanging(string value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public DeviceAuthorization()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_company", Name="company", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Company
		{
			get
			{
				return this._company;
			}
			set
			{
				if (((_company == value) 
							== false))
				{
					this.OnCompanyChanging(value);
					this.SendPropertyChanging();
					this._company = value;
					this.SendPropertyChanged("Company");
					this.OnCompanyChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_productKey", Name="product_key", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProductKey
		{
			get
			{
				return this._productKey;
			}
			set
			{
				if (((_productKey == value) 
							== false))
				{
					this.OnProductKeyChanging(value);
					this.SendPropertyChanging();
					this._productKey = value;
					this.SendPropertyChanged("ProductKey");
					this.OnProductKeyChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="beta_interactive_sisga.device_fingerprint")]
	public partial class DeviceFingerprint : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<long> _createdByID;
		
		private System.Nullable<System.DateTime> _creationDate;
		
		private int _fingerIndex;
		
		private long _funcionarioID;
		
		private long _id;
		
		private string _templateData;
		
		private System.Nullable<long> _updatedByID;
		
		private System.Nullable<System.DateTime> _updatedDate;
		
		private long _version;
		
		private EntityRef<ApplicationUser> _applicationUser = new EntityRef<ApplicationUser>();
		
		private EntityRef<ApplicationUser> _applicationUser1 = new EntityRef<ApplicationUser>();
		
		private EntityRef<Funcionario> _funcionario = new EntityRef<Funcionario>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedByIDChanged();
		
		partial void OnCreatedByIDChanging(System.Nullable<long> value);
		
		partial void OnCreationDateChanged();
		
		partial void OnCreationDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnFingerIndexChanged();
		
		partial void OnFingerIndexChanging(int value);
		
		partial void OnFuncionarioIDChanged();
		
		partial void OnFuncionarioIDChanging(long value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnTemplateDataChanged();
		
		partial void OnTemplateDataChanging(string value);
		
		partial void OnUpdatedByIDChanged();
		
		partial void OnUpdatedByIDChanging(System.Nullable<long> value);
		
		partial void OnUpdatedDateChanged();
		
		partial void OnUpdatedDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public DeviceFingerprint()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdByID", Name="created_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CreatedByID
		{
			get
			{
				return this._createdByID;
			}
			set
			{
				if ((_createdByID != value))
				{
					this.OnCreatedByIDChanging(value);
					this.SendPropertyChanging();
					this._createdByID = value;
					this.SendPropertyChanged("CreatedByID");
					this.OnCreatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_creationDate", Name="creation_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreationDate
		{
			get
			{
				return this._creationDate;
			}
			set
			{
				if ((_creationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._creationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[Column(Storage="_fingerIndex", Name="finger_index", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int FingerIndex
		{
			get
			{
				return this._fingerIndex;
			}
			set
			{
				if ((_fingerIndex != value))
				{
					this.OnFingerIndexChanging(value);
					this.SendPropertyChanging();
					this._fingerIndex = value;
					this.SendPropertyChanged("FingerIndex");
					this.OnFingerIndexChanged();
				}
			}
		}
		
		[Column(Storage="_funcionarioID", Name="funcionario_id", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long FuncionarioID
		{
			get
			{
				return this._funcionarioID;
			}
			set
			{
				if ((_funcionarioID != value))
				{
					this.OnFuncionarioIDChanging(value);
					this.SendPropertyChanging();
					this._funcionarioID = value;
					this.SendPropertyChanged("FuncionarioID");
					this.OnFuncionarioIDChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_templateData", Name="template_data", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string TemplateData
		{
			get
			{
				return this._templateData;
			}
			set
			{
				if (((_templateData == value) 
							== false))
				{
					this.OnTemplateDataChanging(value);
					this.SendPropertyChanging();
					this._templateData = value;
					this.SendPropertyChanged("TemplateData");
					this.OnTemplateDataChanged();
				}
			}
		}
		
		[Column(Storage="_updatedByID", Name="updated_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UpdatedByID
		{
			get
			{
				return this._updatedByID;
			}
			set
			{
				if ((_updatedByID != value))
				{
					this.OnUpdatedByIDChanging(value);
					this.SendPropertyChanging();
					this._updatedByID = value;
					this.SendPropertyChanged("UpdatedByID");
					this.OnUpdatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedDate", Name="updated_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> UpdatedDate
		{
			get
			{
				return this._updatedDate;
			}
			set
			{
				if ((_updatedDate != value))
				{
					this.OnUpdatedDateChanging(value);
					this.SendPropertyChanging();
					this._updatedDate = value;
					this.SendPropertyChanged("UpdatedDate");
					this.OnUpdatedDateChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_applicationUser", OtherKey="ID", ThisKey="UpdatedByID", Name="FK6B9B947B13D9D401", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser
		{
			get
			{
				return this._applicationUser.Entity;
			}
			set
			{
				if (((this._applicationUser.Entity == value) 
							== false))
				{
					if ((this._applicationUser.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser.Entity;
						this._applicationUser.Entity = null;
						previousApplicationUser.DeviceFingerprint.Remove(this);
					}
					this._applicationUser.Entity = value;
					if ((value != null))
					{
						value.DeviceFingerprint.Add(this);
						_updatedByID = value.ID;
					}
					else
					{
						_updatedByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_applicationUser1", OtherKey="ID", ThisKey="CreatedByID", Name="FK6B9B947BF2EB5C6E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser1
		{
			get
			{
				return this._applicationUser1.Entity;
			}
			set
			{
				if (((this._applicationUser1.Entity == value) 
							== false))
				{
					if ((this._applicationUser1.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser1.Entity;
						this._applicationUser1.Entity = null;
						previousApplicationUser.DeviceFingerprint1.Remove(this);
					}
					this._applicationUser1.Entity = value;
					if ((value != null))
					{
						value.DeviceFingerprint1.Add(this);
						_createdByID = value.ID;
					}
					else
					{
						_createdByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_funcionario", OtherKey="ID", ThisKey="FuncionarioID", Name="FK6B9B947BFA7F0284", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Funcionario Funcionario
		{
			get
			{
				return this._funcionario.Entity;
			}
			set
			{
				if (((this._funcionario.Entity == value) 
							== false))
				{
					if ((this._funcionario.Entity != null))
					{
						Funcionario previousFuncionario = this._funcionario.Entity;
						this._funcionario.Entity = null;
						previousFuncionario.DeviceFingerprint.Remove(this);
					}
					this._funcionario.Entity = value;
					if ((value != null))
					{
						value.DeviceFingerprint.Add(this);
						_funcionarioID = value.ID;
					}
					else
					{
						_funcionarioID = default(long);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="beta_interactive_sisga.device_timezone")]
	public partial class DeviceTimeZone : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<long> _createdByID;
		
		private System.Nullable<System.DateTime> _creationDate;
		
		private System.Nullable<System.DateTime> _fridayIn;
		
		private System.Nullable<System.DateTime> _fridayOut;
		
		private long _id;
		
		private System.Nullable<System.DateTime> _mondayIn;
		
		private System.Nullable<System.DateTime> _mondayOut;
		
		private string _name;
		
		private System.Nullable<System.DateTime> _saturdayIn;
		
		private System.Nullable<System.DateTime> _saturdayOut;
		
		private System.Nullable<System.DateTime> _sundayIn;
		
		private System.Nullable<System.DateTime> _sundayOut;
		
		private System.Nullable<System.DateTime> _thursdayIn;
		
		private System.Nullable<System.DateTime> _thursdayOut;
		
		private int _timeZoneIndex;
		
		private System.Nullable<System.DateTime> _tuesdayIn;
		
		private System.Nullable<System.DateTime> _tuesdayOut;
		
		private System.Nullable<long> _updatedByID;
		
		private System.Nullable<System.DateTime> _updatedDate;
		
		private long _version;
		
		private System.Nullable<System.DateTime> _wednesdayIn;
		
		private System.Nullable<System.DateTime> _wednesdayOut;
		
		private EntitySet<Funcionario> _funcionario;
		
		private EntitySet<Funcionario> _funcionario1;
		
		private EntitySet<Funcionario> _funcionario2;
		
		private EntitySet<DeviceTimeZoneGroup> _deviceTimeZoneGroup;
		
		private EntitySet<DeviceTimeZoneGroup> _deviceTimeZoneGroup1;
		
		private EntitySet<DeviceTimeZoneGroup> _deviceTimeZoneGroup2;
		
		private EntityRef<ApplicationUser> _applicationUser = new EntityRef<ApplicationUser>();
		
		private EntityRef<ApplicationUser> _applicationUser1 = new EntityRef<ApplicationUser>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedByIDChanged();
		
		partial void OnCreatedByIDChanging(System.Nullable<long> value);
		
		partial void OnCreationDateChanged();
		
		partial void OnCreationDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnFridayInChanged();
		
		partial void OnFridayInChanging(System.Nullable<System.DateTime> value);
		
		partial void OnFridayOutChanged();
		
		partial void OnFridayOutChanging(System.Nullable<System.DateTime> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnMondayInChanged();
		
		partial void OnMondayInChanging(System.Nullable<System.DateTime> value);
		
		partial void OnMondayOutChanged();
		
		partial void OnMondayOutChanging(System.Nullable<System.DateTime> value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnSaturdayInChanged();
		
		partial void OnSaturdayInChanging(System.Nullable<System.DateTime> value);
		
		partial void OnSaturdayOutChanged();
		
		partial void OnSaturdayOutChanging(System.Nullable<System.DateTime> value);
		
		partial void OnSundayInChanged();
		
		partial void OnSundayInChanging(System.Nullable<System.DateTime> value);
		
		partial void OnSundayOutChanged();
		
		partial void OnSundayOutChanging(System.Nullable<System.DateTime> value);
		
		partial void OnThursdayInChanged();
		
		partial void OnThursdayInChanging(System.Nullable<System.DateTime> value);
		
		partial void OnThursdayOutChanged();
		
		partial void OnThursdayOutChanging(System.Nullable<System.DateTime> value);
		
		partial void OnTimeZoneIndexChanged();
		
		partial void OnTimeZoneIndexChanging(int value);
		
		partial void OnTuesdayInChanged();
		
		partial void OnTuesdayInChanging(System.Nullable<System.DateTime> value);
		
		partial void OnTuesdayOutChanged();
		
		partial void OnTuesdayOutChanging(System.Nullable<System.DateTime> value);
		
		partial void OnUpdatedByIDChanged();
		
		partial void OnUpdatedByIDChanging(System.Nullable<long> value);
		
		partial void OnUpdatedDateChanged();
		
		partial void OnUpdatedDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		
		partial void OnWednesdayInChanged();
		
		partial void OnWednesdayInChanging(System.Nullable<System.DateTime> value);
		
		partial void OnWednesdayOutChanged();
		
		partial void OnWednesdayOutChanging(System.Nullable<System.DateTime> value);
		#endregion
		
		
		public DeviceTimeZone()
		{
			_funcionario = new EntitySet<Funcionario>(new Action<Funcionario>(this.Funcionario_Attach), new Action<Funcionario>(this.Funcionario_Detach));
			_funcionario1 = new EntitySet<Funcionario>(new Action<Funcionario>(this.Funcionario1_Attach), new Action<Funcionario>(this.Funcionario1_Detach));
			_funcionario2 = new EntitySet<Funcionario>(new Action<Funcionario>(this.Funcionario2_Attach), new Action<Funcionario>(this.Funcionario2_Detach));
			_deviceTimeZoneGroup = new EntitySet<DeviceTimeZoneGroup>(new Action<DeviceTimeZoneGroup>(this.DeviceTimeZoneGroup_Attach), new Action<DeviceTimeZoneGroup>(this.DeviceTimeZoneGroup_Detach));
			_deviceTimeZoneGroup1 = new EntitySet<DeviceTimeZoneGroup>(new Action<DeviceTimeZoneGroup>(this.DeviceTimeZoneGroup1_Attach), new Action<DeviceTimeZoneGroup>(this.DeviceTimeZoneGroup1_Detach));
			_deviceTimeZoneGroup2 = new EntitySet<DeviceTimeZoneGroup>(new Action<DeviceTimeZoneGroup>(this.DeviceTimeZoneGroup2_Attach), new Action<DeviceTimeZoneGroup>(this.DeviceTimeZoneGroup2_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_createdByID", Name="created_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CreatedByID
		{
			get
			{
				return this._createdByID;
			}
			set
			{
				if ((_createdByID != value))
				{
					this.OnCreatedByIDChanging(value);
					this.SendPropertyChanging();
					this._createdByID = value;
					this.SendPropertyChanged("CreatedByID");
					this.OnCreatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_creationDate", Name="creation_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreationDate
		{
			get
			{
				return this._creationDate;
			}
			set
			{
				if ((_creationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._creationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[Column(Storage="_fridayIn", Name="friday_in", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> FridayIn
		{
			get
			{
				return this._fridayIn;
			}
			set
			{
				if ((_fridayIn != value))
				{
					this.OnFridayInChanging(value);
					this.SendPropertyChanging();
					this._fridayIn = value;
					this.SendPropertyChanged("FridayIn");
					this.OnFridayInChanged();
				}
			}
		}
		
		[Column(Storage="_fridayOut", Name="friday_out", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> FridayOut
		{
			get
			{
				return this._fridayOut;
			}
			set
			{
				if ((_fridayOut != value))
				{
					this.OnFridayOutChanging(value);
					this.SendPropertyChanging();
					this._fridayOut = value;
					this.SendPropertyChanged("FridayOut");
					this.OnFridayOutChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_mondayIn", Name="monday_in", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> MondayIn
		{
			get
			{
				return this._mondayIn;
			}
			set
			{
				if ((_mondayIn != value))
				{
					this.OnMondayInChanging(value);
					this.SendPropertyChanging();
					this._mondayIn = value;
					this.SendPropertyChanged("MondayIn");
					this.OnMondayInChanged();
				}
			}
		}
		
		[Column(Storage="_mondayOut", Name="monday_out", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> MondayOut
		{
			get
			{
				return this._mondayOut;
			}
			set
			{
				if ((_mondayOut != value))
				{
					this.OnMondayOutChanging(value);
					this.SendPropertyChanging();
					this._mondayOut = value;
					this.SendPropertyChanged("MondayOut");
					this.OnMondayOutChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_saturdayIn", Name="saturday_in", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> SaturdayIn
		{
			get
			{
				return this._saturdayIn;
			}
			set
			{
				if ((_saturdayIn != value))
				{
					this.OnSaturdayInChanging(value);
					this.SendPropertyChanging();
					this._saturdayIn = value;
					this.SendPropertyChanged("SaturdayIn");
					this.OnSaturdayInChanged();
				}
			}
		}
		
		[Column(Storage="_saturdayOut", Name="saturday_out", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> SaturdayOut
		{
			get
			{
				return this._saturdayOut;
			}
			set
			{
				if ((_saturdayOut != value))
				{
					this.OnSaturdayOutChanging(value);
					this.SendPropertyChanging();
					this._saturdayOut = value;
					this.SendPropertyChanged("SaturdayOut");
					this.OnSaturdayOutChanged();
				}
			}
		}
		
		[Column(Storage="_sundayIn", Name="sunday_in", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> SundayIn
		{
			get
			{
				return this._sundayIn;
			}
			set
			{
				if ((_sundayIn != value))
				{
					this.OnSundayInChanging(value);
					this.SendPropertyChanging();
					this._sundayIn = value;
					this.SendPropertyChanged("SundayIn");
					this.OnSundayInChanged();
				}
			}
		}
		
		[Column(Storage="_sundayOut", Name="sunday_out", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> SundayOut
		{
			get
			{
				return this._sundayOut;
			}
			set
			{
				if ((_sundayOut != value))
				{
					this.OnSundayOutChanging(value);
					this.SendPropertyChanging();
					this._sundayOut = value;
					this.SendPropertyChanged("SundayOut");
					this.OnSundayOutChanged();
				}
			}
		}
		
		[Column(Storage="_thursdayIn", Name="thursday_in", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ThursdayIn
		{
			get
			{
				return this._thursdayIn;
			}
			set
			{
				if ((_thursdayIn != value))
				{
					this.OnThursdayInChanging(value);
					this.SendPropertyChanging();
					this._thursdayIn = value;
					this.SendPropertyChanged("ThursdayIn");
					this.OnThursdayInChanged();
				}
			}
		}
		
		[Column(Storage="_thursdayOut", Name="thursday_out", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ThursdayOut
		{
			get
			{
				return this._thursdayOut;
			}
			set
			{
				if ((_thursdayOut != value))
				{
					this.OnThursdayOutChanging(value);
					this.SendPropertyChanging();
					this._thursdayOut = value;
					this.SendPropertyChanged("ThursdayOut");
					this.OnThursdayOutChanged();
				}
			}
		}
		
		[Column(Storage="_timeZoneIndex", Name="timezone_index", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int TimeZoneIndex
		{
			get
			{
				return this._timeZoneIndex;
			}
			set
			{
				if ((_timeZoneIndex != value))
				{
					this.OnTimeZoneIndexChanging(value);
					this.SendPropertyChanging();
					this._timeZoneIndex = value;
					this.SendPropertyChanged("TimeZoneIndex");
					this.OnTimeZoneIndexChanged();
				}
			}
		}
		
		[Column(Storage="_tuesdayIn", Name="tuesday_in", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> TuesdayIn
		{
			get
			{
				return this._tuesdayIn;
			}
			set
			{
				if ((_tuesdayIn != value))
				{
					this.OnTuesdayInChanging(value);
					this.SendPropertyChanging();
					this._tuesdayIn = value;
					this.SendPropertyChanged("TuesdayIn");
					this.OnTuesdayInChanged();
				}
			}
		}
		
		[Column(Storage="_tuesdayOut", Name="tuesday_out", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> TuesdayOut
		{
			get
			{
				return this._tuesdayOut;
			}
			set
			{
				if ((_tuesdayOut != value))
				{
					this.OnTuesdayOutChanging(value);
					this.SendPropertyChanging();
					this._tuesdayOut = value;
					this.SendPropertyChanged("TuesdayOut");
					this.OnTuesdayOutChanged();
				}
			}
		}
		
		[Column(Storage="_updatedByID", Name="updated_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UpdatedByID
		{
			get
			{
				return this._updatedByID;
			}
			set
			{
				if ((_updatedByID != value))
				{
					this.OnUpdatedByIDChanging(value);
					this.SendPropertyChanging();
					this._updatedByID = value;
					this.SendPropertyChanged("UpdatedByID");
					this.OnUpdatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedDate", Name="updated_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> UpdatedDate
		{
			get
			{
				return this._updatedDate;
			}
			set
			{
				if ((_updatedDate != value))
				{
					this.OnUpdatedDateChanging(value);
					this.SendPropertyChanging();
					this._updatedDate = value;
					this.SendPropertyChanged("UpdatedDate");
					this.OnUpdatedDateChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		[Column(Storage="_wednesdayIn", Name="wednesday_in", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> WednesdayIn
		{
			get
			{
				return this._wednesdayIn;
			}
			set
			{
				if ((_wednesdayIn != value))
				{
					this.OnWednesdayInChanging(value);
					this.SendPropertyChanging();
					this._wednesdayIn = value;
					this.SendPropertyChanged("WednesdayIn");
					this.OnWednesdayInChanged();
				}
			}
		}
		
		[Column(Storage="_wednesdayOut", Name="wednesday_out", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> WednesdayOut
		{
			get
			{
				return this._wednesdayOut;
			}
			set
			{
				if ((_wednesdayOut != value))
				{
					this.OnWednesdayOutChanging(value);
					this.SendPropertyChanging();
					this._wednesdayOut = value;
					this.SendPropertyChanged("WednesdayOut");
					this.OnWednesdayOutChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_funcionario", OtherKey="FpUserTimeZone1ID", ThisKey="ID", Name="FK50401DDB52E0997E")]
		[DebuggerNonUserCode()]
		public EntitySet<Funcionario> Funcionario
		{
			get
			{
				return this._funcionario;
			}
			set
			{
				this._funcionario = value;
			}
		}
		
		[Association(Storage="_funcionario1", OtherKey="FpUserTimeZone2ID", ThisKey="ID", Name="FK50401DDB52E10DDD")]
		[DebuggerNonUserCode()]
		public EntitySet<Funcionario> Funcionario1
		{
			get
			{
				return this._funcionario1;
			}
			set
			{
				this._funcionario1 = value;
			}
		}
		
		[Association(Storage="_funcionario2", OtherKey="FpUserTimeZone3ID", ThisKey="ID", Name="FK50401DDB52E1823C")]
		[DebuggerNonUserCode()]
		public EntitySet<Funcionario> Funcionario2
		{
			get
			{
				return this._funcionario2;
			}
			set
			{
				this._funcionario2 = value;
			}
		}
		
		[Association(Storage="_deviceTimeZoneGroup", OtherKey="TimeZone1ID", ThisKey="ID", Name="FK52FD1BC25E9A41BF")]
		[DebuggerNonUserCode()]
		public EntitySet<DeviceTimeZoneGroup> DeviceTimeZoneGroup
		{
			get
			{
				return this._deviceTimeZoneGroup;
			}
			set
			{
				this._deviceTimeZoneGroup = value;
			}
		}
		
		[Association(Storage="_deviceTimeZoneGroup1", OtherKey="TimeZone2ID", ThisKey="ID", Name="FK52FD1BC25E9AB61E")]
		[DebuggerNonUserCode()]
		public EntitySet<DeviceTimeZoneGroup> DeviceTimeZoneGroup1
		{
			get
			{
				return this._deviceTimeZoneGroup1;
			}
			set
			{
				this._deviceTimeZoneGroup1 = value;
			}
		}
		
		[Association(Storage="_deviceTimeZoneGroup2", OtherKey="TimeZone3ID", ThisKey="ID", Name="FK52FD1BC25E9B2A7D")]
		[DebuggerNonUserCode()]
		public EntitySet<DeviceTimeZoneGroup> DeviceTimeZoneGroup2
		{
			get
			{
				return this._deviceTimeZoneGroup2;
			}
			set
			{
				this._deviceTimeZoneGroup2 = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_applicationUser", OtherKey="ID", ThisKey="UpdatedByID", Name="FKCD871BC213D9D401", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser
		{
			get
			{
				return this._applicationUser.Entity;
			}
			set
			{
				if (((this._applicationUser.Entity == value) 
							== false))
				{
					if ((this._applicationUser.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser.Entity;
						this._applicationUser.Entity = null;
						previousApplicationUser.DeviceTimeZone.Remove(this);
					}
					this._applicationUser.Entity = value;
					if ((value != null))
					{
						value.DeviceTimeZone.Add(this);
						_updatedByID = value.ID;
					}
					else
					{
						_updatedByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_applicationUser1", OtherKey="ID", ThisKey="CreatedByID", Name="FKCD871BC2F2EB5C6E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser1
		{
			get
			{
				return this._applicationUser1.Entity;
			}
			set
			{
				if (((this._applicationUser1.Entity == value) 
							== false))
				{
					if ((this._applicationUser1.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser1.Entity;
						this._applicationUser1.Entity = null;
						previousApplicationUser.DeviceTimeZone1.Remove(this);
					}
					this._applicationUser1.Entity = value;
					if ((value != null))
					{
						value.DeviceTimeZone1.Add(this);
						_createdByID = value.ID;
					}
					else
					{
						_createdByID = null;
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Funcionario_Attach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.DeviceTimeZone = this;
		}
		
		private void Funcionario_Detach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.DeviceTimeZone = null;
		}
		
		private void Funcionario1_Attach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.DeviceTimeZone1 = this;
		}
		
		private void Funcionario1_Detach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.DeviceTimeZone1 = null;
		}
		
		private void Funcionario2_Attach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.DeviceTimeZone2 = this;
		}
		
		private void Funcionario2_Detach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.DeviceTimeZone2 = null;
		}
		
		private void DeviceTimeZoneGroup_Attach(DeviceTimeZoneGroup entity)
		{
			this.SendPropertyChanging();
			entity.DeviceTimeZone = this;
		}
		
		private void DeviceTimeZoneGroup_Detach(DeviceTimeZoneGroup entity)
		{
			this.SendPropertyChanging();
			entity.DeviceTimeZone = null;
		}
		
		private void DeviceTimeZoneGroup1_Attach(DeviceTimeZoneGroup entity)
		{
			this.SendPropertyChanging();
			entity.DeviceTimeZone1 = this;
		}
		
		private void DeviceTimeZoneGroup1_Detach(DeviceTimeZoneGroup entity)
		{
			this.SendPropertyChanging();
			entity.DeviceTimeZone1 = null;
		}
		
		private void DeviceTimeZoneGroup2_Attach(DeviceTimeZoneGroup entity)
		{
			this.SendPropertyChanging();
			entity.DeviceTimeZone2 = this;
		}
		
		private void DeviceTimeZoneGroup2_Detach(DeviceTimeZoneGroup entity)
		{
			this.SendPropertyChanging();
			entity.DeviceTimeZone2 = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.device_timezone_group")]
	public partial class DeviceTimeZoneGroup : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<long> _createdByID;
		
		private System.Nullable<System.DateTime> _creationDate;
		
		private int _groupIndex;
		
		private long _id;
		
		private string _name;
		
		private System.Nullable<long> _timeZone1id;
		
		private System.Nullable<long> _timeZone2id;
		
		private System.Nullable<long> _timeZone3id;
		
		private System.Nullable<long> _updatedByID;
		
		private System.Nullable<System.DateTime> _updatedDate;
		
		private long _version;
		
		private EntitySet<Funcionario> _funcionario;
		
		private EntityRef<ApplicationUser> _applicationUser = new EntityRef<ApplicationUser>();
		
		private EntityRef<DeviceTimeZone> _deviceTimeZone = new EntityRef<DeviceTimeZone>();
		
		private EntityRef<DeviceTimeZone> _deviceTimeZone1 = new EntityRef<DeviceTimeZone>();
		
		private EntityRef<DeviceTimeZone> _deviceTimeZone2 = new EntityRef<DeviceTimeZone>();
		
		private EntityRef<ApplicationUser> _applicationUser1 = new EntityRef<ApplicationUser>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedByIDChanged();
		
		partial void OnCreatedByIDChanging(System.Nullable<long> value);
		
		partial void OnCreationDateChanged();
		
		partial void OnCreationDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnGroupIndexChanged();
		
		partial void OnGroupIndexChanging(int value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnTimeZone1IDChanged();
		
		partial void OnTimeZone1IDChanging(System.Nullable<long> value);
		
		partial void OnTimeZone2IDChanged();
		
		partial void OnTimeZone2IDChanging(System.Nullable<long> value);
		
		partial void OnTimeZone3IDChanged();
		
		partial void OnTimeZone3IDChanging(System.Nullable<long> value);
		
		partial void OnUpdatedByIDChanged();
		
		partial void OnUpdatedByIDChanging(System.Nullable<long> value);
		
		partial void OnUpdatedDateChanged();
		
		partial void OnUpdatedDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public DeviceTimeZoneGroup()
		{
			_funcionario = new EntitySet<Funcionario>(new Action<Funcionario>(this.Funcionario_Attach), new Action<Funcionario>(this.Funcionario_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_createdByID", Name="created_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CreatedByID
		{
			get
			{
				return this._createdByID;
			}
			set
			{
				if ((_createdByID != value))
				{
					this.OnCreatedByIDChanging(value);
					this.SendPropertyChanging();
					this._createdByID = value;
					this.SendPropertyChanged("CreatedByID");
					this.OnCreatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_creationDate", Name="creation_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreationDate
		{
			get
			{
				return this._creationDate;
			}
			set
			{
				if ((_creationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._creationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[Column(Storage="_groupIndex", Name="group_index", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int GroupIndex
		{
			get
			{
				return this._groupIndex;
			}
			set
			{
				if ((_groupIndex != value))
				{
					this.OnGroupIndexChanging(value);
					this.SendPropertyChanging();
					this._groupIndex = value;
					this.SendPropertyChanged("GroupIndex");
					this.OnGroupIndexChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_timeZone1id", Name="timezone1_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> TimeZone1ID
		{
			get
			{
				return this._timeZone1id;
			}
			set
			{
				if ((_timeZone1id != value))
				{
					this.OnTimeZone1IDChanging(value);
					this.SendPropertyChanging();
					this._timeZone1id = value;
					this.SendPropertyChanged("TimeZone1ID");
					this.OnTimeZone1IDChanged();
				}
			}
		}
		
		[Column(Storage="_timeZone2id", Name="timezone2_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> TimeZone2ID
		{
			get
			{
				return this._timeZone2id;
			}
			set
			{
				if ((_timeZone2id != value))
				{
					this.OnTimeZone2IDChanging(value);
					this.SendPropertyChanging();
					this._timeZone2id = value;
					this.SendPropertyChanged("TimeZone2ID");
					this.OnTimeZone2IDChanged();
				}
			}
		}
		
		[Column(Storage="_timeZone3id", Name="timezone3_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> TimeZone3ID
		{
			get
			{
				return this._timeZone3id;
			}
			set
			{
				if ((_timeZone3id != value))
				{
					this.OnTimeZone3IDChanging(value);
					this.SendPropertyChanging();
					this._timeZone3id = value;
					this.SendPropertyChanged("TimeZone3ID");
					this.OnTimeZone3IDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedByID", Name="updated_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UpdatedByID
		{
			get
			{
				return this._updatedByID;
			}
			set
			{
				if ((_updatedByID != value))
				{
					this.OnUpdatedByIDChanging(value);
					this.SendPropertyChanging();
					this._updatedByID = value;
					this.SendPropertyChanged("UpdatedByID");
					this.OnUpdatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedDate", Name="updated_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> UpdatedDate
		{
			get
			{
				return this._updatedDate;
			}
			set
			{
				if ((_updatedDate != value))
				{
					this.OnUpdatedDateChanging(value);
					this.SendPropertyChanging();
					this._updatedDate = value;
					this.SendPropertyChanged("UpdatedDate");
					this.OnUpdatedDateChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_funcionario", OtherKey="FpUserGroupIndexID", ThisKey="ID", Name="FK50401DDB30F2CF89")]
		[DebuggerNonUserCode()]
		public EntitySet<Funcionario> Funcionario
		{
			get
			{
				return this._funcionario;
			}
			set
			{
				this._funcionario = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_applicationUser", OtherKey="ID", ThisKey="UpdatedByID", Name="FK52FD1BC213D9D401", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser
		{
			get
			{
				return this._applicationUser.Entity;
			}
			set
			{
				if (((this._applicationUser.Entity == value) 
							== false))
				{
					if ((this._applicationUser.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser.Entity;
						this._applicationUser.Entity = null;
						previousApplicationUser.DeviceTimeZoneGroup.Remove(this);
					}
					this._applicationUser.Entity = value;
					if ((value != null))
					{
						value.DeviceTimeZoneGroup.Add(this);
						_updatedByID = value.ID;
					}
					else
					{
						_updatedByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_deviceTimeZone", OtherKey="ID", ThisKey="TimeZone1ID", Name="FK52FD1BC25E9A41BF", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public DeviceTimeZone DeviceTimeZone
		{
			get
			{
				return this._deviceTimeZone.Entity;
			}
			set
			{
				if (((this._deviceTimeZone.Entity == value) 
							== false))
				{
					if ((this._deviceTimeZone.Entity != null))
					{
						DeviceTimeZone previousDeviceTimeZone = this._deviceTimeZone.Entity;
						this._deviceTimeZone.Entity = null;
						previousDeviceTimeZone.DeviceTimeZoneGroup.Remove(this);
					}
					this._deviceTimeZone.Entity = value;
					if ((value != null))
					{
						value.DeviceTimeZoneGroup.Add(this);
						_timeZone1id = value.ID;
					}
					else
					{
						_timeZone1id = null;
					}
				}
			}
		}
		
		[Association(Storage="_deviceTimeZone1", OtherKey="ID", ThisKey="TimeZone2ID", Name="FK52FD1BC25E9AB61E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public DeviceTimeZone DeviceTimeZone1
		{
			get
			{
				return this._deviceTimeZone1.Entity;
			}
			set
			{
				if (((this._deviceTimeZone1.Entity == value) 
							== false))
				{
					if ((this._deviceTimeZone1.Entity != null))
					{
						DeviceTimeZone previousDeviceTimeZone = this._deviceTimeZone1.Entity;
						this._deviceTimeZone1.Entity = null;
						previousDeviceTimeZone.DeviceTimeZoneGroup1.Remove(this);
					}
					this._deviceTimeZone1.Entity = value;
					if ((value != null))
					{
						value.DeviceTimeZoneGroup1.Add(this);
						_timeZone2id = value.ID;
					}
					else
					{
						_timeZone2id = null;
					}
				}
			}
		}
		
		[Association(Storage="_deviceTimeZone2", OtherKey="ID", ThisKey="TimeZone3ID", Name="FK52FD1BC25E9B2A7D", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public DeviceTimeZone DeviceTimeZone2
		{
			get
			{
				return this._deviceTimeZone2.Entity;
			}
			set
			{
				if (((this._deviceTimeZone2.Entity == value) 
							== false))
				{
					if ((this._deviceTimeZone2.Entity != null))
					{
						DeviceTimeZone previousDeviceTimeZone = this._deviceTimeZone2.Entity;
						this._deviceTimeZone2.Entity = null;
						previousDeviceTimeZone.DeviceTimeZoneGroup2.Remove(this);
					}
					this._deviceTimeZone2.Entity = value;
					if ((value != null))
					{
						value.DeviceTimeZoneGroup2.Add(this);
						_timeZone3id = value.ID;
					}
					else
					{
						_timeZone3id = null;
					}
				}
			}
		}
		
		[Association(Storage="_applicationUser1", OtherKey="ID", ThisKey="CreatedByID", Name="FK52FD1BC2F2EB5C6E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser1
		{
			get
			{
				return this._applicationUser1.Entity;
			}
			set
			{
				if (((this._applicationUser1.Entity == value) 
							== false))
				{
					if ((this._applicationUser1.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser1.Entity;
						this._applicationUser1.Entity = null;
						previousApplicationUser.DeviceTimeZoneGroup1.Remove(this);
					}
					this._applicationUser1.Entity = value;
					if ((value != null))
					{
						value.DeviceTimeZoneGroup1.Add(this);
						_createdByID = value.ID;
					}
					else
					{
						_createdByID = null;
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Funcionario_Attach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.DeviceTimeZoneGroup = this;
		}
		
		private void Funcionario_Detach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.DeviceTimeZoneGroup = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.device_type")]
	public partial class DeviceType : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private long _id;
		
		private string _nome;
		
		private int _typeNumber;
		
		private long _version;
		
		private EntitySet<Device> _device;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnNomeChanged();
		
		partial void OnNomeChanging(string value);
		
		partial void OnTypeNumberChanged();
		
		partial void OnTypeNumberChanging(int value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public DeviceType()
		{
			_device = new EntitySet<Device>(new Action<Device>(this.Device_Attach), new Action<Device>(this.Device_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_nome", Name="nome", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if (((_nome == value) 
							== false))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[Column(Storage="_typeNumber", Name="type_number", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int TypeNumber
		{
			get
			{
				return this._typeNumber;
			}
			set
			{
				if ((_typeNumber != value))
				{
					this.OnTypeNumberChanging(value);
					this.SendPropertyChanging();
					this._typeNumber = value;
					this.SendPropertyChanged("TypeNumber");
					this.OnTypeNumberChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_device", OtherKey="TypeID", ThisKey="ID", Name="FKB06B1E561D5EDFDE")]
		[DebuggerNonUserCode()]
		public EntitySet<Device> Device
		{
			get
			{
				return this._device;
			}
			set
			{
				this._device = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Device_Attach(Device entity)
		{
			this.SendPropertyChanging();
			entity.DeviceType = this;
		}
		
		private void Device_Detach(Device entity)
		{
			this.SendPropertyChanging();
			entity.DeviceType = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.distrito")]
	public partial class Distrito : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private long _code;
		
		private long _id;
		
		private string _nome;
		
		private long _provinciaID;
		
		private long _version;
		
		private EntitySet<Funcionario> _funcionario;
		
		private EntitySet<Empresa> _empresa;
		
		private EntitySet<PostoAdministrativo> _postoAdministrativo;
		
		private EntityRef<Provincia> _provincia = new EntityRef<Provincia>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCodeChanged();
		
		partial void OnCodeChanging(long value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnNomeChanged();
		
		partial void OnNomeChanging(string value);
		
		partial void OnProvinciaIDChanged();
		
		partial void OnProvinciaIDChanging(long value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public Distrito()
		{
			_funcionario = new EntitySet<Funcionario>(new Action<Funcionario>(this.Funcionario_Attach), new Action<Funcionario>(this.Funcionario_Detach));
			_empresa = new EntitySet<Empresa>(new Action<Empresa>(this.Empresa_Attach), new Action<Empresa>(this.Empresa_Detach));
			_postoAdministrativo = new EntitySet<PostoAdministrativo>(new Action<PostoAdministrativo>(this.PostoAdministrativo_Attach), new Action<PostoAdministrativo>(this.PostoAdministrativo_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_code", Name="code", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Code
		{
			get
			{
				return this._code;
			}
			set
			{
				if ((_code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_nome", Name="nome", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if (((_nome == value) 
							== false))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[Column(Storage="_provinciaID", Name="provincia_id", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ProvinciaID
		{
			get
			{
				return this._provinciaID;
			}
			set
			{
				if ((_provinciaID != value))
				{
					this.OnProvinciaIDChanging(value);
					this.SendPropertyChanging();
					this._provinciaID = value;
					this.SendPropertyChanged("ProvinciaID");
					this.OnProvinciaIDChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_funcionario", OtherKey="DistritoID", ThisKey="ID", Name="FK50401DDBCEDE1A35")]
		[DebuggerNonUserCode()]
		public EntitySet<Funcionario> Funcionario
		{
			get
			{
				return this._funcionario;
			}
			set
			{
				this._funcionario = value;
			}
		}
		
		[Association(Storage="_empresa", OtherKey="DistritoID", ThisKey="ID", Name="FK9F354089CEDE1A35")]
		[DebuggerNonUserCode()]
		public EntitySet<Empresa> Empresa
		{
			get
			{
				return this._empresa;
			}
			set
			{
				this._empresa = value;
			}
		}
		
		[Association(Storage="_postoAdministrativo", OtherKey="DistritoID", ThisKey="ID", Name="FKCFB37BA8CEDE1A35")]
		[DebuggerNonUserCode()]
		public EntitySet<PostoAdministrativo> PostoAdministrativo
		{
			get
			{
				return this._postoAdministrativo;
			}
			set
			{
				this._postoAdministrativo = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_provincia", OtherKey="ID", ThisKey="ProvinciaID", Name="FK11393598A58767F", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Provincia Provincia
		{
			get
			{
				return this._provincia.Entity;
			}
			set
			{
				if (((this._provincia.Entity == value) 
							== false))
				{
					if ((this._provincia.Entity != null))
					{
						Provincia previousProvincia = this._provincia.Entity;
						this._provincia.Entity = null;
						previousProvincia.Distrito.Remove(this);
					}
					this._provincia.Entity = value;
					if ((value != null))
					{
						value.Distrito.Add(this);
						_provinciaID = value.ID;
					}
					else
					{
						_provinciaID = default(long);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Funcionario_Attach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.Distrito = this;
		}
		
		private void Funcionario_Detach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.Distrito = null;
		}
		
		private void Empresa_Attach(Empresa entity)
		{
			this.SendPropertyChanging();
			entity.Distrito = this;
		}
		
		private void Empresa_Detach(Empresa entity)
		{
			this.SendPropertyChanging();
			entity.Distrito = null;
		}
		
		private void PostoAdministrativo_Attach(PostoAdministrativo entity)
		{
			this.SendPropertyChanging();
			entity.Distrito = this;
		}
		
		private void PostoAdministrativo_Detach(PostoAdministrativo entity)
		{
			this.SendPropertyChanging();
			entity.Distrito = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.documento_identificacao")]
	public partial class DocumentoIdentificacao : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _expressaoPadrao;
		
		private long _id;
		
		private string _nome;
		
		private long _version;
		
		private EntitySet<Funcionario> _funcionario;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnExpressaoPadraoChanged();
		
		partial void OnExpressaoPadraoChanging(string value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnNomeChanged();
		
		partial void OnNomeChanging(string value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public DocumentoIdentificacao()
		{
			_funcionario = new EntitySet<Funcionario>(new Action<Funcionario>(this.Funcionario_Attach), new Action<Funcionario>(this.Funcionario_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_expressaoPadrao", Name="expressao_padrao", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ExpressaoPadrao
		{
			get
			{
				return this._expressaoPadrao;
			}
			set
			{
				if (((_expressaoPadrao == value) 
							== false))
				{
					this.OnExpressaoPadraoChanging(value);
					this.SendPropertyChanging();
					this._expressaoPadrao = value;
					this.SendPropertyChanged("ExpressaoPadrao");
					this.OnExpressaoPadraoChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_nome", Name="nome", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if (((_nome == value) 
							== false))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_funcionario", OtherKey="TipoDocumentoIdentificacaoID", ThisKey="ID", Name="FK50401DDB7F0BE6B7")]
		[DebuggerNonUserCode()]
		public EntitySet<Funcionario> Funcionario
		{
			get
			{
				return this._funcionario;
			}
			set
			{
				this._funcionario = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Funcionario_Attach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.DocumentoIdentificacao = this;
		}
		
		private void Funcionario_Detach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.DocumentoIdentificacao = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.door")]
	public partial class Door : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<long> _createdByID;
		
		private System.Nullable<System.DateTime> _creationDate;
		
		private System.Nullable<long> _firstDeviceID;
		
		private long _id;
		
		private string _name;
		
		private System.Nullable<long> _secondDeviceID;
		
		private long _typeID;
		
		private System.Nullable<long> _updatedByID;
		
		private System.Nullable<System.DateTime> _updatedDate;
		
		private long _version;
		
		private EntitySet<Device> _device2;
		
		private EntityRef<ApplicationUser> _applicationUser = new EntityRef<ApplicationUser>();
		
		private EntityRef<Device> _device = new EntityRef<Device>();
		
		private EntityRef<DoorType> _doorType = new EntityRef<DoorType>();
		
		private EntityRef<ApplicationUser> _applicationUser1 = new EntityRef<ApplicationUser>();
		
		private EntityRef<Device> _device1 = new EntityRef<Device>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedByIDChanged();
		
		partial void OnCreatedByIDChanging(System.Nullable<long> value);
		
		partial void OnCreationDateChanged();
		
		partial void OnCreationDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnFirstDeviceIDChanged();
		
		partial void OnFirstDeviceIDChanging(System.Nullable<long> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnSecondDeviceIDChanged();
		
		partial void OnSecondDeviceIDChanging(System.Nullable<long> value);
		
		partial void OnTypeIDChanged();
		
		partial void OnTypeIDChanging(long value);
		
		partial void OnUpdatedByIDChanged();
		
		partial void OnUpdatedByIDChanging(System.Nullable<long> value);
		
		partial void OnUpdatedDateChanged();
		
		partial void OnUpdatedDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public Door()
		{
			_device2 = new EntitySet<Device>(new Action<Device>(this.Device2_Attach), new Action<Device>(this.Device2_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_createdByID", Name="created_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CreatedByID
		{
			get
			{
				return this._createdByID;
			}
			set
			{
				if ((_createdByID != value))
				{
					this.OnCreatedByIDChanging(value);
					this.SendPropertyChanging();
					this._createdByID = value;
					this.SendPropertyChanged("CreatedByID");
					this.OnCreatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_creationDate", Name="creation_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreationDate
		{
			get
			{
				return this._creationDate;
			}
			set
			{
				if ((_creationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._creationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[Column(Storage="_firstDeviceID", Name="first_device_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FirstDeviceID
		{
			get
			{
				return this._firstDeviceID;
			}
			set
			{
				if ((_firstDeviceID != value))
				{
					this.OnFirstDeviceIDChanging(value);
					this.SendPropertyChanging();
					this._firstDeviceID = value;
					this.SendPropertyChanged("FirstDeviceID");
					this.OnFirstDeviceIDChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_secondDeviceID", Name="second_device_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> SecondDeviceID
		{
			get
			{
				return this._secondDeviceID;
			}
			set
			{
				if ((_secondDeviceID != value))
				{
					this.OnSecondDeviceIDChanging(value);
					this.SendPropertyChanging();
					this._secondDeviceID = value;
					this.SendPropertyChanged("SecondDeviceID");
					this.OnSecondDeviceIDChanged();
				}
			}
		}
		
		[Column(Storage="_typeID", Name="type_id", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long TypeID
		{
			get
			{
				return this._typeID;
			}
			set
			{
				if ((_typeID != value))
				{
					this.OnTypeIDChanging(value);
					this.SendPropertyChanging();
					this._typeID = value;
					this.SendPropertyChanged("TypeID");
					this.OnTypeIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedByID", Name="updated_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UpdatedByID
		{
			get
			{
				return this._updatedByID;
			}
			set
			{
				if ((_updatedByID != value))
				{
					this.OnUpdatedByIDChanging(value);
					this.SendPropertyChanging();
					this._updatedByID = value;
					this.SendPropertyChanged("UpdatedByID");
					this.OnUpdatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedDate", Name="updated_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> UpdatedDate
		{
			get
			{
				return this._updatedDate;
			}
			set
			{
				if ((_updatedDate != value))
				{
					this.OnUpdatedDateChanging(value);
					this.SendPropertyChanging();
					this._updatedDate = value;
					this.SendPropertyChanged("UpdatedDate");
					this.OnUpdatedDateChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_device2", OtherKey="DoorID", ThisKey="ID", Name="FKB06B1E567726E68")]
		[DebuggerNonUserCode()]
		public EntitySet<Device> Device2
		{
			get
			{
				return this._device2;
			}
			set
			{
				this._device2 = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_applicationUser", OtherKey="ID", ThisKey="UpdatedByID", Name="FK2F23AE13D9D401", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser
		{
			get
			{
				return this._applicationUser.Entity;
			}
			set
			{
				if (((this._applicationUser.Entity == value) 
							== false))
				{
					if ((this._applicationUser.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser.Entity;
						this._applicationUser.Entity = null;
						previousApplicationUser.Door.Remove(this);
					}
					this._applicationUser.Entity = value;
					if ((value != null))
					{
						value.Door.Add(this);
						_updatedByID = value.ID;
					}
					else
					{
						_updatedByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_device", OtherKey="ID", ThisKey="FirstDeviceID", Name="FK2F23AE83CD9B19", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Device Device
		{
			get
			{
				return this._device.Entity;
			}
			set
			{
				if (((this._device.Entity == value) 
							== false))
				{
					if ((this._device.Entity != null))
					{
						Device previousDevice = this._device.Entity;
						this._device.Entity = null;
						previousDevice.Door.Remove(this);
					}
					this._device.Entity = value;
					if ((value != null))
					{
						value.Door.Add(this);
						_firstDeviceID = value.ID;
					}
					else
					{
						_firstDeviceID = null;
					}
				}
			}
		}
		
		[Association(Storage="_doorType", OtherKey="ID", ThisKey="TypeID", Name="FK2F23AEE455DCB6", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public DoorType DoorType
		{
			get
			{
				return this._doorType.Entity;
			}
			set
			{
				if (((this._doorType.Entity == value) 
							== false))
				{
					if ((this._doorType.Entity != null))
					{
						DoorType previousDoorType = this._doorType.Entity;
						this._doorType.Entity = null;
						previousDoorType.Door.Remove(this);
					}
					this._doorType.Entity = value;
					if ((value != null))
					{
						value.Door.Add(this);
						_typeID = value.ID;
					}
					else
					{
						_typeID = default(long);
					}
				}
			}
		}
		
		[Association(Storage="_applicationUser1", OtherKey="ID", ThisKey="CreatedByID", Name="FK2F23AEF2EB5C6E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser1
		{
			get
			{
				return this._applicationUser1.Entity;
			}
			set
			{
				if (((this._applicationUser1.Entity == value) 
							== false))
				{
					if ((this._applicationUser1.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser1.Entity;
						this._applicationUser1.Entity = null;
						previousApplicationUser.Door1.Remove(this);
					}
					this._applicationUser1.Entity = value;
					if ((value != null))
					{
						value.Door1.Add(this);
						_createdByID = value.ID;
					}
					else
					{
						_createdByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_device1", OtherKey="ID", ThisKey="SecondDeviceID", Name="FK2F23AEF2F9A7DD", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Device Device1
		{
			get
			{
				return this._device1.Entity;
			}
			set
			{
				if (((this._device1.Entity == value) 
							== false))
				{
					if ((this._device1.Entity != null))
					{
						Device previousDevice = this._device1.Entity;
						this._device1.Entity = null;
						previousDevice.Door1.Remove(this);
					}
					this._device1.Entity = value;
					if ((value != null))
					{
						value.Door1.Add(this);
						_secondDeviceID = value.ID;
					}
					else
					{
						_secondDeviceID = null;
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Device2_Attach(Device entity)
		{
			this.SendPropertyChanging();
			entity.Door2 = this;
		}
		
		private void Device2_Detach(Device entity)
		{
			this.SendPropertyChanging();
			entity.Door2 = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.door_type")]
	public partial class DoorType : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _fingerprints;
		
		private long _id;
		
		private string _nome;
		
		private long _version;
		
		private EntitySet<Door> _door;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnFingerprintsChanged();
		
		partial void OnFingerprintsChanging(int value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnNomeChanged();
		
		partial void OnNomeChanging(string value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public DoorType()
		{
			_door = new EntitySet<Door>(new Action<Door>(this.Door_Attach), new Action<Door>(this.Door_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_fingerprints", Name="fingerprints", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int Fingerprints
		{
			get
			{
				return this._fingerprints;
			}
			set
			{
				if ((_fingerprints != value))
				{
					this.OnFingerprintsChanging(value);
					this.SendPropertyChanging();
					this._fingerprints = value;
					this.SendPropertyChanged("Fingerprints");
					this.OnFingerprintsChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_nome", Name="nome", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if (((_nome == value) 
							== false))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_door", OtherKey="TypeID", ThisKey="ID", Name="FK2F23AEE455DCB6")]
		[DebuggerNonUserCode()]
		public EntitySet<Door> Door
		{
			get
			{
				return this._door;
			}
			set
			{
				this._door = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Door_Attach(Door entity)
		{
			this.SendPropertyChanging();
			entity.DoorType = this;
		}
		
		private void Door_Detach(Door entity)
		{
			this.SendPropertyChanging();
			entity.DoorType = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.empresa")]
	public partial class Empresa : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<long> _attendanceRulesID;
		
		private string _avenidaRua;
		
		private System.Nullable<long> _createdByID;
		
		private System.Nullable<System.DateTime> _creationDate;
		
		private System.Nullable<long> _distritoID;
		
		private string _email;
		
		private string _fax;
		
		private long _id;
		
		private System.Nullable<long> _localidadeID;
		
		private string _nome;
		
		private int _numero;
		
		private System.Nullable<long> _postoAdministrativoID;
		
		private System.Nullable<long> _provinciaID;
		
		private string _telefone;
		
		private System.Nullable<long> _updatedByID;
		
		private System.Nullable<System.DateTime> _updatedDate;
		
		private long _version;
		
		private EntitySet<Categoria> _categoria;
		
		private EntitySet<Departamento> _departamento;
		
		private EntityRef<ApplicationUser> _applicationUser = new EntityRef<ApplicationUser>();
		
		private EntityRef<AttendanceRules> _attendanceRules = new EntityRef<AttendanceRules>();
		
		private EntityRef<Localidade> _localidade = new EntityRef<Localidade>();
		
		private EntityRef<Provincia> _provincia = new EntityRef<Provincia>();
		
		private EntityRef<PostoAdministrativo> _postoAdministrativo = new EntityRef<PostoAdministrativo>();
		
		private EntityRef<Distrito> _distrito = new EntityRef<Distrito>();
		
		private EntityRef<ApplicationUser> _applicationUser1 = new EntityRef<ApplicationUser>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAttendanceRulesIDChanged();
		
		partial void OnAttendanceRulesIDChanging(System.Nullable<long> value);
		
		partial void OnAvenidaRuaChanged();
		
		partial void OnAvenidaRuaChanging(string value);
		
		partial void OnCreatedByIDChanged();
		
		partial void OnCreatedByIDChanging(System.Nullable<long> value);
		
		partial void OnCreationDateChanged();
		
		partial void OnCreationDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnDistritoIDChanged();
		
		partial void OnDistritoIDChanging(System.Nullable<long> value);
		
		partial void OnEmailChanged();
		
		partial void OnEmailChanging(string value);
		
		partial void OnFaxChanged();
		
		partial void OnFaxChanging(string value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnLocalidadeIDChanged();
		
		partial void OnLocalidadeIDChanging(System.Nullable<long> value);
		
		partial void OnNomeChanged();
		
		partial void OnNomeChanging(string value);
		
		partial void OnNumeroChanged();
		
		partial void OnNumeroChanging(int value);
		
		partial void OnPostoAdministrativoIDChanged();
		
		partial void OnPostoAdministrativoIDChanging(System.Nullable<long> value);
		
		partial void OnProvinciaIDChanged();
		
		partial void OnProvinciaIDChanging(System.Nullable<long> value);
		
		partial void OnTelefoneChanged();
		
		partial void OnTelefoneChanging(string value);
		
		partial void OnUpdatedByIDChanged();
		
		partial void OnUpdatedByIDChanging(System.Nullable<long> value);
		
		partial void OnUpdatedDateChanged();
		
		partial void OnUpdatedDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public Empresa()
		{
			_categoria = new EntitySet<Categoria>(new Action<Categoria>(this.Categoria_Attach), new Action<Categoria>(this.Categoria_Detach));
			_departamento = new EntitySet<Departamento>(new Action<Departamento>(this.Departamento_Attach), new Action<Departamento>(this.Departamento_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_attendanceRulesID", Name="attendance_rules_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> AttendanceRulesID
		{
			get
			{
				return this._attendanceRulesID;
			}
			set
			{
				if ((_attendanceRulesID != value))
				{
					this.OnAttendanceRulesIDChanging(value);
					this.SendPropertyChanging();
					this._attendanceRulesID = value;
					this.SendPropertyChanged("AttendanceRulesID");
					this.OnAttendanceRulesIDChanged();
				}
			}
		}
		
		[Column(Storage="_avenidaRua", Name="avenida_rua", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string AvenidaRua
		{
			get
			{
				return this._avenidaRua;
			}
			set
			{
				if (((_avenidaRua == value) 
							== false))
				{
					this.OnAvenidaRuaChanging(value);
					this.SendPropertyChanging();
					this._avenidaRua = value;
					this.SendPropertyChanged("AvenidaRua");
					this.OnAvenidaRuaChanged();
				}
			}
		}
		
		[Column(Storage="_createdByID", Name="created_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CreatedByID
		{
			get
			{
				return this._createdByID;
			}
			set
			{
				if ((_createdByID != value))
				{
					this.OnCreatedByIDChanging(value);
					this.SendPropertyChanging();
					this._createdByID = value;
					this.SendPropertyChanged("CreatedByID");
					this.OnCreatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_creationDate", Name="creation_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreationDate
		{
			get
			{
				return this._creationDate;
			}
			set
			{
				if ((_creationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._creationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[Column(Storage="_distritoID", Name="distrito_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> DistritoID
		{
			get
			{
				return this._distritoID;
			}
			set
			{
				if ((_distritoID != value))
				{
					this.OnDistritoIDChanging(value);
					this.SendPropertyChanging();
					this._distritoID = value;
					this.SendPropertyChanged("DistritoID");
					this.OnDistritoIDChanged();
				}
			}
		}
		
		[Column(Storage="_email", Name="email", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Email
		{
			get
			{
				return this._email;
			}
			set
			{
				if (((_email == value) 
							== false))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[Column(Storage="_fax", Name="fax", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Fax
		{
			get
			{
				return this._fax;
			}
			set
			{
				if (((_fax == value) 
							== false))
				{
					this.OnFaxChanging(value);
					this.SendPropertyChanging();
					this._fax = value;
					this.SendPropertyChanged("Fax");
					this.OnFaxChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_localidadeID", Name="localidade_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> LocalidadeID
		{
			get
			{
				return this._localidadeID;
			}
			set
			{
				if ((_localidadeID != value))
				{
					this.OnLocalidadeIDChanging(value);
					this.SendPropertyChanging();
					this._localidadeID = value;
					this.SendPropertyChanged("LocalidadeID");
					this.OnLocalidadeIDChanged();
				}
			}
		}
		
		[Column(Storage="_nome", Name="nome", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if (((_nome == value) 
							== false))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[Column(Storage="_numero", Name="numero", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int Numero
		{
			get
			{
				return this._numero;
			}
			set
			{
				if ((_numero != value))
				{
					this.OnNumeroChanging(value);
					this.SendPropertyChanging();
					this._numero = value;
					this.SendPropertyChanged("Numero");
					this.OnNumeroChanged();
				}
			}
		}
		
		[Column(Storage="_postoAdministrativoID", Name="posto_administrativo_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> PostoAdministrativoID
		{
			get
			{
				return this._postoAdministrativoID;
			}
			set
			{
				if ((_postoAdministrativoID != value))
				{
					this.OnPostoAdministrativoIDChanging(value);
					this.SendPropertyChanging();
					this._postoAdministrativoID = value;
					this.SendPropertyChanged("PostoAdministrativoID");
					this.OnPostoAdministrativoIDChanged();
				}
			}
		}
		
		[Column(Storage="_provinciaID", Name="provincia_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ProvinciaID
		{
			get
			{
				return this._provinciaID;
			}
			set
			{
				if ((_provinciaID != value))
				{
					this.OnProvinciaIDChanging(value);
					this.SendPropertyChanging();
					this._provinciaID = value;
					this.SendPropertyChanged("ProvinciaID");
					this.OnProvinciaIDChanged();
				}
			}
		}
		
		[Column(Storage="_telefone", Name="telefone", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Telefone
		{
			get
			{
				return this._telefone;
			}
			set
			{
				if (((_telefone == value) 
							== false))
				{
					this.OnTelefoneChanging(value);
					this.SendPropertyChanging();
					this._telefone = value;
					this.SendPropertyChanged("Telefone");
					this.OnTelefoneChanged();
				}
			}
		}
		
		[Column(Storage="_updatedByID", Name="updated_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UpdatedByID
		{
			get
			{
				return this._updatedByID;
			}
			set
			{
				if ((_updatedByID != value))
				{
					this.OnUpdatedByIDChanging(value);
					this.SendPropertyChanging();
					this._updatedByID = value;
					this.SendPropertyChanged("UpdatedByID");
					this.OnUpdatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedDate", Name="updated_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> UpdatedDate
		{
			get
			{
				return this._updatedDate;
			}
			set
			{
				if ((_updatedDate != value))
				{
					this.OnUpdatedDateChanging(value);
					this.SendPropertyChanging();
					this._updatedDate = value;
					this.SendPropertyChanged("UpdatedDate");
					this.OnUpdatedDateChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_categoria", OtherKey="EmpresaID", ThisKey="ID", Name="FK5D54E1336BA2C0C4")]
		[DebuggerNonUserCode()]
		public EntitySet<Categoria> Categoria
		{
			get
			{
				return this._categoria;
			}
			set
			{
				this._categoria = value;
			}
		}
		
		[Association(Storage="_departamento", OtherKey="EmpresaID", ThisKey="ID", Name="FKB3FD2C046BA2C0C4")]
		[DebuggerNonUserCode()]
		public EntitySet<Departamento> Departamento
		{
			get
			{
				return this._departamento;
			}
			set
			{
				this._departamento = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_applicationUser", OtherKey="ID", ThisKey="UpdatedByID", Name="FK9F35408913D9D401", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser
		{
			get
			{
				return this._applicationUser.Entity;
			}
			set
			{
				if (((this._applicationUser.Entity == value) 
							== false))
				{
					if ((this._applicationUser.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser.Entity;
						this._applicationUser.Entity = null;
						previousApplicationUser.Empresa.Remove(this);
					}
					this._applicationUser.Entity = value;
					if ((value != null))
					{
						value.Empresa.Add(this);
						_updatedByID = value.ID;
					}
					else
					{
						_updatedByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_attendanceRules", OtherKey="ID", ThisKey="AttendanceRulesID", Name="FK9F35408967319331", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public AttendanceRules AttendanceRules
		{
			get
			{
				return this._attendanceRules.Entity;
			}
			set
			{
				if (((this._attendanceRules.Entity == value) 
							== false))
				{
					if ((this._attendanceRules.Entity != null))
					{
						AttendanceRules previousAttendanceRules = this._attendanceRules.Entity;
						this._attendanceRules.Entity = null;
						previousAttendanceRules.Empresa.Remove(this);
					}
					this._attendanceRules.Entity = value;
					if ((value != null))
					{
						value.Empresa.Add(this);
						_attendanceRulesID = value.ID;
					}
					else
					{
						_attendanceRulesID = null;
					}
				}
			}
		}
		
		[Association(Storage="_localidade", OtherKey="ID", ThisKey="LocalidadeID", Name="FK9F354089891EC8F5", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Localidade Localidade
		{
			get
			{
				return this._localidade.Entity;
			}
			set
			{
				if (((this._localidade.Entity == value) 
							== false))
				{
					if ((this._localidade.Entity != null))
					{
						Localidade previousLocalidade = this._localidade.Entity;
						this._localidade.Entity = null;
						previousLocalidade.Empresa.Remove(this);
					}
					this._localidade.Entity = value;
					if ((value != null))
					{
						value.Empresa.Add(this);
						_localidadeID = value.ID;
					}
					else
					{
						_localidadeID = null;
					}
				}
			}
		}
		
		[Association(Storage="_provincia", OtherKey="ID", ThisKey="ProvinciaID", Name="FK9F354089A58767F", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Provincia Provincia
		{
			get
			{
				return this._provincia.Entity;
			}
			set
			{
				if (((this._provincia.Entity == value) 
							== false))
				{
					if ((this._provincia.Entity != null))
					{
						Provincia previousProvincia = this._provincia.Entity;
						this._provincia.Entity = null;
						previousProvincia.Empresa.Remove(this);
					}
					this._provincia.Entity = value;
					if ((value != null))
					{
						value.Empresa.Add(this);
						_provinciaID = value.ID;
					}
					else
					{
						_provinciaID = null;
					}
				}
			}
		}
		
		[Association(Storage="_postoAdministrativo", OtherKey="ID", ThisKey="PostoAdministrativoID", Name="FK9F354089B1014D9E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public PostoAdministrativo PostoAdministrativo
		{
			get
			{
				return this._postoAdministrativo.Entity;
			}
			set
			{
				if (((this._postoAdministrativo.Entity == value) 
							== false))
				{
					if ((this._postoAdministrativo.Entity != null))
					{
						PostoAdministrativo previousPostoAdministrativo = this._postoAdministrativo.Entity;
						this._postoAdministrativo.Entity = null;
						previousPostoAdministrativo.Empresa.Remove(this);
					}
					this._postoAdministrativo.Entity = value;
					if ((value != null))
					{
						value.Empresa.Add(this);
						_postoAdministrativoID = value.ID;
					}
					else
					{
						_postoAdministrativoID = null;
					}
				}
			}
		}
		
		[Association(Storage="_distrito", OtherKey="ID", ThisKey="DistritoID", Name="FK9F354089CEDE1A35", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Distrito Distrito
		{
			get
			{
				return this._distrito.Entity;
			}
			set
			{
				if (((this._distrito.Entity == value) 
							== false))
				{
					if ((this._distrito.Entity != null))
					{
						Distrito previousDistrito = this._distrito.Entity;
						this._distrito.Entity = null;
						previousDistrito.Empresa.Remove(this);
					}
					this._distrito.Entity = value;
					if ((value != null))
					{
						value.Empresa.Add(this);
						_distritoID = value.ID;
					}
					else
					{
						_distritoID = null;
					}
				}
			}
		}
		
		[Association(Storage="_applicationUser1", OtherKey="ID", ThisKey="CreatedByID", Name="FK9F354089F2EB5C6E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser1
		{
			get
			{
				return this._applicationUser1.Entity;
			}
			set
			{
				if (((this._applicationUser1.Entity == value) 
							== false))
				{
					if ((this._applicationUser1.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser1.Entity;
						this._applicationUser1.Entity = null;
						previousApplicationUser.Empresa1.Remove(this);
					}
					this._applicationUser1.Entity = value;
					if ((value != null))
					{
						value.Empresa1.Add(this);
						_createdByID = value.ID;
					}
					else
					{
						_createdByID = null;
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Categoria_Attach(Categoria entity)
		{
			this.SendPropertyChanging();
			entity.Empresa = this;
		}
		
		private void Categoria_Detach(Categoria entity)
		{
			this.SendPropertyChanging();
			entity.Empresa = null;
		}
		
		private void Departamento_Attach(Departamento entity)
		{
			this.SendPropertyChanging();
			entity.Empresa = this;
		}
		
		private void Departamento_Detach(Departamento entity)
		{
			this.SendPropertyChanging();
			entity.Empresa = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.estado_civil")]
	public partial class EstadoCivil : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private long _id;
		
		private string _nome;
		
		private long _version;
		
		private EntitySet<Funcionario> _funcionario;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnNomeChanged();
		
		partial void OnNomeChanging(string value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public EstadoCivil()
		{
			_funcionario = new EntitySet<Funcionario>(new Action<Funcionario>(this.Funcionario_Attach), new Action<Funcionario>(this.Funcionario_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_nome", Name="nome", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if (((_nome == value) 
							== false))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_funcionario", OtherKey="EstadoCivilID", ThisKey="ID", Name="FK50401DDB6AD2AC12")]
		[DebuggerNonUserCode()]
		public EntitySet<Funcionario> Funcionario
		{
			get
			{
				return this._funcionario;
			}
			set
			{
				this._funcionario = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Funcionario_Attach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.EstadoCivil = this;
		}
		
		private void Funcionario_Detach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.EstadoCivil = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.falta")]
	public partial class Falta : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private bool _accepted;
		
		private System.Nullable<long> _acceptedConfirmedBy1id;
		
		private System.Nullable<long> _acceptedConfirmedBy2id;
		
		private string _descricao;
		
		private System.DateTime _dia;
		
		private long _funcionarioID;
		
		private System.DateTime _horaFim;
		
		private System.DateTime _horaInicio;
		
		private long _id;
		
		private bool _justificada;
		
		private long _tipoID;
		
		private bool _valida;
		
		private long _version;
		
		private EntityRef<ApplicationUser> _applicationUser = new EntityRef<ApplicationUser>();
		
		private EntityRef<ApplicationUser> _applicationUser1 = new EntityRef<ApplicationUser>();
		
		private EntityRef<TipoFalta> _tipoFalta = new EntityRef<TipoFalta>();
		
		private EntityRef<Funcionario> _funcionario = new EntityRef<Funcionario>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAcceptedChanged();
		
		partial void OnAcceptedChanging(bool value);
		
		partial void OnAcceptedConfirmedBy1IDChanged();
		
		partial void OnAcceptedConfirmedBy1IDChanging(System.Nullable<long> value);
		
		partial void OnAcceptedConfirmedBy2IDChanged();
		
		partial void OnAcceptedConfirmedBy2IDChanging(System.Nullable<long> value);
		
		partial void OnDescricaoChanged();
		
		partial void OnDescricaoChanging(string value);
		
		partial void OnDiaChanged();
		
		partial void OnDiaChanging(System.DateTime value);
		
		partial void OnFuncionarioIDChanged();
		
		partial void OnFuncionarioIDChanging(long value);
		
		partial void OnHoraFimChanged();
		
		partial void OnHoraFimChanging(System.DateTime value);
		
		partial void OnHoraInicioChanged();
		
		partial void OnHoraInicioChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnJustificadaChanged();
		
		partial void OnJustificadaChanging(bool value);
		
		partial void OnTipoIDChanged();
		
		partial void OnTipoIDChanging(long value);
		
		partial void OnValidaChanged();
		
		partial void OnValidaChanging(bool value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public Falta()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_accepted", Name="accepted", DbType="bit(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool Accepted
		{
			get
			{
				return this._accepted;
			}
			set
			{
				if ((_accepted != value))
				{
					this.OnAcceptedChanging(value);
					this.SendPropertyChanging();
					this._accepted = value;
					this.SendPropertyChanged("Accepted");
					this.OnAcceptedChanged();
				}
			}
		}
		
		[Column(Storage="_acceptedConfirmedBy1id", Name="accepted_confirmed_by1_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> AcceptedConfirmedBy1ID
		{
			get
			{
				return this._acceptedConfirmedBy1id;
			}
			set
			{
				if ((_acceptedConfirmedBy1id != value))
				{
					this.OnAcceptedConfirmedBy1IDChanging(value);
					this.SendPropertyChanging();
					this._acceptedConfirmedBy1id = value;
					this.SendPropertyChanged("AcceptedConfirmedBy1ID");
					this.OnAcceptedConfirmedBy1IDChanged();
				}
			}
		}
		
		[Column(Storage="_acceptedConfirmedBy2id", Name="accepted_confirmed_by2_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> AcceptedConfirmedBy2ID
		{
			get
			{
				return this._acceptedConfirmedBy2id;
			}
			set
			{
				if ((_acceptedConfirmedBy2id != value))
				{
					this.OnAcceptedConfirmedBy2IDChanging(value);
					this.SendPropertyChanging();
					this._acceptedConfirmedBy2id = value;
					this.SendPropertyChanged("AcceptedConfirmedBy2ID");
					this.OnAcceptedConfirmedBy2IDChanged();
				}
			}
		}
		
		[Column(Storage="_descricao", Name="descricao", DbType="varchar(255)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Descricao
		{
			get
			{
				return this._descricao;
			}
			set
			{
				if (((_descricao == value) 
							== false))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[Column(Storage="_dia", Name="dia", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime Dia
		{
			get
			{
				return this._dia;
			}
			set
			{
				if ((_dia != value))
				{
					this.OnDiaChanging(value);
					this.SendPropertyChanging();
					this._dia = value;
					this.SendPropertyChanged("Dia");
					this.OnDiaChanged();
				}
			}
		}
		
		[Column(Storage="_funcionarioID", Name="funcionario_id", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long FuncionarioID
		{
			get
			{
				return this._funcionarioID;
			}
			set
			{
				if ((_funcionarioID != value))
				{
					this.OnFuncionarioIDChanging(value);
					this.SendPropertyChanging();
					this._funcionarioID = value;
					this.SendPropertyChanged("FuncionarioID");
					this.OnFuncionarioIDChanged();
				}
			}
		}
		
		[Column(Storage="_horaFim", Name="hora_fim", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime HoraFim
		{
			get
			{
				return this._horaFim;
			}
			set
			{
				if ((_horaFim != value))
				{
					this.OnHoraFimChanging(value);
					this.SendPropertyChanging();
					this._horaFim = value;
					this.SendPropertyChanged("HoraFim");
					this.OnHoraFimChanged();
				}
			}
		}
		
		[Column(Storage="_horaInicio", Name="hora_inicio", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime HoraInicio
		{
			get
			{
				return this._horaInicio;
			}
			set
			{
				if ((_horaInicio != value))
				{
					this.OnHoraInicioChanging(value);
					this.SendPropertyChanging();
					this._horaInicio = value;
					this.SendPropertyChanged("HoraInicio");
					this.OnHoraInicioChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_justificada", Name="justificada", DbType="bit(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool Justificada
		{
			get
			{
				return this._justificada;
			}
			set
			{
				if ((_justificada != value))
				{
					this.OnJustificadaChanging(value);
					this.SendPropertyChanging();
					this._justificada = value;
					this.SendPropertyChanged("Justificada");
					this.OnJustificadaChanged();
				}
			}
		}
		
		[Column(Storage="_tipoID", Name="tipo_id", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long TipoID
		{
			get
			{
				return this._tipoID;
			}
			set
			{
				if ((_tipoID != value))
				{
					this.OnTipoIDChanging(value);
					this.SendPropertyChanging();
					this._tipoID = value;
					this.SendPropertyChanged("TipoID");
					this.OnTipoIDChanged();
				}
			}
		}
		
		[Column(Storage="_valida", Name="valida", DbType="bit(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool Valida
		{
			get
			{
				return this._valida;
			}
			set
			{
				if ((_valida != value))
				{
					this.OnValidaChanging(value);
					this.SendPropertyChanging();
					this._valida = value;
					this.SendPropertyChanged("Valida");
					this.OnValidaChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_applicationUser", OtherKey="ID", ThisKey="AcceptedConfirmedBy1ID", Name="FK5CB193E4452BDBA", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser
		{
			get
			{
				return this._applicationUser.Entity;
			}
			set
			{
				if (((this._applicationUser.Entity == value) 
							== false))
				{
					if ((this._applicationUser.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser.Entity;
						this._applicationUser.Entity = null;
						previousApplicationUser.Falta.Remove(this);
					}
					this._applicationUser.Entity = value;
					if ((value != null))
					{
						value.Falta.Add(this);
						_acceptedConfirmedBy1id = value.ID;
					}
					else
					{
						_acceptedConfirmedBy1id = null;
					}
				}
			}
		}
		
		[Association(Storage="_applicationUser1", OtherKey="ID", ThisKey="AcceptedConfirmedBy2ID", Name="FK5CB193E44533219", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser1
		{
			get
			{
				return this._applicationUser1.Entity;
			}
			set
			{
				if (((this._applicationUser1.Entity == value) 
							== false))
				{
					if ((this._applicationUser1.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser1.Entity;
						this._applicationUser1.Entity = null;
						previousApplicationUser.Falta1.Remove(this);
					}
					this._applicationUser1.Entity = value;
					if ((value != null))
					{
						value.Falta1.Add(this);
						_acceptedConfirmedBy2id = value.ID;
					}
					else
					{
						_acceptedConfirmedBy2id = null;
					}
				}
			}
		}
		
		[Association(Storage="_tipoFalta", OtherKey="ID", ThisKey="TipoID", Name="FK5CB193EA2F5D9A", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public TipoFalta TipoFalta
		{
			get
			{
				return this._tipoFalta.Entity;
			}
			set
			{
				if (((this._tipoFalta.Entity == value) 
							== false))
				{
					if ((this._tipoFalta.Entity != null))
					{
						TipoFalta previousTipoFalta = this._tipoFalta.Entity;
						this._tipoFalta.Entity = null;
						previousTipoFalta.Falta.Remove(this);
					}
					this._tipoFalta.Entity = value;
					if ((value != null))
					{
						value.Falta.Add(this);
						_tipoID = value.ID;
					}
					else
					{
						_tipoID = default(long);
					}
				}
			}
		}
		
		[Association(Storage="_funcionario", OtherKey="ID", ThisKey="FuncionarioID", Name="FK5CB193EFA7F0284", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Funcionario Funcionario
		{
			get
			{
				return this._funcionario.Entity;
			}
			set
			{
				if (((this._funcionario.Entity == value) 
							== false))
				{
					if ((this._funcionario.Entity != null))
					{
						Funcionario previousFuncionario = this._funcionario.Entity;
						this._funcionario.Entity = null;
						previousFuncionario.Falta.Remove(this);
					}
					this._funcionario.Entity = value;
					if ((value != null))
					{
						value.Falta.Add(this);
						_funcionarioID = value.ID;
					}
					else
					{
						_funcionarioID = default(long);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="beta_interactive_sisga.feriado")]
	public partial class Feriado : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<long> _createdByID;
		
		private System.Nullable<System.DateTime> _creationDate;
		
		private System.DateTime _data;
		
		private int _duracao;
		
		private long _id;
		
		private string _nome;
		
		private System.Nullable<long> _updatedByID;
		
		private System.Nullable<System.DateTime> _updatedDate;
		
		private long _version;
		
		private EntityRef<ApplicationUser> _applicationUser = new EntityRef<ApplicationUser>();
		
		private EntityRef<ApplicationUser> _applicationUser1 = new EntityRef<ApplicationUser>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedByIDChanged();
		
		partial void OnCreatedByIDChanging(System.Nullable<long> value);
		
		partial void OnCreationDateChanged();
		
		partial void OnCreationDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnDataChanged();
		
		partial void OnDataChanging(System.DateTime value);
		
		partial void OnDuracaoChanged();
		
		partial void OnDuracaoChanging(int value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnNomeChanged();
		
		partial void OnNomeChanging(string value);
		
		partial void OnUpdatedByIDChanged();
		
		partial void OnUpdatedByIDChanging(System.Nullable<long> value);
		
		partial void OnUpdatedDateChanged();
		
		partial void OnUpdatedDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public Feriado()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdByID", Name="created_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CreatedByID
		{
			get
			{
				return this._createdByID;
			}
			set
			{
				if ((_createdByID != value))
				{
					this.OnCreatedByIDChanging(value);
					this.SendPropertyChanging();
					this._createdByID = value;
					this.SendPropertyChanged("CreatedByID");
					this.OnCreatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_creationDate", Name="creation_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreationDate
		{
			get
			{
				return this._creationDate;
			}
			set
			{
				if ((_creationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._creationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[Column(Storage="_data", Name="data", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime Data
		{
			get
			{
				return this._data;
			}
			set
			{
				if ((_data != value))
				{
					this.OnDataChanging(value);
					this.SendPropertyChanging();
					this._data = value;
					this.SendPropertyChanged("Data");
					this.OnDataChanged();
				}
			}
		}
		
		[Column(Storage="_duracao", Name="duracao", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int Duracao
		{
			get
			{
				return this._duracao;
			}
			set
			{
				if ((_duracao != value))
				{
					this.OnDuracaoChanging(value);
					this.SendPropertyChanging();
					this._duracao = value;
					this.SendPropertyChanged("Duracao");
					this.OnDuracaoChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_nome", Name="nome", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if (((_nome == value) 
							== false))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[Column(Storage="_updatedByID", Name="updated_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UpdatedByID
		{
			get
			{
				return this._updatedByID;
			}
			set
			{
				if ((_updatedByID != value))
				{
					this.OnUpdatedByIDChanging(value);
					this.SendPropertyChanging();
					this._updatedByID = value;
					this.SendPropertyChanged("UpdatedByID");
					this.OnUpdatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedDate", Name="updated_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> UpdatedDate
		{
			get
			{
				return this._updatedDate;
			}
			set
			{
				if ((_updatedDate != value))
				{
					this.OnUpdatedDateChanging(value);
					this.SendPropertyChanging();
					this._updatedDate = value;
					this.SendPropertyChanged("UpdatedDate");
					this.OnUpdatedDateChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_applicationUser", OtherKey="ID", ThisKey="UpdatedByID", Name="FKC68CBDB613D9D401", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser
		{
			get
			{
				return this._applicationUser.Entity;
			}
			set
			{
				if (((this._applicationUser.Entity == value) 
							== false))
				{
					if ((this._applicationUser.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser.Entity;
						this._applicationUser.Entity = null;
						previousApplicationUser.Feriado.Remove(this);
					}
					this._applicationUser.Entity = value;
					if ((value != null))
					{
						value.Feriado.Add(this);
						_updatedByID = value.ID;
					}
					else
					{
						_updatedByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_applicationUser1", OtherKey="ID", ThisKey="CreatedByID", Name="FKC68CBDB6F2EB5C6E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser1
		{
			get
			{
				return this._applicationUser1.Entity;
			}
			set
			{
				if (((this._applicationUser1.Entity == value) 
							== false))
				{
					if ((this._applicationUser1.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser1.Entity;
						this._applicationUser1.Entity = null;
						previousApplicationUser.Feriado1.Remove(this);
					}
					this._applicationUser1.Entity = value;
					if ((value != null))
					{
						value.Feriado1.Add(this);
						_createdByID = value.ID;
					}
					else
					{
						_createdByID = null;
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="beta_interactive_sisga.ferias")]
	public partial class Ferias : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<long> _createdByID;
		
		private System.Nullable<System.DateTime> _creationDate;
		
		private System.DateTime _dataFinal;
		
		private System.DateTime _dataInicial;
		
		private long _funcionarioID;
		
		private long _id;
		
		private System.Nullable<long> _updatedByID;
		
		private System.Nullable<System.DateTime> _updatedDate;
		
		private long _version;
		
		private EntityRef<ApplicationUser> _applicationUser = new EntityRef<ApplicationUser>();
		
		private EntityRef<ApplicationUser> _applicationUser1 = new EntityRef<ApplicationUser>();
		
		private EntityRef<Funcionario> _funcionario = new EntityRef<Funcionario>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedByIDChanged();
		
		partial void OnCreatedByIDChanging(System.Nullable<long> value);
		
		partial void OnCreationDateChanged();
		
		partial void OnCreationDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnDataFinalChanged();
		
		partial void OnDataFinalChanging(System.DateTime value);
		
		partial void OnDataInicialChanged();
		
		partial void OnDataInicialChanging(System.DateTime value);
		
		partial void OnFuncionarioIDChanged();
		
		partial void OnFuncionarioIDChanging(long value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnUpdatedByIDChanged();
		
		partial void OnUpdatedByIDChanging(System.Nullable<long> value);
		
		partial void OnUpdatedDateChanged();
		
		partial void OnUpdatedDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public Ferias()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdByID", Name="created_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CreatedByID
		{
			get
			{
				return this._createdByID;
			}
			set
			{
				if ((_createdByID != value))
				{
					this.OnCreatedByIDChanging(value);
					this.SendPropertyChanging();
					this._createdByID = value;
					this.SendPropertyChanged("CreatedByID");
					this.OnCreatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_creationDate", Name="creation_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreationDate
		{
			get
			{
				return this._creationDate;
			}
			set
			{
				if ((_creationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._creationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[Column(Storage="_dataFinal", Name="data_final", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DataFinal
		{
			get
			{
				return this._dataFinal;
			}
			set
			{
				if ((_dataFinal != value))
				{
					this.OnDataFinalChanging(value);
					this.SendPropertyChanging();
					this._dataFinal = value;
					this.SendPropertyChanged("DataFinal");
					this.OnDataFinalChanged();
				}
			}
		}
		
		[Column(Storage="_dataInicial", Name="data_inicial", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DataInicial
		{
			get
			{
				return this._dataInicial;
			}
			set
			{
				if ((_dataInicial != value))
				{
					this.OnDataInicialChanging(value);
					this.SendPropertyChanging();
					this._dataInicial = value;
					this.SendPropertyChanged("DataInicial");
					this.OnDataInicialChanged();
				}
			}
		}
		
		[Column(Storage="_funcionarioID", Name="funcionario_id", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long FuncionarioID
		{
			get
			{
				return this._funcionarioID;
			}
			set
			{
				if ((_funcionarioID != value))
				{
					this.OnFuncionarioIDChanging(value);
					this.SendPropertyChanging();
					this._funcionarioID = value;
					this.SendPropertyChanged("FuncionarioID");
					this.OnFuncionarioIDChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedByID", Name="updated_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UpdatedByID
		{
			get
			{
				return this._updatedByID;
			}
			set
			{
				if ((_updatedByID != value))
				{
					this.OnUpdatedByIDChanging(value);
					this.SendPropertyChanging();
					this._updatedByID = value;
					this.SendPropertyChanged("UpdatedByID");
					this.OnUpdatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedDate", Name="updated_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> UpdatedDate
		{
			get
			{
				return this._updatedDate;
			}
			set
			{
				if ((_updatedDate != value))
				{
					this.OnUpdatedDateChanging(value);
					this.SendPropertyChanging();
					this._updatedDate = value;
					this.SendPropertyChanged("UpdatedDate");
					this.OnUpdatedDateChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_applicationUser", OtherKey="ID", ThisKey="UpdatedByID", Name="FKB3D2FDE813D9D401", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser
		{
			get
			{
				return this._applicationUser.Entity;
			}
			set
			{
				if (((this._applicationUser.Entity == value) 
							== false))
				{
					if ((this._applicationUser.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser.Entity;
						this._applicationUser.Entity = null;
						previousApplicationUser.Ferias.Remove(this);
					}
					this._applicationUser.Entity = value;
					if ((value != null))
					{
						value.Ferias.Add(this);
						_updatedByID = value.ID;
					}
					else
					{
						_updatedByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_applicationUser1", OtherKey="ID", ThisKey="CreatedByID", Name="FKB3D2FDE8F2EB5C6E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser1
		{
			get
			{
				return this._applicationUser1.Entity;
			}
			set
			{
				if (((this._applicationUser1.Entity == value) 
							== false))
				{
					if ((this._applicationUser1.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser1.Entity;
						this._applicationUser1.Entity = null;
						previousApplicationUser.Ferias1.Remove(this);
					}
					this._applicationUser1.Entity = value;
					if ((value != null))
					{
						value.Ferias1.Add(this);
						_createdByID = value.ID;
					}
					else
					{
						_createdByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_funcionario", OtherKey="ID", ThisKey="FuncionarioID", Name="FKB3D2FDE8FA7F0284", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Funcionario Funcionario
		{
			get
			{
				return this._funcionario.Entity;
			}
			set
			{
				if (((this._funcionario.Entity == value) 
							== false))
				{
					if ((this._funcionario.Entity != null))
					{
						Funcionario previousFuncionario = this._funcionario.Entity;
						this._funcionario.Entity = null;
						previousFuncionario.Ferias.Remove(this);
					}
					this._funcionario.Entity = value;
					if ((value != null))
					{
						value.Ferias.Add(this);
						_funcionarioID = value.ID;
					}
					else
					{
						_funcionarioID = default(long);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="beta_interactive_sisga.funcionario")]
	public partial class Funcionario : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _apelido;
		
		private string _avenidaRua;
		
		private string _bairro;
		
		private System.Nullable<long> _categoriaID;
		
		private long _code;
		
		private System.Nullable<long> _createdByID;
		
		private System.Nullable<System.DateTime> _creationDate;
		
		private System.Nullable<System.DateTime> _dataDeIngresso;
		
		private System.DateTime _dataDeNascimento;
		
		private long _departamentoID;
		
		private System.Nullable<long> _distritoID;
		
		private string _email;
		
		private long _estadoCivilID;
		
		private bool _fpUserEnabled;
		
		private System.Nullable<long> _fpUserGroupIndexID;
		
		private int _fpUserID;
		
		private string _fpUserName;
		
		private string _fpUserPassword;
		
		private int _fpUserPrivilege;
		
		private System.Nullable<long> _fpUserTimeZone1id;
		
		private System.Nullable<long> _fpUserTimeZone2id;
		
		private System.Nullable<long> _fpUserTimeZone3id;
		
		private long _id;
		
		private System.Nullable<long> _localidadeID;
		
		private System.Nullable<long> _nacionalidadeID;
		
		private string _nome;
		
		private long _numeroCasa;
		
		private string _numeroDocumentoIdentificacao;
		
		private byte[] _photo;
		
		private System.Nullable<long> _postoAdministrativoID;
		
		private System.Nullable<long> _provinciaID;
		
		private long _sexoID;
		
		private string _telefone;
		
		private System.Nullable<long> _tipoDocumentoIdentificacaoID;
		
		private System.Nullable<long> _updatedByID;
		
		private System.Nullable<System.DateTime> _updatedDate;
		
		private EntitySet<Falta> _falta;
		
		private EntitySet<DeviceFingerprint> _deviceFingerprint;
		
		private EntitySet<UserClock> _userClock;
		
		private EntitySet<FuncionarioHorario> _funcionarioHorario;
		
		private EntitySet<Ferias> _ferias;
		
		private EntitySet<AttCalcs> _attCalcs;
		
		private EntityRef<ApplicationUser> _applicationUser = new EntityRef<ApplicationUser>();
		
		private EntityRef<Categoria> _categoria = new EntityRef<Categoria>();
		
		private EntityRef<DeviceTimeZoneGroup> _deviceTimeZoneGroup = new EntityRef<DeviceTimeZoneGroup>();
		
		private EntityRef<DeviceTimeZone> _deviceTimeZone = new EntityRef<DeviceTimeZone>();
		
		private EntityRef<DeviceTimeZone> _deviceTimeZone1 = new EntityRef<DeviceTimeZone>();
		
		private EntityRef<DeviceTimeZone> _deviceTimeZone2 = new EntityRef<DeviceTimeZone>();
		
		private EntityRef<EstadoCivil> _estadoCivil = new EntityRef<EstadoCivil>();
		
		private EntityRef<Country> _country = new EntityRef<Country>();
		
		private EntityRef<DocumentoIdentificacao> _documentoIdentificacao = new EntityRef<DocumentoIdentificacao>();
		
		private EntityRef<Localidade> _localidade = new EntityRef<Localidade>();
		
		private EntityRef<Sexo> _sexo = new EntityRef<Sexo>();
		
		private EntityRef<Provincia> _provincia = new EntityRef<Provincia>();
		
		private EntityRef<PostoAdministrativo> _postoAdministrativo = new EntityRef<PostoAdministrativo>();
		
		private EntityRef<Distrito> _distrito = new EntityRef<Distrito>();
		
		private EntityRef<ApplicationUser> _applicationUser1 = new EntityRef<ApplicationUser>();
		
		private EntityRef<Departamento> _departamento = new EntityRef<Departamento>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnApelidoChanged();
		
		partial void OnApelidoChanging(string value);
		
		partial void OnAvenidaRuaChanged();
		
		partial void OnAvenidaRuaChanging(string value);
		
		partial void OnBairroChanged();
		
		partial void OnBairroChanging(string value);
		
		partial void OnCategoriaIDChanged();
		
		partial void OnCategoriaIDChanging(System.Nullable<long> value);
		
		partial void OnCodeChanged();
		
		partial void OnCodeChanging(long value);
		
		partial void OnCreatedByIDChanged();
		
		partial void OnCreatedByIDChanging(System.Nullable<long> value);
		
		partial void OnCreationDateChanged();
		
		partial void OnCreationDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnDataDeIngressoChanged();
		
		partial void OnDataDeIngressoChanging(System.Nullable<System.DateTime> value);
		
		partial void OnDataDeNascimentoChanged();
		
		partial void OnDataDeNascimentoChanging(System.DateTime value);
		
		partial void OnDepartamentoIDChanged();
		
		partial void OnDepartamentoIDChanging(long value);
		
		partial void OnDistritoIDChanged();
		
		partial void OnDistritoIDChanging(System.Nullable<long> value);
		
		partial void OnEmailChanged();
		
		partial void OnEmailChanging(string value);
		
		partial void OnEstadoCivilIDChanged();
		
		partial void OnEstadoCivilIDChanging(long value);
		
		partial void OnFpUserEnabledChanged();
		
		partial void OnFpUserEnabledChanging(bool value);
		
		partial void OnFpUserGroupIndexIDChanged();
		
		partial void OnFpUserGroupIndexIDChanging(System.Nullable<long> value);
		
		partial void OnFpUserIDChanged();
		
		partial void OnFpUserIDChanging(int value);
		
		partial void OnFpUserNameChanged();
		
		partial void OnFpUserNameChanging(string value);
		
		partial void OnFpUserPasswordChanged();
		
		partial void OnFpUserPasswordChanging(string value);
		
		partial void OnFpUserPrivilegeChanged();
		
		partial void OnFpUserPrivilegeChanging(int value);
		
		partial void OnFpUserTimeZone1IDChanged();
		
		partial void OnFpUserTimeZone1IDChanging(System.Nullable<long> value);
		
		partial void OnFpUserTimeZone2IDChanged();
		
		partial void OnFpUserTimeZone2IDChanging(System.Nullable<long> value);
		
		partial void OnFpUserTimeZone3IDChanged();
		
		partial void OnFpUserTimeZone3IDChanging(System.Nullable<long> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnLocalidadeIDChanged();
		
		partial void OnLocalidadeIDChanging(System.Nullable<long> value);
		
		partial void OnNacionalidadeIDChanged();
		
		partial void OnNacionalidadeIDChanging(System.Nullable<long> value);
		
		partial void OnNomeChanged();
		
		partial void OnNomeChanging(string value);
		
		partial void OnNumeroCasaChanged();
		
		partial void OnNumeroCasaChanging(long value);
		
		partial void OnNumeroDocumentoIdentificacaoChanged();
		
		partial void OnNumeroDocumentoIdentificacaoChanging(string value);
		
		partial void OnPhotoChanged();
		
		partial void OnPhotoChanging(byte[] value);
		
		partial void OnPostoAdministrativoIDChanged();
		
		partial void OnPostoAdministrativoIDChanging(System.Nullable<long> value);
		
		partial void OnProvinciaIDChanged();
		
		partial void OnProvinciaIDChanging(System.Nullable<long> value);
		
		partial void OnSexoIDChanged();
		
		partial void OnSexoIDChanging(long value);
		
		partial void OnTelefoneChanged();
		
		partial void OnTelefoneChanging(string value);
		
		partial void OnTipoDocumentoIdentificacaoIDChanged();
		
		partial void OnTipoDocumentoIdentificacaoIDChanging(System.Nullable<long> value);
		
		partial void OnUpdatedByIDChanged();
		
		partial void OnUpdatedByIDChanging(System.Nullable<long> value);
		
		partial void OnUpdatedDateChanged();
		
		partial void OnUpdatedDateChanging(System.Nullable<System.DateTime> value);
		#endregion
		
		
		public Funcionario()
		{
			_falta = new EntitySet<Falta>(new Action<Falta>(this.Falta_Attach), new Action<Falta>(this.Falta_Detach));
			_deviceFingerprint = new EntitySet<DeviceFingerprint>(new Action<DeviceFingerprint>(this.DeviceFingerprint_Attach), new Action<DeviceFingerprint>(this.DeviceFingerprint_Detach));
			_userClock = new EntitySet<UserClock>(new Action<UserClock>(this.UserClock_Attach), new Action<UserClock>(this.UserClock_Detach));
			_funcionarioHorario = new EntitySet<FuncionarioHorario>(new Action<FuncionarioHorario>(this.FuncionarioHorario_Attach), new Action<FuncionarioHorario>(this.FuncionarioHorario_Detach));
			_ferias = new EntitySet<Ferias>(new Action<Ferias>(this.Ferias_Attach), new Action<Ferias>(this.Ferias_Detach));
			_attCalcs = new EntitySet<AttCalcs>(new Action<AttCalcs>(this.AttCalcs_Attach), new Action<AttCalcs>(this.AttCalcs_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_apelido", Name="apelido", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Apelido
		{
			get
			{
				return this._apelido;
			}
			set
			{
				if (((_apelido == value) 
							== false))
				{
					this.OnApelidoChanging(value);
					this.SendPropertyChanging();
					this._apelido = value;
					this.SendPropertyChanged("Apelido");
					this.OnApelidoChanged();
				}
			}
		}
		
		[Column(Storage="_avenidaRua", Name="avenida_rua", DbType="varchar(255)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AvenidaRua
		{
			get
			{
				return this._avenidaRua;
			}
			set
			{
				if (((_avenidaRua == value) 
							== false))
				{
					this.OnAvenidaRuaChanging(value);
					this.SendPropertyChanging();
					this._avenidaRua = value;
					this.SendPropertyChanged("AvenidaRua");
					this.OnAvenidaRuaChanged();
				}
			}
		}
		
		[Column(Storage="_bairro", Name="bairro", DbType="varchar(255)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Bairro
		{
			get
			{
				return this._bairro;
			}
			set
			{
				if (((_bairro == value) 
							== false))
				{
					this.OnBairroChanging(value);
					this.SendPropertyChanging();
					this._bairro = value;
					this.SendPropertyChanged("Bairro");
					this.OnBairroChanged();
				}
			}
		}
		
		[Column(Storage="_categoriaID", Name="categoria_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CategoriaID
		{
			get
			{
				return this._categoriaID;
			}
			set
			{
				if ((_categoriaID != value))
				{
					this.OnCategoriaIDChanging(value);
					this.SendPropertyChanging();
					this._categoriaID = value;
					this.SendPropertyChanged("CategoriaID");
					this.OnCategoriaIDChanged();
				}
			}
		}
		
		[Column(Storage="_code", Name="code", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Code
		{
			get
			{
				return this._code;
			}
			set
			{
				if ((_code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[Column(Storage="_createdByID", Name="created_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CreatedByID
		{
			get
			{
				return this._createdByID;
			}
			set
			{
				if ((_createdByID != value))
				{
					this.OnCreatedByIDChanging(value);
					this.SendPropertyChanging();
					this._createdByID = value;
					this.SendPropertyChanged("CreatedByID");
					this.OnCreatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_creationDate", Name="creation_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreationDate
		{
			get
			{
				return this._creationDate;
			}
			set
			{
				if ((_creationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._creationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[Column(Storage="_dataDeIngresso", Name="data_de_ingresso", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DataDeIngresso
		{
			get
			{
				return this._dataDeIngresso;
			}
			set
			{
				if ((_dataDeIngresso != value))
				{
					this.OnDataDeIngressoChanging(value);
					this.SendPropertyChanging();
					this._dataDeIngresso = value;
					this.SendPropertyChanged("DataDeIngresso");
					this.OnDataDeIngressoChanged();
				}
			}
		}
		
		[Column(Storage="_dataDeNascimento", Name="data_de_nascimento", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DataDeNascimento
		{
			get
			{
				return this._dataDeNascimento;
			}
			set
			{
				if ((_dataDeNascimento != value))
				{
					this.OnDataDeNascimentoChanging(value);
					this.SendPropertyChanging();
					this._dataDeNascimento = value;
					this.SendPropertyChanged("DataDeNascimento");
					this.OnDataDeNascimentoChanged();
				}
			}
		}
		
		[Column(Storage="_departamentoID", Name="departamento_id", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long DepartamentoID
		{
			get
			{
				return this._departamentoID;
			}
			set
			{
				if ((_departamentoID != value))
				{
					this.OnDepartamentoIDChanging(value);
					this.SendPropertyChanging();
					this._departamentoID = value;
					this.SendPropertyChanged("DepartamentoID");
					this.OnDepartamentoIDChanged();
				}
			}
		}
		
		[Column(Storage="_distritoID", Name="distrito_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> DistritoID
		{
			get
			{
				return this._distritoID;
			}
			set
			{
				if ((_distritoID != value))
				{
					this.OnDistritoIDChanging(value);
					this.SendPropertyChanging();
					this._distritoID = value;
					this.SendPropertyChanged("DistritoID");
					this.OnDistritoIDChanged();
				}
			}
		}
		
		[Column(Storage="_email", Name="email", DbType="varchar(255)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Email
		{
			get
			{
				return this._email;
			}
			set
			{
				if (((_email == value) 
							== false))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[Column(Storage="_estadoCivilID", Name="estado_civil_id", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long EstadoCivilID
		{
			get
			{
				return this._estadoCivilID;
			}
			set
			{
				if ((_estadoCivilID != value))
				{
					this.OnEstadoCivilIDChanging(value);
					this.SendPropertyChanging();
					this._estadoCivilID = value;
					this.SendPropertyChanged("EstadoCivilID");
					this.OnEstadoCivilIDChanged();
				}
			}
		}
		
		[Column(Storage="_fpUserEnabled", Name="fp_user_enabled", DbType="bit(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool FpUserEnabled
		{
			get
			{
				return this._fpUserEnabled;
			}
			set
			{
				if ((_fpUserEnabled != value))
				{
					this.OnFpUserEnabledChanging(value);
					this.SendPropertyChanging();
					this._fpUserEnabled = value;
					this.SendPropertyChanged("FpUserEnabled");
					this.OnFpUserEnabledChanged();
				}
			}
		}
		
		[Column(Storage="_fpUserGroupIndexID", Name="fp_user_group_index_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FpUserGroupIndexID
		{
			get
			{
				return this._fpUserGroupIndexID;
			}
			set
			{
				if ((_fpUserGroupIndexID != value))
				{
					this.OnFpUserGroupIndexIDChanging(value);
					this.SendPropertyChanging();
					this._fpUserGroupIndexID = value;
					this.SendPropertyChanged("FpUserGroupIndexID");
					this.OnFpUserGroupIndexIDChanged();
				}
			}
		}
		
		[Column(Storage="_fpUserID", Name="fp_user_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int FpUserID
		{
			get
			{
				return this._fpUserID;
			}
			set
			{
				if ((_fpUserID != value))
				{
					this.OnFpUserIDChanging(value);
					this.SendPropertyChanging();
					this._fpUserID = value;
					this.SendPropertyChanged("FpUserID");
					this.OnFpUserIDChanged();
				}
			}
		}
		
		[Column(Storage="_fpUserName", Name="fp_user_name", DbType="varchar(255)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FpUserName
		{
			get
			{
				return this._fpUserName;
			}
			set
			{
				if (((_fpUserName == value) 
							== false))
				{
					this.OnFpUserNameChanging(value);
					this.SendPropertyChanging();
					this._fpUserName = value;
					this.SendPropertyChanged("FpUserName");
					this.OnFpUserNameChanged();
				}
			}
		}
		
		[Column(Storage="_fpUserPassword", Name="fp_user_password", DbType="varchar(255)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FpUserPassword
		{
			get
			{
				return this._fpUserPassword;
			}
			set
			{
				if (((_fpUserPassword == value) 
							== false))
				{
					this.OnFpUserPasswordChanging(value);
					this.SendPropertyChanging();
					this._fpUserPassword = value;
					this.SendPropertyChanged("FpUserPassword");
					this.OnFpUserPasswordChanged();
				}
			}
		}
		
		[Column(Storage="_fpUserPrivilege", Name="fp_user_privilege", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int FpUserPrivilege
		{
			get
			{
				return this._fpUserPrivilege;
			}
			set
			{
				if ((_fpUserPrivilege != value))
				{
					this.OnFpUserPrivilegeChanging(value);
					this.SendPropertyChanging();
					this._fpUserPrivilege = value;
					this.SendPropertyChanged("FpUserPrivilege");
					this.OnFpUserPrivilegeChanged();
				}
			}
		}
		
		[Column(Storage="_fpUserTimeZone1id", Name="fp_user_timezone1_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FpUserTimeZone1ID
		{
			get
			{
				return this._fpUserTimeZone1id;
			}
			set
			{
				if ((_fpUserTimeZone1id != value))
				{
					this.OnFpUserTimeZone1IDChanging(value);
					this.SendPropertyChanging();
					this._fpUserTimeZone1id = value;
					this.SendPropertyChanged("FpUserTimeZone1ID");
					this.OnFpUserTimeZone1IDChanged();
				}
			}
		}
		
		[Column(Storage="_fpUserTimeZone2id", Name="fp_user_timezone2_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FpUserTimeZone2ID
		{
			get
			{
				return this._fpUserTimeZone2id;
			}
			set
			{
				if ((_fpUserTimeZone2id != value))
				{
					this.OnFpUserTimeZone2IDChanging(value);
					this.SendPropertyChanging();
					this._fpUserTimeZone2id = value;
					this.SendPropertyChanged("FpUserTimeZone2ID");
					this.OnFpUserTimeZone2IDChanged();
				}
			}
		}
		
		[Column(Storage="_fpUserTimeZone3id", Name="fp_user_timezone3_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FpUserTimeZone3ID
		{
			get
			{
				return this._fpUserTimeZone3id;
			}
			set
			{
				if ((_fpUserTimeZone3id != value))
				{
					this.OnFpUserTimeZone3IDChanging(value);
					this.SendPropertyChanging();
					this._fpUserTimeZone3id = value;
					this.SendPropertyChanged("FpUserTimeZone3ID");
					this.OnFpUserTimeZone3IDChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_localidadeID", Name="localidade_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> LocalidadeID
		{
			get
			{
				return this._localidadeID;
			}
			set
			{
				if ((_localidadeID != value))
				{
					this.OnLocalidadeIDChanging(value);
					this.SendPropertyChanging();
					this._localidadeID = value;
					this.SendPropertyChanged("LocalidadeID");
					this.OnLocalidadeIDChanged();
				}
			}
		}
		
		[Column(Storage="_nacionalidadeID", Name="nacionalidade_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> NacionalidadeID
		{
			get
			{
				return this._nacionalidadeID;
			}
			set
			{
				if ((_nacionalidadeID != value))
				{
					this.OnNacionalidadeIDChanging(value);
					this.SendPropertyChanging();
					this._nacionalidadeID = value;
					this.SendPropertyChanged("NacionalidadeID");
					this.OnNacionalidadeIDChanged();
				}
			}
		}
		
		[Column(Storage="_nome", Name="nome", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if (((_nome == value) 
							== false))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[Column(Storage="_numeroCasa", Name="numero_casa", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long NumeroCasa
		{
			get
			{
				return this._numeroCasa;
			}
			set
			{
				if ((_numeroCasa != value))
				{
					this.OnNumeroCasaChanging(value);
					this.SendPropertyChanging();
					this._numeroCasa = value;
					this.SendPropertyChanged("NumeroCasa");
					this.OnNumeroCasaChanged();
				}
			}
		}
		
		[Column(Storage="_numeroDocumentoIdentificacao", Name="numero_documento_identificacao", DbType="varchar(255)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NumeroDocumentoIdentificacao
		{
			get
			{
				return this._numeroDocumentoIdentificacao;
			}
			set
			{
				if (((_numeroDocumentoIdentificacao == value) 
							== false))
				{
					this.OnNumeroDocumentoIdentificacaoChanging(value);
					this.SendPropertyChanging();
					this._numeroDocumentoIdentificacao = value;
					this.SendPropertyChanged("NumeroDocumentoIdentificacao");
					this.OnNumeroDocumentoIdentificacaoChanged();
				}
			}
		}
		
		[Column(Storage="_photo", Name="photo", DbType="mediumblob", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public byte[] Photo
		{
			get
			{
				return this._photo;
			}
			set
			{
				if (((_photo == value) 
							== false))
				{
					this.OnPhotoChanging(value);
					this.SendPropertyChanging();
					this._photo = value;
					this.SendPropertyChanged("Photo");
					this.OnPhotoChanged();
				}
			}
		}
		
		[Column(Storage="_postoAdministrativoID", Name="posto_administrativo_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> PostoAdministrativoID
		{
			get
			{
				return this._postoAdministrativoID;
			}
			set
			{
				if ((_postoAdministrativoID != value))
				{
					this.OnPostoAdministrativoIDChanging(value);
					this.SendPropertyChanging();
					this._postoAdministrativoID = value;
					this.SendPropertyChanged("PostoAdministrativoID");
					this.OnPostoAdministrativoIDChanged();
				}
			}
		}
		
		[Column(Storage="_provinciaID", Name="provincia_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ProvinciaID
		{
			get
			{
				return this._provinciaID;
			}
			set
			{
				if ((_provinciaID != value))
				{
					this.OnProvinciaIDChanging(value);
					this.SendPropertyChanging();
					this._provinciaID = value;
					this.SendPropertyChanged("ProvinciaID");
					this.OnProvinciaIDChanged();
				}
			}
		}
		
		[Column(Storage="_sexoID", Name="sexo_id", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long SexoID
		{
			get
			{
				return this._sexoID;
			}
			set
			{
				if ((_sexoID != value))
				{
					this.OnSexoIDChanging(value);
					this.SendPropertyChanging();
					this._sexoID = value;
					this.SendPropertyChanged("SexoID");
					this.OnSexoIDChanged();
				}
			}
		}
		
		[Column(Storage="_telefone", Name="telefone", DbType="varchar(255)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Telefone
		{
			get
			{
				return this._telefone;
			}
			set
			{
				if (((_telefone == value) 
							== false))
				{
					this.OnTelefoneChanging(value);
					this.SendPropertyChanging();
					this._telefone = value;
					this.SendPropertyChanged("Telefone");
					this.OnTelefoneChanged();
				}
			}
		}
		
		[Column(Storage="_tipoDocumentoIdentificacaoID", Name="tipo_documento_identificacao_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> TipoDocumentoIdentificacaoID
		{
			get
			{
				return this._tipoDocumentoIdentificacaoID;
			}
			set
			{
				if ((_tipoDocumentoIdentificacaoID != value))
				{
					this.OnTipoDocumentoIdentificacaoIDChanging(value);
					this.SendPropertyChanging();
					this._tipoDocumentoIdentificacaoID = value;
					this.SendPropertyChanged("TipoDocumentoIdentificacaoID");
					this.OnTipoDocumentoIdentificacaoIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedByID", Name="updated_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UpdatedByID
		{
			get
			{
				return this._updatedByID;
			}
			set
			{
				if ((_updatedByID != value))
				{
					this.OnUpdatedByIDChanging(value);
					this.SendPropertyChanging();
					this._updatedByID = value;
					this.SendPropertyChanged("UpdatedByID");
					this.OnUpdatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedDate", Name="updated_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> UpdatedDate
		{
			get
			{
				return this._updatedDate;
			}
			set
			{
				if ((_updatedDate != value))
				{
					this.OnUpdatedDateChanging(value);
					this.SendPropertyChanging();
					this._updatedDate = value;
					this.SendPropertyChanged("UpdatedDate");
					this.OnUpdatedDateChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_falta", OtherKey="FuncionarioID", ThisKey="ID", Name="FK5CB193EFA7F0284")]
		[DebuggerNonUserCode()]
		public EntitySet<Falta> Falta
		{
			get
			{
				return this._falta;
			}
			set
			{
				this._falta = value;
			}
		}
		
		[Association(Storage="_deviceFingerprint", OtherKey="FuncionarioID", ThisKey="ID", Name="FK6B9B947BFA7F0284")]
		[DebuggerNonUserCode()]
		public EntitySet<DeviceFingerprint> DeviceFingerprint
		{
			get
			{
				return this._deviceFingerprint;
			}
			set
			{
				this._deviceFingerprint = value;
			}
		}
		
		[Association(Storage="_userClock", OtherKey="FuncionarioID", ThisKey="ID", Name="FK726DE69AFA7F0284")]
		[DebuggerNonUserCode()]
		public EntitySet<UserClock> UserClock
		{
			get
			{
				return this._userClock;
			}
			set
			{
				this._userClock = value;
			}
		}
		
		[Association(Storage="_funcionarioHorario", OtherKey="FuncionarioID", ThisKey="ID", Name="FK7554017EFA7F0284")]
		[DebuggerNonUserCode()]
		public EntitySet<FuncionarioHorario> FuncionarioHorario
		{
			get
			{
				return this._funcionarioHorario;
			}
			set
			{
				this._funcionarioHorario = value;
			}
		}
		
		[Association(Storage="_ferias", OtherKey="FuncionarioID", ThisKey="ID", Name="FKB3D2FDE8FA7F0284")]
		[DebuggerNonUserCode()]
		public EntitySet<Ferias> Ferias
		{
			get
			{
				return this._ferias;
			}
			set
			{
				this._ferias = value;
			}
		}
		
		[Association(Storage="_attCalcs", OtherKey="FuncionarioID", ThisKey="ID", Name="FKE00671A0FA7F0284")]
		[DebuggerNonUserCode()]
		public EntitySet<AttCalcs> AttCalcs
		{
			get
			{
				return this._attCalcs;
			}
			set
			{
				this._attCalcs = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_applicationUser", OtherKey="ID", ThisKey="UpdatedByID", Name="FK50401DDB13D9D401", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser
		{
			get
			{
				return this._applicationUser.Entity;
			}
			set
			{
				if (((this._applicationUser.Entity == value) 
							== false))
				{
					if ((this._applicationUser.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser.Entity;
						this._applicationUser.Entity = null;
						previousApplicationUser.Funcionario.Remove(this);
					}
					this._applicationUser.Entity = value;
					if ((value != null))
					{
						value.Funcionario.Add(this);
						_updatedByID = value.ID;
					}
					else
					{
						_updatedByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_categoria", OtherKey="ID", ThisKey="CategoriaID", Name="FK50401DDB1DA8C604", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Categoria Categoria
		{
			get
			{
				return this._categoria.Entity;
			}
			set
			{
				if (((this._categoria.Entity == value) 
							== false))
				{
					if ((this._categoria.Entity != null))
					{
						Categoria previousCategoria = this._categoria.Entity;
						this._categoria.Entity = null;
						previousCategoria.Funcionario.Remove(this);
					}
					this._categoria.Entity = value;
					if ((value != null))
					{
						value.Funcionario.Add(this);
						_categoriaID = value.ID;
					}
					else
					{
						_categoriaID = null;
					}
				}
			}
		}
		
		[Association(Storage="_deviceTimeZoneGroup", OtherKey="ID", ThisKey="FpUserGroupIndexID", Name="FK50401DDB30F2CF89", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public DeviceTimeZoneGroup DeviceTimeZoneGroup
		{
			get
			{
				return this._deviceTimeZoneGroup.Entity;
			}
			set
			{
				if (((this._deviceTimeZoneGroup.Entity == value) 
							== false))
				{
					if ((this._deviceTimeZoneGroup.Entity != null))
					{
						DeviceTimeZoneGroup previousDeviceTimeZoneGroup = this._deviceTimeZoneGroup.Entity;
						this._deviceTimeZoneGroup.Entity = null;
						previousDeviceTimeZoneGroup.Funcionario.Remove(this);
					}
					this._deviceTimeZoneGroup.Entity = value;
					if ((value != null))
					{
						value.Funcionario.Add(this);
						_fpUserGroupIndexID = value.ID;
					}
					else
					{
						_fpUserGroupIndexID = null;
					}
				}
			}
		}
		
		[Association(Storage="_deviceTimeZone", OtherKey="ID", ThisKey="FpUserTimeZone1ID", Name="FK50401DDB52E0997E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public DeviceTimeZone DeviceTimeZone
		{
			get
			{
				return this._deviceTimeZone.Entity;
			}
			set
			{
				if (((this._deviceTimeZone.Entity == value) 
							== false))
				{
					if ((this._deviceTimeZone.Entity != null))
					{
						DeviceTimeZone previousDeviceTimeZone = this._deviceTimeZone.Entity;
						this._deviceTimeZone.Entity = null;
						previousDeviceTimeZone.Funcionario.Remove(this);
					}
					this._deviceTimeZone.Entity = value;
					if ((value != null))
					{
						value.Funcionario.Add(this);
						_fpUserTimeZone1id = value.ID;
					}
					else
					{
						_fpUserTimeZone1id = null;
					}
				}
			}
		}
		
		[Association(Storage="_deviceTimeZone1", OtherKey="ID", ThisKey="FpUserTimeZone2ID", Name="FK50401DDB52E10DDD", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public DeviceTimeZone DeviceTimeZone1
		{
			get
			{
				return this._deviceTimeZone1.Entity;
			}
			set
			{
				if (((this._deviceTimeZone1.Entity == value) 
							== false))
				{
					if ((this._deviceTimeZone1.Entity != null))
					{
						DeviceTimeZone previousDeviceTimeZone = this._deviceTimeZone1.Entity;
						this._deviceTimeZone1.Entity = null;
						previousDeviceTimeZone.Funcionario1.Remove(this);
					}
					this._deviceTimeZone1.Entity = value;
					if ((value != null))
					{
						value.Funcionario1.Add(this);
						_fpUserTimeZone2id = value.ID;
					}
					else
					{
						_fpUserTimeZone2id = null;
					}
				}
			}
		}
		
		[Association(Storage="_deviceTimeZone2", OtherKey="ID", ThisKey="FpUserTimeZone3ID", Name="FK50401DDB52E1823C", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public DeviceTimeZone DeviceTimeZone2
		{
			get
			{
				return this._deviceTimeZone2.Entity;
			}
			set
			{
				if (((this._deviceTimeZone2.Entity == value) 
							== false))
				{
					if ((this._deviceTimeZone2.Entity != null))
					{
						DeviceTimeZone previousDeviceTimeZone = this._deviceTimeZone2.Entity;
						this._deviceTimeZone2.Entity = null;
						previousDeviceTimeZone.Funcionario2.Remove(this);
					}
					this._deviceTimeZone2.Entity = value;
					if ((value != null))
					{
						value.Funcionario2.Add(this);
						_fpUserTimeZone3id = value.ID;
					}
					else
					{
						_fpUserTimeZone3id = null;
					}
				}
			}
		}
		
		[Association(Storage="_estadoCivil", OtherKey="ID", ThisKey="EstadoCivilID", Name="FK50401DDB6AD2AC12", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public EstadoCivil EstadoCivil
		{
			get
			{
				return this._estadoCivil.Entity;
			}
			set
			{
				if (((this._estadoCivil.Entity == value) 
							== false))
				{
					if ((this._estadoCivil.Entity != null))
					{
						EstadoCivil previousEstadoCivil = this._estadoCivil.Entity;
						this._estadoCivil.Entity = null;
						previousEstadoCivil.Funcionario.Remove(this);
					}
					this._estadoCivil.Entity = value;
					if ((value != null))
					{
						value.Funcionario.Add(this);
						_estadoCivilID = value.ID;
					}
					else
					{
						_estadoCivilID = default(long);
					}
				}
			}
		}
		
		[Association(Storage="_country", OtherKey="ID", ThisKey="NacionalidadeID", Name="FK50401DDB7CB50CB8", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Country Country
		{
			get
			{
				return this._country.Entity;
			}
			set
			{
				if (((this._country.Entity == value) 
							== false))
				{
					if ((this._country.Entity != null))
					{
						Country previousCountry = this._country.Entity;
						this._country.Entity = null;
						previousCountry.Funcionario.Remove(this);
					}
					this._country.Entity = value;
					if ((value != null))
					{
						value.Funcionario.Add(this);
						_nacionalidadeID = value.ID;
					}
					else
					{
						_nacionalidadeID = null;
					}
				}
			}
		}
		
		[Association(Storage="_documentoIdentificacao", OtherKey="ID", ThisKey="TipoDocumentoIdentificacaoID", Name="FK50401DDB7F0BE6B7", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public DocumentoIdentificacao DocumentoIdentificacao
		{
			get
			{
				return this._documentoIdentificacao.Entity;
			}
			set
			{
				if (((this._documentoIdentificacao.Entity == value) 
							== false))
				{
					if ((this._documentoIdentificacao.Entity != null))
					{
						DocumentoIdentificacao previousDocumentoIdentificacao = this._documentoIdentificacao.Entity;
						this._documentoIdentificacao.Entity = null;
						previousDocumentoIdentificacao.Funcionario.Remove(this);
					}
					this._documentoIdentificacao.Entity = value;
					if ((value != null))
					{
						value.Funcionario.Add(this);
						_tipoDocumentoIdentificacaoID = value.ID;
					}
					else
					{
						_tipoDocumentoIdentificacaoID = null;
					}
				}
			}
		}
		
		[Association(Storage="_localidade", OtherKey="ID", ThisKey="LocalidadeID", Name="FK50401DDB891EC8F5", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Localidade Localidade
		{
			get
			{
				return this._localidade.Entity;
			}
			set
			{
				if (((this._localidade.Entity == value) 
							== false))
				{
					if ((this._localidade.Entity != null))
					{
						Localidade previousLocalidade = this._localidade.Entity;
						this._localidade.Entity = null;
						previousLocalidade.Funcionario.Remove(this);
					}
					this._localidade.Entity = value;
					if ((value != null))
					{
						value.Funcionario.Add(this);
						_localidadeID = value.ID;
					}
					else
					{
						_localidadeID = null;
					}
				}
			}
		}
		
		[Association(Storage="_sexo", OtherKey="ID", ThisKey="SexoID", Name="FK50401DDBA0783275", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Sexo Sexo
		{
			get
			{
				return this._sexo.Entity;
			}
			set
			{
				if (((this._sexo.Entity == value) 
							== false))
				{
					if ((this._sexo.Entity != null))
					{
						Sexo previousSexo = this._sexo.Entity;
						this._sexo.Entity = null;
						previousSexo.Funcionario.Remove(this);
					}
					this._sexo.Entity = value;
					if ((value != null))
					{
						value.Funcionario.Add(this);
						_sexoID = value.ID;
					}
					else
					{
						_sexoID = default(long);
					}
				}
			}
		}
		
		[Association(Storage="_provincia", OtherKey="ID", ThisKey="ProvinciaID", Name="FK50401DDBA58767F", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Provincia Provincia
		{
			get
			{
				return this._provincia.Entity;
			}
			set
			{
				if (((this._provincia.Entity == value) 
							== false))
				{
					if ((this._provincia.Entity != null))
					{
						Provincia previousProvincia = this._provincia.Entity;
						this._provincia.Entity = null;
						previousProvincia.Funcionario.Remove(this);
					}
					this._provincia.Entity = value;
					if ((value != null))
					{
						value.Funcionario.Add(this);
						_provinciaID = value.ID;
					}
					else
					{
						_provinciaID = null;
					}
				}
			}
		}
		
		[Association(Storage="_postoAdministrativo", OtherKey="ID", ThisKey="PostoAdministrativoID", Name="FK50401DDBB1014D9E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public PostoAdministrativo PostoAdministrativo
		{
			get
			{
				return this._postoAdministrativo.Entity;
			}
			set
			{
				if (((this._postoAdministrativo.Entity == value) 
							== false))
				{
					if ((this._postoAdministrativo.Entity != null))
					{
						PostoAdministrativo previousPostoAdministrativo = this._postoAdministrativo.Entity;
						this._postoAdministrativo.Entity = null;
						previousPostoAdministrativo.Funcionario.Remove(this);
					}
					this._postoAdministrativo.Entity = value;
					if ((value != null))
					{
						value.Funcionario.Add(this);
						_postoAdministrativoID = value.ID;
					}
					else
					{
						_postoAdministrativoID = null;
					}
				}
			}
		}
		
		[Association(Storage="_distrito", OtherKey="ID", ThisKey="DistritoID", Name="FK50401DDBCEDE1A35", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Distrito Distrito
		{
			get
			{
				return this._distrito.Entity;
			}
			set
			{
				if (((this._distrito.Entity == value) 
							== false))
				{
					if ((this._distrito.Entity != null))
					{
						Distrito previousDistrito = this._distrito.Entity;
						this._distrito.Entity = null;
						previousDistrito.Funcionario.Remove(this);
					}
					this._distrito.Entity = value;
					if ((value != null))
					{
						value.Funcionario.Add(this);
						_distritoID = value.ID;
					}
					else
					{
						_distritoID = null;
					}
				}
			}
		}
		
		[Association(Storage="_applicationUser1", OtherKey="ID", ThisKey="CreatedByID", Name="FK50401DDBF2EB5C6E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser1
		{
			get
			{
				return this._applicationUser1.Entity;
			}
			set
			{
				if (((this._applicationUser1.Entity == value) 
							== false))
				{
					if ((this._applicationUser1.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser1.Entity;
						this._applicationUser1.Entity = null;
						previousApplicationUser.Funcionario1.Remove(this);
					}
					this._applicationUser1.Entity = value;
					if ((value != null))
					{
						value.Funcionario1.Add(this);
						_createdByID = value.ID;
					}
					else
					{
						_createdByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_departamento", OtherKey="ID", ThisKey="DepartamentoID", Name="FK50401DDBFF5CF5D0", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Departamento Departamento
		{
			get
			{
				return this._departamento.Entity;
			}
			set
			{
				if (((this._departamento.Entity == value) 
							== false))
				{
					if ((this._departamento.Entity != null))
					{
						Departamento previousDepartamento = this._departamento.Entity;
						this._departamento.Entity = null;
						previousDepartamento.Funcionario.Remove(this);
					}
					this._departamento.Entity = value;
					if ((value != null))
					{
						value.Funcionario.Add(this);
						_departamentoID = value.ID;
					}
					else
					{
						_departamentoID = default(long);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Falta_Attach(Falta entity)
		{
			this.SendPropertyChanging();
			entity.Funcionario = this;
		}
		
		private void Falta_Detach(Falta entity)
		{
			this.SendPropertyChanging();
			entity.Funcionario = null;
		}
		
		private void DeviceFingerprint_Attach(DeviceFingerprint entity)
		{
			this.SendPropertyChanging();
			entity.Funcionario = this;
		}
		
		private void DeviceFingerprint_Detach(DeviceFingerprint entity)
		{
			this.SendPropertyChanging();
			entity.Funcionario = null;
		}
		
		private void UserClock_Attach(UserClock entity)
		{
			this.SendPropertyChanging();
			entity.Funcionario = this;
		}
		
		private void UserClock_Detach(UserClock entity)
		{
			this.SendPropertyChanging();
			entity.Funcionario = null;
		}
		
		private void FuncionarioHorario_Attach(FuncionarioHorario entity)
		{
			this.SendPropertyChanging();
			entity.Funcionario = this;
		}
		
		private void FuncionarioHorario_Detach(FuncionarioHorario entity)
		{
			this.SendPropertyChanging();
			entity.Funcionario = null;
		}
		
		private void Ferias_Attach(Ferias entity)
		{
			this.SendPropertyChanging();
			entity.Funcionario = this;
		}
		
		private void Ferias_Detach(Ferias entity)
		{
			this.SendPropertyChanging();
			entity.Funcionario = null;
		}
		
		private void AttCalcs_Attach(AttCalcs entity)
		{
			this.SendPropertyChanging();
			entity.Funcionario = this;
		}
		
		private void AttCalcs_Detach(AttCalcs entity)
		{
			this.SendPropertyChanging();
			entity.Funcionario = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.funcionario_horario")]
	public partial class FuncionarioHorario : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _ano;
		
		private System.DateTime _fim;
		
		private long _funcionarioID;
		
		private System.Nullable<long> _horarioID;
		
		private long _id;
		
		private System.DateTime _inicio;
		
		private bool _isSemanal;
		
		private System.Nullable<long> _periodoMensalID;
		
		private System.Nullable<long> _periodoSemanalID;
		
		private long _version;
		
		private EntityRef<MesAno> _mesAno = new EntityRef<MesAno>();
		
		private EntityRef<HorarioSemana> _horarioSemana = new EntityRef<HorarioSemana>();
		
		private EntityRef<SemanaAno> _semanaAno = new EntityRef<SemanaAno>();
		
		private EntityRef<Funcionario> _funcionario = new EntityRef<Funcionario>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAnoChanged();
		
		partial void OnAnoChanging(int value);
		
		partial void OnFimChanged();
		
		partial void OnFimChanging(System.DateTime value);
		
		partial void OnFuncionarioIDChanged();
		
		partial void OnFuncionarioIDChanging(long value);
		
		partial void OnHorarioIDChanged();
		
		partial void OnHorarioIDChanging(System.Nullable<long> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnInicioChanged();
		
		partial void OnInicioChanging(System.DateTime value);
		
		partial void OnIsSemanalChanged();
		
		partial void OnIsSemanalChanging(bool value);
		
		partial void OnPeriodoMensalIDChanged();
		
		partial void OnPeriodoMensalIDChanging(System.Nullable<long> value);
		
		partial void OnPeriodoSemanalIDChanged();
		
		partial void OnPeriodoSemanalIDChanging(System.Nullable<long> value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public FuncionarioHorario()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_ano", Name="ano", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int Ano
		{
			get
			{
				return this._ano;
			}
			set
			{
				if ((_ano != value))
				{
					this.OnAnoChanging(value);
					this.SendPropertyChanging();
					this._ano = value;
					this.SendPropertyChanged("Ano");
					this.OnAnoChanged();
				}
			}
		}
		
		[Column(Storage="_fim", Name="fim", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime Fim
		{
			get
			{
				return this._fim;
			}
			set
			{
				if ((_fim != value))
				{
					this.OnFimChanging(value);
					this.SendPropertyChanging();
					this._fim = value;
					this.SendPropertyChanged("Fim");
					this.OnFimChanged();
				}
			}
		}
		
		[Column(Storage="_funcionarioID", Name="funcionario_id", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long FuncionarioID
		{
			get
			{
				return this._funcionarioID;
			}
			set
			{
				if ((_funcionarioID != value))
				{
					this.OnFuncionarioIDChanging(value);
					this.SendPropertyChanging();
					this._funcionarioID = value;
					this.SendPropertyChanged("FuncionarioID");
					this.OnFuncionarioIDChanged();
				}
			}
		}
		
		[Column(Storage="_horarioID", Name="horario_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> HorarioID
		{
			get
			{
				return this._horarioID;
			}
			set
			{
				if ((_horarioID != value))
				{
					this.OnHorarioIDChanging(value);
					this.SendPropertyChanging();
					this._horarioID = value;
					this.SendPropertyChanged("HorarioID");
					this.OnHorarioIDChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_inicio", Name="inicio", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime Inicio
		{
			get
			{
				return this._inicio;
			}
			set
			{
				if ((_inicio != value))
				{
					this.OnInicioChanging(value);
					this.SendPropertyChanging();
					this._inicio = value;
					this.SendPropertyChanged("Inicio");
					this.OnInicioChanged();
				}
			}
		}
		
		[Column(Storage="_isSemanal", Name="is_semanal", DbType="bit(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool IsSemanal
		{
			get
			{
				return this._isSemanal;
			}
			set
			{
				if ((_isSemanal != value))
				{
					this.OnIsSemanalChanging(value);
					this.SendPropertyChanging();
					this._isSemanal = value;
					this.SendPropertyChanged("IsSemanal");
					this.OnIsSemanalChanged();
				}
			}
		}
		
		[Column(Storage="_periodoMensalID", Name="periodo_mensal_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> PeriodoMensalID
		{
			get
			{
				return this._periodoMensalID;
			}
			set
			{
				if ((_periodoMensalID != value))
				{
					this.OnPeriodoMensalIDChanging(value);
					this.SendPropertyChanging();
					this._periodoMensalID = value;
					this.SendPropertyChanged("PeriodoMensalID");
					this.OnPeriodoMensalIDChanged();
				}
			}
		}
		
		[Column(Storage="_periodoSemanalID", Name="periodo_semanal_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> PeriodoSemanalID
		{
			get
			{
				return this._periodoSemanalID;
			}
			set
			{
				if ((_periodoSemanalID != value))
				{
					this.OnPeriodoSemanalIDChanging(value);
					this.SendPropertyChanging();
					this._periodoSemanalID = value;
					this.SendPropertyChanged("PeriodoSemanalID");
					this.OnPeriodoSemanalIDChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_mesAno", OtherKey="ID", ThisKey="PeriodoMensalID", Name="FK7554017E123CE75E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public MesAno MesAno
		{
			get
			{
				return this._mesAno.Entity;
			}
			set
			{
				if (((this._mesAno.Entity == value) 
							== false))
				{
					if ((this._mesAno.Entity != null))
					{
						MesAno previousMesAno = this._mesAno.Entity;
						this._mesAno.Entity = null;
						previousMesAno.FuncionarioHorario.Remove(this);
					}
					this._mesAno.Entity = value;
					if ((value != null))
					{
						value.FuncionarioHorario.Add(this);
						_periodoMensalID = value.ID;
					}
					else
					{
						_periodoMensalID = null;
					}
				}
			}
		}
		
		[Association(Storage="_horarioSemana", OtherKey="ID", ThisKey="HorarioID", Name="FK7554017E222F84DD", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public HorarioSemana HorarioSemana
		{
			get
			{
				return this._horarioSemana.Entity;
			}
			set
			{
				if (((this._horarioSemana.Entity == value) 
							== false))
				{
					if ((this._horarioSemana.Entity != null))
					{
						HorarioSemana previousHorarioSemana = this._horarioSemana.Entity;
						this._horarioSemana.Entity = null;
						previousHorarioSemana.FuncionarioHorario.Remove(this);
					}
					this._horarioSemana.Entity = value;
					if ((value != null))
					{
						value.FuncionarioHorario.Add(this);
						_horarioID = value.ID;
					}
					else
					{
						_horarioID = null;
					}
				}
			}
		}
		
		[Association(Storage="_semanaAno", OtherKey="ID", ThisKey="PeriodoSemanalID", Name="FK7554017E85866FAB", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public SemanaAno SemanaAno
		{
			get
			{
				return this._semanaAno.Entity;
			}
			set
			{
				if (((this._semanaAno.Entity == value) 
							== false))
				{
					if ((this._semanaAno.Entity != null))
					{
						SemanaAno previousSemanaAno = this._semanaAno.Entity;
						this._semanaAno.Entity = null;
						previousSemanaAno.FuncionarioHorario.Remove(this);
					}
					this._semanaAno.Entity = value;
					if ((value != null))
					{
						value.FuncionarioHorario.Add(this);
						_periodoSemanalID = value.ID;
					}
					else
					{
						_periodoSemanalID = null;
					}
				}
			}
		}
		
		[Association(Storage="_funcionario", OtherKey="ID", ThisKey="FuncionarioID", Name="FK7554017EFA7F0284", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Funcionario Funcionario
		{
			get
			{
				return this._funcionario.Entity;
			}
			set
			{
				if (((this._funcionario.Entity == value) 
							== false))
				{
					if ((this._funcionario.Entity != null))
					{
						Funcionario previousFuncionario = this._funcionario.Entity;
						this._funcionario.Entity = null;
						previousFuncionario.FuncionarioHorario.Remove(this);
					}
					this._funcionario.Entity = value;
					if ((value != null))
					{
						value.FuncionarioHorario.Add(this);
						_funcionarioID = value.ID;
					}
					else
					{
						_funcionarioID = default(long);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="beta_interactive_sisga.horario_dia")]
	public partial class HorarioDia : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<long> _createdByID;
		
		private System.Nullable<System.DateTime> _creationDate;
		
		private bool _enabled;
		
		private System.DateTime _entrada1;
		
		private System.DateTime _entrada2;
		
		private bool _hasIntervalo;
		
		private int _horasTrabalho;
		
		private long _id;
		
		private int _intervaloMinutos;
		
		private int _minsTrabalho;
		
		private System.DateTime _saida1;
		
		private System.DateTime _saida2;
		
		private int _toleranciaNaEntrada1;
		
		private int _toleranciaNaSaida2;
		
		private System.Nullable<long> _updatedByID;
		
		private System.Nullable<System.DateTime> _updatedDate;
		
		private long _version;
		
		private EntitySet<HorarioSemana> _horarioSemana;
		
		private EntitySet<HorarioSemana> _horarioSemana1;
		
		private EntitySet<HorarioSemana> _horarioSemana2;
		
		private EntitySet<HorarioSemana> _horarioSemana3;
		
		private EntitySet<HorarioSemana> _horarioSemana4;
		
		private EntitySet<HorarioSemana> _horarioSemana5;
		
		private EntitySet<HorarioSemana> _horarioSemana6;
		
		private EntitySet<AttCalcs> _attCalcs;
		
		private EntityRef<ApplicationUser> _applicationUser = new EntityRef<ApplicationUser>();
		
		private EntityRef<ApplicationUser> _applicationUser1 = new EntityRef<ApplicationUser>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedByIDChanged();
		
		partial void OnCreatedByIDChanging(System.Nullable<long> value);
		
		partial void OnCreationDateChanged();
		
		partial void OnCreationDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnEnabledChanged();
		
		partial void OnEnabledChanging(bool value);
		
		partial void OnEntrada1Changed();
		
		partial void OnEntrada1Changing(System.DateTime value);
		
		partial void OnEntrada2Changed();
		
		partial void OnEntrada2Changing(System.DateTime value);
		
		partial void OnHasIntervaloChanged();
		
		partial void OnHasIntervaloChanging(bool value);
		
		partial void OnHorasTrabalhoChanged();
		
		partial void OnHorasTrabalhoChanging(int value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnIntervaloMinutosChanged();
		
		partial void OnIntervaloMinutosChanging(int value);
		
		partial void OnMinsTrabalhoChanged();
		
		partial void OnMinsTrabalhoChanging(int value);
		
		partial void OnSaida1Changed();
		
		partial void OnSaida1Changing(System.DateTime value);
		
		partial void OnSaida2Changed();
		
		partial void OnSaida2Changing(System.DateTime value);
		
		partial void OnToleranciaNaEntrada1Changed();
		
		partial void OnToleranciaNaEntrada1Changing(int value);
		
		partial void OnToleranciaNaSaida2Changed();
		
		partial void OnToleranciaNaSaida2Changing(int value);
		
		partial void OnUpdatedByIDChanged();
		
		partial void OnUpdatedByIDChanging(System.Nullable<long> value);
		
		partial void OnUpdatedDateChanged();
		
		partial void OnUpdatedDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public HorarioDia()
		{
			_horarioSemana = new EntitySet<HorarioSemana>(new Action<HorarioSemana>(this.HorarioSemana_Attach), new Action<HorarioSemana>(this.HorarioSemana_Detach));
			_horarioSemana1 = new EntitySet<HorarioSemana>(new Action<HorarioSemana>(this.HorarioSemana1_Attach), new Action<HorarioSemana>(this.HorarioSemana1_Detach));
			_horarioSemana2 = new EntitySet<HorarioSemana>(new Action<HorarioSemana>(this.HorarioSemana2_Attach), new Action<HorarioSemana>(this.HorarioSemana2_Detach));
			_horarioSemana3 = new EntitySet<HorarioSemana>(new Action<HorarioSemana>(this.HorarioSemana3_Attach), new Action<HorarioSemana>(this.HorarioSemana3_Detach));
			_horarioSemana4 = new EntitySet<HorarioSemana>(new Action<HorarioSemana>(this.HorarioSemana4_Attach), new Action<HorarioSemana>(this.HorarioSemana4_Detach));
			_horarioSemana5 = new EntitySet<HorarioSemana>(new Action<HorarioSemana>(this.HorarioSemana5_Attach), new Action<HorarioSemana>(this.HorarioSemana5_Detach));
			_horarioSemana6 = new EntitySet<HorarioSemana>(new Action<HorarioSemana>(this.HorarioSemana6_Attach), new Action<HorarioSemana>(this.HorarioSemana6_Detach));
			_attCalcs = new EntitySet<AttCalcs>(new Action<AttCalcs>(this.AttCalcs_Attach), new Action<AttCalcs>(this.AttCalcs_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_createdByID", Name="created_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CreatedByID
		{
			get
			{
				return this._createdByID;
			}
			set
			{
				if ((_createdByID != value))
				{
					this.OnCreatedByIDChanging(value);
					this.SendPropertyChanging();
					this._createdByID = value;
					this.SendPropertyChanged("CreatedByID");
					this.OnCreatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_creationDate", Name="creation_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreationDate
		{
			get
			{
				return this._creationDate;
			}
			set
			{
				if ((_creationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._creationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[Column(Storage="_enabled", Name="enabled", DbType="bit(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				if ((_enabled != value))
				{
					this.OnEnabledChanging(value);
					this.SendPropertyChanging();
					this._enabled = value;
					this.SendPropertyChanged("Enabled");
					this.OnEnabledChanged();
				}
			}
		}
		
		[Column(Storage="_entrada1", Name="entrada1", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime Entrada1
		{
			get
			{
				return this._entrada1;
			}
			set
			{
				if ((_entrada1 != value))
				{
					this.OnEntrada1Changing(value);
					this.SendPropertyChanging();
					this._entrada1 = value;
					this.SendPropertyChanged("Entrada1");
					this.OnEntrada1Changed();
				}
			}
		}
		
		[Column(Storage="_entrada2", Name="entrada2", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime Entrada2
		{
			get
			{
				return this._entrada2;
			}
			set
			{
				if ((_entrada2 != value))
				{
					this.OnEntrada2Changing(value);
					this.SendPropertyChanging();
					this._entrada2 = value;
					this.SendPropertyChanged("Entrada2");
					this.OnEntrada2Changed();
				}
			}
		}
		
		[Column(Storage="_hasIntervalo", Name="has_intervalo", DbType="bit(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool HasIntervalo
		{
			get
			{
				return this._hasIntervalo;
			}
			set
			{
				if ((_hasIntervalo != value))
				{
					this.OnHasIntervaloChanging(value);
					this.SendPropertyChanging();
					this._hasIntervalo = value;
					this.SendPropertyChanged("HasIntervalo");
					this.OnHasIntervaloChanged();
				}
			}
		}
		
		[Column(Storage="_horasTrabalho", Name="horas_trabalho", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int HorasTrabalho
		{
			get
			{
				return this._horasTrabalho;
			}
			set
			{
				if ((_horasTrabalho != value))
				{
					this.OnHorasTrabalhoChanging(value);
					this.SendPropertyChanging();
					this._horasTrabalho = value;
					this.SendPropertyChanged("HorasTrabalho");
					this.OnHorasTrabalhoChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_intervaloMinutos", Name="intervalo_minutos", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IntervaloMinutos
		{
			get
			{
				return this._intervaloMinutos;
			}
			set
			{
				if ((_intervaloMinutos != value))
				{
					this.OnIntervaloMinutosChanging(value);
					this.SendPropertyChanging();
					this._intervaloMinutos = value;
					this.SendPropertyChanged("IntervaloMinutos");
					this.OnIntervaloMinutosChanged();
				}
			}
		}
		
		[Column(Storage="_minsTrabalho", Name="mins_trabalho", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int MinsTrabalho
		{
			get
			{
				return this._minsTrabalho;
			}
			set
			{
				if ((_minsTrabalho != value))
				{
					this.OnMinsTrabalhoChanging(value);
					this.SendPropertyChanging();
					this._minsTrabalho = value;
					this.SendPropertyChanged("MinsTrabalho");
					this.OnMinsTrabalhoChanged();
				}
			}
		}
		
		[Column(Storage="_saida1", Name="saida1", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime Saida1
		{
			get
			{
				return this._saida1;
			}
			set
			{
				if ((_saida1 != value))
				{
					this.OnSaida1Changing(value);
					this.SendPropertyChanging();
					this._saida1 = value;
					this.SendPropertyChanged("Saida1");
					this.OnSaida1Changed();
				}
			}
		}
		
		[Column(Storage="_saida2", Name="saida2", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime Saida2
		{
			get
			{
				return this._saida2;
			}
			set
			{
				if ((_saida2 != value))
				{
					this.OnSaida2Changing(value);
					this.SendPropertyChanging();
					this._saida2 = value;
					this.SendPropertyChanged("Saida2");
					this.OnSaida2Changed();
				}
			}
		}
		
		[Column(Storage="_toleranciaNaEntrada1", Name="tolerancia_na_entrada1", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ToleranciaNaEntrada1
		{
			get
			{
				return this._toleranciaNaEntrada1;
			}
			set
			{
				if ((_toleranciaNaEntrada1 != value))
				{
					this.OnToleranciaNaEntrada1Changing(value);
					this.SendPropertyChanging();
					this._toleranciaNaEntrada1 = value;
					this.SendPropertyChanged("ToleranciaNaEntrada1");
					this.OnToleranciaNaEntrada1Changed();
				}
			}
		}
		
		[Column(Storage="_toleranciaNaSaida2", Name="tolerancia_na_saida2", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ToleranciaNaSaida2
		{
			get
			{
				return this._toleranciaNaSaida2;
			}
			set
			{
				if ((_toleranciaNaSaida2 != value))
				{
					this.OnToleranciaNaSaida2Changing(value);
					this.SendPropertyChanging();
					this._toleranciaNaSaida2 = value;
					this.SendPropertyChanged("ToleranciaNaSaida2");
					this.OnToleranciaNaSaida2Changed();
				}
			}
		}
		
		[Column(Storage="_updatedByID", Name="updated_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UpdatedByID
		{
			get
			{
				return this._updatedByID;
			}
			set
			{
				if ((_updatedByID != value))
				{
					this.OnUpdatedByIDChanging(value);
					this.SendPropertyChanging();
					this._updatedByID = value;
					this.SendPropertyChanged("UpdatedByID");
					this.OnUpdatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedDate", Name="updated_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> UpdatedDate
		{
			get
			{
				return this._updatedDate;
			}
			set
			{
				if ((_updatedDate != value))
				{
					this.OnUpdatedDateChanging(value);
					this.SendPropertyChanging();
					this._updatedDate = value;
					this.SendPropertyChanged("UpdatedDate");
					this.OnUpdatedDateChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_horarioSemana", OtherKey="SextaID", ThisKey="ID", Name="FK13850E964B0B44D7")]
		[DebuggerNonUserCode()]
		public EntitySet<HorarioSemana> HorarioSemana
		{
			get
			{
				return this._horarioSemana;
			}
			set
			{
				this._horarioSemana = value;
			}
		}
		
		[Association(Storage="_horarioSemana1", OtherKey="QuintaID", ThisKey="ID", Name="FK13850E964F8B14D4")]
		[DebuggerNonUserCode()]
		public EntitySet<HorarioSemana> HorarioSemana1
		{
			get
			{
				return this._horarioSemana1;
			}
			set
			{
				this._horarioSemana1 = value;
			}
		}
		
		[Association(Storage="_horarioSemana2", OtherKey="DomingoID", ThisKey="ID", Name="FK13850E9653F82B9B")]
		[DebuggerNonUserCode()]
		public EntitySet<HorarioSemana> HorarioSemana2
		{
			get
			{
				return this._horarioSemana2;
			}
			set
			{
				this._horarioSemana2 = value;
			}
		}
		
		[Association(Storage="_horarioSemana3", OtherKey="TercaID", ThisKey="ID", Name="FK13850E96A7BFCE6B")]
		[DebuggerNonUserCode()]
		public EntitySet<HorarioSemana> HorarioSemana3
		{
			get
			{
				return this._horarioSemana3;
			}
			set
			{
				this._horarioSemana3 = value;
			}
		}
		
		[Association(Storage="_horarioSemana4", OtherKey="QuartaID", ThisKey="ID", Name="FK13850E96AF2C9D48")]
		[DebuggerNonUserCode()]
		public EntitySet<HorarioSemana> HorarioSemana4
		{
			get
			{
				return this._horarioSemana4;
			}
			set
			{
				this._horarioSemana4 = value;
			}
		}
		
		[Association(Storage="_horarioSemana5", OtherKey="SabadoID", ThisKey="ID", Name="FK13850E96D126B7B2")]
		[DebuggerNonUserCode()]
		public EntitySet<HorarioSemana> HorarioSemana5
		{
			get
			{
				return this._horarioSemana5;
			}
			set
			{
				this._horarioSemana5 = value;
			}
		}
		
		[Association(Storage="_horarioSemana6", OtherKey="SegundaID", ThisKey="ID", Name="FK13850E96E4EC8C7F")]
		[DebuggerNonUserCode()]
		public EntitySet<HorarioSemana> HorarioSemana6
		{
			get
			{
				return this._horarioSemana6;
			}
			set
			{
				this._horarioSemana6 = value;
			}
		}
		
		[Association(Storage="_attCalcs", OtherKey="HorarioDiaID", ThisKey="ID", Name="FKE00671A0E8D8400B")]
		[DebuggerNonUserCode()]
		public EntitySet<AttCalcs> AttCalcs
		{
			get
			{
				return this._attCalcs;
			}
			set
			{
				this._attCalcs = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_applicationUser", OtherKey="ID", ThisKey="UpdatedByID", Name="FK13883A9F13D9D401", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser
		{
			get
			{
				return this._applicationUser.Entity;
			}
			set
			{
				if (((this._applicationUser.Entity == value) 
							== false))
				{
					if ((this._applicationUser.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser.Entity;
						this._applicationUser.Entity = null;
						previousApplicationUser.HorarioDia.Remove(this);
					}
					this._applicationUser.Entity = value;
					if ((value != null))
					{
						value.HorarioDia.Add(this);
						_updatedByID = value.ID;
					}
					else
					{
						_updatedByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_applicationUser1", OtherKey="ID", ThisKey="CreatedByID", Name="FK13883A9FF2EB5C6E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser1
		{
			get
			{
				return this._applicationUser1.Entity;
			}
			set
			{
				if (((this._applicationUser1.Entity == value) 
							== false))
				{
					if ((this._applicationUser1.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser1.Entity;
						this._applicationUser1.Entity = null;
						previousApplicationUser.HorarioDia1.Remove(this);
					}
					this._applicationUser1.Entity = value;
					if ((value != null))
					{
						value.HorarioDia1.Add(this);
						_createdByID = value.ID;
					}
					else
					{
						_createdByID = null;
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void HorarioSemana_Attach(HorarioSemana entity)
		{
			this.SendPropertyChanging();
			entity.HorarioDia = this;
		}
		
		private void HorarioSemana_Detach(HorarioSemana entity)
		{
			this.SendPropertyChanging();
			entity.HorarioDia = null;
		}
		
		private void HorarioSemana1_Attach(HorarioSemana entity)
		{
			this.SendPropertyChanging();
			entity.HorarioDia1 = this;
		}
		
		private void HorarioSemana1_Detach(HorarioSemana entity)
		{
			this.SendPropertyChanging();
			entity.HorarioDia1 = null;
		}
		
		private void HorarioSemana2_Attach(HorarioSemana entity)
		{
			this.SendPropertyChanging();
			entity.HorarioDia2 = this;
		}
		
		private void HorarioSemana2_Detach(HorarioSemana entity)
		{
			this.SendPropertyChanging();
			entity.HorarioDia2 = null;
		}
		
		private void HorarioSemana3_Attach(HorarioSemana entity)
		{
			this.SendPropertyChanging();
			entity.HorarioDia3 = this;
		}
		
		private void HorarioSemana3_Detach(HorarioSemana entity)
		{
			this.SendPropertyChanging();
			entity.HorarioDia3 = null;
		}
		
		private void HorarioSemana4_Attach(HorarioSemana entity)
		{
			this.SendPropertyChanging();
			entity.HorarioDia4 = this;
		}
		
		private void HorarioSemana4_Detach(HorarioSemana entity)
		{
			this.SendPropertyChanging();
			entity.HorarioDia4 = null;
		}
		
		private void HorarioSemana5_Attach(HorarioSemana entity)
		{
			this.SendPropertyChanging();
			entity.HorarioDia5 = this;
		}
		
		private void HorarioSemana5_Detach(HorarioSemana entity)
		{
			this.SendPropertyChanging();
			entity.HorarioDia5 = null;
		}
		
		private void HorarioSemana6_Attach(HorarioSemana entity)
		{
			this.SendPropertyChanging();
			entity.HorarioDia6 = this;
		}
		
		private void HorarioSemana6_Detach(HorarioSemana entity)
		{
			this.SendPropertyChanging();
			entity.HorarioDia6 = null;
		}
		
		private void AttCalcs_Attach(AttCalcs entity)
		{
			this.SendPropertyChanging();
			entity.HorarioDia = this;
		}
		
		private void AttCalcs_Detach(AttCalcs entity)
		{
			this.SendPropertyChanging();
			entity.HorarioDia = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.horario_semana")]
	public partial class HorarioSemana : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _codigo;
		
		private System.Nullable<long> _createdByID;
		
		private System.Nullable<System.DateTime> _creationDate;
		
		private string _descricao;
		
		private System.Nullable<long> _domingoID;
		
		private bool _hasFeriados;
		
		private bool _hasHorasExtras;
		
		private long _id;
		
		private System.Nullable<long> _quartaID;
		
		private System.Nullable<long> _quintaID;
		
		private System.Nullable<long> _sabadoID;
		
		private System.Nullable<long> _segundaID;
		
		private System.Nullable<long> _sextaID;
		
		private System.Nullable<long> _tercaID;
		
		private int _totalHoras;
		
		private int _totalMinutos;
		
		private System.Nullable<long> _updatedByID;
		
		private System.Nullable<System.DateTime> _updatedDate;
		
		private long _version;
		
		private EntitySet<FuncionarioHorario> _funcionarioHorario;
		
		private EntityRef<ApplicationUser> _applicationUser = new EntityRef<ApplicationUser>();
		
		private EntityRef<HorarioDia> _horarioDia = new EntityRef<HorarioDia>();
		
		private EntityRef<HorarioDia> _horarioDia1 = new EntityRef<HorarioDia>();
		
		private EntityRef<HorarioDia> _horarioDia2 = new EntityRef<HorarioDia>();
		
		private EntityRef<HorarioDia> _horarioDia3 = new EntityRef<HorarioDia>();
		
		private EntityRef<HorarioDia> _horarioDia4 = new EntityRef<HorarioDia>();
		
		private EntityRef<HorarioDia> _horarioDia5 = new EntityRef<HorarioDia>();
		
		private EntityRef<HorarioDia> _horarioDia6 = new EntityRef<HorarioDia>();
		
		private EntityRef<ApplicationUser> _applicationUser1 = new EntityRef<ApplicationUser>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCodigoChanged();
		
		partial void OnCodigoChanging(int value);
		
		partial void OnCreatedByIDChanged();
		
		partial void OnCreatedByIDChanging(System.Nullable<long> value);
		
		partial void OnCreationDateChanged();
		
		partial void OnCreationDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnDescricaoChanged();
		
		partial void OnDescricaoChanging(string value);
		
		partial void OnDomingoIDChanged();
		
		partial void OnDomingoIDChanging(System.Nullable<long> value);
		
		partial void OnHasFeriadosChanged();
		
		partial void OnHasFeriadosChanging(bool value);
		
		partial void OnHasHorasExtrasChanged();
		
		partial void OnHasHorasExtrasChanging(bool value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnQuartaIDChanged();
		
		partial void OnQuartaIDChanging(System.Nullable<long> value);
		
		partial void OnQuintaIDChanged();
		
		partial void OnQuintaIDChanging(System.Nullable<long> value);
		
		partial void OnSabadoIDChanged();
		
		partial void OnSabadoIDChanging(System.Nullable<long> value);
		
		partial void OnSegundaIDChanged();
		
		partial void OnSegundaIDChanging(System.Nullable<long> value);
		
		partial void OnSextaIDChanged();
		
		partial void OnSextaIDChanging(System.Nullable<long> value);
		
		partial void OnTercaIDChanged();
		
		partial void OnTercaIDChanging(System.Nullable<long> value);
		
		partial void OnTotalHorasChanged();
		
		partial void OnTotalHorasChanging(int value);
		
		partial void OnTotalMinutosChanged();
		
		partial void OnTotalMinutosChanging(int value);
		
		partial void OnUpdatedByIDChanged();
		
		partial void OnUpdatedByIDChanging(System.Nullable<long> value);
		
		partial void OnUpdatedDateChanged();
		
		partial void OnUpdatedDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public HorarioSemana()
		{
			_funcionarioHorario = new EntitySet<FuncionarioHorario>(new Action<FuncionarioHorario>(this.FuncionarioHorario_Attach), new Action<FuncionarioHorario>(this.FuncionarioHorario_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_codigo", Name="codigo", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int Codigo
		{
			get
			{
				return this._codigo;
			}
			set
			{
				if ((_codigo != value))
				{
					this.OnCodigoChanging(value);
					this.SendPropertyChanging();
					this._codigo = value;
					this.SendPropertyChanged("Codigo");
					this.OnCodigoChanged();
				}
			}
		}
		
		[Column(Storage="_createdByID", Name="created_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CreatedByID
		{
			get
			{
				return this._createdByID;
			}
			set
			{
				if ((_createdByID != value))
				{
					this.OnCreatedByIDChanging(value);
					this.SendPropertyChanging();
					this._createdByID = value;
					this.SendPropertyChanged("CreatedByID");
					this.OnCreatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_creationDate", Name="creation_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreationDate
		{
			get
			{
				return this._creationDate;
			}
			set
			{
				if ((_creationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._creationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[Column(Storage="_descricao", Name="descricao", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Descricao
		{
			get
			{
				return this._descricao;
			}
			set
			{
				if (((_descricao == value) 
							== false))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[Column(Storage="_domingoID", Name="domingo_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> DomingoID
		{
			get
			{
				return this._domingoID;
			}
			set
			{
				if ((_domingoID != value))
				{
					this.OnDomingoIDChanging(value);
					this.SendPropertyChanging();
					this._domingoID = value;
					this.SendPropertyChanged("DomingoID");
					this.OnDomingoIDChanged();
				}
			}
		}
		
		[Column(Storage="_hasFeriados", Name="has_feriados", DbType="bit(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool HasFeriados
		{
			get
			{
				return this._hasFeriados;
			}
			set
			{
				if ((_hasFeriados != value))
				{
					this.OnHasFeriadosChanging(value);
					this.SendPropertyChanging();
					this._hasFeriados = value;
					this.SendPropertyChanged("HasFeriados");
					this.OnHasFeriadosChanged();
				}
			}
		}
		
		[Column(Storage="_hasHorasExtras", Name="has_horas_extras", DbType="bit(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public bool HasHorasExtras
		{
			get
			{
				return this._hasHorasExtras;
			}
			set
			{
				if ((_hasHorasExtras != value))
				{
					this.OnHasHorasExtrasChanging(value);
					this.SendPropertyChanging();
					this._hasHorasExtras = value;
					this.SendPropertyChanged("HasHorasExtras");
					this.OnHasHorasExtrasChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_quartaID", Name="quarta_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> QuartaID
		{
			get
			{
				return this._quartaID;
			}
			set
			{
				if ((_quartaID != value))
				{
					this.OnQuartaIDChanging(value);
					this.SendPropertyChanging();
					this._quartaID = value;
					this.SendPropertyChanged("QuartaID");
					this.OnQuartaIDChanged();
				}
			}
		}
		
		[Column(Storage="_quintaID", Name="quinta_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> QuintaID
		{
			get
			{
				return this._quintaID;
			}
			set
			{
				if ((_quintaID != value))
				{
					this.OnQuintaIDChanging(value);
					this.SendPropertyChanging();
					this._quintaID = value;
					this.SendPropertyChanged("QuintaID");
					this.OnQuintaIDChanged();
				}
			}
		}
		
		[Column(Storage="_sabadoID", Name="sabado_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> SabadoID
		{
			get
			{
				return this._sabadoID;
			}
			set
			{
				if ((_sabadoID != value))
				{
					this.OnSabadoIDChanging(value);
					this.SendPropertyChanging();
					this._sabadoID = value;
					this.SendPropertyChanged("SabadoID");
					this.OnSabadoIDChanged();
				}
			}
		}
		
		[Column(Storage="_segundaID", Name="segunda_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> SegundaID
		{
			get
			{
				return this._segundaID;
			}
			set
			{
				if ((_segundaID != value))
				{
					this.OnSegundaIDChanging(value);
					this.SendPropertyChanging();
					this._segundaID = value;
					this.SendPropertyChanged("SegundaID");
					this.OnSegundaIDChanged();
				}
			}
		}
		
		[Column(Storage="_sextaID", Name="sexta_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> SextaID
		{
			get
			{
				return this._sextaID;
			}
			set
			{
				if ((_sextaID != value))
				{
					this.OnSextaIDChanging(value);
					this.SendPropertyChanging();
					this._sextaID = value;
					this.SendPropertyChanged("SextaID");
					this.OnSextaIDChanged();
				}
			}
		}
		
		[Column(Storage="_tercaID", Name="terca_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> TercaID
		{
			get
			{
				return this._tercaID;
			}
			set
			{
				if ((_tercaID != value))
				{
					this.OnTercaIDChanging(value);
					this.SendPropertyChanging();
					this._tercaID = value;
					this.SendPropertyChanged("TercaID");
					this.OnTercaIDChanged();
				}
			}
		}
		
		[Column(Storage="_totalHoras", Name="total_horas", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int TotalHoras
		{
			get
			{
				return this._totalHoras;
			}
			set
			{
				if ((_totalHoras != value))
				{
					this.OnTotalHorasChanging(value);
					this.SendPropertyChanging();
					this._totalHoras = value;
					this.SendPropertyChanged("TotalHoras");
					this.OnTotalHorasChanged();
				}
			}
		}
		
		[Column(Storage="_totalMinutos", Name="total_minutos", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int TotalMinutos
		{
			get
			{
				return this._totalMinutos;
			}
			set
			{
				if ((_totalMinutos != value))
				{
					this.OnTotalMinutosChanging(value);
					this.SendPropertyChanging();
					this._totalMinutos = value;
					this.SendPropertyChanged("TotalMinutos");
					this.OnTotalMinutosChanged();
				}
			}
		}
		
		[Column(Storage="_updatedByID", Name="updated_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UpdatedByID
		{
			get
			{
				return this._updatedByID;
			}
			set
			{
				if ((_updatedByID != value))
				{
					this.OnUpdatedByIDChanging(value);
					this.SendPropertyChanging();
					this._updatedByID = value;
					this.SendPropertyChanged("UpdatedByID");
					this.OnUpdatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedDate", Name="updated_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> UpdatedDate
		{
			get
			{
				return this._updatedDate;
			}
			set
			{
				if ((_updatedDate != value))
				{
					this.OnUpdatedDateChanging(value);
					this.SendPropertyChanging();
					this._updatedDate = value;
					this.SendPropertyChanged("UpdatedDate");
					this.OnUpdatedDateChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_funcionarioHorario", OtherKey="HorarioID", ThisKey="ID", Name="FK7554017E222F84DD")]
		[DebuggerNonUserCode()]
		public EntitySet<FuncionarioHorario> FuncionarioHorario
		{
			get
			{
				return this._funcionarioHorario;
			}
			set
			{
				this._funcionarioHorario = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_applicationUser", OtherKey="ID", ThisKey="UpdatedByID", Name="FK13850E9613D9D401", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser
		{
			get
			{
				return this._applicationUser.Entity;
			}
			set
			{
				if (((this._applicationUser.Entity == value) 
							== false))
				{
					if ((this._applicationUser.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser.Entity;
						this._applicationUser.Entity = null;
						previousApplicationUser.HorarioSemana.Remove(this);
					}
					this._applicationUser.Entity = value;
					if ((value != null))
					{
						value.HorarioSemana.Add(this);
						_updatedByID = value.ID;
					}
					else
					{
						_updatedByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_horarioDia", OtherKey="ID", ThisKey="SextaID", Name="FK13850E964B0B44D7", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public HorarioDia HorarioDia
		{
			get
			{
				return this._horarioDia.Entity;
			}
			set
			{
				if (((this._horarioDia.Entity == value) 
							== false))
				{
					if ((this._horarioDia.Entity != null))
					{
						HorarioDia previousHorarioDia = this._horarioDia.Entity;
						this._horarioDia.Entity = null;
						previousHorarioDia.HorarioSemana.Remove(this);
					}
					this._horarioDia.Entity = value;
					if ((value != null))
					{
						value.HorarioSemana.Add(this);
						_sextaID = value.ID;
					}
					else
					{
						_sextaID = null;
					}
				}
			}
		}
		
		[Association(Storage="_horarioDia1", OtherKey="ID", ThisKey="QuintaID", Name="FK13850E964F8B14D4", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public HorarioDia HorarioDia1
		{
			get
			{
				return this._horarioDia1.Entity;
			}
			set
			{
				if (((this._horarioDia1.Entity == value) 
							== false))
				{
					if ((this._horarioDia1.Entity != null))
					{
						HorarioDia previousHorarioDia = this._horarioDia1.Entity;
						this._horarioDia1.Entity = null;
						previousHorarioDia.HorarioSemana1.Remove(this);
					}
					this._horarioDia1.Entity = value;
					if ((value != null))
					{
						value.HorarioSemana1.Add(this);
						_quintaID = value.ID;
					}
					else
					{
						_quintaID = null;
					}
				}
			}
		}
		
		[Association(Storage="_horarioDia2", OtherKey="ID", ThisKey="DomingoID", Name="FK13850E9653F82B9B", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public HorarioDia HorarioDia2
		{
			get
			{
				return this._horarioDia2.Entity;
			}
			set
			{
				if (((this._horarioDia2.Entity == value) 
							== false))
				{
					if ((this._horarioDia2.Entity != null))
					{
						HorarioDia previousHorarioDia = this._horarioDia2.Entity;
						this._horarioDia2.Entity = null;
						previousHorarioDia.HorarioSemana2.Remove(this);
					}
					this._horarioDia2.Entity = value;
					if ((value != null))
					{
						value.HorarioSemana2.Add(this);
						_domingoID = value.ID;
					}
					else
					{
						_domingoID = null;
					}
				}
			}
		}
		
		[Association(Storage="_horarioDia3", OtherKey="ID", ThisKey="TercaID", Name="FK13850E96A7BFCE6B", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public HorarioDia HorarioDia3
		{
			get
			{
				return this._horarioDia3.Entity;
			}
			set
			{
				if (((this._horarioDia3.Entity == value) 
							== false))
				{
					if ((this._horarioDia3.Entity != null))
					{
						HorarioDia previousHorarioDia = this._horarioDia3.Entity;
						this._horarioDia3.Entity = null;
						previousHorarioDia.HorarioSemana3.Remove(this);
					}
					this._horarioDia3.Entity = value;
					if ((value != null))
					{
						value.HorarioSemana3.Add(this);
						_tercaID = value.ID;
					}
					else
					{
						_tercaID = null;
					}
				}
			}
		}
		
		[Association(Storage="_horarioDia4", OtherKey="ID", ThisKey="QuartaID", Name="FK13850E96AF2C9D48", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public HorarioDia HorarioDia4
		{
			get
			{
				return this._horarioDia4.Entity;
			}
			set
			{
				if (((this._horarioDia4.Entity == value) 
							== false))
				{
					if ((this._horarioDia4.Entity != null))
					{
						HorarioDia previousHorarioDia = this._horarioDia4.Entity;
						this._horarioDia4.Entity = null;
						previousHorarioDia.HorarioSemana4.Remove(this);
					}
					this._horarioDia4.Entity = value;
					if ((value != null))
					{
						value.HorarioSemana4.Add(this);
						_quartaID = value.ID;
					}
					else
					{
						_quartaID = null;
					}
				}
			}
		}
		
		[Association(Storage="_horarioDia5", OtherKey="ID", ThisKey="SabadoID", Name="FK13850E96D126B7B2", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public HorarioDia HorarioDia5
		{
			get
			{
				return this._horarioDia5.Entity;
			}
			set
			{
				if (((this._horarioDia5.Entity == value) 
							== false))
				{
					if ((this._horarioDia5.Entity != null))
					{
						HorarioDia previousHorarioDia = this._horarioDia5.Entity;
						this._horarioDia5.Entity = null;
						previousHorarioDia.HorarioSemana5.Remove(this);
					}
					this._horarioDia5.Entity = value;
					if ((value != null))
					{
						value.HorarioSemana5.Add(this);
						_sabadoID = value.ID;
					}
					else
					{
						_sabadoID = null;
					}
				}
			}
		}
		
		[Association(Storage="_horarioDia6", OtherKey="ID", ThisKey="SegundaID", Name="FK13850E96E4EC8C7F", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public HorarioDia HorarioDia6
		{
			get
			{
				return this._horarioDia6.Entity;
			}
			set
			{
				if (((this._horarioDia6.Entity == value) 
							== false))
				{
					if ((this._horarioDia6.Entity != null))
					{
						HorarioDia previousHorarioDia = this._horarioDia6.Entity;
						this._horarioDia6.Entity = null;
						previousHorarioDia.HorarioSemana6.Remove(this);
					}
					this._horarioDia6.Entity = value;
					if ((value != null))
					{
						value.HorarioSemana6.Add(this);
						_segundaID = value.ID;
					}
					else
					{
						_segundaID = null;
					}
				}
			}
		}
		
		[Association(Storage="_applicationUser1", OtherKey="ID", ThisKey="CreatedByID", Name="FK13850E96F2EB5C6E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser1
		{
			get
			{
				return this._applicationUser1.Entity;
			}
			set
			{
				if (((this._applicationUser1.Entity == value) 
							== false))
				{
					if ((this._applicationUser1.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser1.Entity;
						this._applicationUser1.Entity = null;
						previousApplicationUser.HorarioSemana1.Remove(this);
					}
					this._applicationUser1.Entity = value;
					if ((value != null))
					{
						value.HorarioSemana1.Add(this);
						_createdByID = value.ID;
					}
					else
					{
						_createdByID = null;
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void FuncionarioHorario_Attach(FuncionarioHorario entity)
		{
			this.SendPropertyChanging();
			entity.HorarioSemana = this;
		}
		
		private void FuncionarioHorario_Detach(FuncionarioHorario entity)
		{
			this.SendPropertyChanging();
			entity.HorarioSemana = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.localidade")]
	public partial class Localidade : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private long _code;
		
		private long _id;
		
		private string _nome;
		
		private long _postoAdministrativoID;
		
		private long _version;
		
		private EntitySet<Funcionario> _funcionario;
		
		private EntitySet<Empresa> _empresa;
		
		private EntityRef<PostoAdministrativo> _postoAdministrativo = new EntityRef<PostoAdministrativo>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCodeChanged();
		
		partial void OnCodeChanging(long value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnNomeChanged();
		
		partial void OnNomeChanging(string value);
		
		partial void OnPostoAdministrativoIDChanged();
		
		partial void OnPostoAdministrativoIDChanging(long value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public Localidade()
		{
			_funcionario = new EntitySet<Funcionario>(new Action<Funcionario>(this.Funcionario_Attach), new Action<Funcionario>(this.Funcionario_Detach));
			_empresa = new EntitySet<Empresa>(new Action<Empresa>(this.Empresa_Attach), new Action<Empresa>(this.Empresa_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_code", Name="code", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Code
		{
			get
			{
				return this._code;
			}
			set
			{
				if ((_code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_nome", Name="nome", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if (((_nome == value) 
							== false))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[Column(Storage="_postoAdministrativoID", Name="posto_administrativo_id", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long PostoAdministrativoID
		{
			get
			{
				return this._postoAdministrativoID;
			}
			set
			{
				if ((_postoAdministrativoID != value))
				{
					this.OnPostoAdministrativoIDChanging(value);
					this.SendPropertyChanging();
					this._postoAdministrativoID = value;
					this.SendPropertyChanged("PostoAdministrativoID");
					this.OnPostoAdministrativoIDChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_funcionario", OtherKey="LocalidadeID", ThisKey="ID", Name="FK50401DDB891EC8F5")]
		[DebuggerNonUserCode()]
		public EntitySet<Funcionario> Funcionario
		{
			get
			{
				return this._funcionario;
			}
			set
			{
				this._funcionario = value;
			}
		}
		
		[Association(Storage="_empresa", OtherKey="LocalidadeID", ThisKey="ID", Name="FK9F354089891EC8F5")]
		[DebuggerNonUserCode()]
		public EntitySet<Empresa> Empresa
		{
			get
			{
				return this._empresa;
			}
			set
			{
				this._empresa = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_postoAdministrativo", OtherKey="ID", ThisKey="PostoAdministrativoID", Name="FK4E3A9D1CB1014D9E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public PostoAdministrativo PostoAdministrativo
		{
			get
			{
				return this._postoAdministrativo.Entity;
			}
			set
			{
				if (((this._postoAdministrativo.Entity == value) 
							== false))
				{
					if ((this._postoAdministrativo.Entity != null))
					{
						PostoAdministrativo previousPostoAdministrativo = this._postoAdministrativo.Entity;
						this._postoAdministrativo.Entity = null;
						previousPostoAdministrativo.Localidade.Remove(this);
					}
					this._postoAdministrativo.Entity = value;
					if ((value != null))
					{
						value.Localidade.Add(this);
						_postoAdministrativoID = value.ID;
					}
					else
					{
						_postoAdministrativoID = default(long);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Funcionario_Attach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.Localidade = this;
		}
		
		private void Funcionario_Detach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.Localidade = null;
		}
		
		private void Empresa_Attach(Empresa entity)
		{
			this.SendPropertyChanging();
			entity.Localidade = this;
		}
		
		private void Empresa_Detach(Empresa entity)
		{
			this.SendPropertyChanging();
			entity.Localidade = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.mes_ano")]
	public partial class MesAno : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _ano;
		
		private System.DateTime _fim;
		
		private long _id;
		
		private System.DateTime _inicio;
		
		private int _mes;
		
		private int _ordem;
		
		private long _version;
		
		private EntitySet<FuncionarioHorario> _funcionarioHorario;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAnoChanged();
		
		partial void OnAnoChanging(int value);
		
		partial void OnFimChanged();
		
		partial void OnFimChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnInicioChanged();
		
		partial void OnInicioChanging(System.DateTime value);
		
		partial void OnMesChanged();
		
		partial void OnMesChanging(int value);
		
		partial void OnOrdemChanged();
		
		partial void OnOrdemChanging(int value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public MesAno()
		{
			_funcionarioHorario = new EntitySet<FuncionarioHorario>(new Action<FuncionarioHorario>(this.FuncionarioHorario_Attach), new Action<FuncionarioHorario>(this.FuncionarioHorario_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_ano", Name="ano", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int Ano
		{
			get
			{
				return this._ano;
			}
			set
			{
				if ((_ano != value))
				{
					this.OnAnoChanging(value);
					this.SendPropertyChanging();
					this._ano = value;
					this.SendPropertyChanged("Ano");
					this.OnAnoChanged();
				}
			}
		}
		
		[Column(Storage="_fim", Name="fim", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime Fim
		{
			get
			{
				return this._fim;
			}
			set
			{
				if ((_fim != value))
				{
					this.OnFimChanging(value);
					this.SendPropertyChanging();
					this._fim = value;
					this.SendPropertyChanged("Fim");
					this.OnFimChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_inicio", Name="inicio", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime Inicio
		{
			get
			{
				return this._inicio;
			}
			set
			{
				if ((_inicio != value))
				{
					this.OnInicioChanging(value);
					this.SendPropertyChanging();
					this._inicio = value;
					this.SendPropertyChanged("Inicio");
					this.OnInicioChanged();
				}
			}
		}
		
		[Column(Storage="_mes", Name="mes", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int Mes
		{
			get
			{
				return this._mes;
			}
			set
			{
				if ((_mes != value))
				{
					this.OnMesChanging(value);
					this.SendPropertyChanging();
					this._mes = value;
					this.SendPropertyChanged("Mes");
					this.OnMesChanged();
				}
			}
		}
		
		[Column(Storage="_ordem", Name="ordem", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int Ordem
		{
			get
			{
				return this._ordem;
			}
			set
			{
				if ((_ordem != value))
				{
					this.OnOrdemChanging(value);
					this.SendPropertyChanging();
					this._ordem = value;
					this.SendPropertyChanged("Ordem");
					this.OnOrdemChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_funcionarioHorario", OtherKey="PeriodoMensalID", ThisKey="ID", Name="FK7554017E123CE75E")]
		[DebuggerNonUserCode()]
		public EntitySet<FuncionarioHorario> FuncionarioHorario
		{
			get
			{
				return this._funcionarioHorario;
			}
			set
			{
				this._funcionarioHorario = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void FuncionarioHorario_Attach(FuncionarioHorario entity)
		{
			this.SendPropertyChanging();
			entity.MesAno = this;
		}
		
		private void FuncionarioHorario_Detach(FuncionarioHorario entity)
		{
			this.SendPropertyChanging();
			entity.MesAno = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.posto_administrativo")]
	public partial class PostoAdministrativo : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private long _code;
		
		private long _distritoID;
		
		private long _id;
		
		private string _nome;
		
		private long _version;
		
		private EntitySet<Localidade> _localidade;
		
		private EntitySet<Funcionario> _funcionario;
		
		private EntitySet<Empresa> _empresa;
		
		private EntityRef<Distrito> _distrito = new EntityRef<Distrito>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCodeChanged();
		
		partial void OnCodeChanging(long value);
		
		partial void OnDistritoIDChanged();
		
		partial void OnDistritoIDChanging(long value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnNomeChanged();
		
		partial void OnNomeChanging(string value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public PostoAdministrativo()
		{
			_localidade = new EntitySet<Localidade>(new Action<Localidade>(this.Localidade_Attach), new Action<Localidade>(this.Localidade_Detach));
			_funcionario = new EntitySet<Funcionario>(new Action<Funcionario>(this.Funcionario_Attach), new Action<Funcionario>(this.Funcionario_Detach));
			_empresa = new EntitySet<Empresa>(new Action<Empresa>(this.Empresa_Attach), new Action<Empresa>(this.Empresa_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_code", Name="code", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Code
		{
			get
			{
				return this._code;
			}
			set
			{
				if ((_code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[Column(Storage="_distritoID", Name="distrito_id", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long DistritoID
		{
			get
			{
				return this._distritoID;
			}
			set
			{
				if ((_distritoID != value))
				{
					this.OnDistritoIDChanging(value);
					this.SendPropertyChanging();
					this._distritoID = value;
					this.SendPropertyChanged("DistritoID");
					this.OnDistritoIDChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_nome", Name="nome", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if (((_nome == value) 
							== false))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_localidade", OtherKey="PostoAdministrativoID", ThisKey="ID", Name="FK4E3A9D1CB1014D9E")]
		[DebuggerNonUserCode()]
		public EntitySet<Localidade> Localidade
		{
			get
			{
				return this._localidade;
			}
			set
			{
				this._localidade = value;
			}
		}
		
		[Association(Storage="_funcionario", OtherKey="PostoAdministrativoID", ThisKey="ID", Name="FK50401DDBB1014D9E")]
		[DebuggerNonUserCode()]
		public EntitySet<Funcionario> Funcionario
		{
			get
			{
				return this._funcionario;
			}
			set
			{
				this._funcionario = value;
			}
		}
		
		[Association(Storage="_empresa", OtherKey="PostoAdministrativoID", ThisKey="ID", Name="FK9F354089B1014D9E")]
		[DebuggerNonUserCode()]
		public EntitySet<Empresa> Empresa
		{
			get
			{
				return this._empresa;
			}
			set
			{
				this._empresa = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_distrito", OtherKey="ID", ThisKey="DistritoID", Name="FKCFB37BA8CEDE1A35", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Distrito Distrito
		{
			get
			{
				return this._distrito.Entity;
			}
			set
			{
				if (((this._distrito.Entity == value) 
							== false))
				{
					if ((this._distrito.Entity != null))
					{
						Distrito previousDistrito = this._distrito.Entity;
						this._distrito.Entity = null;
						previousDistrito.PostoAdministrativo.Remove(this);
					}
					this._distrito.Entity = value;
					if ((value != null))
					{
						value.PostoAdministrativo.Add(this);
						_distritoID = value.ID;
					}
					else
					{
						_distritoID = default(long);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Localidade_Attach(Localidade entity)
		{
			this.SendPropertyChanging();
			entity.PostoAdministrativo = this;
		}
		
		private void Localidade_Detach(Localidade entity)
		{
			this.SendPropertyChanging();
			entity.PostoAdministrativo = null;
		}
		
		private void Funcionario_Attach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.PostoAdministrativo = this;
		}
		
		private void Funcionario_Detach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.PostoAdministrativo = null;
		}
		
		private void Empresa_Attach(Empresa entity)
		{
			this.SendPropertyChanging();
			entity.PostoAdministrativo = this;
		}
		
		private void Empresa_Detach(Empresa entity)
		{
			this.SendPropertyChanging();
			entity.PostoAdministrativo = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.provincia")]
	public partial class Provincia : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private long _code;
		
		private long _id;
		
		private string _nome;
		
		private long _version;
		
		private EntitySet<Distrito> _distrito;
		
		private EntitySet<Funcionario> _funcionario;
		
		private EntitySet<Empresa> _empresa;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCodeChanged();
		
		partial void OnCodeChanging(long value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnNomeChanged();
		
		partial void OnNomeChanging(string value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public Provincia()
		{
			_distrito = new EntitySet<Distrito>(new Action<Distrito>(this.Distrito_Attach), new Action<Distrito>(this.Distrito_Detach));
			_funcionario = new EntitySet<Funcionario>(new Action<Funcionario>(this.Funcionario_Attach), new Action<Funcionario>(this.Funcionario_Detach));
			_empresa = new EntitySet<Empresa>(new Action<Empresa>(this.Empresa_Attach), new Action<Empresa>(this.Empresa_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_code", Name="code", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Code
		{
			get
			{
				return this._code;
			}
			set
			{
				if ((_code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_nome", Name="nome", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if (((_nome == value) 
							== false))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_distrito", OtherKey="ProvinciaID", ThisKey="ID", Name="FK11393598A58767F")]
		[DebuggerNonUserCode()]
		public EntitySet<Distrito> Distrito
		{
			get
			{
				return this._distrito;
			}
			set
			{
				this._distrito = value;
			}
		}
		
		[Association(Storage="_funcionario", OtherKey="ProvinciaID", ThisKey="ID", Name="FK50401DDBA58767F")]
		[DebuggerNonUserCode()]
		public EntitySet<Funcionario> Funcionario
		{
			get
			{
				return this._funcionario;
			}
			set
			{
				this._funcionario = value;
			}
		}
		
		[Association(Storage="_empresa", OtherKey="ProvinciaID", ThisKey="ID", Name="FK9F354089A58767F")]
		[DebuggerNonUserCode()]
		public EntitySet<Empresa> Empresa
		{
			get
			{
				return this._empresa;
			}
			set
			{
				this._empresa = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Distrito_Attach(Distrito entity)
		{
			this.SendPropertyChanging();
			entity.Provincia = this;
		}
		
		private void Distrito_Detach(Distrito entity)
		{
			this.SendPropertyChanging();
			entity.Provincia = null;
		}
		
		private void Funcionario_Attach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.Provincia = this;
		}
		
		private void Funcionario_Detach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.Provincia = null;
		}
		
		private void Empresa_Attach(Empresa entity)
		{
			this.SendPropertyChanging();
			entity.Provincia = this;
		}
		
		private void Empresa_Detach(Empresa entity)
		{
			this.SendPropertyChanging();
			entity.Provincia = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.registration_code")]
	public partial class RegistrationCode : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _dateCreated;
		
		private long _id;
		
		private string _token;
		
		private string _userName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDateCreatedChanged();
		
		partial void OnDateCreatedChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnTokenChanged();
		
		partial void OnTokenChanging(string value);
		
		partial void OnUserNameChanged();
		
		partial void OnUserNameChanging(string value);
		#endregion
		
		
		public RegistrationCode()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_dateCreated", Name="date_created", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateCreated
		{
			get
			{
				return this._dateCreated;
			}
			set
			{
				if ((_dateCreated != value))
				{
					this.OnDateCreatedChanging(value);
					this.SendPropertyChanging();
					this._dateCreated = value;
					this.SendPropertyChanged("DateCreated");
					this.OnDateCreatedChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_token", Name="token", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Token
		{
			get
			{
				return this._token;
			}
			set
			{
				if (((_token == value) 
							== false))
				{
					this.OnTokenChanging(value);
					this.SendPropertyChanging();
					this._token = value;
					this.SendPropertyChanged("Token");
					this.OnTokenChanged();
				}
			}
		}
		
		[Column(Storage="_userName", Name="username", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string UserName
		{
			get
			{
				return this._userName;
			}
			set
			{
				if (((_userName == value) 
							== false))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._userName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="beta_interactive_sisga.role")]
	public partial class Role : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _authority;
		
		private long _id;
		
		private long _version;
		
		private EntitySet<ApplicationUserRole> _applicationUserRole;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAuthorityChanged();
		
		partial void OnAuthorityChanging(string value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public Role()
		{
			_applicationUserRole = new EntitySet<ApplicationUserRole>(new Action<ApplicationUserRole>(this.ApplicationUserRole_Attach), new Action<ApplicationUserRole>(this.ApplicationUserRole_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_authority", Name="authority", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Authority
		{
			get
			{
				return this._authority;
			}
			set
			{
				if (((_authority == value) 
							== false))
				{
					this.OnAuthorityChanging(value);
					this.SendPropertyChanging();
					this._authority = value;
					this.SendPropertyChanged("Authority");
					this.OnAuthorityChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_applicationUserRole", OtherKey="RoleID", ThisKey="ID", Name="FK9A16903B961F8313")]
		[DebuggerNonUserCode()]
		public EntitySet<ApplicationUserRole> ApplicationUserRole
		{
			get
			{
				return this._applicationUserRole;
			}
			set
			{
				this._applicationUserRole = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void ApplicationUserRole_Attach(ApplicationUserRole entity)
		{
			this.SendPropertyChanging();
			entity.Role = this;
		}
		
		private void ApplicationUserRole_Detach(ApplicationUserRole entity)
		{
			this.SendPropertyChanging();
			entity.Role = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.security_map")]
	public partial class SecurityMap : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _conFigAttribute;
		
		private string _description;
		
		private long _id;
		
		private string _url;
		
		private long _version;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnConFigAttributeChanged();
		
		partial void OnConFigAttributeChanging(string value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnURLChanged();
		
		partial void OnURLChanging(string value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public SecurityMap()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_conFigAttribute", Name="config_attribute", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ConFigAttribute
		{
			get
			{
				return this._conFigAttribute;
			}
			set
			{
				if (((_conFigAttribute == value) 
							== false))
				{
					this.OnConFigAttributeChanging(value);
					this.SendPropertyChanging();
					this._conFigAttribute = value;
					this.SendPropertyChanged("ConFigAttribute");
					this.OnConFigAttributeChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="description", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_url", Name="url", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string URL
		{
			get
			{
				return this._url;
			}
			set
			{
				if (((_url == value) 
							== false))
				{
					this.OnURLChanging(value);
					this.SendPropertyChanging();
					this._url = value;
					this.SendPropertyChanged("URL");
					this.OnURLChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="beta_interactive_sisga.semana_ano")]
	public partial class SemanaAno : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _ano;
		
		private System.DateTime _fim;
		
		private long _id;
		
		private System.DateTime _inicio;
		
		private int _mes;
		
		private int _ordem;
		
		private long _version;
		
		private EntitySet<FuncionarioHorario> _funcionarioHorario;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAnoChanged();
		
		partial void OnAnoChanging(int value);
		
		partial void OnFimChanged();
		
		partial void OnFimChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnInicioChanged();
		
		partial void OnInicioChanging(System.DateTime value);
		
		partial void OnMesChanged();
		
		partial void OnMesChanging(int value);
		
		partial void OnOrdemChanged();
		
		partial void OnOrdemChanging(int value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public SemanaAno()
		{
			_funcionarioHorario = new EntitySet<FuncionarioHorario>(new Action<FuncionarioHorario>(this.FuncionarioHorario_Attach), new Action<FuncionarioHorario>(this.FuncionarioHorario_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_ano", Name="ano", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int Ano
		{
			get
			{
				return this._ano;
			}
			set
			{
				if ((_ano != value))
				{
					this.OnAnoChanging(value);
					this.SendPropertyChanging();
					this._ano = value;
					this.SendPropertyChanged("Ano");
					this.OnAnoChanged();
				}
			}
		}
		
		[Column(Storage="_fim", Name="fim", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime Fim
		{
			get
			{
				return this._fim;
			}
			set
			{
				if ((_fim != value))
				{
					this.OnFimChanging(value);
					this.SendPropertyChanging();
					this._fim = value;
					this.SendPropertyChanged("Fim");
					this.OnFimChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_inicio", Name="inicio", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime Inicio
		{
			get
			{
				return this._inicio;
			}
			set
			{
				if ((_inicio != value))
				{
					this.OnInicioChanging(value);
					this.SendPropertyChanging();
					this._inicio = value;
					this.SendPropertyChanged("Inicio");
					this.OnInicioChanged();
				}
			}
		}
		
		[Column(Storage="_mes", Name="mes", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int Mes
		{
			get
			{
				return this._mes;
			}
			set
			{
				if ((_mes != value))
				{
					this.OnMesChanging(value);
					this.SendPropertyChanging();
					this._mes = value;
					this.SendPropertyChanged("Mes");
					this.OnMesChanged();
				}
			}
		}
		
		[Column(Storage="_ordem", Name="ordem", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int Ordem
		{
			get
			{
				return this._ordem;
			}
			set
			{
				if ((_ordem != value))
				{
					this.OnOrdemChanging(value);
					this.SendPropertyChanging();
					this._ordem = value;
					this.SendPropertyChanged("Ordem");
					this.OnOrdemChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_funcionarioHorario", OtherKey="PeriodoSemanalID", ThisKey="ID", Name="FK7554017E85866FAB")]
		[DebuggerNonUserCode()]
		public EntitySet<FuncionarioHorario> FuncionarioHorario
		{
			get
			{
				return this._funcionarioHorario;
			}
			set
			{
				this._funcionarioHorario = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void FuncionarioHorario_Attach(FuncionarioHorario entity)
		{
			this.SendPropertyChanging();
			entity.SemanaAno = this;
		}
		
		private void FuncionarioHorario_Detach(FuncionarioHorario entity)
		{
			this.SendPropertyChanging();
			entity.SemanaAno = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.sexo")]
	public partial class Sexo : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private long _id;
		
		private string _nome;
		
		private long _version;
		
		private EntitySet<Funcionario> _funcionario;
		
		private EntitySet<ApplicationUser> _applicationUser;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnNomeChanged();
		
		partial void OnNomeChanging(string value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public Sexo()
		{
			_funcionario = new EntitySet<Funcionario>(new Action<Funcionario>(this.Funcionario_Attach), new Action<Funcionario>(this.Funcionario_Detach));
			_applicationUser = new EntitySet<ApplicationUser>(new Action<ApplicationUser>(this.ApplicationUser_Attach), new Action<ApplicationUser>(this.ApplicationUser_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_nome", Name="nome", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if (((_nome == value) 
							== false))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_funcionario", OtherKey="SexoID", ThisKey="ID", Name="FK50401DDBA0783275")]
		[DebuggerNonUserCode()]
		public EntitySet<Funcionario> Funcionario
		{
			get
			{
				return this._funcionario;
			}
			set
			{
				this._funcionario = value;
			}
		}
		
		[Association(Storage="_applicationUser", OtherKey="UserSexoID", ThisKey="ID", Name="FKC715AFB67CA01")]
		[DebuggerNonUserCode()]
		public EntitySet<ApplicationUser> ApplicationUser
		{
			get
			{
				return this._applicationUser;
			}
			set
			{
				this._applicationUser = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Funcionario_Attach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.Sexo = this;
		}
		
		private void Funcionario_Detach(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.Sexo = null;
		}
		
		private void ApplicationUser_Attach(ApplicationUser entity)
		{
			this.SendPropertyChanging();
			entity.Sexo = this;
		}
		
		private void ApplicationUser_Detach(ApplicationUser entity)
		{
			this.SendPropertyChanging();
			entity.Sexo = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.system_log")]
	public partial class SystemLog : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _description;
		
		private long _id;
		
		private System.DateTime _logTime;
		
		private long _userID;
		
		private long _version;
		
		private EntityRef<ApplicationUser> _applicationUser = new EntityRef<ApplicationUser>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnLogTimeChanged();
		
		partial void OnLogTimeChanging(System.DateTime value);
		
		partial void OnUserIDChanged();
		
		partial void OnUserIDChanging(long value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public SystemLog()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_description", Name="description", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_logTime", Name="log_time", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime LogTime
		{
			get
			{
				return this._logTime;
			}
			set
			{
				if ((_logTime != value))
				{
					this.OnLogTimeChanging(value);
					this.SendPropertyChanging();
					this._logTime = value;
					this.SendPropertyChanged("LogTime");
					this.OnLogTimeChanged();
				}
			}
		}
		
		[Column(Storage="_userID", Name="user_id", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long UserID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((_userID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_applicationUser", OtherKey="ID", ThisKey="UserID", Name="FK2656953475CEC491", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser
		{
			get
			{
				return this._applicationUser.Entity;
			}
			set
			{
				if (((this._applicationUser.Entity == value) 
							== false))
				{
					if ((this._applicationUser.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser.Entity;
						this._applicationUser.Entity = null;
						previousApplicationUser.SystemLog.Remove(this);
					}
					this._applicationUser.Entity = value;
					if ((value != null))
					{
						value.SystemLog.Add(this);
						_userID = value.ID;
					}
					else
					{
						_userID = default(long);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="beta_interactive_sisga.tipo_falta")]
	public partial class TipoFalta : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private long _id;
		
		private string _nome;
		
		private long _version;
		
		private EntitySet<Falta> _falta;
		
		private EntitySet<AttCalcs> _attCalcs;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnNomeChanged();
		
		partial void OnNomeChanging(string value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public TipoFalta()
		{
			_falta = new EntitySet<Falta>(new Action<Falta>(this.Falta_Attach), new Action<Falta>(this.Falta_Detach));
			_attCalcs = new EntitySet<AttCalcs>(new Action<AttCalcs>(this.AttCalcs_Attach), new Action<AttCalcs>(this.AttCalcs_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_nome", Name="nome", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if (((_nome == value) 
							== false))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_falta", OtherKey="TipoID", ThisKey="ID", Name="FK5CB193EA2F5D9A")]
		[DebuggerNonUserCode()]
		public EntitySet<Falta> Falta
		{
			get
			{
				return this._falta;
			}
			set
			{
				this._falta = value;
			}
		}
		
		[Association(Storage="_attCalcs", OtherKey="TipoFaltaID", ThisKey="ID", Name="FKE00671A0D6A89BFB")]
		[DebuggerNonUserCode()]
		public EntitySet<AttCalcs> AttCalcs
		{
			get
			{
				return this._attCalcs;
			}
			set
			{
				this._attCalcs = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Falta_Attach(Falta entity)
		{
			this.SendPropertyChanging();
			entity.TipoFalta = this;
		}
		
		private void Falta_Detach(Falta entity)
		{
			this.SendPropertyChanging();
			entity.TipoFalta = null;
		}
		
		private void AttCalcs_Attach(AttCalcs entity)
		{
			this.SendPropertyChanging();
			entity.TipoFalta = this;
		}
		
		private void AttCalcs_Detach(AttCalcs entity)
		{
			this.SendPropertyChanging();
			entity.TipoFalta = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.user_clock")]
	public partial class UserClock : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<long> _clockStateID;
		
		private string _correctState;
		
		private System.Nullable<long> _createdByID;
		
		private System.Nullable<System.DateTime> _creationDate;
		
		private System.DateTime _date;
		
		private System.Nullable<System.DateTime> _dateAndTime;
		
		private long _deviceID;
		
		private long _funcionarioID;
		
		private long _id;
		
		private int _machineNumber;
		
		private string _result;
		
		private System.DateTime _time;
		
		private System.Nullable<long> _updatedByID;
		
		private System.Nullable<System.DateTime> _updatedDate;
		
		private System.Nullable<long> _verifyModeID;
		
		private long _version;
		
		private EntityRef<ApplicationUser> _applicationUser = new EntityRef<ApplicationUser>();
		
		private EntityRef<UserClockVerifyMode> _userClockVerifyMode = new EntityRef<UserClockVerifyMode>();
		
		private EntityRef<Device> _device = new EntityRef<Device>();
		
		private EntityRef<UserClockState> _userClockState = new EntityRef<UserClockState>();
		
		private EntityRef<ApplicationUser> _applicationUser1 = new EntityRef<ApplicationUser>();
		
		private EntityRef<Funcionario> _funcionario = new EntityRef<Funcionario>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnClockStateIDChanged();
		
		partial void OnClockStateIDChanging(System.Nullable<long> value);
		
		partial void OnCorrectStateChanged();
		
		partial void OnCorrectStateChanging(string value);
		
		partial void OnCreatedByIDChanged();
		
		partial void OnCreatedByIDChanging(System.Nullable<long> value);
		
		partial void OnCreationDateChanged();
		
		partial void OnCreationDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnDateChanged();
		
		partial void OnDateChanging(System.DateTime value);
		
		partial void OnDateAndTimeChanged();
		
		partial void OnDateAndTimeChanging(System.Nullable<System.DateTime> value);
		
		partial void OnDeviceIDChanged();
		
		partial void OnDeviceIDChanging(long value);
		
		partial void OnFuncionarioIDChanged();
		
		partial void OnFuncionarioIDChanging(long value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnMachineNumberChanged();
		
		partial void OnMachineNumberChanging(int value);
		
		partial void OnResultChanged();
		
		partial void OnResultChanging(string value);
		
		partial void OnTimeChanged();
		
		partial void OnTimeChanging(System.DateTime value);
		
		partial void OnUpdatedByIDChanged();
		
		partial void OnUpdatedByIDChanging(System.Nullable<long> value);
		
		partial void OnUpdatedDateChanged();
		
		partial void OnUpdatedDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnVerifyModeIDChanged();
		
		partial void OnVerifyModeIDChanging(System.Nullable<long> value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public UserClock()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_clockStateID", Name="clock_state_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ClockStateID
		{
			get
			{
				return this._clockStateID;
			}
			set
			{
				if ((_clockStateID != value))
				{
					this.OnClockStateIDChanging(value);
					this.SendPropertyChanging();
					this._clockStateID = value;
					this.SendPropertyChanged("ClockStateID");
					this.OnClockStateIDChanged();
				}
			}
		}
		
		[Column(Storage="_correctState", Name="correct_state", DbType="varchar(255)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CorrectState
		{
			get
			{
				return this._correctState;
			}
			set
			{
				if (((_correctState == value) 
							== false))
				{
					this.OnCorrectStateChanging(value);
					this.SendPropertyChanging();
					this._correctState = value;
					this.SendPropertyChanged("CorrectState");
					this.OnCorrectStateChanged();
				}
			}
		}
		
		[Column(Storage="_createdByID", Name="created_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CreatedByID
		{
			get
			{
				return this._createdByID;
			}
			set
			{
				if ((_createdByID != value))
				{
					this.OnCreatedByIDChanging(value);
					this.SendPropertyChanging();
					this._createdByID = value;
					this.SendPropertyChanged("CreatedByID");
					this.OnCreatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_creationDate", Name="creation_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreationDate
		{
			get
			{
				return this._creationDate;
			}
			set
			{
				if ((_creationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._creationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[Column(Storage="_date", Name="date", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime Date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((_date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[Column(Storage="_dateAndTime", Name="date_and_time", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateAndTime
		{
			get
			{
				return this._dateAndTime;
			}
			set
			{
				if ((_dateAndTime != value))
				{
					this.OnDateAndTimeChanging(value);
					this.SendPropertyChanging();
					this._dateAndTime = value;
					this.SendPropertyChanged("DateAndTime");
					this.OnDateAndTimeChanged();
				}
			}
		}
		
		[Column(Storage="_deviceID", Name="device_id", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long DeviceID
		{
			get
			{
				return this._deviceID;
			}
			set
			{
				if ((_deviceID != value))
				{
					this.OnDeviceIDChanging(value);
					this.SendPropertyChanging();
					this._deviceID = value;
					this.SendPropertyChanged("DeviceID");
					this.OnDeviceIDChanged();
				}
			}
		}
		
		[Column(Storage="_funcionarioID", Name="funcionario_id", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long FuncionarioID
		{
			get
			{
				return this._funcionarioID;
			}
			set
			{
				if ((_funcionarioID != value))
				{
					this.OnFuncionarioIDChanging(value);
					this.SendPropertyChanging();
					this._funcionarioID = value;
					this.SendPropertyChanged("FuncionarioID");
					this.OnFuncionarioIDChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_machineNumber", Name="machine_number", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int MachineNumber
		{
			get
			{
				return this._machineNumber;
			}
			set
			{
				if ((_machineNumber != value))
				{
					this.OnMachineNumberChanging(value);
					this.SendPropertyChanging();
					this._machineNumber = value;
					this.SendPropertyChanged("MachineNumber");
					this.OnMachineNumberChanged();
				}
			}
		}
		
		[Column(Storage="_result", Name="result", DbType="varchar(255)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Result
		{
			get
			{
				return this._result;
			}
			set
			{
				if (((_result == value) 
							== false))
				{
					this.OnResultChanging(value);
					this.SendPropertyChanging();
					this._result = value;
					this.SendPropertyChanged("Result");
					this.OnResultChanged();
				}
			}
		}
		
		[Column(Storage="_time", Name="time", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime Time
		{
			get
			{
				return this._time;
			}
			set
			{
				if ((_time != value))
				{
					this.OnTimeChanging(value);
					this.SendPropertyChanging();
					this._time = value;
					this.SendPropertyChanged("Time");
					this.OnTimeChanged();
				}
			}
		}
		
		[Column(Storage="_updatedByID", Name="updated_by_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UpdatedByID
		{
			get
			{
				return this._updatedByID;
			}
			set
			{
				if ((_updatedByID != value))
				{
					this.OnUpdatedByIDChanging(value);
					this.SendPropertyChanging();
					this._updatedByID = value;
					this.SendPropertyChanged("UpdatedByID");
					this.OnUpdatedByIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedDate", Name="updated_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> UpdatedDate
		{
			get
			{
				return this._updatedDate;
			}
			set
			{
				if ((_updatedDate != value))
				{
					this.OnUpdatedDateChanging(value);
					this.SendPropertyChanging();
					this._updatedDate = value;
					this.SendPropertyChanged("UpdatedDate");
					this.OnUpdatedDateChanged();
				}
			}
		}
		
		[Column(Storage="_verifyModeID", Name="verify_mode_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> VerifyModeID
		{
			get
			{
				return this._verifyModeID;
			}
			set
			{
				if ((_verifyModeID != value))
				{
					this.OnVerifyModeIDChanging(value);
					this.SendPropertyChanging();
					this._verifyModeID = value;
					this.SendPropertyChanged("VerifyModeID");
					this.OnVerifyModeIDChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_applicationUser", OtherKey="ID", ThisKey="UpdatedByID", Name="FK726DE69A13D9D401", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser
		{
			get
			{
				return this._applicationUser.Entity;
			}
			set
			{
				if (((this._applicationUser.Entity == value) 
							== false))
				{
					if ((this._applicationUser.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser.Entity;
						this._applicationUser.Entity = null;
						previousApplicationUser.UserClock.Remove(this);
					}
					this._applicationUser.Entity = value;
					if ((value != null))
					{
						value.UserClock.Add(this);
						_updatedByID = value.ID;
					}
					else
					{
						_updatedByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_userClockVerifyMode", OtherKey="ID", ThisKey="VerifyModeID", Name="FK726DE69A39ECB762", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public UserClockVerifyMode UserClockVerifyMode
		{
			get
			{
				return this._userClockVerifyMode.Entity;
			}
			set
			{
				if (((this._userClockVerifyMode.Entity == value) 
							== false))
				{
					if ((this._userClockVerifyMode.Entity != null))
					{
						UserClockVerifyMode previousUserClockVerifyMode = this._userClockVerifyMode.Entity;
						this._userClockVerifyMode.Entity = null;
						previousUserClockVerifyMode.UserClock.Remove(this);
					}
					this._userClockVerifyMode.Entity = value;
					if ((value != null))
					{
						value.UserClock.Add(this);
						_verifyModeID = value.ID;
					}
					else
					{
						_verifyModeID = null;
					}
				}
			}
		}
		
		[Association(Storage="_device", OtherKey="ID", ThisKey="DeviceID", Name="FK726DE69A486169E8", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Device Device
		{
			get
			{
				return this._device.Entity;
			}
			set
			{
				if (((this._device.Entity == value) 
							== false))
				{
					if ((this._device.Entity != null))
					{
						Device previousDevice = this._device.Entity;
						this._device.Entity = null;
						previousDevice.UserClock.Remove(this);
					}
					this._device.Entity = value;
					if ((value != null))
					{
						value.UserClock.Add(this);
						_deviceID = value.ID;
					}
					else
					{
						_deviceID = default(long);
					}
				}
			}
		}
		
		[Association(Storage="_userClockState", OtherKey="ID", ThisKey="ClockStateID", Name="FK726DE69A687B05D6", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public UserClockState UserClockState
		{
			get
			{
				return this._userClockState.Entity;
			}
			set
			{
				if (((this._userClockState.Entity == value) 
							== false))
				{
					if ((this._userClockState.Entity != null))
					{
						UserClockState previousUserClockState = this._userClockState.Entity;
						this._userClockState.Entity = null;
						previousUserClockState.UserClock.Remove(this);
					}
					this._userClockState.Entity = value;
					if ((value != null))
					{
						value.UserClock.Add(this);
						_clockStateID = value.ID;
					}
					else
					{
						_clockStateID = null;
					}
				}
			}
		}
		
		[Association(Storage="_applicationUser1", OtherKey="ID", ThisKey="CreatedByID", Name="FK726DE69AF2EB5C6E", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public ApplicationUser ApplicationUser1
		{
			get
			{
				return this._applicationUser1.Entity;
			}
			set
			{
				if (((this._applicationUser1.Entity == value) 
							== false))
				{
					if ((this._applicationUser1.Entity != null))
					{
						ApplicationUser previousApplicationUser = this._applicationUser1.Entity;
						this._applicationUser1.Entity = null;
						previousApplicationUser.UserClock1.Remove(this);
					}
					this._applicationUser1.Entity = value;
					if ((value != null))
					{
						value.UserClock1.Add(this);
						_createdByID = value.ID;
					}
					else
					{
						_createdByID = null;
					}
				}
			}
		}
		
		[Association(Storage="_funcionario", OtherKey="ID", ThisKey="FuncionarioID", Name="FK726DE69AFA7F0284", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Funcionario Funcionario
		{
			get
			{
				return this._funcionario.Entity;
			}
			set
			{
				if (((this._funcionario.Entity == value) 
							== false))
				{
					if ((this._funcionario.Entity != null))
					{
						Funcionario previousFuncionario = this._funcionario.Entity;
						this._funcionario.Entity = null;
						previousFuncionario.UserClock.Remove(this);
					}
					this._funcionario.Entity = value;
					if ((value != null))
					{
						value.UserClock.Add(this);
						_funcionarioID = value.ID;
					}
					else
					{
						_funcionarioID = default(long);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="beta_interactive_sisga.user_clock_state")]
	public partial class UserClockState : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private long _id;
		
		private string _name;
		
		private int _stateNumber;
		
		private long _version;
		
		private EntitySet<UserClock> _userClock;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnStateNumberChanged();
		
		partial void OnStateNumberChanging(int value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public UserClockState()
		{
			_userClock = new EntitySet<UserClock>(new Action<UserClock>(this.UserClock_Attach), new Action<UserClock>(this.UserClock_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_stateNumber", Name="state_number", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int StateNumber
		{
			get
			{
				return this._stateNumber;
			}
			set
			{
				if ((_stateNumber != value))
				{
					this.OnStateNumberChanging(value);
					this.SendPropertyChanging();
					this._stateNumber = value;
					this.SendPropertyChanged("StateNumber");
					this.OnStateNumberChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_userClock", OtherKey="ClockStateID", ThisKey="ID", Name="FK726DE69A687B05D6")]
		[DebuggerNonUserCode()]
		public EntitySet<UserClock> UserClock
		{
			get
			{
				return this._userClock;
			}
			set
			{
				this._userClock = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void UserClock_Attach(UserClock entity)
		{
			this.SendPropertyChanging();
			entity.UserClockState = this;
		}
		
		private void UserClock_Detach(UserClock entity)
		{
			this.SendPropertyChanging();
			entity.UserClockState = null;
		}
		#endregion
	}
	
	[Table(Name="beta_interactive_sisga.user_clock_verify_mode")]
	public partial class UserClockVerifyMode : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private long _id;
		
		private int _modeNumber;
		
		private string _name;
		
		private long _version;
		
		private EntitySet<UserClock> _userClock;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(long value);
		
		partial void OnModeNumberChanged();
		
		partial void OnModeNumberChanging(int value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnVersionChanged();
		
		partial void OnVersionChanging(long value);
		#endregion
		
		
		public UserClockVerifyMode()
		{
			_userClock = new EntitySet<UserClock>(new Action<UserClock>(this.UserClock_Attach), new Action<UserClock>(this.UserClock_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_id", Name="id", DbType="bigint(20)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_modeNumber", Name="mode_number", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ModeNumber
		{
			get
			{
				return this._modeNumber;
			}
			set
			{
				if ((_modeNumber != value))
				{
					this.OnModeNumberChanging(value);
					this.SendPropertyChanging();
					this._modeNumber = value;
					this.SendPropertyChanged("ModeNumber");
					this.OnModeNumberChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_version", Name="version", DbType="bigint(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public long Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_userClock", OtherKey="VerifyModeID", ThisKey="ID", Name="FK726DE69A39ECB762")]
		[DebuggerNonUserCode()]
		public EntitySet<UserClock> UserClock
		{
			get
			{
				return this._userClock;
			}
			set
			{
				this._userClock = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void UserClock_Attach(UserClock entity)
		{
			this.SendPropertyChanging();
			entity.UserClockVerifyMode = this;
		}
		
		private void UserClock_Detach(UserClock entity)
		{
			this.SendPropertyChanging();
			entity.UserClockVerifyMode = null;
		}
		#endregion
	}
}
