namespace proje6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GbxPer = new System.Windows.Forms.GroupBox();
            this.BtnPerEkle = new System.Windows.Forms.Button();
            this.TxtPerAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GbxMusteri = new System.Windows.Forms.GroupBox();
            this.BtnMusteriEkle = new System.Windows.Forms.Button();
            this.TxtMusteri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GbxÜrün = new System.Windows.Forms.GroupBox();
            this.BtnUrunEkle = new System.Windows.Forms.Button();
            this.TxtSatıs = new System.Windows.Forms.TextBox();
            this.TxtAlıs = new System.Windows.Forms.TextBox();
            this.TxtStok = new System.Windows.Forms.TextBox();
            this.TxtUrunAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.BtnSatis = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbPersonel = new System.Windows.Forms.ComboBox();
            this.CmbMusteri = new System.Windows.Forms.ComboBox();
            this.CmbUrun = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GbxPer.SuspendLayout();
            this.GbxMusteri.SuspendLayout();
            this.GbxÜrün.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1464, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 447);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1472, 245);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Haraketler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GbxPer);
            this.groupBox2.Controls.Add(this.GbxMusteri);
            this.groupBox2.Controls.Add(this.GbxÜrün);
            this.groupBox2.Location = new System.Drawing.Point(18, 55);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(799, 395);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekleme işlemleri";
            // 
            // GbxPer
            // 
            this.GbxPer.Controls.Add(this.BtnPerEkle);
            this.GbxPer.Controls.Add(this.TxtPerAd);
            this.GbxPer.Controls.Add(this.label6);
            this.GbxPer.Location = new System.Drawing.Point(523, 71);
            this.GbxPer.Name = "GbxPer";
            this.GbxPer.Size = new System.Drawing.Size(248, 284);
            this.GbxPer.TabIndex = 2;
            this.GbxPer.TabStop = false;
            this.GbxPer.Text = "Personel Ekleme";
            // 
            // BtnPerEkle
            // 
            this.BtnPerEkle.Location = new System.Drawing.Point(84, 232);
            this.BtnPerEkle.Name = "BtnPerEkle";
            this.BtnPerEkle.Size = new System.Drawing.Size(75, 36);
            this.BtnPerEkle.TabIndex = 6;
            this.BtnPerEkle.Text = "Ekle";
            this.BtnPerEkle.UseVisualStyleBackColor = true;
            this.BtnPerEkle.Click += new System.EventHandler(this.BtnPerEkle_Click);
            // 
            // TxtPerAd
            // 
            this.TxtPerAd.Location = new System.Drawing.Point(122, 61);
            this.TxtPerAd.MaxLength = 30;
            this.TxtPerAd.Name = "TxtPerAd";
            this.TxtPerAd.Size = new System.Drawing.Size(100, 30);
            this.TxtPerAd.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ad SoyAd:";
            // 
            // GbxMusteri
            // 
            this.GbxMusteri.Controls.Add(this.BtnMusteriEkle);
            this.GbxMusteri.Controls.Add(this.TxtMusteri);
            this.GbxMusteri.Controls.Add(this.label5);
            this.GbxMusteri.Location = new System.Drawing.Point(285, 71);
            this.GbxMusteri.Name = "GbxMusteri";
            this.GbxMusteri.Size = new System.Drawing.Size(232, 284);
            this.GbxMusteri.TabIndex = 1;
            this.GbxMusteri.TabStop = false;
            this.GbxMusteri.Text = "Müşteri Ekleme";
            // 
            // BtnMusteriEkle
            // 
            this.BtnMusteriEkle.Location = new System.Drawing.Point(94, 232);
            this.BtnMusteriEkle.Name = "BtnMusteriEkle";
            this.BtnMusteriEkle.Size = new System.Drawing.Size(75, 36);
            this.BtnMusteriEkle.TabIndex = 4;
            this.BtnMusteriEkle.Text = "Ekle";
            this.BtnMusteriEkle.UseVisualStyleBackColor = true;
            this.BtnMusteriEkle.Click += new System.EventHandler(this.BtnMusteriEkle_Click);
            // 
            // TxtMusteri
            // 
            this.TxtMusteri.Location = new System.Drawing.Point(120, 61);
            this.TxtMusteri.MaxLength = 30;
            this.TxtMusteri.Name = "TxtMusteri";
            this.TxtMusteri.Size = new System.Drawing.Size(100, 30);
            this.TxtMusteri.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ad SoyAd:";
            // 
            // GbxÜrün
            // 
            this.GbxÜrün.Controls.Add(this.BtnUrunEkle);
            this.GbxÜrün.Controls.Add(this.TxtSatıs);
            this.GbxÜrün.Controls.Add(this.TxtAlıs);
            this.GbxÜrün.Controls.Add(this.TxtStok);
            this.GbxÜrün.Controls.Add(this.TxtUrunAd);
            this.GbxÜrün.Controls.Add(this.label4);
            this.GbxÜrün.Controls.Add(this.label3);
            this.GbxÜrün.Controls.Add(this.label2);
            this.GbxÜrün.Controls.Add(this.label1);
            this.GbxÜrün.Location = new System.Drawing.Point(7, 71);
            this.GbxÜrün.Name = "GbxÜrün";
            this.GbxÜrün.Size = new System.Drawing.Size(258, 284);
            this.GbxÜrün.TabIndex = 0;
            this.GbxÜrün.TabStop = false;
            this.GbxÜrün.Text = "Ürün Ekleme";
            this.GbxÜrün.Enter += new System.EventHandler(this.GbxÜrün_Enter);
            // 
            // BtnUrunEkle
            // 
            this.BtnUrunEkle.Location = new System.Drawing.Point(63, 232);
            this.BtnUrunEkle.Name = "BtnUrunEkle";
            this.BtnUrunEkle.Size = new System.Drawing.Size(75, 36);
            this.BtnUrunEkle.TabIndex = 8;
            this.BtnUrunEkle.Text = "Ekle";
            this.BtnUrunEkle.UseVisualStyleBackColor = true;
            this.BtnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click);
            // 
            // TxtSatıs
            // 
            this.TxtSatıs.Location = new System.Drawing.Point(128, 182);
            this.TxtSatıs.MaxLength = 30;
            this.TxtSatıs.Name = "TxtSatıs";
            this.TxtSatıs.Size = new System.Drawing.Size(100, 30);
            this.TxtSatıs.TabIndex = 7;
            // 
            // TxtAlıs
            // 
            this.TxtAlıs.Location = new System.Drawing.Point(128, 140);
            this.TxtAlıs.MaxLength = 30;
            this.TxtAlıs.Name = "TxtAlıs";
            this.TxtAlıs.Size = new System.Drawing.Size(100, 30);
            this.TxtAlıs.TabIndex = 6;
            // 
            // TxtStok
            // 
            this.TxtStok.Location = new System.Drawing.Point(128, 98);
            this.TxtStok.MaxLength = 30;
            this.TxtStok.Name = "TxtStok";
            this.TxtStok.Size = new System.Drawing.Size(100, 30);
            this.TxtStok.TabIndex = 5;
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.Location = new System.Drawing.Point(128, 56);
            this.TxtUrunAd.MaxLength = 30;
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(100, 30);
            this.TxtUrunAd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Satış Fiyatı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alış Fiyatı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stok Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtfiyat);
            this.groupBox3.Controls.Add(this.BtnSatis);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.CmbPersonel);
            this.groupBox3.Controls.Add(this.CmbMusteri);
            this.groupBox3.Controls.Add(this.CmbUrun);
            this.groupBox3.Location = new System.Drawing.Point(825, 55);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(660, 395);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Satış İşlemleri";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(519, 95);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(100, 30);
            this.txtfiyat.TabIndex = 10;
            // 
            // BtnSatis
            // 
            this.BtnSatis.Location = new System.Drawing.Point(255, 303);
            this.BtnSatis.Name = "BtnSatis";
            this.BtnSatis.Size = new System.Drawing.Size(75, 36);
            this.BtnSatis.TabIndex = 9;
            this.BtnSatis.Text = "Ekle";
            this.BtnSatis.UseVisualStyleBackColor = true;
            this.BtnSatis.Click += new System.EventHandler(this.BtnSatis_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(514, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Ürün  Fiyatı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(369, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Personel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Müşteri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ürün ";
            // 
            // CmbPersonel
            // 
            this.CmbPersonel.FormattingEnabled = true;
            this.CmbPersonel.Location = new System.Drawing.Point(358, 92);
            this.CmbPersonel.Name = "CmbPersonel";
            this.CmbPersonel.Size = new System.Drawing.Size(123, 33);
            this.CmbPersonel.TabIndex = 2;
            // 
            // CmbMusteri
            // 
            this.CmbMusteri.FormattingEnabled = true;
            this.CmbMusteri.Location = new System.Drawing.Point(207, 92);
            this.CmbMusteri.Name = "CmbMusteri";
            this.CmbMusteri.Size = new System.Drawing.Size(123, 33);
            this.CmbMusteri.TabIndex = 1;
            // 
            // CmbUrun
            // 
            this.CmbUrun.FormattingEnabled = true;
            this.CmbUrun.Location = new System.Drawing.Point(51, 92);
            this.CmbUrun.Name = "CmbUrun";
            this.CmbUrun.Size = new System.Drawing.Size(123, 33);
            this.CmbUrun.TabIndex = 0;
            this.CmbUrun.SelectedIndexChanged += new System.EventHandler(this.CmbUrun_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 710);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.GbxPer.ResumeLayout(false);
            this.GbxPer.PerformLayout();
            this.GbxMusteri.ResumeLayout(false);
            this.GbxMusteri.PerformLayout();
            this.GbxÜrün.ResumeLayout(false);
            this.GbxÜrün.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox GbxÜrün;
        private System.Windows.Forms.TextBox TxtUrunAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbxPer;
        private System.Windows.Forms.TextBox TxtPerAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GbxMusteri;
        private System.Windows.Forms.TextBox TxtMusteri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSatıs;
        private System.Windows.Forms.TextBox TxtAlıs;
        private System.Windows.Forms.TextBox TxtStok;
        private System.Windows.Forms.Button BtnPerEkle;
        private System.Windows.Forms.Button BtnMusteriEkle;
        private System.Windows.Forms.Button BtnUrunEkle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbPersonel;
        private System.Windows.Forms.ComboBox CmbMusteri;
        private System.Windows.Forms.ComboBox CmbUrun;
        private System.Windows.Forms.Button BtnSatis;
        private System.Windows.Forms.TextBox txtfiyat;
    }
}

