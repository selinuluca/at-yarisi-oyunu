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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int secim;
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(secim);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            secim = 1;
            MessageBox.Show("BAHSİNİZ KAYDEDİLDİ. İYİ EĞLENCELER");
            groupBox1.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            secim = 2;
            MessageBox.Show("BAHSİNİZ KAYDEDİLDİ. İYİ EĞLENCELER");
            groupBox1.Visible = false;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            secim = 3;
            MessageBox.Show("BAHSİNİZ KAYDEDİLDİ. İYİ EĞLENCELER");
            groupBox1.Visible = false;

        }

        public void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
