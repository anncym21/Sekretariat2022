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

    public partial class zdjecia_view : Form
    {
        int numer_zdjecia;
        string[] obrazki = { "mxyxw", "b5nmm", "74853", "cg5dd", "x3deb", "defhd", "c7gb3" };
        public zdjecia_view()
        {
            InitializeComponent();
            Random random = new Random();
            numer_zdjecia = random.Next(0, 6);
            pictureBox1.Image = Image.FromFile(@"../../" + numer_zdjecia + ".png");
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void zaloguj_Click(object sender, EventArgs e)
        {
            
            if (login.Text != "admin"&&haslo.Text != "Qwerty1@34")
            {
                MessageBox.Show("Nie poprawny login i haslo");
            }
            if(login.Text != "admin" && haslo.Text == "Qwerty1@34")
            {
                MessageBox.Show("Nie poprawny login");
            }
            if(login.Text == "admin" && haslo.Text != "Qwerty1@34")
            {
                MessageBox.Show("Nie poprawne haslo");
            }
            if(login.Text == "admin" && haslo.Text == "Qwerty1@34" && weryfikacja.Text == obrazki[numer_zdjecia -1])
            {
                wyszukaj_ucznia wyszukaj_ucznia = new wyszukaj_ucznia();
                wyszukaj_ucznia.ShowDialog();   
                this.Close();
               

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void haslo_TextChanged(object sender, EventArgs e)
        {
            haslo.UseSystemPasswordChar = true;

        }

        private void label_losuj_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            numer_zdjecia = random.Next(0, 6);
            pictureBox1.Image = Image.FromFile(@"../../"+numer_zdjecia+".png");
        }
    }
}
