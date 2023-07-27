using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at_yarışı_oyunu
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
     

      //public  int secimmm;
        public void Form4_Load(object sender, EventArgs e)
        {
         

        }
        Class1 class1 = new Class1();
        public void atama1()
        {
           int secim1 = 1;
            class1.secim= secim1;
            //secimmm = (int)secim;
        }
        public void atama2()
        {
           int secim2 = 2;
            class1.secim = secim2;
            //secimmm = (int)secim;
        }
        public void atama3()
        {
           int secim3 = 3;
            class1.secim = secim3;
            //secimmm = (int)secim;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //secim = 1;
            atama1();
            MessageBox.Show("BAHSİNİZ KAYDEDİLDİ. İYİ EĞLENCELER");
            Form1 form = new Form1();
            form.ShowDialog();
            //this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //secim = 2;
            atama2();
            MessageBox.Show("BAHSİNİZ KAYDEDİLDİ. İYİ EĞLENCELER");
            Form1 form = new Form1();
            form.ShowDialog();
            //this.Hide();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //secim = 3;
            atama3();
            MessageBox.Show("BAHSİNİZ KAYDEDİLDİ. İYİ EĞLENCELER");
            Form1 form = new Form1();
            form.ShowDialog();
            //this.Hide();

        }
    }
}
