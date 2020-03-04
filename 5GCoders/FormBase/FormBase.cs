using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
using Encriptacio;
using Connection;

namespace Prova
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        Encriptar E = new Encriptar();
        SQLConnection bd = new SQLConnection();
        DataSet dts;
        DataRow dr;

        bool nouRegistre = false;
        string query;

        private string _Taula;

        public string Taula
        {
            get { return _Taula; }
            set { _Taula = value; }
        }

        private string _CampBusqueda;

        public string CampBusqueda
        {
            get { return _CampBusqueda; }
            set { _CampBusqueda = value; }
        }

        private void FormBase_Load(object sender, EventArgs e)
        {
            CarregarDades();
            BindejarDades();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            NetejarBindejos();
            dr = dts.Tables[0].NewRow();
            //INICIALITZAR ELS TEXTBOX RELACIONATS AMB COMBOBOX (FORÀNIES) A 1 PER EVITAR QUE ES QUEDIN BUITS
            foreach (Control ctrl in PanelEdicion.Controls)
            {
                if (ctrl.GetType() == typeof(SWTextBox))
                {
                    if (((SWTextBox)ctrl).EsForania)
                    {
                        ((SWTextBox)ctrl).Text = "1";
                    }
                }
            }

            SWSearch.Enabled = false;
            CancelButton.Visible = true;
            InsertButton.Visible = true;
            NewButton.Visible = false;
            UpdateButton.Visible = false;
            nouRegistre = true;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            bd.Actualitzar(dts, query);
            CarregarDades();
            BindejarDades();

            MessageBox.Show("Dades actualitzades", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            BindejarDades();

            SWSearch.Enabled = true;
            CancelButton.Visible = false;
            InsertButton.Visible = false;
            NewButton.Visible = true;
            UpdateButton.Visible = true;
            nouRegistre = false;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            //OMPLIR ELS VALORS DEL DATAROW CREAT ANTERIORMENT AMB EL SEU CORRESPONENT TEXTBOX
            foreach (Control ctrl in PanelEdicion.Controls)
            {
                if (ctrl.GetType() == typeof(SWTextBox) && !ctrl.Name.Equals("SWSearch"))
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
            dts.Tables[0].Rows.Add(dr);

            bd.Actualitzar(dts, query);
            CarregarDades();
            BindejarDades();

            MessageBox.Show("Registre afegit", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SWSearch.Enabled = true;
            CancelButton.Visible = false;
            InsertButton.Visible = false;
            NewButton.Visible = true;
            UpdateButton.Visible = true;
            nouRegistre = false;
        }
        //OMPLIR EL DATASET AMB LES DADES DE LA CONSULTA
        private void CarregarDades()
        {
            try
            {
                query = "SELECT * FROM " + Taula;
                dts = bd.PortarTaula(query);
                DGV.DataSource = dts.Tables[0];

                DGV.Columns[0].Visible = false;
            }
            catch (Exception)
            {
                
            }
        }
        
        private void BindejarDades()
        {
            foreach (Control ctrl in PanelEdicion.Controls)
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
                        ctrl.Validated += new EventHandler(ValidarCanvis);
                    }
                }
            }
        }
        //NETEJAR BINDEJOS PER PODER AFEGIR UN NOU REGISTRE
        private void NetejarBindejos()
        {
            foreach (Control ctrl in PanelEdicion.Controls)
            {
                if (ctrl.GetType() == typeof(SWTextBox) && !ctrl.Name.Equals("SWSearch"))
                {
                    ctrl.DataBindings.Clear();
                    ctrl.Text = null;
                }
            }
        }
        //FUNCIÓ PER VALIDAR ELS CANVIS DELS COMBOBOX I DELS TEXTBOX
        private void ValidarCanvis(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(SWTextBox))
            {
                if (((SWTextBox)sender).Name == "SWPassword")
                {
                    ((SWTextBox)sender).Text = E.EncriptarContrasenya(((SWTextBox)sender).Text);
                }
            }

            if (!nouRegistre)
            {
                if (sender.GetType() == typeof(SWComboFK))
                {
                    foreach (Control ctrl in PanelEdicion.Controls)
                    {
                        if (ctrl.GetType() == typeof(SWTextBox) && !ctrl.Name.Equals("SWSearch"))
                        {
                            if (((SWTextBox)ctrl).controlID == ((SWComboFK)sender).Name)
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
                    }
                }

                try
                {
                    ((SWTextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
                }
                catch (Exception)
                {
                        
                }
            }
        }
        //FILTRAR EL RESULTAT DE LA CONSULTA DINS DEL PROPI DATASET
        private void SWSearch_TextChanged(object sender, EventArgs e)
        {
            string search = SWSearch.Text;
            string query =  CampBusqueda + " LIKE '%" + search + "%'";

            dts.Tables[0].DefaultView.RowFilter = query;
            DGV.DataSource = dts.Tables[0];
        }
    }
}
