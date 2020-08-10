using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptDecrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelKey.Hide();
            txtCustomKey.Hide();
            buttonSetCustomKey.Hide();
            label6.Hide();
        }
        String encryptionKey = "";
        private void btnProcess_Click(object sender, EventArgs e)
        {
            String plainText = txtPlainText.Text;
            String encryptedText = txtEncText.Text;
            if (plainText == "" && encryptedText == "")
            {
                MessageBox.Show("Enter inputs");
                return;
            }
            if (encryptionKey == "iBankEncryption")
            {
                if(plainText.Length > 0)
                    encryptDecryptCommon(plainText, encryptedText, "iBank",false);
                else
                    encryptDecryptCommon(encryptedText, encryptedText, "iBank",true);

            }
            else                
            {
                if(plainText.Length > 0)
                    encryptDecryptCommon(plainText, encryptedText, "",false);
                else
                    encryptDecryptCommon(encryptedText, encryptedText, "",true);
            }                           
        }

        private void encryptDecryptCommon(String plainText, String encryptedText,String mode,bool toBeDecrypted)
        {
            String EnrKey = encryptionKey;
            EncryptionAndDecryption ObjEncryptDecrypt = new EncryptionAndDecryption();
            String encryptedtext = "";
            String encrypteDecryptedText = "";
            try
            {
                if (!toBeDecrypted)
                {
                    if (mode == "iBank")
                        encryptedtext = Cryptography_CSharp.Encrypt(plainText);
                    else
                        encryptedtext = ObjEncryptDecrypt.Encryption(plainText, EnrKey);
                    txtOutput.Text = encryptedtext;
                    return;
                }
                else if (encryptedText.Length > 0)
                {
                    if (mode == "iBank")
                        encrypteDecryptedText = encryptedtext = Cryptography_CSharp.Decrypt(plainText);
                    else
                        encrypteDecryptedText = ObjEncryptDecrypt.Decryption(encryptedText, EnrKey);
                    txtOutput.Text = encrypteDecryptedText;
                    return;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception : " + e.Message);
            }            
        }

        private void txtPlainText_TextChanged(object sender, EventArgs e)
        {
            if (txtPlainText.Text.Length > 0)
                txtEncText.Enabled = false;
            else
            {
                txtPlainText.Enabled = true;
                txtEncText.Enabled = true;
            }
        }

        private void txtEncText_TextChanged(object sender, EventArgs e)
        {
            if (txtEncText.Text.Length > 0)
                txtPlainText.Enabled = false;
            else
            {
                txtPlainText.Enabled = true;
                txtEncText.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            txtOutput.Text = "";
            txtEncText.Text = "";
            txtPlainText.Text = "";
            label6.Hide();
        }

        private void encryptionTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (encryptionTypes.Text == "Generic")
            {
                labelKey.Show();
                txtCustomKey.Show();
                buttonSetCustomKey.Show();
                txtEncText.Enabled = false;
                txtPlainText.Enabled = false;
                txtOutput.Enabled = false;
            }
            else if (encryptionTypes.Text == "iBank Encryption")
            {
                labelKey.Hide();
                txtCustomKey.Hide();
                buttonSetCustomKey.Hide();
                txtEncText.Enabled = true;
                txtPlainText.Enabled = true;
                txtOutput.Enabled = true;
                encryptionKey = "iBankEncryption";
            }
            else
            {
                labelKey.Hide();
                txtCustomKey.Hide();
                buttonSetCustomKey.Hide();
                txtEncText.Enabled = true;
                txtPlainText.Enabled = true;
                txtOutput.Enabled = true;
                encryptionKey = "encryptPassword";
            }
        }

        private void buttonSetCustomKey_Click(object sender, EventArgs e)
        {
            if (txtCustomKey.Text == "")
                MessageBox.Show("Enter Custom Key");
            else
            {
                txtEncText.Enabled = true;
                txtPlainText.Enabled = true;
                txtOutput.Enabled = true;
                encryptionKey = txtCustomKey.Text;
                clearFields();
            }
        }

        private void txtOutput_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOutput.Text.ToString());
            label6.Show();
        }
    }
}
