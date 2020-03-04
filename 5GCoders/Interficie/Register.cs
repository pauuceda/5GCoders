using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connection;
using CustomControls;
using Encriptacio;
using System.Data.SqlClient;
using System.Configuration;

namespace Interficie
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        Encriptar E = new Encriptar();
        string consulta, consultaLogins, contrasenyaEncriptada;

        private void Register_Load(object sender, EventArgs e)
        {
            CarregarDades();
            BindejarDades();
        }

        private void CarregarDades()
        {
            try
            {
                SWCategoriaCB.carregaDades();
            }
            catch (Exception)
            {

            }
        }

        private void BindejarDades()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(SWComboFK))
                {
                    ((SWComboFK)ctrl).carregaDades();
                }
                else if (ctrl.GetType() == typeof(SWTextBox))
                {
                    ((SWTextBox)ctrl).TextChanged += new EventHandler(EventContrasenya);
                }
            }
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                SWPassword.UseSystemPasswordChar = false;
                SWRepeatPassword.UseSystemPasswordChar = false;
            }
            else
            {
                SWPassword.UseSystemPasswordChar = true;
                SWRepeatPassword.UseSystemPasswordChar = true;
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (CampsPlens())
            {
                if (ContrasenyesIguals())
                {
                    contrasenyaEncriptada = E.EncriptarContrasenya(SWPassword.Text);

                    consulta = "INSERT INTO USERS(CODEUSER, USERNAME, LOGIN, PASSWORD, IDUSERRANK, IDUSERCATEGORY) " +
                               "VALUES('" + SWCodeUser.Text + "', '" + SWNomUsuari.Text + "', '" + SWLogin.Text + "', '" + contrasenyaEncriptada + "', '" + SWUserRankTB.Text + "', '" + SWCategoriaTB.Text + "')";

                    if (!UserExists(SWLogin.Text))
                    {
                        CrearUsuari(consulta);

                        MessageBox.Show("T'has registrat correctament", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                       MessageBox.Show("L'usuari que has introduït ja existeix", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Has d'omplir tots els camps", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool CampsPlens()
        {
            bool plens = false;

            if (!string.IsNullOrEmpty(SWCodeUser.Text.Trim()) && !string.IsNullOrEmpty(SWNomUsuari.Text.Trim()) && !string.IsNullOrEmpty(SWLogin.Text.Trim()) && !string.IsNullOrEmpty(SWPassword.Text.Trim()) && !string.IsNullOrEmpty(SWRepeatPassword.Text.Trim()))
            {
                plens = true;
            }

            return plens;
        }

        private bool ContrasenyesIguals()
        {
            bool iguals = false;

            if (!string.IsNullOrEmpty(SWPassword.Text.Trim()) && !string.IsNullOrEmpty(SWRepeatPassword.Text.Trim()))
            {
                if (SWPassword.Text.Trim() == SWRepeatPassword.Text.Trim())
                {
                    LabelError.Visible = false;
                    iguals = true;
                }
                else
                {
                    LabelError.Visible = true;
                }
            }

            return iguals;
        }

        private void EventContrasenya(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SWPassword.Text.Trim()) && !string.IsNullOrEmpty(SWRepeatPassword.Text.Trim()))
            {
                if (SWPassword.Text.Trim() == SWRepeatPassword.Text.Trim())
                {
                    LabelError.Visible = false;
                }
                else
                {
                    LabelError.Visible = true;
                }
            }
        }

        private void CrearUsuari(string consulta)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand cmd = new SqlCommand(consulta);

            cmd.Connection = connection;

            connection.ConnectionString = ConfigurationManager.ConnectionStrings["5gcoders"].ConnectionString;

            connection.Open();

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        private void tancarAplicacio_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Close();
            }
        }

        private bool UserExists(string UserLogin)
        {
            SQLConnection bd = new SQLConnection();
            DataSet dts = new DataSet();
            consultaLogins = "SELECT LOGIN FROM USERS";
            bool Exists = false;

            dts = bd.PortarTaula(consultaLogins);

            for (int i = 0; i < dts.Tables[0].Rows.Count - 1; i++)
            {
                if (dts.Tables[0].Rows[i][0].ToString() == UserLogin)
                {
                    Exists = true;
                    break;
                }
            }

            return Exists;
        }
    }
}