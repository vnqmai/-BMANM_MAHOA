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

        public Form1()
        {
            InitializeComponent();
            InitializeBackgroundWorker();

            txtPublickey.ReadOnly = true;
            txtPublickey.Text = rsa.LoadKeyFromFile("publickey.txt");
            txtPrivatekey.ReadOnly = true;
            txtPrivatekey.Text = rsa.LoadKeyFromFile("privatekey.txt");
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
                txtDecryptedFileName.Clear();
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
                txtEncryptedFileName.Clear();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            numberToCompute = rsa.sobit;
            highestPercentageReached = 0;
            backgroundWorker1.RunWorkerAsync(numberToCompute);            

            btnSavePub.Enabled = true;
            btnSavePri.Enabled = true;
        }

        private void btnSavePub_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("publickey.txt",FileMode.Create);
            StreamWriter swriter = new StreamWriter(fs);
            //swriter.Write(txtPublickey.Text);
            swriter.Write(rsa.PublickeyString());
            swriter.Flush();
            fs.Close();
            MessageBox.Show("Save public key successfully!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnSavePri_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("privatekey.txt", FileMode.Create);
            StreamWriter swriter = new StreamWriter(fs);
            //swriter.Write(txtPrivatekey.Text);
            swriter.Write(rsa.PrivatekeyString());
            swriter.Flush();
            fs.Close();
            MessageBox.Show("Save private key successfully!", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private int getMaxBlockSize(int keySize)
        {
            int max = ((int)(keySize / 8 / 3)) * 4;            
            if ((keySize/8)% 3!= 0){
                max += 4;
            }
            return max;
        }
        private void btnDecryptPri_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("privatekey.txt", FileMode.Open);
                StreamReader sreader = new StreamReader(fs);
                string prikey = sreader.ReadLine();
                fs.Close();

                string decrypted = rsa.Decrypt(rtxtDecryptedFile.Text);
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
            try
            {
                FileStream fs = new FileStream("publickey.txt", FileMode.Open);
                StreamReader sreader = new StreamReader(fs);
                string pubkey = sreader.ReadLine();
                fs.Close();

                string encrypted = rsa.Encrypt(rtxtEncryptedFile.Text);

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
    }
}
