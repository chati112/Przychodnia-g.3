using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przychodnia.Service
{
    public partial class FormTEstowyDoMaili : Form
    {

        private readonly string senderEmail = "essa@ellstore.pl";
        private readonly string senderName = "Clinc EU";
        private readonly string smtpServer = "live.smtp.mailtrap.io";
        private readonly int smtpPort = 587;
        private readonly string smtpUsername = "api";
        private readonly string smtpPassword = "05d7f33be25b41fdd0adbf9e71cde811";


        public FormTEstowyDoMaili()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void SendTestEmail(string recipientEmail)
        {
            using (SmtpClient client = new SmtpClient(smtpServer, smtpPort))
            {
                client.EnableSsl = true; // W zależności od dostawcy SMTP wartość ta może być 'true' lub 'false'
                client.Credentials = new NetworkCredential(smtpUsername, smtpPassword);

                using (MailMessage message = new MailMessage())
                {
                    message.From = new MailAddress(senderEmail, senderName);
                    message.To.Add(new MailAddress(recipientEmail));
                    message.Subject = "Test SMTP - Clinc EU";
                    message.Body = "To jest testowe wiadomości SMTP od Clinc EU. Jeśli to czytasz, SMTP działa poprawnie.";

                    try
                    {
                        client.Send(message);
                        MessageBox.Show("E-mail testowy został wysłany.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił błąd podczas wysyłania e-maila: {ex.Message}");
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SendTestEmail(textBox1.Text); // Załóżmy, że textBoxEmail jest kontrolką TextBox na formularzu
        }
    }
}
