using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using CustomControls;
using Encriptacio;
using ORM;

namespace GestioUsuaris
{
    public partial class Usuaris : Form
    {
        Encriptar E = new Encriptar();
        bool nouRegistre = false;
        bool CarregaInicial = true;
        string IDUsuari;

        public Usuaris()
        {
            InitializeComponent();
        }

        private void Usuaris_Load(object sender, EventArgs e)
        {
            CarregarDades();
            BindejarDades();

            CarregaInicial = false;
        }

        private void NetejarBindejos()
        {
            foreach (Control ctrl in PanelEdicion.Controls)
            {
                if (ctrl.GetType() == typeof(SWTextBox) && !ctrl.Name.Equals("SWSearch"))
                {
                    ctrl.DataBindings.Clear();

                    if (!((SWTextBox)ctrl).EsForania)
                    {
                        ctrl.Text = null;
                    }
                    else
                    {
                        ctrl.Text = "1";
                    }
                }
            }
        }

        private void BindejarDades()
        {
            foreach (Control ctrl in PanelEdicion.Controls)
            {
                if (ctrl.GetType() == typeof(SWComboFK))
                {
                    if (CarregaInicial)
                    {
                        ((SWComboFK)ctrl).carregaDades();
                    }

                    //((SWComboFK)ctrl).SelectedIndexChanged += new EventHandler(ValidarCanvis);
                }

                if (ctrl.GetType() == typeof(SWTextBox) && !ctrl.Name.Equals("SWSearch"))
                {
                    ctrl.DataBindings.Clear();
                    ctrl.DataBindings.Add("Text", ORMSource, ((SWTextBox)ctrl).NomCamp);
                    ctrl.Validated += new EventHandler(ValidarCanvis);
                }
            }
        }

        private void CarregarDades()
        {
            ORMSource.DataSource = selectAllUsers();
            DGV.DataSource = ORMSource;

            DGV.Columns[0].Visible = false;
        }

        private void ValidarCanvis(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(SWTextBox))
            {
                if (((SWTextBox)sender).Name == "SWPassword")
                {
                    ((SWTextBox)sender).Text = E.EncriptarContrasenya(((SWTextBox)sender).Text);
                }
            }

            if (!nouRegistre)
            {
                if (sender.GetType() == typeof(SWTextBox))
                {
                    try
                    {
                        ((SWTextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
                    }
                    catch (Exception)
                    {

                    }
                }
                else if (sender.GetType() == typeof(SWComboFK))
                {
                    foreach (Control ctrl in PanelEdicion.Controls)
                    {
                        if (ctrl.GetType() == typeof(SWTextBox) && !ctrl.Name.Equals("SWSearch"))
                        {
                            if (((SWTextBox)ctrl).controlID == ((SWComboFK)sender).Name)
                            {
                                try
                                {
                                    ((SWTextBox)ctrl).DataBindings[0].BindingManagerBase.EndCurrentEdit();
                                }
                                catch (Exception)
                                {

                                }
                            }
                        }
                    }
                }
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            NetejarBindejos();

            CanceButton.Visible = true;
            InsertButton.Visible = true;
            NewButton.Visible = false;
            UpdateButton.Visible = false;
            PrintButton.Visible = false;
            nouRegistre = true;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ActualitzarRegistre();

            CarregarDades();
            BindejarDades();

            MessageBox.Show("Dades actualitzades", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CanceButton_Click(object sender, EventArgs e)
        {
            BindejarDades();

            CanceButton.Visible = false;
            InsertButton.Visible = false;
            NewButton.Visible = true;
            UpdateButton.Visible = true;
            PrintButton.Visible = true;
            nouRegistre = false;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            InsertarRegistre();

            CarregarDades();
            BindejarDades();

            MessageBox.Show("Registre afegit", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CanceButton.Visible = false;
            InsertButton.Visible = false;
            NewButton.Visible = true;
            UpdateButton.Visible = true;
            PrintButton.Visible = true;
            nouRegistre = false;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            InformeUsuari IU = new InformeUsuari(IDUsuari);

            IU.TopLevel = false;
            PanelDGV.Controls.Add(IU);

            IU.Show();
            IU.BringToFront();
        }

        public static ChampionsEntities CE = new ChampionsEntities();

        public static List<Users> selectAllUsers()
        {
            List<Users> _usuaris =
                (
                from u in CE.Users
                select u
                ).ToList();

            return _usuaris;
        }

        public void InsertarRegistre()
        {
            if (SWPassword.Text.Trim() == "")
            {
                SWPassword.Text = E.EncriptarContrasenya(SWPassword.Text);
            }

            using (ChampionsEntities CE = new ChampionsEntities())
            {
                Users nouUsuari = new Users
                {
                    CodeUser = SWCodeUser.Text,
                    UserName = SWNomUsuari.Text,
                    Login = SWLogin.Text,
                    Password = SWPassword.Text,
                    Photo = SWPhoto.Text,
                    idUserCategory = int.Parse(SWCategoriaTB.Text),
                    idPlanet = int.Parse(SWPlanetsTB.Text),
                    idUserRank = int.Parse(SWUserRankTB.Text),
                    idSpecie = int.Parse(SWEspeciesTB.Text)
                };

                CE.Users.Add(nouUsuari);

                try
                {
                    CE.SaveChanges();
                }
                catch (Exception)
                {

                }
            }
        }

        public void ActualitzarRegistre()
        {
            using (ChampionsEntities CE = new ChampionsEntities())
            {
                Users Usuari = new Users
                {
                    CodeUser = SWCodeUser.Text,
                    UserName = SWNomUsuari.Text,
                    Login = SWLogin.Text,
                    Password = SWPassword.Text,
                    Photo = SWPhoto.Text,
                    idUserCategory = int.Parse(SWCategoriaTB.Text),
                    idPlanet = int.Parse(SWPlanetsTB.Text),
                    idUserRank = int.Parse(SWUserRankTB.Text),
                    idSpecie = int.Parse(SWEspeciesTB.Text)
                };

                CE.Entry(Usuari).State = EntityState.Modified;

                try
                {
                    CE.SaveChanges();
                }
                catch (Exception)
                {

                }
            }
        }

        private void DGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            IDUsuari = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void DGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    Users u = CE.Users.First(x => x.CodeUser == SWCodeUser.Text);
                    CE.Users.Remove(u);

                    CE.SaveChanges();
                }
                catch (Exception)
                {

                }

                CarregarDades();
                BindejarDades();
            }
        }
    }
}