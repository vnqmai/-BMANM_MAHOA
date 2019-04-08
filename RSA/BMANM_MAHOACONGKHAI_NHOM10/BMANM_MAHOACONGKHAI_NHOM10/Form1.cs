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

namespace BMANM_MAHOACONGKHAI_NHOM10
{
    public partial class Form1 : Form
    {
        private static RsaEnc rsa = new RsaEnc();
        private int numberToCompute = 0;
        private int highestPercentageReached = 0;
        private bool isGenerated = false;
        public Form1()
        {
            InitializeComponent();
            InitializeBackgroundWorker();

            txtPublickey.ReadOnly = true;            
            txtPrivatekey.ReadOnly = true;            
            txtEncryptedFileName.Enabled = false;
            txtDecryptedFileName.Enabled = false;
            btnSavePri.Enabled = false;
            btnSavePub.Enabled = false;

            txtPublickey.MaxLength = 20000000;
            txtPrivatekey.MaxLength = 20000000;

            rtxtDecryptedFile.BackColor = System.Drawing.Color.White;
            rtxtDecryptedFile.ReadOnly = true;
            rtxtEncryptedFile.BackColor = System.Drawing.Color.White;            
            rtxtEncryptedFile.ReadOnly = true;

            if(rbtnUseGenPubkey.Checked == true)
            {
                btnChoosePubkeyFile.Enabled = false;
                txtPubkeyFileName.Enabled = false;
            }
            if (rbtnUseGenPrikey.Checked == true)
            {
                btnChoosePrikeyFile.Enabled = false;
                txtPrikeyFileName.Enabled = false;
            }
        }

