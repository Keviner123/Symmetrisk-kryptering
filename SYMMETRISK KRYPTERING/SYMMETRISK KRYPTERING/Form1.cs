using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYMMETRISK_KRYPTERING
{
    public partial class Form1 : Form
    {
        SymmetricAlgorithm selectedSymmetricAlgorithm;
        ConversionHandlers CH = new ConversionHandlers();

        public Form1()
        {
            InitializeComponent();

            //Add Algorithms
            comboBoxAlgorithm.Items.Add("DES");
            comboBoxAlgorithm.Items.Add("3DES");
            comboBoxAlgorithm.Items.Add("Rijndael");

            //Set the default Algorithm
            comboBoxAlgorithm.SelectedIndex = 0;

            //Generate default keys and IV
            GenerateKeyAndIV();

        }

        public SymmetricAlgorithm GetSymmetricAlgorithm(string cipher)
        {
            SymmetricAlgorithm SymmetricAlgorithm = null;

            switch (cipher)
            {
                case "DES":
                    SymmetricAlgorithm = DES.Create();
                    break;
                case "3DES":
                    SymmetricAlgorithm = TripleDES.Create();
                    break;
                case "Rijndael":
                    SymmetricAlgorithm = Rijndael.Create();
                    break;
            }
            return (SymmetricAlgorithm);

        }

        public void GenerateKeyAndIV()
        {
            selectedSymmetricAlgorithm = GetSymmetricAlgorithm(comboBoxAlgorithm.Text);

            textBoxKey.Text = CH.ByteArrayToHexString(selectedSymmetricAlgorithm.Key);
            textBoxIV.Text = CH.ByteArrayToHexString(selectedSymmetricAlgorithm.IV);
        }

        public byte[] Encrypt(byte[] mess, byte[] key, byte[] iv)
        {
            selectedSymmetricAlgorithm.Key = key;
            selectedSymmetricAlgorithm.IV = iv;
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, selectedSymmetricAlgorithm.CreateEncryptor(),CryptoStreamMode.Write);
            cs.Write(mess, 0, mess.Length);
            cs.Close();
            return ms.ToArray();
        }

        public byte[] Decrypt(byte[] mess, byte[] key, byte[] iv)
        {
            byte[] plaintext = new byte[mess.Length];
            selectedSymmetricAlgorithm.Key = key;
            selectedSymmetricAlgorithm.IV = iv;
            MemoryStream ms = new MemoryStream(mess);
            CryptoStream cs = new CryptoStream(ms,
            selectedSymmetricAlgorithm.CreateDecryptor(),CryptoStreamMode.Read);cs.Read(plaintext, 0, mess.Length);
            cs.Close();
            return plaintext;
        }


        private void buttonGenerateKeyAndIV_Click(object sender, EventArgs e)
        {
            GenerateKeyAndIV();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            byte[] ciphertext = Encrypt(CH.StringToByteArray(textBoxPlainTextASCII.Text), CH.HexStringToByteArray(textBoxKey.Text), CH.HexStringToByteArray(textBoxIV.Text));

            textBoxCipherTextASCII.Text = CH.ByteArrayToString(ciphertext);
            textBoxCipherTextHEX.Text = CH.ByteArrayToHexString(ciphertext);
            textBoxPlainTextHEX.Text = CH.ByteArrayToHexString(CH.StringToByteArray(textBoxPlainTextASCII.Text));
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] plaintext = Decrypt(CH.HexStringToByteArray(textBoxCipherTextHEX.Text), CH.HexStringToByteArray(textBoxKey.Text), CH.HexStringToByteArray(textBoxIV.Text));
                MessageBox.Show(CH.ByteArrayToString(plaintext), "Decrypted message");
            }
            catch (Exception)
            {
                MessageBox.Show("Check inputs", "Error");
            }

        }

        private void textBoxPlainTextASCII_TextChanged(object sender, EventArgs e)
        {
            byte[] ciphertext = Encrypt(CH.StringToByteArray(textBoxPlainTextASCII.Text), CH.HexStringToByteArray(textBoxKey.Text), CH.HexStringToByteArray(textBoxIV.Text));

            textBoxCipherTextASCII.Text = CH.ByteArrayToString(ciphertext);
            textBoxCipherTextHEX.Text = CH.ByteArrayToHexString(ciphertext);
            textBoxPlainTextHEX.Text = CH.ByteArrayToHexString(CH.StringToByteArray(textBoxPlainTextASCII.Text));
        }
    }
}
