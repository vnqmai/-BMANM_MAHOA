using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMANM_MAHOA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            if (radioCeasar.Checked == true)
            {
                Ceasar c = new Ceasar(int.Parse(txtK.Text), txtIn.Text,null);
                txtO.Text = c.mahoa();
            }
            else if (radioViginere.Checked == true)
            {
                Vigernere v = new Vigernere(txtK.Text,txtIn.Text,null);
                txtO.Text = v.MaHoa();
            }
        }

        private void radioCeasar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioViginere_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnG_Click(object sender, EventArgs e)
        {
            if (radioCeasar.Checked == true)
            {
                Ceasar c = new Ceasar(int.Parse(txtK.Text), null, txtIn.Text);
                txtO.Text = c.giaima();
            }
            else if (radioViginere.Checked == true)
            {
                Vigernere v = new Vigernere(txtK.Text,null, txtIn.Text);
                txtO.Text = v.GiaiMa();
            }
        }
    }
}
