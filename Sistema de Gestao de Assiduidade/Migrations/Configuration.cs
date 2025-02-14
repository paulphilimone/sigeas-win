using System.Data.Entity.Migrations;

namespace mz.betainteractive.sigeas.Migrations
{   
    
    internal sealed class Configuration : DbMigrationsConfiguration<mz.betainteractive.sigeas.Models.SigeasDatabaseContext>
    {
        public Configuration() {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            //SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());  
        }

        protected override void Seed(mz.betainteractive.sigeas.Models.SigeasDatabaseContext context) {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
