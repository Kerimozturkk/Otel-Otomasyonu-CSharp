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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string[] mus_AD = new string[18];
        string[] mus_SOYAD = new string[18];
        string[] mus_GSM = new string[18];
        int[] mus_KISI = new int[18];
        
        private void runQuery()
        {
            string query = "SELECT musteri_Ad,musteri_Soyad,musteri_GSM,musteri_Kisi_Sayisi,oda_Id FROM musteri";

            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=otel_rezarvasyon_db";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();


                if (myReader.HasRows)
                {
                    int i = 0;
                    while (myReader.Read())
                    {

                        mus_AD[i] = myReader.GetString(0);
                        mus_SOYAD[i] = myReader.GetString(1);
                        mus_GSM[i] = myReader.GetString(2);
                        mus_KISI[i] = Convert.ToInt32(myReader.GetString(3));
                        guncelle_musteri_sec.Items.Insert(i, myReader.GetString(0) + " " + myReader.GetString(1) + " GSM:" + myReader.GetString(2)+" Kisi sayisi:"+ myReader.GetString(3));
                        oda.Text = myReader.GetString(4);
                        //Console.WriteLine(myReader.GetString(0) + "-" + myReader.GetString(1) + "-" + myReader.GetString(2) + "-" + myReader.GetString(3));
                        i++;
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
            databaseConnection.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            runQuery();
        }

        private void guncelle_musteri_sec_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 18; i++)
            {
                if (guncelle_musteri_sec.SelectedIndex == i)
                {
                    mus_ad.Text = mus_AD[i];
                    mus_soyad.Text = mus_SOYAD[i];
                    mus_gsm.Text = mus_GSM[i];
                    mus_kisi.Text = mus_KISI[i].ToString();


                }

            }
        }
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=otel_rezarvasyon_db");
        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            //UPDATE personel SET bolum='Veri Güvenliği' WHERE bolum='Bilgi İşlem'
            //UPDATE personel SET dtarihi=1978 AND dyeri='Kırıkkale' WHERE ID=42
            string ad = mus_ad.Text;
            string soyad = mus_soyad.Text;
            string gsm = mus_gsm.Text;
            int kisi = Convert.ToInt32(mus_kisi.Text);
            int o_Id = Convert.ToInt32(oda.Text);
            string guncelleQuery = "UPDATE musteri SET musteri_Ad = '" + ad + "', musteri_Soyad = '" + soyad + "', musteri_GSM = '" + gsm + "', musteri_Kisi_Sayisi = '" + kisi + "' WHERE oda_Id ="+ o_Id;

            connection.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(guncelleQuery, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Veriler Güncellendi");
                }
                else
                {
                    MessageBox.Show("Veriler Güncellenemedi");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            connection.Close();
        }
    }
}
