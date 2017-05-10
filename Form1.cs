using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace EncryptionForm
{
    public partial class Form1 : Form
    {
        public static string iv = "qpalzmwoskxntgbb";
        public static string key = "g6h10azxmcfr73y63bt84ls3hk19tgs4";
                                    
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunEncryption(inputBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RunDecryption(inputBox.Text);
        }

        public AesCryptoServiceProvider GetAes()
        {
            var aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = Encoding.ASCII.GetBytes(key);
            aes.IV = Encoding.ASCII.GetBytes(iv);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;

            return aes;
        }

        public void RunEncryption(string text)
        {
            byte[] texts = Encoding.ASCII.GetBytes(text);
            var encdec = GetAes();

            ICryptoTransform icrypt = encdec.CreateEncryptor(encdec.Key, encdec.IV);
            byte[] enc = icrypt.TransformFinalBlock(texts, 0, texts.Length);
            icrypt.Dispose();
            outputBox.Text = Convert.ToBase64String(enc);
        }

        public void RunDecryption(string text)
        {
            try
            {
                byte[] dtexts = Convert.FromBase64String(text);
                var encdec = GetAes();

                ICryptoTransform icrypt = encdec.CreateDecryptor(encdec.Key, encdec.IV);
                byte[] dec = icrypt.TransformFinalBlock(dtexts, 0, dtexts.Length);
                icrypt.Dispose();
                outputBox.Text = Encoding.ASCII.GetString(dec);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                button2.Enabled = false;
            }
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }
    }
}
