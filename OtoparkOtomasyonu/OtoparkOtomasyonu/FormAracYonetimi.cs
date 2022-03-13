using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyonu
{
    public partial class FormAracYonetimi : Form
    {
        public FormAracYonetimi()
        {
            InitializeComponent();
        }

        IniFile Settings = new IniFile("Settings.ini");

        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DATABASE.accdb");

        private void bilgileriGoster()
        {
            comboBoxPlaka.Items.Clear();
            listViewBilgiler.Items.Clear();

            conn.Open();
            OleDbCommand AccessCommand = new OleDbCommand("select * from Otopark order by GirisSaati desc", conn);
            OleDbDataReader read = AccessCommand.ExecuteReader();

            while (read.Read())
            {
                comboBoxPlaka.Items.Add(read["Plaka"]);

                ListViewItem addNew = new ListViewItem();
                addNew.Text = read["ID"].ToString();
                addNew.SubItems.Add(read["Plaka"].ToString());
                addNew.SubItems.Add(read["Ad"].ToString());
                addNew.SubItems.Add(read["Soyad"].ToString());
                addNew.SubItems.Add(read["Telefon"].ToString());
                addNew.SubItems.Add(read["AracTip"].ToString());
                addNew.SubItems.Add(read["AracModel"].ToString());
                addNew.SubItems.Add(read["GirisSaati"].ToString());
                listViewBilgiler.Items.Add(addNew);
            }
            conn.Close();

            double kapasite = Convert.ToDouble(Settings.Read("kapasite"));
            double mevcutArabaSayisi = Convert.ToDouble(listViewBilgiler.Items.Count);

            double hesapla = mevcutArabaSayisi / kapasite * 100;
            labelKapasite.Text = mevcutArabaSayisi + "/" + kapasite + " (" + hesapla.ToString("#.##") + "%)";
        }

        private void aracGirisGirdileriniTemizle()
        {
            textBoxPlaka.Clear();
            textBoxAd.Clear();
            textBoxSoyad.Clear();
            maskedTextBoxTelefon.Clear();
            textBoxAracModeli.Clear();
            comboBoxAracTipi.SelectedIndex = -1;
            buttonAracKayitEt.Text = "Kayıt Et";
        }

        private void aracCikisGirdileriniTemizle()
        {
            comboBoxPlaka.Text = "";
            labelUcret.Text = "--TL";
            buttonCikisYap.Enabled = false;
        }

        private void sorguCalistir(string komut)
        {
            conn.Open();
            OleDbCommand AccessCommand = new OleDbCommand(komut, conn);
            AccessCommand.ExecuteNonQuery();
            conn.Close();
        }

        //---------------------------------------------------------------------------------------------

        private void FormAracYonetimi_Load(object sender, EventArgs e)
        {
            listViewBilgiler.Height = 495;
            bilgileriGoster();
        }

        private void buttonAracGirisi_Click(object sender, EventArgs e)
        {
            listViewBilgiler.Height = 310;

            buttonMenuyuKapat.Visible = true;
            groupBoxAracGirisi.Visible = true;
            groupBoxAracCikisi.Visible = false;

            aracCikisGirdileriniTemizle();
        }

        private void buttonAracCikisi_Click(object sender, EventArgs e)
        {
            listViewBilgiler.Height = 310;

            buttonMenuyuKapat.Visible = true;
            groupBoxAracGirisi.Visible = false;
            groupBoxAracCikisi.Visible = true;

            aracGirisGirdileriniTemizle();
        }

        private void buttonMenuyuKapat_Click(object sender, EventArgs e)
        {
            listViewBilgiler.Height = 495;

            buttonMenuyuKapat.Visible = false;
            groupBoxAracGirisi.Visible = false;
            groupBoxAracCikisi.Visible = false;

            aracGirisGirdileriniTemizle();
            aracCikisGirdileriniTemizle();
        }

        private int kayitID; // kayit guncelleme icin

        private void buttonAracKayitEt_Click(object sender, EventArgs e)
        {
            if (textBoxPlaka.Text != "" && textBoxAd.Text.ToString() != "" && textBoxSoyad.Text.ToString() != "" && maskedTextBoxTelefon.MaskFull == true && comboBoxAracTipi.Text.ToString() != "" && textBoxAracModeli.Text.ToString() != "")
            {
                if (buttonAracKayitEt.Text == "Kayıt Et")
                {
                    dateTimePickerGirisSaati.Value = DateTime.Now;

                    sorguCalistir("INSERT INTO Otopark (Plaka,Ad,Soyad,Telefon,AracTip,AracModel,GirisSaati) values ('" + textBoxPlaka.Text.ToString() + "','" + textBoxAd.Text.ToString() + "','" + textBoxSoyad.Text.ToString() + "','" + maskedTextBoxTelefon.Text.ToString() + "','" + comboBoxAracTipi.SelectedItem.ToString() + "','" + textBoxAracModeli.Text.ToString() + "','" + dateTimePickerGirisSaati.Text.ToString() + "')");

                    bilgileriGoster();
                    aracGirisGirdileriniTemizle();
                    
                    MessageBox.Show("Araç giriş kaydı başarıyla yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    dateTimePickerGirisSaati.Value = DateTime.Now;

                    sorguCalistir("Update Otopark set Plaka = '" + textBoxPlaka.Text.ToString() + "', Ad = '" + textBoxAd.Text.ToString() + "', Soyad = '" + textBoxSoyad.Text.ToString() + "', Telefon = '" + maskedTextBoxTelefon.Text.ToString() + "', AracTip = '" + comboBoxAracTipi.SelectedItem.ToString() + "', AracModel = '" + textBoxAracModeli.Text.ToString() + "' where ID = " + kayitID);

                    bilgileriGoster();
                    aracGirisGirdileriniTemizle();

                    MessageBox.Show("Araç kaydı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }   
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            aracGirisGirdileriniTemizle();   
        }

        string[] saat;
        string girisSaatiString;
        int odenecekTutar = 0;

        private void buttonUcretHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                if (!comboBoxPlaka.Items.Contains(comboBoxPlaka.Text.ToString()))
                {
                    MessageBox.Show("Girilen plaka mevcut değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                conn.Open();
                OleDbCommand AccessCommand = new OleDbCommand("Select GirisSaati from Otopark where Plaka = '" + comboBoxPlaka.Text.ToString() + "'", conn);
                OleDbDataReader read = AccessCommand.ExecuteReader();

                while (read.Read())
                {
                    girisSaatiString = read["GirisSaati"].ToString();
                }
                conn.Close();

                dateTimePickerCikisSaati.Value = DateTime.Now;

                DateTime girisSaati = DateTime.Parse(girisSaatiString);
                string gecenZaman = (dateTimePickerCikisSaati.Value - girisSaati).ToString();

                string[] bol = gecenZaman.Split('.');

                int toplamSaat = 0;

                if (bol.Length == 2)
                {
                    saat = bol[0].Split(':');
                    toplamSaat += Convert.ToInt32(saat[0]);
                }
                else if (bol.Length == 3)
                {
                    saat = bol[1].Split(':');
                    toplamSaat += Convert.ToInt32(bol[0]) * 24;
                    toplamSaat += Convert.ToInt32(saat[0]);
                }


                if (toplamSaat >= 0 && toplamSaat < 1)
                {
                    odenecekTutar = Convert.ToInt32(Settings.Read("saat_0x1"));
                }
                else if (toplamSaat >= 1 && toplamSaat < 2)
                {
                    odenecekTutar = Convert.ToInt32(Settings.Read("saat_1x2"));
                }
                else if (toplamSaat >= 2 && toplamSaat < 4)
                {
                    odenecekTutar = Convert.ToInt32(Settings.Read("saat_2x4"));
                }
                else if (toplamSaat >= 4 && toplamSaat < 8)
                {
                    odenecekTutar = Convert.ToInt32(Settings.Read("saat_4x8"));
                }
                else if (toplamSaat >= 8 && toplamSaat < 12)
                {
                    odenecekTutar = Convert.ToInt32(Settings.Read("saat_8x12"));
                }
                else if (toplamSaat >= 12 && toplamSaat < 24)
                {
                    odenecekTutar = Convert.ToInt32(Settings.Read("saat_12x24"));
                }
                else if (toplamSaat >= 24)
                {
                    odenecekTutar = (Convert.ToInt32(Settings.Read("saat_24x00")) * (toplamSaat - 24)) + Convert.ToInt32(Settings.Read("saat_12x24"));
                }

                labelUcret.Text = odenecekTutar.ToString() + " TL ("+ toplamSaat +" saat)";
                buttonCikisYap.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen plakayı kontrol ediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCikisYap_Click(object sender, EventArgs e)
        {
            
            // cikisi yapilacak aracin bilgilerini getir
            conn.Open();
            OleDbCommand AccessCommand = new OleDbCommand("Select * from Otopark where Plaka = '" + comboBoxPlaka.Text.ToString() + "'", conn);
            OleDbDataReader read = AccessCommand.ExecuteReader();

            string xPlaka = "", xAd = "", xSoyad = "", xTelefon = "", xAracTip = "", xAracModel = "", xGirisSaati = "";

            while (read.Read())
            {
                xPlaka = read["Plaka"].ToString();
                xAd = read["Ad"].ToString();
                xSoyad = read["Soyad"].ToString();
                xTelefon = read["Telefon"].ToString();
                xAracTip = read["AracTip"].ToString();
                xAracModel = read["AracModel"].ToString();
                xGirisSaati = read["GirisSaati"].ToString();
            }
            conn.Close();

            sorguCalistir("INSERT INTO Gecmis (Plaka,Ad,Soyad,Telefon,AracTip,AracModel,GirisSaati,CikisSaati,OdenenUcret) values ('" + xPlaka + "','" + xAd + "','" + xSoyad + "','" + xTelefon + "','" + xAracTip + "','" + xAracModel + "','" + xGirisSaati + "','" + dateTimePickerCikisSaati.Text.ToString() + "'," + odenecekTutar + ")");
            sorguCalistir("Delete from Otopark where Plaka = '" + comboBoxPlaka.Text.ToString() + "'");

            aracCikisGirdileriniTemizle();
            bilgileriGoster(); 

            MessageBox.Show("Araç çıkışı başarıyla yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void comboBoxPlaka_TextChanged(object sender, EventArgs e)
        {
            buttonCikisYap.Enabled = false;
            labelUcret.Text = "--TL";
        }

        private void cikisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                comboBoxPlaka.Text = listViewBilgiler.SelectedItems[0].SubItems[1].Text;
                buttonAracCikisi_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Herhangi bir kayıt seçilmedi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxPlaka.Text = listViewBilgiler.SelectedItems[0].SubItems[1].Text;
                textBoxAd.Text = listViewBilgiler.SelectedItems[0].SubItems[2].Text;
                textBoxSoyad.Text = listViewBilgiler.SelectedItems[0].SubItems[3].Text;
                maskedTextBoxTelefon.Text = listViewBilgiler.SelectedItems[0].SubItems[4].Text;
                comboBoxAracTipi.Text = listViewBilgiler.SelectedItems[0].SubItems[5].Text;
                textBoxAracModeli.Text = listViewBilgiler.SelectedItems[0].SubItems[6].Text;

                buttonAracKayitEt.Text = "Güncelle";
                kayitID = Convert.ToInt32(listViewBilgiler.SelectedItems[0].SubItems[0].Text);

                buttonAracGirisi_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Herhangi bir kayıt seçilmedi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void kaydiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                kayitID = Convert.ToInt32(listViewBilgiler.SelectedItems[0].SubItems[0].Text);
                string plakaAl = listViewBilgiler.SelectedItems[0].SubItems[1].Text;

                if (MessageBox.Show(plakaAl + " plakalı aracın kaydını silmek istediğinizden eminmisiniz?", "Kayıt Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sorguCalistir("Delete from Otopark where ID = " + kayitID);

                    aracGirisGirdileriniTemizle();
                    aracCikisGirdileriniTemizle();
                    bilgileriGoster();

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
