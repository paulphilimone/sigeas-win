using System;
using System.Collections.Generic;
using System.Windows.Forms;
using mz.betainteractive.sigeas.model.ca;
using System.Threading;
using System.Globalization;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.Views;
using mz.betainteractive.sigeas.Views.Main;


namespace mz.betainteractive.sigeas {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-PT");
            Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencySymbol = "Mt";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.DoEvents();

            SystemManager manager = SystemManager.getManager();

            SplashScreenUpdater47 updater = new SplashScreenUpdater47(manager);
            manager.addSystemManagerListener(updater);


            //Tests();
            Application.Run(new SplashScreen(updater));

        }

        static void Tests() {
            /*
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=sigeas;Password=s@ge_omega47;Database=bi_sigeas_database;");
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand("insert into testx values('Paulo', 'Filimone')", conn);
            int i = command.ExecuteNonQuery();
            Console.WriteLine("result=" + i);
            */
        }

        class SplashScreenUpdater47 : SplashScreen.SplashScreenUpdater, SystemManagerListener {
            SystemManager manager;
            LoginView loginView;

            public SplashScreenUpdater47(SystemManager manager) {
                this.manager = manager;
            }

            public void LoadingDatabase(int progressPercentage) {
                this.OnLoading(progressPercentage);
            }

            public void FinishedLoading() {

            }

            public override void StartLoading() {
                this.manager.Initialize();

            }

            public override void OnFinishedLoading() {
                loginView = new LoginView();
                loginView.Visible = true;
            }

        }

    }
}