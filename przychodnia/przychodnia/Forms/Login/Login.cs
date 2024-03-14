using przychodnia.Forms.AdminForm;
using przychodnia.Forms.Login;
using przychodnia.Forms.MainForm;
using przychodnia.Helpers;
using przychodnia.Models;
using przychodnia.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przychodnia
{
    public partial class Login : Form
    {

        public Login()
        {
            
            InitializeComponent();
        }

        private void LoadUsers()
        {
            string query = "SELECT * FROM tbl_Uzytkownicy";
            DataTable dt = DataBaseHelper.ExecuteQuery(query);
            dataGridView1.DataSource = dt;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            var user = UserService.Login(login, password);

            if (user != null)
            {
                UserHelper.LoggedUser = user;
                this.Hide(); // Ukryj LoginForm

                if (user.RequirePasswordChange)
                {
                    // Jeśli wymagana jest zmiana hasła, pokazuj formularz zmiany hasła zamiast przechodzić do panelu
                    ChangePasswordForm changePasswordForm = new ChangePasswordForm();
                    changePasswordForm.FormClosed += (s, args) => this.Show();
                    changePasswordForm.Show();
                }
                else if (user.Rola == "Admin")
                {
                    // Przejście do panelu admina
                    AdminForm adminForm = new AdminForm();
                    adminForm.FormClosed += (s, args) => this.Show();
                    adminForm.Show();
                }
                else
                {
                    // Przejście do panelu użytkownika
                    MainForm mainForm = new MainForm();
                    mainForm.FormClosed += (s, args) => this.Show();
                    mainForm.Show();
                }

                // Wyczyszczenie pól logowania
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Nieprawidłowy login lub hasło.");
                this.Show();
            }
        }

        private void NavigateToNextForm(User user)
        {
            this.Hide(); // Ukryj LoginForm

            if (user.Rola == "Admin")
            {
                AdminForm adminForm = new AdminForm();
                adminForm.FormClosed += (s, args) => this.Show();
                adminForm.Show(); // przejście do panelu admina
            }
            else
            {
                MainForm mainForm = new MainForm();
                mainForm.FormClosed += (s, args) => this.Show();
                mainForm.Show(); // przejście do panelu użytkownika
            }

            // Czyszczenie pól formularza logowania
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
        }



        private void buttonRecoverPassword_Click(object sender, EventArgs e)
        {
            RecoverPasswordForm recoverForm = new RecoverPasswordForm();

            // Wyświetlanie formularza odzyskiwania hasła
            recoverForm.ShowDialog();
        }
    }
}
