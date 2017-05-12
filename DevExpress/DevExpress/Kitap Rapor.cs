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
    public partial class KitapRapor : Form
    {
        public KitapRapor()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=CASPERNIRVANA;Initial Catalog=Kutuphane;Integrated Security=True");
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Kitap_Alışveriş where K_ad like '" + textEdit1.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Menü frm = new Menü();
            frm.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Kitap_Alışveriş where K_ad like '" + textEdit1.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
