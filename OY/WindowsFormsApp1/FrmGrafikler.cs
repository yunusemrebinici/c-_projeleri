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

namespace WindowsFormsApp1
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        //Data Source=EMRE\SQLEXPRESS01;Initial Catalog=BonusOkul;Integrated Security=True;Encrypt=True;

        SqlConnection bgl = new SqlConnection("Data Source=EMRE\\SQLEXPRESS01;Initial Catalog=DBSECİMPROJE;Integrated Security=True;");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            // ilçe adlarını comboboxa çekme

            bgl.Open();
            SqlCommand cmd = new SqlCommand("select ILCEAD from TBLILCE",bgl);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]); 
            }
            bgl.Close();

            //CHART TABLOSUNA VERİLERİ AKTARMA
            bgl.Open();
            SqlCommand cmd2 = new SqlCommand(" Select SUM(APARTİ),SUM(BPARTİ),SUM(CPARTİ),SUM(DPARTİ),SUM(EPARTİ) FROM TBLILCE", bgl);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A PARTİ", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B PARTİ", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C PARTİ", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D PARTİ", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E PARTİ", dr2[4]);




            }
            bgl.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //COMBODAKİ SEÇİME GÖRE VERİLERİ BARA AKTARMA
            bgl.Open();
            SqlCommand cmd3 = new SqlCommand(" Select * from TBLILCE where ILCEAD=@P1", bgl);
            cmd3.Parameters.AddWithValue("@P1", comboBox1.Text);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                PrgAP.Value = int.Parse(dr3[2].ToString());
                PrgBP.Value = int.Parse(dr3[3].ToString());
                PrgCP.Value = int.Parse(dr3[4].ToString());
                PrgDP.Value = int.Parse(dr3[5].ToString());
                PrgEP.Value = int.Parse(dr3[6].ToString());

                LblTa.Text = dr3[2].ToString();
                LblTb.Text = dr3[3].ToString();
                LblTc.Text = dr3[4].ToString();
                LblTd.Text = dr3[5].ToString();
                LblTe.Text = dr3[6].ToString();

            }
            bgl.Close();

        }
    }
}
