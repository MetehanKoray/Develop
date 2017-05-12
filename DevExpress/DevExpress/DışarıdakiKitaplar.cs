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
    public partial class DışarıdakiKitaplar : Form
    {
        public DışarıdakiKitaplar()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=CASPERNIRVANA;Initial Catalog=Kutuphane;Integrated Security=True");
        public void verilerigoster(string veriler)
    {
        SqlDataAdapter da = new SqlDataAdapter(veriler,con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        dataGridView1.DataSource = ds.Tables[0];
    }
        private void DışarıdakiKitaplar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneDataSet4.v1' table. You can move, or remove it, as needed.
            this.v1TableAdapter.Fill(this.kutuphaneDataSet4.v1);
            // TODO: This line of code loads data into the 'kutuphaneDataSet3.Mevcut' table. You can move, or remove it, as needed.
            this.mevcutTableAdapter.Fill(this.kutuphaneDataSet3.Mevcut);
            verilerigoster("Select * From v1");
        }
        private void simpleButton7_Click(object sender, EventArgs e)
        {
            Menü frm = new Menü();
            frm.Show();
            this.Hide();
        }
    }
}
