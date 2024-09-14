namespace Bankamatik
{
    partial class FrmHesap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.LblTelefon = new System.Windows.Forms.Label();
            this.LblHesapNo = new System.Windows.Forms.Label();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.Grpbx = new System.Windows.Forms.GroupBox();
            this.BtnGonder = new System.Windows.Forms.Button();
            this.MskHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnHaraketler = new System.Windows.Forms.Button();
            this.Grpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad SoyAd:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hesap No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC Kimlik:";
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Location = new System.Drawing.Point(199, 167);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(45, 25);
            this.LblTc.TabIndex = 7;
            this.LblTc.Text = "Null";
            // 
            // LblTelefon
            // 
            this.LblTelefon.AutoSize = true;
            this.LblTelefon.Location = new System.Drawing.Point(199, 131);
            this.LblTelefon.Name = "LblTelefon";
            this.LblTelefon.Size = new System.Drawing.Size(45, 25);
            this.LblTelefon.TabIndex = 6;
            this.LblTelefon.Text = "Null";
            // 
            // LblHesapNo
            // 
            this.LblHesapNo.AutoSize = true;
            this.LblHesapNo.Location = new System.Drawing.Point(199, 95);
            this.LblHesapNo.Name = "LblHesapNo";
            this.LblHesapNo.Size = new System.Drawing.Size(45, 25);
            this.LblHesapNo.TabIndex = 5;
            this.LblHesapNo.Text = "Null";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(199, 59);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(45, 25);
            this.LblAdSoyad.TabIndex = 4;
            this.LblAdSoyad.Text = "Null";
            // 
            // Grpbx
            // 
            this.Grpbx.Controls.Add(this.BtnGonder);
            this.Grpbx.Controls.Add(this.MskHesapNo);
            this.Grpbx.Controls.Add(this.TxtTutar);
            this.Grpbx.Controls.Add(this.label5);
            this.Grpbx.Controls.Add(this.label6);
            this.Grpbx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Grpbx.Location = new System.Drawing.Point(0, 266);
            this.Grpbx.Name = "Grpbx";
            this.Grpbx.Size = new System.Drawing.Size(546, 218);
            this.Grpbx.TabIndex = 8;
            this.Grpbx.TabStop = false;
            this.Grpbx.Text = "Havale";
            // 
            // BtnGonder
            // 
            this.BtnGonder.Location = new System.Drawing.Point(182, 118);
            this.BtnGonder.Name = "BtnGonder";
            this.BtnGonder.Size = new System.Drawing.Size(92, 30);
            this.BtnGonder.TabIndex = 6;
            this.BtnGonder.Text = "Gönder";
            this.BtnGonder.UseVisualStyleBackColor = true;
            this.BtnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
            // 
            // MskHesapNo
            // 
            this.MskHesapNo.Location = new System.Drawing.Point(162, 45);
            this.MskHesapNo.Name = "MskHesapNo";
            this.MskHesapNo.Size = new System.Drawing.Size(139, 30);
            this.MskHesapNo.TabIndex = 5;
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(162, 82);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(139, 30);
            this.TxtTutar.TabIndex = 4;
            this.TxtTutar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tutar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Hesap No:";
            // 
            // BtnHaraketler
            // 
            this.BtnHaraketler.Location = new System.Drawing.Point(372, 59);
            this.BtnHaraketler.Name = "BtnHaraketler";
            this.BtnHaraketler.Size = new System.Drawing.Size(135, 39);
            this.BtnHaraketler.TabIndex = 9;
            this.BtnHaraketler.Text = "Haraketler";
            this.BtnHaraketler.UseVisualStyleBackColor = true;
            this.BtnHaraketler.Click += new System.EventHandler(this.BtnHaraketler_Click);
            // 
            // FrmHesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(546, 484);
            this.Controls.Add(this.BtnHaraketler);
            this.Controls.Add(this.Grpbx);
            this.Controls.Add(this.LblTc);
            this.Controls.Add(this.LblTelefon);
            this.Controls.Add(this.LblHesapNo);
            this.Controls.Add(this.LblAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmHesap";
            this.Text = "FrmHesap";
            this.Load += new System.EventHandler(this.FrmHesap_Load);
            this.Grpbx.ResumeLayout(false);
            this.Grpbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.Label LblTelefon;
        private System.Windows.Forms.Label LblHesapNo;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.GroupBox Grpbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.Button BtnGonder;
        private System.Windows.Forms.MaskedTextBox MskHesapNo;
        private System.Windows.Forms.Button BtnHaraketler;
    }
}