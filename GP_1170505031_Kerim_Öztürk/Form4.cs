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
    public partial class Form4 : Form
    {
        public Form1 form1;
        public Form4()
        {
            InitializeComponent();
        }
        int [] oda_Index  = new int [18];
        int[] oda_no = new int[18];
        string [] ad_Soyad = new string[18];
        private void runQuery()
        {
            string query = "SELECT musteri_Ad,musteri_Soyad,oda_Id FROM musteri";

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
                        //oda_Index = Convert.ToInt32(myReader.GetString(2));
                        //ad_Soyad = myReader.GetString(0) + " " + myReader.GetString(1);
                        oda_Index[i] = Convert.ToInt32(myReader.GetString(2));
                        oda_no[i] = Convert.ToInt32(myReader.GetString(2));
                        ad_Soyad[i] = myReader.GetString(0) + " " + myReader.GetString(1);
                        //musteri_sec.Items.Add(myReader.GetString(0) + " " + myReader.GetString(1) + " Oda: " + myReader.GetString(2));
                        musteri_sec.Items.Insert(i, myReader.GetString(0) + " " + myReader.GetString(1) + " Oda: " + myReader.GetString(2));
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
        private void Form4_Load(object sender, EventArgs e)
        {
            runQuery();
        }

        private void musteri_sec_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < 18; i++)
            {
                if(musteri_sec.SelectedIndex == i)
                {
                    musteri_adi.Text = "Müşteri Adı: "+ad_Soyad[i];
                    oda_numarasi.Text = "Oda Numarası: "+oda_Index[i].ToString();
                    aaa.Text = oda_no[i].ToString();

                }
               
            }
            /*if(musteri_sec.SelectedIndex == 1)
            {
                musteri_adi.Text = ad_Soyad.ToString();
                oda_numarasi.Text = oda_Index.ToString();
            }
            */
        }
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=otel_rezarvasyon_db");
        private void sil_btn_Click(object sender, EventArgs e)
        {
            int oda_no = Convert.ToInt32(aaa.Text);
            try
            {
                string silRezervasyonQuery = "DELETE FROM rezervasyon WHERE oda_Id = " + oda_no;
                string silMusteriQuery = "DELETE FROM musteri WHERE oda_Id = " + oda_no;
                connection.Open();
                MySqlCommand command = new MySqlCommand(silRezervasyonQuery, connection);
                MySqlCommand command2 = new MySqlCommand(silMusteriQuery, connection);

                if (command.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Rezervasyon İptal Edildi");
                }
                else
                {
                    MessageBox.Show("Rezervasyon İptal Edilemedi");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            int oda_kullanıma_ac = Convert.ToInt32(aaa.Text);
            switch (oda_kullanıma_ac)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    form1.oda_3.BackColor = Color.Transparent;
                    form1.oda_3.Enabled = true;
                    break;
                case 4:
                    form1.oda_4.BackColor = Color.Transparent;
                    form1.oda_4.Enabled = true;
                    break;
                case 5:
                    form1.oda_5.BackColor = Color.Transparent;
                    form1.oda_5.Enabled = true;
                    break;
                case 6:
                    form1.oda_6.BackColor = Color.Transparent;
                    form1.oda_6.Enabled = true;
                    break;
                case 7:
                    form1.oda_7.BackColor = Color.Transparent;
                    form1.oda_7.Enabled = true;
                    break;
                case 8:
                    form1.oda_8.BackColor = Color.Transparent;
                    form1.oda_8.Enabled = true;
                    break;
                case 9:
                    form1.oda_9.BackColor = Color.Transparent;
                    form1.oda_9.Enabled = true;
                    break;
                case 10:
                    form1.oda_10.BackColor = Color.Transparent;
                    form1.oda_10.Enabled = true;
                    break;
                case 11:
                    form1.oda_11.BackColor = Color.Transparent;
                    form1.oda_11.Enabled = true;
                    break;
                case 12:
                    form1.oda_12.BackColor = Color.Transparent;
                    form1.oda_12.Enabled = true;
                    break;
                case 13:
                    form1.oda_13.BackColor = Color.Transparent;
                    form1.oda_13.Enabled = true;
                    break;
                case 14:
                    form1.oda_14.BackColor = Color.Transparent;
                    form1.oda_14.Enabled = true;
                    break;
                case 15:
                    form1.oda_15.BackColor = Color.Transparent;
                    form1.oda_15.Enabled = true;
                    break;
                case 16:
                    form1.oda_S16.BackColor = Color.Transparent;
                    form1.oda_S16.Enabled = true;
                    break;
                case 17:
                    form1.oda_S17.BackColor = Color.Transparent;
                    form1.oda_S17.Enabled = true;
                    break;
                case 18:
                    form1.oda_KS18.BackColor = Color.Transparent;
                    form1.oda_KS18.Enabled = true;
                    break;
                default:
                    break;
            }
        }
    }
}
