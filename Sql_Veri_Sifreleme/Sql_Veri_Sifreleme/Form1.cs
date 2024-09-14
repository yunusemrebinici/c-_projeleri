using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Sql_Veri_Sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=EMRE\\SQLEXPRESS01;Initial Catalog=TEST;Integrated Security=True;");
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            

           
            string ad=TxtAd.Text;
            byte [] addizi=ASCIIEncoding.ASCII.GetBytes(ad);
            string adsifre=Convert.ToBase64String(addizi);

            string soyad = TxtSoyAd.Text;
            byte[] soyadDizi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string Soysifre = Convert.ToBase64String(soyadDizi);

            string sifre = TxtSifre.Text;
            byte[] Sifredizi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string Ssifre = Convert.ToBase64String(Sifredizi);

            string mail = TxtMail.Text;
            byte[] Maildizi = ASCIIEncoding.ASCII.GetBytes(mail);
            string Smail = Convert.ToBase64String(Maildizi);

            bgl.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBLTEST (AD,SOYAD,SIFRE,MAIL) values (@p1,@p2,@p3,@p4)", bgl);
            cmd.Parameters.AddWithValue("@p1",adsifre);
            cmd.Parameters.AddWithValue("@p2",Soysifre);
            cmd.Parameters.AddWithValue("@p3",Ssifre);
            cmd.Parameters.AddWithValue("@p4",Smail);
            cmd.ExecuteNonQuery();
            bgl.Close();
            listele();
            LblTest.Text = Smail;
        }
        void listele() 
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLTEST", bgl);                      
            DataTable dt =new DataTable();                       
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void Listele() 
        {
            SqlDataAdapter da = new SqlDataAdapter("Select AD,SOYAD,MAIL,SIFRE from TBLTEST",bgl);
            DataSet ds = new DataSet();
            da.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                row["AD"] = coz(row["AD"] as string);
                row["SOYAD"] = coz(row["SOYAD"] as string);
                row["MAIL"] = coz(row["MAIL"] as string);
                row["SIFRE"] = coz(row["SIFRE"] as string);
            }
            dataGridView1.DataSource = ds.Tables[0];
        }
        private object coz(string v1) 
        {
            byte[] cozumdizi = Convert.FromBase64String(v1);
            string adverisi=ASCIIEncoding.ASCII.GetString(cozumdizi);
            return adverisi;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            LblTest.Visible = false;

		}

        private void BtnCoz_Click(object sender, EventArgs e)
        {
        //    string ad=TxtAd.Text;
        //    byte[] adcozumdizi=Convert.FromBase64String(ad);
        //    string adverisi=ASCIIEncoding.ASCII.GetString(adcozumdizi);
        //    LblTest.Text= adverisi;

            Listele();
        }
    }
}
