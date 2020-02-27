using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioUsuaris
{
    public partial class InformeUsuari : Form
    {
        string IDUsuari;

        public InformeUsuari(string ID)
        {
            InitializeComponent();
            IDUsuari = ID;
        }

        private void InformeUsuari_Load(object sender, EventArgs e)
        {
            UsuarisCrystal usuarisCrystal = new UsuarisCrystal();

            usuarisCrystal.SetDatabaseLogon("5GCoders", "12345aA!");

            usuarisCrystal.RecordSelectionFormula = "{Users.idUser} = " + IDUsuari;

            CRViewer.ReportSource = usuarisCrystal;
            CRViewer.Refresh();
            CRViewer.RefreshReport();
        }
    }
}
