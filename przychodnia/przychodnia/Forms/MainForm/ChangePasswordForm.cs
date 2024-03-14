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

namespace przychodnia.Forms.MainForm
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newPassword = textBoxNewPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Hasło nie może być puste.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Hasła nie są identyczne.");
                return;
            }

            bool passwordChanged = UserService.ChangeUserPassword(UserHelper.LoggedUser.Id, newPassword);

            if (passwordChanged)
            {
                MessageBox.Show("Hasło zostało zmienione. Zaloguj się ponownie.");
                UserHelper.LoggedUser = null; // Opcjonalnie, wyloguj użytkownika
                this.Close(); // Zamknij formularz zmiany hasła
            }
            else
            {
                MessageBox.Show("Nie udało się zmienić hasła.");
            }
        }
    }
}
