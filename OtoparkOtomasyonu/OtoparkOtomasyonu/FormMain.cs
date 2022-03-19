using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyonu
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void showForm(Form form)
        {
            this.panelAna.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelAna.Controls.Add(form);
            form.Show();
        }

        private void setPositionPanel(Button btn)
        {
            panel_index.BringToFront();
            panel_index.Location = new Point(0, btn.Top);
            
            label_index.Text = btn.Text.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Settings.ini"))
            {
                showForm(new FormAnasayfa());
                setPositionPanel(buttonAnasayfa);
            }
            else
            {
                IniFile Settings = new IniFile("Settings.ini");

                Settings.Write("kapasite", "100");

                Settings.Write("saat_0x1", "6");
                Settings.Write("saat_1x2", "8");
                Settings.Write("saat_2x4", "10");
                Settings.Write("saat_4x8", "12");
                Settings.Write("saat_8x12", "15");
                Settings.Write("saat_12x24", "18");
                Settings.Write("saat_24x00", "4");

                showForm(new FormAyarlar());
                setPositionPanel(buttonAyarlar);
            }
        }

        private void buttonAnasayfa_Click(object sender, EventArgs e)
        {
            showForm(new FormAnasayfa());
            setPositionPanel(buttonAnasayfa);
        }

        private void buttonAracYonetimi_Click(object sender, EventArgs e)
        {
            showForm(new FormAracYonetimi());
            setPositionPanel(buttonAracYonetimi);
        }

        private void buttonGecmis_Click(object sender, EventArgs e)
        {
            showForm(new FormGecmis());
            setPositionPanel(buttonGecmis);
        }

        private void buttonAyarlar_Click(object sender, EventArgs e)
        {
            showForm(new FormAyarlar());
            setPositionPanel(buttonAyarlar);
        }

        private void pictureBoxInstagram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instagram adreslerimiz: (henüz eklenmedi)", "Instagram", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBoxMail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mail adreslerimiz;\n  - Enes Ünal: enesunal497@gmail.com\n  - Batın Berkin Topaloğlu: topaloglubatinberkin@gmail.com", "Instagram", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void pictureBoxWhatsapp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Whatsapp numaralarımız: (henüz eklenmedi)", "Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Bundan sonrasi cercevesi olmayan formu oynatmak icin

        private bool mouseDown;
        private Point lastLocation;

        private void panelUst_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelUst_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void panelUst_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        } 
    }
}
