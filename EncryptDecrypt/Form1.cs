using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
            try
            {
                String plainText = txtPlainText.Text;
                String encryptedText = txtEncText.Text;
                try
                {
                    JObject json = new JObject();
                    json = JObject.Parse(encryptedText);
                    if (json.ContainsKey("data"))
                        encryptedText = json.GetValue("data").ToString();
                }
                catch
                {

                }
                if (encryptedText != "")
                {
                    encryptedText = encryptedText.Replace("\\n", "");
                    encryptedText = encryptedText.Replace("\\r", "");
                    encryptedText = encryptedText.Replace("\\", "");
                }

                if (plainText == "" && encryptedText == "")
                {
                    MessageBox.Show("Enter inputs");
                    return;
                }
                if (encryptionKey == "iBankEncryption")
                {
                    if (plainText.Length > 0)
                        encryptDecryptCommon(plainText, encryptedText, "iBank", false);
                    else
                        encryptDecryptCommon(encryptedText, encryptedText, "iBank", true);

                }
                else if (encryptionKey == "SAIB")
                {
                    if (plainText.Length > 0)
                        encryptDecryptCommon(plainText, encryptedText, "SAIB", false);
                    else
                        encryptDecryptCommon(encryptedText, encryptedText, "SAIB", true);

                }
                else if (encryptionKey == "SIDC Password")
                {
                    if (plainText.Length > 0)
                        encryptDecryptCommon(plainText, encryptedText, "SIDC Password", false);
                    else
                        encryptDecryptCommon(encryptedText, encryptedText, "SIDC Password", true);
                }
                else
                {
                    if (plainText.Length > 0)
                        encryptDecryptCommon(plainText, encryptedText, "", false);
                    else
                        encryptDecryptCommon(encryptedText, encryptedText, "", true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encryption / Decryption error, please try again");
            }                                       
        }

        private void encryptDecryptCommon(String plainText, String encryptedText,String mode,bool toBeDecrypted,bool isAutoDecrypt = false)
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
                        encryptedtext = Cryptography_CSharp.Encrypt(plainText, mode);
                    else if (mode == "SAIB")
                        encryptedtext = Cryptography_CSharp.Encrypt(plainText, mode);
                    else if(mode == "SIDC Password")
                        encryptedtext = Cryptography_CSharp.Encrypt(plainText, mode);
                    else
                        encryptedtext = ObjEncryptDecrypt.Encryption(plainText, EnrKey);
                    txtOutput.Text = encryptedtext;
                    return;
                }
                else if (encryptedText.Length > 0)
                {
                    if (mode == "iBank")
                        encrypteDecryptedText = encryptedtext = Cryptography_CSharp.Decrypt(plainText, mode);
                    else if (mode == "SAIB")
                        encrypteDecryptedText = encryptedtext = Cryptography_CSharp.Decrypt(plainText, mode);
                    else
                        encrypteDecryptedText = ObjEncryptDecrypt.Decryption(encryptedText, EnrKey);
                    if (checkBox1.Checked)
                    {
                        try
                        {
                            JToken parsedJson = JToken.Parse(encrypteDecryptedText);
                            txtOutput.Text = parsedJson.ToString(Formatting.Indented);
                            var formPopup = new Form();
                            TextBox textBox = new TextBox();
                            textBox.AppendText(parsedJson.ToString(Formatting.Indented));
                            textBox.Multiline = true;
                            textBox.Width = ClientRectangle.Width;
                            textBox.Height = ClientRectangle.Height;
                            textBox.ScrollBars = ScrollBars.Vertical;
                            textBox.SelectionStart = textBox.Text.Length;
                            textBox.ScrollToCaret();
                            formPopup.Controls.Add(textBox);
                            formPopup.Show(this);
                        }
                        catch
                        {
                            txtOutput.Text = encrypteDecryptedText;
                        }                        
                    }
                    else
                        txtOutput.Text = encrypteDecryptedText;
                    return;
                }
            }
            catch (Exception e)
            {
                if(!isAutoDecrypt)
                    MessageBox.Show("Encryption / Decryption error, please try again");
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
            beginEncryptionDecryption();
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
            beginEncryptionDecryption();
        }

        private void beginEncryptionDecryption()
        {
            try
            {
                String plainText = txtPlainText.Text;
                String encryptedText = txtEncText.Text;
                try
                {
                    JObject json = new JObject();
                    json = JObject.Parse(encryptedText);
                    if (json.ContainsKey("data"))
                        encryptedText = json.GetValue("data").ToString();
                }
                catch
                {

                }
                if (encryptedText != "")
                {
                    encryptedText = encryptedText.Replace("\\n", "");
                    encryptedText = encryptedText.Replace("\\r", "");
                    encryptedText = encryptedText.Replace("\\", "");
                }

                if (plainText == "" && encryptedText == "")
                {
                    MessageBox.Show("Enter inputs");
                    return;
                }
                if (encryptionKey == "iBankEncryption")
                {
                    if (plainText.Length > 0)
                        encryptDecryptCommon(plainText, encryptedText, "iBank", false,true);
                    else
                        encryptDecryptCommon(encryptedText, encryptedText, "iBank", true, true);

                }
                else if (encryptionKey == "SAIB")
                {
                    if (plainText.Length > 0)
                        encryptDecryptCommon(plainText, encryptedText, "SAIB", false, true);
                    else
                        encryptDecryptCommon(encryptedText, encryptedText, "SAIB", true, true);

                }
                else if (encryptionKey == "SIDC Password")
                {
                    if (plainText.Length > 0)
                        encryptDecryptCommon(plainText, encryptedText, "SIDC Password", false, true);
                    else
                        encryptDecryptCommon(encryptedText, encryptedText, "SIDC Password", true, true);
                }
                else
                {
                    if (plainText.Length > 0)
                        encryptDecryptCommon(plainText, encryptedText, "", false, true);
                    else
                        encryptDecryptCommon(encryptedText, encryptedText, "", true, true);
                }
            }
            catch (Exception ex)
            {
                //
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
            checkBox1.Checked = true;
            if (encryptionTypes.Text == "Generic")
            {
                labelKey.Show();
                txtCustomKey.Show();
                buttonSetCustomKey.Show();
                txtEncText.Enabled = false;
                txtPlainText.Enabled = false;
                txtOutput.Enabled = false;
                checkBox1.Checked = false;
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
            else if (encryptionTypes.Text == "SAIB" || encryptionTypes.Text == "SIDC")
            {
                labelKey.Hide();
                txtCustomKey.Hide();
                buttonSetCustomKey.Hide();
                txtEncText.Enabled = true;
                txtPlainText.Enabled = true;
                txtOutput.Enabled = true;
                encryptionKey = "SAIB";
            }
            else if (encryptionTypes.Text == "SIDC Password")
            {
                labelKey.Hide();
                txtCustomKey.Hide();
                buttonSetCustomKey.Hide();
                txtEncText.Enabled = true;
                txtPlainText.Enabled = true;
                txtOutput.Enabled = true;
                encryptionKey = "SIDC Password";
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
                checkBox1.Checked = false;
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
            try
            {
                Clipboard.SetText(txtOutput.Text.ToString());
                label6.Show();
            }
            catch
            {
                MessageBox.Show("Click on Encrypt/Decrypt");
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;            
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.Info;
            t_Tip.ShowAlways = true;
            t_Tip.SetToolTip(txtOutput, "Click to copy");
        }
    }
}
