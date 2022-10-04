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


namespace Sekretariat
{
    public partial class wyszukaj_ucznia : Form
    {
        string fileName = "dane.txt";
        int id = 0;
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
            if (File.Exists(fileName))
            {
                using (StreamReader fs = File.OpenText(fileName))
                {
                    string wynik = "";
                    while (fs.ReadLine()!= null)
                    {
                        var linia = fs.ReadLine();
                        wynik = wynik + linia+ "\n";
                        
                    }
                    wynik_textbox.Text = wynik;
                }

            }
        }
    }
}
