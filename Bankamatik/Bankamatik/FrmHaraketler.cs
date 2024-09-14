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

namespace Bankamatik
{
    public partial class FrmHaraketler : Form
    {
        public FrmHaraketler()
        {
            InitializeComponent();
        }
       public string ghesap;
       public string ahesap;
        SqlConnection bgl = new SqlConnection("Data Source=EMRE\\SQLEXPRESS01;Initial Catalog=DbBanka;Integrated Security=True;");
        private void FrmHaraketler_Load(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand sqlCommand = new SqlCommand("execute haraket3",bgl);
            sqlCommand.Parameters.AddWithValue("@GonderenHesapNo",ghesap );
            sqlCommand.Parameters.AddWithValue("@AliciHesapNo", ahesap);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            bgl.Close();






            //SqlDataAdapter da= new SqlDataAdapter("Execute haraket",bgl);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
        }
    }
}
