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
    public partial class KitapAlışVeriş : Form
    {
        public KitapAlışVeriş()
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
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("Select * From Kitap_Alışveriş where K_barkod_no like '%" + textEdit9.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("Delete From Kitap_Alışveriş where K_barkod_no=@barkod", con);
            komut.Parameters.AddWithValue("@barkod", textEdit9.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * From Kitap_Alışveriş");
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into eldekikitaplar (barkod,ad)Values(@barkod,@ad)", con);
            cmd.Parameters.AddWithValue("@barkod", textEdit1.Text);
            cmd.Parameters.AddWithValue("@ad", textEdit2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            SqlCommand cmdd = new SqlCommand("Delete from Dışarıdaki_Kitaplar where K_barkod_no=@barkod", con);
            cmdd.Parameters.AddWithValue("@barkod", textEdit9.Text);
            cmdd.ExecuteNonQuery();
            con.Close();
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string id = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string barkod = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string ad = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string yazar_ad = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string tur = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            string yayınevi = dataGridView1.Rows[secilialan].Cells[5].Value.ToString();
            string uyeno = dataGridView1.Rows[secilialan].Cells[6].Value.ToString();
            string adsoyad = dataGridView1.Rows[secilialan].Cells[7].Value.ToString();
            string telefon = dataGridView1.Rows[secilialan].Cells[8].Value.ToString();
            string email = dataGridView1.Rows[secilialan].Cells[9].Value.ToString();
            string verilistarih = dataGridView1.Rows[secilialan].Cells[10].Value.ToString();
            string durum = dataGridView1.Rows[secilialan].Cells[11].Value.ToString();

            textEdit9.Text = id.ToString();
            textEdit1.Text = barkod.ToString();
            textEdit2.Text = ad.ToString();
            textEdit3.Text = yazar_ad.ToString();
            comboBoxEdit1.Text = tur.ToString();
            textEdit4.Text = yayınevi.ToString();
            textEdit5.Text = uyeno.ToString();
            textEdit6.Text = adsoyad.ToString();
            textEdit7.Text = telefon.ToString();
            textEdit8.Text = email.ToString();
            dateEdit1.Text = verilistarih.ToString();
            rdbalındı.PerformClick();

            if (durum == "Teslim Alındı")
            {
                rdbalındı.PerformClick();
            }
            else
            {
                rdbverildi.PerformClick();
            }
        }
        private void simpleButton7_Click(object sender, EventArgs e)
        {
            Menü frm = new Menü();
            frm.Show();
            this.Hide();
        }
        /*string adres="Data Source=CASPERNIRVANA;Initial Catalog=Kutuphane;Integrated Security=True";*/

        private void KitapAlışVeriş_Load(object sender, EventArgs e)
        {
            verilerigoster("Select * From Kitap_Alışveriş");
            /* if (Convert.ToString(dataGridView1.Rows[2].Cells[8].Value).StartsWith("Alındı"))*/
            /*for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Application.DoEvents();
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
               
                if (Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value) > 0)
                {
                    renk.BackColor = Color.Yellow;
                    renk.ForeColor = Color.White;
                }*/
            }
            /*verilerigoster("Select * From Kitap_Alışveriş");
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            if (Convert.ToString(dataGridView1.Rows[sec].Cells[8].Value).StartsWith("Alındı"))
            {
                string id = dataGridView1.Rows[sec].Cells[8].Value.ToString();
                Application.DoEvents();
                DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
                //satir arka plan rengini kosullu olarak degistiriyoruz.
                // 30 dan buyuk olanlar OrangeRed rengini veriyoruz.
                rowColor.BackColor = Color.OrangeRed;
                //yazi rengi beyaz oluyor.
                rowColor.ForeColor = Color.White;
            }*/
        
        private void textEdit6_EditValueChanged(object sender, EventArgs e)
        {
            /*con.Open();
            SqlCommand komut = new SqlCommand("Select * From Kitap_Alışveriş where Id like '%" + textEdit6.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();*/

            /*con.Open();
            SqlCommand cmd2 = new SqlCommand("Select [Kitap_ad],[Kitap_yazar],[Yayın_tarihi] from [Kitaplar] where [Barkod_no]=@baslik", con);
            cmd2.Parameters.AddWithValue("@baslik", textEdit6.Text);
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                textEdit1.Text = dr["Kitap_ad"].ToString();
                textEdit2.Text = dr["Kitap_yazar"].ToString();
                dateEdit3.Text = dr["Yayın_tarihi"].ToString();
            }
            con.Close();*/
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select [Kitap_ad],[Kitap_yazar],[Kitap_tur],[YayınEvi] from [Kitaplar] where [Barkod_no]=@barkod", con);
            cmd2.Parameters.AddWithValue("@barkod", textEdit1.Text);
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                textEdit2.Text = dr["Kitap_ad"].ToString();
                textEdit3.Text = dr["Kitap_yazar"].ToString();
                comboBoxEdit1.Text = dr["Kitap_tur"].ToString();
                textEdit4.Text = dr["YayınEvi"].ToString();
            }
            con.Close();
        }

        private void textEdit10_EditValueChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select [Uye_no],[Telefon],[Email] from Uyeler where [AdSoyad]=@isim", con);
            cmd.Parameters.AddWithValue("@isim", textEdit6.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textEdit5.Text = dr["Uye_no"].ToString();
                textEdit7.Text = dr["Telefon"].ToString();
                textEdit8.Text = dr["Email"].ToString();
            }
            con.Close();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (rdbalındı.Checked == true)
            {
                /*int secili=dataGridView1.SelectedCells[0].RowIndex;*/
                con.Open();
                SqlCommand komut = new SqlCommand("Update Kitap_Alışveriş set K_ad='" + textEdit2.Text + "',Yazar_ad='" + textEdit3.Text + "',Kitap_tur='" + comboBoxEdit1.Text + "',Yayin_evi='" + textEdit4.Text + "',Uye_no='" + textEdit5.Text + "',Uye_ad='" + textEdit6.Text + "',Telefon='" + textEdit7.Text + "',Email='" + textEdit8.Text + "', Durum='" + rdbalındı.Text + "'  where K_barkod_no='" + textEdit1.Text + "'", con);
                komut.ExecuteNonQuery();
                verilerigoster("Select * From Kitap_Alışveriş");
                /*string cinsiyet = "";
            
                    cinsiyet = rdbalındı.Text;*/
            }
            else
                MessageBox.Show("Kitap Alındı ise Alındı'yı İşaretleyiniz");
            con.Close();
            textEdit9.ResetText();
            /*dataGridView1.Rows[secili].DefaultCellStyle.BackColor = Color.Red;*/
            if (rdbalındı.Checked)
            {
                con.Open();
                SqlCommand cmdd = new SqlCommand("Insert into eldekikitaplar(barkod,ad,Tür)Values(@barkodd,@adii,@tur)", con);
                cmdd.Parameters.AddWithValue("@barkodd", textEdit1.Text);
                cmdd.Parameters.AddWithValue("@adii", textEdit2.Text);
                cmdd.Parameters.AddWithValue("@tur", comboBoxEdit1.Text);
                cmdd.ExecuteNonQuery();
                con.Close();
                con.Open();
                SqlCommand cm = new SqlCommand("Delete From Dışarıdaki_Kitaplar where barkod=@barkot", con);
                cm.Parameters.AddWithValue("@barkot", textEdit1.Text);
                cm.ExecuteNonQuery();
                con.Close();
            }
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            string barkodno = textEdit1.Text;
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * From Kitaplar where Barkod_no='" + textEdit1.Text + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                con.Open();
                SqlCommand komut = new SqlCommand("Insert into Kitap_Alışveriş (K_barkod_no,K_ad,Yazar_ad,Kitap_tur,Yayin_evi,Uye_no,Uye_ad,Telefon,Email,Kitap_ver_tarih,Durum)Values(@barkod,@kitap_ad,@kitap_yazar,@tur,@ev,@no,@uye_ad,@gsm,@eposta,@vertarih,@durum)", con);
                komut.Parameters.AddWithValue("@barkod", textEdit1.Text);
                komut.Parameters.AddWithValue("@kitap_ad", textEdit2.Text);
                komut.Parameters.AddWithValue("@kitap_yazar", textEdit3.Text);
                komut.Parameters.AddWithValue("@tur", comboBoxEdit1.Text);
                komut.Parameters.AddWithValue("@ev", textEdit4.Text);
                komut.Parameters.AddWithValue("@no", textEdit5.Text);
                komut.Parameters.AddWithValue("@uye_ad", textEdit6.Text);
                komut.Parameters.AddWithValue("@gsm", textEdit7.Text);
                komut.Parameters.AddWithValue("@eposta", textEdit8.Text);
                komut.Parameters.AddWithValue("@vertarih", dateEdit1.Text);
                komut.Parameters.AddWithValue("durum", rdbverildi.Text);
                komut.ExecuteNonQuery();
                verilerigoster("Select * From Kitap_Alışveriş");
                SqlCommand cmd1 = new SqlCommand("Insert into Dışarıdaki_Kitaplar(barkod,ad,Tür)Values(@barkodd,@adi,@tur)", con);
                cmd1.Parameters.AddWithValue("@barkodd", textEdit1.Text);
                cmd1.Parameters.AddWithValue("@adi", textEdit2.Text);
                cmd1.Parameters.AddWithValue("@tur", comboBoxEdit1.Text);
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("Delete From eldekikitaplar where barkod=@barkot", con);
                cmd2.Parameters.AddWithValue("@barkot", textEdit1.Text);
                cmd2.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Kitap Barkod No Bulunamadı!");
            }
            con.Close();
            textEdit1.ResetText();
            textEdit2.ResetText();
            textEdit3.ResetText();
            textEdit4.ResetText();
            textEdit5.ResetText();
            textEdit6.ResetText();
            textEdit7.ResetText();
            textEdit8.ResetText();
            dateEdit1.ResetText();
            comboBoxEdit1.ResetText();
            
        }
        private void simpleButton9_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * From Kitap_Alışveriş");
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("Delete From Kitap_Alışveriş where K_barkod_no=@barkod", con);
            komut.Parameters.AddWithValue("@barkod", textEdit1.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * From Kitap_Alışveriş");
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into eldekikitaplar (barkod,ad)Values(@barkod,@ad)", con);
            cmd.Parameters.AddWithValue("@barkod", textEdit1.Text);
            cmd.Parameters.AddWithValue("@ad", textEdit2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            SqlCommand cmdd = new SqlCommand("Delete from Dışarıdaki_Kitaplar where Barkod=@barkod", con);
            cmdd.Parameters.AddWithValue("@barkod", textEdit1.Text);
            cmdd.ExecuteNonQuery();
            con.Close();
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("Select * From Kitap_Alışveriş where K_barkod_no like '%" + textEdit9.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
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