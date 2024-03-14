using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace przychodnia.Service
{
    public class EmailService
    {
        public static void SendNewPasswordEmail(string recipientEmail, string newPassword)
        {
            
            string smtpHost = "live.smtp.mailtrap.io";
            int smtpPort = 587;
            string smtpUsername = " ";
            string smtpPassword = " ";
            string senderEmail = " ";
            string senderName = "Clinc EU";

            using (SmtpClient client = new SmtpClient(smtpHost, smtpPort))
            {
                client.EnableSsl = true; 
                client.Credentials = new NetworkCredential(smtpUsername, smtpPassword);

                using (MailMessage message = new MailMessage())
                {
                    
                    message.From = new MailAddress(senderEmail, senderName);
                    
                    message.To.Add(new MailAddress(recipientEmail));
                    
                    message.Subject = "Twoje nowe hasło w przychodni ";
                    // Treść wiadomości
                    message.Body = $"Twoje nowe hasło to: {newPassword}\nPrzy próbie zalogowania konieczne będzie ustawione nowego hasła dla Twojego konta ;)";

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
