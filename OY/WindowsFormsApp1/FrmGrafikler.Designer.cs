namespace WindowsFormsApp1
{
    partial class FrmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PrgAP = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LblA = new System.Windows.Forms.Label();
            this.LblB = new System.Windows.Forms.Label();
            this.PrgBP = new System.Windows.Forms.ProgressBar();
            this.LblC = new System.Windows.Forms.Label();
            this.PrgCP = new System.Windows.Forms.ProgressBar();
            this.LblD = new System.Windows.Forms.Label();
            this.PrgDP = new System.Windows.Forms.ProgressBar();
            this.LblE = new System.Windows.Forms.Label();
            this.PrgEP = new System.Windows.Forms.ProgressBar();
            this.LblTa = new System.Windows.Forms.Label();
            this.LblTb = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.LblTd = new System.Windows.Forms.Label();
            this.LblTe = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 26);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Partiler";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(550, 251);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblTe);
            this.groupBox2.Controls.Add(this.LblTd);
            this.groupBox2.Controls.Add(this.LblTc);
            this.groupBox2.Controls.Add(this.LblTb);
            this.groupBox2.Controls.Add(this.LblTa);
            this.groupBox2.Controls.Add(this.LblE);
            this.groupBox2.Controls.Add(this.PrgEP);
            this.groupBox2.Controls.Add(this.LblD);
            this.groupBox2.Controls.Add(this.PrgDP);
            this.groupBox2.Controls.Add(this.LblC);
            this.groupBox2.Controls.Add(this.PrgCP);
            this.groupBox2.Controls.Add(this.LblB);
            this.groupBox2.Controls.Add(this.PrgBP);
            this.groupBox2.Controls.Add(this.LblA);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.PrgAP);
            this.groupBox2.Location = new System.Drawing.Point(15, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 270);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // PrgAP
            // 
            this.PrgAP.Location = new System.Drawing.Point(103, 74);
            this.PrgAP.Maximum = 200;
            this.PrgAP.Name = "PrgAP";
            this.PrgAP.Size = new System.Drawing.Size(349, 27);
            this.PrgAP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "İlçe Seçiniz";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Location = new System.Drawing.Point(18, 76);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(89, 25);
            this.LblA.TabIndex = 3;
            this.LblA.Text = "A PARTİ";
            // 
            // LblB
            // 
            this.LblB.AutoSize = true;
            this.LblB.Location = new System.Drawing.Point(18, 109);
            this.LblB.Name = "LblB";
            this.LblB.Size = new System.Drawing.Size(88, 25);
            this.LblB.TabIndex = 5;
            this.LblB.Text = "B PARTİ";
            // 
            // PrgBP
            // 
            this.PrgBP.Location = new System.Drawing.Point(103, 107);
            this.PrgBP.Maximum = 200;
            this.PrgBP.Name = "PrgBP";
            this.PrgBP.Size = new System.Drawing.Size(349, 27);
            this.PrgBP.TabIndex = 4;
            // 
            // LblC
            // 
            this.LblC.AutoSize = true;
            this.LblC.Location = new System.Drawing.Point(18, 142);
            this.LblC.Name = "LblC";
            this.LblC.Size = new System.Drawing.Size(90, 25);
            this.LblC.TabIndex = 7;
            this.LblC.Text = "C PARTİ";
            // 
            // PrgCP
            // 
            this.PrgCP.Location = new System.Drawing.Point(103, 140);
            this.PrgCP.Maximum = 200;
            this.PrgCP.Name = "PrgCP";
            this.PrgCP.Size = new System.Drawing.Size(349, 27);
            this.PrgCP.TabIndex = 6;
            // 
            // LblD
            // 
            this.LblD.AutoSize = true;
            this.LblD.Location = new System.Drawing.Point(18, 175);
            this.LblD.Name = "LblD";
            this.LblD.Size = new System.Drawing.Size(89, 25);
            this.LblD.TabIndex = 9;
            this.LblD.Text = "D PARTİ";
            // 
            // PrgDP
            // 
            this.PrgDP.Location = new System.Drawing.Point(103, 173);
            this.PrgDP.Maximum = 200;
            this.PrgDP.Name = "PrgDP";
            this.PrgDP.Size = new System.Drawing.Size(349, 27);
            this.PrgDP.TabIndex = 8;
            // 
            // LblE
            // 
            this.LblE.AutoSize = true;
            this.LblE.Location = new System.Drawing.Point(18, 208);
            this.LblE.Name = "LblE";
            this.LblE.Size = new System.Drawing.Size(88, 25);
            this.LblE.TabIndex = 11;
            this.LblE.Text = "E PARTİ";
            // 
            // PrgEP
            // 
            this.PrgEP.Location = new System.Drawing.Point(103, 206);
            this.PrgEP.Maximum = 200;
            this.PrgEP.Name = "PrgEP";
            this.PrgEP.Size = new System.Drawing.Size(349, 27);
            this.PrgEP.TabIndex = 10;
            // 
            // LblTa
            // 
            this.LblTa.AutoSize = true;
            this.LblTa.Location = new System.Drawing.Point(458, 76);
            this.LblTa.Name = "LblTa";
            this.LblTa.Size = new System.Drawing.Size(23, 25);
            this.LblTa.TabIndex = 12;
            this.LblTa.Text = "0";
            // 
            // LblTb
            // 
            this.LblTb.AutoSize = true;
            this.LblTb.Location = new System.Drawing.Point(458, 109);
            this.LblTb.Name = "LblTb";
            this.LblTb.Size = new System.Drawing.Size(23, 25);
            this.LblTb.TabIndex = 13;
            this.LblTb.Text = "0";
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Location = new System.Drawing.Point(458, 142);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(23, 25);
            this.LblTc.TabIndex = 14;
            this.LblTc.Text = "0";
            // 
            // LblTd
            // 
            this.LblTd.AutoSize = true;
            this.LblTd.Location = new System.Drawing.Point(458, 175);
            this.LblTd.Name = "LblTd";
            this.LblTd.Size = new System.Drawing.Size(23, 25);
            this.LblTd.TabIndex = 15;
            this.LblTd.Text = "0";
            // 
            // LblTe
            // 
            this.LblTe.AutoSize = true;
            this.LblTe.Location = new System.Drawing.Point(458, 208);
            this.LblTe.Name = "LblTe";
            this.LblTe.Size = new System.Drawing.Size(23, 25);
            this.LblTe.TabIndex = 16;
            this.LblTe.Text = "0";
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(592, 581);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGrafikler";
            this.Text = "VTGS";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar PrgAP;
        private System.Windows.Forms.Label LblD;
        private System.Windows.Forms.ProgressBar PrgDP;
        private System.Windows.Forms.Label LblC;
        private System.Windows.Forms.ProgressBar PrgCP;
        private System.Windows.Forms.Label LblB;
        private System.Windows.Forms.ProgressBar PrgBP;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.Label LblTe;
        private System.Windows.Forms.Label LblTd;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.Label LblTb;
        private System.Windows.Forms.Label LblTa;
        private System.Windows.Forms.Label LblE;
        private System.Windows.Forms.ProgressBar PrgEP;
    }
}