using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace DevExpress
{
    public partial class Defter : Form
    {
        public Defter()
        {
            InitializeComponent();
        }

        private void btnmail_Click(object sender, EventArgs e)
        {
            MailMessage mesajim = new MailMessage();

            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("m.koray41@hotmail.com", "Mete@0532250_");
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            mesajim.To.Add(textBox1.Text);
            mesajim.From = new MailAddress("m.koray41@hotmail.com");
            textBox2.Text =  mesajim.Subject;
            mesajim.Body = textBox3.Text;
            istemci.Send(mesajim);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
