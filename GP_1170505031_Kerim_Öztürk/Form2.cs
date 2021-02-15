using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GP_1170505031_Kerim_Öztürk
{
    
    public partial class Form2 : Form
    {
        public Form1 form1;

        public string insert_musteri_query;
        public string insert_rezervasyon_query;
        public Form2()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        //string query = "SELECT musteri_Ad,musteri_Soyad,musteri_GSM,m.oda_Id,r.giris_Tarih,r.cikis_Tarih,r.kapora_Ucret FROM musteri AS m INNER JOIN rezervasyon as r ON(r.musteri_Id = m.musteri_Id) ";
        //string query = "INSERT INTO musteri (musteri_Id,oda_Id,musteri_Ad,musteri_Soyad,musteri_GSM,musteri_Kisi_Sayisi) VALUES (@musteri_Id,@oda_Id,@musteri_Ad,@musteri_Soyad,@musteri_GSM,@musteri_Kisi_Sayisi)";
        /*
        
         private void runQuery()
        {
            string query = "SELECT musteri_Ad,musteri_Soyad,musteri_GSM,m.oda_Id,r.giris_Tarih,r.cikis_Tarih,r.kapora_Ucret FROM musteri AS m INNER JOIN rezervasyon as r ON(r.musteri_Id = m.musteri_Id) ";
            
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=otel_rezarvasyon_db";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                String[] liste = new String[7];

                if (myReader.HasRows)
                {
                   
                    while (myReader.Read())
                    {                       
                        for(int i = 0; i < 7; i++)
                        {
                            liste[i] = myReader.GetString(i);                           
                        }
                        var listViewItem = new ListViewItem(liste);
                        rez_listesi.Items.Add(listViewItem);

                        //Console.WriteLine(myReader.GetString(0) + "-" + myReader.GetString(1) + "-" + myReader.GetString(2) + "-" + myReader.GetString(3));
                    }
                }
                else
                {
                    MessageBox.Show("Query successfully executed");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error: " + e.Message);
            }

        }

         */
        MySqlConnection connection = new MySqlConnection("datasource = 127.0.0.1; port=3306;username=root;password=;database=otel_rezarvasyon_db");
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime girisTarihi = dateTimePicker1.Value;
            DateTime cikisTarihi = dateTimePicker2.Value;
            string girisTarihi1 = dateTimePicker1.Text;
            string cikisTarihi1 = dateTimePicker2.Text;
            bool Manzara;
            bool OdaServisi;
            if (manzara.Text == "Manzara: Var") { Manzara = true; }
            else { Manzara = false; }
            if (odaServisi.Text == "Oda servisi: Var") { OdaServisi = true; }
            else { OdaServisi = false; }


            Random rastgele_rezerv_Id = new Random();
            int rezerv_Id = rastgele_rezerv_Id.Next(3, 1000);
            rezervasyon_ID.Text = "Rezervasyon_ID: " + rezerv_Id.ToString();
            int oda_Id = Convert.ToInt32(Oda_Id.Text.ToString());
            string oda_Adi = rez__olustur_oda_numarası.ToString();
            Random rastgele_musteri_Id = new Random();
            int musteri_Id = rastgele_musteri_Id.Next(3, 1000);
            musteri_ID.Text = "Musteri_ID: " + musteri_Id.ToString();
            int kapora;
            if (Kapora_checkBox.Checked == true)
            {
                kapora = Convert.ToInt32(Kapora_textBox.Text.ToString());
            }
            else
            {
                kapora = 0;
            }
            string musteri_Adi = Musteri_Adi.Text.ToString();
            string musteri_Soyadi = Musteri_Soyadi.Text.ToString();
            string musteri_GSM = Musteri_GSM.Text.ToString();
            int musteri_kisi_sayisi = Convert.ToInt32(Musteri_Kisi_Sayisi.Text.ToString());

            bool tadilat = false;
            int odaaaa_ID = Convert.ToInt32(Oda_Id.Text);
            if (odaaaa_ID == 18)
            {
                KralSuit_Rezervasyon kralsuitR = new KralSuit_Rezervasyon(rezerv_Id,
                                                                oda_Adi,
                                                                oda_Id,
                                                                Manzara,
                                                                OdaServisi,
                                                                musteri_Id,
                                                                musteri_Adi,
                                                                musteri_Soyadi,
                                                                musteri_GSM,
                                                                musteri_kisi_sayisi,
                                                                girisTarihi,
                                                                cikisTarihi,
                                                                kapora,
                                                                tadilat);

                Manzara = false;
                OdaServisi = false;
                int konak_Suresiks = kralsuitR.konak_Suresi();
                int ucretks = kralsuitR.Ucret_Hesabi(Manzara, OdaServisi);
                //rez_olustur_sure.Text = "Konak Süresi: " + konak_Suresis.ToString();
                //Rez_olustur_tot_ucret.Text = "Oda Ücreti: " + ucrets.ToString();

                string insertQuerys = "INSERT INTO musteri (musteri_Id,oda_Id,musteri_Ad,musteri_Soyad,musteri_GSM,musteri_Kisi_Sayisi) VALUES ('" + kralsuitR.musteri_id + "','" + kralsuitR.oda_Id + "','" + kralsuitR.musteri_Ad + "','" + kralsuitR.musteri_Soyad + "','" + kralsuitR.musteri_GSM + "','" + kralsuitR.musteri_Kisi_Sayisi + "')";
                string insert2Querys = "INSERT INTO rezervasyon (rezerv_Id,oda_Id,musteri_Id,giris_Tarih,cikis_Tarih,kapora_Ucret,total_Ucret,rezerv_Suresi) VALUES ('" + kralsuitR.rezerv_Id + "','" + kralsuitR.oda_Id + "','" + kralsuitR.musteri_id + "','" + girisTarihi1 + "','" + cikisTarihi1 + "','" + kralsuitR.kapora + "','" + ucretks + "','" + konak_Suresiks + "')";

                connection.Open();
                MySqlCommand commandks = new MySqlCommand(insertQuerys, connection);
                MySqlCommand command2ks = new MySqlCommand(insert2Querys, connection);
                try
                {
                    if (commandks.ExecuteNonQuery() == 1 && command2ks.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Veriler Eklendi");
                    }
                    else
                    {
                        MessageBox.Show("Veriler Eklenemedi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
            }

            int odaa_ID = Convert.ToInt32(Oda_Id.Text);
            if (odaa_ID == 16 || odaa_ID == 17)
            {
                Suit_Rezervasyon suitR = new Suit_Rezervasyon(rezerv_Id,
                                                                oda_Adi,
                                                                oda_Id,
                                                                Manzara,
                                                                OdaServisi,
                                                                musteri_Id,
                                                                musteri_Adi,
                                                                musteri_Soyadi,
                                                                musteri_GSM,
                                                                musteri_kisi_sayisi,
                                                                girisTarihi,
                                                                cikisTarihi,
                                                                kapora,
                                                                tadilat);

                Manzara = false;
                OdaServisi = false;
                int konak_Suresis = suitR.konak_Suresi();
                int ucrets = suitR.Ucret_Hesabi(Manzara, OdaServisi);
                //rez_olustur_sure.Text = "Konak Süresi: " + konak_Suresis.ToString();
                //Rez_olustur_tot_ucret.Text = "Oda Ücreti: " + ucrets.ToString();

                string insertQuerys = "INSERT INTO musteri (musteri_Id,oda_Id,musteri_Ad,musteri_Soyad,musteri_GSM,musteri_Kisi_Sayisi) VALUES ('" + suitR.musteri_id + "','" + suitR.oda_Id + "','" + suitR.musteri_Ad + "','" + suitR.musteri_Soyad + "','" + suitR.musteri_GSM + "','" + suitR.musteri_Kisi_Sayisi + "')";
                string insert2Querys = "INSERT INTO rezervasyon (rezerv_Id,oda_Id,musteri_Id,giris_Tarih,cikis_Tarih,kapora_Ucret,total_Ucret,rezerv_Suresi) VALUES ('" + suitR.rezerv_Id + "','" + suitR.oda_Id + "','" + suitR.musteri_id + "','" + girisTarihi1 + "','" + cikisTarihi1 + "','" + suitR.kapora + "','" + ucrets + "','" + konak_Suresis + "')";

                connection.Open();
                MySqlCommand commands = new MySqlCommand(insertQuerys, connection);
                MySqlCommand command2s = new MySqlCommand(insert2Querys, connection);
                try
                {
                    if (commands.ExecuteNonQuery() == 1 && command2s.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Veriler Eklendi");
                    }
                    else
                    {
                        MessageBox.Show("Veriler Eklenemedi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
            }

            Normal_Rezervasyon normalR = new Normal_Rezervasyon(rezerv_Id,
                                                                oda_Adi,
                                                                oda_Id,
                                                                Manzara,
                                                                OdaServisi,
                                                                musteri_Id,
                                                                musteri_Adi,
                                                                musteri_Soyadi,
                                                                musteri_GSM,
                                                                musteri_kisi_sayisi,
                                                                girisTarihi,
                                                                cikisTarihi,
                                                                kapora,
                                                                tadilat);

            int konak_Suresi = normalR.konak_Suresi();
            int ucret = normalR.Ucret_Hesabi(Manzara, OdaServisi);
            //rez_olustur_sure.Text = "Konak Süresi: " + konak_Suresi.ToString();
            //Rez_olustur_tot_ucret.Text = "Oda Ücreti: " + ucret.ToString();

            string insertQuery = "INSERT INTO musteri (musteri_Id,oda_Id,musteri_Ad,musteri_Soyad,musteri_GSM,musteri_Kisi_Sayisi) VALUES ('" + normalR.musteri_id + "','" + normalR.oda_Id + "','" + normalR.musteri_Ad + "','" + normalR.musteri_Soyad + "','" + normalR.musteri_GSM + "','" + normalR.musteri_Kisi_Sayisi + "')";
            string insert2Query = "INSERT INTO rezervasyon (rezerv_Id,oda_Id,musteri_Id,giris_Tarih,cikis_Tarih,kapora_Ucret,total_Ucret,rezerv_Suresi) VALUES ('" + normalR.rezerv_Id + "','" + normalR.oda_Id + "','" + normalR.musteri_id + "','" + girisTarihi1 + "','" + cikisTarihi1 + "','" + normalR.kapora + "','" + ucret + "','" + konak_Suresi + "')";
            
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            MySqlCommand command2 = new MySqlCommand(insert2Query, connection);
            try
            {
                if (command.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Veriler Eklendi");
                }
                else
                {
                    MessageBox.Show("Veriler Eklenemedi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            
            switch (oda_Id)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    form1.oda_3.BackColor = Color.Red;
                    form1.oda_3.Enabled = false;
                    break;
                case 4:
                    form1.oda_4.BackColor = Color.Red;
                    form1.oda_4.Enabled = false;
                    break;
                case 5:
                    form1.oda_5.BackColor = Color.Red;
                    form1.oda_5.Enabled = false;
                    break;
                case 6:
                    form1.oda_6.BackColor = Color.Red;
                    form1.oda_6.Enabled = false;
                    break;
                case 7:
                    form1.oda_7.BackColor = Color.Red;
                    form1.oda_7.Enabled = false;
                    break;
                case 8:
                    form1.oda_8.BackColor = Color.Red;
                    form1.oda_8.Enabled = false;
                    break;
                case 9:
                    form1.oda_9.BackColor = Color.Red;
                    form1.oda_9.Enabled = false;
                    break;
                case 10:
                    form1.oda_10.BackColor = Color.Red;
                    form1.oda_10.Enabled = false;
                    break;
                case 11:
                    form1.oda_11.BackColor = Color.Red;
                    form1.oda_11.Enabled = false;
                    break;
                case 12:
                    form1.oda_12.BackColor = Color.Red;
                    form1.oda_12.Enabled = false;
                    break;
                case 13:
                    form1.oda_13.BackColor = Color.Red;
                    form1.oda_13.Enabled = false;
                    break;
                case 14:
                    form1.oda_14.BackColor = Color.Red;
                    form1.oda_14.Enabled = false;
                    break;
                case 15:
                    form1.oda_15.BackColor = Color.Red;
                    form1.oda_15.Enabled = false;
                    break;
                case 16:
                    form1.oda_S16.BackColor = Color.Red;
                    form1.oda_S16.Enabled = false;
                    break;
                case 17:
                    form1.oda_S17.BackColor = Color.Red;
                    form1.oda_S17.Enabled = false;
                    break;
                case 18:
                    form1.oda_KS18.BackColor = Color.Red;
                    form1.oda_KS18.Enabled = false;
                    break;
                default:
                    break;
            }
        }
        
        private void ucretHesapla_Click(object sender, EventArgs e)
        {
            
            DateTime girisTarihi = dateTimePicker1.Value;
            DateTime cikisTarihi = dateTimePicker2.Value;

            System.TimeSpan konaklama_suresi;
            konaklama_suresi = cikisTarihi.Subtract(girisTarihi);//İlk tarihten son tarihi çıkardık
            int toplam_gun = Convert.ToInt32(konaklama_suresi.TotalDays);
            rez_olustur_sure.Text = "Konak Süresi: "+toplam_gun.ToString();

            bool Manzara;
            bool OdaServisi;
            if (manzara.Text == "Manzara: Var") { Manzara = true; }
            else { Manzara = false; }
            if (odaServisi.Text == "Oda servisi: Var") { OdaServisi = true; }
            else { OdaServisi = false; }

            int gunluk_ucret = 50;
            if(Manzara == true) { gunluk_ucret = gunluk_ucret + 40; }
            if (OdaServisi == true) { gunluk_ucret = gunluk_ucret + 20; }

            int odaaaaa_ID = Convert.ToInt32(Oda_Id.Text);
            if (odaaaaa_ID == 18)
            {
                Manzara = false;
                OdaServisi = false;
                gunluk_ucret = 250;

            }


            int odaaa_ID = Convert.ToInt32(Oda_Id.Text);
            if (odaaa_ID == 16 || odaaa_ID == 17)
            {
                Manzara = false;
                OdaServisi = false;
                gunluk_ucret = 150;
                
            }
            if (Kapora_checkBox.Checked == true)
            {
                int kapora = Convert.ToInt32(Kapora_textBox.Text);
                
                int total_ucret = toplam_gun * gunluk_ucret;
                Rez_olustur_tot_ucret.Text = "Oda Ucreti: " + (total_ucret - kapora).ToString();
            }
            else
            {
                int total_ucret = toplam_gun * gunluk_ucret;
                Rez_olustur_tot_ucret.Text = "Oda Ucreti: " + total_ucret.ToString();
            }
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (Kapora_checkBox.Checked == true)
            {
                Kapora_textBox.Enabled = true;
            }
            else
            {
                Kapora_textBox.Enabled = false;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime girisTarihi = dateTimePicker1.Value;
            DateTime cikisTarihi = dateTimePicker2.Value;
            if(girisTarihi >= cikisTarihi)
            {
                MessageBox.Show("Konaklama süresi en az 1 gün sürmelidir ve Giriş Tarihi daha önce bit tarih olmalıdı");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        
        private void rez__olustur_oda_numarası_Click(object sender, EventArgs e)
        {
            
        }
    }
}
