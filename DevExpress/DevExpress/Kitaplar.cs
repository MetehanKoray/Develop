using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excell = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace DevExpress
{
    public partial class Kitaplar : Form
    {
        public Kitaplar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=CASPERNIRVANA;Initial Catalog=Kutuphane;Integrated Security=True");
        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            simpleButton2.BackColor = Color.Red;
            verilerigoster("Select * From Kitaplar ");
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {


            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select [Barkod_no] From Kitaplar where Barkod_no=@barkod ",baglanti);
            cmd.Parameters.AddWithValue("@barkod",textEdit1.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Barkod Numarası Zaten Kayıtlı.");
            }
            else
            {
                baglanti.Close();
                baglanti.Open();

                cmd= new SqlCommand("Insert into Kitaplar(Barkod_no,Kitap_ad,Kitap_yazar,YayınEvi,Yayın_tarihi,Kitap_tur,Temin_tarih) values (@barkod,@ad,@yazar,@yayınev,@tarih,@tur,@temintarih)", baglanti);
                cmd.Parameters.AddWithValue("@barkod", textEdit1.Text);
                cmd.Parameters.AddWithValue("@ad", textEdit2.Text);
                cmd.Parameters.AddWithValue("@yazar", textEdit3.Text);
                cmd.Parameters.AddWithValue("@yayınev", textEdit5.Text);
                cmd.Parameters.AddWithValue("@tarih", dateEdit1.Text);
                cmd.Parameters.AddWithValue("@tur", comboBoxEdit1.Text);
                cmd.Parameters.AddWithValue("@temintarih", dateEdit2.Text);
                cmd.ExecuteNonQuery();
                verilerigoster("Select * From Kitaplar");
                cmd = new SqlCommand("Insert into eldekikitaplar(barkod,ad,Tür)Values(@barkod,@isim,@tur)", baglanti);
                SqlParameter id = new SqlParameter("@ide", SqlDbType.Int);
                cmd.Parameters.AddWithValue("@barkod", textEdit1.Text);
                cmd.Parameters.AddWithValue("@isim", textEdit2.Text);
                cmd.Parameters.AddWithValue("@tur", comboBoxEdit1.Text);
                cmd.ExecuteNonQuery();
                textEdit1.ResetText();
                textEdit2.ResetText();
                textEdit3.ResetText();
                textEdit4.ResetText();
                textEdit5.ResetText();
                dateEdit1.ResetText();
                comboBoxEdit1.ResetText();
                dateEdit2.ResetText();
            }
            baglanti.Close();  
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Kitaplar where Id=@ide", baglanti);
            komut.Parameters.AddWithValue("@ide", textEdit4.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select *From Kitaplar");
            baglanti.Close();
            textEdit1.Reset(); 
        }
        private void Kitaplar_Load(object sender, EventArgs e)
        {
            verilerigoster("Select * From Kitaplar ");
        }
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Kitaplar where Id Like'%" + textEdit4.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
            textEdit1.Reset();
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Kitaplar set  Barkod_no='" + textEdit1.Text + "',Kitap_ad='" + textEdit2.Text + "',Kitap_yazar='" + textEdit3.Text + "',YayınEvi='"+textEdit5.Text+"',Yayın_tarihi='" + dateEdit1.Text + "',Kitap_tur='" + comboBoxEdit1.Text + "',Temin_tarih='" + dateEdit2.Text + "' where Id='" + textEdit4.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            verilerigoster("Select * From Kitaplar");
            SqlCommand cmd = new SqlCommand("Update eldekikitaplar set Barkod='" + textEdit1.Text + "',Ad='" + textEdit2.Text + "',Tür='" + comboBoxEdit1.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            textEdit1.ResetText();
            textEdit2.ResetText();
            textEdit3.ResetText();
            textEdit4.ResetText();
            textEdit5.ResetText();
            dateEdit1.ResetText();
            comboBoxEdit1.ResetText();
            dateEdit2.ResetText();
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string id = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string barkod = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string ad = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string yazar = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string yayınevi = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            string tarih = dataGridView1.Rows[secilialan].Cells[5].Value.ToString();
            string tur = dataGridView1.Rows[secilialan].Cells[6].Value.ToString();
            string ttarih = dataGridView1.Rows[secilialan].Cells[7].Value.ToString();
            textEdit4.Text = id;
            textEdit1.Text = barkod;
            textEdit2.Text = ad;
            textEdit3.Text = yazar;
            textEdit5.Text = yayınevi;
            dateEdit1.Text = tarih;
            comboBoxEdit1.Text = tur;
            dateEdit2.Text = ttarih;
        }
        private void simpleButton7_Click(object sender, EventArgs e)
        {
            Menü frm = new Menü();
            frm.Show();
            this.Hide();
        }
        private void simpleButton8_Click(object sender, EventArgs e)
        {
            Excell.Application excelldosya = new Excell.Application();
            excelldosya.Visible = true;
            object Missing = Type.Missing;
            Workbook calismakitabi = excelldosya.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)calismakitabi.Sheets[1];
            int sutun = 1;
            int satir = 1;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Range myrange = (Range)sheet1.Cells[satir, sutun + j];
                myrange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            satir++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Range myrange = (Range)sheet1.Cells[satir + i, sutun + j];
                    myrange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myrange.Select();
                }
            }
        }
    }
}
