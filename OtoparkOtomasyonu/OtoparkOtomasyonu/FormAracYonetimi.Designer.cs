namespace OtoparkOtomasyonu
{
    partial class FormAracYonetimi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAracYonetimi));
            this.listViewBilgiler = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cikisYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.guncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.kaydiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAracGirisi = new System.Windows.Forms.Button();
            this.buttonAracCikisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelKapasite = new System.Windows.Forms.Label();
            this.dateTimePickerGirisSaati = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAracModeli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAracTipi = new System.Windows.Forms.ComboBox();
            this.textBoxPlaka = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonAracKayitEt = new System.Windows.Forms.Button();
            this.groupBoxAracGirisi = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxAracCikisi = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelUcret = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonCikisYap = new System.Windows.Forms.Button();
            this.comboBoxPlaka = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonUcretHesapla = new System.Windows.Forms.Button();
            this.dateTimePickerCikisSaati = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonMenuyuKapat = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxAracGirisi.SuspendLayout();
            this.groupBoxAracCikisi.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewBilgiler
            // 
            this.listViewBilgiler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewBilgiler.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewBilgiler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewBilgiler.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewBilgiler.FullRowSelect = true;
            this.listViewBilgiler.GridLines = true;
            this.listViewBilgiler.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewBilgiler.HideSelection = false;
            this.listViewBilgiler.Location = new System.Drawing.Point(0, 244);
            this.listViewBilgiler.MultiSelect = false;
            this.listViewBilgiler.Name = "listViewBilgiler";
            this.listViewBilgiler.Size = new System.Drawing.Size(997, 310);
            this.listViewBilgiler.TabIndex = 0;
            this.listViewBilgiler.UseCompatibleStateImageBehavior = false;
            this.listViewBilgiler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Kayıt No";
            this.columnHeader0.Width = 75;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Plaka";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 135;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Araç Tipi";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Arac Modeli";
            this.columnHeader6.Width = 130;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Giriş Tarihi";
            this.columnHeader7.Width = 160;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cikisYapToolStripMenuItem,
            this.toolStripSeparator1,
            this.guncelleToolStripMenuItem,
            this.toolStripSeparator2,
            this.kaydiSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 82);
            // 
            // cikisYapToolStripMenuItem
            // 
            this.cikisYapToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cikisYapToolStripMenuItem.Image")));
            this.cikisYapToolStripMenuItem.Name = "cikisYapToolStripMenuItem";
            this.cikisYapToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.cikisYapToolStripMenuItem.Text = "Çıkış Yap";
            this.cikisYapToolStripMenuItem.Click += new System.EventHandler(this.cikisYapToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // guncelleToolStripMenuItem
            // 
            this.guncelleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guncelleToolStripMenuItem.Image")));
            this.guncelleToolStripMenuItem.Name = "guncelleToolStripMenuItem";
            this.guncelleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guncelleToolStripMenuItem.Text = "Güncelle";
            this.guncelleToolStripMenuItem.Click += new System.EventHandler(this.guncelleToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // kaydiSilToolStripMenuItem
            // 
            this.kaydiSilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kaydiSilToolStripMenuItem.Image")));
            this.kaydiSilToolStripMenuItem.Name = "kaydiSilToolStripMenuItem";
            this.kaydiSilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kaydiSilToolStripMenuItem.Text = "Kaydı Sil";
            this.kaydiSilToolStripMenuItem.Click += new System.EventHandler(this.kaydiSilToolStripMenuItem_Click);
            // 
            // buttonAracGirisi
            // 
            this.buttonAracGirisi.BackColor = System.Drawing.Color.Teal;
            this.buttonAracGirisi.FlatAppearance.BorderSize = 0;
            this.buttonAracGirisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAracGirisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAracGirisi.ForeColor = System.Drawing.Color.White;
            this.buttonAracGirisi.Location = new System.Drawing.Point(12, 12);
            this.buttonAracGirisi.Name = "buttonAracGirisi";
            this.buttonAracGirisi.Size = new System.Drawing.Size(160, 42);
            this.buttonAracGirisi.TabIndex = 1;
            this.buttonAracGirisi.Text = "Araç Giriş Menüsü";
            this.buttonAracGirisi.UseVisualStyleBackColor = false;
            this.buttonAracGirisi.Click += new System.EventHandler(this.buttonAracGirisi_Click);
            // 
            // buttonAracCikisi
            // 
            this.buttonAracCikisi.BackColor = System.Drawing.Color.Teal;
            this.buttonAracCikisi.FlatAppearance.BorderSize = 0;
            this.buttonAracCikisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAracCikisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAracCikisi.ForeColor = System.Drawing.Color.White;
            this.buttonAracCikisi.Location = new System.Drawing.Point(178, 12);
            this.buttonAracCikisi.Name = "buttonAracCikisi";
            this.buttonAracCikisi.Size = new System.Drawing.Size(160, 42);
            this.buttonAracCikisi.TabIndex = 2;
            this.buttonAracCikisi.Text = "Araç Çıkış Menüsü";
            this.buttonAracCikisi.UseVisualStyleBackColor = false;
            this.buttonAracCikisi.Click += new System.EventHandler(this.buttonAracCikisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kapasite:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.labelKapasite);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(871, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 42);
            this.panel1.TabIndex = 4;
            // 
            // labelKapasite
            // 
            this.labelKapasite.AutoSize = true;
            this.labelKapasite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKapasite.ForeColor = System.Drawing.Color.White;
            this.labelKapasite.Location = new System.Drawing.Point(83, 10);
            this.labelKapasite.Name = "labelKapasite";
            this.labelKapasite.Size = new System.Drawing.Size(23, 21);
            this.labelKapasite.TabIndex = 1;
            this.labelKapasite.Text = "%";
            this.labelKapasite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePickerGirisSaati
            // 
            this.dateTimePickerGirisSaati.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerGirisSaati.Enabled = false;
            this.dateTimePickerGirisSaati.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerGirisSaati.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerGirisSaati.Location = new System.Drawing.Point(419, 83);
            this.dateTimePickerGirisSaati.Name = "dateTimePickerGirisSaati";
            this.dateTimePickerGirisSaati.Size = new System.Drawing.Size(195, 29);
            this.dateTimePickerGirisSaati.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(320, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Giriş Saati";
            // 
            // textBoxAracModeli
            // 
            this.textBoxAracModeli.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAracModeli.Location = new System.Drawing.Point(419, 48);
            this.textBoxAracModeli.Name = "textBoxAracModeli";
            this.textBoxAracModeli.Size = new System.Drawing.Size(195, 29);
            this.textBoxAracModeli.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(320, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Araç Modeli";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(320, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Araç Tipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Telefon";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSoyad.Location = new System.Drawing.Point(105, 83);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(195, 29);
            this.textBoxSoyad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Soyad";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAd.Location = new System.Drawing.Point(105, 48);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(195, 29);
            this.textBoxAd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ad";
            // 
            // comboBoxAracTipi
            // 
            this.comboBoxAracTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAracTipi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxAracTipi.FormattingEnabled = true;
            this.comboBoxAracTipi.Items.AddRange(new object[] {
            "Otomobil",
            "Kamyonet",
            "Motosiklet"});
            this.comboBoxAracTipi.Location = new System.Drawing.Point(419, 13);
            this.comboBoxAracTipi.Name = "comboBoxAracTipi";
            this.comboBoxAracTipi.Size = new System.Drawing.Size(195, 29);
            this.comboBoxAracTipi.TabIndex = 8;
            // 
            // textBoxPlaka
            // 
            this.textBoxPlaka.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPlaka.Location = new System.Drawing.Point(105, 13);
            this.textBoxPlaka.MaxLength = 10;
            this.textBoxPlaka.Name = "textBoxPlaka";
            this.textBoxPlaka.Size = new System.Drawing.Size(195, 29);
            this.textBoxPlaka.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Plaka";
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTemizle.Location = new System.Drawing.Point(544, 118);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(70, 29);
            this.buttonTemizle.TabIndex = 11;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonAracKayitEt
            // 
            this.buttonAracKayitEt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAracKayitEt.Location = new System.Drawing.Point(419, 118);
            this.buttonAracKayitEt.Name = "buttonAracKayitEt";
            this.buttonAracKayitEt.Size = new System.Drawing.Size(119, 29);
            this.buttonAracKayitEt.TabIndex = 10;
            this.buttonAracKayitEt.Text = "Kayıt Et";
            this.buttonAracKayitEt.UseVisualStyleBackColor = true;
            this.buttonAracKayitEt.Click += new System.EventHandler(this.buttonAracKayitEt_Click);
            // 
            // groupBoxAracGirisi
            // 
            this.groupBoxAracGirisi.Controls.Add(this.maskedTextBoxTelefon);
            this.groupBoxAracGirisi.Controls.Add(this.label8);
            this.groupBoxAracGirisi.Controls.Add(this.buttonTemizle);
            this.groupBoxAracGirisi.Controls.Add(this.textBoxPlaka);
            this.groupBoxAracGirisi.Controls.Add(this.buttonAracKayitEt);
            this.groupBoxAracGirisi.Controls.Add(this.comboBoxAracTipi);
            this.groupBoxAracGirisi.Controls.Add(this.dateTimePickerGirisSaati);
            this.groupBoxAracGirisi.Controls.Add(this.label2);
            this.groupBoxAracGirisi.Controls.Add(this.label7);
            this.groupBoxAracGirisi.Controls.Add(this.textBoxAd);
            this.groupBoxAracGirisi.Controls.Add(this.textBoxAracModeli);
            this.groupBoxAracGirisi.Controls.Add(this.label3);
            this.groupBoxAracGirisi.Controls.Add(this.label6);
            this.groupBoxAracGirisi.Controls.Add(this.textBoxSoyad);
            this.groupBoxAracGirisi.Controls.Add(this.label5);
            this.groupBoxAracGirisi.Controls.Add(this.label4);
            this.groupBoxAracGirisi.Location = new System.Drawing.Point(177, 68);
            this.groupBoxAracGirisi.Name = "groupBoxAracGirisi";
            this.groupBoxAracGirisi.Size = new System.Drawing.Size(627, 156);
            this.groupBoxAracGirisi.TabIndex = 31;
            this.groupBoxAracGirisi.TabStop = false;
            this.groupBoxAracGirisi.Visible = false;
            // 
            // maskedTextBoxTelefon
            // 
            this.maskedTextBoxTelefon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxTelefon.Location = new System.Drawing.Point(105, 118);
            this.maskedTextBoxTelefon.Mask = "(999) 000 0000";
            this.maskedTextBoxTelefon.Name = "maskedTextBoxTelefon";
            this.maskedTextBoxTelefon.Size = new System.Drawing.Size(195, 29);
            this.maskedTextBoxTelefon.TabIndex = 7;
            // 
            // groupBoxAracCikisi
            // 
            this.groupBoxAracCikisi.Controls.Add(this.panel3);
            this.groupBoxAracCikisi.Controls.Add(this.buttonCikisYap);
            this.groupBoxAracCikisi.Controls.Add(this.comboBoxPlaka);
            this.groupBoxAracCikisi.Controls.Add(this.label9);
            this.groupBoxAracCikisi.Controls.Add(this.buttonUcretHesapla);
            this.groupBoxAracCikisi.Controls.Add(this.dateTimePickerCikisSaati);
            this.groupBoxAracCikisi.Controls.Add(this.label11);
            this.groupBoxAracCikisi.Location = new System.Drawing.Point(177, 68);
            this.groupBoxAracCikisi.Name = "groupBoxAracCikisi";
            this.groupBoxAracCikisi.Size = new System.Drawing.Size(627, 156);
            this.groupBoxAracCikisi.TabIndex = 32;
            this.groupBoxAracCikisi.TabStop = false;
            this.groupBoxAracCikisi.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(101)))), ((int)(((byte)(48)))));
            this.panel3.Controls.Add(this.labelUcret);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(376, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 124);
            this.panel3.TabIndex = 33;
            // 
            // labelUcret
            // 
            this.labelUcret.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUcret.ForeColor = System.Drawing.Color.White;
            this.labelUcret.Location = new System.Drawing.Point(3, 58);
            this.labelUcret.Name = "labelUcret";
            this.labelUcret.Size = new System.Drawing.Size(219, 37);
            this.labelUcret.TabIndex = 32;
            this.labelUcret.Text = "--TL";
            this.labelUcret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(83, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Ücret";
            // 
            // buttonCikisYap
            // 
            this.buttonCikisYap.Enabled = false;
            this.buttonCikisYap.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikisYap.Location = new System.Drawing.Point(149, 119);
            this.buttonCikisYap.Name = "buttonCikisYap";
            this.buttonCikisYap.Size = new System.Drawing.Size(195, 29);
            this.buttonCikisYap.TabIndex = 30;
            this.buttonCikisYap.Text = "Çıkış Yap";
            this.buttonCikisYap.UseVisualStyleBackColor = true;
            this.buttonCikisYap.Click += new System.EventHandler(this.buttonCikisYap_Click);
            // 
            // comboBoxPlaka
            // 
            this.comboBoxPlaka.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPlaka.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPlaka.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxPlaka.FormattingEnabled = true;
            this.comboBoxPlaka.Location = new System.Drawing.Point(149, 14);
            this.comboBoxPlaka.Name = "comboBoxPlaka";
            this.comboBoxPlaka.Size = new System.Drawing.Size(195, 29);
            this.comboBoxPlaka.TabIndex = 29;
            this.comboBoxPlaka.TextChanged += new System.EventHandler(this.comboBoxPlaka_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(50, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Plaka";
            // 
            // buttonUcretHesapla
            // 
            this.buttonUcretHesapla.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUcretHesapla.Location = new System.Drawing.Point(149, 84);
            this.buttonUcretHesapla.Name = "buttonUcretHesapla";
            this.buttonUcretHesapla.Size = new System.Drawing.Size(195, 29);
            this.buttonUcretHesapla.TabIndex = 10;
            this.buttonUcretHesapla.Text = "Ücret Hesapla";
            this.buttonUcretHesapla.UseVisualStyleBackColor = true;
            this.buttonUcretHesapla.Click += new System.EventHandler(this.buttonUcretHesapla_Click);
            // 
            // dateTimePickerCikisSaati
            // 
            this.dateTimePickerCikisSaati.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerCikisSaati.Enabled = false;
            this.dateTimePickerCikisSaati.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerCikisSaati.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCikisSaati.Location = new System.Drawing.Point(149, 49);
            this.dateTimePickerCikisSaati.Name = "dateTimePickerCikisSaati";
            this.dateTimePickerCikisSaati.Size = new System.Drawing.Size(195, 29);
            this.dateTimePickerCikisSaati.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(50, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 21);
            this.label11.TabIndex = 27;
            this.label11.Text = "Çıkış Saati";
            // 
            // buttonMenuyuKapat
            // 
            this.buttonMenuyuKapat.BackColor = System.Drawing.Color.Gray;
            this.buttonMenuyuKapat.FlatAppearance.BorderSize = 0;
            this.buttonMenuyuKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuyuKapat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMenuyuKapat.ForeColor = System.Drawing.Color.White;
            this.buttonMenuyuKapat.Location = new System.Drawing.Point(344, 12);
            this.buttonMenuyuKapat.Name = "buttonMenuyuKapat";
            this.buttonMenuyuKapat.Size = new System.Drawing.Size(133, 42);
            this.buttonMenuyuKapat.TabIndex = 34;
            this.buttonMenuyuKapat.Text = "Menüyü Kapat";
            this.buttonMenuyuKapat.UseVisualStyleBackColor = false;
            this.buttonMenuyuKapat.Visible = false;
            this.buttonMenuyuKapat.Click += new System.EventHandler(this.buttonMenuyuKapat_Click);
            // 
            // FormAracYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 554);
            this.Controls.Add(this.buttonMenuyuKapat);
            this.Controls.Add(this.groupBoxAracCikisi);
            this.Controls.Add(this.groupBoxAracGirisi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAracCikisi);
            this.Controls.Add(this.buttonAracGirisi);
            this.Controls.Add(this.listViewBilgiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAracYonetimi";
            this.Text = "FormAracYonetimi";
            this.Load += new System.EventHandler(this.FormAracYonetimi_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxAracGirisi.ResumeLayout(false);
            this.groupBoxAracGirisi.PerformLayout();
            this.groupBoxAracCikisi.ResumeLayout(false);
            this.groupBoxAracCikisi.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewBilgiler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button buttonAracGirisi;
        private System.Windows.Forms.Button buttonAracCikisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerGirisSaati;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAracModeli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAracTipi;
        private System.Windows.Forms.TextBox textBoxPlaka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttonAracKayitEt;
        private System.Windows.Forms.GroupBox groupBoxAracGirisi;
        private System.Windows.Forms.Label labelKapasite;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefon;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.GroupBox groupBoxAracCikisi;
        private System.Windows.Forms.ComboBox comboBoxPlaka;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonUcretHesapla;
        private System.Windows.Forms.DateTimePicker dateTimePickerCikisSaati;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonCikisYap;
        private System.Windows.Forms.Label labelUcret;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cikisYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydiSilToolStripMenuItem;
        private System.Windows.Forms.Button buttonMenuyuKapat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}