using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace przychodnia.Models
{
    public  class User
    {
        public User(int id,string login, string imie, string nazwisko, string miejscowosc, string kodPocztowy, string ulica, string numerPosesji, string numerLokalu, string pESEL, DateTime dataUrodzenia, string plec, string email, string numerTelefonu, string haslo)
        {
            Id = id;
            Login = login;
            Imie = imie;
            Nazwisko = nazwisko;
            Miejscowosc = miejscowosc;
            KodPocztowy = kodPocztowy;
            Ulica = ulica;
            NumerPosesji = numerPosesji;
            NumerLokalu = numerLokalu;
            PESEL = pESEL;
            DataUrodzenia = dataUrodzenia;
            Plec = plec;
            Email = email;
            NumerTelefonu = numerTelefonu;
            Haslo = haslo;
        }

        ///Login, Imie, Nazwisko, Miejscowosc, KodPocztowy, Ulica, NumerPosesji, NumerLokalu, PESEL, DataUrodzenia, Plec, Email, NumerTelefonu, Haslo
        public int Id { get; set; }
        public string Login { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Miejscowosc { get; set; }
        public string KodPocztowy { get; set; }
        public string Ulica { get; set; }
        public string NumerPosesji { get; set; }
        public string NumerLokalu { get; set; }
        public string PESEL { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public string Plec { get; set; }
        public string Email { get; set; }
        public string NumerTelefonu { get; set; }
        public string Haslo { get; set; }
        public override String ToString() => Imie + " " + Nazwisko;


        public string FullName() => this.Imie + " " + this.Nazwisko;


        public static User CreateUser()
        {
            return new User(0,"", "", "", "", "", "", "", "", "", DateTime.Now, "", "", "", "");  
        }
        public static SqlCommand AddParametrsToSqlCommand(SqlCommand cmd, User user)
        {
            cmd.Parameters.AddWithValue("@login", user.Login);
            cmd.Parameters.AddWithValue("@imie", user.Imie);
            cmd.Parameters.AddWithValue("@nazwisko", user.Nazwisko);
            cmd.Parameters.AddWithValue("@miejscowosc", user.Miejscowosc);
            cmd.Parameters.AddWithValue("@kodPocztowy", user.KodPocztowy);
            cmd.Parameters.AddWithValue("@ulica", user.Ulica);
            cmd.Parameters.AddWithValue("@numerPosesji", user.NumerPosesji);
            cmd.Parameters.AddWithValue("@numerLokalu", user.NumerLokalu);
            cmd.Parameters.AddWithValue("@pESEL", user.PESEL);
            cmd.Parameters.AddWithValue("@dataUrodzenia", user.DataUrodzenia);
            cmd.Parameters.AddWithValue("@plec", user.Plec);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@numerTelefonu", user.NumerTelefonu);
            cmd.Parameters.AddWithValue("@haslo", user.Haslo);
            return cmd;
        }

    }
}
