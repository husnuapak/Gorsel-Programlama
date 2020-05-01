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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        public  string islem = "Yeni";
        public  string adi = "";
        public  string soyadi = "";
        public  string telefon= "";
        public  string adres = "";
        public string eadi = "";
        int kayitno=-1 ;
        //toolStripComboBox1
        public void kaydet() {
            if (islem == "Edit")
            {
                toolStripComboBox1.Items.Remove(eadi);
                toolStripComboBox1.Items.Add(adi);
                dataGridView1.Rows[kayitno].Cells[0].Value = kayitno;
                dataGridView1.Rows[kayitno].Cells[1].Value = adi;
                dataGridView1.Rows[kayitno].Cells[2].Value = soyadi;
                dataGridView1.Rows[kayitno].Cells[3].Value = telefon;
                dataGridView1.Rows[kayitno].Cells[4].Value = adres;

                MessageBox.Show("Kayıt Guncellendi");
            }
            else
            {
                toolStripComboBox1.Items.Add(adi);
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = n.ToString();
                dataGridView1.Rows[n].Cells[1].Value = adi;
                dataGridView1.Rows[n].Cells[2].Value = soyadi;
                dataGridView1.Rows[n].Cells[3].Value = telefon;
                dataGridView1.Rows[n].Cells[4].Value = adres;
           

                    MessageBox.Show("Kayıt Eklendi");
            }
            islem = "Yeni";
            adi = "";
            soyadi = "";
            telefon = "";
            adres = "";

        }
  

        public void kayitsil()
        {
            
            dataGridView1.Rows.RemoveAt(kayitno);

            MessageBox.Show("Kayıt Slindi");
            kayitno = -1;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            islem = "Yeni";
            Form3 f3 = new Form3(this);
            f3.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try { 
            islem = "Edit";
            kayitno = dataGridView1.CurrentCell.RowIndex;
            if (kayitno < 0)
            {
                MessageBox.Show("Lütfen Düzenlenecek Kaydı Seçiniz");
            }
            else
            {

                    adi=dataGridView1.Rows[kayitno].Cells[1].Value.ToString() ;
                    eadi = adi;
                    soyadi =dataGridView1.Rows[kayitno].Cells[2].Value.ToString();
                    telefon =dataGridView1.Rows[kayitno].Cells[3].Value.ToString();
                    adres =dataGridView1.Rows[kayitno].Cells[4].Value.ToString();

                    Form3 f3 = new Form3(this);
                f3.ShowDialog();
            }
            }catch(Exception ex)
            {
                MessageBox.Show("Lütfen Düzenlenecek Kaydı Seçiniz");
            }


        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            if (toolStripComboBox1.Text != "")
            {
                bs.Filter = "Column2='" + toolStripComboBox1.Text + "' ";

            }
                dataGridView1.DataSource = bs;


            /*int x = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
              if(row.Cells[1].Value.ToString()== toolStripComboBox1.Text)
              {
                    x++;
              }
            }
            MessageBox.Show("Adı : "+toolStripComboBox1.Text+" Olan "+x.ToString()+" Kayıt Vardır");
            */
        }
    }
}
