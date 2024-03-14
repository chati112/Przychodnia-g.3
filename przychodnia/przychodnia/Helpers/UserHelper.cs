﻿using Org.BouncyCastle.Utilities.Encoders;
using przychodnia.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace przychodnia.Helpers
{
    public static class UserHelper
    {
        public static User LoggedUser { get; set; }

        public static List<User> GetUsersListFromDataTable(DataTable dt)
        {
            //Login, Imie, Nazwisko, Miejscowosc, KodPocztowy, Ulica, NumerPosesji, NumerLokalu, PESEL, DataUrodzenia, Plec, Email, NumerTelefonu, Haslo, Rola
            List<User> users = new List<User>();
            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                string login = row["login"].ToString();
                string imie = row["imie"].ToString();
                string nazwisko = row["nazwisko"].ToString();
                    
                string miejscowosc = row["miejscowosc"].ToString();
                string kodPocztowy = row["kodPocztowy"].ToString();
                string ulica = row["ulica"].ToString();
                string numerPosesji = row["numerPosesji"].ToString();
                string numerLokalu = row["numerLokalu"].ToString();
                string pesel = row["PESEL"].ToString();
                DateTime dataUrodzenia = Convert.ToDateTime(row["dataUrodzenia"]);
                string plec = row["plec"].ToString();
                string email = row["email"].ToString();
                string numerTelefonu = row["numerTelefonu"].ToString();
                string haslo = row["haslo"].ToString();
                string rola = row["rola"].ToString();
                bool requirePasswordChange = Convert.ToBoolean(row["requirePasswordChange"]);
                User user = new User(id, login, imie, nazwisko, miejscowosc, kodPocztowy, ulica, numerPosesji, numerLokalu, pesel, dataUrodzenia, plec, email, numerTelefonu, haslo, rola, requirePasswordChange);
                users.Add(user);
            }

            return users;
        }

        public static List<User> GetUsersList()
        {
            // Przygotowanie zapytania SQL do pobrania wszystkich użytkowników
            string query = "SELECT * FROM tbl_Uzytkownicy";

            // Używanie istniejącej metody ExecuteQuery z DataBaseHelper do wykonania zapytania i otrzymania wyników
            DataTable dt = DataBaseHelper.ExecuteQuery(query);

            // Używanie istniejącej metody do przekształcenia DataTable na listę użytkowników
            return GetUsersListFromDataTable(dt);
        }
    }
}
