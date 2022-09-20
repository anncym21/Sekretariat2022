using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sekretariat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void zaloguj_Click(object sender, EventArgs e)
        {
            if(login.Text != "admin"&&haslo.Text != "Qwerty1@34")
            {
                MessageBox.Show("Nie poprawny login i haslo");
            }else if(login.Text != "admin" && haslo.Text == "Qwerty1@34")
            {
                MessageBox.Show("Nie poprawny login");
            }
            else if(login.Text == "admin" && haslo.Text != "Qwerty1@34")
            {
                MessageBox.Show("Nie poprawne haslo");
            }
            else
            {
                MessageBox.Show("Poprawne dane");
            }
        }
    }
}
