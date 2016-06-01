using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.Utilities;
using mz.betainteractive.sigeas.DeviceSystem;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.DeviceSystem.Views;
using mz.betainteractive.sigeas.model.ca;
using System.IO;
using System.Drawing.Imaging;

namespace mz.betainteractive.sigeas.Views.Funcionarios {

    public partial class FuncionarioEditView : Form, mz.betainteractive.sigeas.Utilities.Components.AuthorizableComponent {

        private SigeasDatabaseContext context;        
        private Funcionario currentFuncionario;
        private Empresa empresa;
        private List<UserSetFingerprint.Fingerprint> fingersToRegist = new List<UserSetFingerprint.Fingerprint>();

        /*Form Authorization*/
        public int FormCode { get; set; }
        public bool AllowView { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowAdd { get; set; }


        public FuncionarioEditView(SigeasDatabaseContext contextDb, Empresa empresa, Funcionario beneficiario) {
            InitializeComponent();

            this.context = contextDb;
            this.empresa = empresa;
            Initialize();

            currentFuncionario = beneficiario;            
            InitializeDefault();            
        }

        private void InitializeDefault() {
            CboxPrevilege.SelectedIndex = 0;
            
            TxtNome.Text = currentFuncionario.Nome;
            TxtApelido.Text = currentFuncionario.Apelido;
            
            TxtBairro.Text ="";
            TxtAvenidaRua.Text = "";
            TxtNumeroCasa.Text = "";

            if (currentFuncionario.Sexo != null){
                CBoxSexo.SelectedItem = currentFuncionario.Sexo;
            }
            if (currentFuncionario.EstadoCivil != null) {
                CBoxEstadoCivil.SelectedItem = currentFuncionario.EstadoCivil;
            }
            if (currentFuncionario.DataDeNascimento != null) {
                DtpDataNasc.Value = currentFuncionario.DataDeNascimento.Value;
            }
            if (currentFuncionario.DocumentoIdentificacao != null) {
                CBoxTipoDocumento.SelectedItem = currentFuncionario.DocumentoIdentificacao;
            }
            if (currentFuncionario.NumeroDI != null) {
                TxtNumeroID.Text = currentFuncionario.NumeroDI;
            }            
            if (currentFuncionario.Departamento != null){
                CBoxDepartamento.SelectedItem = currentFuncionario.Departamento;
            }
            if (currentFuncionario.Categoria != null){
                CBoxCategoria.SelectedItem = currentFuncionario.Categoria;
            }
            
            if (currentFuncionario.Photo != null) {
                if (currentFuncionario.Photo.Length > 0) {
                    picBoxFoto.BackgroundImage = GetPictureFromArray(currentFuncionario.Photo);
                }
            }
            
            if (currentFuncionario.Nacionalidade != null){
                CBoxNacionalidade.SelectedItem = currentFuncionario.Nacionalidade;
            }
            if (currentFuncionario.Provincia != null){
                CBoxProvincia.SelectedItem = currentFuncionario.Provincia;
            }
            if (currentFuncionario.Distrito != null){
                CBoxDistrito.SelectedItem = currentFuncionario.Distrito;
            }
            if (currentFuncionario.PostoAdministrativo != null){
                CBoxPostoAdministrativo.SelectedItem = currentFuncionario.PostoAdministrativo;
            }
            if (currentFuncionario.Localidade != null){
                CBoxLocalidade.SelectedItem = currentFuncionario.Localidade;
            }
            if (currentFuncionario.Bairro != null) {
                TxtBairro.Text = currentFuncionario.Bairro;
            }
            if (currentFuncionario.AvenidaRua != null) {
                TxtAvenidaRua.Text = currentFuncionario.AvenidaRua;
            }
            if (currentFuncionario.NumeroCasa != null) {
                TxtNumeroCasa.Text = currentFuncionario.NumeroCasa.ToString();
            }

            if (currentFuncionario.Telefone != null) {
                TxtTelefone.Text = currentFuncionario.Telefone;
            }
            if (currentFuncionario.Email != null) {
                TxtEmail.Text = currentFuncionario.Email;
            }
            
                        
            if (currentFuncionario.Enabled != null) {
                ChkEnabled.Checked = currentFuncionario.Enabled.Value;
            }
            if (currentFuncionario.UserName != null) {
                TxtUserName.Text = currentFuncionario.UserName;
            }
            if (currentFuncionario.Password != null) {
                TxtPassword.Text = currentFuncionario.Password;
            }
            if (currentFuncionario.Privilege != null) {
                CboxPrevilege.SelectedIndex = currentFuncionario.Privilege.Value;
            }
            if (currentFuncionario.CardNumber != null) {
                TxtCardNumber.Text = currentFuncionario.CardNumber;
            }
                                    
        }

        private Image GetPictureFromArray(byte[] p) {
            try {
                MemoryStream ms = new MemoryStream(p);
                Image img = Image.FromStream(ms);
                return img;
            } catch (Exception ex) {
                MessageBox.Show("Não foi possivel ler a foto apartir da base de dados");
                return null;
            }
        }
                
        public void Initialize() {            
            LoadBasicData();            
            LoadDevicesToComboBox();
        }

        private void LoadDevicesToComboBox() {
            //No futuro não sera assim
            var devices = context.Device.Where(t => t.Door == null).ToList();

            CBoxDevices.Items.Clear();

            foreach (Device dev in devices) {
                CBoxDevices.Items.Add(dev);
            }
        }               

        private void LoadBasicData() {
            LoadSexoToComboBox();
            LoadEstadoCivilToComboBox();
            LoadDocumentoIdentificacaoToComboBox();

            DBSearch.FillCountry(context, CBoxNacionalidade);

            CBoxProvincia.Items.Clear();
            CBoxDistrito.Items.Clear();
            CBoxPostoAdministrativo.Items.Clear();
            CBoxLocalidade.Items.Clear();
            DBSearch.FillProvincia(context, CBoxProvincia);

            LoadDepartamentosToComboBox();
            LoadCategoriasToComboBox();

        }

        private void LoadCategoriasToComboBox() {
            var categorias = empresa.Categorias;

            CBoxCategoria.Items.Clear();

            foreach (Categoria categ in categorias) {
                CBoxCategoria.Items.Add(categ);
            }
        }

        private void LoadDepartamentosToComboBox() {
            var departamentos = empresa.Departamentos;

            CBoxDepartamento.Items.Clear();

            foreach (Departamento depart in departamentos) {
                CBoxDepartamento.Items.Add(depart);
            }
        }

        private void LoadSexoToComboBox() {
            DBSearch.FillSexo(null, CBoxSexo);
        }

        private void LoadEstadoCivilToComboBox() {
            DBSearch.FillEstadoCivil(null, CBoxEstadoCivil);
        }

        private void LoadDocumentoIdentificacaoToComboBox() {
            DBSearch.FillDocumentoID(null, CBoxTipoDocumento);
        }

        private void FuncionarioAddView_FormClosing(object sender, FormClosingEventArgs e) {
            //context.Dispose();
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void BtConnectDevice_Click(object sender, EventArgs e) {
            if (CBoxDevices.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione o dispositivo por favor");
                return;
            }

            if (BtConnectDevice.Text == "Desconectar Dispositivo") {
                DisconnectDevice();
                return;
            }

            if (BtConnectDevice.Text == "Conectar Dispositivo") {
                ConnectDevice();
                return;
            }
        }

        private void ConnectDevice() {
            Device device = (Device)CBoxDevices.SelectedItem;
            DeviceConnector connector = DeviceConnector.GetDeviceConnector(device);

            connector.StartConnection();

            if (device.Connected) {
                BtConnectDevice.Text = "Desconectar Dispositivo";
                BtnRegCardNumber.Enabled = true;
                BtnRegFingerPrint.Enabled = true;
                LabelDeviceConnected.Text = "Conectado";
                DetectUserIds();
            } else {
                BtConnectDevice.Text = "Conectar Dispositivo";
                BtnRegCardNumber.Enabled = false;
                BtnRegFingerPrint.Enabled = false;
                LabelDeviceConnected.Text = "Desconectado";
            }
        }

        private void DisconnectDevice() {
            Device device = (Device) CBoxDevices.SelectedItem;

            if (device.Connected) {
                device.Disconnect();
            }

            if (device.Connected) {
                BtConnectDevice.Text = "Desconectar Dispositivo";
                BtnRegisterUser.Enabled = false;
                BtnRegCardNumber.Enabled = true;
                BtnRegFingerPrint.Enabled = true;
                LabelDeviceConnected.Text = "Conectado";
            } else {
                BtConnectDevice.Text = "Conectar Dispositivo";
                BtnRegisterUser.Enabled = false;
                BtnRegCardNumber.Enabled = false;
                BtnRegFingerPrint.Enabled = false;
                LabelDeviceConnected.Text = "Desconectado";
            }
        }

        private void BtnRegCardNumber_Click(object sender, EventArgs e) {
            Device device = (Device) CBoxDevices.SelectedItem;
            
            UserSetCardNumber cardView = new UserSetCardNumber();
            cardView.StartForm(device);
            String cardNumber = cardView.GetCardNumber();

            if (cardNumber != null) {
                TxtCardNumber.Text = cardNumber;
            }
        }        

        private void BtnRegFingerPrint_Click(object sender, EventArgs e) {
            GravarFingerPrint();
        }

        private void GravarFingerPrint() {
            //Detectar Free UserId                              - Done
            //Obter o Free UserId                               - Done
            //Gravar um usuario nesse Id                        - Done
            //Gravar Fingerprints nesse Usuario                 - Done
            //Obter as Fingerprints, e gravar na base de dados  - Done
            //Apagar os dados registrados                       - Done

            if (TxtUserId.Text.Length == 0) {
                MessageBox.Show(this, "O beneficiario não possui codigo temporario para registo, Conecte o dispositivo para obter o código primeiro!");
                //BtnRegisterUser.Focus();
                BtConnectDevice.Focus();
                return;
            }

            int userId = -1;

            try {
                userId = Convert.ToInt32(TxtUserId.Text);
            } catch (Exception ex) {
                MessageBox.Show(this, "O codigo do funcionario no biometrico é invalido, Conecte o dispositivo para obter o código novamente!");
                TxtUserId.Text = "";
                //BtnRegisterUser.Focus();
                BtConnectDevice.Focus();
                return;
            }

            Device device = (Device) CBoxDevices.SelectedItem;

            UserSetFingerprint frmSetFinger = new UserSetFingerprint();
            frmSetFinger.AfterEnrollDelete = true;
            frmSetFinger.UserIdToEnroll = userId;
            frmSetFinger.StartForm(device);

            List<UserSetFingerprint.Fingerprint> fingers = null;
            frmSetFinger.GetCurrentFingerprints(out fingers);

            fingersToRegist.Clear();
            fingersToRegist.AddRange(fingers);

            //Console.WriteLine("UserId To Delete: "+frmSetFinger.GetCurrentFingerprintResult().EnrolledUserId);
            
        }
        
        private void DetectUserIds() {
            Device device = (Device) CBoxDevices.SelectedItem;
            DeviceIO deviceIO = new DeviceIO(device);
                        
            int maxUsers = 0;
            
            SortedSet<int> users = new SortedSet<int>();

            deviceIO.GetAvaiableUsersID(out users, out maxUsers);

            int avaiable = -1;

            for (int i = 1; i <= maxUsers; i++) {
                if (!users.Contains(i)) {
                    avaiable = i;
                    break;
                }
            }
                        
            if (avaiable == -1) {
                MessageBox.Show(this, "O biométrico atingiu número máximo de registos de beneficiarios, não será possivel registar mais funcionários");
                TxtUserId.Text = "";
                return;
            } else {                
                TxtUserId.Text = avaiable.ToString();
            }

        }

        private byte[] GetPictureFromBox() {
            //default png
            if (picBoxFoto.BackgroundImage == null) {
                return null;
            }

            try {
                Image img = picBoxFoto.BackgroundImage;
                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Jpeg);

                return ms.ToArray();

            } catch (Exception ex) {
                return null;
            }

        }

        private void UpdateFuncionario() {
            
            if (!Validar()) {
                return;
            }
            
            //Verificar se o CardNumber é o mesmo
            var userTst1 = context.User.FirstOrDefault(u => u.UserName == TxtUserName.Text && u.Id != currentFuncionario.Id);


            var userTst2 = context.User.FirstOrDefault(u => u.CardNumber == TxtCardNumber.Text && u.Id != currentFuncionario.Id && u.CardNumber != "");

            if (userTst1 != null) {
                MessageBox.Show(this, "Já existe um (Funcionario) com o mesmo (Nome de usuário) do (Funcionario) a ser atualizado. Altere o nome do usuário!", "Conflito: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtUserName.Focus();
                return;
            }

            if (userTst2 != null) {
                MessageBox.Show(this, "Já existe um (Funcionario) com o mesmo (Número de cartão) do (Funcionario) a ser atualizado. Registe outro cartão!", "Conflito: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnRegCardNumber.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show(this, "Tem certeza que deseja atualizar os dados do (Funcionario:  \"" + TxtNome.Text + "\")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            string nome = TxtNome.Text;
            //string apelido = TxtApelido.Text;
            string sexo = (CBoxSexo.SelectedItem as string)[0]+"";
            string estadoCivil = CBoxEstadoCivil.SelectedItem as string;
            DateTime dataNasc = DtpDataNasc.Value;

            string docIdentificao = CBoxTipoDocumento.SelectedItem as string;
            string numeroDi = TxtNumeroID.Text;

            string telefone = TxtTelefone.Text;
            string email = TxtEmail.Text;

            Departamento departamento = (Departamento)CBoxDepartamento.SelectedItem;
            Categoria categoria = (Categoria)CBoxCategoria.SelectedItem;

            Pais nacionalidade = CBoxNacionalidade.SelectedItem as Pais;
            Provincia provincia = CBoxProvincia.SelectedItem as Provincia;
            Distrito distrito = CBoxDistrito.SelectedItem as Distrito;
            PostoAdministrativo pAdministrativo = CBoxPostoAdministrativo.SelectedItem as PostoAdministrativo;
            Localidade localidade = CBoxLocalidade.SelectedItem as Localidade;

            String bairro = TxtBairro.Text;
            String avRua = TxtAvenidaRua.Text;
            int numero = Convert.ToInt32(TxtNumeroCasa.Text);

            bool enabled = ChkEnabled.Checked;
            string username = TxtUserName.Text;
            string password = TxtPassword.Text;
            int previlege = CboxPrevilege.SelectedIndex;
            string cardNumber = TxtCardNumber.Text;

            ApplicationUser updatedBy = SystemManager.GetCurrentUser(context);

            Funcionario funcionario = currentFuncionario;
            
            funcionario.CompleteRegistered = true;
            funcionario.Nome = nome;
            //funcionario.Apelido = apelido;
            funcionario.Sexo = sexo;
            funcionario.EstadoCivil = estadoCivil;
            funcionario.DataDeNascimento = dataNasc;

            funcionario.DocumentoIdentificacao = docIdentificao;
            funcionario.NumeroDI = numeroDi;

            funcionario.Departamento = departamento;
            funcionario.Categoria = categoria;

            funcionario.Nacionalidade = nacionalidade;
            funcionario.Provincia = provincia;
            funcionario.Distrito = distrito;
            funcionario.PostoAdministrativo = pAdministrativo;
            funcionario.Localidade = localidade;
            funcionario.Telefone = telefone;
            funcionario.Email = email;

            funcionario.UpdatedBy = updatedBy;
            funcionario.UpdatedDate = DateTime.Now;
                        
            funcionario.Enabled = enabled;
            funcionario.UserName = username;
            funcionario.Password = password;
            funcionario.Privilege = previlege;
            funcionario.CardNumber = cardNumber;

            byte[] photo = GetPictureFromBox();
            funcionario.Photo = photo;

            //For Now We Use This
            foreach (UserSetFingerprint.Fingerprint usf in fingersToRegist){
                bool contains = false;
                //Update Fingerprint
                foreach (UserFingerprint userFing in funcionario.UserFingerprints){                    
                    if (userFing.FingerIndex == usf.FingerIndex) {
                        userFing.TemplateData = usf.TemplateData;
                        contains = true;
                        break;
                    }                                        
                }

                if (!contains) {
                    UserFingerprint fingerPrint = new UserFingerprint();
                    fingerPrint.FingerIndex = usf.FingerIndex;
                    fingerPrint.TemplateData = usf.TemplateData;

                    funcionario.UserFingerprints.Add(fingerPrint);
                }
                
            }            
            

            try {
                context.SaveChanges();
                MessageBox.Show(this, "O Funcionario foi atualizado com sucesso!");
                this.Close();
                
            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar atualizar o Funcionario na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar atualizar o Funcionario na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar() {
            //Dados Basicos
            if (TxtNome.Text == "") {
                MessageBox.Show(this, "Introduza o nome, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabFuncionario.SelectedIndex = 0;
                TxtNome.Focus();
                return false;
            }
            /*
            if (TxtApelido.Text == "") {
                MessageBox.Show(this, "Introduza o apelido", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabFuncionario.SelectedIndex = 0;
                TxtApelido.Focus();
                return false;
            }*/
            if (CBoxSexo.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione o sexo, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabFuncionario.SelectedIndex = 0;
                CBoxSexo.Focus();
                return false;
            }
            if (CBoxEstadoCivil.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione o estado civil, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabFuncionario.SelectedIndex = 0;
                CBoxEstadoCivil.Focus();
                return false;
            }
            if (CBoxTipoDocumento.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione o documento de identificação, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabFuncionario.SelectedIndex = 0;
                CBoxTipoDocumento.Focus();
                return false;
            }
            if (TxtNumeroID.Text == "") {
                MessageBox.Show(this, "Introduza o número do(a) " + CBoxTipoDocumento.SelectedText, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabFuncionario.SelectedIndex = 0;
                TxtNumeroID.Focus();
                return false;
            }
            if (CBoxDepartamento.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione o departamento", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabFuncionario.SelectedIndex = 0;
                CBoxDepartamento.Focus();
                return false;
            }
            if (CBoxCategoria.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione a categoria", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabFuncionario.SelectedIndex = 0;
                CBoxCategoria.Focus();
                return false;
            }
            //Contacto
            //introduzir pelo menos 1 contacto

            if (TxtEmail.Text=="" && TxtTelefone.Text == "") {
                MessageBox.Show(this, "Introduza o pelo menos um contacto (Email / Telefone)", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabFuncionario.SelectedIndex = 1;
                TxtEmail.Focus();
                return false;
            }

            if (TxtEmail.Text != "" && StringUtilities.ValidateEmail(TxtEmail.Text) == false) {
                MessageBox.Show(this, "Introduza correctamente o email ex: (exemplo@companhia.com)!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabFuncionario.SelectedIndex = 1;
                TxtEmail.Focus();
                return false;
            }
            
            if (StringUtilities.ValidateInteger(TxtNumeroCasa.Text) == false) {
                MessageBox.Show(this, "Introduza correctamente o numero da casa: (Introduza um numero inteiro)!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabFuncionario.SelectedIndex = 1;
                TxtNumeroCasa.Focus();
                return false;
            }
                        
            //Biometrico
            if (TxtUserName.Text == "") {
                MessageBox.Show(this, "Introduza o nickname do beneficiario", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabFuncionario.SelectedIndex = 2;
                TxtUserName.Focus();
                return false;
            }
            if (TxtPassword.Text == "") {
                MessageBox.Show(this, "Introduza a password do beneficiario", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabFuncionario.SelectedIndex = 2;
                TxtPassword.Focus();
                return false;
            }
            if (CboxPrevilege.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione o previlégio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabFuncionario.SelectedIndex = 2;
                CboxPrevilege.Focus();
                return false;
            }
            /*
            if (TxtCardNumber.Text == "") {
                MessageBox.Show(this, "Registe o cartão do usuário primeiro!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabFuncionario.SelectedIndex = 2;
                BtnRegCardNumber.Focus();
                return false;
            }*/

            return true;
        }
                
        private void TxtCardNumber_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (System.Diagnostics.Debugger.IsAttached) {
                TxtCardNumber.ReadOnly = !TxtCardNumber.ReadOnly;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e) {
            UpdateFuncionario();
        }

        private void CBoxProvincia_SelectedIndexChanged(object sender, EventArgs e) {
            DBSearch.OnSelectedProvincia(CBoxProvincia, CBoxDistrito, CBoxPostoAdministrativo, CBoxLocalidade);
        }

        private void CBoxDistrito_SelectedIndexChanged(object sender, EventArgs e) {
            DBSearch.OnSelectedDistrito(CBoxDistrito, CBoxPostoAdministrativo, CBoxLocalidade);
        }

        private void CBoxPostoAdministrativo_SelectedIndexChanged(object sender, EventArgs e) {
            DBSearch.OnSelectedPostoAdministrativo(CBoxPostoAdministrativo, CBoxLocalidade);
        }

        private void BtnBrowseFoto_Click(object sender, EventArgs e) {
            GetPictureFromFile();
        }

        private void GetPictureFromFile() {
            DialogResult res = openPictureDialog.ShowDialog();

            if (res == DialogResult.OK) {

                try {
                    Image img = Image.FromFile(openPictureDialog.FileName);

                    picBoxFoto.BackgroundImage = img;
                    picBoxFoto.Refresh();
                } catch (Exception ex) {
                    MessageBox.Show("Não foi possivel ler a foto");
                }
            }

        }

        private void BtnRemoverFoto_Click(object sender, EventArgs e) {
            RemoverFoto();
        }

        private void RemoverFoto() {
            picBoxFoto.BackgroundImage = null;
        }
            


                        
    }
}
