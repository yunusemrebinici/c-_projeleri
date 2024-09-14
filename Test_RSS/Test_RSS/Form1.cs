using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Test_RSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         void rss(string v1) 
        {
            listBox1.Items.Clear();
            XmlTextReader reader = new XmlTextReader(v1);

            while (reader.Read())
            {
                if (reader.Name == "title")
                {
                    listBox1.Items.Add(reader.ReadString());
                }
            }
        }
        string rss2(string link)
        {
            listBox1.Items.Clear();
            XmlTextReader xmloku = new XmlTextReader(link);
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
            return link;
            
        }
        string h1, h2, h3;
        private void button1_Click(object sender, EventArgs e)
        {
            h1 = "https://www.milliyet.com.tr/rss/rssnew/dunyarss.xml";
            rss(h1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            h2 = "https://feeds.bbci.co.uk/turkce/rss.xml";
            rss2(h2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
        

            listBox1.Items.Clear();
            XmlTextReader reader = new XmlTextReader("https://www.ntv.com.tr/sanat.rss");

            while (reader.Read())
            {
                if (reader.Name == "title")
                {
                    listBox1.Items.Add(reader.ReadString());
                }
            }
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
