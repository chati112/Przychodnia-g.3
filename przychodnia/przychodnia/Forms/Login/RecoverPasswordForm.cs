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

        //private void buttonsendrequest_click(object sender, eventargs e)
        //{
        //    string userid = textboxuserid.text;
        //    string email = textboxemail.text;

        //    datatable data = userservice.getusers($"login = '{userid}' and email = '{email}'");
        //    if (data.rows.count == 1)
        //    {

        //        generowanie nowego hasła
        //        string newpassword = passwordhelper.generatenewpassword(); // implementuj tę funkcję
        //        string hashedpassword = hashpassword(newpassword); // implementuj tę funkcję

        //        aktualizacja hasła w bazie danych
        //        userservice.updateuserpassword(userid, hashedpassword);

        //        wysłanie nowego hasła na e - mail
        //        sendpasswordemail(email, newpassword); // implementuj tę funkcję

        //        messagebox.show("nowe hasło zostało wysłane.");
        //    }
        //    else
        //    {
        //        messagebox.show("nie można zidentyfikować użytkownika.");
        //    }
        //}



        private void buttonSendRequest_Click(object sender, EventArgs e)
        {
            string id = numericUpDownId.Value.ToString(); // Załóżmy, że Id jest typu numericUpDown
            string email = textBoxEmail.Text;

            // Resetowanie hasła i wysyłanie nowego hasła
            bool result = UserService.ResetUserPassword(id, email);
            if (result)
            {
                MessageBox.Show("Tymczasowe hasło zostało wysłane na Twój adres e-mail.");
            }
            else
            {
                MessageBox.Show("Nie można zidentyfikować użytkownika.");
            }
        }

    }
}
