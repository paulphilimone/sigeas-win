REM: note that the '-sprocs' option is turned on
del SisgaDB.cs
DbMetal.exe -provider=MySql -database:beta_interactive_sisga -server:localhost -user:root -namespace:mz.betainteractive.sisga -code:SisgaDB.cs -sprocs
pause


