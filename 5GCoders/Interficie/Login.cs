using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encriptacio;

namespace Interficie
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Entrar();
        }

        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                Entrar();
            }
        }

        private void pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                Entrar();
            }
        }

        DataSet dts;
        SQLConnection.BbddChampions bd = new SQLConnection.BbddChampions();
        string consulta;
        //FUNCIÓ PER COMPROVAR QUE L'USUARI I LA CONTRASENYA COINCIDEIXEN EN UN ÚNIC REGISTRE DINS DE LA BASE DE DADES
        public void Entrar()
        {
            Encriptar E = new Encriptar();

            string contrasenyaEncriptada = "";

            consulta = "SELECT IDUSER, PASSWORD " +
                        "FROM USERS " +
                        "WHERE LOGIN = '" + textb_user.Text + "'";

            dts = bd.PortarPerConsulta(consulta);

            if (dts.Tables[0].Rows.Count == 1)
            {
                contrasenyaEncriptada = E.GenerarHash(textb_pass.Text.Trim());

                if (dts.Tables[0].Rows[0][1].ToString() == contrasenyaEncriptada)
                {
                    consulta = "SELECT USERS.IDUSER, USERS.USERNAME, USERS.LOGIN, USERS.PASSWORD, USERS.PHOTO, USERCATEGORIES.ACCESSLEVEL " +
                               "FROM USERS, USERCATEGORIES " +
                               "WHERE USERCATEGORIES.IDUSERCATEGORY = USERS.IDUSERCATEGORY AND USERS.IDUSER = " + dts.Tables[0].Rows[0][0];

                    dts = bd.PortarPerConsulta(consulta);

                    Menu M = new Menu(dts.Tables[0].Rows[0][0].ToString(), dts.Tables[0].Rows[0][1].ToString(), dts.Tables[0].Rows[0][2].ToString(), dts.Tables[0].Rows[0][4].ToString(), dts.Tables[0].Rows[0][5].ToString());

                    this.Hide();
                    M.Show();
                }
                else
                {
                    errorValidacio.Visible = true;
                }
            }
            else
            {
                errorValidacio.Visible = true;
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tancarAplicacio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                textb_pass.UseSystemPasswordChar = false;
            }
            else
            {
                textb_pass.UseSystemPasswordChar = true;
            }
        }

        private void tancarAplicacio_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Application.Exit();
            }
        }

        private void RegisterLabel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Register R = new Register();

                R.ShowDialog();
            }
        }
    }
}
