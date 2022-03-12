using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyonu
{
    public partial class FormAnasayfa : Form
    {
        public FormAnasayfa()
        {
            InitializeComponent();
        }

        IniFile Settings = new IniFile("Settings.ini");
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DATABASE.accdb");

        private void FormAnasayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();

            conn.Open();

            OleDbCommand AccessCommand1 = new OleDbCommand("Select OdenenUcret from Gecmis where CikisSaati like '%" + DateTime.Today.ToString("dd/MM/yyyy") + "%'", conn);
            OleDbDataReader read1 = AccessCommand1.ExecuteReader();

            OleDbCommand AccessCommand2 = new OleDbCommand("select OdenenUcret from Gecmis", conn);
            OleDbDataReader read2 = AccessCommand2.ExecuteReader();

            OleDbCommand AccessCommand3 = new OleDbCommand("select * from Otopark", conn);
            OleDbDataReader read3 = AccessCommand3.ExecuteReader();

            OleDbCommand AccessCommand4 = new OleDbCommand("select AracTip from Otopark", conn);
            OleDbDataReader read4 = AccessCommand4.ExecuteReader();

            
            int gunlukGelir = 0;
            while (read1.Read())
            {
                gunlukGelir += Convert.ToInt32(read1["OdenenUcret"]);
            }

            int toplamGelir = 0;
            while (read2.Read())
            {
                toplamGelir += Convert.ToInt32(read2["OdenenUcret"]);
            }

            double mevcutArabaSayisi = 0;
            while (read3.Read())
            {
                mevcutArabaSayisi++;
            }

            int otomobil = 0;
            int kamyonet = 0;
            int motosiklet = 0;
            while (read4.Read())
            {
                switch (read4["AracTip"].ToString())
                {
                    case "Otomobil": otomobil++; break;
                    case "Kamyonet": kamyonet++; break;
                    case "Motosiklet": motosiklet++; break;
                    default: break;
                }
            }
            conn.Close();

            labelGunlukGelir.Text = gunlukGelir.ToString() + " TL (Bugün)";
            labelToplamGelir.Text = toplamGelir.ToString() + " TL (Toplam)";

            //-----------------------
            double kapasite = Convert.ToDouble(Settings.Read("kapasite"));
            double hesapla = mevcutArabaSayisi / kapasite * 100;
            labelKapasite.Text = "Kapasite: " + mevcutArabaSayisi + "/" + kapasite + " (" + hesapla.ToString("#.##") + "%)";
            //-----------------------

            labelOtomobil.Text = otomobil.ToString();
            labelKamyonet.Text = kamyonet.ToString();
            labelMotosiklet.Text = motosiklet.ToString();     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelZaman.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }
    }
}
