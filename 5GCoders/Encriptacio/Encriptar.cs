using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Encriptacio
{
    public class Encriptar
    {
        public Encriptar()
        {

        }

        public string GenerarHash (string contrasenya)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] Hash = md5.ComputeHash(Encoding.ASCII.GetBytes(contrasenya));

            return Convert.ToBase64String(Hash);
        }

        public string EncriptarContrasenya (string contrasenya)
        {
            string contrasenyaEncriptada;

            contrasenyaEncriptada = GenerarHash(contrasenya);

            return contrasenyaEncriptada;
        }

        public string RandomString(int length, bool xifres)
        {
            string chars = "";

            if (xifres)
            {
                chars = "1234567890";
            }
            else
            {
                chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            }

            StringBuilder res = new StringBuilder();

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(chars[(int)(num % (uint)chars.Length)]);
                }
            }

            return res.ToString();
        }

        public string EncryptRSA(string plainText)
        {
            //lets take a new CSP with a new 2048 bit rsa key pair
            var csp = new RSACryptoServiceProvider(2048);

            //and the public key ...
            var pubKey = csp.ExportParameters(false);

            //converting the public key into a string representation
            string pubKeyString;
            {
                //we need some buffer
                var sw = new System.IO.StringWriter();
                //we need a serializer
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //serialize the key into the stream
                xs.Serialize(sw, pubKey);
                //get the string from the stream
                pubKeyString = sw.ToString();
            }

            //converting it back
            {
                //get a stream from the string
                var sr = new System.IO.StringReader(pubKeyString);
                //we need a deserializer
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //get the object back from the stream
                pubKey = (RSAParameters)xs.Deserialize(sr);
            }

            //we have a public key ... let's get a new csp and load that key
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(pubKey);

            //for encryption, always handle bytes...
            var bytesPlainTextData = Encoding.Unicode.GetBytes(plainText);

            //apply pkcs#1.5 padding and encrypt our data 
            var bytesCypherText = csp.Encrypt(bytesPlainTextData, false);

            //we might want a string representation of our cypher text... base64 will do
            var cypherText = Convert.ToBase64String(bytesCypherText);

            return cypherText;
        }

        public string DecryptRSA(string encryptedText)
        {
            //lets take a new CSP with a new 2048 bit rsa key pair
            var csp = new RSACryptoServiceProvider(2048);

            //how to get the private key
            var privKey = csp.ExportParameters(true);

            //converting the public key into a string representation
            string privKeyString;
            {
                //we need some buffer
                var sw = new System.IO.StringWriter();
                //we need a serializer
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //serialize the key into the stream
                xs.Serialize(sw, privKey);
                //get the string from the stream
                privKeyString = sw.ToString();
            }

            //converting it back
            {
                //get a stream from the string
                var sr = new System.IO.StringReader(privKeyString);
                //we need a deserializer
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //get the object back from the stream
                privKey = (RSAParameters)xs.Deserialize(sr);
            }

            //first, get our bytes back from the base64 string...
            var bytesCypherText = Convert.FromBase64String(encryptedText);

            //we want to decrypt, therefore we need a csp and load our private key
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(privKey);

            //decrypt and strip pkcs#1.5 padding
            var bytesPlainTextData = csp.Decrypt(bytesCypherText, false);

            //get our original plainText back...
            var plainText = Encoding.Unicode.GetString(bytesPlainTextData);

            return plainText;
        }
    }
}
