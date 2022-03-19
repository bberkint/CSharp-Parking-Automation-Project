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
    public partial class FormGecmis : Form
    {
        public FormGecmis()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DATABASE.accdb");

        private void bilgileriGoster(string komut)
        {
            listViewTumBilgiler.Items.Clear();

            conn.Open();
            OleDbCommand AccessCommand = new OleDbCommand(komut, conn);
            OleDbDataReader read = AccessCommand.ExecuteReader();

            while (read.Read())
            {
                ListViewItem addNew = new ListViewItem();
                addNew.Text = read["ID"].ToString();
                addNew.SubItems.Add(read["Plaka"].ToString());
                addNew.SubItems.Add(read["Ad"].ToString());
                addNew.SubItems.Add(read["Soyad"].ToString());
                addNew.SubItems.Add(read["Telefon"].ToString());
                addNew.SubItems.Add(read["AracTip"].ToString());
                addNew.SubItems.Add(read["AracModel"].ToString());
                addNew.SubItems.Add(read["GirisSaati"].ToString());
                addNew.SubItems.Add(read["CikisSaati"].ToString());
                addNew.SubItems.Add(read["OdenenUcret"].ToString());
                listViewTumBilgiler.Items.Add(addNew);
            }
            conn.Close();

            labelBulunanKayit.Text = listViewTumBilgiler.Items.Count.ToString();
        }

        private void comboBoxPlakaDoldur()
        {
            comboBoxAranacakPlaka.Items.Clear();

            conn.Open();
            OleDbCommand AccessCommand = new OleDbCommand("select Plaka from Gecmis order by ID desc", conn);
            OleDbDataReader read = AccessCommand.ExecuteReader();

            while (read.Read())
            {
                if (!comboBoxAranacakPlaka.Items.Contains(read["Plaka"]))
                {
                    comboBoxAranacakPlaka.Items.Add(read["Plaka"]);
                }  
            }
            conn.Close();
        }

        private void sorguCalistir(string komut)
        {
            conn.Open();
            OleDbCommand AccessCommand = new OleDbCommand(komut, conn);
            AccessCommand.ExecuteNonQuery();
            conn.Close();
        }

        private void FormGecmis_Load(object sender, EventArgs e)
        {
            comboBoxPlakaDoldur();
            bilgileriGoster("select * from Gecmis order by ID desc");
        }

        private void buttonTumKayitlariListele_Click(object sender, EventArgs e)
        {
            comboBoxAranacakPlaka.Text = "";
            bilgileriGoster("select * from Gecmis order by ID desc");
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            if (comboBoxAranacakPlaka.Text.ToString() == "")
            {
                bilgileriGoster("select * from Gecmis order by ID desc");
            }
            else
            {
                if (!comboBoxAranacakPlaka.Items.Contains(comboBoxAranacakPlaka.Text.ToString()))
                {
                    MessageBox.Show("Girilen plakaya ait kayıt bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bilgileriGoster("select * from Gecmis where Plaka = '" + comboBoxAranacakPlaka.Text.ToString() + "' order by ID desc");
            }
        }

        private void kaydiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int kayitID = Convert.ToInt32(listViewTumBilgiler.SelectedItems[0].SubItems[0].Text);

                if (MessageBox.Show(kayitID + " numaralı kaydı silmek istediğinizden eminmisiniz?", "Kayıt Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sorguCalistir("Delete from Gecmis where ID = " + kayitID);
                    bilgileriGoster("select * from Gecmis order by ID desc");

                    MessageBox.Show("Araç kaydı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Herhangi bir kayıt seçilmedi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }
    }
}
