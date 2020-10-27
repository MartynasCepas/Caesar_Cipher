namespace Caesar_Cipher
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
            this.encryptTextBox = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.encryptLabel = new System.Windows.Forms.Label();
            this.decryptLabel = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.keyTrackBar = new System.Windows.Forms.TrackBar();
            this.decryptTextBox = new System.Windows.Forms.TextBox();
            this.encrypedLabel = new System.Windows.Forms.Label();
            this.decryptedLabel = new System.Windows.Forms.Label();
            this.ecryptedTextBox = new System.Windows.Forms.TextBox();
            this.decryptedTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.keyTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // encryptTextBox
            // 
            this.encryptTextBox.Location = new System.Drawing.Point(23, 184);
            this.encryptTextBox.Multiline = true;
            this.encryptTextBox.Name = "encryptTextBox";
            this.encryptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.encryptTextBox.Size = new System.Drawing.Size(365, 65);
            this.encryptTextBox.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(362, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(118, 17);
            this.title.TabIndex = 1;
            this.title.Text = "Caesar Encryptor";
            // 
            // encryptLabel
            // 
            this.encryptLabel.AutoSize = true;
            this.encryptLabel.Location = new System.Drawing.Point(20, 145);
            this.encryptLabel.Name = "encryptLabel";
            this.encryptLabel.Size = new System.Drawing.Size(106, 17);
            this.encryptLabel.TabIndex = 2;
            this.encryptLabel.Text = "Text to encrypt:";
            // 
            // decryptLabel
            // 
            this.decryptLabel.AutoSize = true;
            this.decryptLabel.Location = new System.Drawing.Point(20, 297);
            this.decryptLabel.Name = "decryptLabel";
            this.decryptLabel.Size = new System.Drawing.Size(106, 17);
            this.decryptLabel.TabIndex = 3;
            this.decryptLabel.Text = "Text to decrypt:";
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(20, 46);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(48, 17);
            this.keyLabel.TabIndex = 4;
            this.keyLabel.Text = "Key: 0";
            // 
            // keyTrackBar
            // 
            this.keyTrackBar.Location = new System.Drawing.Point(23, 77);
            this.keyTrackBar.Maximum = 25;
            this.keyTrackBar.Minimum = -25;
            this.keyTrackBar.Name = "keyTrackBar";
            this.keyTrackBar.Size = new System.Drawing.Size(365, 56);
            this.keyTrackBar.TabIndex = 5;
            this.keyTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // decryptTextBox
            // 
            this.decryptTextBox.Location = new System.Drawing.Point(23, 341);
            this.decryptTextBox.Multiline = true;
            this.decryptTextBox.Name = "decryptTextBox";
            this.decryptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decryptTextBox.Size = new System.Drawing.Size(365, 65);
            this.decryptTextBox.TabIndex = 6;
           
            // 
            // encrypedLabel
            // 
            this.encrypedLabel.AutoSize = true;
            this.encrypedLabel.Location = new System.Drawing.Point(497, 145);
            this.encrypedLabel.Name = "encrypedLabel";
            this.encrypedLabel.Size = new System.Drawing.Size(102, 17);
            this.encrypedLabel.TabIndex = 8;
            this.encrypedLabel.Text = "Encrypted text:";
            // 
            // decryptedLabel
            // 
            this.decryptedLabel.AutoSize = true;
            this.decryptedLabel.Location = new System.Drawing.Point(497, 297);
            this.decryptedLabel.Name = "decryptedLabel";
            this.decryptedLabel.Size = new System.Drawing.Size(103, 17);
            this.decryptedLabel.TabIndex = 10;
            this.decryptedLabel.Text = "Decrypted text:";
            // 
            // ecryptedTextBox
            // 
            this.ecryptedTextBox.Location = new System.Drawing.Point(500, 184);
            this.ecryptedTextBox.Multiline = true;
            this.ecryptedTextBox.Name = "ecryptedTextBox";
            this.ecryptedTextBox.ReadOnly = true;
            this.ecryptedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ecryptedTextBox.Size = new System.Drawing.Size(365, 65);
            this.ecryptedTextBox.TabIndex = 11;
            // 
            // decryptedTextBox
            // 
            this.decryptedTextBox.Location = new System.Drawing.Point(500, 341);
            this.decryptedTextBox.Multiline = true;
            this.decryptedTextBox.Name = "decryptedTextBox";
            this.decryptedTextBox.ReadOnly = true;
            this.decryptedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decryptedTextBox.Size = new System.Drawing.Size(365, 65);
            this.decryptedTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 452);
            this.Controls.Add(this.decryptedTextBox);
            this.Controls.Add(this.ecryptedTextBox);
            this.Controls.Add(this.decryptedLabel);
            this.Controls.Add(this.encrypedLabel);
            this.Controls.Add(this.decryptTextBox);
            this.Controls.Add(this.keyTrackBar);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.decryptLabel);
            this.Controls.Add(this.encryptLabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.encryptTextBox);
            this.Name = "Form1";
            this.Text = "Caesar Encryptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.keyTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox encryptTextBox;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label encryptLabel;
        private System.Windows.Forms.Label decryptLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TrackBar keyTrackBar;
        private System.Windows.Forms.TextBox decryptTextBox;
        private System.Windows.Forms.Label encrypedLabel;
        private System.Windows.Forms.Label decryptedLabel;
        private System.Windows.Forms.TextBox ecryptedTextBox;
        private System.Windows.Forms.TextBox decryptedTextBox;
    }
}

