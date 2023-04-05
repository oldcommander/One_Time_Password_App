using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneTimePassword
{
    public partial class Form1 : Form
    {
        static public string user = "ahmetcekin2000@gmail.com";
        string password = "12345";
        static public string kod2 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kod="";
            if (txt_user.Text=="" || txt_password.Text=="")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                if (txt_user.Text == user && txt_password.Text == password)
                {
                    Random rnd = new Random();
                    for (int i = 0; i < 6; i++)
                    {
                        kod = kod + rnd.Next(0, 10).ToString();
                    }

                    kod2 = kod;
                   
                    string adres = Mailislem.mailAdresi.ToString();
                    string sifre = Mailislem.mailParola.ToString();

                    SmtpClient sc = new SmtpClient();
                    sc.Port = 587;
                    sc.Host = "smtp.gmail.com";
                    sc.EnableSsl = true;
                    sc.Credentials = new NetworkCredential( adres, sifre);

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(adres , "---GİRİŞ---");
                    mail.To.Add(user);
                    mail.IsBodyHtml = true;
                    mail.Body = "Tek kullanımlık kodunuz: " + kod + " Lütfen Kimseyle Paylaşmayınız.";
                    mail.Subject = " Giriş ";
                    sc.Send(mail);

                    passwordCheck pswc = new passwordCheck();
                    this.Hide();
                    pswc.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya parola hatalı", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
