using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, ortalama;

            sayi1 = Convert.ToInt32(textBox2.Text);
            sayi2 = Convert.ToInt32(textBox3.Text);

            ortalama = (sayi1 + sayi2) / 2;

            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(ortalama);

            if (ortalama >= 50)
            {
                listBox5.Items.Add("Geçti");
            }
            else
            {
                listBox5.Items.Add("Kaldı");
            }
        }
    }
}
