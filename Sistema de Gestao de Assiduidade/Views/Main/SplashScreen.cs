using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.Models;

namespace mz.betainteractive.sigeas.Views.Main {
    public partial class SplashScreen : Form {
        
        private BackgroundWorker worker = new BackgroundWorker();
        private SplashScreenUpdater updater;

        public SplashScreen(SplashScreenUpdater updater) {
            InitializeComponent();
            this.updater = updater;
            
            worker.WorkerReportsProgress = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);

            this.updater.BackgroundWorker = worker;
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            this.Hide();
            updater.OnFinishedLoading();            
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            this.ProgressBar.Value = e.ProgressPercentage;
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e) {
            updater.StartLoading();
        }

        private void SplashScreen_Shown(object sender, EventArgs e) {
            worker.RunWorkerAsync();
        }

        public abstract class SplashScreenUpdater {
            public BackgroundWorker BackgroundWorker {get; set;}
            
            public abstract void StartLoading();

            public void OnLoading(int progress) {
                this.BackgroundWorker.ReportProgress(progress);
            }

            public abstract void OnFinishedLoading();
        }

        private void ApplicationTitle_Click(object sender, EventArgs e) {

        }
    }

    
}
