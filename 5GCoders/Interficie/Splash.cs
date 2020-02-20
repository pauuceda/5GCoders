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
        int Comptador = 0;

        public Splash()
        {
            InitializeComponent();
        }
        //EVENT TIMER
        private void progres_Tick(object sender, EventArgs e)
        {
            percent.Text = Comptador.ToString() + '%';
            //ATURAR EL TIMER I REALITZAR LES SEGÜENTS COMANDES QUAN LA BARRA DE PROGRÉS ARRIBI AL SEU MÀXIMS
            if (Comptador == 100)
            {
                progres.Stop();
                this.Hide();

                Login L = new Login();
                L.Show();
            }

            Comptador++;
        }
    }
}
