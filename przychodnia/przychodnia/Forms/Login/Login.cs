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
            List<User> users = UserService.Login(login, password);
            label2.Text = users.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            List<User> users = UserService.Login(login, password);
            label2.Text = users.Count.ToString();
        }
    }
}
