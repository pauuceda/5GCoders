using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

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

        Connection.SQLConnection bd = new Connection.SQLConnection();
        DataSet dts = new DataSet();
        string consulta;

        private void PerfilUsuari_Load(object sender, EventArgs e)
        {
            consulta = "SELECT USERNAME, LOGIN, PHOTO FROM USERS WHERE IDUSER = " + ID;
            dts = bd.PortarTaula(consulta);

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