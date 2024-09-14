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
using Microsoft.SqlServer.Server;

namespace MESAJ
{
    public partial class FrmMesaj : Form
    {
        public FrmMesaj()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=EMRE\\SQLEXPRESS01;Initial Catalog=MESAJ;Integrated Security=True;");

        public string ad;
        public int kullanıcıadı;       
        public int sifre;

        void listele() 
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("Select * FROM KISILER",bgl);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            CmbAlıcı.DisplayMember = "AD" ;
            CmbAlıcı.ValueMember = "NUMARA";
            CmbAlıcı.DataSource=dt;
            bgl.Close();    
        }


        void gidenkutusu() 
        {
            SqlCommand cmd2 = new SqlCommand("select  AD +' '+ SOYAD as 'KİME' ,BASLIK,ICERIK   from MESAJLAR inner join KISILER ON MESAJLAR.ALAN=KISILER.NUMARA WHERE GONDEREN IN (@P1)",bgl);
            cmd2.Parameters.AddWithValue("@P1",kullanıcıadı);
            SqlDataAdapter da2= new SqlDataAdapter(cmd2);
            DataTable dt2=new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

        }

        void gelenkutusu()
        {   
           
            SqlCommand cmd = new SqlCommand("select AD +' '+SOYAD as 'Gönderen' , MESAJLAR.BASLIK,MESAJLAR.ICERIK from MESAJLAR inner join KISILER on GONDEREN=KISILER.NUMARA where ALAN="+kullanıcıadı , bgl);                  
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmMesaj_Load(object sender, EventArgs e)
        {
            label1.Text= ad;
            gelenkutusu();
            gidenkutusu();
            label12.Text=kullanıcıadı.ToString();
            listele();
            label4.Text = CmbAlıcı.SelectedValue.ToString();

        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand KOMUT = new SqlCommand("INSERT INTO MESAJLAR (GONDEREN,ALAN,BASLIK,ICERIK) VALUES (@P1,@P2,@P3,@P4)",bgl);
            KOMUT.Parameters.AddWithValue("@P1",kullanıcıadı);
            KOMUT.Parameters.AddWithValue("@P2",CmbAlıcı.SelectedValue);
            KOMUT.Parameters.AddWithValue("@P3",TxtBaslik.Text);
            KOMUT.Parameters.AddWithValue("@P4",TxtMesaj.Text);
            KOMUT.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Mesaj Gönderildi");
            gidenkutusu();

        }
    }
}
