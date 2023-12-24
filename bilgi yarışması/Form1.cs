using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;

            label5.Text = btnB.Text;
            if(label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled=true;

            label5.Text = btnC.Text;
            if(label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlıs.Text=yanlis.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled=true;

            label5.Text = btnD.Text;
            if(label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;

            label5.Text = btnA.Text;
            if(label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnsonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            soruno++;
            lblsoruno.Text = soruno.ToString();

            if(soruno ==1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label4.Text = "1923";
            }
            if(soruno == 2)
            {
                richTextBox1.Text = "Hangi il Ege bölgemizde bulunmaz ?";
                btnA.Text = "izmir";
                btnB.Text = "balıkesir";
                btnC.Text = "aydın";
                btnD.Text = "manisa";
                label4.Text = "balıkesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son kuşlar hangi yazara aittir ?";
                btnA.Text = "sait faik ";
                btnB.Text = "cemal süreyya";
                btnC.Text = "atilla ilhan";
                btnD.Text = "reşat nuri";
                label4.Text = "sait faik ";
                btnsonraki.Text = "Sonuçlar";
            }
            if (soruno == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnsonraki.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış:" + yanlis);
            }
            {
                
            }
        }
    }
}
