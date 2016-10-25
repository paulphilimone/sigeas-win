using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.Utilities;
using System.Text.RegularExpressions;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.DeviceSystem;
using mz.betainteractive.utilities.module.BackgroundFeatures;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.utilities.module.Components;
using mz.betainteractive.sigeas.Utilities;
using mz.betainteractive.utilities.module.General;
using mz.betainteractive.utilities.module.Collections;

namespace mz.betainteractive.sigeas.Views.DeviceManagement {
    public partial class DeviceManager : Form, AuthorizableComponent {
        private SigeasDatabaseContext context;
        private Door SelectedDoor;        
        private Device SelectedUnlocatedDevice;

        private DeviceType DEVICE_TYPE_IN;
        private DeviceType DEVICE_TYPE_OUT;
        private DeviceType DEVICE_TYPE_IN_OUT;

        //private Local SelectedLocal;
        //private Device SelectedLocalDevice;
        private TreeNode RootNodeDoors;
        //private TreeNode RootNodeLocals;
        private TreeNode RootNodeUnlocattedDevices;
        System.Drawing.Font fontNodeBold;
        System.Drawing.Font fontNodeNormal;

        /*Form Authorization*/
        public int FormCode { get; set; }
        public bool AllowView { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowAdd { get; set; }


        public DeviceManager() {
            InitializeComponent();


            fontNodeNormal = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fontNodeBold = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold | FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            RootNodeDoors = new TreeNode("Portas");
            RootNodeDoors.NodeFont = fontNodeBold;
            RootNodeDoors.SelectedImageIndex = 6;
            RootNodeDoors.ImageIndex = 6;

            /*
            RootNodeLocals = new TreeNode("Locais");
            RootNodeLocals.NodeFont = fontNodeBold;
            RootNodeLocals.SelectedImageIndex = 5;
            RootNodeLocals.ImageIndex = 5;
            */

            RootNodeUnlocattedDevices = new TreeNode("Dispositivos não alocados");
            RootNodeUnlocattedDevices.NodeFont = fontNodeBold;
            RootNodeUnlocattedDevices.SelectedImageIndex = 3;
            RootNodeUnlocattedDevices.ImageIndex = 3;

            TViewDevicesTree.Nodes.Clear();
            TViewDevicesTree.Nodes.Add(RootNodeDoors);
            //TViewDevicesTree.Nodes.Add(RootNodeLocals);
            TViewDevicesTree.Nodes.Add(RootNodeUnlocattedDevices);

        }

        private void DisposeContext() {
            if (context != null) {
                context.Dispose();
                context = null;
                SelectedDoor = null;                
                //SelectedLocal = null;
                //SelectedLocalDevice = null;
                SelectedUnlocatedDevice = null;
                RemoveAll();
            }
        }

        private void LoadContext() {
            if (context == null) {
                context = new SigeasDatabaseContext();
            }

            SelectedDoor = null;            
            //SelectedLocal = null;
            //SelectedLocalDevice = null;
            SelectedUnlocatedDevice = null;
        }

        private void RemoveAll() {
            RootNodeDoors.Nodes.Clear();
            //RootNodeLocals.Nodes.Clear();
            RootNodeUnlocattedDevices.Nodes.Clear();
            SelectedDoor = null;
            //SelectedLocal = null;
            SelectedUnlocatedDevice = null;
        }

        private void DeviceManager_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
            DisposeContext();
        }

