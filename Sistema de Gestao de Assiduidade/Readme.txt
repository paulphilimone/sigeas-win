Developers
- Install Nuget Package Manager on VS2010
  eg. install-package EPPlus
- Install Crystal Reports for VS - CRforVS_13_0_17.exe
- Install NET Connector - mysql-connector-net-6.9.8.msi
- Install and register ZK SDK - Communication Protocol SDK(64Bit Ver6.2.4.1)
  - can be downloaded from https://paulphilimone@bitbucket.org/betainteractive/zk-sdk.git
- The database connection string can be change on file
  Sistema de Gestao de Assiduidade.exe.config


- Notes onn future development.  
  - Ter em conta Multiple Verification Modes, altera verifyMode number
  - Ao recalcular AttendanceData - permitir apagar ou nao

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
   * - Metodos de insercao de dados (device model - devem acompanhar o tipo de dispositivo BW or TFT)              
     - Executing this
       - Detect every direct method used - not done
       - Convert to Methods on SDM
 - (***) Para o futuro ver o que fazer quando houver clocks (num dia em que nao se trabalha, num feriado e no periodo de ferias)
 - Adicionar Reports
    Generate Reports
    - Mais faltosos por Departamentos
    - Departamento com mais faltas

Fase 2 - depois venda e update
 - Mudar as Views do programa (torna-lo mais user friendly)
 - Optional (Faces e Multiple Verification Mode)

Fase 3
 - Web Application
 - SigeasDeviceModule - Server(app with rest web services) n Client(java)