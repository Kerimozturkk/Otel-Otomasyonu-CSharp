using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_1170505031_Kerim_Öztürk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void rez_listele_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();

        }

        private void rez_guncelle_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void rez_iptal_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.form1 = this;
            form4.Show();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oda_1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.form1 = this;
            form2.Show();
            form2.rez__olustur_oda_numarası.Text = "Oda Adı: " + oda_1.Name.ToString();
            form2.manzara.Text = "Manzara: Var";
            form2.odaServisi.Text = "Oda servisi: Var";
            form2.Oda_Id.Text = "1";
            form2.btn_adı.Text = oda_1.Name;
        }

        private void oda_2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.form1 = this;
            form2.Show();
            form2.rez__olustur_oda_numarası.Text = "Oda Adı: " + oda_2.Name.ToString();
            form2.manzara.Text = "Manzara: Yok";
            form2.odaServisi.Text = "Oda servisi: Var";
            form2.Oda_Id.Text = "2";
            form2.btn_adı.Text = oda_2.Name;
        }

        private void oda_3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.form1 = this;
            form2.Show();
            form2.rez__olustur_oda_numarası.Text = "Oda Adı: " + oda_3.Name.ToString();
            form2.manzara.Text = "Manzara: Yok";
            form2.odaServisi.Text = "Oda servisi: Var";
            form2.Oda_Id.Text = "3";
            form2.btn_adı.Text = oda_3.Name;
        }

        private void oda_4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.form1 = this;
            form2.Show();
            form2.rez__olustur_oda_numarası.Text = "Oda Adı: " + oda_4.Name.ToString();
            form2.manzara.Text = "Manzara: Var";
            form2.odaServisi.Text = "Oda servisi: Yok";
            form2.Oda_Id.Text = "4";
            form2.btn_adı.Text = oda_4.Name;
        }

        private void oda_5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.form1 = this;
            form2.Show();
            form2.rez__olustur_oda_numarası.Text = "Oda Adı: " + oda_5.Name.ToString();
            form2.manzara.Text = "Manzara: Var";
            form2.odaServisi.Text = "Oda servisi: Yok";
            form2.Oda_Id.Text = "5";
            form2.btn_adı.Text = oda_5.Name;
        }

        private void oda_6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.form1 = this;
            form2.Show();
            form2.rez__olustur_oda_numarası.Text = "Oda Adı: " + oda_6.Name.ToString();
            form2.manzara.Text = "Manzara: Var";
            form2.odaServisi.Text = "Oda servisi: Var";
            form2.Oda_Id.Text = "6";
            form2.btn_adı.Text = oda_6.Name;
        }

        private void oda_7_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.form1 = this;
            form2.Show();
            form2.rez__olustur_oda_numarası.Text = "Oda Adı: " + oda_7.Name.ToString();
            form2.manzara.Text = "Manzara: Yok";
            form2.odaServisi.Text = "Oda servisi: Var";
            form2.Oda_Id.Text = "7";
            form2.btn_adı.Text = oda_7.Name;
        }

        private void oda_8_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.form1 = this;
            form2.Show();
            form2.rez__olustur_oda_numarası.Text = "Oda Adı: " + oda_8.Name.ToString();
            form2.manzara.Text = "Manzara: Yok";
            form2.odaServisi.Text = "Oda servisi: Var";
            form2.Oda_Id.Text = "8";
            form2.btn_adı.Text = oda_8.Name;
        }

        private void oda_9_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.form1 = this;
            form2.Show();
            form2.rez__olustur_oda_numarası.Text = "Oda Adı: " + oda_9.Name.ToString();
            form2.manzara.Text = "Manzara: Var";
            form2.odaServisi.Text = "Oda servisi: Yok";
            form2.Oda_Id.Text = "9";
            form2.btn_adı.Text = oda_9.Name;
        }

        private void oda_10_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.form1 = this;
            form2.Show();
            form2.rez__olustur_oda_numarası.Text = "Oda Adı: " + oda_10.Name.ToString();
            form2.manzara.Text = "Manzara: Var";
            form2.odaServisi.Text = "Oda servisi: Yok";
            form2.Oda_Id.Text = "10";
            form2.btn_adı.Text = oda_10.Name;
        }

        private void oda_11_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.form1 = this;
            form2.Show();
            form2.rez__olustur_oda_numarası.Text = "Oda Adı: " + oda_11.Name.ToString();
            form2.manzara.Text = "Manzara: Var";
            form2.odaServisi.Text = "Oda servisi: Var";
            form2.Oda_Id.Text = "11";
            form2.btn_adı.Text = oda_11.Name;
        }

        private void oda_12_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.form1 = this;
            form2.Show();
            form2.rez__olustur_oda_numarası.Text = "Oda Adı: " + oda_12.Name.ToString();
            form2.manzara.Text = "Manzara: Yok";
            form2.odaServisi.Text = "Oda servisi: Var";
            form2.Oda_Id.Text = "12";
            form2.btn_adı.Text = oda_12.Name;
        }

        private void oda_13_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.form1 = this;
            form2.Show();
            form2.rez__olustur_oda_numarası.Text = "Oda Adı: " + oda_13.Name.ToString();
            form2.manzara.Text = "Manzara: Yok";
            form2.odaServisi.Text = "Oda servisi: Var";
            form2.Oda_Id.Text = "13";
            form2.btn_adı.Text = oda_13.Name;
        }

        private void oda_14_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.form1 = this;
            form2.Show();
            form2.rez__olustur_oda_numarası.Text = "Oda Adı: " + oda_14.Name.ToString();
            form2.manzara.Text = "Manzara: Var";
            form2.odaServisi.Text = "Oda servisi: Yok";
            form2.Oda_Id.Text = "14";
            form2.btn_adı.Text = oda_14.Name;
        }

        private void oda_15_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.form1 = this;
            form2.Show();
            form2.rez__olustur_oda_numarası.Text = "Oda Adı: " + oda_15.Name.ToString();
            form2.manzara.Text = "Manzara: Var";
            form2.odaServisi.Text = "Oda servisi: Yok";
            form2.Oda_Id.Text = "15";
            form2.btn_adı.Text = oda_15.Name;
        }

        private void oda_S16_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.form1 = this;
            form2.Show();
            form2.rez__olustur_oda_numarası.Text = "Oda Adı: " + oda_S16.Name.ToString();
            form2.manzara.Text = "Manzara: Var";
            form2.odaServisi.Text = "Oda servisi: Var";
            form2.Oda_Id.Text = "16";
            form2.btn_adı.Text = oda_S16.Name;
        }

        private void oda_S17_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.form1 = this;
            form2.Show();
            form2.rez__olustur_oda_numarası.Text = "Oda Adı: " + oda_S17.Name.ToString();
            form2.manzara.Text = "Manzara: Var";
            form2.odaServisi.Text = "Oda servisi: Var";
            form2.Oda_Id.Text = "17";
            form2.btn_adı.Text = oda_S17.Name;
        }

        private void oda_KS18_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.form1 = this;
            form2.Show();
            form2.rez__olustur_oda_numarası.Text = "Oda Adı: " + oda_KS18.Name.ToString();
            form2.manzara.Text = "Manzara: Var";
            form2.odaServisi.Text = "Oda servisi: Var";
            form2.Oda_Id.Text = "18";
            form2.btn_adı.Text = oda_KS18.Name;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oda_1.BackColor = Color.Red;
            oda_1.Enabled = false;
            oda_2.BackColor = Color.Red;
            oda_2.Enabled = false;
            oda_14.BackColor = Color.Yellow;
            oda_14.Enabled = false;
        }
    }
}
