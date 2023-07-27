using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at_yarışı_oyunu
{
    public partial class Form2 : Form
    {
        public Form2(int bahis)
        {
            InitializeComponent();
            atama(bahis);
        }
        public int deger;
      public void atama(int bahisdegeri)
        {
            deger = bahisdegeri;
        }
        public int kimkazandı;
        public void kiyas()
        {
            if (kimkazandı == deger)
                 MessageBox.Show("TEBRİKLER BAHSİ KAZANDINIZ.");
            else
                 MessageBox.Show("MAALESEF BAHSİ KAYBETTİNİZ!!");         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        Random rnd = new Random();
        public void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += rnd.Next(5,15);
            pictureBox2.Left += rnd.Next(5,15);
            pictureBox3.Left += rnd.Next(5,15);

            int bsu = pictureBox1.Left + pictureBox1.Width;
            int isu = pictureBox2.Left + pictureBox2.Width;
            int usu = pictureBox3.Left + pictureBox3.Width;

            if (bsu > isu && bsu > usu)
            {
                label11.Text = "1.at yarışı önde götürüyor.";
            }
            else if (isu > bsu && isu > usu)
            {
                label11.Text = "2.at yarışı önde götürüyor.";
            }
            else if (usu > isu && usu > bsu)
                label11.Text = "3.at yarışı önde götürüyor.";

            if (bsu >=label5.Left || isu >= label5.Left ||  usu >= label5.Left)
            {
                timer1.Enabled=false;
                MessageBox.Show("yarış bitti!!");

                if (bsu > isu && bsu > usu)
                {
                    label11.Text = "1.at yarışı kazandı";
                    kimkazandı = 1;
                }
                else if (isu > bsu && isu > usu)
                {
                    label11.Text = "2.at yarışı kazandı";
                    kimkazandı = 2;
                }
                else if (usu > isu && usu > bsu)
                {
                    label11.Text = "3.at yarışı kazandı.";
                    kimkazandı= 3;
                }
                kiyas();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {     
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
