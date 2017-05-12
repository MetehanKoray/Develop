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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private void GirisYap_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.kuladi = textEdit1.Text;
                Properties.Settings.Default.sifre = textEdit2.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.kuladi = null;
                Properties.Settings.Default.sifre = null;
                Properties.Settings.Default.Save();
            }
            string ad = textEdit1.Text;
            string sifre = textEdit2.Text;
           
            con = new SqlConnection("Data Source=CASPERNIRVANA;Initial Catalog=Kutuphane;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * From Kullanıcı_Giris where k_ad='" + textEdit1.Text + "' AND k_sifre='" + textEdit2.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Menü frm = new Menü();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifreyi Hatalı Girdiniz");
            }
            con.Close();

        }
        private void GirisYap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string ad = textEdit1.Text;
                string sifre = textEdit2.Text;
                con = new SqlConnection("Data Source=CASPERNIRVANA;Initial Catalog=Kutuphane;Integrated Security=True");
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Select * From Kullanıcı_Giris where k_ad='" + textEdit1.Text + "' AND k_sifre='" + textEdit2.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Kitaplar frm = new Kitaplar();
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifreyi Hatalı Girdiniz");
                }
                con.Close();
            }
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            textEdit2.Properties.PasswordChar = '*';
            textEdit1.Text = Properties.Settings.Default.kuladi;
            textEdit2.Text = Properties.Settings.Default.sifre;
            if (textEdit1.Text.Count() > 1)
                checkBox1.Checked = true;
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SifrenimiUnuttun frm = new SifrenimiUnuttun();
                frm.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeKayit frm = new UyeKayit();
            frm.Show();
            this.Hide();
        }
    }
}

