using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace CustomControls
{
    public partial class OpcionsMenu : UserControl
    {
        public OpcionsMenu()
        {
            InitializeComponent();
        }

        private string _NomFormulari;

        public string NomFormulari
        {
            get { return _NomFormulari; }
            set { _NomFormulari = value; }
        }

        private string _Descripcio;

        public string Descripcio
        {
            get { return _Descripcio; }
            set { _Descripcio = value; }
        }

        private string _DLL;

        public string DLL
        {
            get { return _DLL; }
            set { _DLL = value; }
        }

        private string _imatgeOpcio;

        public string imatgeOpcio
        {
            get { return _imatgeOpcio; }
            set { _imatgeOpcio = value; }
        }

        private string _Rang;

        public string Rang
        {
            get { return _Rang; }
            set { _Rang = value; }
        }

        private void OpcionsMenu_Load(object sender, EventArgs e)
        {
            taulaForms.Text = Descripcio;
            Imatge.ImageLocation = "../Resources/" + imatgeOpcio;
        }

        private void Imatge_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                obrirForm();
            }
        }

        private void taulaForms_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                obrirForm();
            }
        }
        
        private void groupBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                obrirForm();
            }
        }

        private void obrirForm()
        {
            bool FormObert = true;
            string nomForm = Descripcio;

            foreach (Form formulari in Application.OpenForms)
            {
                if (formulari.Name == nomForm)
                {
                    formulari.BringToFront();
                }
                else
                {
                    FormObert = false;
                }
            }

            if (!FormObert)
            {
                try
                {
                    Assembly ensamblat = Assembly.LoadFrom("../DLL/" + DLL + ".dll");
                    Object Formulari;
                    Type tipus;
                    tipus = ensamblat.GetType(DLL + "." + NomFormulari);
                    Formulari = Activator.CreateInstance(tipus);
                    ((Form)Formulari).TopLevel = false;

                    foreach (Panel panel in this.Parent.Parent.Parent.Controls)
                    {
                        if (panel.Name == "PanelDGV")
                        {
                            panel.Controls.Add((Form)Formulari);
                            ((Form)Formulari).Show();
                            ((Form)Formulari).BringToFront();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Opció deshabilitada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}