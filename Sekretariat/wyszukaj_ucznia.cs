using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sekretariat
{
    public partial class wyszukaj_ucznia : Form
    {
        string fileName = @".\dane.txt";
        int id = 0;
        string dane = "(localdb);database=Database1";
        public wyszukaj_ucznia()
        {
            InitializeComponent();
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            

            // Create a new file     
            using (StreamWriter fs = File.AppendText(fileName))
            {
                fs.WriteLine(id.ToString()+" "+textBox_imie.Text+" "+textBox_nazwisko.Text+" "+textBox_klasa.Text);
                id = id + 1;
            }
        }

        private void szukaj_Click(object sender, EventArgs e)
        {


            // To read a text file line by line
            
            
                using (StreamReader fs = File.OpenText(fileName))
                {
                    string wynik = "";
                    string linia = "";
                string[] dane_linia;
                    while (( linia = fs.ReadLine())!= null)
                    {
                         dane_linia = linia.Split(' ');
                  
                    if(dane.Text != "" && kryteria_1.Text != "" && kryteria_tekst.Text != "")
                    {
                        if(dane.Text == "Imie")
                        {
                            if (kryteria_1.Text == "równe" && kryteria_tekst.Text == dane_linia[1])
                            {
                                wynik = wynik + linia+ "\n";
                            }
                            if (kryteria_1.Text == "zawiera" && dane_linia[1].Contains(kryteria_tekst.Text))
                            {
                                wynik = wynik + linia + "\n";
                            }
                            if (kryteria_1.Text == "rozpoczyna sie od" && dane_linia[1].StartsWith(kryteria_tekst.Text))
                            {
                                wynik = wynik + linia + "\n";
                            }
                        }
                        if (dane.Text == "Nazwisko")
                        {
                            if (kryteria_1.Text == "równe" && kryteria_tekst.Text == dane_linia[2])
                            {
                                wynik = wynik + linia+"\n";
                            }
                            if (kryteria_1.Text == "zawiera" && dane_linia[2].Contains(kryteria_tekst.Text))
                            {
                                wynik = wynik + linia + "\n";
                            }
                            if (kryteria_1.Text == "rozpoczyna sie od" && dane_linia[2].StartsWith(kryteria_tekst.Text))
                            {
                                wynik = wynik + linia + "\n";
                            }
                        }
                        if (dane.Text == "Klasa")
                        {
                            if (kryteria_1.Text == "równe" && kryteria_tekst.Text == dane_linia[3])
                            {
                                wynik = wynik + linia+ "\n";
                            }
                            if (kryteria_1.Text == "zawiera" && dane_linia[3].Contains(kryteria_tekst.Text))
                            {
                                wynik = wynik + linia + "\n";
                            }
                            if (kryteria_1.Text == "rozpoczyna sie od" && dane_linia[3].StartsWith(kryteria_tekst.Text))
                            {
                                wynik = wynik + linia + "\n";
                            }
                        }

                    }
                    else
                    {
                        wynik = wynik + linia + "\n";
                    }
                        
                    }
                    richTextBox_wynik.Text = wynik;
                }

            
        }

        private void wyszukaj_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox_wynik_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
