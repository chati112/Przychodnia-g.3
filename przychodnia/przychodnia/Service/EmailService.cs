using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace przychodnia.Service
{
    internal class EmailService
    {
        public static void SendNewPasswordEmail(string recipientEmail, string newPassword)
        {
            string smtpHost = "smtp.gmail.com"; // Adres serwera SMTP
            int smtpPort = 587; // Port serwera SMTP 
            string smtpUsername = "Przychodnia2137@gmail.com"; //  e-mail
            string smtpPassword = "SuperAdmin2137"; // Hasło do  e-mail

            using (SmtpClient client = new SmtpClient(smtpHost, smtpPort))
            {
                client.EnableSsl = true; // Włączenie SSL
                client.Credentials = new NetworkCredential(smtpUsername, smtpPassword);

                using (MailMessage message = new MailMessage(smtpUsername, recipientEmail))
                {
                    message.Subject = "Twoje nowe hasło";
                    message.Body = $"Twoje nowe hasło to: {newPassword}\nZalecamy zmianę hasła po zalogowaniu.";

                    try
                    {
                        client.Send(message);
                        Console.WriteLine("E-mail z nowym hasłem został wysłany.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Wystąpił błąd podczas wysyłania e-maila: {ex.Message}");
                    }
                }
            }
        }
    }
}
