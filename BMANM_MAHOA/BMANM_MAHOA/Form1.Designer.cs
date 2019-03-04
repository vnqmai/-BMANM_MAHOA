namespace BMANM_MAHOA
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtO = new System.Windows.Forms.TextBox();
            this.btnM = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.radioCeasar = new System.Windows.Forms.RadioButton();
            this.radioViginere = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "K";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "O";
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(86, 45);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(100, 20);
            this.txtIn.TabIndex = 3;
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(86, 81);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 20);
            this.txtK.TabIndex = 4;
            // 
            // txtO
            // 
            this.txtO.Location = new System.Drawing.Point(86, 117);
            this.txtO.Name = "txtO";
            this.txtO.Size = new System.Drawing.Size(100, 20);
            this.txtO.TabIndex = 5;
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(155, 9);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(45, 23);
            this.btnM.TabIndex = 6;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnG
            // 
            this.btnG.Location = new System.Drawing.Point(206, 9);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(52, 23);
            this.btnG.TabIndex = 7;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // radioCeasar
            // 
            this.radioCeasar.AutoSize = true;
            this.radioCeasar.Location = new System.Drawing.Point(10, 12);
            this.radioCeasar.Name = "radioCeasar";
            this.radioCeasar.Size = new System.Drawing.Size(58, 17);
            this.radioCeasar.TabIndex = 8;
            this.radioCeasar.TabStop = true;
            this.radioCeasar.Text = "Ceasar";
            this.radioCeasar.UseVisualStyleBackColor = true;
            this.radioCeasar.CheckedChanged += new System.EventHandler(this.radioCeasar_CheckedChanged);
            // 
            // radioViginere
            // 
            this.radioViginere.AutoSize = true;
            this.radioViginere.Location = new System.Drawing.Point(74, 12);
            this.radioViginere.Name = "radioViginere";
            this.radioViginere.Size = new System.Drawing.Size(70, 17);
            this.radioViginere.TabIndex = 9;
            this.radioViginere.TabStop = true;
            this.radioViginere.Text = "Vigernere";
            this.radioViginere.UseVisualStyleBackColor = true;
            this.radioViginere.CheckedChanged += new System.EventHandler(this.radioViginere_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 155);
            this.Controls.Add(this.radioViginere);
            this.Controls.Add(this.radioCeasar);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.txtO);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtO;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.RadioButton radioCeasar;
        private System.Windows.Forms.RadioButton radioViginere;
    }
}

