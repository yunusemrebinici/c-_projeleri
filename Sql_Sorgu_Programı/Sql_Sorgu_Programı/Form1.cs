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

namespace Sql_Sorgu_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Data Source=EMRE\SQLEXPRESS01;Initial Catalog=Proje6;Integrated Security=True;Encrypt=False

        SqlConnection bgl=new SqlConnection("Data Source=EMRE\\SQLEXPRESS01;Initial Catalog=DbNotKayıt;Integrated Security=True;");
        private void BtnCalistir_Click(object sender, EventArgs e)
        {
            string komut = richTextBox1.Text;

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(komut, bgl);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Yanlış Komut Girdiniz");
            }
           
           
        }

        private void BtnCrud_Click(object sender, EventArgs e)
        {
            string komut2 = richTextBox1.Text;

            try
            {
                bgl.Open();
                SqlCommand cmd = new SqlCommand(komut2, bgl);
                cmd.ExecuteNonQuery();
                bgl.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Yanlış Komut Girdiniz");
            }
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from TBLDERS", bgl);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
