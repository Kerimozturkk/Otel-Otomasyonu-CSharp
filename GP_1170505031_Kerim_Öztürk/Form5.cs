using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace GP_1170505031_Kerim_Öztürk
{
    public partial class Form5 : Form
    {
        
        public Form5()
        {
            InitializeComponent();
        }

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

        private void Form5_Load(object sender, EventArgs e)
        {
            rez_listesi.Columns.Add("Müşteri Adi",90);
            rez_listesi.Columns.Add("Müşteri Soyadi",100);
            rez_listesi.Columns.Add("Müşteri GSM",90);
            rez_listesi.Columns.Add("Oda_Adı",100);
            rez_listesi.Columns.Add("Giriş Tarihi",150);
            rez_listesi.Columns.Add("Çıkış Tarihi",150);
            rez_listesi.Columns.Add("Kapora",90);
            runQuery();

        }

    }
}
