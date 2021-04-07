using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace SaugumasDarbas2
{
    
    public partial class Form1 : Form
    {
        //string FileName = "CText.txt";
        string EncryptRSAPath = @"C:\Users\PC\Desktop\DESlsong\SaugumasDarbas2\rsaEncrypt.txt";
        string DecryptRSAPath = @"C:\Users\PC\Desktop\DESlsong\SaugumasDarbas2\rsaDecrypt.txt";
        //string FileNameCBC = @"C:\Users\PC\source\repos\SaugumasDarbas2\SaugumasDarbas2\cbcEncrypt.txt";

        string pubKeyPath = @"C:\Users\PC\Desktop\DESlsong\SaugumasDarbas2\public.key";//change as needed
        string priKeyPath = @"C:\Users\PC\Desktop\DESlsong\SaugumasDarbas2\private.key";//change as needed

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void Encrypt_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (encryptTextbox.Text != "" && encryptTextbox.Text != null)
                {

                    FileStream encryptFilePath = File.Open(EncryptRSAPath, FileMode.OpenOrCreate);
                    encryptFilePath.SetLength(0);
                    encryptFilePath.Close(); // This flushes the content, too.

                    //string unencryptedStringRSA = encryptTextbox.Text;
                    MakeKey();//to make private and public keys

                    //encrypt. it will read from normal text from file and ecrypt it in that file
                    string encryptedStringRSA = EncryptFile(EncryptRSAPath, encryptTextbox.Text);

                    encryptedTextTextbox.Text = encryptedStringRSA;
                    //Console.WriteLine("Unencrypted String: " + unencryptedStringRSA);
                    Console.WriteLine("Encrypted String: " + encryptedStringRSA);

                }
                else
                {
                    MessageBox.Show("Write text to textbox to encrypt it!!!");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void descrypt_Click_1(object sender, EventArgs e)
        {
            try
            {
                /*
                FileStream decryptFilePath = File.Open(DecryptRSAPath, FileMode.OpenOrCreate);
                decryptFilePath.SetLength(0);
                decryptFilePath.Close(); // This flushes the content, too.

                string decryptedData = DecryptFile(EncryptRSAPath, DecryptRSAPath);
                Console.WriteLine("Decrypted String: " + decryptedData);
                decryptedFileTextbox.Text = decryptedData;

                /*
                if (decryptedData != null && decryptedData != "")
                {
                    File.Delete(priKeyPath);
                    File.Delete(pubKeyPath);
                }
                */

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textToDecrypt.Text != "" && textToDecrypt.Text != null)
                {
                    /*
                    string encryptedText = textToDecrypt.Text;
                    string decryptedData = SimpleDecrypt(encryptedText);
                    Console.WriteLine("Encrypted String: " + encryptedText);
                    Console.WriteLine("Decrypted String: " + decryptedData);

                    decryptedTextbox.Text = decryptedData;
                    */

                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        public void MakeKey()
        {
            //lets take a new CSP with a new 2048 bit rsa key pair
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048);

            //how to get the private key
            RSAParameters privKey = csp.ExportParameters(true);

            //and the public key ...
            RSAParameters pubKey = csp.ExportParameters(false);
            //converting the public key into a string representation
            string pubKeyString;
            {
                //we need some buffer
                var sw = new StringWriter();
                //we need a serializer
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //serialize the key into the stream
                xs.Serialize(sw, pubKey);
                //get the string from the stream
                pubKeyString = sw.ToString();
                File.WriteAllText(pubKeyPath, pubKeyString);
            }
            string privKeyString;
            {
                //we need some buffer
                var sw = new StringWriter();
                //we need a serializer
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //serialize the key into the stream
                xs.Serialize(sw, privKey);
                //get the string from the stream
                privKeyString = sw.ToString();
                File.WriteAllText(priKeyPath, privKeyString);
                
            }
        }
        public string EncryptFile(string filePath, string inputString)
        {
            //converting the public key into a string representation
            string pubKeyString;
            {
                using (StreamReader reader = new StreamReader(pubKeyPath)) { pubKeyString = reader.ReadToEnd(); }
            }
            //get a stream from the string
            var sr = new StringReader(pubKeyString);

            //we need a deserializer
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));

            //get the object back from the stream
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
            csp.ImportParameters((RSAParameters)xs.Deserialize(sr));


            byte[] bytesPlainTextData = Encoding.ASCII.GetBytes(inputString);
            //byte[] bytesPlainTextData = File.ReadAllBytes(filePath);

            //apply pkcs#1.5 padding and encrypt our data 
            var bytesCipherText = csp.Encrypt(bytesPlainTextData, false);
            //we might want a string representation of our cypher text... base64 will do
            string encryptedText = Convert.ToBase64String(bytesCipherText);
            File.WriteAllText(filePath, encryptedText);

            return encryptedText;
        }
        
    }
}

