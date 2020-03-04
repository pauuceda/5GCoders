using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Encriptacio;
using Connection;
using System.Xml;
using System.Text;
using System.Security.Cryptography;

namespace PACSSpaceship
{
    public partial class Spaceship : Form
    {
        public Spaceship()
        {
            InitializeComponent();
        }

        EncryptionClass E = new EncryptionClass();
        SQLConnection SQL;
        char[] c = { 'A', 'B', 'C', 'D' };
        Dictionary<string, string> coordinates;
        XmlDocument XMLDocument = new XmlDocument();
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        //byte[] plainText, encryptedText;
        string publicKey, validationCode;

        private void Spaceship_Load(object sender, EventArgs e)
        {
            LoadPlanets(ComboPlanets);
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            SendSignal(ComboPlanets);
        }

        private void SendSignal(ComboBox ComboPlanets)
        {
            int id;

            try
            {
                id = (int)ComboPlanets.SelectedValue;

                validationCode = GenerateCode();
                coordinates = GenerateCoordinates();
                publicKey = GenerateKeys();

                UploadValidationCode(id, validationCode);
                UploadCoordinates(id, coordinates);
                UploadPublicKey(id, publicKey);

                MessageBox.Show("Done", "5G Coders", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

            }
        }

        private void LoadPlanets(ComboBox ComboPlanet)
        {
            SQL = new SQLConnection();
            string query = "SELECT IDPLANET, DESCPLANET FROM PLANETS";
            DataSet dts = SQL.PortarTaula(query);

            ComboPlanet.DataSource = dts.Tables[0];
            ComboPlanet.ValueMember = "idPlanet";
            ComboPlanet.DisplayMember = "DescPlanet";
        }
        //Generar el ValidationCode
        private string GenerateCode()
        {
            string code;
            return code = E.RandomString(12, false);
        }
        //Generar el diccionari de coordenades
        private Dictionary<string, string> GenerateCoordinates()
        {
            Dictionary<string, string> dictCoord = new Dictionary<string, string>();
            string coord;

            for (int i = 0; i < c.Length; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    coord = E.RandomString(5, true);

                    dictCoord.Add(c[i] + j.ToString(), coord);
                }
            }

            return dictCoord;
        }
        //Generar la clau pública i la clau privada
        public string GenerateKeys()
        {
            CspParameters cspp = new CspParameters();
            string publicKey;

            const string keyName = "Key01";    //Private
            cspp.KeyContainerName = keyName;

            using (RSACryptoServiceProvider RSAPlanet = new RSACryptoServiceProvider(cspp))
            {
                RSAPlanet.PersistKeyInCsp = false;
                RSAPlanet.Clear();
            }

            using (RSACryptoServiceProvider RSAPlanetFinal = new RSACryptoServiceProvider(cspp))
            {
                return publicKey = RSAPlanetFinal.ToXmlString(false);   //Public
            }
        }
        //Pujar a la bbdd el ValidationCode
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
        //Pujar a la bbdd les coordenades
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
        //Pujar a la bbdd la clau pública
        private void UploadPublicKey(int idPlanet, string publicKey)
        {
            string query = "SELECT * FROM PLANETKEYS WHERE IDPLANET = " + idPlanet;
            DataSet dts = SQL.PortarTaula(query);

            if (dts.Tables[0].Rows.Count == 0)
            {
                query = "insert into PlanetKeys(idPlanet,XMLKey) values(" + idPlanet + ",'" + publicKey + "')";
                SQL.SQLCommand(query);
            }
            else
            {
                query = "UPDATE PLANETKEYS SET XMLKEY = '" + publicKey + "' WHERE IDPLANET = " + idPlanet;
                SQL.SQLCommand(query);
            }

        }
        //Funció per encriptar
        public byte[] Encryption(byte[] Data, bool DoOAEPPadding, string pKey)
        {
            try
            {
                byte[] encryptedData;

                using (RSACryptoServiceProvider RSAEnc = new RSACryptoServiceProvider())
                {
                    RSAEnc.FromXmlString(pKey);

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

        //Funció per desencriptar
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

        /*plainText = ByteConverter.GetBytes(validationCode);
        encryptedText = Encryption(plainText, false, publicKey);
        textBox2.Text = Convert.ToBase64String(encryptedText);*/

        /*byte[] decryptedtex = Decryption(encryptedtext, false);
        textBox3.Text = ByteConverter.GetString(decryptedtex);*/
    }
}
