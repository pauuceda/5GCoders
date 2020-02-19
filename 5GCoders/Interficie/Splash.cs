using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interficie
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        //EVENT TIMER
        private void progres_Tick(object sender, EventArgs e)
        {
            progress.PerformStep();
            percent.Text = progress.Value.ToString() + '%';
            //ATURAR EL TIMER I REALITZAR LES SEGÜENTS COMANDES QUAN LA BARRA DE PROGRÉS ARRIBI AL SEU MÀXIMS
            if (progress.Value == progress.Maximum)
            {
                progres.Stop();
                this.Hide();

                Login L = new Login();
                L.Show();
            }
        }
    }
}
