namespace EncryptDecrypt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtEncText = new System.Windows.Forms.TextBox();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.encryptionTypes = new System.Windows.Forms.ListBox();
            this.txtCustomKey = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSetCustomKey = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Controls.Add(this.txtEncText);
            this.groupBox1.Controls.Add(this.txtPlainText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encrypt/Decrypt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtOutput.Enabled = false;
            this.txtOutput.Location = new System.Drawing.Point(10, 112);
            this.txtOutput.MinimumSize = new System.Drawing.Size(4, 60);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(243, 60);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.Click += new System.EventHandler(this.txtOutput_Click);
            // 
            // txtEncText
            // 
            this.txtEncText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncText.Location = new System.Drawing.Point(138, 46);
            this.txtEncText.MinimumSize = new System.Drawing.Size(4, 50);
            this.txtEncText.Multiline = true;
            this.txtEncText.Name = "txtEncText";
            this.txtEncText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEncText.Size = new System.Drawing.Size(115, 50);
            this.txtEncText.TabIndex = 3;
            this.txtEncText.TextChanged += new System.EventHandler(this.txtEncText_TextChanged);
            // 
            // txtPlainText
            // 
            this.txtPlainText.BackColor = System.Drawing.Color.White;
            this.txtPlainText.Location = new System.Drawing.Point(6, 46);
            this.txtPlainText.MinimumSize = new System.Drawing.Size(4, 50);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlainText.Size = new System.Drawing.Size(115, 50);
            this.txtPlainText.TabIndex = 2;
            this.txtPlainText.TextChanged += new System.EventHandler(this.txtPlainText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Encrypted Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plain Text";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(12, 197);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(259, 23);
            this.btnProcess.TabIndex = 5;
            this.btnProcess.Text = "Encrypt/Decrypt";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(13, 226);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(259, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // encryptionTypes
            // 
            this.encryptionTypes.FormattingEnabled = true;
            this.encryptionTypes.Items.AddRange(new object[] {
            "Password",
            "iBank Encryption",
            "Generic",
            "SAIB",
            "SIDC"});
            this.encryptionTypes.Location = new System.Drawing.Point(278, 28);
            this.encryptionTypes.Name = "encryptionTypes";
            this.encryptionTypes.Size = new System.Drawing.Size(127, 95);
            this.encryptionTypes.TabIndex = 7;
            this.encryptionTypes.SelectedIndexChanged += new System.EventHandler(this.encryptionTypes_SelectedIndexChanged);
            // 
            // txtCustomKey
            // 
            this.txtCustomKey.Location = new System.Drawing.Point(282, 197);
            this.txtCustomKey.Name = "txtCustomKey";
            this.txtCustomKey.Size = new System.Drawing.Size(123, 20);
            this.txtCustomKey.TabIndex = 8;
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(279, 181);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(63, 13);
            this.labelKey.TabIndex = 9;
            this.labelKey.Text = "Custom Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Text Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // buttonSetCustomKey
            // 
            this.buttonSetCustomKey.Location = new System.Drawing.Point(282, 226);
            this.buttonSetCustomKey.Name = "buttonSetCustomKey";
            this.buttonSetCustomKey.Size = new System.Drawing.Size(123, 23);
            this.buttonSetCustomKey.TabIndex = 12;
            this.buttonSetCustomKey.Text = "Set Key";
            this.buttonSetCustomKey.UseVisualStyleBackColor = true;
            this.buttonSetCustomKey.Click += new System.EventHandler(this.buttonSetCustomKey_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label6.Location = new System.Drawing.Point(278, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 30);
            this.label6.TabIndex = 13;
            this.label6.Text = "Copied To \r\nClipboard";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(282, 161);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Decrypt JSON Text?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(417, 261);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSetCustomKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.txtCustomKey);
            this.Controls.Add(this.encryptionTypes);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(433, 300);
            this.MinimumSize = new System.Drawing.Size(433, 252);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption / Decryption";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtEncText;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox encryptionTypes;
        private System.Windows.Forms.TextBox txtCustomKey;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSetCustomKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

