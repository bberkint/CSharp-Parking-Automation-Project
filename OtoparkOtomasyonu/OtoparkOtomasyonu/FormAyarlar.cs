using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyonu
{
    public partial class FormAyarlar : Form
    {
        public FormAyarlar()
        {
            InitializeComponent();
        }

        IniFile Settings = new IniFile("Settings.ini");

        private void FormAyarlar_Load(object sender, EventArgs e)
        {
            numericUpDown_kapasite.Value = Convert.ToInt32(Settings.Read("kapasite"));

            numericUpDown_0x1.Value = Convert.ToInt32(Settings.Read("saat_0x1"));
            numericUpDown_1x2.Value = Convert.ToInt32(Settings.Read("saat_1x2"));
            numericUpDown_2x4.Value = Convert.ToInt32(Settings.Read("saat_2x4"));
            numericUpDown_4x8.Value = Convert.ToInt32(Settings.Read("saat_4x8"));
            numericUpDown_8x12.Value = Convert.ToInt32(Settings.Read("saat_8x12"));
            numericUpDown_12x24.Value = Convert.ToInt32(Settings.Read("saat_12x24"));
            numericUpDown_24x00.Value = Convert.ToInt32(Settings.Read("saat_24x00"));
        }

        private void numericUpDown_0x1_ValueChanged(object sender, EventArgs e)
        {
            Settings.Write("saat_0x1", numericUpDown_0x1.Value.ToString());
        }

        private void numericUpDown_1x2_ValueChanged(object sender, EventArgs e)
        {
            Settings.Write("saat_1x2", numericUpDown_1x2.Value.ToString());
        }

        private void numericUpDown_2x4_ValueChanged(object sender, EventArgs e)
        {
            Settings.Write("saat_2x4", numericUpDown_2x4.Value.ToString());
        }

        private void numericUpDown_4x8_ValueChanged(object sender, EventArgs e)
        {
            Settings.Write("saat_4x8", numericUpDown_4x8.Value.ToString());
        }

        private void numericUpDown_8x12_ValueChanged(object sender, EventArgs e)
        {
            Settings.Write("saat_8x12", numericUpDown_8x12.Value.ToString());
        }

        private void numericUpDown_12x24_ValueChanged(object sender, EventArgs e)
        {
            Settings.Write("saat_12x24", numericUpDown_12x24.Value.ToString());
        }

        private void numericUpDown_24x00_ValueChanged(object sender, EventArgs e)
        {
            Settings.Write("saat_24x00", numericUpDown_24x00.Value.ToString());
        }

        private void numericUpDown_kapasite_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_kapasite.Value == 0)
                MessageBox.Show("Kapasite 0 (sıfır) olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                Settings.Write("kapasite", numericUpDown_kapasite.Value.ToString());
        }
    }
}
