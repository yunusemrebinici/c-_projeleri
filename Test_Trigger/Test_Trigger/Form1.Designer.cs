namespace Test_Trigger
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
			this.BtnSil = new System.Windows.Forms.Button();
			this.BtnEkle = new System.Windows.Forms.Button();
			this.TxtTur = new System.Windows.Forms.TextBox();
			this.TxtYayınEvi = new System.Windows.Forms.TextBox();
			this.TxtSayfa = new System.Windows.Forms.TextBox();
			this.TxtYazar = new System.Windows.Forms.TextBox();
			this.TxtAd = new System.Windows.Forms.TextBox();
			this.TxtId = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.LblKitapSayısı = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.BtnSil);
			this.groupBox1.Controls.Add(this.BtnEkle);
			this.groupBox1.Controls.Add(this.TxtTur);
			this.groupBox1.Controls.Add(this.TxtYayınEvi);
			this.groupBox1.Controls.Add(this.TxtSayfa);
			this.groupBox1.Controls.Add(this.TxtYazar);
			this.groupBox1.Controls.Add(this.TxtAd);
			this.groupBox1.Controls.Add(this.TxtId);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(311, 439);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kitap Ekleme";
			// 
			// BtnSil
			// 
			this.BtnSil.Location = new System.Drawing.Point(187, 332);
			this.BtnSil.Name = "BtnSil";
			this.BtnSil.Size = new System.Drawing.Size(75, 31);
			this.BtnSil.TabIndex = 8;
			this.BtnSil.Text = "Sil";
			this.BtnSil.UseVisualStyleBackColor = true;
			this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
			// 
			// BtnEkle
			// 
			this.BtnEkle.Location = new System.Drawing.Point(91, 332);
			this.BtnEkle.Name = "BtnEkle";
			this.BtnEkle.Size = new System.Drawing.Size(75, 31);
			this.BtnEkle.TabIndex = 1;
			this.BtnEkle.Text = "Ekle";
			this.BtnEkle.UseVisualStyleBackColor = true;
			this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
			// 
			// TxtTur
			// 
			this.TxtTur.Location = new System.Drawing.Point(137, 275);
			this.TxtTur.Name = "TxtTur";
			this.TxtTur.Size = new System.Drawing.Size(100, 30);
			this.TxtTur.TabIndex = 7;
			// 
			// TxtYayınEvi
			// 
			this.TxtYayınEvi.Location = new System.Drawing.Point(137, 235);
			this.TxtYayınEvi.Name = "TxtYayınEvi";
			this.TxtYayınEvi.Size = new System.Drawing.Size(100, 30);
			this.TxtYayınEvi.TabIndex = 7;
			// 
			// TxtSayfa
			// 
			this.TxtSayfa.Location = new System.Drawing.Point(137, 195);
			this.TxtSayfa.Name = "TxtSayfa";
			this.TxtSayfa.Size = new System.Drawing.Size(100, 30);
			this.TxtSayfa.TabIndex = 7;
			// 
			// TxtYazar
			// 
			this.TxtYazar.Location = new System.Drawing.Point(137, 155);
			this.TxtYazar.Name = "TxtYazar";
			this.TxtYazar.Size = new System.Drawing.Size(100, 30);
			this.TxtYazar.TabIndex = 7;
			// 
			// TxtAd
			// 
			this.TxtAd.Location = new System.Drawing.Point(137, 115);
			this.TxtAd.Name = "TxtAd";
			this.TxtAd.Size = new System.Drawing.Size(100, 30);
			this.TxtAd.TabIndex = 7;
			// 
			// TxtId
			// 
			this.TxtId.Enabled = false;
			this.TxtId.Location = new System.Drawing.Point(137, 75);
			this.TxtId.Name = "TxtId";
			this.TxtId.Size = new System.Drawing.Size(100, 30);
			this.TxtId.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(65, 280);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(42, 25);
			this.label6.TabIndex = 6;
			this.label6.Text = "Tür";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 239);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 25);
			this.label5.TabIndex = 5;
			this.label5.Text = "YayınEvi:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(38, 198);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 25);
			this.label4.TabIndex = 4;
			this.label4.Text = "Sayfa:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(70, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 25);
			this.label3.TabIndex = 3;
			this.label3.Text = "ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 157);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Yazar:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(64, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ad:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView1);
			this.groupBox2.Location = new System.Drawing.Point(341, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(506, 392);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
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
			this.dataGridView1.Size = new System.Drawing.Size(500, 363);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 17);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(121, 25);
			this.label7.TabIndex = 7;
			this.label7.Text = "Kitap Sayısı:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.LblKitapSayısı);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Location = new System.Drawing.Point(344, 390);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(503, 61);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			// 
			// LblKitapSayısı
			// 
			this.LblKitapSayısı.AutoSize = true;
			this.LblKitapSayısı.Location = new System.Drawing.Point(131, 17);
			this.LblKitapSayısı.Name = "LblKitapSayısı";
			this.LblKitapSayısı.Size = new System.Drawing.Size(48, 25);
			this.LblKitapSayısı.TabIndex = 8;
			this.LblKitapSayısı.Text = "Tür:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(859, 472);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "...";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox TxtTur;
        private System.Windows.Forms.TextBox TxtYayınEvi;
        private System.Windows.Forms.TextBox TxtSayfa;
        private System.Windows.Forms.TextBox TxtYazar;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblKitapSayısı;
    }
}

