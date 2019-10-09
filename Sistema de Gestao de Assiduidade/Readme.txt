Developers
- Install Nuget Package Manager on VS2010
  eg. install-package EPPlus
- Install Crystal Reports for VS - CRforVS_13_0_17.exe (dont forget to install the Runtime - extract the .exe first)
- Install NET Connector - mysql-connector-net-6.9.8.msi
- Install and register ZK SDK - Communication Protocol SDK(64Bit Ver6.2.4.1)
  - can be downloaded from https://paulphilimone@bitbucket.org/betainteractive/zk-sdk.git
- The database connection string can be change on file
  Sistema de Gestao de Assiduidade.exe.config


- Notes onn future development.  
  - Ter em conta Multiple Verification Modes, altera verifyMode number
  - Ao recalcular AttendanceData - permitir apagar ou nao
  - (***) Para o futuro ver o que fazer quando houver clocks (num dia em que nao se trabalha, num feriado e no periodo de ferias)

- New Features  
  - Novas Funcionalidades
   - onLoginChecks -> (put a lot of checks, recalcular ferias, device capacity warning, etc) 
   - after 30 minutes without touching, Lock account
   - if Program is always opening, openingChecks.        
  - Initial Program Setup needs Technical Assistant
  - Controlador de Ferias (new feature)
  - Controle de acesso aos departamentos (new feature)  -      
  - Para o futuro permitir alterar/remover MonthWorks sem apagar os ja usados

Fase 1 - antes da venda
 - Testar e corrigir bugs 
   * - Metodos de insercao de dados (device model - devem acompanhar o tipo de dispositivo BW or TFT) - Done!
 - Adicionar Reports - Done!
 - Mudar as Views do programa (torna-lo mais user friendly)
   - MainView melhorar - Done!
   - Reagrupar os menus - Done!
   - Planear como cada Form deve abrir (MDI e Dialogs) - **** missing test all
   - Segurança de Forms e bloqueio de buttons - ****
     - put content of new forms 14,15,16,17 to SystemManager security - Done!
     - confirm the appliance of every RolePermission on their respective forms - ****

Fase 2 - depois venda e update (vender 2 e fazer testes)
 - Optional (Faces e Multiple Verification Mode)
 - Corrigir Bug's

Fase 3
 - Web Application
 - SigeasDeviceModule - Server(app with rest web services) n Client(java)

Forms/Views List and dependency
-------------------------------
UserManager - blocks - 
//this.UserManagement.FormCode = 0x0101; Add, View, Update, Delete - Done!

//this.DeviceManager.FormCode = 0x0102; Add, View, Update, Delete - Done!
BtnAddDoor, BtnAddDevice, BtnRemoveDoor, BtnSaveDoor, BtnSaveDevice, BtnRemoveDevice, btDelAllUserClock, btDelAllUsers

//this.DeviceActivation.FormCode = 0x0103; View - Done!

//this.EmpresaForm.FormCode = 0x0104; Add, View, Update, Delete - 

//this.FuncionarioForm.FormCode = 0x0105; 
Add, View, Update, Delete

//this.HorarioSemanalForm.FormCode = 0x0106; 
Add, View, Update, Delete

//this.PlanificacaoHorarioForm.FormCode = 0x0107;
Add, View, Update, Delete

//this.FeriadosForm.FormCode = 0x0108;
Add, View

//this.FeriasForm.FormCode = 0x0109;
new RolePermission { FormCode = 0x0109, ActionCode = 1, Name = "Visualizar Planificação de Férias" });
new RolePermission { FormCode = 0x0109, ActionCode = 2, Name = "Atualizar Plano de Férias" });

//this.UserClockViewerForm.FormCode = 0x0110;
new RolePermission { FormCode = 0x0110, ActionCode = 1, Name = "Visualizar Registos de Picagens" });
new RolePermission { FormCode = 0x0110, ActionCode = 2, Name = "Atualizar Registos de Picagens" });
new RolePermission { FormCode = 0x0110, ActionCode = 3, Name = "Apagar Registos de Picagens" });
new RolePermission { FormCode = 0x0110, ActionCode = 4, Name = "Adicionar Registos de Picagens" });

//this.AttendanceCalcsForm.FormCode = 0x0111;
new RolePermission { FormCode = 0x0111, ActionCode = 1, Name = "Visualizar Cálculos de Assiduidades" });
new RolePermission { FormCode = 0x0111, ActionCode = 2, Name = "Efectuar Cálculos de Assiduidades" });

//this.FuncionarioDevicesView.FormCode = 0x0112;
new RolePermission { FormCode = 0x0112, ActionCode = 1, Name = "Planificar o acesso as portas/biométricos pelos Funcionarios" });

//this.deviceDataUpdateView.FormCode = 0x0113;
new RolePermission { FormCode = 0x0113, ActionCode = 1, Name = "Registar/Atualizar Funcionários nos Biométricos" });

//this.ImportHrData.FormCode = 0x0114;
new RolePermission { FormCode = 0x0114, ActionCode = 1, Name = "Importar dados dados RH apartir de XLS/x" });

//this.importExportView.FormCode = 0x0115;
new RolePermission { FormCode = 0x0115, ActionCode = 1, Name = "Importar/Exportar Dados biométricos para colheita de dados" });
               
//this.pedidoDispensaView.FormCode = 0x0116;
new RolePermission { FormCode = 0x0116, ActionCode = 1, Name = "Visualizar Formulário de Pedido de dispensa" });
               
//this.reportsCreatorView.FormCode = 0x0117;
new RolePermission { FormCode = 0x0117, ActionCode = 1, Name = "Visualizar e criar Relatórios de Assiduidade" });