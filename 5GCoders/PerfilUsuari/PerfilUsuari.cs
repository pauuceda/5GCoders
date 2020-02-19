using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PerfilUsuari
{
    public partial class PerfilUsuari : Form
    {

        string ID;

        public PerfilUsuari(string IDUsuari)
        {
            InitializeComponent();
            ID = IDUsuari;
        }

        SQLConnection.BbddChampions bd = new SQLConnection.BbddChampions();
        DataSet dts = new DataSet();
        string consulta;

        private void PerfilUsuari_Load(object sender, EventArgs e)
        {
            consulta = "SELECT USERNAME, LOGIN, PHOTO FROM USERS WHERE IDUSER = " + ID;
            dts = bd.PortarPerConsulta(consulta);

            Nom.Text = dts.Tables[0].Rows[0][0].ToString();
            userName.Text = "@" + dts.Tables[0].Rows[0][1].ToString();

            if (File.Exists(Path.GetFullPath("../Resources/" + dts.Tables[0].Rows[0][2].ToString()))) {
                fotoPerfil.ImageLocation = "../Resources/" + dts.Tables[0].Rows[0][2].ToString();
            }
            else
            {
                fotoPerfil.ImageLocation = "../Resources/Usuari.png";
            }
        }
    }
}