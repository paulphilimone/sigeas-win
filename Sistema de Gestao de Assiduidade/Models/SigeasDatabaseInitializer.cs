using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Configuration;
using mz.betainteractive.sigeas.Models;

namespace mz.betainteractive.sigeas.Models {

    public class SigeasDatabaseInitializer : IDatabaseInitializer<SigeasDatabaseContext> {

        public void InitializeDatabase(SigeasDatabaseContext context) {
            Console.WriteLine("INITIALIZING");
            if (!context.Database.Exists()) {
                Console.WriteLine("CREATE DATABASE");
                //Create Database
                context.Database.Create();
            } else {
                Console.WriteLine("UPGRADE DATABASE");
                if (!context.Database.CompatibleWithModel(true)) {                    
                    //Upgrade Database
                    Database.SetInitializer(new MigrateDatabaseToLatestVersion<SigeasDatabaseContext, mz.betainteractive.sigeas.Migrations.Configuration>());                    
                    context.Database.Initialize(true);
                }
            }
        }
    }

}
