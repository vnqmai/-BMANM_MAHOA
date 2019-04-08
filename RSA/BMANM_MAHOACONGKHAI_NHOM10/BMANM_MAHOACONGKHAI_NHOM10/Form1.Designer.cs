namespace BMANM_MAHOACONGKHAI_NHOM10
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSavePub = new System.Windows.Forms.Button();
            this.btnSavePri = new System.Windows.Forms.Button();
            this.btnEncryptPub = new System.Windows.Forms.Button();
            this.btnDecryptPri = new System.Windows.Forms.Button();
            this.txtPublickey = new System.Windows.Forms.TextBox();
            this.txtPrivatekey = new System.Windows.Forms.TextBox();
            this.rtxtEncryptedFile = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEncryptedFileName = new System.Windows.Forms.TextBox();
            this.btnChooseFiletoEncrypt = new System.Windows.Forms.Button();
            this.rtxtDecryptedFile = new System.Windows.Forms.RichTextBox();
            this.diagEncryptedFile = new System.Windows.Forms.OpenFileDialog();
            this.diagDecryptedFile = new System.Windows.Forms.OpenFileDialog();
            this.btnChooseFiletoDecrypt = new System.Windows.Forms.Button();
            this.txtDecryptedFileName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnChoosePubkeyFile = new System.Windows.Forms.Button();
            this.txtPubkeyFileName = new System.Windows.Forms.TextBox();
            this.rbtnUseGenPubkey = new System.Windows.Forms.RadioButton();
            this.rbtnUsePubkeyFile = new System.Windows.Forms.RadioButton();
            this.txtPrikeyFileName = new System.Windows.Forms.TextBox();
            this.btnChoosePrikeyFile = new System.Windows.Forms.Button();
            this.rbtnUsePrikeyFile = new System.Windows.Forms.RadioButton();
            this.rbtnUseGenPrikey = new System.Windows.Forms.RadioButton();
            this.diagPrikeyFile = new System.Windows.Forms.OpenFileDialog();
            this.diagPubkeyFile = new System.Windows.Forms.OpenFileDialog();
            this.folderSavePubkey = new System.Windows.Forms.FolderBrowserDialog();
            this.folderSavePrikey = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(382, 159);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(95, 29);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSavePub
            // 
            this.btnSavePub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePub.Location = new System.Drawing.Point(146, 91);
            this.btnSavePub.Name = "btnSavePub";
            this.btnSavePub.Size = new System.Drawing.Size(95, 27);
            this.btnSavePub.TabIndex = 1;
            this.btnSavePub.Text = "Save";
            this.btnSavePub.UseVisualStyleBackColor = true;
            this.btnSavePub.Click += new System.EventHandler(this.btnSavePub_Click);
            // 
            // btnSavePri
            // 
            this.btnSavePri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePri.Location = new System.Drawing.Point(146, 93);
            this.btnSavePri.Name = "btnSavePri";
            this.btnSavePri.Size = new System.Drawing.Size(95, 26);
            this.btnSavePri.TabIndex = 2;
            this.btnSavePri.Text = "Save";
            this.btnSavePri.UseVisualStyleBackColor = true;
            this.btnSavePri.Click += new System.EventHandler(this.btnSavePri_Click);
            // 
            // btnEncryptPub
            // 
            this.btnEncryptPub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptPub.Location = new System.Drawing.Point(162, 282);
            this.btnEncryptPub.Name = "btnEncryptPub";
            this.btnEncryptPub.Size = new System.Drawing.Size(95, 33);
            this.btnEncryptPub.TabIndex = 3;
            this.btnEncryptPub.Text = "Encrypt";
            this.btnEncryptPub.UseVisualStyleBackColor = true;
            this.btnEncryptPub.Click += new System.EventHandler(this.btnEncryptPub_Click);
            // 
            // btnDecryptPri
            // 
            this.btnDecryptPri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptPri.Location = new System.Drawing.Point(172, 282);
            this.btnDecryptPri.Name = "btnDecryptPri";
            this.btnDecryptPri.Size = new System.Drawing.Size(95, 33);
            this.btnDecryptPri.TabIndex = 4;
            this.btnDecryptPri.Text = "Decrypt";
            this.btnDecryptPri.UseVisualStyleBackColor = true;
            this.btnDecryptPri.Click += new System.EventHandler(this.btnDecryptPri_Click);
            // 
            // txtPublickey
            // 
            this.txtPublickey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublickey.Location = new System.Drawing.Point(13, 25);
            this.txtPublickey.Multiline = true;
            this.txtPublickey.Name = "txtPublickey";
            this.txtPublickey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPublickey.Size = new System.Drawing.Size(366, 60);
            this.txtPublickey.TabIndex = 7;
            // 
            // txtPrivatekey
            // 
            this.txtPrivatekey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrivatekey.Location = new System.Drawing.Point(13, 25);
            this.txtPrivatekey.Multiline = true;
            this.txtPrivatekey.Name = "txtPrivatekey";
            this.txtPrivatekey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrivatekey.Size = new System.Drawing.Size(366, 62);
            this.txtPrivatekey.TabIndex = 8;
            // 
            // rtxtEncryptedFile
            // 
            this.rtxtEncryptedFile.Location = new System.Drawing.Point(14, 163);
            this.rtxtEncryptedFile.Name = "rtxtEncryptedFile";
            this.rtxtEncryptedFile.Size = new System.Drawing.Size(372, 113);
            this.rtxtEncryptedFile.TabIndex = 9;
            this.rtxtEncryptedFile.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 240);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RSA";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPrivatekey);
            this.groupBox5.Controls.Add(this.btnSavePri);
            this.groupBox5.Location = new System.Drawing.Point(440, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(409, 127);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Private key";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPublickey);
            this.groupBox4.Controls.Add(this.btnSavePub);
            this.groupBox4.Location = new System.Drawing.Point(16, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(418, 127);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Public key";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(22, 194);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(827, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnUsePubkeyFile);
            this.groupBox2.Controls.Add(this.rbtnUseGenPubkey);
            this.groupBox2.Controls.Add(this.txtPubkeyFileName);
            this.groupBox2.Controls.Add(this.btnChoosePubkeyFile);
            this.groupBox2.Controls.Add(this.txtEncryptedFileName);
            this.groupBox2.Controls.Add(this.btnChooseFiletoEncrypt);
            this.groupBox2.Controls.Add(this.rtxtEncryptedFile);
            this.groupBox2.Controls.Add(this.btnEncryptPub);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 321);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encrypt file with public key";
            // 
            // txtEncryptedFileName
            // 
            this.txtEncryptedFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptedFileName.Location = new System.Drawing.Point(123, 114);
            this.txtEncryptedFileName.Name = "txtEncryptedFileName";
            this.txtEncryptedFileName.Size = new System.Drawing.Size(263, 26);
            this.txtEncryptedFileName.TabIndex = 13;
            this.txtEncryptedFileName.Text = "Choose file need to be encrypted...";
            // 
            // btnChooseFiletoEncrypt
            // 
            this.btnChooseFiletoEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFiletoEncrypt.Location = new System.Drawing.Point(14, 115);
            this.btnChooseFiletoEncrypt.Name = "btnChooseFiletoEncrypt";
            this.btnChooseFiletoEncrypt.Size = new System.Drawing.Size(103, 26);
            this.btnChooseFiletoEncrypt.TabIndex = 12;
            this.btnChooseFiletoEncrypt.Text = "Choose";
            this.btnChooseFiletoEncrypt.UseVisualStyleBackColor = true;
            this.btnChooseFiletoEncrypt.Click += new System.EventHandler(this.btnChooseFiletoEncrypt_Click);
            // 
            // rtxtDecryptedFile
            // 
            this.rtxtDecryptedFile.Location = new System.Drawing.Point(15, 163);
            this.rtxtDecryptedFile.Name = "rtxtDecryptedFile";
            this.rtxtDecryptedFile.Size = new System.Drawing.Size(420, 113);
            this.rtxtDecryptedFile.TabIndex = 14;
            this.rtxtDecryptedFile.Text = "";
            // 
            // diagEncryptedFile
            // 
            this.diagEncryptedFile.FileName = "openFileDialog1";
            // 
            // diagDecryptedFile
            // 
            this.diagDecryptedFile.FileName = "openFileDialog2";
            // 
            // btnChooseFiletoDecrypt
            // 
            this.btnChooseFiletoDecrypt.Location = new System.Drawing.Point(15, 114);
            this.btnChooseFiletoDecrypt.Name = "btnChooseFiletoDecrypt";
            this.btnChooseFiletoDecrypt.Size = new System.Drawing.Size(103, 26);
            this.btnChooseFiletoDecrypt.TabIndex = 13;
            this.btnChooseFiletoDecrypt.Text = "Choose";
            this.btnChooseFiletoDecrypt.UseVisualStyleBackColor = true;
            this.btnChooseFiletoDecrypt.Click += new System.EventHandler(this.btnChooseFiletoDecrypt_Click);
            // 
            // txtDecryptedFileName
            // 
            this.txtDecryptedFileName.Location = new System.Drawing.Point(124, 114);
            this.txtDecryptedFileName.Name = "txtDecryptedFileName";
            this.txtDecryptedFileName.Size = new System.Drawing.Size(311, 26);
            this.txtDecryptedFileName.TabIndex = 15;
            this.txtDecryptedFileName.Text = "Choose file need to be decrypted...";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnUsePrikeyFile);
            this.groupBox3.Controls.Add(this.rbtnUseGenPrikey);
            this.groupBox3.Controls.Add(this.txtPrikeyFileName);
            this.groupBox3.Controls.Add(this.btnChoosePrikeyFile);
            this.groupBox3.Controls.Add(this.txtDecryptedFileName);
            this.groupBox3.Controls.Add(this.rtxtDecryptedFile);
            this.groupBox3.Controls.Add(this.btnChooseFiletoDecrypt);
            this.groupBox3.Controls.Add(this.btnDecryptPri);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(426, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 321);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Decrypt file with private key";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnChoosePubkeyFile
            // 
            this.btnChoosePubkeyFile.Location = new System.Drawing.Point(14, 82);
            this.btnChoosePubkeyFile.Name = "btnChoosePubkeyFile";
            this.btnChoosePubkeyFile.Size = new System.Drawing.Size(103, 27);
            this.btnChoosePubkeyFile.TabIndex = 14;
            this.btnChoosePubkeyFile.Text = "Choose";
            this.btnChoosePubkeyFile.UseVisualStyleBackColor = true;
            this.btnChoosePubkeyFile.Click += new System.EventHandler(this.btnChoosePubkeyFile_Click);
            // 
            // txtPubkeyFileName
            // 
            this.txtPubkeyFileName.Location = new System.Drawing.Point(123, 82);
            this.txtPubkeyFileName.Name = "txtPubkeyFileName";
            this.txtPubkeyFileName.Size = new System.Drawing.Size(263, 26);
            this.txtPubkeyFileName.TabIndex = 15;
            this.txtPubkeyFileName.Text = "Choose public key file...";
            // 
            // rbtnUseGenPubkey
            // 
            this.rbtnUseGenPubkey.AutoSize = true;
            this.rbtnUseGenPubkey.Checked = true;
            this.rbtnUseGenPubkey.Location = new System.Drawing.Point(14, 39);
            this.rbtnUseGenPubkey.Name = "rbtnUseGenPubkey";
            this.rbtnUseGenPubkey.Size = new System.Drawing.Size(161, 24);
            this.rbtnUseGenPubkey.TabIndex = 13;
            this.rbtnUseGenPubkey.TabStop = true;
            this.rbtnUseGenPubkey.Text = "Use generated key";
            this.rbtnUseGenPubkey.UseVisualStyleBackColor = true;
            this.rbtnUseGenPubkey.CheckedChanged += new System.EventHandler(this.rbtnUseGenPubkey_CheckedChanged);
            // 
            // rbtnUsePubkeyFile
            // 
            this.rbtnUsePubkeyFile.AutoSize = true;
            this.rbtnUsePubkeyFile.Location = new System.Drawing.Point(181, 39);
            this.rbtnUsePubkeyFile.Name = "rbtnUsePubkeyFile";
            this.rbtnUsePubkeyFile.Size = new System.Drawing.Size(108, 24);
            this.rbtnUsePubkeyFile.TabIndex = 16;
            this.rbtnUsePubkeyFile.Text = "Use key file";
            this.rbtnUsePubkeyFile.UseVisualStyleBackColor = true;
            this.rbtnUsePubkeyFile.CheckedChanged += new System.EventHandler(this.rbtnUsePubkeyFile_CheckedChanged);
            // 
            // txtPrikeyFileName
            // 
            this.txtPrikeyFileName.Location = new System.Drawing.Point(124, 82);
            this.txtPrikeyFileName.Name = "txtPrikeyFileName";
            this.txtPrikeyFileName.Size = new System.Drawing.Size(311, 26);
            this.txtPrikeyFileName.TabIndex = 18;
            this.txtPrikeyFileName.Text = "Choose private key file...";
            // 
            // btnChoosePrikeyFile
            // 
            this.btnChoosePrikeyFile.Location = new System.Drawing.Point(15, 82);
            this.btnChoosePrikeyFile.Name = "btnChoosePrikeyFile";
            this.btnChoosePrikeyFile.Size = new System.Drawing.Size(103, 27);
            this.btnChoosePrikeyFile.TabIndex = 17;
            this.btnChoosePrikeyFile.Text = "Choose";
            this.btnChoosePrikeyFile.UseVisualStyleBackColor = true;
            this.btnChoosePrikeyFile.Click += new System.EventHandler(this.btnChoosePrikeyFile_Click);
            // 
            // rbtnUsePrikeyFile
            // 
            this.rbtnUsePrikeyFile.AutoSize = true;
            this.rbtnUsePrikeyFile.Location = new System.Drawing.Point(184, 39);
            this.rbtnUsePrikeyFile.Name = "rbtnUsePrikeyFile";
            this.rbtnUsePrikeyFile.Size = new System.Drawing.Size(108, 24);
            this.rbtnUsePrikeyFile.TabIndex = 18;
            this.rbtnUsePrikeyFile.Text = "Use key file";
            this.rbtnUsePrikeyFile.UseVisualStyleBackColor = true;
            this.rbtnUsePrikeyFile.CheckedChanged += new System.EventHandler(this.rbtnUsePrikeyFile_CheckedChanged);
            // 
            // rbtnUseGenPrikey
            // 
            this.rbtnUseGenPrikey.AutoSize = true;
            this.rbtnUseGenPrikey.Checked = true;
            this.rbtnUseGenPrikey.Location = new System.Drawing.Point(17, 39);
            this.rbtnUseGenPrikey.Name = "rbtnUseGenPrikey";
            this.rbtnUseGenPrikey.Size = new System.Drawing.Size(161, 24);
            this.rbtnUseGenPrikey.TabIndex = 17;
            this.rbtnUseGenPrikey.TabStop = true;
            this.rbtnUseGenPrikey.Text = "Use generated key";
            this.rbtnUseGenPrikey.UseVisualStyleBackColor = true;
            this.rbtnUseGenPrikey.CheckedChanged += new System.EventHandler(this.rbtnUseGenPrikey_CheckedChanged);
            // 
            // diagPrikeyFile
            // 
            this.diagPrikeyFile.FileName = "privatekey.txt";
            // 
            // diagPubkeyFile
            // 
            this.diagPubkeyFile.FileName = "publickey.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 591);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Mã hóa công khai nhóm 10";
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSavePub;
        private System.Windows.Forms.Button btnSavePri;
        private System.Windows.Forms.Button btnEncryptPub;
        private System.Windows.Forms.Button btnDecryptPri;
        private System.Windows.Forms.TextBox txtPublickey;
        private System.Windows.Forms.TextBox txtPrivatekey;
        private System.Windows.Forms.RichTextBox rtxtEncryptedFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEncryptedFileName;
        private System.Windows.Forms.Button btnChooseFiletoEncrypt;
        private System.Windows.Forms.RichTextBox rtxtDecryptedFile;
        private System.Windows.Forms.OpenFileDialog diagEncryptedFile;
        private System.Windows.Forms.OpenFileDialog diagDecryptedFile;
        private System.Windows.Forms.Button btnChooseFiletoDecrypt;
        private System.Windows.Forms.TextBox txtDecryptedFileName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPubkeyFileName;
        private System.Windows.Forms.Button btnChoosePubkeyFile;
        private System.Windows.Forms.RadioButton rbtnUsePubkeyFile;
        private System.Windows.Forms.RadioButton rbtnUseGenPubkey;
        private System.Windows.Forms.RadioButton rbtnUsePrikeyFile;
        private System.Windows.Forms.RadioButton rbtnUseGenPrikey;
        private System.Windows.Forms.TextBox txtPrikeyFileName;
        private System.Windows.Forms.Button btnChoosePrikeyFile;
        private System.Windows.Forms.OpenFileDialog diagPrikeyFile;
        private System.Windows.Forms.OpenFileDialog diagPubkeyFile;
        private System.Windows.Forms.FolderBrowserDialog folderSavePubkey;
        private System.Windows.Forms.FolderBrowserDialog folderSavePrikey;
    }
}

