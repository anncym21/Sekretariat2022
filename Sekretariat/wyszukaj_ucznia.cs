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
using static System.Windows.Forms.LinkLabel;
using System.Data.SqlTypes;

namespace Sekretariat
{
    public partial class wyszukaj_ucznia : Form
    {
        SqlConnection con;
        string fileName = @".\dane.txt";
        int id = 0;
        string baza = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dane;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        string query = "select * from dane.dbo.uczniowie";
        public wyszukaj_ucznia()
        {
            InitializeComponent();
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            con = new SqlConnection(baza);
            con.Open();
            
         
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            string insert = "insert into dane.dbo.uczniowie( imie, nazwisko, klasa) values ('"+ textBox_imie.Text + "', '"+textBox_nazwisko.Text+"','"+textBox_klasa.Text+"' );";
            
            SqlCommand insert_cmd = new SqlCommand(insert, con);
            insert_cmd.ExecuteScalar();
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


            /*   using (StreamReader fs = File.OpenText(fileName))
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
            */
            string query = "";
            if (dane.Text == "Klasa")
            {
                if (kryteria_1.Text == "równe" )
                {
                    query = "select * from dane.dbo.uczniowie where klasa =  '"+ kryteria_tekst.Text+"'";
                }
                if (kryteria_1.Text == "zawiera" )
                {
                    query = "select * from dane.dbo.uczniowie where klasa like '%"+ kryteria_tekst.Text +"%' ";
                }
                if (kryteria_1.Text == "rorozpoczyna sie od")
                {
                    query = "select * from dane.dbo.uczniowie where klasa like '" + kryteria_tekst.Text + "%' ";
                }
            }
            if (dane.Text == "Nazwisko")
            {
                if (kryteria_1.Text == "równe")
                {
                    query = "select * from dane.dbo.uczniowie where nazwisko =  '"+ kryteria_tekst.Text+"'";
                }
                if (kryteria_1.Text == "zawiera")
                {
                    query = "select * from dane.dbo.uczniowie where nazwisko like '%" + kryteria_tekst.Text + "%' ";
                }
                if (kryteria_1.Text == "rozpoczyna sie od")
                {
                    query = "select * from dane.dbo.uczniowie where nazwisko like '" + kryteria_tekst.Text + "%' ";
                }
            }
            if (dane.Text == "Imie")
            {
                if (kryteria_1.Text == "równe")
                {
                    query = "select * from dane.dbo.uczniowie where imie = '"+ kryteria_tekst.Text+"' ";
                }
                if (kryteria_1.Text == "zawiera")
                {
                    query = "select * from dane.dbo.uczniowie where imie like '%" + kryteria_tekst.Text + "%' ";
                }
                if (kryteria_1.Text == "rozpoczyna sie od")
                {
                    query = "select * from dane.dbo.uczniowie where imie like '" + kryteria_tekst.Text + "%' ";
                }
            }
            

            SqlCommand cmd = new SqlCommand(query, con);
           
           
            cmd = new SqlCommand(query, con);
            SqlDataReader sqlReader = cmd.ExecuteReader();
            richTextBox_wynik.Text = "";
            while (sqlReader.Read())
            {
                //MessageBox.Show(sqlReader.GetValue(0) + " - " + sqlReader.GetValue(1) + " - " + sqlReader.GetValue(2));
                richTextBox_wynik.Text += sqlReader.GetValue(1) + " " + sqlReader.GetValue(2) + " " + sqlReader.GetValue(3) + "\n";
            }
            sqlReader.Close();
            cmd.Dispose();
            

        }

        private void wyszukaj_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox_wynik_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryteria_tekst_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
