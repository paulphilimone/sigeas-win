Developers
- Install Nuget Package Manager on VS2010
  eg. install-package EPPlus
- Install NET Connector - mysql-connector-net-6.9.8.msi
- Install and register ZK SDK - Communication Protocol SDK(64Bit Ver6.2.4.1)
  - can be downloaded from https://paulphilimone@bitbucket.org/betainteractive/zk-sdk.git
- The database connection string can be change on file
  Sistema de Gestao de Assiduidade.exe.config


- Notes onn future development.  
  - Ter em conta Multiple Verification Modes, altera verifyMode number
  - Add saving dialog to "Guardar associacoes" on tableFuncionariosDeviceView

- New Features
  - Add Device Capacity Warning (need to connect once or twice a week, create statistics of clocks per day)
  - Initial Program Setup needs Technical Assistant
  - Controlador de Ferias (new feature)
  - Controle de acesso aos departamentos (new feature)
  - Generate Reports
    - Per Funcionario  - Todos dias do mês
    - Per Departamento - Total de Horas trabalhadas no mês, horas nâo trabalhadas, horas extras, faltas
    - Per Categoria    - Total de Horas trabalhadas no mês, horas nâo trabalhadas, horas extras, faltas
    - Mais faltosos por Departamentos
    - Departamento com mais faltas
    - 

Fase 1 - depois venda
 - Testar e corrigir bugs
   - UserClockViewer bugs
     - Not saving
 - Modificar Planificacao de Horario (tornar mais facil)
 - Adicionar Reports

Fase 2 - depois venda e update
 - Mudar as Views do programa (torna-lo mais user friendly)
 - Optional (Faces e Multiple Verification Mode)

Fase 3
 - Web Application
 - SigeasDeviceModule - Server(app with rest web services) n Client(java)