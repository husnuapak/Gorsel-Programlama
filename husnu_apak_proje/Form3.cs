using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace husnu_apak_proje
{
    public partial class Form3 : Form
    {
        private Form1 f1;

        public Form3(Form1 frm1)
        {
            InitializeComponent();
            f1 = frm1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (f1.islem == "Yeni")
            {
                button2.Enabled = false;
            }
            else
            {
                textBox1.Text= f1.adi ;
                textBox2.Text= f1.soyadi ;
                textBox3.Text= f1.telefon ;
                richTextBox1.Text= f1.adres ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Ad Giriniz");
                label5.Text = "Lütfen Adınızı Giriniz";
                label5.Visible = true;

            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Lütfen Soyad Giriniz");
                label5.Text = "Lütfen Soyad Giriniz";
                label5.Visible = true;
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Lütfen Telefon  Giriniz");
                label5.Text = "Lütfen Telefon Giriniz";
                label5.Visible = true;
            }
            else if (richTextBox1.Text == "")
            {
                MessageBox.Show("Lütfen Adres Giriniz");
                label5.Text = "Lütfen Adres Giriniz";
                label5.Visible = true;
            }
            else {
                label5.Visible = false;
                f1.adi = textBox1.Text;
                f1.soyadi = textBox2.Text;
                f1.telefon = textBox3.Text;
                f1.adres = richTextBox1.Text;
                f1.kaydet();
                textBox1.Text="";
                textBox2.Text = "";
                textBox3.Text = "";
                richTextBox1.Text="";
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            richTextBox1.Text = "";

            f1.kayitsil();
            this.Close();
        }
    }
}
