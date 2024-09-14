namespace Etüt_test
{
    partial class Form1
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.BtnEtut = new System.Windows.Forms.Button();
			this.MskSaat = new System.Windows.Forms.MaskedTextBox();
			this.MskTarih = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.CmbOgretmen = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.CmbDers = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.CmbOgrenci = new System.Windows.Forms.ComboBox();
			this.BtnEtutDetay = new System.Windows.Forms.Button();
			this.LblDersId = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.BtnDersEkle = new System.Windows.Forms.Button();
			this.TxtDersEkle = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.BtnEkle = new System.Windows.Forms.Button();
			this.RchMail = new System.Windows.Forms.RichTextBox();
			this.MskOgrTelEkle = new System.Windows.Forms.MaskedTextBox();
			this.CmbSınıf = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.TxtOgrSoyEkle = new System.Windows.Forms.TextBox();
			this.TxtOgrAdEkle = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.BtnFotograf = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.LblFotoYol = new System.Windows.Forms.Label();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.BtnOgrtEkle = new System.Windows.Forms.Button();
			this.CmbBrans = new System.Windows.Forms.ComboBox();
			this.TxtHocaSoyad = new System.Windows.Forms.TextBox();
			this.TxtHocaEkle = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.LblFotoYol2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox7.SuspendLayout();
			this.groupBox8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.BtnEtut);
			this.groupBox1.Controls.Add(this.MskSaat);
			this.groupBox1.Controls.Add(this.MskTarih);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.CmbOgretmen);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.CmbDers);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 22);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(381, 310);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// BtnEtut
			// 
			this.BtnEtut.Location = new System.Drawing.Point(158, 202);
			this.BtnEtut.Name = "BtnEtut";
			this.BtnEtut.Size = new System.Drawing.Size(145, 39);
			this.BtnEtut.TabIndex = 1;
			this.BtnEtut.Text = "Etüt Oluştur";
			this.BtnEtut.UseVisualStyleBackColor = true;
			this.BtnEtut.Click += new System.EventHandler(this.BtnEtut_Click);
			// 
			// MskSaat
			// 
			this.MskSaat.Location = new System.Drawing.Point(135, 166);
			this.MskSaat.Mask = "00:00";
			this.MskSaat.Name = "MskSaat";
			this.MskSaat.Size = new System.Drawing.Size(190, 30);
			this.MskSaat.TabIndex = 9;
			this.MskSaat.ValidatingType = typeof(System.DateTime);
			// 
			// MskTarih
			// 
			this.MskTarih.Location = new System.Drawing.Point(135, 125);
			this.MskTarih.Mask = "00/00/0000";
			this.MskTarih.Name = "MskTarih";
			this.MskTarih.Size = new System.Drawing.Size(190, 30);
			this.MskTarih.TabIndex = 8;
			this.MskTarih.ValidatingType = typeof(System.DateTime);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(60, 172);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 24);
			this.label4.TabIndex = 7;
			this.label4.Text = "Saat:";
			// 
			// CmbOgretmen
			// 
			this.CmbOgretmen.FormattingEnabled = true;
			this.CmbOgretmen.Location = new System.Drawing.Point(135, 82);
			this.CmbOgretmen.Name = "CmbOgretmen";
			this.CmbOgretmen.Size = new System.Drawing.Size(190, 32);
			this.CmbOgretmen.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(60, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "Tarih:";
			// 
			// CmbDers
			// 
			this.CmbDers.FormattingEnabled = true;
			this.CmbDers.Location = new System.Drawing.Point(135, 40);
			this.CmbDers.Name = "CmbDers";
			this.CmbDers.Size = new System.Drawing.Size(190, 32);
			this.CmbDers.TabIndex = 1;
			this.CmbDers.SelectedIndexChanged += new System.EventHandler(this.CmbDers_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Öğretmen:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(69, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ders";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.CmbOgrenci);
			this.groupBox2.Controls.Add(this.BtnEtutDetay);
			this.groupBox2.Controls.Add(this.LblDersId);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(404, 22);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(352, 199);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// CmbOgrenci
			// 
			this.CmbOgrenci.FormattingEnabled = true;
			this.CmbOgrenci.Location = new System.Drawing.Point(119, 32);
			this.CmbOgrenci.Name = "CmbOgrenci";
			this.CmbOgrenci.Size = new System.Drawing.Size(121, 32);
			this.CmbOgrenci.TabIndex = 7;
			this.CmbOgrenci.SelectedIndexChanged += new System.EventHandler(this.CmbOgrenci_SelectedIndexChanged);
			// 
			// BtnEtutDetay
			// 
			this.BtnEtutDetay.Location = new System.Drawing.Point(116, 109);
			this.BtnEtutDetay.Name = "BtnEtutDetay";
			this.BtnEtutDetay.Size = new System.Drawing.Size(136, 33);
			this.BtnEtutDetay.TabIndex = 6;
			this.BtnEtutDetay.Text = "Etüt Al";
			this.BtnEtutDetay.UseVisualStyleBackColor = true;
			this.BtnEtutDetay.Click += new System.EventHandler(this.BtnEtutDetay_Click);
			// 
			// LblDersId
			// 
			this.LblDersId.AutoSize = true;
			this.LblDersId.Location = new System.Drawing.Point(209, 82);
			this.LblDersId.Name = "LblDersId";
			this.LblDersId.Size = new System.Drawing.Size(43, 24);
			this.LblDersId.TabIndex = 5;
			this.LblDersId.Text = "Null";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 82);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(169, 24);
			this.label6.TabIndex = 1;
			this.label6.Text = "SEÇİLEN DERS ID:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 24);
			this.label5.TabIndex = 0;
			this.label5.Text = "Öğrencİ Ad:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGridView1);
			this.groupBox3.Location = new System.Drawing.Point(0, 356);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(973, 262);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 26);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(967, 233);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.BtnDersEkle);
			this.groupBox4.Controls.Add(this.TxtDersEkle);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Location = new System.Drawing.Point(404, 188);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(352, 144);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Ders Ekle";
			// 
			// BtnDersEkle
			// 
			this.BtnDersEkle.Location = new System.Drawing.Point(136, 65);
			this.BtnDersEkle.Name = "BtnDersEkle";
			this.BtnDersEkle.Size = new System.Drawing.Size(75, 29);
			this.BtnDersEkle.TabIndex = 5;
			this.BtnDersEkle.Text = "Ekle";
			this.BtnDersEkle.UseVisualStyleBackColor = true;
			this.BtnDersEkle.Click += new System.EventHandler(this.BtnDersEkle_Click);
			// 
			// TxtDersEkle
			// 
			this.TxtDersEkle.Location = new System.Drawing.Point(116, 29);
			this.TxtDersEkle.Name = "TxtDersEkle";
			this.TxtDersEkle.Size = new System.Drawing.Size(136, 30);
			this.TxtDersEkle.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(58, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 24);
			this.label7.TabIndex = 3;
			this.label7.Text = "Ders";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.BtnEkle);
			this.groupBox5.Controls.Add(this.RchMail);
			this.groupBox5.Controls.Add(this.MskOgrTelEkle);
			this.groupBox5.Controls.Add(this.CmbSınıf);
			this.groupBox5.Controls.Add(this.label12);
			this.groupBox5.Controls.Add(this.label10);
			this.groupBox5.Controls.Add(this.label11);
			this.groupBox5.Controls.Add(this.TxtOgrSoyEkle);
			this.groupBox5.Controls.Add(this.TxtOgrAdEkle);
			this.groupBox5.Controls.Add(this.label9);
			this.groupBox5.Controls.Add(this.label8);
			this.groupBox5.Location = new System.Drawing.Point(979, 22);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(260, 312);
			this.groupBox5.TabIndex = 4;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Öğrenci Ekleme";
			// 
			// BtnEkle
			// 
			this.BtnEkle.Location = new System.Drawing.Point(118, 215);
			this.BtnEkle.Name = "BtnEkle";
			this.BtnEkle.Size = new System.Drawing.Size(116, 29);
			this.BtnEkle.TabIndex = 11;
			this.BtnEkle.Text = "Öğrenci Ekle";
			this.BtnEkle.UseVisualStyleBackColor = true;
			this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
			// 
			// RchMail
			// 
			this.RchMail.Location = new System.Drawing.Point(121, 183);
			this.RchMail.Name = "RchMail";
			this.RchMail.Size = new System.Drawing.Size(113, 26);
			this.RchMail.TabIndex = 10;
			this.RchMail.Text = "";
			// 
			// MskOgrTelEkle
			// 
			this.MskOgrTelEkle.Location = new System.Drawing.Point(121, 147);
			this.MskOgrTelEkle.Mask = "(999) 000-0000";
			this.MskOgrTelEkle.Name = "MskOgrTelEkle";
			this.MskOgrTelEkle.Size = new System.Drawing.Size(113, 30);
			this.MskOgrTelEkle.TabIndex = 9;
			// 
			// CmbSınıf
			// 
			this.CmbSınıf.FormattingEnabled = true;
			this.CmbSınıf.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12"});
			this.CmbSınıf.Location = new System.Drawing.Point(121, 109);
			this.CmbSınıf.Name = "CmbSınıf";
			this.CmbSınıf.Size = new System.Drawing.Size(113, 32);
			this.CmbSınıf.TabIndex = 8;
			this.CmbSınıf.SelectedIndexChanged += new System.EventHandler(this.CmbSınıf_SelectedIndexChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(54, 187);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(49, 24);
			this.label12.TabIndex = 7;
			this.label12.Text = "Mail.";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(36, 151);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 24);
			this.label10.TabIndex = 6;
			this.label10.Text = "Telefon:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(54, 115);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(49, 24);
			this.label11.TabIndex = 5;
			this.label11.Text = "Sınıf:";
			// 
			// TxtOgrSoyEkle
			// 
			this.TxtOgrSoyEkle.Location = new System.Drawing.Point(121, 73);
			this.TxtOgrSoyEkle.Name = "TxtOgrSoyEkle";
			this.TxtOgrSoyEkle.Size = new System.Drawing.Size(113, 30);
			this.TxtOgrSoyEkle.TabIndex = 4;
			// 
			// TxtOgrAdEkle
			// 
			this.TxtOgrAdEkle.Location = new System.Drawing.Point(121, 37);
			this.TxtOgrAdEkle.Name = "TxtOgrAdEkle";
			this.TxtOgrAdEkle.Size = new System.Drawing.Size(113, 30);
			this.TxtOgrAdEkle.TabIndex = 3;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(38, 79);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 24);
			this.label9.TabIndex = 2;
			this.label9.Text = "Soy Ad:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 43);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(97, 24);
			this.label8.TabIndex = 1;
			this.label8.Text = "Öğrencİ Ad:";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.BtnFotograf);
			this.groupBox6.Controls.Add(this.pictureBox1);
			this.groupBox6.Location = new System.Drawing.Point(1245, 22);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(242, 310);
			this.groupBox6.TabIndex = 5;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Öğrenci Fotoğraf Ekleme";
			// 
			// BtnFotograf
			// 
			this.BtnFotograf.Location = new System.Drawing.Point(62, 205);
			this.BtnFotograf.Name = "BtnFotograf";
			this.BtnFotograf.Size = new System.Drawing.Size(98, 37);
			this.BtnFotograf.TabIndex = 1;
			this.BtnFotograf.Text = "Fotoğraf Seç";
			this.BtnFotograf.UseVisualStyleBackColor = true;
			this.BtnFotograf.Click += new System.EventHandler(this.BtnFotograf_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(6, 31);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(230, 168);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// LblFotoYol
			// 
			this.LblFotoYol.AutoSize = true;
			this.LblFotoYol.Location = new System.Drawing.Point(530, 9);
			this.LblFotoYol.Name = "LblFotoYol";
			this.LblFotoYol.Size = new System.Drawing.Size(49, 24);
			this.LblFotoYol.TabIndex = 8;
			this.LblFotoYol.Text = "Mail.";
			this.LblFotoYol.Visible = false;
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.BtnOgrtEkle);
			this.groupBox7.Controls.Add(this.CmbBrans);
			this.groupBox7.Controls.Add(this.TxtHocaSoyad);
			this.groupBox7.Controls.Add(this.TxtHocaEkle);
			this.groupBox7.Controls.Add(this.label15);
			this.groupBox7.Controls.Add(this.label14);
			this.groupBox7.Controls.Add(this.label13);
			this.groupBox7.Location = new System.Drawing.Point(979, 356);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(501, 250);
			this.groupBox7.TabIndex = 9;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Öğretmen Ekle";
			this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
			// 
			// BtnOgrtEkle
			// 
			this.BtnOgrtEkle.Location = new System.Drawing.Point(125, 146);
			this.BtnOgrtEkle.Name = "BtnOgrtEkle";
			this.BtnOgrtEkle.Size = new System.Drawing.Size(188, 34);
			this.BtnOgrtEkle.TabIndex = 6;
			this.BtnOgrtEkle.Text = "Ekle";
			this.BtnOgrtEkle.UseVisualStyleBackColor = true;
			this.BtnOgrtEkle.Click += new System.EventHandler(this.BtnOgrtEkle_Click);
			// 
			// CmbBrans
			// 
			this.CmbBrans.FormattingEnabled = true;
			this.CmbBrans.Location = new System.Drawing.Point(116, 108);
			this.CmbBrans.Name = "CmbBrans";
			this.CmbBrans.Size = new System.Drawing.Size(208, 32);
			this.CmbBrans.TabIndex = 5;
			// 
			// TxtHocaSoyad
			// 
			this.TxtHocaSoyad.Location = new System.Drawing.Point(116, 72);
			this.TxtHocaSoyad.Name = "TxtHocaSoyad";
			this.TxtHocaSoyad.Size = new System.Drawing.Size(208, 30);
			this.TxtHocaSoyad.TabIndex = 4;
			// 
			// TxtHocaEkle
			// 
			this.TxtHocaEkle.Location = new System.Drawing.Point(116, 36);
			this.TxtHocaEkle.Name = "TxtHocaEkle";
			this.TxtHocaEkle.Size = new System.Drawing.Size(208, 30);
			this.TxtHocaEkle.TabIndex = 3;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(37, 111);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(56, 24);
			this.label15.TabIndex = 2;
			this.label15.Text = "Branş:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(28, 75);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(65, 24);
			this.label14.TabIndex = 1;
			this.label14.Text = "Soy Ad:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(57, 42);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(36, 24);
			this.label13.TabIndex = 0;
			this.label13.Text = "Ad:";
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.pictureBox2);
			this.groupBox8.Location = new System.Drawing.Point(762, 22);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(200, 310);
			this.groupBox8.TabIndex = 10;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Öğrenci Fotoğrafı";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox2.Location = new System.Drawing.Point(3, 26);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(194, 281);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// LblFotoYol2
			// 
			this.LblFotoYol2.AutoSize = true;
			this.LblFotoYol2.Location = new System.Drawing.Point(650, 9);
			this.LblFotoYol2.Name = "LblFotoYol2";
			this.LblFotoYol2.Size = new System.Drawing.Size(49, 24);
			this.LblFotoYol2.TabIndex = 11;
			this.LblFotoYol2.Text = "Mail.";
			this.LblFotoYol2.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(1523, 618);
			this.Controls.Add(this.LblFotoYol2);
			this.Controls.Add(this.groupBox8);
			this.Controls.Add(this.groupBox7);
			this.Controls.Add(this.LblFotoYol);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.groupBox8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEtut;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbOgretmen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbDers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnEtutDetay;
        private System.Windows.Forms.Label LblDersId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CmbOgrenci;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnDersEkle;
        private System.Windows.Forms.TextBox TxtDersEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtOgrSoyEkle;
        private System.Windows.Forms.TextBox TxtOgrAdEkle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label LblFotoYol;
        private System.Windows.Forms.Button BtnFotograf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox RchMail;
        private System.Windows.Forms.MaskedTextBox MskOgrTelEkle;
        private System.Windows.Forms.ComboBox CmbSınıf;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button BtnOgrtEkle;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.TextBox TxtHocaSoyad;
        private System.Windows.Forms.TextBox TxtHocaEkle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblFotoYol2;
    }
}

