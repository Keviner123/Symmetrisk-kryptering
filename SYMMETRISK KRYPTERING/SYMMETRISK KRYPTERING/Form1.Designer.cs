namespace SYMMETRISK_KRYPTERING
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
            this.comboBoxAlgorithm = new System.Windows.Forms.ComboBox();
            this.Key = new System.Windows.Forms.Label();
            this.buttonGenerateKeyAndIV = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIV = new System.Windows.Forms.TextBox();
            this.textBoxPlainTextHEX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlainTextASCII = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCipherTextHEX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCipherTextASCII = new System.Windows.Forms.TextBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxAlgorithm
            // 
            this.comboBoxAlgorithm.FormattingEnabled = true;
            this.comboBoxAlgorithm.Location = new System.Drawing.Point(64, 14);
            this.comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            this.comboBoxAlgorithm.Size = new System.Drawing.Size(445, 21);
            this.comboBoxAlgorithm.TabIndex = 0;
            // 
            // Key
            // 
            this.Key.AutoSize = true;
            this.Key.Location = new System.Drawing.Point(12, 49);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(25, 13);
            this.Key.TabIndex = 1;
            this.Key.Text = "Key";
            // 
            // buttonGenerateKeyAndIV
            // 
            this.buttonGenerateKeyAndIV.Location = new System.Drawing.Point(64, 98);
            this.buttonGenerateKeyAndIV.Name = "buttonGenerateKeyAndIV";
            this.buttonGenerateKeyAndIV.Size = new System.Drawing.Size(445, 23);
            this.buttonGenerateKeyAndIV.TabIndex = 2;
            this.buttonGenerateKeyAndIV.Text = "Generate Key and IV";
            this.buttonGenerateKeyAndIV.UseVisualStyleBackColor = true;
            this.buttonGenerateKeyAndIV.Click += new System.EventHandler(this.buttonGenerateKeyAndIV_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(64, 46);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.ReadOnly = true;
            this.textBoxKey.Size = new System.Drawing.Size(445, 20);
            this.textBoxKey.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IV";
            // 
            // textBoxIV
            // 
            this.textBoxIV.Location = new System.Drawing.Point(64, 72);
            this.textBoxIV.Name = "textBoxIV";
            this.textBoxIV.ReadOnly = true;
            this.textBoxIV.Size = new System.Drawing.Size(445, 20);
            this.textBoxIV.TabIndex = 5;
            // 
            // textBoxPlainTextHEX
            // 
            this.textBoxPlainTextHEX.Location = new System.Drawing.Point(57, 46);
            this.textBoxPlainTextHEX.Name = "textBoxPlainTextHEX";
            this.textBoxPlainTextHEX.ReadOnly = true;
            this.textBoxPlainTextHEX.Size = new System.Drawing.Size(452, 20);
            this.textBoxPlainTextHEX.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ASCII";
            // 
            // textBoxPlainTextASCII
            // 
            this.textBoxPlainTextASCII.Location = new System.Drawing.Point(57, 21);
            this.textBoxPlainTextASCII.Name = "textBoxPlainTextASCII";
            this.textBoxPlainTextASCII.Size = new System.Drawing.Size(452, 20);
            this.textBoxPlainTextASCII.TabIndex = 7;
            this.textBoxPlainTextASCII.TextChanged += new System.EventHandler(this.textBoxPlainTextASCII_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "HEX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "HEX";
            // 
            // textBoxCipherTextHEX
            // 
            this.textBoxCipherTextHEX.Location = new System.Drawing.Point(57, 44);
            this.textBoxCipherTextHEX.Name = "textBoxCipherTextHEX";
            this.textBoxCipherTextHEX.ReadOnly = true;
            this.textBoxCipherTextHEX.Size = new System.Drawing.Size(452, 20);
            this.textBoxCipherTextHEX.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ASCII";
            // 
            // textBoxCipherTextASCII
            // 
            this.textBoxCipherTextASCII.Location = new System.Drawing.Point(57, 19);
            this.textBoxCipherTextASCII.Name = "textBoxCipherTextASCII";
            this.textBoxCipherTextASCII.ReadOnly = true;
            this.textBoxCipherTextASCII.Size = new System.Drawing.Size(452, 20);
            this.textBoxCipherTextASCII.TabIndex = 13;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(57, 73);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(452, 23);
            this.buttonDecrypt.TabIndex = 17;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxIV);
            this.groupBox1.Controls.Add(this.comboBoxAlgorithm);
            this.groupBox1.Controls.Add(this.Key);
            this.groupBox1.Controls.Add(this.buttonGenerateKeyAndIV);
            this.groupBox1.Controls.Add(this.textBoxKey);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 136);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key / IV";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxPlainTextASCII);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxPlainTextHEX);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 82);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encryption";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxCipherTextHEX);
            this.groupBox3.Controls.Add(this.textBoxCipherTextASCII);
            this.groupBox3.Controls.Add(this.buttonDecrypt);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 109);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cipher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Algorithm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 360);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Symmetric Cryptography";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAlgorithm;
        private System.Windows.Forms.Label Key;
        private System.Windows.Forms.Button buttonGenerateKeyAndIV;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIV;
        private System.Windows.Forms.TextBox textBoxPlainTextHEX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlainTextASCII;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCipherTextHEX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCipherTextASCII;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
    }
}

