using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PACSPlanet;
using PACSSpaceship;

namespace PACSGeneral
{
    public partial class PACS : Form
    {
        public PACS()
        {
            InitializeComponent();
        }

        private void PACS_Load(object sender, EventArgs e)
        {
            Planet P = new Planet();
            Spaceship S = new Spaceship();

            P.TopLevel = false;
            S.TopLevel = false;
            PanelPlanet.Controls.Add(P);
            PanelSpaceship.Controls.Add(S);
            P.Show();
            S.Show();
            P.BringToFront();
            S.BringToFront();
        }
    }
}
