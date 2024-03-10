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
        public static List<User> Login(string login, string password)
        {
            DataTable data = GetUsers($"Login = '{login}' AND Haslo = '{password}'");
            List<User> employees = UserHelper.GetUsersListFromDataTable(data);
            return employees;
        }
    }
}
