using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Döviz_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya=new XmlDocument();
            xmldosya.Load(bugun);

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            LblDolarA.Text= dolaralis;
            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            LblDolarS.Text= dolarsatis;

            string ealis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            LblEuroA.Text= ealis;
            string esatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            LblEuroS.Text = esatis;
        }

        private void BtnDa_Click(object sender, EventArgs e)
        {
            TxtKur.Text = LblDolarA.Text;
        }

        private void BtnDs_Click(object sender, EventArgs e)
        {
            TxtKur.Text = LblDolarS.Text;
        }

        private void BtnEa_Click(object sender, EventArgs e)
        {
            TxtKur.Text = LblEuroA.Text;
        }

        private void BtnEs_Click(object sender, EventArgs e)
        {
            TxtKur.Text = LblEuroA.Text;

        }

        private void TxtKur_TextChanged(object sender, EventArgs e)
        {
            TxtKur.Text=TxtKur.Text.Replace(".",",");
        }

        private void Btnİslem1_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur=Convert.ToDouble(TxtKur.Text);
            miktar=Convert.ToDouble(TxtMiktar.Text);
            tutar =kur*miktar;
            TxtTutar.Text=tutar.ToString();

        }

        private void Btnİslem2_Click(object sender, EventArgs e)
        {
            double kur=Convert.ToDouble(TxtKur.Text);
            int miktar = Convert.ToInt32(TxtMiktar.Text);
            int tutar =Convert.ToInt32(miktar/kur);
            TxtTutar.Text=tutar.ToString();
            double kalan =miktar % kur;  
            TxtKalan.Text=kalan.ToString();
        }
    }
}
