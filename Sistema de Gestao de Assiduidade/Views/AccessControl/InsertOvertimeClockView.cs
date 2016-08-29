using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.Utilities;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.utilities.module.General;


namespace mz.betainteractive.sigeas.Views.AccessControl {
    public partial class InsertOvertimeClockView : Form {

        private SigeasDatabaseContext context;
        private UserClock userClock;
        private Funcionario funcionario;
        private int OPENED_MODE;
        private int EDIT_MODE = 0;
        private int INSERT_MODE = 1;

        public InsertOvertimeClockView(SigeasDatabaseContext context) {
            InitializeComponent();            
            this.context = context;
            LoadCombos();
        }

        private void btFechar_Click(object sender, EventArgs e) {
            this.Close();
        }
                
        public void Edit(UserClock userclock) {

            this.OPENED_MODE = EDIT_MODE;
            
            BtnUpdate.Text = "Atualizar";
            this.userClock = userclock;
            DateTime dateTime = userclock.DateAndTime;

            CBoxBeneficiario.Items.Clear();
            CBoxBeneficiario.Items.Add(userclock.Funcionario);
            CBoxBeneficiario.SelectedIndex = 0;            
         
            CBoxDevices.SelectedItem = userclock.Device;
            CBoxVerifyMode.SelectedItem = userClock.VerifyMode;
         
            dtpData.Value = dateTime.Date;
            dtpHora.Value = dateTime;
        }

        public void New(Funcionario funcionario) {
            this.OPENED_MODE = INSERT_MODE;

            BtnUpdate.Text = "Registar";

            this.funcionario = funcionario;

            CBoxBeneficiario.Items.Clear();
            CBoxBeneficiario.Items.Add(funcionario);
            CBoxBeneficiario.SelectedIndex = 0;
        }                
        
        private void LoadDevicesToComboBox() {
            //No futuro não sera assim
            var devices = context.Device.ToList();

            CBoxDevices.Items.Clear();

            foreach (Device dev in devices) {
                CBoxDevices.Items.Add(dev);
            }
        }

        private void LoadVerifyModesToComboBox() {
            var modes = context.VerifyMode.ToList();

            CBoxVerifyMode.Items.Clear();

            foreach (var vm in modes) {
                CBoxVerifyMode.Items.Add(vm);
            }
        }

        private void LoadCombos() {
            LoadDevicesToComboBox();
            LoadVerifyModesToComboBox();
        }               
                
        private void btUpdate_Click(object sender, EventArgs e) {
            if (this.OPENED_MODE == EDIT_MODE) {
                UpdateUserClock();
            } else {
                GravarUserClock();
            }
        }
        
        bool validar() {
            //validar dados
            if (CBoxDevices.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione o biométrico primeiro");
                CBoxDevices.Focus();
                return false;
            }

            return true;
        }

        private void GravarUserClock() {
            
            if (!validar()) {
                return;
            }

            DialogResult dr = MessageBox.Show(this, "Tem certeza que gravar o (Registo de Entrada/Saida)?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            UserClock userClock = new UserClock();

            Funcionario beneficiario = CBoxBeneficiario.SelectedItem as Funcionario;
            Device device = (Device) CBoxDevices.SelectedItem;
            string state = "";
            VerifyMode mode = CBoxVerifyMode.SelectedItem as VerifyMode;
            DateTime dt = dtpData.Value;
            DateTime tm = dtpHora.Value;
            DateTime date = new DateTime(dt.Year, dt.Month, dt.Day, tm.Hour, tm.Minute, tm.Second);

            userClock.Funcionario = funcionario;
            userClock.Device = device;
            userClock.VerifyMode = mode;
            userClock.DateAndTime = date;                        
            userClock.CorrectState = state;
            userClock.CreatedBy = SystemManager.GetCurrentUser(context);
            userClock.CreationDate = DateTime.Today;

            try {
                context.UserClock.Add(userClock);
                context.SaveChanges();

                MessageBox.Show(this, "O Registo de entrada/saida foi registado");
            }catch (Exception ex){
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar gravar o registo de entrada/saida");
                MessageBox.Show(this, "Ocorreu erro ao tentar gravar o registo de entrada/saida.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                                    
            this.Close();
            
        }

        private void UpdateUserClock() {
            
            if (!validar()) {
                return;
            }

            DialogResult dr = MessageBox.Show(this, "Tem certeza que atualizar o (Registo de Entrada/Saida)?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }
                        

            DateTime dt = dtpData.Value;
            DateTime tm = dtpHora.Value;
            DateTime date = new DateTime(dt.Year, dt.Month, dt.Day, tm.Hour, tm.Minute, tm.Second);                        
            Device device = (Device)CBoxDevices.SelectedItem;
            VerifyMode mode = CBoxVerifyMode.SelectedItem as VerifyMode;
            string state = "";
                                    
            userClock.Device = device;
            userClock.VerifyMode = mode;
            userClock.DateAndTime = date;
            userClock.CorrectState = state;
            userClock.UpdatedBy = SystemManager.GetCurrentUser(context);
            userClock.UpdatedDate = DateTime.Today;
            
            try {             
                context.SaveChanges();
                MessageBox.Show(this, "O Registo de entrada/saida foi actualizado");
            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar atualizar o registo de entrada/saida");
                MessageBox.Show(this, "Ocorreu erro ao tentar atualizar o registo de entrada/saida.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            this.Close();            
        }

        private void CBoxBeneficiario_SelectedIndexChanged(object sender, EventArgs e) {

        }

        /*
        private void CBoxDevices_SelectedIndexChanged(object sender, EventArgs e) {
            if (CBoxDevices.SelectedIndex != -1) {
                Device device = (Device)CBoxDevices.SelectedItem;
                TxtServicoCartao.Text = device.ServicoCartao.ToString();
            } else {
                TxtServicoCartao.Text = "";
            }
        }
        */
                
         
    }
}
