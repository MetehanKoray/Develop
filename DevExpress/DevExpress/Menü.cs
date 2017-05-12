using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevExpress
{
    public partial class Menü : Form
    {
        public Menü()
        {
            InitializeComponent();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Uyeler frm = new Uyeler();
            frm.Show();
            this.Hide();
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Kitaplar frm = new Kitaplar();
            frm.Show();
            this.Hide();
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            KitapAlışVeriş frm = new KitapAlışVeriş();
            frm.Show();
            this.Hide();
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Mevcut_Kitaplar frm = new Mevcut_Kitaplar();
            frm.Show();
            this.Hide();
            
        }
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Rapor frm = new Rapor();
            frm.Show();
            this.Hide();
        }
    }
}
