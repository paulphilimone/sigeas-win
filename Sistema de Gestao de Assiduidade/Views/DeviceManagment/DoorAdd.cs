using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.Utilities;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.Views.DeviceManagement {
    public partial class DoorAdd : Form {
        private SigeasDatabaseContext context;

        public DoorAdd(SigeasDatabaseContext context) {
            InitializeComponent();
            this.context = context;
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e) {
            AddDoor();
        }

        private void AddDoor() {
            if (!Validar()) {
                return;
            }

            string nome = TxtNome.Text;
                        
            DeviceType devType1 = context.DeviceType.FirstOrDefault(t => t.TypeNumber == DeviceType.TYPE_IN);
            DeviceType devType2 = context.DeviceType.FirstOrDefault(t => t.TypeNumber == DeviceType.TYPE_OUT);
            DeviceType devType3 = context.DeviceType.FirstOrDefault(t => t.TypeNumber == DeviceType.TYPE_IN_OUT);
            
            
            Device device1 = (Device)CBoxDevice1.SelectedItem;
            Device device2 = null;
            DoorType doorType = CBoxDoorType.SelectedItem as DoorType;

            Departamento departamento = CBoxDepartamento.SelectedItem as Departamento;

            if (rbEdit_TwoDevices.Checked) {
                device2 = (Device) CBoxDevice2.SelectedItem;
            }

            var doors = context.Door.Where(d => d.Name == nome).FirstOrDefault();

            if (doors != null) {
                MessageBox.Show(this, "Ja existe uma porta com a mesmo (Nome) da porta ser adicionado.", "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNome.Focus();
                return;
            }
            
            

            DialogResult dr = MessageBox.Show(this, "Tem certeza que deseja adicionar o autocarro(" + nome + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            Door door = new Door();
            door.Name = nome;
            //door.FirstDevice = device1;
            //door.SecondDevice = device2;
            door.Type = doorType;
            door.Departamento = departamento;

            if (departamento != null) {
                departamento.RegisteredDoor = door;
            }

            if (device1 != null) {
                door.Devices.Add(device1);
            }

            if (device2 != null) {
                door.Devices.Add(device2);
            }

            if (rbEdit_TwoDevices.Checked) {
                device1.DeviceType = devType1;
                device2.DeviceType = devType2;              
                door.NumberOfDevices = 2;
            } else {
                device1.DeviceType = devType3;                
                door.NumberOfDevices = 1;
            }
            
            door.CreatedBy = SystemManager.GetCurrentUser(context);
            door.CreationDate = DateTime.Now;

            try {
                context.Door.Add(door);
                context.SaveChanges();                

                MessageBox.Show(this, "A porta foi adicionada com sucesso");
                this.Close();
            }catch(Exception ex){
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar adicionar a porta na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar adicionar a porta na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

        }

        private void LoadDevices1() {
            var devices = context.Device.Where(d => d.Door == null).ToList();

            CBoxDevice1.Items.Clear();

            foreach (Device dev in devices) {
                CBoxDevice1.Items.Add(dev);                
            }
        }

        private void LoadDevices2() {
            var devices = context.Device.Where(d => d.Door == null).ToList();

            CBoxDevice2.Items.Clear();

            foreach (Device dev in devices) {                
                CBoxDevice2.Items.Add(dev);
            }
        }

        private void LoadDepartamentos() {
            Empresa empresa = SystemManager.GetCurrentEmpresa(context);


            var depts = context.Departamento.Where(d => d.Empresa.Id == empresa.Id && d.RegisteredDoor == null).ToList();

            CBoxDepartamento.Items.Clear();

            foreach (var dep in depts) {
                CBoxDepartamento.Items.Add(dep);
            }
        }

        private void LoadDoorTypes() {
            var types = context.DoorType.ToList();

            CBoxDoorType.Items.Clear();

            foreach (DoorType dType in types) {
                CBoxDoorType.Items.Add(dType);
            }

            //Default - Modulo 1
            CBoxDoorType.SelectedIndex = 0;
        }
               
        private bool Validar() {
            
            if (TxtNome.Text == "") {
                MessageBox.Show(this, "Introduza o nome, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNome.Focus();
                return false;
            }

            if (CBoxDoorType.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione o Tipo de Biométrico!, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CBoxDoorType.Focus();
                return false;
            }

            if (rbEdit_OneDevice.Checked == false && rbEdit_TwoDevices.Checked == false) {
                MessageBox.Show(this, "Selecione o tipo de porta, por favor!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rbEdit_OneDevice.Focus();
                return false;
            }

            if (rbEdit_OneDevice.Checked) {
                if (CBoxDevice1.SelectedIndex == -1) {
                    MessageBox.Show(this, "Selecione um dispositivo biométrico ou clique em (Adicionar) para adicionar um dispositivo!, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CBoxDevice1.Focus();
                    return false;
                }
            } else {
                if (CBoxDevice1.SelectedIndex == -1) {
                    MessageBox.Show(this, "Selecione o dispositivo biométrico de entrada ou clique em (Adicionar 1) para adicionar um dispositivo!, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CBoxDevice1.Focus();
                    return false;
                }

                if (CBoxDevice2.SelectedIndex == -1) {
                    MessageBox.Show(this, "Selecione o dispositivo biométrico de saida ou clique em (Adicionar 2) para adicionar um dispositivo!, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CBoxDevice2.Focus();
                    return false;
                }

                Device device1 = CBoxDevice1.SelectedItem as Device;
                Device device2 = CBoxDevice2.SelectedItem as Device;

                if (device1.Equals(device2)) {
                    MessageBox.Show(this, "O dispositivo biométrico de saida não pode ser o mesmo que o de entrada. Selecione outro dispositivo!, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CBoxDevice2.Focus();
                    return false;
                }
            }

            

            return true;
        }

        private void BtnAddDevice_Click(object sender, EventArgs e) {
            OpenAddDevice1();
        }

        private void OpenAddDevice1() {
            DeviceAdd deviceAdd = new DeviceAdd();
            deviceAdd.ShowDialog(this);
            LoadDevices1();
        }

        private void OpenAddDevice2() {
            DeviceAdd deviceAdd = new DeviceAdd();
            deviceAdd.ShowDialog(this);
            LoadDevices2();
        }

        private void DoorAdd_Load(object sender, EventArgs e) {
            //context = new SigeasDatabaseContext();
            CleanAll();
            LoadDevices1();
            LoadDevices2();
            LoadDoorTypes();
            LoadDepartamentos();
        }
                
        private void CleanAll() {
            TxtNome.Text = "";
            rbEdit_OneDevice.Checked = true;
            CBoxDevice1.Items.Clear();
            CBoxDevice2.Items.Clear();
            OnSelectedDoorType();
        }               

        private void DooAdd_FormClosed(object sender, FormClosedEventArgs e) {
            //context.Dispose();
            //context = null;            
        }

        private void rbEdit_OneDevice_CheckedChanged(object sender, EventArgs e) {
            OnSelectedDoorType();
        }

        private void OnSelectedDoorType() {
            if (rbEdit_OneDevice.Checked) {
                //picEditBio1.BackColor = Color.LightSkyBlue;
                //picEditBio2.BackColor = Color.Transparent;

                LabelDevice1.Enabled = true;
                LabelDevice1.Text = "Biométrico único (Entrada/Saida)";
                CBoxDevice1.Enabled = true;
                BtnAddDevice1.Enabled = true;
                BtnAddDevice1.Text = "Adicionar";

                LabelDevice2.Enabled = false;
                LabelDevice2.Text = "Biométrico 2 (Saida)";
                CBoxDevice2.Enabled = false;
                BtnAddDevice2.Enabled = false;
                BtnAddDevice2.Text = "Adicionar 2";

            } else {

                //picEditBio1.BackColor = Color.Transparent;
                //picEditBio2.BackColor = Color.LightSkyBlue;

                LabelDevice1.Enabled = true;
                LabelDevice1.Text = "Biométrico 1 (Entrada)";
                CBoxDevice1.Enabled = true;
                BtnAddDevice1.Enabled = true;
                BtnAddDevice1.Text = "Adicionar 1";

                LabelDevice2.Enabled = true;
                LabelDevice2.Text = "Biométrico 2 (Saida)";
                CBoxDevice2.Enabled = true;
                BtnAddDevice2.Enabled = true;
                BtnAddDevice2.Text = "Adicionar 2";
            }
        }

        private void rbEdit_TwoDevices_CheckedChanged(object sender, EventArgs e) {
            OnSelectedDoorType();
        }

        private void BtnAddDevice2_Click(object sender, EventArgs e) {
            OpenAddDevice2();
        }
    }
}
