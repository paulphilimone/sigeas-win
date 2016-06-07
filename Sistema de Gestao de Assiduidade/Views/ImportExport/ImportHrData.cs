using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.Utilities.Components;
using System.IO;
using OfficeOpenXml;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.model.ca;
using mz.betainteractive.sigeas.BackgroundFeatures;
using mz.betainteractive.sigeas.DeviceSystem;
using mz.betainteractive.sigeas.Utilities;

namespace mz.betainteractive.sigeas.Views.ImportExport {
    public partial class ImportHrData : Form, AuthorizableComponent {

        private SigeasDatabaseContext context;
        private Empresa empresa;
        private OpenFileDialog openFileDialog = null;
        private string OpenedFileName;

        private List<Departamento> departamentos;
        private List<Categoria> categorias;
        private List<XlsFuncionario> funcionarios;

        private SortedSet<int> avaiables_users;

        public int FormCode { get; set; }
        public bool AllowView { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowAdd { get; set; }


        public ImportHrData() {
            InitializeComponent();            
        }
        
        private void DisposeContext() {
            if (context != null) {
                context.Dispose();
                context = null;
                openFileDialog = null;
            }
        }

        private void LoadContext() {
            if (context == null) {
                context = new SigeasDatabaseContext();
                Initialize();
            }
        }

        private void Initialize() {
            this.openFileDialog = new OpenFileDialog();
            this.empresa = SystemManager.GetCurrentEmpresa(context);
            this.departamentos = new List<Departamento>();
            this.categorias = new List<Categoria>();
            this.funcionarios = new List<XlsFuncionario>();

            this.avaiables_users = new SortedSet<int>();

            this.BtnDownloadFps.Enabled = false;
            this.BtnConnect.Enabled = false;
            
            LoadDevicesToComboBox();
        }

        private void LoadDevicesToComboBox() {
            //No futuro não sera assim
            var devices = context.Device.ToList();

            CBoxDevices.Items.Clear();

            foreach (Device dev in devices) {
                CBoxDevices.Items.Add(dev);
            }
        }

        private void ImportHrData_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
            DisposeContext();
        }

