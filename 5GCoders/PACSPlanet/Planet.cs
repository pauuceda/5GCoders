using Connection;
using Encriptacio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TCP_IP;

namespace PACSPlanet
{
    public partial class Planet : Form
    {
        public Planet()
        {
            InitializeComponent();
        }

        string coordinate;
        char[] c = { 'A', 'B', 'C', 'D' };
        Dictionary<string, string> dictCoord = new Dictionary<string, string>();
        SQLConnection SQL = new SQLConnection();
        TCPClass TCPServer = new TCPClass();

        private void Planet_Load(object sender, EventArgs e)
        {
            CarregaInicial();
            TCPServer.StartServer();
        }

        private void CarregaInicial()
        {
            EncryptionClass encryption = new EncryptionClass();

            for (int i = 0; i < c.Length; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    coordinate = encryption.RandomString(5, true);

                    dictCoord.Add(c[i] + j.ToString(), coordinate);
                }
            }
        }

        private void StoreCoordinates(ComboBox ComboSpaceship, Dictionary<string, string> coordinates)
        {
            DataSet dts;
            string query, innerEncryption;
            int idPlanet;

            idPlanet = (int)ComboSpaceship.SelectedValue;

            query = "SELECT * FROM INNERENCRYPTION WHERE IDPLANET = " + idPlanet;
            dts = SQL.PortarTaula(query);

            if (dts.Tables[0].Rows.Count == 1)
            {
                innerEncryption = dts.Tables[0].Rows[0]["IDINNERENCRYPTION"].ToString();

                query = "SELECT * FROM COORDINATEKEYS WHERE IDINNERENCRYPTION = " + innerEncryption;
                dts = SQL.PortarTaula(query);

                if (dts.Tables[0].Rows.Count != 20)
                {
                    foreach (KeyValuePair<string, string> item in coordinates)
                    {
                        query = "SELECT * FROM INNERENCRYPTION WHERE IDPLANET = " + idPlanet;
                        dts = SQL.PortarTaula(query);

                        innerEncryption = dts.Tables[0].Rows[0]["IDINNERENCRYPTION"].ToString();

                        query = "INSERT INTO COORDINATEKEYS(IDINNERENCRYPTION, COORDINATE, COORDINATEKEY) VALUES(" + innerEncryption + ", '" + item.Key + "', '" + item.Value + "')";
                        SQL.SQLCommand(query);
                    }
                }
                else
                {
                    foreach (KeyValuePair<string, string> item in coordinates)
                    {
                        query = "UPDATE COORDINATEKEYS SET COORDINATEKEY = '" + item.Value + "' WHERE COORDINATE = '" + item.Key + "'";
                        SQL.SQLCommand(query);
                    }
                }
            }
            else
            {
                query = "INSERT INTO INNERENCRYPTION(IDPLANET) VALUES(" + idPlanet + ")";
                SQL.SQLCommand(query);
            }
        }
    }
}
