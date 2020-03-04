using Connection;
using CustomControls;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Interficie
{
    public partial class Menu : Form
    {
        string ID, User, Nom, AccessLevel, Foto;
        bool formObert = false, primerTick = true, obrint = false;
        //INICIALITZEM LES VARIABLES QUE S'HAN PASSAT DES DEL FORMULARI DEL LOGIN PER PODER UTILITZAR-LES
        public Menu(string IDUsuari, string nomPersona, string nomUser, string Photo, string accessLevel)
        {
            InitializeComponent();
            ID = IDUsuari;
            Nom = nomPersona;
            User = nomUser;
            AccessLevel = accessLevel;
            Foto = Photo;
        }

        private void btnslide_Click(object sender, EventArgs e)
        {
            
        }

        private void decorarOpcions()
        {
            foreach (UserControl ctrl in panelMenu.Controls)
            {
                foreach (GroupBox ctrl2 in ctrl.Controls)
                {
                    foreach (Control ctrl3 in ctrl2.Controls)
                    {
                        if (ctrl3.GetType() == typeof(Label))
                        {
                            if (ctrl3.Visible)
                            {
                                ctrl3.Visible = false;
                            }
                            else
                            {
                                ctrl3.Visible = true;
                            }
                        }
                    }
                }
            }

            if (obrint)
            {
                lbl_name.Visible = true;
                lbl_user.Visible = true;
                MoreOptionsB.Visible = true;
            }
            else
            {
                lbl_name.Visible = false;
                lbl_user.Visible = false;
                MoreOptionsB.Visible = false;
            }
        }
        //ANIMACIÓ DE LES IMATGES DEL MENÚ D'OPCIONS
        private void imatge_Tick(object sender, EventArgs e)
        {
            foreach (UserControl ctrl in panelMenu.Controls)
            {
                foreach (GroupBox groupBox in ctrl.Controls)
                {
                    foreach (Control ctrl3 in groupBox.Controls)
                    {
                        if (ctrl3.GetType() == typeof(PictureBox))
                        {
                            if (!obrint)
                            {
                                ctrl3.Left += 4;
                            }
                            else
                            {
                                ctrl3.Left -= 4;
                            }

                            if (ctrl3.Location == new Point(8, 13) || ctrl3.Location == new Point(40, 13))
                            {
                                imatge.Stop();
                            }
                        }
                    }
                }
            }
        }
        //ANIMACIÓ DEL MENÚ LATERAL D'OPCIONS
        private void swipeMenu_Tick(object sender, EventArgs e)
        {
            if (MenuVertical.Width < 250)
            {
                if (obrint) 
                {
                    FerMenuGran();
                }
                else
                {
                    FerMenuPetit();
                }
            }
            else
            {
                if (!obrint)
                {
                    FerMenuPetit();
                }
                else
                {
                    FerMenuGran();
                }
            }

            if (!primerTick) {
                if (MenuVertical.Width <= 145 || MenuVertical.Width >= 250)
                {
                    swipeMenu.Stop();

                    if (MenuVertical.Width > 250)
                    {
                        MenuVertical.Width = 250;
                    }
                }
            }

            primerTick = false;
        }

        private void FerMenuGran()
        {
            MenuVertical.Width += 14;
            logo.Width += 14;
            profile.Width += 13;

            foreach (UserControl ctrl in panelMenu.Controls)
            {
                foreach (GroupBox groupBox in ctrl.Controls)
                {
                    groupBox.Width += 14;
                }
            }
        }

        private void FerMenuPetit()
        {
            MenuVertical.Width -= 14;
            logo.Width -= 14;
            profile.Width -= 13;

            foreach (UserControl ctrl in panelMenu.Controls)
            {
                foreach (GroupBox groupBox in ctrl.Controls)
                {
                    groupBox.Width -= 20;
                }
            }
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lbl_name.Text = Nom;
            lbl_user.Text = "@" + User.Trim().ToLower();
            moreOptions.Size = new  System.Drawing.Size(0, 0);

            if (File.Exists(Path.GetFullPath("../Resources/" + Foto)))
            {
                img_profile.ImageLocation = "../Resources/" + Foto;
            }
            else
            {
                img_profile.ImageLocation = "../Resources/Usuari.png";
            }

            DataSet dtsMenu;
            SQLConnection bd = new SQLConnection();

            string consulta = "SELECT * FROM FORMS WHERE RANG <= " + Int32.Parse(AccessLevel) + " ORDER BY FORMS.ID DESC;";

            dtsMenu = bd.PortarTaula(consulta);

            foreach (DataRow dr in dtsMenu.Tables[0].Rows)
            {
                OpcionsMenu Opcio = new OpcionsMenu
                {
                    Dock = DockStyle.Top,

                    NomFormulari = dr["NOMFORMULARI"].ToString(),
                    Descripcio = dr["DESCRIPCIO"].ToString(),
                    DLL = dr["DLL"].ToString(),
                    imatgeOpcio = dr["IMG"].ToString(),
                    Rang = dr["RANG"].ToString(),
            };
                
                panelMenu.Controls.Add(Opcio);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        bool obrintOpcions = false;
        bool opcionsObert = false;

        private void opcions_Tick(object sender, EventArgs e)
        {
            obrirTancarOpcions();
        }

        private void PanelDGV_Click(object sender, EventArgs e)
        {
            TancarOpcions();
        }

        private void PanelHora_Click(object sender, EventArgs e)
        {
            TancarOpcions();
        }

        private void MenuVertical_Click(object sender, EventArgs e)
        {
            TancarOpcions();
        }

        private void panelMenu_Click(object sender, EventArgs e)
        {
            TancarOpcions();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TancarOpcions();
        }

        private void BarraTitulo_Click(object sender, EventArgs e)
        {
            TancarOpcions();
        }

        private void lbl_hora_Click(object sender, EventArgs e)
        {
            TancarOpcions();
        }

        private void data_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PanelHora_Click_1(object sender, EventArgs e)
        {
            TancarOpcions();
        }

        private void veurePerfilB_Click(object sender, EventArgs e)
        {
            MostrarPerfil();
        }

        private void iconcerrar_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Application.Exit();
            }
        }

        private void btnslide_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                swipeMenu.Start();
                imatge.Start();

                if (MenuVertical.Width == 250)
                {
                    obrint = false;
                }
                else
                {
                    obrint = true;
                }

                TancarOpcions();
                decorarOpcions();
            }
        }

        private void MoreOptionsB_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                opcions.Start();
            }
        }

        private void iconminimizar_MouseClick(object sender, MouseEventArgs e)
        {
            TancarOpcions();

            if (e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void tancarSessioB_Click(object sender, EventArgs e)
        {
            tancarSessio();
        }

        private void MostrarPerfil()
        {
            foreach (Form formulari in Application.OpenForms)
            {
                if (formulari.Name.Equals("PerfilUsuari"))
                {
                    formulari.BringToFront();
                    formObert = true;
                }
            }

            if (!formObert)
            {
                PerfilUsuari.PerfilUsuari Perfil = new PerfilUsuari.PerfilUsuari(ID);

                Perfil.TopLevel = false;
                PanelDGV.Controls.Add(Perfil);
                Perfil.Size = PanelDGV.Size;
                Perfil.Show();
                Perfil.BringToFront();
            }

            opcions.Start();
            obrirTancarOpcions();
        }

        private void obrirTancarOpcions()
        {
            obrintOpcions = false;

            if (moreOptions.Width < 200 && !obrintOpcions && !opcionsObert)
            {
                moreOptions.Width += 20;
                moreOptions.Height += 10;
            }
            else
            {
                moreOptions.Width -= 20;
                moreOptions.Height -= 10;
            }

            if (moreOptions.Size == moreOptions.MaximumSize || moreOptions.Size == moreOptions.MinimumSize)
            {
                opcions.Stop();

                if (moreOptions.Size == moreOptions.MaximumSize)
                {
                    obrintOpcions = true;
                    opcionsObert = true;
                }
                else
                {
                    obrintOpcions = false;
                    opcionsObert = false;
                }
            }
        }

        bool perfilObert;

        private void tancarSessio()
        {
            Login L = new Login();

            Form FormPerfil = this;

            foreach (Form formulari in Application.OpenForms)
            {
                if (formulari.Name == "PerfilUsuari")
                {
                    perfilObert = true;
                    FormPerfil = formulari;
                    break;
                }
                else
                {
                    perfilObert = false;
                }
            }

            if (perfilObert)
            {
                FormPerfil.Close();
            }
            
            this.Hide();
            L.Show();
        }

        private void TancarOpcions()
        {
            if (moreOptions.Size == moreOptions.MaximumSize)
            {
                opcions.Start();
            }
        }

        private void EventTancarOpcions(object sender, EventArgs e)
        {
            TancarOpcions();
        }
    }
}