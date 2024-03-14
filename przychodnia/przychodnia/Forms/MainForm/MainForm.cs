using przychodnia.Helpers;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            label1.Text = "Witaj, " + UserHelper.LoggedUser.Imie + " " + UserHelper.LoggedUser.Nazwisko + " !";
            
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Czy na pewno chcesz się wylogować?",
                                                 "Potwierdź wylogowanie",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                UserHelper.LoggedUser = null;
                this.Close(); // Zamknięcie MainForm
            }
            // Jeśli użytkownik wybierze "Nie", nic się nie dzieje i okno dialogowe zostaje zamknięte
        }

    }
}
