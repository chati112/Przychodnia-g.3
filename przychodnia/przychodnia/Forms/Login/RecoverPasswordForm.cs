using przychodnia.Helpers;
using przychodnia.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przychodnia.Forms.Login
{
    public partial class RecoverPasswordForm : Form
    {
        public RecoverPasswordForm()
        {
            InitializeComponent();
        }

        //private void buttonSendRequest_Click(object sender, EventArgs e)
        //{
        //    string userId = textBoxUserId.Text;
        //    string email = textBoxEmail.Text;

        //    DataTable data = UserService.GetUsers($"Login = '{userId}' AND Email = '{email}'");
        //    if (data.Rows.Count == 1)
        //    {
               
        //        // Generowanie nowego hasła
        //        string newPassword = PasswordHelper.GenerateNewPassword(); // Implementuj tę funkcję
        //        string hashedPassword = HashPassword(newPassword); // Implementuj tę funkcję

        //        // Aktualizacja hasła w bazie danych
        //        UserService.UpdateUserPassword(userId, hashedPassword);

        //        // Wysłanie nowego hasła na e-mail
        //        SendPasswordEmail(email, newPassword); // Implementuj tę funkcję

        //        MessageBox.Show("Nowe hasło zostało wysłane.");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Nie można zidentyfikować użytkownika.");
        //    }
        //}

      

        private void buttonSendRequest_Click(object sender, EventArgs e)
        {
            string Id = numericUpDownId.Text;
            string email = textBoxEmail.Text;

            bool result = UserService.ResetUserPassword(Id, email);
            if (result)
            {
                MessageBox.Show("Tymczasowe hasło zostało wysłane na twój adres e-mail.");
            }
            else
            {
                MessageBox.Show("Nie można zidentyfikować użytkownika.");
            }
        }

    }
}
