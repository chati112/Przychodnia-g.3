using przychodnia.Helpers;
using przychodnia.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przychodnia.Service
{
    public static class UserService
    {
        private static DataTable GetUsers(string filter = "")
        {
            string query = "SELECT * FROM tbl_Uzytkownicy";
            if (filter != "")
            {
                query += $" WHERE {filter}";
            }
            return DataBaseHelper.ExecuteQuery(query);
        }

        public static User Login(string login, string password)
        {
            DataTable data = GetUsers($"Login = '{login}' AND Haslo = '{password}'");
            if (data.Rows.Count == 1)
            {
                // Zakładając, że kolumna roli nazywa się "Rola" w Twojej bazie danych
                var row = data.Rows[0];
                return new User(
                    Convert.ToInt32(row["Id"]),
                    row["Login"].ToString(),
                    row["Imie"].ToString(),
                    row["Nazwisko"].ToString(),
                    row["Miejscowosc"].ToString(),
                    row["KodPocztowy"].ToString(),
                    row["Ulica"].ToString(),
                    row["NumerPosesji"].ToString(),
                    row["NumerLokalu"].ToString(),
                    row["PESEL"].ToString(),
                    Convert.ToDateTime(row["DataUrodzenia"]),
                    row["Plec"].ToString(),
                    row["Email"].ToString(),
                    row["NumerTelefonu"].ToString(),
                    row["Haslo"].ToString(),
                    row["Rola"].ToString() // Dodanie roli
                );
            }
            return null; // Jeśli nie znaleziono użytkownika
        }


        public static bool ResetUserPassword(string Id, string email)
        {
            DataTable data = GetUsers($"Id = '{Id}' AND Email = '{email}'");
            if (data.Rows.Count == 1)
            {
                string newPassword = PasswordHelper.GenerateNewPassword();

                //string hashedPassword = PasswordHelper.HashPassword(newPassword);

                string updateQuery = "UPDATE tbl_Uzytkownicy SET Haslo = @Haslo WHERE Id = @Id AND Email = @Email";
                Dictionary<string, object> parameters = new Dictionary<string, object>
        {
            { "@Haslo", newPassword }, //hashedPassword jeśli chcemy hashowane hasło
            { "@Id", Id },
            { "@Email", email }
        };

                // Aktualizacja hasła w bazie danych
                bool updateResult = DataBaseHelper.ExecuteNonQuery(updateQuery, parameters);

                if (updateResult)
                {
                    EmailService.SendNewPasswordEmail(email, newPassword);
                    return true;
                }
            }
            return false;
        }

    }

}
