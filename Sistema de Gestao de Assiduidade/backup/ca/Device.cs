using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mz.betaInteractive.sisga;
using System.ComponentModel;
using System.Windows.Forms;

namespace mz.betainteractive.sisga.model.ca{
    public class SDevice   {
        public Device DB;
        /*
        public int Index; //DatabaseIndex       
        public string Name;
        public string SerialNumber;        
        public int DoorIndex;
        //IN-OUT,IN,OUT
        public int Type;
        //TCP,COM,USB
        public int ConnectionType;
        //NetConnection
        public string IpAddress;
        public int Port;
        //SerialConnection
        public int BaudRate;
        public int ComPort;
        */

        public SDoor Door;
        public zkemkeeper.CZKEMClass ACCESS;
        public bool Connected;

        public InfoDownload Download;

        public FrmPopupBackground popup;
        private BackgroundWorker bckgThread;

        //Action
        bool firedConnect;

        //STATUS
        /*
        public int NUMBER_OF_ADMINISTRATORS; //1
        public int NUMBER_OF_USERS;          //2
        public int NUMBER_OF_FINGERPRINTS;   //3   
        public int NUMBER_OF_PASSWORDS;      //4
        public int NUMBER_OF_ADMIN_LOGS;     //5 nº de vezes que o admin do biometrico acedeu a este
        public int NUMBER_OF_ATT_RECORDS;    //6
        public int FINGERPRINT_CAPACITY;     //7
        public int USER_CAPACITY;            //8
        public int RECORD_CAPACITY;          //9
         */
        //STATUS ends here

        private SDevice(Device device) {
            this.DB = device;
            /*
            this.Index = device.ID;
            this.Name = device.Name;
            this.SerialNumber = device.SerialNumber;
            this.DoorIndex = (int) device.DoorIndex;
            this.Type = (int) device.Type;

            this.ConnectionType = (int)device.ConnectionType;
            this.IpAddress = device.IPAddress;
            this.Port = (int)device.Port;
            this.ComPort = (int)device.ComPort;
            this.BaudRate = (int)device.BaudRate;
            */

            this.ACCESS = new zkemkeeper.CZKEMClass();
            popup = new FrmPopupBackground();

            bckgThread = new BackgroundWorker();
            bckgThread.DoWork += new DoWorkEventHandler(bckgThread_DoWork);
            bckgThread.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bckgThread_RunWorkerCompleted);
            bckgThread.ProgressChanged += new ProgressChangedEventHandler(bckgThread_ProgressChanged);

            this.Download = new InfoDownload(this);
        }

        public SDevice(Device device, SDoor door)
            : this(device) {
            this.Door = door;
        }                

        private void bckgThread_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            
        }

        private void bckgThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (firedConnect) {
                popup.Hide();
                firedConnect = false;
                if (Connected) {                    
                } else {
                    MessageBox.Show("Não foi possivel efectuar a conexão");                    
                }                
            }
        }

        private void bckgThread_DoWork(object sender, DoWorkEventArgs e) {
            try {
                if (firedConnect) {
                    if (DB.ConnectionType == 0) { //TCP
                        Connected = ACCESS.Connect_Net(DB.IPAddress, DB.Port);
                    }
                    if (DB.ConnectionType == 1) { //RS
                        Connected = ACCESS.Connect_Com(DB.ComPort, 1, DB.BaudRate);
                    }
                    if (DB.ConnectionType == 1) { //USB
                        Connected = ACCESS.Connect_USB(1);
                    }

                    if (Connected) {
                        bool regev = this.ACCESS.RegEvent(1, 32767);
                        Console.WriteLine("All Events Registred " + regev);
                    }
                }
            } catch (Exception ex) {
                Connected = false;
                //Create a error Logs
                //ex.
                
            }
        }               

        public void Update(Device device) {
            this.DB = device;
            /*
            this.Index = device.ID;
            this.Name = device.Name;
            this.SerialNumber = device.SerialNumber;
            this.DoorIndex = (int) device.DoorIndex;
            this.Type = (int) device.Type;

            this.ConnectionType = (int)device.ConnectionType;
            this.IpAddress = device.IPAddress;
            this.Port = (int)device.Port;
            this.ComPort = (int)device.ComPort;
            this.BaudRate = (int)device.BaudRate;
             */
        }

        public void Connect() {
            firedConnect = true;
            bckgThread.RunWorkerAsync();
            popup.LabelText.Text = "Conectando (" + this.DB.Name + ")...";
            popup.ShowDialog();
        }

        public void Disconnect() {
            Connected = false;
            ACCESS.Disconnect();
        }

        public override string ToString() {
            return Door.DB.Name + ": " + DB.Name;
        }
    }
}