        private void InitializeBackgroundWorker()
        {
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void btnChooseFiletoEncrypt_Click(object sender, EventArgs e)
        {            
            if (diagEncryptedFile.ShowDialog()==DialogResult.OK)
            {
                var filePath = diagEncryptedFile.FileName;
                txtEncryptedFileName.Text = filePath;
                rtxtEncryptedFile.LoadFile(filePath, RichTextBoxStreamType.PlainText);

                rtxtEncryptedFile.BackColor = System.Drawing.Color.LightPink;
                rtxtDecryptedFile.BackColor = System.Drawing.Color.White;
                rtxtDecryptedFile.Clear();
                txtDecryptedFileName.Text = "Choose file need to be decrypted...";
            }
        }

        private void btnChooseFiletoDecrypt_Click(object sender, EventArgs e)
        {
            if (diagDecryptedFile.ShowDialog()==DialogResult.OK) {
                var filePath = diagDecryptedFile.FileName;
                txtDecryptedFileName.Text = filePath;
                rtxtDecryptedFile.LoadFile(filePath,RichTextBoxStreamType.PlainText);

                rtxtDecryptedFile.BackColor = System.Drawing.Color.LightPink;
                rtxtEncryptedFile.BackColor = System.Drawing.Color.White;
                rtxtEncryptedFile.Clear();
                txtEncryptedFileName.Text = "Choose file need to be encrypted...";
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {            
            numberToCompute = rsa.sobit;
            highestPercentageReached = 0;
            backgroundWorker1.RunWorkerAsync(numberToCompute);            

            btnSavePub.Enabled = true;
            btnSavePri.Enabled = true;

            isGenerated = true;
        }

        private void btnSavePub_Click(object sender, EventArgs e)
        {
            DialogResult res = folderSavePubkey.ShowDialog();
            if (res == DialogResult.OK)
            {
                string folderPath = folderSavePubkey.SelectedPath;

                FileStream fs = new FileStream(folderPath+"\\publickey.txt", FileMode.Create);                
                StreamWriter swriter = new StreamWriter(fs);
                //swriter.Write(txtPublickey.Text);
                swriter.Write(rsa.PublickeyString());
                swriter.Flush();
                fs.Close();

                MessageBox.Show("Save public key successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void btnSavePri_Click(object sender, EventArgs e)
        {
            DialogResult res = folderSavePrikey.ShowDialog();
            if(res == DialogResult.OK)
            {
                string folderPath = folderSavePrikey.SelectedPath;

                FileStream fs = new FileStream(folderPath+"\\privatekey.txt", FileMode.Create);
                StreamWriter swriter = new StreamWriter(fs);
                //swriter.Write(txtPrivatekey.Text);
                swriter.Write(rsa.PrivatekeyString());
                swriter.Flush();
                fs.Close();

                MessageBox.Show("Save private key successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void btnDecryptPri_Click(object sender, EventArgs e)
        {
            if (rbtnUseGenPrikey.Checked == true)
            {
                if (isGenerated == false)
                {
                    MessageBox.Show("Please generate RSA public/private keys first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (rbtnUsePrikeyFile.Checked == true)
            {
                if (txtPrikeyFileName.Text == "Choose private key file...")
                {
                    MessageBox.Show("Please choose private key file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }                
            }
            if (txtDecryptedFileName.Text == "Choose file need to be decrypted...")
            {
                MessageBox.Show("Please choose file need to be decrypted!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                FileStream fs = new FileStream("privatekey.txt", FileMode.Open);
                StreamReader sreader = new StreamReader(fs);
                string prikey = sreader.ReadLine();
                fs.Close();

                string decrypted = "";
                if (rbtnUseGenPrikey.Checked == true)
                    decrypted = rsa.Decrypt(rtxtDecryptedFile.Text,"");
                else if (rbtnUsePrikeyFile.Checked == true)
                    decrypted = rsa.Decrypt(rtxtDecryptedFile.Text, txtPrikeyFileName.Text);

                fs = new FileStream(txtDecryptedFileName.Text, FileMode.Create);
                StreamWriter swriter = new StreamWriter(fs);
                swriter.Write(decrypted.ToString());
                swriter.Flush();
                fs.Close();

                rtxtDecryptedFile.LoadFile(txtDecryptedFileName.Text, RichTextBoxStreamType.PlainText);
                rtxtDecryptedFile.BackColor = System.Drawing.Color.LightGreen;

                MessageBox.Show("Decrypted successfully!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnEncryptPub_Click(object sender, EventArgs e)
        {
            if (rbtnUseGenPubkey.Checked==true)
            {
                if (isGenerated == false)
                {                    
                    MessageBox.Show("Please generate RSA public/private keys first!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }                
            }
            else if (rbtnUsePubkeyFile.Checked==true)
            {
                if (txtPubkeyFileName.Text== "Choose public key file...")
                {
                    MessageBox.Show("Please choose public key file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }                
            }
            if (txtEncryptedFileName.Text == "Choose file need to be encrypted...")
            {
                MessageBox.Show("Please choose file need to be encrypted!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                FileStream fs = new FileStream("publickey.txt", FileMode.Open);
                StreamReader sreader = new StreamReader(fs);
                string pubkey = sreader.ReadLine();
                fs.Close();

                string encrypted = "";
                if (rbtnUseGenPubkey.Checked == true)
                    encrypted = rsa.Encrypt(rtxtEncryptedFile.Text, "");
                else if (rbtnUsePubkeyFile.Checked == true)
                    encrypted = rsa.Encrypt(rtxtEncryptedFile.Text,txtPubkeyFileName.Text);

                fs = new FileStream(txtEncryptedFileName.Text, FileMode.Create);
                StreamWriter swriter = new StreamWriter(fs);
                swriter.Write(encrypted);
                swriter.Flush();
                fs.Close();

                rtxtEncryptedFile.LoadFile(txtEncryptedFileName.Text, RichTextBoxStreamType.PlainText);
                rtxtEncryptedFile.BackColor = System.Drawing.Color.LightGreen;

                MessageBox.Show("Encrypted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;            
            txtPublickey.Text = rsa.PublickeyString();
            txtPrivatekey.Text = rsa.PrivatekeyString();

            int percentComplete = (int)((float)rsa.sobit / (float)numberToCompute * 100);
            if (percentComplete > highestPercentageReached)
            {
                highestPercentageReached = percentComplete;
                worker.ReportProgress(percentComplete);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (e.Cancelled)
            {
                MessageBox.Show("Generating rsa keys has been cancelled!","Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dia = MessageBox.Show("Generate rsa keys successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(dia == DialogResult.OK)
                {
                    this.progressBar1.Value = 0;
                }
            }

        }

        private void rbtnUsePubkeyFile_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUsePubkeyFile.Checked == true)
            {
                btnChoosePubkeyFile.Enabled = true;
                txtPubkeyFileName.Enabled = false;
            }
        }

        private void rbtnUsePrikeyFile_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUsePrikeyFile.Checked == true)
            {
                btnChoosePrikeyFile.Enabled = true;
                txtPrikeyFileName.Enabled = false;
            }
        }

        private void rbtnUseGenPubkey_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUseGenPubkey.Checked == true)
            {
                btnChoosePubkeyFile.Enabled = false;
                txtPubkeyFileName.Enabled = false;
            }            
        }

        private void rbtnUseGenPrikey_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUseGenPrikey.Checked == true)
            {
                btnChoosePrikeyFile.Enabled = false;
                txtPrikeyFileName.Enabled = false;
            }
        }

        private void btnChoosePubkeyFile_Click(object sender, EventArgs e)
        {
            if (diagPubkeyFile.ShowDialog() == DialogResult.OK)
            {
                var filePath = diagPubkeyFile.FileName;
                txtPubkeyFileName.Text = filePath;                
            }
        }

        private void btnChoosePrikeyFile_Click(object sender, EventArgs e)
        {
            if (diagPrikeyFile.ShowDialog() == DialogResult.OK)
            {
                var filePath = diagPrikeyFile.FileName;
                txtPrikeyFileName.Text = filePath;
            }
        }
    }
}
