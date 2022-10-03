using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Sekretariat
{

    public partial class zdjecia_view : Form
    {

        public zdjecia_view()
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void haslo_TextChanged(object sender, EventArgs e)
        {
            haslo.UseSystemPasswordChar = true;
        }
    }
}
