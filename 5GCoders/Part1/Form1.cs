using Connection;
using Encryption;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Part1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EncryptionClass encrypt = new EncryptionClass();
        SQLConnection SQL;
        char[] c = { 'A', 'B', 'C', 'D' };
        Dictionary<string, string> coordinates;
        XmlDocument XMLDocument = new XmlDocument();
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        byte[] plainText, encryptedText;


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPlanets();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int id = (int)comboBox1.SelectedValue;

            string validationCode = GenerateCode();
            coordinates = GenerateCoordinates();

            UploadValidationCode(id, validationCode);
            UploadCoordinates(id, coordinates);
        }

        private void LoadPlanets()
        {
            SQL = new SQLConnection();
            string query = "SELECT IDPLANET, DESCPLANET FROM PLANETS";
            DataSet dts = SQL.PortarTaula(query);

            comboBox1.DataSource = dts.Tables[0];
            comboBox1.ValueMember = "idPlanet";
            comboBox1.DisplayMember = "DescPlanet";
        }

        private string GenerateCode()
        {
            string code;

            return code = encrypt.RandomString(12, false);
        }

        private Dictionary<string, string> GenerateCoordinates()
        {
            Dictionary<string, string> dictCoord = new Dictionary<string, string>();
            string coord;

            for (int i = 0; i < c.Length; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    coord = encrypt.RandomString(5, true);

                    dictCoord.Add(c[i] + j.ToString(), coord);
                }
            }

            return dictCoord;
        }

        private void UploadValidationCode(int idPlanet, string code)
        {
            SQL = new SQLConnection();
            string query = "SELECT * FROM VALIDATIONCODE WHERE IDPLANET = " + idPlanet;
            DataSet dts = SQL.PortarTaula(query);

            if (dts.Tables[0].Rows.Count == 1)
            {
                query = "UPDATE VALIDATIONCODE SET VALIDATIONCODE = '" + code + "'" + "WHERE IDPLANET = " + idPlanet;
                SQL.SQLCommand(query);
            }
            else
            {
                query = "INSERT INTO VALIDATIONCODE VALUES(" + idPlanet + ", '" + code + "')";
                SQL.SQLCommand(query);
            }
        }

        private void UploadCoordinates(int idPlanet, Dictionary<string, string> coordinates)
        {
            string query = "SELECT * FROM INNERENCRYPTION WHERE IDPLANET = " + idPlanet;
            DataSet dts = SQL.PortarTaula(query);

            if (dts.Tables[0].Rows.Count == 0)
            {
                query = "INSERT INTO INNERENCRYPTION(IDPLANET) VALUES(" + idPlanet + ")";
                SQL.SQLCommand(query);
            }

            query = "SELECT * FROM INNERENCRYPTION WHERE IDPLANET = " + idPlanet;
            dts = SQL.PortarTaula(query);

            string idInnerEncryption = dts.Tables[0].Rows[0]["IDINNERENCRYPTION"].ToString();

            query = "SELECT * FROM COORDINATEKEYS WHERE IDINNERENCRYPTION = " + idInnerEncryption;
            dts = SQL.PortarTaula(query);

            if (dts.Tables[0].Rows.Count != 20)
            {
                foreach (KeyValuePair<string, string> item in coordinates)
                {
                    query = "SELECT * FROM INNERENCRYPTION WHERE IDPLANET = " + idPlanet;
                    dts = SQL.PortarTaula(query);

                    idInnerEncryption = dts.Tables[0].Rows[0]["IDINNERENCRYPTION"].ToString();

                    query = "INSERT INTO COORDINATEKEYS(IDINNERENCRYPTION, COORDINATE, COORDINATEKEY) VALUES(" + idInnerEncryption + ", '" + item.Key + "', '" + item.Value + "')";
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








        public byte[] Encryption(byte[] Data, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;

                using (RSACryptoServiceProvider RSAEnc = new RSACryptoServiceProvider())
                {
                    string xmlKey = textBox4.Text;
                    RSAEnc.FromXmlString(xmlKey);

                    encryptedData = RSAEnc.Encrypt(Data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public byte[] Decryption(byte[] Data, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                CspParameters cspp = new CspParameters();
                const string keyName = "Key01";
                cspp.KeyContainerName = keyName;
                using (RSACryptoServiceProvider RSADec = new RSACryptoServiceProvider(cspp))
                {
                    decryptedData = RSADec.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plaintext = ByteConverter.GetBytes(textBox1.Text);
            encryptedtext = Encryption(plaintext, false);
            textBox2.Text = Convert.ToBase64String(encryptedtext);
            SqlConnection conn = new SqlConnection("Data Source=5gCoders.database.windows.net;Initial Catalog=5gcoders;User ID=coders5g;Password=123456aA");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into PlanetKeys(idPlanet,XMLKey) values(" + 2 + ",'" + textBox4.Text + "')", conn);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] decryptedtex = Decryption(encryptedtext, false);
            textBox3.Text = ByteConverter.GetString(decryptedtex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CspParameters cspp = new CspParameters();
            const string keyName = "Key01";
            cspp.KeyContainerName = keyName;
            using (RSACryptoServiceProvider RSAPlanet = new RSACryptoServiceProvider(cspp))
            {
                textBox4.Text = RSAPlanet.ToXmlString(false);
            }
        }
    }
}