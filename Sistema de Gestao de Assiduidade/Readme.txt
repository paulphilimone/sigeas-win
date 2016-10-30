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
   - Reagrupar os menus - ****
   - Planear como cada Form deve abrir (MDI e Dialogs) - ****
   - Segurança de Forms e bloqueio de buttons - ****

Fase 2 - depois venda e update (vender 2 e fazer testes)
 - Optional (Faces e Multiple Verification Mode)
 - Corrigir Bug's

Fase 3
 - Web Application
 - SigeasDeviceModule - Server(app with rest web services) n Client(java)

Forms/Views List and dependency
-------------------------------
