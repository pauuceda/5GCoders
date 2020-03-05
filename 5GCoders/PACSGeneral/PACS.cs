using System;
using System.Windows.Forms;
using PACSPlanet;
using PACSSpaceship;
using Connection;
using System.Data;

namespace PACSGeneral
{
    public partial class PACS : Form
    {
        public PACS()
        {
            InitializeComponent();
        }

        int idPlanet;

        private void PACS_Load(object sender, EventArgs e)
        {
            LoadPlanets(ComboPlanets);
        }

        bool FormObert = false;

        private void PlanetButton_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "Planet")
                {
                    FormObert = true;
                    break;
                }
            }

            if (!FormObert)
            {
                Planet P = new Planet();
                P.TopLevel = false;
                PanelGeneral.Controls.Add(P);
                P.Show();

                PlanetButton.Dispose();
                SpaceshipButton.Dispose();
            }
        }

        private void SpaceshipButton_Click(object sender, EventArgs e)
        {
            Spaceship S = new Spaceship();
            S.TopLevel = false;
            PanelGeneral.Controls.Add(S);
            S.Show();

            PlanetButton.Dispose();
            SpaceshipButton.Dispose();
        }

        private void LoadPlanets(ComboBox ComboPlanet)
        {
            SQLConnection SQL = new SQLConnection();
            string query = "SELECT IDPLANET, DESCPLANET FROM PLANETS";
            DataSet dts = SQL.PortarTaula(query);

            ComboPlanet.DataSource = dts.Tables[0];
            ComboPlanet.ValueMember = "idPlanet";
            ComboPlanet.DisplayMember = "DescPlanet";
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            idPlanet = (int)ComboPlanets.SelectedValue;

            ComboPlanets.Dispose();
            SendButton.Dispose();

            PlanetButton.Visible = true;
            SpaceshipButton.Visible = true;
        }
    }
}