        private void ImportHrData_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible == true) {
                this.LoadContext();
            }
        }

        private void BtnImportFile_Click(object sender, EventArgs e) {
            importXLSFile();
        }

        private void importXLSFile() {


            this.openFileDialog.Filter = "Excel files *.xls|*.xlsx";
            this.openFileDialog.InitialDirectory = "c:\\";
            this.openFileDialog.Title = "Importar ficheiro XLS";

            try {

                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK) {
                    this.OpenedFileName = openFileDialog.FileName;
                                      
                    if (Path.GetExtension(OpenedFileName) == ".xlsx" || Path.GetExtension(OpenedFileName) == ".xls") {
                        ReadXlsFile();
                    } else {
                        MessageBox.Show("Não foi possivel ler o ficheiro! A extensão deve ser XLS/X");
                    }

                    // Workbook wk;
                }

            } catch (Exception ex) {
                MessageBox.Show("Não foi possivel ler o ficheiro!" + Environment.NewLine + "" + ex.ToString());
            }
        }

        private void ReadXlsFile() {

            this.departamentos.Clear();
            this.categorias.Clear();
            this.funcionarios.Clear();
            this.LViewDepartamentos.Items.Clear();
            this.LViewCategorias.Items.Clear();
            this.LViewFuncionarios.Items.Clear();

            ExcelPackage package = new ExcelPackage(openFileDialog.OpenFile());
            
            //package.Workbook.Worksheets
            TxtImportedFile.Text = OpenedFileName;

            ExcelWorksheet wDepts = null;
            ExcelWorksheet wCategs = null;
            ExcelWorksheet wFuncs = null;

            foreach (var ws in package.Workbook.Worksheets){
                Console.WriteLine("ws: " + ws.Name);
                if (wDepts == null) {
                    wDepts = ws;
                    continue;
                }
                if (wCategs == null) {
                    wCategs = ws;
                    continue;
                }
                if (wFuncs == null) {
                    wFuncs = ws;
                    continue;
                }
            }

            //ExcelWorksheet wDepts = package.Workbook.Worksheets.ElementAt(0);
            //ExcelWorksheet wCategs = package.Workbook.Worksheets.ElementAt(1);
            //ExcelWorksheet wFuncs = package.Workbook.Worksheets.ElementAt(2);

            ReadDepartamentos(wDepts);
            ReadCategorias(wCategs);
            ReadFuncionarios(wFuncs);


        }

        private void ReadFuncionarios(ExcelWorksheet wFuncs) {
            for (var rowNumber = 2; rowNumber <= wFuncs.Dimension.End.Row; rowNumber++) {
                var row = wFuncs.Cells[rowNumber, 1, rowNumber, wFuncs.Dimension.End.Column];
                                
                if (row.Count() < 11) {
                    Console.WriteLine("Empty Line, Break!");
                    break;
                }

                XlsFuncionario func = new XlsFuncionario();
                func.code = row.ElementAt(0).Text;
                func.name = row.ElementAt(1).Text;
                func.gender = row.ElementAt(2).Text;
                func.department_code = row.ElementAt(3).Text;
                func.category_code = row.ElementAt(4).Text;
                func.enrollNumber = row.ElementAt(5).Text;
                func.privilege = row.ElementAt(6).Text;
                func.username = row.ElementAt(7).Text;
                func.password = row.ElementAt(8).Text;
                func.cardnumber = row.ElementAt(9).Text;
                func.enabled = row.ElementAt(10).Text;

                ListViewItem item = new ListViewItem();
                item.Text = func.code;                
                item.SubItems.Add(func.name);
                item.SubItems.Add(func.gender);
                item.SubItems.Add(func.department_code);
                item.SubItems.Add(func.category_code);
                item.SubItems.Add(func.enrollNumber);
                item.SubItems.Add(func.privilege);
                item.SubItems.Add(func.username);
                item.SubItems.Add(func.password);
                item.SubItems.Add(func.cardnumber);
                item.SubItems.Add(func.enabled);

                LViewFuncionarios.Items.Add(item);

                this.funcionarios.Add(func);
            }
        }

        private void ReadCategorias(ExcelWorksheet wCategs) {
            for (var rowNumber = 2; rowNumber <= wCategs.Dimension.End.Row; rowNumber++) {
                var row = wCategs.Cells[rowNumber, 1, rowNumber, wCategs.Dimension.End.Column];

                if (row.Count() < 3) {
                    Console.WriteLine("Empty Line, Break!");
                    break;
                }

                var categ = new Categoria();
                categ.Code = row.ElementAt(0).Text;
                categ.Nome = row.ElementAt(1).Text;
                categ.Funcoes = row.ElementAt(2).Text;


                ListViewItem item = new ListViewItem();                              
              
                item.Text = categ.Code;
                item.SubItems.Add(categ.Nome);
                item.SubItems.Add(categ.Funcoes);

                LViewCategorias.Items.Add(item);

                this.categorias.Add(categ);
            }
        }

        private void ReadDepartamentos(ExcelWorksheet wDepts) {
            for (var rowNumber = 2; rowNumber <= wDepts.Dimension.End.Row; rowNumber++) {
                var row = wDepts.Cells[rowNumber, 1, rowNumber, wDepts.Dimension.End.Column];

                if (row.Count() < 3) {
                    Console.WriteLine("Empty Line, Break!");
                    break;
                }
                                                
                var dept = new Departamento();
                dept.Code = row.ElementAt(0).Text;
                dept.Nome = row.ElementAt(1).Text;
                dept.Descricao = row.ElementAt(2).Text;

                ListViewItem item = new ListViewItem();

                item.Text = dept.Code;
                item.SubItems.Add(dept.Nome);
                item.SubItems.Add(dept.Descricao);
                
                LViewDepartamentos.Items.Add(item);
                
                this.departamentos.Add(dept);
            }
        }

        private void BtnSaveImportedData_Click(object sender, EventArgs e) {
            Console.WriteLine("departs: " + departamentos.Count);
            Console.WriteLine("categrs: " + categorias.Count);
            Console.WriteLine("funcios: " + funcionarios.Count);

            OnExecuteDialog background = new OnExecuteDialog("Importação de XLS....", "Analisando e inserindo dados no sistema...");
            bool result = false;

            int[] resultDpts = new int[departamentos.Count]; //0 - saved, 1 - already exists, 2 - error while saving
            int[] resultCtgs = new int[categorias.Count]; //0 - saved, 1 - already exists, 2 - error while saving
            int[] resultFunc = new int[funcionarios.Count]; //0 - saved, 1 - already exists, 2 - error while saving

            background.OnExecute += delegate() {
                result = ExecuteSaves(resultDpts, resultCtgs, resultFunc);
            };

            background.OnPostExecute += delegate() {
                UpdateViewsWithResults(resultDpts, resultCtgs, resultFunc);
                LoadSavedFuncionarioToFingReader();

                if (result == true) {
                    MessageBox.Show(this, "Os Dados foram importados com sucesso! Verifique a coluna de status nas tabelas.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    MessageBox.Show(this, "Não foi possivel gravar os dados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            background.StartExecute();                        
        }

        private void SaveDepartamentos(int[] result) {
            
            int i = 0;
            foreach (var dept in departamentos) {

                var depts = context.Departamento.Where(d => d.Code==dept.Code || d.Nome==dept.Nome).FirstOrDefault();

                if (depts != null) {
                    result[i] = 1;
                    i++;
                    continue;
                }

                dept.CreatedBy = SystemManager.GetCurrentUser(context);
                dept.CreationDate = DateTime.Now;
                empresa.Departamentos.Add(dept);

                i++;
            }

            context.SaveChanges();
                        
        }

        private void SaveCategorias(int[] result) {
            
            int i = 0;
            foreach (var categ in categorias) {

                var categs = context.Categoria.Where(d => d.Code == categ.Code || d.Nome == categ.Nome).FirstOrDefault();

                if (categs != null) {
                    result[i] = 1;
                    i++;
                    continue;
                }

                categ.CreatedBy = SystemManager.GetCurrentUser(context);
                categ.CreationDate = DateTime.Now;
                empresa.Categorias.Add(categ);

                i++;
            }

            context.SaveChanges();            
        }

        private void SaveFuncionarios(int[] result) {
            
            int? maxId = context.Funcionario.Max(f => (int?)f.Id);
            int lastId = 0;

            if (maxId != null) lastId = maxId.Value;

            int i = 0;
            foreach (var xlsfunc in funcionarios) {

                var repCodes = context.Funcionario.Where(d => d.Code == xlsfunc.code || d.Nome == xlsfunc.name).FirstOrDefault();
                var repFuncs = context.Funcionario.Where(
                              f => f.Nome == xlsfunc.name &&
                                   f.Sexo == xlsfunc.gender &&
                                   f.Departamento.Code == xlsfunc.department_code &&
                                   f.Categoria.Code == xlsfunc.category_code
                    ).FirstOrDefault();

                if (repCodes != null || repFuncs != null) {
                    result[i] = 1;
                    i++;
                    continue;
                }                               

                Funcionario func = new Funcionario();

                var departamento = context.Departamento.Where(d => d.Code == xlsfunc.department_code).FirstOrDefault();
                var categoria = context.Categoria.Where(d => d.Code == xlsfunc.category_code).FirstOrDefault();

                xlsfunc.code = func.CreateCode(empresa, ++lastId);

                func.Code = xlsfunc.code;
                func.Nome = xlsfunc.name;
                func.Sexo = xlsfunc.gender[0] + "";
                func.Departamento = departamento;
                func.Categoria = categoria;
                func.EnrollNumber = (xlsfunc.enrollNumber=="NA") ? 0 : Int32.Parse(xlsfunc.enrollNumber);
                func.Privilege = (xlsfunc.enrollNumber == "NA") ? 0 : Int32.Parse(xlsfunc.privilege);
                func.Username = (xlsfunc.username == "NA") ? "" : xlsfunc.username;
                func.Password = (xlsfunc.password == "NA") ? "" : xlsfunc.password;
                func.Cardnumber = (xlsfunc.cardnumber == "NA") ? "" : xlsfunc.cardnumber;
                func.Enabled = true;

                func.CreatedBy = SystemManager.GetCurrentUser(context);
                func.CreationDate = DateTime.Now;
                
                context.Funcionario.Add(func);

                i++;
            }

            context.SaveChanges();
        }

        private bool ExecuteSaves(int[] resultDpts, int[] resultCtgs, int[] resultFunc) {
            try {
                SaveDepartamentos(resultDpts);
                SaveCategorias(resultCtgs);
                SaveFuncionarios(resultFunc);
            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Error Saving");
                return false;
            }

            return true;
        }

        private void UpdateViewsWithResults(int[] resultDpts, int[] resultCtgs, int[] resultFunc) {
            
            int i = 0;
            int[] result = resultDpts;

            foreach (ListViewItem item in LViewDepartamentos.Items) {
                item.BackColor = result[i] == 0 ? Color.AliceBlue : result[i] == 1 ? Color.Yellow : Color.IndianRed;
                item.SubItems.Add(result[i] == 0 ? "Saved" : result[i] == 1 ? "Exists" : "Error");

                i++;
            }
            LViewDepartamentos.Refresh();

            i = 0;
            result = resultCtgs;
            foreach (ListViewItem item in LViewCategorias.Items) {
                item.BackColor = result[i] == 0 ? Color.AliceBlue : result[i] == 1 ? Color.Yellow : Color.IndianRed;
                item.SubItems.Add(result[i] == 0 ? "Saved" : result[i] == 1 ? "Exists" : "Error");

                i++;
            }
            LViewCategorias.Refresh();

            i = 0;
            result = resultFunc;
            foreach (ListViewItem item in LViewFuncionarios.Items) {
                item.BackColor = result[i] == 0 ? Color.AliceBlue : result[i] == 1 ? Color.Yellow : Color.IndianRed;
                item.SubItems.Add(result[i] == 0 ? "Saved" : result[i] == 1 ? "Exists" : "Error");

                i++;
            }

            LViewFuncionarios.Refresh();
        }

        private void BtnConnect_Click(object sender, EventArgs e) {

            if (CBoxDevices.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione o dispositivo por favor");
                return;
            }

            if (BtnConnect.Text == "Desconectar Dispositivo") {
                DisconnectDevice();
                return;
            }

            if (BtnConnect.Text == "Conectar Dispositivo") {
                ConnectDevice();
                return;
            }
        }

        private void ConnectDevice() {
            Device device = (Device)CBoxDevices.SelectedItem;

            DeviceConnector connector = DeviceConnector.GetDeviceConnector(device);

            connector.StartConnection();

            if (device.Connected) {
                BtnConnect.Text = "Desconectar Dispositivo";
                CBoxDevices.Enabled = false;                
                BtnDownloadFps.Enabled = !false;            
                LabelDeviceConnected.Text = "Conectado";

                GetAvaiableUsersID(device, out avaiables_users);

            } else {
                BtnConnect.Text = "Conectar Dispositivo";
                CBoxDevices.Enabled = true;                
                BtnDownloadFps.Enabled = false;            
                LabelDeviceConnected.Text = "Desconectado";
            }
        }

        private void DisconnectDevice() {
            Device device = (Device)CBoxDevices.SelectedItem;

            if (device.Connected) {
                device.Disconnect();
            }

            if (device.Connected) {
                BtnConnect.Text = "Desconectar Dispositivo";
                CBoxDevices.Enabled = false;                
                BtnDownloadFps.Enabled = !false;       
                LabelDeviceConnected.Text = "Conectado";
            } else {
                BtnConnect.Text = "Conectar Dispositivo";
                CBoxDevices.Enabled = true;
                BtnDownloadFps.Enabled = false;    
                LabelDeviceConnected.Text = "Desconectado";
            }
        }

        private void GetAvaiableUsersID(Device device, out SortedSet<int> avaiables) {

            DeviceIO deviceIO = new DeviceIO(device);

            List<int> users = new List<int>();
            avaiables = new SortedSet<int>();
            int maxUsers = 0;

            deviceIO.GetAvaiableUsersID(out avaiables, out maxUsers);

        }


        private void LoadSavedFuncionarioToFingReader() {
            foreach (var func in funcionarios){
                ListViewItem item = new ListViewItem();
                
                item.Text = func.code;
                item.SubItems.Add(func.name);
                item.SubItems.Add(func.gender);
                item.SubItems.Add(func.department_code);
                item.SubItems.Add(func.category_code);
                item.SubItems.Add(func.enrollNumber);
                item.SubItems.Add(func.privilege);
                item.SubItems.Add(func.username);
                item.SubItems.Add(func.password);
                item.SubItems.Add(func.cardnumber);
                //item.SubItems.Add(func.enabled);

                LViewFuncToGetFng.Items.Add(item);
            }

            LViewFuncToGetFng.Refresh();
        }

        private void BtnDownloadFps_Click(object sender, EventArgs e) {
            DownloadFingerprints();
        }

        private void DownloadFingerprints() {
            Device device = (Device)CBoxDevices.SelectedItem;

            if (!device.Connected) {
                MessageBox.Show(this, "Não sera possivel obter os registos de fingerprints. Conecte o dispositivo primeiro!", "Biometrico Desconectado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OnExecuteDialog background = new OnExecuteDialog("Importação de Fingerprints....", "Obtendo registos de fingerprints no biometrico...");
            bool result = false;

            int[] resultFunc = new int[funcionarios.Count]; //0 - saved, 1 - already exists, 2 - error while saving

            background.OnExecute += delegate() {
                result = SaveFingerprints(device, resultFunc);
            };

            background.OnPostExecute += delegate() {
                UpdateViewsWithResults(resultFunc);
                
                if (result == true) {
                    MessageBox.Show(this, "Os Dados foram importados com sucesso! Verifique a coluna de status nas tabelas.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    MessageBox.Show(this, "Não foi possivel gravar os dados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            background.StartExecute();                 
        }

        private bool SaveFingerprints(Device device, int[] result) {

            try {
                
               
                //get all fingerprints
                List<string> users = funcionarios.Select(f => f.code).ToList<string>();
                List<RawFingerprint> fingerprints = null;

                DeviceIO devIo = new DeviceIO(device);

                devIo.GetAllUserTmp(users, out fingerprints);
                int i = 0;
                foreach (var xlsfunc in funcionarios) {

                    if (xlsfunc.enrollNumber!=null && xlsfunc.enrollNumber.Length>0) {

                        Funcionario func = context.Funcionario.Where(f => f.Code==xlsfunc.code).FirstOrDefault();
                        int saves = 0;

                        for (int fi = 0; fi < 9; fi++) {

                            var rFingerPrint = fingerprints.Where(fg => fg.EnrollNumber == func.EnrollNumber && fg.FingerIndex == fi).FirstOrDefault();

                            if (rFingerPrint == null) continue;

                            bool contains = false;

                            foreach (UserFingerprint userFing in func.UserFingerprints) {
                                if (userFing.FingerIndex == rFingerPrint.FingerIndex) {
                                    userFing.TemplateData = rFingerPrint.TemplateData;
                                    contains = true;
                                    saves++;
                                    break;
                                }
                            }

                            if (!contains) {
                                var fingerPrint = new UserFingerprint();
                                fingerPrint.FingerIndex = rFingerPrint.FingerIndex;
                                fingerPrint.TemplateData = rFingerPrint.TemplateData;

                                func.UserFingerprints.Add(fingerPrint);
                                saves++;
                            }

                        }

                        result[i] = saves;
                                                
                    }

                    i++;
                }

                context.SaveChanges();

            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Error Saving Fps");
                return false;
            }

            return true;
        }

        private void UpdateViewsWithResults(int[] resultFuncFps) {
            int i = 0;
            
            foreach (ListViewItem item in LViewFuncToGetFng.Items) {
                item.BackColor = resultFuncFps[i] == 0 ? Color.White : resultFuncFps[i] > 0 ? Color.AliceBlue : Color.IndianRed;
                item.SubItems.Add(resultFuncFps[i] == 0 ? "" : resultFuncFps[i] > 0 ? resultFuncFps[i]+" Saved" : "Error");

                i++;
            }

            LViewFuncToGetFng.Refresh();
        }

        private void CBoxDevices_SelectedIndexChanged(object sender, EventArgs e) {
            if (CBoxDevices.SelectedIndex != -1) {
                OnSelectDevice();
            } else {
                BtnConnect.Enabled = false;                
                BtnDownloadFps.Enabled = false;
            }
        }

        private void OnSelectDevice() {
            Device device = (Device)CBoxDevices.SelectedItem;

            BtnConnect.Enabled = true;
            BtnDownloadFps.Enabled = true;

            TxtSerialNumber.Text = device.SerialNumber;
            TxtDeviceDoor.Text = device.Door.ToString();
        }
               
    }

    class XlsFuncionario {
        public string code;
        public string name;
        public string gender;
        public string department_code;
        public string category_code;
        public string enrollNumber;
        public string privilege;
        public string username;
        public string password;
        public string cardnumber;
        public string enabled;

    }
}
