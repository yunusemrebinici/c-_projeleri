using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resi_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string resim;
        Color renk;
        private void BtnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resim= openFileDialog1.FileName;
        }

        private void BtnRenkSec_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }
        Bitmap bmp;
        private void BtnYazdır_Click(object sender, EventArgs e)
        {
           
            try
            {
            bmp = new Bitmap(resim);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.DrawString(TxtMetin.Text,new Font("Segoe UI", Convert.ToInt16(TxtBoyut.Text),FontStyle.Bold),new SolidBrush(renk),20,30);
            pictureBox1.Image=bmp;
            }
            catch (Exception)
            {
                MessageBox.Show("Değerler Boş Geçilemez");
                
            }
           
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Resim|.jpg";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName!="")
                {
                  bmp.Save(saveFileDialog1.FileName);
                }
               
            }
            catch (Exception)
            {

                
            }
          
        }
    }
}
