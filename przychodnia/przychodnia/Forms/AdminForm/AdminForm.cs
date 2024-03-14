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

namespace przychodnia.Forms.AdminForm
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            label1.Text = "Witaj w panelu administracyjnym, " + UserHelper.LoggedUser.Imie + " " + UserHelper.LoggedUser.Nazwisko + " !";
            LoadUsers();
        }

        private void LoadUsers()
        {
            string query = "SELECT * FROM tbl_Uzytkownicy";
            DataTable dt = DataBaseHelper.ExecuteQuery(query);
            dataGridView2.DataSource = dt;
            MessageBox.Show("Liczba znalezionych użytkowników: " + dt.Rows.Count);


        }


        private void buttonLogout_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Czy na pewno chcesz się wylogować?",
                                                 "Potwierdź wylogowanie",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close(); // Zamknięcie MainForm
            }
        }


        private void buttonFiltruj_Click(object sender, EventArgs e)
        {
            // Oczyść DataGridView
            var listaUzytkownikow = new List<User>(); // Przygotuj nową, pustą listę
            dataGridView2.DataSource = null; // Usuń przypisanie źródła danych
            dataGridView2.DataSource = listaUzytkownikow;

            // Pobierz listę wszystkich użytkowników
            List<User> users = UserHelper.GetUsersList();

            // Filtrowanie listy użytkowników
            foreach (var user in users)
            {
                // Logika filtrowania na podstawie textBoxLogin, etc.
                if (user.Login.Contains(textBoxLogin.Text))
                {
                    // Dodaj użytkownika do DataGridView, jeśli pasuje
                    int rowIndex = dataGridView2.Rows.Add(); // Dodaj nowy wiersz
                    dataGridView2.Rows[rowIndex].Cells["Id"].Value = user.Id; // Przykład, jak przypisać wartości do komórek
                                                                              // Uzupełnij pozostałe komórki dla użytkownika...
                }
            }
        }


    }
}
