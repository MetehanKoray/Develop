using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DevExpress
{
    public partial class Mevcut_Kitaplar : Form
    {
        public Mevcut_Kitaplar()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=CASPERNIRVANA;Initial Catalog=Kutuphane;Integrated Security=True");
        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        public void verilerigoster2(string veri)
        {
            SqlDataAdapter da = new SqlDataAdapter(veri,con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }
        private void Mevcut_Kitaplar_Load(object sender, EventArgs e)
        {
            chart2.BackImage = "";
            /*int kitapsayisi;
            kitapsayisi = dataGridView1.Rows.Count;
            MessageBox.Show(kitapsayisi.ToString());*/
            /* dataGridView1. = dataGridView1.RowCount - 1;*/
            /*dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;*/
            /*dataGridView1[0, dataGridView1.RowCount - 2].Selected = true;
            label1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();*/
            verilerigoster("Select * From eldekikitaplar");
            verilerigoster2("Select * From Dışarıdaki_Kitaplar");
            int mevcut;
            SqlCommand cmd = new SqlCommand("select count(*) from eldekikitaplar", con);
            con.Open();
            mevcut = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            chart2.Series["Mevcut Kitaplar"].Points.AddY(mevcut);


            int disari;
            SqlCommand cmnd = new SqlCommand("select count(*) from Dışarıdaki_Kitaplar", con);
            con.Open();
            disari = Convert.ToInt32(cmnd.ExecuteScalar());
            con.Close();
            chart2.Series["Dışarıdaki Kitaplar"].Points.AddY(disari);
            /*MessageBox.Show(kayitsayisi.ToString());*/
            /*chart1.Series["Dışarıdaki Kitaplar"].Points.AddY(kayitsayisi);*/
            /*chart1.Series["Mevcut Kitaplar"].Points[0].AxisLabel = kayitsayisi.ToString();*/
            /*chart2.Series["Dışarıdaki Kitaplar"].Points.AddY(15);*/
        }
        private void simpleButton7_Click_1(object sender, EventArgs e)
        {
            Menü frm = new Menü();
            frm.Show();
            this.Hide();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            int asadsa;
            asadsa = Convert.ToInt32(5);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand conn = new SqlCommand("Delete from eldekikitaplar",con);
            conn.ExecuteNonQuery();
            verilerigoster("Select * From eldekikitaplar");
            con.Close();
            con.Open();
            SqlCommand connn = new SqlCommand("Delete from Dışarıdaki_Kitaplar", con);
            connn.ExecuteNonQuery();
            verilerigoster2("select  * from  Dışarıdaki_Kitaplar");
            con.Close();
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
