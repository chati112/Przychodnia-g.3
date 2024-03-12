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
        private string connectionString = "Server=tcp:sqldatabase-przychodnia.database.windows.net,1433;Initial Catalog=PRZYCHODNIA;Persist Security Info=False;User ID=sqladmin;Password=SuperAdmin2137#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

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

                if (user.Rola=="Admin")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.FormClosed += (s, args) => this.Show();
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                    adminForm.Show(); //przejście do panelu admina
                }
                else
                {
                    MainForm mainForm = new MainForm();
                    mainForm.FormClosed += (s, args) => this.Show();
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                    UserHelper.LoggedUser = user;
                    mainForm.Show(); //przejście do panelu użytkownika
                }
            }
            else
            {
                MessageBox.Show("Nieprawidłowy login lub hasło.");
                this.Show(); 
            }
        }


        private void buttonRecoverPassword_Click(object sender, EventArgs e)
        {
            RecoverPasswordForm recoverForm = new RecoverPasswordForm();

            // Wyświetlanie formularza odzyskiwania hasła
            recoverForm.ShowDialog();
        }
    }
}
