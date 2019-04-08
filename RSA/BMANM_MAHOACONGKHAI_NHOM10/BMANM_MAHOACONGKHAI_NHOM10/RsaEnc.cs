using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BMANM_MAHOACONGKHAI_NHOM10
{
    class RsaEnc
    {        
        private static RSACryptoServiceProvider rsa;
        private RSAParameters privatekey;
        private RSAParameters publickey;      
        public int sobit; 
        public RsaEnc()
        {            
            Random rd = new Random();
            sobit = Math.Abs(2048);
            rsa = new RSACryptoServiceProvider(sobit);            
            privatekey = rsa.ExportParameters(true);
            publickey = rsa.ExportParameters(false);            
        }
        public string PublickeyString()
        {            
            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw,publickey);
            return sw.ToString();
        }
        public string PrivatekeyString()
        {
            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, privatekey);
            return sw.ToString();
        }
        public string Encrypt(string plainText)
        {
            rsa = new RSACryptoServiceProvider();
            string keyfromfile = LoadKeyFromFile("publickey.txt");
            if (keyfromfile != null)
            {
                rsa.FromXmlString(keyfromfile);
            }
            else
                rsa.ImportParameters(publickey);            
            var data = Encoding.Unicode.GetBytes(plainText);
            var cypher = rsa.Encrypt(data,false);
            return Convert.ToBase64String(cypher);
        }
        public string Decrypt(string cypherText)
        {
            var databytes = Convert.FromBase64String(cypherText);
            string keyfromfile = LoadKeyFromFile("privatekey.txt");
            if (keyfromfile != null)
            {
                rsa.FromXmlString(keyfromfile);
            }
            else
                rsa.ImportParameters(privatekey);
            var plain = rsa.Decrypt(databytes,false);
            return Encoding.Unicode.GetString(plain);
        }
        public string LoadKeyFromFile(string filePath)
        {
            string res = "";
            FileStream fs = new FileStream(filePath,FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            res = sr.ReadToEnd();
            fs.Close();
            return res;
        }        
    }
}
