namespace SaugumasDarbas2
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
            this.label1 = new System.Windows.Forms.Label();
            this.encryptTextbox = new System.Windows.Forms.TextBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.descrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.decryptedTextLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.encryptedTextTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.decryptedFileTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textToDecrypt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.decryptedTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iveskite teksta:";
            // 
            // encryptTextbox
            // 
            this.encryptTextbox.Location = new System.Drawing.Point(85, 111);
            this.encryptTextbox.Name = "encryptTextbox";
            this.encryptTextbox.Size = new System.Drawing.Size(276, 20);
            this.encryptTextbox.TabIndex = 1;
            // 
            // Encrypt
            // 
            this.Encrypt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encrypt.Location = new System.Drawing.Point(85, 260);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(122, 38);
            this.Encrypt.TabIndex = 2;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click_1);
            // 
            // descrypt
            // 
            this.descrypt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrypt.Location = new System.Drawing.Point(459, 195);
            this.descrypt.Name = "descrypt";
            this.descrypt.Size = new System.Drawing.Size(122, 38);
            this.descrypt.TabIndex = 5;
            this.descrypt.Text = "Descrypt";
            this.descrypt.UseVisualStyleBackColor = true;
            this.descrypt.Click += new System.EventHandler(this.descrypt_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // decryptedTextLabel
            // 
            this.decryptedTextLabel.AutoSize = true;
            this.decryptedTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptedTextLabel.Location = new System.Drawing.Point(386, 260);
            this.decryptedTextLabel.Name = "decryptedTextLabel";
            this.decryptedTextLabel.Size = new System.Drawing.Size(0, 24);
            this.decryptedTextLabel.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 39);
            this.label4.TabIndex = 19;
            this.label4.Text = "ENCRYPTION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(452, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(435, 39);
            this.label5.TabIndex = 20;
            this.label5.Text = "DECRYPTION FROM FILE";
            // 
            // encryptedTextTextbox
            // 
            this.encryptedTextTextbox.Location = new System.Drawing.Point(86, 171);
            this.encryptedTextTextbox.Multiline = true;
            this.encryptedTextTextbox.Name = "encryptedTextTextbox";
            this.encryptedTextTextbox.Size = new System.Drawing.Size(275, 62);
            this.encryptedTextTextbox.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Encrypted text";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(455, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "Decrypted text";
            // 
            // decryptedFileTextbox
            // 
            this.decryptedFileTextbox.Location = new System.Drawing.Point(459, 111);
            this.decryptedFileTextbox.Multiline = true;
            this.decryptedFileTextbox.Name = "decryptedFileTextbox";
            this.decryptedFileTextbox.Size = new System.Drawing.Size(275, 62);
            this.decryptedFileTextbox.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 39);
            this.label8.TabIndex = 34;
            this.label8.Text = "DECRYPTION";
            // 
            // textToDecrypt
            // 
            this.textToDecrypt.Location = new System.Drawing.Point(85, 409);
            this.textToDecrypt.Multiline = true;
            this.textToDecrypt.Name = "textToDecrypt";
            this.textToDecrypt.Size = new System.Drawing.Size(275, 61);
            this.textToDecrypt.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(82, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(268, 24);
            this.label9.TabIndex = 32;
            this.label9.Text = "Iveskite uzsifruota teksta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(81, 485);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 24);
            this.label10.TabIndex = 37;
            this.label10.Text = "Decrypted text";
            // 
            // decryptedTextbox
            // 
            this.decryptedTextbox.Location = new System.Drawing.Point(85, 526);
            this.decryptedTextbox.Multiline = true;
            this.decryptedTextbox.Name = "decryptedTextbox";
            this.decryptedTextbox.Size = new System.Drawing.Size(275, 62);
            this.decryptedTextbox.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(86, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 38);
            this.button1.TabIndex = 35;
            this.button1.Text = "Descrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 666);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.decryptedTextbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textToDecrypt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.decryptedFileTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.encryptedTextTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.decryptedTextLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.encryptTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox encryptTextbox;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button descrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label decryptedTextLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox encryptedTextTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox decryptedFileTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textToDecrypt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox decryptedTextbox;
        private System.Windows.Forms.Button button1;
    }
}

