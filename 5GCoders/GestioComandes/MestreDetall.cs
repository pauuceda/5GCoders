using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORM;
using Prova;
using CustomControls;
using SQLConnection;

namespace GestioComandes
{
    public partial class MestreDetall : Form
    {
        SQLConnection.BbddChampions bd = new SQLConnection.BbddChampions();
        DataSet dtsOrders, dtsDetails;
        DataRow dr;

        string query;
        bool nouRegistre;

        public MestreDetall()
        {
            
            InitializeComponent();
            Refresh();
        }
        private void CarregarDades()
        {
            try
            {
                query = "SELECT * FROM ORDERS";
                dtsOrders = bd.PortarPerConsulta(query);
                DGVMestre.DataSource = dtsOrders.Tables[0];

                query = "SELECT * FROM ORDERSDETAIL";
                dtsDetails = bd.PortarPerConsulta(query);
                DGVDetall.DataSource = dtsDetails.Tables[0];
            }
            catch (Exception)
            {

            }
        }

        private void MestreDetall_Load(object sender, EventArgs e)
        {
            CarregarDades();
            BindejarDades(PanelOrder, dtsOrders);
            BindejarDades(PanelDetails, dtsDetails);
        }

        private void BindejarDades(Panel panel, DataSet dts)
        {
            foreach (Control ctrl in panel.Controls )
            {
                if (ctrl.GetType() == typeof(SWComboFK))
                {
                    //CARREGAR COMBOBOX AMD DADES I AFEGIR-LI UNA FUNCIÓ PER VALIDAR ELS CANVIS A L'EVENT DE CANVI D'ÍTEM
                    ((SWComboFK)ctrl).carregaDades();
                    ((SWComboFK)ctrl).SelectedIndexChanged += new EventHandler(ValidarCanvis);
                }
                else if (ctrl.GetType() == typeof(SWTextBox) && !ctrl.Name.Equals("SWSearch"))
                {
                    //NETEJAR BINDEJOS I AFEGIR-LI ELS NOUS
                    ctrl.DataBindings.Clear();
                    ctrl.DataBindings.Add("Text", dts.Tables[0], ((SWTextBox)ctrl).NomCamp);

                    if (!nouRegistre)
                    {
                        ctrl.TextChanged += new EventHandler(ValidarCanvis);
                        ctrl.Validated += new EventHandler(ValidarCanvis);
                    }
                }
            }
        }

        private void NetejarBindejos(Panel panel)
        {
            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl.GetType() == typeof(SWTextBox) && !ctrl.Name.Equals("SWSearch"))
                {
                    ctrl.DataBindings.Clear();
                    ctrl.Text = null;
                }
            }
        }

        private void UpdateOrder_Click(object sender, EventArgs e)
        {
            CarregarDades();
            BindejarDades(PanelOrder, dtsOrders);
            BindejarDades(PanelDetails, dtsDetails);
        }

        private void NewOrder_Click(object sender, EventArgs e)
        {
            NewOrder.Visible = false;
            UpdateOrder.Visible = false;
            CancelOrder.Visible = true;
            InsertOrder.Visible = true;

            NetejarBindejos(PanelOrder);

            dr = dtsOrders.Tables[0].NewRow();
            //INICIALITZAR ELS TEXTBOX RELACIONATS AMB COMBOBOX (FORÀNIES) A 1 PER EVITAR QUE ES QUEDIN BUITS
            foreach (Control ctrl in PanelOrder.Controls)
            {
                if (ctrl.GetType() == typeof(SWTextBox))
                {
                    if (((SWTextBox)ctrl).EsForania)
                    {
                        ((SWTextBox)ctrl).Text = "1";
                    }
                }
            }
        }

        private void InsertOrder_Click(object sender, EventArgs e)
        {
            NewOrder.Visible = true;
            UpdateOrder.Visible = true;
            CancelOrder.Visible = false;
            InsertOrder.Visible = false;

            foreach (Control ctrl in PanelOrder.Controls)
            {
                if (ctrl.GetType() == typeof(SWTextBox))
                {
                    try
                    {
                        dr[((SWTextBox)ctrl).NomCamp] = ctrl.Text;
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            //AFEGIR FILA AL DATASET
            dtsOrders.Tables[0].Rows.Add(dr);

            bd.Actualitzar(query, dtsOrders);
            CarregarDades();
            BindejarDades(PanelOrder, dtsOrders);

            MessageBox.Show("Registre afegit", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CancelOrder_Click(object sender, EventArgs e)
        {
            NewOrder.Visible = true;
            UpdateOrder.Visible = true;
            CancelOrder.Visible = false;
            InsertOrder.Visible = false;

            CarregarDades();
            BindejarDades(PanelOrder, dtsOrders);
            //BindejarDades(PanelDetails, dtsDetails);
        }

        //FUNCIÓ PER VALIDAR ELS CANVIS DELS COMBOBOX I DELS TEXTBOX
        private void ValidarCanvis(object sender, EventArgs e)
        {
            if (!nouRegistre)
            {
                if (sender.GetType() == typeof(SWComboFK))
                {
                    foreach (Control ctrl in PanelOrder.Controls)
                    {
                        try
                        {
                            ((SWTextBox)ctrl).DataBindings[0].BindingManagerBase.EndCurrentEdit();
                        }
                        catch (Exception)
                        {

                        }
                    }

                    foreach (Control ctrl in PanelDetails.Controls)
                    {
                        try
                        {
                            ((SWTextBox)ctrl).DataBindings[0].BindingManagerBase.EndCurrentEdit();
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
                else if (sender.GetType() == typeof(SWTextBox))
                {
                    try
                    {
                        ((SWTextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }
    }
    
}
