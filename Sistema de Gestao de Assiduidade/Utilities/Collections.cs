using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.model.ca;
using System.Globalization;
using System.Drawing;
using mz.betainteractive.sigeas.settings;
using mz.betainteractive.sigeas.Models.Entities;

namespace mz.betainteractive.sigeas.utilities {
    
    public class ObjectItem{
        public Object Value;
        private String name;

        public ObjectItem(Object o, String name) {
            this.Value = o;
            this.name = name;
        }

        public override string ToString() {
            return this.name;
        }
    }

    public class TreeNodeDevice : TreeNode{
        public Device Value;

        public TreeNodeDevice(Device device) {
            this.Value = device;
            this.Text = device.Name;
        }

        public override string ToString() {
            return base.ToString();
        }
    }

    public class TreeNodeDepartamento : TreeNode {
        public Departamento Value;

        public TreeNodeDepartamento(Departamento departamento) {
            this.Value = departamento;
            this.Text = departamento.Nome;
            this.ImageIndex = 1;
            this.SelectedImageIndex = 1;
        }

        public override string ToString() {
            return base.ToString();
        }
    }

    public class TreeNodeCategoria : TreeNode {
        public Categoria Value;

        public TreeNodeCategoria(Categoria categoria) {
            this.Value = categoria;
            this.Text = categoria.Nome;
            this.ImageIndex = 2;
            this.SelectedImageIndex = 2;
        }

        public override string ToString() {
            return base.ToString();
        }
    }

    public class TreeNodeFuncionario : TreeNode {
        public Funcionario Value;

        public TreeNodeFuncionario(Funcionario funcionario) {
            this.Value = funcionario;
            this.Text = funcionario.Nome+" "+funcionario.Apelido;
            this.ImageIndex = 3;
            this.SelectedImageIndex = 3;
        }

        public override string ToString() {
            return base.ToString();
        }
    }

    public class TreeNodeHorarioSemana : TreeNode {
        public HorarioSemana Value;

        public TreeNodeHorarioSemana(HorarioSemana horarioSemana) {
            this.Value = horarioSemana;
            this.Text = horarioSemana.Descricao;
            this.ImageIndex = 0;
            this.SelectedImageIndex = 0;
        }

        public override string ToString() {
            return base.ToString();
        }
    }

    public class ListViewItemDevice : ListViewItem {
        public Device Value;

        public ListViewItemDevice(Device device) {
            this.Value = device;
            UpdateColumns();
        }

        public void UpdateColumns() {
            this.SubItems.Clear();
            this.Text = Value.Door.ToString();
            this.SubItems.Add(Value.Name);
            this.SubItems.Add(Value.Connected ? "ON" : "OFF");
        }

        public override string ToString() {
            return base.ToString();
        }
    }

    
    public class ListViewItemFerias : ListViewItem {
        public Ferias Value;

        public ListViewItemFerias(Ferias ferias) {
            this.Value = ferias;
            UpdateColumns();
        }

        public void UpdateColumns() {
            String inicio = Value.DataInicial.ToString("d' de 'MMMM' de 'yyyy");
            String fim = Value.DataFinal.ToString("d' de 'MMMM' de 'yyyy");

            TimeSpan tm = Value.DataFinal.Subtract(Value.DataInicial);

            DateTime now = DateTime.Today;
            String estado = "";

            if (Value.DataInicial.CompareTo(now) > 0) {
                estado = "Não compridas";
            } else {
                if (Value.DataFinal.CompareTo(now) <= 0) {
                    estado = "Férias compridas";
                } else {
                    estado = "A cumprir";
                }
            }

            String dias = (tm.Days + 1) + " dias";                     

            this.SubItems.Clear();
            this.Text = inicio;
            this.SubItems.Add(fim);
            this.SubItems.Add(dias);
            this.SubItems.Add(estado);
        }

        public override string ToString() {
            return base.ToString();
        }
    }

    public class ListViewItemFeriado : ListViewItem {
        public Feriado Value;

        public ListViewItemFeriado(Feriado feriado) {
            this.Value = feriado;
            UpdateColumns();
        }

        public void UpdateColumns() {
            String nome = Value.Nome;
            String data = Value.Data.ToString("dd MMMM");

            this.SubItems.Clear();
            this.Text = nome;
            this.SubItems.Add(data);
        }

        public override string ToString() {
            return base.ToString();
        }
    }

    public class ListViewItemUserClock : ListViewItem {
        public UserClock Value;

        public ListViewItemUserClock(UserClock userClock) {
            this.Value = userClock;
            UpdateColumns();                        
        }               

        public void UpdateColumns() {
            this.SubItems.Clear();
            this.Text = (this.Index+1).ToString();
            this.SubItems.Add(Value.Funcionario.Code);
            this.SubItems.Add(Value.Funcionario.ToString());
            this.SubItems.Add(Value.VerifyMode.ToString());
            this.SubItems.Add(Value.DateAndTime.ToString());//"g", DateTimeFormatInfo.InvariantInfo));
            this.SubItems.Add(Value.InOutMode.ToString());
            this.SubItems.Add(Value.CorrectState);
            this.SubItems.Add(Value.Result);

            if (Value.Result == "Invalido") {
                this.BackColor = Color.Lime;
            }
        }

        public override string ToString() {
            return base.ToString();
        }
    }
    /*
    

    public class ListViewGenericItem<T> : ListViewItem {
        public T Value;

        public delegate void SetSubItemsHandler();

        public ListViewGenericItem(T value) {
            this.Value = value;
        }

        public virtual event SetSubItemsHandler SetItems;        
    }

    public class DataGridViewGenericRow<T> : DataGridViewRow
    {
        public T Value;
        public DataGridViewGenericRow(T value) {
            this.Value = value;
        }
    }
    */
    public class EqualityComparerObjectAtt<T> : IEqualityComparer<T>
    {

        #region IEqualityComparer<T> Members

        public bool Equals(T x, T y) {            
            return x.Equals(y);
        }

        public int GetHashCode(T obj) {
            return 0;// obj.GetHashCode();
        }

        #endregion

        #region IEqualityComparer<T> Members

        bool IEqualityComparer<T>.Equals(T x, T y) {
            return x.Equals(y);
        }

        int IEqualityComparer<T>.GetHashCode(T obj) {
            return 0;// obj.GetHashCode();
        }

        #endregion
    }
}
