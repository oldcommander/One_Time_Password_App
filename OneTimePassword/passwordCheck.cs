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
    public partial class passwordCheck : Form
    {
        int sayac = 60;
        string kod;
        public passwordCheck()
        {
            InitializeComponent();
        }

        private void passwordCheck_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.user.ToString();
            gunaLabel2.Text = "60";
            this.timer1.Interval = 1200;
            this.timer1.Start();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sayac--;
            gunaLabel2.Text = sayac.ToString();
            if (sayac==0)
            {
                this.timer1.Stop();
            }
        }

        private void btn_yenikodAl_Click(object sender, EventArgs e)
        {
            if (sayac!=0)
            {
                MessageBox.Show("Süreniz dolmadan yeni kod alamazsınız. Lütfen sürenizin dolmasınını bekleyin", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Random rnd = new Random();
                for (int i = 0; i < 6; i++)
                {
                    kod = kod + rnd.Next(0, 10).ToString();
                }

                txt_kod.Text = "";
                OneTimePassword.Form1.kod2 = kod;

                string adres = Mailislem.mailAdresi.ToString();
                string sifre = Mailislem.mailParola.ToString();

                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;
                sc.Credentials = new NetworkCredential(adres, sifre);

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(adres, "---GİRİŞ---");
                mail.To.Add(OneTimePassword.Form1.user);
                mail.IsBodyHtml = true;
                mail.Body = "Tek kullanımlık kodunuz: " + kod + " Lütfen Kimseyle Paylaşmayınız.";
                mail.Subject = " Giriş ";
                sc.Send(mail);
                MessageBox.Show("Tek kullanımlık kodunuz mail hesabınıza gönderilmiştir. Lütfen mail hesabınızı kontrol ediniz.", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sayac = 60;
                timer1_Tick(kod,e);
                passwordCheck_Load(kod, e);
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            sonuc snc = new sonuc();
            string dogrula = OneTimePassword.Form1.kod2.ToString();

            if (sayac == 0)
            {
                MessageBox.Show("Süreniz Dolduğu İçin Kodunuz Geçersiz Sayılmıştır. Lütfen Yeni Kod Alınız.", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (txt_kod.Text == "")
                {
                    MessageBox.Show("Lütfen gerekli alanı doldurun.", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (dogrula == txt_kod.Text)
                {
                    this.Hide();
                    snc.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı Kod Girdiniz. Lütfen Bilgilerinizi Kontrol edin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }
}
