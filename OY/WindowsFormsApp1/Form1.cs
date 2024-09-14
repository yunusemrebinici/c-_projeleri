using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=EMRE\\SQLEXPRESS01;Initial Catalog=DBSECİMPROJE;Integrated Security=True;");

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnOyGiris_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand(" insert into TBLILCE (ILCEAD,APARTİ,BPARTİ,CPARTİ,DPARTİ,EPARTİ) values (@P1,@P2,@P3,@P4,@P5,@P6)",bgl);
            cmd.Parameters.AddWithValue("@P1",Txtİlce.Text);
            cmd.Parameters.AddWithValue("@P2",TxtAp.Text);
            cmd.Parameters.AddWithValue("@P3",TxtBp.Text);
            cmd.Parameters.AddWithValue("@P4",TxtCp.Text);
            cmd.Parameters.AddWithValue("@P5",TxtDp.Text);
            cmd.Parameters.AddWithValue("@P6",TxtEp.Text);
            cmd.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Kayıt Yapıldı");
        }

        private void BtnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr =new FrmGrafikler();
            fr.Show();
        }
    }
}