        private void DeviceManager_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible) {
                Console.WriteLine("Running");
                LoadContext();
                Initialize();
            }
        }

        private void Initialize() {
            CleanAll();
            LoadDevicesToTree();
            LoadDeviceTypesToComboBox();
            //LoadDoorTypes();

            this.DEVICE_TYPE_IN = context.DeviceType.FirstOrDefault(t => t.TypeNumber == DeviceType.TYPE_IN);
            this.DEVICE_TYPE_OUT = context.DeviceType.FirstOrDefault(t => t.TypeNumber == DeviceType.TYPE_OUT);
            this.DEVICE_TYPE_IN_OUT = context.DeviceType.FirstOrDefault(t => t.TypeNumber == DeviceType.TYPE_IN_OUT);
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

        private void LoadDeviceTypesToComboBox() {
            CBoxDeviceType.Items.Clear();
            CBoxDoorDeviceType1.Items.Clear();
            CBoxDoorDeviceType2.Items.Clear();

            var deviceTypes = context.DeviceType.ToList();

            foreach (var type in deviceTypes) {
                CBoxDeviceType.Items.Add(type);
                CBoxDoorDeviceType1.Items.Add(type);
                CBoxDoorDeviceType2.Items.Add(type);
            }
        }

        private void LoadDevicesToTree() {

            SelectedDoor = null;
            //SelectedDoorDevice1 = null;
            //SelectedDoorDevice2 = null;
            SelectedUnlocatedDevice = null;
            CleanAll();

            

            foreach (object odev in CBoxConnectedDevices.Items.OfType<Device>().ToList()) {
                Device dev = odev as Device;
                dev.Disconnect();
            }

            CBoxConnectedDevices.Items.Clear();

            RootNodeDoors.Nodes.Clear();
            //RootNodeLocals.Nodes.Clear();
            RootNodeUnlocattedDevices.Nodes.Clear();

            try {
                var doors = context.Door.ToList();
                var devices = context.Device.Where(d => d.Door == null);
                //var locals = context.Locais.ToList();

                foreach (Door door in doors) {

                    TreeNodeItem<Door> node = new TreeNodeItem<Door>(door, 7, 7);

                    TreeNodeItem<Device> nodeDev1 = null;
                    TreeNodeItem<Device> nodeDev2 = null;

                    Device firstDevice = null;
                    Device secondDevice = null;
                    
                    //Load device1 e device2
                    if (door.Devices.Count == 2) {
                        firstDevice = door.Devices[0];
                        secondDevice = door.Devices[1];
                    } else {
                        firstDevice = door.Devices[0];
                    }

                    node.NodeFont = fontNodeNormal;

                    if (firstDevice != null) {
                        nodeDev1 = new TreeNodeItem<Device>(firstDevice, 1, 1);
                        nodeDev1.NodeFont = fontNodeNormal;
                        node.Nodes.Add(nodeDev1);

                        firstDevice.OnConnectionStateChanged += new DeviceConnectionEventHandler(
                            (object obj, DeviceConnectionEventArgs e) => {
                                if (e.Device.Connected) {
                                    AddConnectedDevice((Device)e.Device);
                                    nodeDev1.ImageIndex = 2;
                                    nodeDev1.SelectedImageIndex = 2;
                                } else {
                                    RemoveConnectedDevice((Device)e.Device);
                                    nodeDev1.ImageIndex = 1;
                                    nodeDev1.SelectedImageIndex = 1;
                                }
                            }
                        );
                    }


                    if (secondDevice != null) {
                        nodeDev2 = new TreeNodeItem<Device>(secondDevice, 1, 1);
                        nodeDev2.NodeFont = fontNodeNormal;
                        node.Nodes.Add(nodeDev2);

                        secondDevice.OnConnectionStateChanged += new DeviceConnectionEventHandler(
                            (object obj, DeviceConnectionEventArgs e) => {
                                if (e.Device.Connected) {
                                    AddConnectedDevice((Device)e.Device);
                                    nodeDev2.ImageIndex = 2;
                                    nodeDev2.SelectedImageIndex = 2;
                                } else {
                                    RemoveConnectedDevice((Device)e.Device);
                                    nodeDev2.ImageIndex = 1;
                                    nodeDev2.SelectedImageIndex = 1;
                                }
                            }
                        );
                    }

                    RootNodeDoors.Nodes.Add(node);
                    
                }

                /*
                foreach (Local local in locals) {
                    TreeNodeItem<Local> node = new TreeNodeItem<Local>(local, 5, 5);
                    TreeNodeItem<Device> nodeDev = new TreeNodeItem<Device>(local.RegisteredDevice, 1, 1);

                    node.NodeFont = fontNodeNormal;
                    nodeDev.NodeFont = fontNodeNormal;

                    node.Nodes.Add(nodeDev);

                    RootNodeLocals.Nodes.Add(node);

                    local.RegisteredDevice.OnConnectionStateChanged += new DeviceConnectionEventHandler(
                         (object obj, DeviceConnectionEventArgs e) => {
                             if (e.Device.Connected) {
                                 AddConnectedDevice((Device)e.Device);
                                 nodeDev.ImageIndex = 2;
                                 nodeDev.SelectedImageIndex = 2;
                             } else {
                                 RemoveConnectedDevice((Device)e.Device);
                                 nodeDev.ImageIndex = 1;
                                 nodeDev.SelectedImageIndex = 1;
                             }
                         }
                    );
                }
                */

                foreach (Device device in devices) {
                    TreeNodeItem<Device> nodeDev = new TreeNodeItem<Device>(device, 1, 1);
                    nodeDev.NodeFont = fontNodeNormal;
                    RootNodeUnlocattedDevices.Nodes.Add(nodeDev);

                    device.OnConnectionStateChanged += new DeviceConnectionEventHandler(
                         (object obj, DeviceConnectionEventArgs e) => {
                             if (e.Device.Connected) {
                                 AddConnectedDevice((Device)e.Device);
                                 nodeDev.ImageIndex = 2;
                                 nodeDev.SelectedImageIndex = 2;
                             } else {
                                 RemoveConnectedDevice((Device)e.Device);
                                 nodeDev.ImageIndex = 1;
                                 nodeDev.SelectedImageIndex = 1;
                             }
                         }
                    );
                }

            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar ler perfis na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar ler perfis na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveConnectedDevice(Device device) {
            CBoxConnectedDevices.Items.Remove(device);
        }

        private void AddConnectedDevice(Device device) {
            Console.WriteLine("Add");

            if (!CBoxConnectedDevices.Items.Contains(device)) {
                CBoxConnectedDevices.Items.Add(device);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e) {
            AddDoor();
        }

        private void AddDoor() {
            DoorAdd doorAdd = new DoorAdd(context);

            doorAdd.ShowDialog(this);

            LoadDevicesToTree();
        }

        private void TreeDeviceContextMenuStrip_Opening(object sender, CancelEventArgs e) {

            if (TViewDevicesTree.SelectedNode != null) {

                if (TViewDevicesTree.SelectedNode.Parent != null) {
                    /*
                    if (TViewDevicesTree.SelectedNode.Parent.Equals(RootNodeDeviceWithoutCars)) {
                        e.Cancel = true;
                        return;
                    }*/
                }

                if (TViewDevicesTree.SelectedNode is TreeNodeItem<Door>) {
                    TreeNodeItem<Door> tdoor = TViewDevicesTree.SelectedNode as TreeNodeItem<Door>;
                    TreeNodeItem<Device> tdev = tdoor.Nodes[0] as TreeNodeItem<Device>;
                                        
                }

                if (TViewDevicesTree.SelectedNode is TreeNodeItem<Device> || TViewDevicesTree.SelectedNode is TreeNodeItem<Door>) {

                    Device dev = null;

                    if (TViewDevicesTree.SelectedNode is TreeNodeItem<Device>) {
                        TreeNodeItem<Device> tdev = (TreeNodeItem<Device>)TViewDevicesTree.SelectedNode;
                        dev = tdev.Value;
                        tsMenuTree_Atualizar.Enabled = true;
                        tsMenuTree_Conectar.Enabled = !dev.Connected;
                        tsMenuTree_Desconectar.Enabled = dev.Connected;
                        tsMenuTree_Alterar.Enabled = true;
                        tsMenuTree_GetInfo.Enabled = dev.Connected;
                    }

                    if (TViewDevicesTree.SelectedNode is TreeNodeItem<Door>) {
                        TreeNodeItem<Door> tcar = TViewDevicesTree.SelectedNode as TreeNodeItem<Door>;
                        //dev = tcar.Value.RegisteredDevice;
                        tsMenuTree_Atualizar.Enabled = true;
                        tsMenuTree_Conectar.Enabled = false;
                        tsMenuTree_Desconectar.Enabled = false;
                        tsMenuTree_Alterar.Enabled = true;
                        tsMenuTree_GetInfo.Enabled = false;
                    }
                    
                    /*
                    if (TViewDevicesTree.SelectedNode is TreeNodeItem<Local>) {
                        TreeNodeItem<Local> node = TViewDevicesTree.SelectedNode as TreeNodeItem<Local>;
                        dev = node.Value.RegisteredDevice;
                    }
                    */

                    

                } else {
                    tsMenuTree_Atualizar.Enabled = true;
                    tsMenuTree_Conectar.Enabled = false;
                    tsMenuTree_Desconectar.Enabled = false;
                    tsMenuTree_Alterar.Enabled = false;
                    tsMenuTree_GetInfo.Enabled = false;
                }
            } else {
                tsMenuTree_Atualizar.Enabled = true;
                tsMenuTree_Conectar.Enabled = false;
                tsMenuTree_Desconectar.Enabled = false;
                tsMenuTree_Alterar.Enabled = false;
                tsMenuTree_GetInfo.Enabled = false;
            }
        }

        private void tsMenuTree_Atualizar_Click(object sender, EventArgs e) {
            MessageBox.Show(this, "Todos os dados contidos nos campos do formulario serão limpos");
            LoadDevicesToTree();
            LoadDeviceTypesToComboBox();
        }

        private void tsMenuTree_Conectar_Click(object sender, EventArgs e) {
            Device dev = null;

            if (TViewDevicesTree.SelectedNode is TreeNodeItem<Device>) {
                TreeNodeItem<Device> tdev = (TreeNodeItem<Device>)TViewDevicesTree.SelectedNode;
                dev = tdev.Value;
            }

            /*
            if (TViewDevicesTree.SelectedNode is TreeNodeItem<Door>) {
                TreeNodeItem<Door> tcar = TViewDevicesTree.SelectedNode as TreeNodeItem<Door>;
                dev = tcar.Value.RegisteredDevice;
            }

            if (TViewDevicesTree.SelectedNode is TreeNodeItem<Local>) {
                TreeNodeItem<Local> tlocal = TViewDevicesTree.SelectedNode as TreeNodeItem<Local>;
                dev = tlocal.Value.RegisteredDevice;
            }
            */

            if (dev == null) {
                return;
            }

            DeviceConnector devConn = new DeviceConnector(dev);
            devConn.StartConnection();

        }

        private void tsMenuTree_Desconectar_Click(object sender, EventArgs e) {
            Device dev = null;

            if (TViewDevicesTree.SelectedNode is TreeNodeItem<Device>) {

                if (TViewDevicesTree.SelectedNode is TreeNodeItem<Device>) {
                    TreeNodeItem<Device> tdev = (TreeNodeItem<Device>)TViewDevicesTree.SelectedNode;
                    dev = tdev.Value;
                }
                                
                dev.Disconnect();

            } else {
                return;
            }
        }

        private Door GetSelectedDoor() {
            Door door = null;

            if (TViewDevicesTree.SelectedNode is TreeNodeItem<Device> || TViewDevicesTree.SelectedNode is TreeNodeItem<Door>) {

                if (TViewDevicesTree.SelectedNode is TreeNodeItem<Device>) {
                    if (TViewDevicesTree.SelectedNode.Parent.Equals(RootNodeUnlocattedDevices)) {
                        return null;
                    }

                    TreeNodeItem<Door> tdoor = TViewDevicesTree.SelectedNode.Parent as TreeNodeItem<Door>;
                    door = tdoor.Value;
                }

                if (TViewDevicesTree.SelectedNode is TreeNodeItem<Door>) {
                    TreeNodeItem<Door> tdoor = TViewDevicesTree.SelectedNode as TreeNodeItem<Door>;
                    door = tdoor.Value;
                }

            }

            return door;
        }

        private void treeViewCars_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            OnSelectNode();
        }

        private void OnSelectNode() {

            if (TViewDevicesTree.SelectedNode is TreeNodeItem<Device>) {
                if (TViewDevicesTree.SelectedNode.Parent.Equals(RootNodeUnlocattedDevices)) {
                    TreeNodeItem<Device> tdevice = TViewDevicesTree.SelectedNode as TreeNodeItem<Device>;
                    OnSelectUnlocatedDevice(tdevice.Value);
                    return;
                }

                if (TViewDevicesTree.SelectedNode.Parent is TreeNodeItem<Door>) {
                    TreeNodeItem<Door> tdoor = TViewDevicesTree.SelectedNode.Parent as TreeNodeItem<Door>;
                    OnSelectDoor(tdoor.Value);
                    return;
                }

                /*
                if (TViewDevicesTree.SelectedNode.Parent is TreeNodeItem<Local>) {
                    TreeNodeItem<Local> tlocal = TViewDevicesTree.SelectedNode.Parent as TreeNodeItem<Local>;
                    OnSelectLocal(tlocal.Value);
                    return;
                }*/
            }


            if (TViewDevicesTree.SelectedNode is TreeNodeItem<Door>) {
                TreeNodeItem<Door> tdoor = TViewDevicesTree.SelectedNode as TreeNodeItem<Door>;
                OnSelectDoor(tdoor.Value);
                return;
            }

            /*
            if (TViewDevicesTree.SelectedNode is TreeNodeItem<Local>) {
                TreeNodeItem<Local> tlocal = TViewDevicesTree.SelectedNode as TreeNodeItem<Local>;
                OnSelectLocal(tlocal.Value);
                return;
            }
            */

        }

        /*
        private void OnSelectLocal(Local tlocal) {
            Local local = tlocal;

            if (local == null) {
                return;
            }

            SelectedLocal = local;
            SelectedLocalDevice = local.RegisteredDevice;
            CleanAll();

            DisableLocalDevice();
            ShowData(local);

            BtnRemoveLocal.Enabled = AllowDelete;//true;
        }
        */

        private void OnSelectDoor(Door tdoor) {
            Door door = tdoor;

            if (door == null) {
                return;
            }

            SelectedDoor = door;

            

            //SelectedDoorDevice1 = firstDevice;
            //SelectedDoorDevice2 = secondDevice;

            CleanAll();

            DisableDoorDevice();

            ShowData(door);

            BtnRemoveCar.Enabled = AllowDelete;//true;
        }

        private void OnSelectUnlocatedDevice(Device tdevice) {
            Device dev = tdevice;

            if (dev == null) {
                return;
            }

            SelectedUnlocatedDevice = dev;
            CleanAll();

            DisableUnlocatedDevice();
            ShowUnlocatedDevice(dev);

            BtnRemoveDevice.Enabled = AllowDelete;//true;
        }

        private void CleanAll() {
            BtnRemoveCar.Enabled = false;
            BtnAddCar.Enabled = AllowAdd;//true;            
            BtnAddDevice.Enabled = AllowAdd;//true;
            BtnRemoveDevice.Enabled = false;

            DisableDoorDevice();
            DisableLocalDevice();
            DisableUnlocatedDevice();

            CleanFormDoor();
            CleanDoorDevices();
            CleanFormLocal();
            //CleanLocalDevice();
            CleanUnlocatedDevice();
            CleanFormDeviceInfo();
        }

        private void CleanFormDoor() {
            TxtDoorName.Text = "";
            RBtnDoor_OneDevice.Checked = true;            
            CBoxDoorDevice1.Items.Clear();
            CBoxDoorDevice2.Items.Clear();

            CBoxDoorDevice1.ResetText();
            CBoxDoorDevice2.ResetText();
        }

        private void CleanDoorDevices() {
            LabelDevice1.Text = "Dados do Biométrico";
            CBoxDoorDeviceType1.SelectedIndex = -1;
            TxtDoorDeviceName1.Text = "";
            RbDoorDeviceTCP1.Checked = true;
            TxtDoorDeviceIPAddress1.Text = "192.168.1.201";
            TxtDoorDeviceIpPort1.Text = "4370";
            CBoxDoorDeviceComPort1.SelectedIndex = 0;
            CBoxDoorDeviceBaudRate1.SelectedIndex = 0;
            TxtDoorDeviceSerialNumber1.Text = "";

            LabelDevice2.Text = "Dados do Biométrico";
            CBoxDoorDeviceType2.SelectedIndex = -1;
            TxtDoorDeviceName2.Text = "";
            RbDoorDeviceTCP2.Checked = true;
            TxtDoorDeviceIPAddress2.Text = "192.168.1.201";
            TxtDoorDeviceIpPort2.Text = "4370";
            CBoxDoorDeviceComPort2.SelectedIndex = 0;
            CBoxDoorDeviceBaudRate2.SelectedIndex = 0;
            TxtDoorDeviceSerialNumber2.Text = "";
        }

        private void CleanFormLocal() {
            TxtLocalNome.Text = "";
            TxtLocalEndereco.Text = "";
            TxtLocalDescricao.Text = "";
            CBoxLocalDevices.Items.Clear();
        }

        private void CleanLocalDevice() {
            LabelLocalDevice.Text = "Dados do Biométrico";
            TxtLocalDeviceName.Text = "";
            RbLocalDeviceTCP.Checked = true;
            TxtLocalDeviceIPAddress.Text = "192.168.1.201";
            TxtLocalDeviceIpPort.Text = "4370";
            CBoxLocalDeviceComPort.SelectedIndex = 0;
            CBoxLocalDeviceBaudRate.SelectedIndex = 0;
            TxtLocalDeviceSerialNumber.Text = "";
            CBoxLocalDeviceServico.SelectedIndex = -1;
        }

        private void CleanUnlocatedDevice() {
            LabelDevice.Text = "Dados do Biométrico";
            TxtDeviceName.Text = "";
            CBoxDeviceType.SelectedIndex = -1;
            RbDeviceTCP.Checked = true;
            TxtDeviceIPAddress.Text = "192.168.1.201";
            TxtDeviceIpPort.Text = "4370";
            CBoxDeviceComPort.SelectedIndex = 0;
            CBoxDeviceBaudRate.SelectedIndex = 0;
            TxtDeviceSerialNumber.Text = "";            
        }

        private void CleanFormDeviceInfo() {
            //grpBioInfo.Text = "Dispositivo:";

            txtInfoBio_VendorName.Text = "";
            txtInfoBio_ProdCode.Text = "";
            txtInfoBio_SN.Text = "";
            txtInfoBio_FirmVer.Text = "";

            lbInfoBio_nAdmins.Text = "";
            lbInfoBio_nUsers.Text = "";
            lbInfoBio_nFingers.Text = "";
            lbInfoBio_nPswds.Text = "";
            lbInfoBio_nSysLogs.Text = "";
            lbInfoBio_nLogs.Text = "";
            lbInfoBio_nFaces.Text = "";

            lbInfoBio_Maxfingers.Text = "";
            lbInfoBio_MaxUsers.Text = "";
            lbInfoBio_MaxLogs.Text = "";
            lbInfoBio_MaxFaces.Text = "";
        }

        private void ShowData(Door door) {
            tabControlDevMan.SelectedIndex = 0;

            TxtDoorName.Text = door.Name;
            
            //DoorType - Modulo 1
            CBoxDoorType.Items.Clear();
            CBoxDoorType.Items.Add(door.Type);
            CBoxDoorType.SelectedIndex = 0;

            if (door.Departamento != null) {
                CBoxDepartamento.Items.Clear();
                CBoxDepartamento.Items.Add(door.Departamento);
                CBoxDepartamento.SelectedIndex = 0;
            }

            Device firstDevice = null;
            Device secondDevice = null;

            //Load device1 e device2
            if (door.Devices.Count == 2) {
                firstDevice = door.Devices[0];
                secondDevice = door.Devices[1];
            } else {
                firstDevice = door.Devices[0];
            }

            RBtnDoor_OneDevice.Checked = door.NumberOfDevices==1 ? true : false;

            if (firstDevice != null) {                
                CBoxDoorDevice1.Items.Clear();
                CBoxDoorDevice1.Items.Add(firstDevice);
                CBoxDoorDevice1.SelectedIndex = 0;
                ShowDoorDevice1(firstDevice);
            }

            if (secondDevice != null) {
                RBtnDoor_TwoDevices.Checked = true;

                CBoxDoorDevice2.Items.Clear();
                CBoxDoorDevice2.Items.Add(secondDevice);
                CBoxDoorDevice2.SelectedIndex = 0;
                ShowDoorDevice2(secondDevice);
            }
        }

        private void ShowDoorDevice1(Device device) {
            LabelDevice1.Text = "Dados do Biométrico [" + device.Name + "]";
            TxtDoorDeviceName1.Text = device.Name;
            CBoxDoorDeviceType1.SelectedItem = device.DeviceType;
            RbDoorDeviceTCP1.Checked = device.ConnectionType == 0;
            RbDoorDeviceRS1.Checked = device.ConnectionType == 1;
            RbDoorDeviceUSB1.Checked = device.ConnectionType == 2;
            TxtDoorDeviceIPAddress1.Text = device.IpAddress;
            TxtDoorDeviceIpPort1.Text = device.Port + "";
            CBoxDoorDeviceComPort1.SelectedIndex = device.ComPort - 1;
            CBoxDoorDeviceBaudRate1.SelectedValue = device.BaudRate + "";
            TxtDoorDeviceSerialNumber1.Text = device.SerialNumber;
                        
        }

        private void ShowDoorDevice2(Device device) {
            LabelDevice2.Text = "Dados do Biométrico [" + device.Name + "]";
            TxtDoorDeviceName2.Text = device.Name;
            CBoxDoorDeviceType2.SelectedItem = device.DeviceType;
            RbDoorDeviceTCP2.Checked = device.ConnectionType == 0;
            RbDoorDeviceRS2.Checked = device.ConnectionType == 1;
            RbDoorDeviceUSB2.Checked = device.ConnectionType == 2;
            TxtDoorDeviceIPAddress2.Text = device.IpAddress;
            TxtDoorDeviceIpPort2.Text = device.Port + "";
            CBoxDoorDeviceComPort2.SelectedIndex = device.ComPort - 1;
            CBoxDoorDeviceBaudRate2.SelectedValue = device.BaudRate + "";
            TxtDoorDeviceSerialNumber2.Text = device.SerialNumber;

        }

        private void ShowUnlocatedDevice(Device device) {
            tabControlDevMan.SelectedIndex = 2;

            LabelDevice.Text = "Dados do Biométrico [" + device.Name + "]";
            TxtDeviceName.Text = device.Name;
            CBoxDeviceType.SelectedItem = device.DeviceType;
            RbDeviceTCP.Checked = device.ConnectionType == 0;
            RbDeviceRS.Checked = device.ConnectionType == 1;
            RbDeviceUSB.Checked = device.ConnectionType == 2;
            TxtDeviceIPAddress.Text = device.IpAddress;
            TxtDeviceIpPort.Text = device.Port + "";
            CBoxDeviceComPort.SelectedIndex = device.ComPort - 1;
            CBoxDeviceBaudRate.SelectedValue = device.BaudRate + "";
            TxtDeviceSerialNumber.Text = device.SerialNumber;
                                    
        }

        /*
        private void ShowData(Local local) {
            tabControlDevMan.SelectedIndex = 1;

            TxtLocalNome.Text = local.Nome;
            TxtLocalEndereco.Text = local.Endereco;
            TxtLocalDescricao.Text = local.Descricao;

            CBoxLocalParceiros.Items.Clear();
            CBoxLocalParceiros.Items.Add(local.Proprietario);
            CBoxLocalParceiros.SelectedIndex = 0;

            CBoxLocalCategorias.Items.Clear();
            CBoxLocalCategorias.Items.Add(local.Categoria);
            CBoxLocalCategorias.SelectedIndex = 0;

            CBoxLocalDevices.Items.Clear();
            CBoxLocalDevices.Items.Add(local.RegisteredDevice);
            CBoxLocalDevices.SelectedIndex = 0;

            ShowLocalDevice(local.RegisteredDevice);
        }
        */

        private void ShowLocalDevice(Device device) {
            LabelLocalDevice.Text = "Dados do Biométrico [" + device.Name + "]";
            TxtLocalDeviceName.Text = device.Name;
            RbLocalDeviceTCP.Checked = device.ConnectionType == 0;
            RbLocalDeviceRS.Checked = device.ConnectionType == 1;
            RbLocalDeviceUSB.Checked = device.ConnectionType == 2;
            TxtLocalDeviceIPAddress.Text = device.IpAddress;
            TxtLocalDeviceIpPort.Text = device.Port + "";
            CBoxLocalDeviceComPort.SelectedIndex = device.ComPort - 1;
            CBoxLocalDeviceBaudRate.SelectedValue = device.BaudRate + "";
            TxtLocalDeviceSerialNumber.Text = device.SerialNumber;                        
        }

        private void BtnGetInfoBio_Click(object sender, EventArgs e) {

            if (CBoxConnectedDevices.Items.Count == 0) {
                MessageBox.Show(this, "Não exitesm dispositivos conectados no momento!");
                CBoxConnectedDevices.Focus();
                return;
            }

            if (CBoxConnectedDevices.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione um dos dispositivos conectados!");
                CBoxConnectedDevices.Focus();
                return;
            }

            Device device = CBoxConnectedDevices.SelectedItem as Device;
            GetBioInfo(device);
        }

        private void GetBioInfo(Device device) {
            if (device.Connected == false) {
                MessageBox.Show(this, "O biométrico não esta conectado, conecte-o para obter informação");
                return;
            }

            string prodVendor = "";
            string prodCode = "";
            string SN = "";
            string firmVer = "";
            string fpAlg = "";
            string tftBw = "";

            int capFps = 0;
            int capUsers = 0;
            int capLogs = 0;
            int capFaces = 0;

            int nUsers = 0;
            int nAdmins = 0;
            int nFps = 0;
            int nPwds = 0;
            int nSysLogs = 0;
            int nLogs = 0;
            int nFaces = 0;

            DeviceIO deviceIO = new DeviceIO(device);

            try {

                deviceIO.GetVendor(ref prodVendor);
                deviceIO.GetProductCode(out prodCode);
                deviceIO.GetSerialNumber(out SN);
                deviceIO.GetFirmwareVersion(ref firmVer);
                tftBw = deviceIO.IsTFTMachine() ? "TFT" : "B&w";
                fpAlg = deviceIO.GetFPVersion();

                deviceIO.GetDeviceStatus(1, ref nAdmins);
                deviceIO.GetDeviceStatus(2, ref nUsers);
                deviceIO.GetDeviceStatus(3, ref nFps);
                deviceIO.GetDeviceStatus(4, ref nPwds);
                deviceIO.GetDeviceStatus(5, ref nSysLogs);
                deviceIO.GetDeviceStatus(6, ref nLogs);
                deviceIO.GetDeviceStatus(21, ref nFaces);

                deviceIO.GetDeviceStatus(7, ref capFps);
                deviceIO.GetDeviceStatus(8, ref capUsers);
                deviceIO.GetDeviceStatus(9, ref capLogs);
                deviceIO.GetDeviceStatus(22, ref capFaces);

                //labelInfoBioName.Text = device.ToString();
                //grpBioInfo.Text = device.ToString();

                txtInfoBio_VendorName.Text = prodVendor;
                txtInfoBio_ProdCode.Text = prodCode;
                txtInfoBio_SN.Text = SN;
                txtInfoBio_FirmVer.Text = firmVer;
                txtInfoBio_FPVer.Text = fpAlg;
                txtInfoBio_TftOrBw.Text = tftBw;

                lbInfoBio_nAdmins.Text = nAdmins.ToString();
                lbInfoBio_nUsers.Text = nUsers.ToString();
                lbInfoBio_nFingers.Text = nFps.ToString();
                lbInfoBio_nPswds.Text = nPwds.ToString();
                lbInfoBio_nSysLogs.Text = nSysLogs.ToString();
                lbInfoBio_nLogs.Text = nLogs.ToString();
                lbInfoBio_nFaces.Text = nFaces.ToString();

                lbInfoBio_Maxfingers.Text = capFps.ToString();
                lbInfoBio_MaxUsers.Text = capUsers.ToString();
                lbInfoBio_MaxLogs.Text = capLogs.ToString();
                lbInfoBio_MaxFaces.Text = capFaces.ToString();

                tabControlDevMan.SelectedIndex = 3;

            } catch (Exception ex) {
                MessageBox.Show(this, "Não foi possivel obter a informação do dispositivo", "Erro ao ler o dispositivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsMenuTree_GetInfo_Click(object sender, EventArgs e) {
            
        }

        private void tsMenuTree_Alterar_Click(object sender, EventArgs e) {
            OnSelectAlterar();
        }

        private void OnSelectAlterar() {
            if (TViewDevicesTree.SelectedNode is TreeNodeItem<Device>) {
                if (TViewDevicesTree.SelectedNode.Parent.Equals(RootNodeUnlocattedDevices)) {
                    TreeNodeItem<Device> tdev = TViewDevicesTree.SelectedNode.Parent as TreeNodeItem<Device>;
                    ChangeUnlocated();
                    return;
                }

                if (TViewDevicesTree.SelectedNode.Parent is TreeNodeItem<Door>) {
                    TreeNodeItem<Door> tdoor = TViewDevicesTree.SelectedNode.Parent as TreeNodeItem<Door>;
                    ChangeDoor();
                    return;
                }

                /*
                if (TViewDevicesTree.SelectedNode.Parent is TreeNodeItem<Local>) {
                    TreeNodeItem<Local> tlocal = TViewDevicesTree.SelectedNode.Parent as TreeNodeItem<Local>;
                    ChangeLocal();
                    return;
                }
                 */
            }

            if (TViewDevicesTree.SelectedNode is TreeNodeItem<Door>) {
                TreeNodeItem<Door> tcar = TViewDevicesTree.SelectedNode as TreeNodeItem<Door>;
                ChangeDoor();
                return;
            }

            /*
            if (TViewDevicesTree.SelectedNode is TreeNodeItem<Local>) {
                TreeNodeItem<Local> tlocal = TViewDevicesTree.SelectedNode as TreeNodeItem<Local>;
                ChangeLocal();
                return;
            }
            */
        }

        private void DisableUnlocatedDevice() {
            bool value = false;

            BtnSaveDevice.Enabled = value;
            BtnRemoveDevice.Enabled = value;
            BtnDeviceCancelUpdate.Enabled = value;

            TxtDeviceName.ReadOnly = !value;
            CBoxDeviceType.Enabled = value;
            RbDeviceTCP.Enabled = value;
            RbDeviceRS.Enabled = value;
            RbDeviceUSB.Enabled = value;
            TxtDeviceIPAddress.ReadOnly = !value;
            TxtDeviceIpPort.ReadOnly = !value;
            CBoxDeviceComPort.Enabled = value;
            CBoxDeviceBaudRate.Enabled = value;
            TxtDeviceSerialNumber.ReadOnly = true;
            
        }

        private void EnableUnlocatedDevice() {
            bool value = true;

            BtnSaveDevice.Enabled = AllowUpdate;
            BtnRemoveDevice.Enabled = !value;
            BtnDeviceCancelUpdate.Enabled = value;

            TxtDeviceName.ReadOnly = !value;
            CBoxDeviceType.Enabled = value;
            RbDeviceTCP.Enabled = value;
            RbDeviceRS.Enabled = value;
            RbDeviceUSB.Enabled = value;
            TxtDeviceIPAddress.ReadOnly = !value;
            TxtDeviceIpPort.ReadOnly = !value;
            CBoxDeviceComPort.Enabled = value;
            CBoxDeviceBaudRate.Enabled = value;
            TxtDeviceSerialNumber.ReadOnly = true;            
        }

        private void DisableDoorDevice() {
            bool value = false;

            BtnSaveDoor.Enabled = value;
            BtnRemoveCar.Enabled = value;
            BtnDoorCancelUpdate.Enabled = value;

            TxtDoorName.ReadOnly = !value;
            CBoxDoorType.Enabled = value;
            RBtnDoor_OneDevice.AutoCheck = value;
            RBtnDoor_TwoDevices.AutoCheck = value;
            
            CBoxDoorDevice1.Enabled = value;
            CBoxDoorDevice2.Enabled = value;

            CBoxDepartamento.Enabled = value;

            TxtDoorDeviceName1.ReadOnly = !value;
            RbDoorDeviceTCP1.Enabled = value;
            RbDoorDeviceRS1.Enabled = value;
            RbDoorDeviceUSB1.Enabled = value;
            TxtDoorDeviceIPAddress1.ReadOnly = !value;
            TxtDoorDeviceIpPort1.ReadOnly = !value;
            CBoxDoorDeviceComPort1.Enabled = value;
            CBoxDoorDeviceBaudRate1.Enabled = value;
            TxtDoorDeviceSerialNumber1.ReadOnly = true;

            TxtDoorDeviceName2.ReadOnly = !value;
            RbDoorDeviceTCP2.Enabled = value;
            RbDoorDeviceRS2.Enabled = value;
            RbDoorDeviceUSB2.Enabled = value;
            TxtDoorDeviceIPAddress2.ReadOnly = !value;
            TxtDoorDeviceIpPort2.ReadOnly = !value;
            CBoxDoorDeviceComPort2.Enabled = value;
            CBoxDoorDeviceBaudRate2.Enabled = value;
            TxtDoorDeviceSerialNumber2.ReadOnly = true;
            
        }

        private void EnableDoorDevice() {
            bool value = true;

            BtnSaveDoor.Enabled = AllowUpdate;
            BtnDoorCancelUpdate.Enabled = value;

            TxtDoorName.ReadOnly = !value;
            CBoxDoorType.Enabled = value;
                        
            RBtnDoor_OneDevice.AutoCheck = value;
            RBtnDoor_TwoDevices.AutoCheck = value;

            CBoxDoorDevice1.Enabled = value;

            CBoxDepartamento.Enabled = value;

            TxtDoorDeviceName1.ReadOnly = !value;
            //CBoxDoorDeviceType1.Enabled = !value;
            RbDoorDeviceTCP1.Enabled = value;
            RbDoorDeviceRS1.Enabled = value;
            RbDoorDeviceUSB1.Enabled = value;
            TxtDoorDeviceIPAddress1.ReadOnly = !value;
            TxtDoorDeviceIpPort1.ReadOnly = !value;
            CBoxDoorDeviceComPort1.Enabled = value;
            CBoxDoorDeviceBaudRate1.Enabled = value;
            TxtDoorDeviceSerialNumber1.ReadOnly = true;

            TxtDoorDeviceName2.ReadOnly = !value;
            RbDoorDeviceTCP2.Enabled = value;
            RbDoorDeviceRS2.Enabled = value;
            RbDoorDeviceUSB2.Enabled = value;
            TxtDoorDeviceIPAddress2.ReadOnly = !value;
            TxtDoorDeviceIpPort2.ReadOnly = !value;
            CBoxDoorDeviceComPort2.Enabled = value;
            CBoxDoorDeviceBaudRate2.Enabled = value;
            TxtDoorDeviceSerialNumber2.ReadOnly = true;
        }

        private void ChangeDoor() {
            if (SelectedDoor == null) {
                MessageBox.Show(this, "Selecione um autocarro primeiro");
                return;
            }

            tabControlDevMan.SelectedIndex = 0;

            EnableDoorDevice();
            BtnAddCar.Enabled = false;
            BtnRemoveCar.Enabled = false;
            LoadDevicesToChangeDoor();
            //LoadParceirosToChangeCar();
        }

        /*
        private void ChangeLocal() {
            if (SelectedLocal == null) {
                MessageBox.Show(this, "Selecione um local primeiro");
                return;
            }

            tabControlDevMan.SelectedIndex = 1;

            EnableLocalDevice();
            BtnAddLocal.Enabled = false;
            BtnRemoveLocal.Enabled = false;
            LoadDevicesToChangeLocal();
            LoadParceirosToChangeLocal();
            LoadCategoriasToChangeLocal();
        }
        */

        private void ChangeUnlocated() {
            if (SelectedUnlocatedDevice == null) {
                MessageBox.Show(this, "Selecione um dispositivo não alocado primeiro");
                return;
            }

            tabControlDevMan.SelectedIndex = 2;

            EnableUnlocatedDevice();
            BtnAddDevice.Enabled = false;
            BtnRemoveDevice.Enabled = false;

        }

        //Summary 
        // Ler os dispositivos que não tem biometricos associados e adicionar a lista de devices do autocarro
        //
        private void LoadDevicesToChangeDoor() {
            var devices = context.Device.Where(d => d.Door == null).ToList();

            //CBoxDevices.Items.Clear();

            foreach (Device dev in devices) {
                CBoxDoorDevice1.Items.Add(dev);
                CBoxDoorDevice2.Items.Add(dev);
            }
        }

        /*
        private void LoadParceirosToChangeCar() {
            var parceiros = context.Parceiros.ToList();

            CBoxCarParceiros.Items.Clear();

            foreach (var par in parceiros) {
                CBoxCarParceiros.Items.Add(par);
            }

            CBoxCarParceiros.SelectedItem = SelectedDoor.Proprietario;
        }

        private void LoadDevicesToChangeLocal() {
            var devices = context.Device.Where(d => d.RegisteredDoor == null && d.RegisteredLocal == null);

            //CBoxLocalDevices.Items.Clear();

            foreach (Device dev in devices) {
                CBoxLocalDevices.Items.Add(dev);
            }
        }

        private void LoadParceirosToChangeLocal() {
            var parceiros = context.Parceiros.ToList();

            CBoxLocalParceiros.Items.Clear();

            foreach (var par in parceiros) {
                CBoxLocalParceiros.Items.Add(par);
            }

            CBoxLocalParceiros.SelectedItem = SelectedLocal.Proprietario;
        }

        private void LoadCategoriasToChangeLocal() {
            var categorias = context.LocalCategoria.ToList();

            CBoxLocalCategorias.Items.Clear();

            foreach (var categ in categorias) {
                CBoxLocalCategorias.Items.Add(categ);
            }

            CBoxLocalCategorias.SelectedItem = SelectedLocal.Categoria;
        }
        */

        private void DisableLocalDevice() {
            bool value = false;

            BtnSaveLocal.Enabled = value;
            BtnLocalCancelUpdate.Enabled = value;

            TxtLocalNome.ReadOnly = !value;
            TxtLocalEndereco.ReadOnly = !value;
            TxtLocalDescricao.ReadOnly = !value;
            CBoxLocalDevices.Enabled = value;

            TxtLocalDeviceName.ReadOnly = !value;
            RbLocalDeviceTCP.Enabled = value;
            RbLocalDeviceRS.Enabled = value;
            RbLocalDeviceUSB.Enabled = value;
            TxtLocalDeviceIPAddress.ReadOnly = !value;
            TxtLocalDeviceIpPort.ReadOnly = !value;
            CBoxLocalDeviceComPort.Enabled = value;
            CBoxLocalDeviceBaudRate.Enabled = value;
            TxtLocalDeviceSerialNumber.ReadOnly = true;
            CBoxLocalDeviceServico.Enabled = value;
        }

        /*
        private void EnableLocalDevice() {
            bool value = true;

            BtnSaveLocal.Enabled = AllowUpdate;
            BtnLocalCancelUpdate.Enabled = value;
            TxtLocalNome.ReadOnly = !value;
            TxtLocalEndereco.ReadOnly = !value;
            TxtLocalDescricao.ReadOnly = !value;
            CBoxLocalDevices.Enabled = value;

            TxtLocalDeviceName.ReadOnly = !value;
            RbLocalDeviceTCP.Enabled = value;
            RbLocalDeviceRS.Enabled = value;
            RbLocalDeviceUSB.Enabled = value;
            TxtLocalDeviceIPAddress.ReadOnly = !value;
            TxtLocalDeviceIpPort.ReadOnly = !value;
            CBoxLocalDeviceComPort.Enabled = value;
            CBoxLocalDeviceBaudRate.Enabled = value;
            TxtLocalDeviceSerialNumber.ReadOnly = true;
            CBoxLocalDeviceServico.Enabled = value;
        }*/

        private void BtnCancelUpdate_Click(object sender, EventArgs e) {
            DisableDoorDevice();
        }

        private void BtnAddDevice_Click(object sender, EventArgs e) {
            OpenAddDevice();
        }

        private void OpenAddDevice() {
            DeviceAdd deviceAdd = new DeviceAdd();

            deviceAdd.ShowDialog(this);

            LoadDevicesToTree();
        }

        private void BtnSaveCar_Click(object sender, EventArgs e) {
            UpdateDoorDevice();
        }

        private void UpdateDoorDevice() {
            if (!ValidarDoor()) {
                return;
            }

            if (!ValidateDoorDevice1()) {
                return;
            }

            if (RBtnDoor_TwoDevices.Checked) {
                if (!ValidateDoorDevice2()) {
                    return;
                }
            }

            string doorName = TxtDoorName.Text;
            Device doorDevice1 = CBoxDoorDevice1.SelectedItem as Device; //GetDoorDevice1();
            Device doorDevice2 = CBoxDoorDevice2.SelectedItem as Device; //GetDoorDevice2();
            DoorType doorType = CBoxDoorType.SelectedItem as DoorType;
            Departamento departamento = CBoxDepartamento.SelectedItem as Departamento;

            //verificar se existe um outro autocarro com o novo nome
            Door car = context.Door.FirstOrDefault(u => u.Id != SelectedDoor.Id && u.Name == doorName);
            
            if (car != null) {
                MessageBox.Show(this, "Já existe uma porta com o nome (" + doorName + "), introduza outra por favor!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtDoorName.Focus();
                return;
            }

            //verificar se existe um outro device com o novo nome
            if (doorDevice1 != null) {

                Device dev = context.Device.FirstOrDefault(d => d.Id != doorDevice1.Id && d.Name == TxtDoorDeviceName1.Text);
                if (dev != null) {
                    MessageBox.Show(this, "Já existe um dispositivo biométrico com o nome (" + TxtDoorDeviceName2.Text + "), introduza outro por favor!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tabDoorDevices.SelectedIndex = 0;
                    TxtDoorDeviceName1.Focus();
                    return;
                }
            }
            if (doorDevice2 != null) {
                Device dev = context.Device.FirstOrDefault(d => d.Id != doorDevice2.Id && d.Name == TxtDoorDeviceName2.Text);
                if (dev != null) {
                    MessageBox.Show(this, "Já existe um dispositivo biométrico com o nome (" + TxtDoorDeviceName2.Text + "), introduza outro por favor!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tabDoorDevices.SelectedIndex = 1;
                    TxtDoorDeviceName2.Focus();
                    return;
                }
            }

            DialogResult dr = MessageBox.Show(this, "Tem certeza que deseja atualizar os dados da porta " + doorName + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) {
                return;
            }
          
            SelectedDoor.Name = doorName;            
            SelectedDoor.NumberOfDevices = RBtnDoor_OneDevice.Checked ? 1 : 2;
            SelectedDoor.Type = doorType;
            SelectedDoor.UpdatedBy = SystemManager.GetCurrentUser(context);
            SelectedDoor.UpdatedDate = DateTime.Now;
            SelectedDoor.Departamento = departamento;

            if (departamento != null) {
                departamento.RegisteredDoor = SelectedDoor;
            }
            
            VerifyDevicesAndDoChanges(SelectedDoor, doorDevice1, doorDevice2);
                        
            try {
                context.SaveChanges();
                MessageBox.Show(this, "A porta e biometrico(s) foram atualizados com sucesso");

                Door temp = SelectedDoor;
                LoadDevicesToTree();
                OnSelectDoor(temp);

            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar atualizar a porta na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar atualizar o porta na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
            }
        }

        private void VerifyDevicesAndDoChanges(Door SelectedDoor, Device newDevice1, Device newDevice2) {
            Device oldFirstDevice = null;
            Device oldSecondDevice = null;

            Device newFirstDevice = null;            
            Device newSecondDevice = null;

            int OldNumberOfDevices = 0;

            OldNumberOfDevices = SelectedDoor.Devices.Count;

            //Load device1 e device2
            if (OldNumberOfDevices == 2) {
                oldFirstDevice = SelectedDoor.Devices[0];
                oldSecondDevice = SelectedDoor.Devices[1];
            } else {
                oldFirstDevice = SelectedDoor.Devices[0];
            }

            newFirstDevice = oldFirstDevice;
            newSecondDevice = oldSecondDevice;

            //Se era com 2 devices e mudou para 1 - Apagar o segundo
            if (OldNumberOfDevices == 2 && RBtnDoor_OneDevice.Checked) {
                if (oldSecondDevice != null) {
                    SelectedDoor.Devices.Remove(oldSecondDevice);
                    newSecondDevice = null;
                }
            }
            //Se era com 1 device e mudou para 2 - Adicionar o segundo
            if (OldNumberOfDevices == 1 && RBtnDoor_TwoDevices.Checked) {
                if (newDevice2 != null) {
                    SelectedDoor.Devices.Add(newDevice2);
                    newSecondDevice = newDevice2;
                }
            }

            //If we change device1
            if (newDevice1 != null && oldFirstDevice != null) {
                if (!oldFirstDevice.Equals(newDevice1)) {
                    SelectedDoor.Devices.Remove(oldFirstDevice);
                    SelectedDoor.Devices.Insert(0, newDevice1);
                    newFirstDevice = newDevice1;
                }
            }
            //If we change device2
            if (newDevice2 != null && oldSecondDevice != null) {
                if (!oldSecondDevice.Equals(newDevice2)) {
                    SelectedDoor.Devices.Remove(oldSecondDevice);
                    SelectedDoor.Devices.Add(newDevice2);
                    newSecondDevice = newDevice2;
                }
            }


            //Update Data
            if (RBtnDoor_TwoDevices.Checked) {
                newFirstDevice = GetDoorDevice1(newFirstDevice);
                newSecondDevice = GetDoorDevice2(newSecondDevice);

                newFirstDevice.DeviceType = DEVICE_TYPE_IN;
                newSecondDevice.DeviceType = DEVICE_TYPE_OUT;
                
            } else {
                newFirstDevice = GetDoorDevice1(newFirstDevice);

                newFirstDevice.DeviceType = DEVICE_TYPE_IN_OUT;
            }
        }

        private Device GetDoorDevice1(Device device) {                                    
            device.Name = TxtDoorDeviceName1.Text;
            device.DeviceType = CBoxDoorDeviceType1.SelectedItem as DeviceType;
            device.SerialNumber = TxtDoorDeviceSerialNumber1.Text;
            device.ConnectionType = (RbDoorDeviceTCP1.Checked) ? 0 : ((RbDoorDeviceRS1.Checked) ? 1 : 2);
            device.IpAddress = TxtDoorDeviceIPAddress1.Text;
            device.Port = Convert.ToInt32(TxtDoorDeviceIpPort1.Text);
            device.ComPort = this.CBoxDoorDeviceComPort1.SelectedIndex + 1;
            device.BaudRate = Convert.ToInt32(this.CBoxDoorDeviceBaudRate1.SelectedItem.ToString());

            return device;
        }

        private Device GetDoorDevice2(Device device) {
            
            if (device == null) {
                return null;
            } 

            device.Name = TxtDoorDeviceName2.Text;
            device.DeviceType = CBoxDoorDeviceType2.SelectedItem as DeviceType;
            device.SerialNumber = TxtDoorDeviceSerialNumber2.Text;
            device.ConnectionType = (RbDoorDeviceTCP2.Checked) ? 0 : ((RbDoorDeviceRS2.Checked) ? 1 : 2);
            device.IpAddress = TxtDoorDeviceIPAddress2.Text;
            device.Port = Convert.ToInt32(TxtDoorDeviceIpPort2.Text);
            device.ComPort = this.CBoxDoorDeviceComPort2.SelectedIndex + 1;
            device.BaudRate = Convert.ToInt32(this.CBoxDoorDeviceBaudRate2.SelectedItem.ToString());

            return device;
        }

        private bool ValidarDoor() {
            if (TxtDoorName.Text == "") {
                MessageBox.Show(this, "Introduza o nome, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtDoorName.Focus();
                return false;
            }

            if (RBtnDoor_OneDevice.Checked == false && RBtnDoor_TwoDevices.Checked == false) {
                MessageBox.Show(this, "Selecione o tipo de porta, por favor!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RBtnDoor_OneDevice.Focus();
                return false;
            }

            if (RBtnDoor_OneDevice.Checked) {
                if (CBoxDoorDevice1.SelectedIndex == -1) {
                    MessageBox.Show(this, "Selecione um dispositivo biométrico ou adicionar um dispositivo!, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CBoxDoorDevice1.Focus();
                    return false;
                }
            } else {
                if (CBoxDoorDevice1.SelectedIndex == -1) {
                    MessageBox.Show(this, "Selecione o dispositivo biométrico de entrada ou clique em (Adicionar 1) para adicionar um dispositivo!, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CBoxDoorDevice1.Focus();
                    return false;
                }

                if (CBoxDoorDevice2.SelectedIndex == -1) {
                    MessageBox.Show(this, "Selecione o dispositivo biométrico de saida ou clique em (Adicionar 2) para adicionar um dispositivo!, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CBoxDoorDevice2.Focus();
                    return false;
                }

                Device device1 = CBoxDoorDevice1.SelectedItem as Device;
                Device device2 = CBoxDoorDevice2.SelectedItem as Device;

                if (device1.Equals(device2)) {
                    MessageBox.Show(this, "O dispositivo biométrico de saida não pode ser o mesmo que o de entrada. Selecione outro dispositivo!, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CBoxDoorDevice2.Focus();
                    return false;
                }
            }

            return true;
        }

        private bool ValidateDoorDevice1() {
            if (TxtDoorDeviceName1.Text == "") {
                MessageBox.Show(this, "Introduza o nome do biométrico");
                tabDoorDevices.SelectedIndex = 0;
                TxtDoorDeviceName1.Focus();
                return false;
            }

            if (CBoxDoorDeviceType1.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione o tipo de dispositivo biometrico!");
                tabDoorDevices.SelectedIndex = 0;
                CBoxDoorDeviceType1.Focus();
                return false;
            }

            if (!ValidateCarDeviceConnection1()) {
                return false;
            }

            if (TxtDoorDeviceSerialNumber1.Text == "") {
                tabDoorDevices.SelectedIndex = 0;
                MessageBox.Show(this, "Número de serie invalido!\nPara obter o número de serie, conecte o dispositivo e clique em (Testar conexão).");
                return false;
            }                        

            return true;
        }

        private bool ValidateCarDeviceConnection1() {

            string regxIp = "^[0-9]+\\.[0-9]+\\.[0-9]+\\.[0-9]+$";
            string regxNum = "^[0-9]+$";

            if (RbDoorDeviceTCP1.Checked) {
                if (!Regex.IsMatch(TxtDoorDeviceIPAddress1.Text, regxIp)) {
                    MessageBox.Show(this, "O endereço IP introduzido é inválido, introduza correctamente");
                    tabDoorDevices.SelectedIndex = 0;
                    TxtDoorDeviceIPAddress1.Focus();
                    return false;
                }
                if (!Regex.IsMatch(TxtDoorDeviceIpPort1.Text, regxNum)) {
                    MessageBox.Show(this, "O numero da porta introduzido é inválido, introduza correctamente");
                    tabDoorDevices.SelectedIndex = 0;
                    TxtDoorDeviceIpPort1.Focus();
                    return false;
                }
            }

            if (RbDoorDeviceRS1.Checked) {
                if (CBoxDoorDeviceComPort1.SelectedIndex == -1) {
                    MessageBox.Show(this, "Selecione a porta COM");
                    tabDoorDevices.SelectedIndex = 0;
                    CBoxDoorDeviceComPort1.Focus();                    
                    return false;
                }
                if (CBoxDoorDeviceBaudRate1.SelectedIndex == -1) {
                    MessageBox.Show(this, "Selecione a taxa de transferência(Baud Rate)");
                    tabDoorDevices.SelectedIndex = 0;
                    CBoxDoorDeviceBaudRate1.Focus();
                    return false;
                }
            }

            return true;
        }

        private bool ValidateDoorDevice2() {
                        
            if (TxtDoorDeviceName2.Text == "") {
                MessageBox.Show(this, "Introduza o nome do biométrico");
                tabDoorDevices.SelectedIndex = 1;
                TxtDoorDeviceName2.Focus();
                return false;
            }

            if (CBoxDoorDeviceType2.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione o tipo de dispositivo biometrico!");
                tabDoorDevices.SelectedIndex = 1;
                CBoxDoorDeviceType2.Focus();
                return false;
            }

            if (!ValidateCarDeviceConnection2()) {
                return false;
            }

            if (TxtDoorDeviceSerialNumber2.Text == "") {
                MessageBox.Show(this, "Número de serie invalido!\nPara obter o número de serie, conecte o dispositivo e clique em (Testar conexão).");
                tabDoorDevices.SelectedIndex = 1;
                return false;
            }

            return true;
        }

        private bool ValidateCarDeviceConnection2() {

            string regxIp = "^[0-9]+\\.[0-9]+\\.[0-9]+\\.[0-9]+$";
            string regxNum = "^[0-9]+$";

            if (RbDoorDeviceTCP2.Checked) {
                if (!Regex.IsMatch(TxtDoorDeviceIPAddress2.Text, regxIp)) {
                    MessageBox.Show(this, "O endereço IP introduzido é inválido, introduza correctamente");
                    tabDoorDevices.SelectedIndex = 1;
                    TxtDoorDeviceIPAddress2.Focus();
                    return false;
                }
                if (!Regex.IsMatch(TxtDoorDeviceIpPort2.Text, regxNum)) {
                    MessageBox.Show(this, "O numero da porta introduzido é inválido, introduza correctamente");
                    tabDoorDevices.SelectedIndex = 1;
                    TxtDoorDeviceIpPort2.Focus();
                    return false;
                }
            }

            if (RbDoorDeviceRS2.Checked) {
                if (CBoxDoorDeviceComPort2.SelectedIndex == -1) {
                    MessageBox.Show(this, "Selecione a porta COM");
                    tabDoorDevices.SelectedIndex = 1;
                    CBoxDoorDeviceComPort2.Focus();
                    return false;
                }
                if (CBoxDoorDeviceBaudRate2.SelectedIndex == -1) {
                    MessageBox.Show(this, "Selecione a taxa de transferência(Baud Rate)");
                    tabDoorDevices.SelectedIndex = 1;
                    CBoxDoorDeviceBaudRate2.Focus();
                    return false;
                }
            }

            return true;
        }              

        private void btDelAllUserClock_Click(object sender, EventArgs e) {

            if (CBoxConnectedDevices.Items.Count == 0) {
                MessageBox.Show(this, "Não exitesm dispositivos conectados no momento!");
                CBoxConnectedDevices.Focus();
                return;
            }

            if (CBoxConnectedDevices.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione um dos dispositivos conectados!");
                CBoxConnectedDevices.Focus();
                return;
            }

            Device device = CBoxConnectedDevices.SelectedItem as Device;
            
            DeleteAllUserClocksOnDevice(device);
            
        }

        private void DeleteAllUserClocksOnDevice(Device device) {

            if (device.Connected == false) {
                MessageBox.Show(this, "O biométrico não esta conectado, conecte-o para poder apagar os registos de entradas");
                return;
            }

            DialogResult result = MessageBox.Show(this, "Deseja apagar os registos de picagens que estão no biométrico?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.No) {
                return;
            }

            DeviceIO io = new DeviceIO(device);

            OnExecuteDialog background = new OnExecuteDialog("Apagar registos...", "Apagando registos de picagens do biométrico...");
            bool erased = false;

            background.OnExecute += delegate() {
                erased = io.DeleteAllAttendaceData();
            };

            background.OnPostExecute += delegate() {
                if (erased == true) {
                    MessageBox.Show(this, "Os registos de picagens foram apagados com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    MessageBox.Show(this, "Não foi possivel apagar os registos de picagens", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            background.StartExecute();
        }

        /*
        private void BtnAddLocal_Click(object sender, EventArgs e) {
            AddLocal();
        }

        private void AddLocal() {
            LocalAdd localAdd = new LocalAdd();

            localAdd.ShowDialog(this);

            LoadDevicesToTree();
        }


        private void BtnLocalCancelUpdate_Click(object sender, EventArgs e) {
            DisableLocalDevice();
        }

        private void BtnSaveLocal_Click(object sender, EventArgs e) {
            UpdateLocalDevice();
        }

        private void UpdateLocalDevice() {
            if (!ValidarLocal()) {
                return;
            }

            if (!ValidateLocalDevice()) {
                return;
            }

            string localName = TxtLocalNome.Text;
            string localEndereco = TxtLocalEndereco.Text;
            string localDescricao = TxtLocalDescricao.Text;
            Device localDevice = (Device)CBoxLocalDevices.SelectedItem;
            Parceiro localParceiro = CBoxLocalParceiros.SelectedItem as Parceiro;
            LocalCategoria localCategoria = CBoxLocalCategorias.SelectedItem as LocalCategoria;

            string devName = TxtLocalDeviceName.Text;
            string devSN = TxtLocalDeviceSerialNumber.Text;
            int devConnectionType = (RbLocalDeviceTCP.Checked) ? 0 : ((RbLocalDeviceRS.Checked) ? 1 : 2);
            string devIpAddress = TxtLocalDeviceIPAddress.Text;
            int devPort = Convert.ToInt32(TxtLocalDeviceIpPort.Text);
            int devComPort = this.CBoxLocalDeviceComPort.SelectedIndex + 1;
            int devBaudRate = Convert.ToInt32(this.CBoxLocalDeviceBaudRate.SelectedItem.ToString());

            //verificar se existe um outro local com o novo nome
            Local local = context.Locais.FirstOrDefault(lc => lc.Id != SelectedLocal.Id && lc.Nome == localName);

            if (local != null) {
                MessageBox.Show(this, "Já existe um local com o nome (" + localName + "), introduza outro por favor!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtLocalNome.Focus();
                return;
            }

            //verificar se existe um outro device com o novo nome
            Device dev = context.Device.FirstOrDefault(d => d.Id != localDevice.Id && d.Name == devName);

            if (dev != null) {
                MessageBox.Show(this, "Já existe um dispositivo biométrico com o nome (" + devName + "), introduza outro por favor!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtLocalDeviceName.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show(this, "Tem certeza que deseja atualizar os dados do local " + localName + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            SelectedLocal.Nome = localName;
            SelectedLocal.Endereco = localEndereco;
            SelectedLocal.Descricao = localDescricao;
            SelectedLocal.RegisteredDevice = localDevice;
            SelectedLocal.Proprietario = localParceiro;
            SelectedLocal.Categoria = localCategoria;
            SelectedLocal.UpdatedBy = SystemManager.GetCurrentUser(context);
            SelectedLocal.UpdatedDate = DateTime.Now;

            localDevice.Name = devName;
            localDevice.ConnectionType = devConnectionType;
            localDevice.IpAddress = devIpAddress;
            localDevice.Port = devPort;
            localDevice.ComPort = devComPort;
            localDevice.BaudRate = devBaudRate;
            localDevice.UpdatedBy = SystemManager.GetCurrentUser(context);
            localDevice.UpdatedDate = DateTime.Now;

            if (CBoxLocalDeviceServico.SelectedIndex != -1) {
                localDevice.ServicoCartao = CBoxLocalDeviceServico.SelectedItem as ServicoCartao;
            }


            try {
                context.SaveChanges();
                MessageBox.Show(this, "O local e biometrico foram atualizados com sucesso");

                Local temp = SelectedLocal;
                LoadDevicesToTree();
                OnSelectLocal(temp);

            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar atualizar o local na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar atualizar o local na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidarLocal() {
            if (TxtLocalNome.Text == "") {
                MessageBox.Show(this, "Introduza o nome do local, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtLocalNome.Focus();
                return false;
            }

            if (CBoxLocalParceiros.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione o proprietário do Local, por favor!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CBoxLocalParceiros.Focus();
                return false;
            }

            if (CBoxLocalCategorias.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione a categoria do Local, por favor!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CBoxLocalCategorias.Focus();
                return false;
            }

            if (TxtLocalEndereco.Text == "") {
                MessageBox.Show(this, "Introduza o endereço do local, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtLocalEndereco.Focus();
                return false;
            }
                    
            if (TxtLocalDescricao.Text == "") {
                MessageBox.Show(this, "Introduza o nome, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtLocalDescricao.Focus();
                return false;
            }

            if (CBoxLocalDevices.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione um dispositivo biométrico ou clique em (Adicionar biometrico) para adicionar um dispositivo!, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CBoxLocalDevices.Focus();
                return false;
            }

            return true;
        }
*/
        private bool ValidateLocalDevice() {
            if (TxtLocalDeviceName.Text == "") {
                MessageBox.Show(this, "Introduza o nome do biométrico");
                TxtLocalDeviceName.Focus();
                return false;
            }

            if (!ValidateLocalDeviceConnection()) {
                return false;
            }

            if (TxtLocalDeviceSerialNumber.Text == "") {
                MessageBox.Show(this, "Número de serie invalido!\nPara obter o número de serie, conecte o dispositivo e clique em (Testar conexão).");
                return false;
            }

            if (CBoxLocalDeviceServico.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione o serviço associado ao biometrico!");
                CBoxLocalDeviceServico.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateLocalDeviceConnection() {

            string regxIp = "^[0-9]+\\.[0-9]+\\.[0-9]+\\.[0-9]+$";
            string regxNum = "^[0-9]+$";

            if (RbLocalDeviceTCP.Checked) {
                if (!Regex.IsMatch(TxtLocalDeviceIPAddress.Text, regxIp)) {
                    MessageBox.Show(this, "O endereço IP introduzido é inválido, introduza correctamente");
                    TxtLocalDeviceIPAddress.Focus();
                    return false;
                }
                if (!Regex.IsMatch(TxtLocalDeviceIpPort.Text, regxNum)) {
                    MessageBox.Show(this, "O numero da porta introduzido é inválido, introduza correctamente");
                    TxtLocalDeviceIpPort.Focus();
                    return false;
                }
            }

            if (RbLocalDeviceRS.Checked) {
                if (CBoxLocalDeviceComPort.SelectedIndex == -1) {
                    MessageBox.Show(this, "Selecione a porta COM");
                    CBoxLocalDeviceComPort.Focus();
                    return false;
                }
                if (CBoxLocalDeviceBaudRate.SelectedIndex == -1) {
                    MessageBox.Show(this, "Selecione a taxa de transferência(Baud Rate)");
                    CBoxLocalDeviceBaudRate.Focus();
                    return false;
                }
            }

            return true;
        }

        private void UpdateUnlocatedDevice() {
            if (!ValidateUnlocatedDevice()) {
                return;
            }

            string devName = TxtDeviceName.Text;
            DeviceType devType = CBoxDeviceType.SelectedItem as DeviceType;
            string devSN = TxtDeviceSerialNumber.Text;
            int devConnectionType = (RbDeviceTCP.Checked) ? 0 : ((RbDeviceRS.Checked) ? 1 : 2);
            string devIpAddress = TxtDeviceIPAddress.Text;
            int devPort = Convert.ToInt32(TxtDeviceIpPort.Text);
            int devComPort = this.CBoxDeviceComPort.SelectedIndex + 1;
            int devBaudRate = Convert.ToInt32(this.CBoxDeviceBaudRate.SelectedItem.ToString());

            //verificar se existe um outro device com o novo nome
            Device dev = context.Device.FirstOrDefault(d => d.Id != SelectedUnlocatedDevice.Id && d.Name == devName);

            if (dev != null) {
                MessageBox.Show(this, "Já existe um dispositivo biométrico com o nome (" + devName + "), introduza outro por favor!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtDeviceName.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show(this, "Tem certeza que deseja atualizar os dados do biometrico " + devName + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            Device device = SelectedUnlocatedDevice;

            device.Name = devName;
            device.DeviceType = devType;
            device.ConnectionType = devConnectionType;
            device.IpAddress = devIpAddress;
            device.Port = devPort;
            device.ComPort = devComPort;
            device.BaudRate = devBaudRate;
            device.UpdatedBy = SystemManager.GetCurrentUser(context);
            device.UpdatedDate = DateTime.Now;
                        

            try {
                context.SaveChanges();
                MessageBox.Show(this, "O biometrico foi atualizado com sucesso");
            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar atualizar o biometrico na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar atualizar o biometrico na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidateUnlocatedDevice() {
            if (TxtDeviceName.Text == "") {
                MessageBox.Show(this, "Introduza o nome do biométrico");
                TxtDeviceName.Focus();
                return false;
            }

            if (CBoxDeviceType.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione o tipo de dispositivo biometrico!");
                CBoxDeviceType.Focus();
                return false;
            }

            if (!ValidateUnlocatedDeviceConnection()) {
                return false;
            }

            if (TxtDeviceSerialNumber.Text == "") {
                MessageBox.Show(this, "Número de serie invalido!\nPara obter o número de serie, conecte o dispositivo e clique em (Testar conexão).");
                return false;
            }                        

            return true;
        }

        private bool ValidateUnlocatedDeviceConnection() {

            string regxIp = "^[0-9]+\\.[0-9]+\\.[0-9]+\\.[0-9]+$";
            string regxNum = "^[0-9]+$";

            if (RbDeviceTCP.Checked) {
                if (!Regex.IsMatch(TxtDeviceIPAddress.Text, regxIp)) {
                    MessageBox.Show(this, "O endereço IP introduzido é inválido, introduza correctamente");
                    TxtDeviceIPAddress.Focus();
                    return false;
                }
                if (!Regex.IsMatch(TxtDeviceIpPort.Text, regxNum)) {
                    MessageBox.Show(this, "O numero da porta introduzido é inválido, introduza correctamente");
                    TxtDeviceIpPort.Focus();
                    return false;
                }
            }

            if (RbDeviceRS.Checked) {
                if (CBoxDeviceComPort.SelectedIndex == -1) {
                    MessageBox.Show(this, "Selecione a porta COM");
                    CBoxDeviceComPort.Focus();
                    return false;
                }
                if (CBoxDeviceBaudRate.SelectedIndex == -1) {
                    MessageBox.Show(this, "Selecione a taxa de transferência(Baud Rate)");
                    CBoxDeviceBaudRate.Focus();
                    return false;
                }
            }

            return true;
        }

        private void CBoxLocalDevices_SelectedIndexChanged(object sender, EventArgs e) {
            if (CBoxLocalDevices.Enabled) {
                SelectedLocalDeviceChanged();
            }
        }

        private void SelectedLocalDeviceChanged() {
            if (CBoxLocalDevices.SelectedIndex == -1) {
                return;
            }

            Device device = (Device)CBoxLocalDevices.SelectedItem;

            ShowLocalDevice(device);
        }

        private void BtnDeviceCancelUpdate_Click(object sender, EventArgs e) {
            DisableUnlocatedDevice();
        }

        private void BtnSaveDevice_Click(object sender, EventArgs e) {
            UpdateUnlocatedDevice();
        }

        private void BtnRemoveCar_Click(object sender, EventArgs e) {
            RemoveDoor();
        }

        private void RemoveDoor() {
            if (SelectedDoor == null) {
                MessageBox.Show(this, "Selecione uma porta!");
                return;
            }

            DialogResult dr = MessageBox.Show(this, "Tem certeza que deseja remover a Porta (" + SelectedDoor.Name + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            try {
                context.Door.Remove(SelectedDoor);
                context.SaveChanges();
                MessageBox.Show(this, "A porta foi removida com sucesso!");
                LoadDevicesToTree();
            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar remover o Porta na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar remover o Porta na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRemoveDevice_Click(object sender, EventArgs e) {
            RemoveDevice();
        }

        private void RemoveDevice() {
            if (SelectedUnlocatedDevice == null) {
                MessageBox.Show(this, "Selecione um dispositivo não alocado!");
                return;
            }

            string message = "Ao remover o dispositivo, serão removidos todos registos de picagens, e seus dependentes!" + Environment.NewLine;

            DialogResult dr = MessageBox.Show(message + "Tem certeza que deseja remover o Dispositivo ( \"" + SelectedUnlocatedDevice.Name + "\")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            try {
                context.Device.Remove(SelectedUnlocatedDevice);
                context.SaveChanges();
                MessageBox.Show(this, "O Dispositivo biométrico foi removido do sistema com sucesso!");

                LoadDevicesToTree();

            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar remover o Dispositivo biométrico na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar remover o Dispositivo biométrico na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
        private void BtnRemoveLocal_Click(object sender, EventArgs e) {
            RemoveLocal();
        }

        private void RemoveLocal() {
            if (SelectedLocal == null) {
                MessageBox.Show(this, "Selecione um local, por favor!");
                return;
            }

            DialogResult dr = MessageBox.Show(this, "Tem certeza que deseja remover o Local (" + SelectedLocal.Nome + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            try {
                context.Locais.Remove(SelectedLocal);
                context.SaveChanges();
                MessageBox.Show(this, "O Local foi removido com sucesso!");
                LoadDevicesToTree();
            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar remover o Local na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar remover o Local na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */

        private void RBtnDoor_OneDevice_CheckedChanged(object sender, EventArgs e) {
            OnSelectedDoorType();
        }

        private void OnSelectedDoorType() {
            if (RBtnDoor_OneDevice.Checked) {
                //PicDoorOneDevice.BackColor = Color.LightSkyBlue;
                //PicDoorTwoDevices.BackColor = Color.Transparent;

                LabelDoorDevice1.Enabled = true;
                LabelDoorDevice1.Text = "Biométrico único (Entrada/Saida)";
                CBoxDoorDevice1.Enabled = true;
                tabPageDoorDevice1.Text = "Biométrico único (Entrada/Saida)";

                CBoxDoorDeviceType1.SelectedItem = context.DeviceType.FirstOrDefault(t => t.TypeNumber == DeviceType.TYPE_IN_OUT);
                CBoxDoorDeviceType1.Enabled = false;

                LabelDoorDevice2.Enabled = false;
                LabelDoorDevice2.Text = "Biométrico 2 (Saida)";
                CBoxDoorDevice2.Enabled = false;

                tabDoorDevices.TabPages.Remove(tabPageDoorDevice2);

            } else {

                //PicDoorOneDevice.BackColor = Color.Transparent;
                //PicDoorTwoDevices.BackColor = Color.LightSkyBlue;

                LabelDoorDevice1.Enabled = true;
                LabelDoorDevice1.Text = "Biométrico 1 (Entrada)";
                CBoxDoorDevice1.Enabled = true;
                tabPageDoorDevice1.Text = "Biométrico 1 (Entrada)";

                CBoxDoorDeviceType1.SelectedItem = context.DeviceType.FirstOrDefault(t => t.TypeNumber == DeviceType.TYPE_IN);
                CBoxDoorDeviceType1.Enabled = false;

                LabelDevice2.Enabled = true;
                LabelDevice2.Text = "Biométrico 2 (Saida)";
                CBoxDoorDevice2.Enabled = true;
                tabPageDoorDevice2.Text = "Biométrico 2 (Saida)";

                CBoxDoorDeviceType2.SelectedItem = context.DeviceType.FirstOrDefault(t => t.TypeNumber == DeviceType.TYPE_OUT);
                CBoxDoorDeviceType2.Enabled = false;

                if (!tabDoorDevices.TabPages.Contains(tabPageDoorDevice2)) {
                    tabDoorDevices.TabPages.Insert(1, tabPageDoorDevice2);
                }
            }
        }

        private void CBoxDoorDevice1_SelectedIndexChanged(object sender, EventArgs e) {

            if (CBoxDoorDevice1.SelectedItem is Device) {                
                Device device = CBoxDoorDevice1.SelectedItem as Device;
                ShowDoorDevice1(device);
            }

        }

        private void CBoxDoorDevice2_SelectedIndexChanged(object sender, EventArgs e) {
            
            if (CBoxDoorDevice2.SelectedItem is Device) {
                Device device = CBoxDoorDevice2.SelectedItem as Device;
                ShowDoorDevice2(device);
            }

        }

    }
}
