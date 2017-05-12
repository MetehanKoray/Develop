﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Base;

namespace DevExpress
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            kullanıcı_GirisTableAdapter1.Fill(kutuphaneDataSet11.Kullanıcı_Giris);
        }
        SqlConnection baglanti = new SqlConnection("Data Source=CASPERNIRVANA;Initial Catalog=Kutuphane;Integrated Security=True");
        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            gridControl1.DataSource = ds.Tables[0];
        }
       /* private void simpleButton1_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * From Kullanıcı_Giris ");
        }*/
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into Kullanıcı_Giris (k_ad,k_sifre)values (@adi,@sifrei)", baglanti);
            SqlParameter personId = new SqlParameter("@ide", SqlDbType.Int);
            komut.Parameters.AddWithValue("@adi", textEdit1.Text);
            komut.Parameters.AddWithValue("@sifrei", textEdit2.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * From Kullanıcı_Giris");
            baglanti.Close();
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Kullanıcı_Giris where k_id=@ide", baglanti);
            komut.Parameters.AddWithValue("@ide", textEdit1.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select *From Kullanıcı_Giris");
            baglanti.Close();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneDataSet10.Kitaplar' table. You can move, or remove it, as needed.
            this.kitaplarTableAdapter.Fill(this.kutuphaneDataSet10.Kitaplar);


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * From Kitaplar ");
           /* try
            {
 
                for (int i = 0; i < Datagridview1.Rows.Count; i++)
                {
                    Application.DoEvents();
 
                    DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
 
                    //puan sutunundaki degere göre satir rengi degistiriyoruz.
                    if (Convert.ToInt32(Datagridview1.Rows[i].Cells[3].Value)> 30)
                    {
                        //satir arka plan rengini kosullu olarak degistiriyoruz.
                        // 30 dan buyuk olanlar OrangeRed rengini veriyoruz.
                        rowColor.BackColor = Color.OrangeRed;
                        //yazi rengi beyaz oluyor.
                        rowColor.ForeColor = Color.White;
                    }
                    else if (Convert.ToInt32(Datagridview1.Rows[i].Cells[3].Value)> 0 && Convert.ToInt32(Datagridview1.Rows[i].Cells[3].Value) < 30)
                    {
                        rowColor.BackColor = Color.Blue;
                        rowColor.ForeColor = Color.White;
                    }
                    else if (Convert.ToInt32(Datagridview1.Rows[i].Cells[3].Value)== 0)
                    {
                        rowColor.BackColor = Color.LightGreen;
                        rowColor.ForeColor = Color.White;
                    }
 
                    //satir rengini degistiriyoruz.

Datagridview1.Rows[i].DefaultCellStyle = rowColor;
                }
 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex);
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string k_ad; 
            int sifre;
            k_ad = Convert.ToString(textBox1.Text);
            sifre = Convert.ToInt32(textBox2.Text);

            if (k_ad=="Mete" || sifre==1234)
            {
                MessageBox.Show("Hoşgeldiniz");
            }
            else if (true)
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * From Kitaplar");
        }
    }
}
