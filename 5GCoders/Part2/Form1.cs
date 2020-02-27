using Connection;
using Encryption;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string s;
        char[] c = {'A', 'B', 'C', 'D'};
        Dictionary<string, string> dictCoord = new Dictionary<string, string>();
        SQLConnection SQL = new SQLConnection();

        private void Form1_Load(object sender, EventArgs e)
        {
            EncryptionClass encryption = new EncryptionClass();

            for (int i = 0; i < c.Length; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    s = encryption.RandomString(5, true);

                    dictCoord.Add(c[i] + j.ToString(), s);
                }
            }

            foreach (KeyValuePair<string, string> item in dictCoord)
            {
                textBox1.Text += item.Key + " = " + item.Value + "\r\n";
            }
        }
        
        private void StoreCoordinates(Dictionary<string, string> coordinates, int idPlanet)
        {
            DataSet dts;
            string query, innerEncryption;

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
                    foreach(KeyValuePair<string, string> item in coordinates)
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

        private void button1_Click(object sender, EventArgs e)
        {
            StoreCoordinates(dictCoord, 1);
        }
    }
}
