namespace Sekretariat
{
    partial class wyszukaj_ucznia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.wyszukaj = new System.Windows.Forms.TabPage();
            this.richTextBox_wynik = new System.Windows.Forms.RichTextBox();
            this.szukaj = new System.Windows.Forms.Button();
            this.kryteria_tekst = new System.Windows.Forms.TextBox();
            this.kryteria_1 = new System.Windows.Forms.ComboBox();
            this.dane = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dodaj = new System.Windows.Forms.TabPage();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.textBox_klasa = new System.Windows.Forms.TextBox();
            this.textBox_nazwisko = new System.Windows.Forms.TextBox();
            this.textBox_imie = new System.Windows.Forms.TextBox();
            this.klasa = new System.Windows.Forms.Label();
            this.nazwisko = new System.Windows.Forms.Label();
            this.imie = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.wyszukaj.SuspendLayout();
            this.dodaj.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.wyszukaj);
            this.tabControl1.Controls.Add(this.dodaj);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(596, 365);
            this.tabControl1.TabIndex = 0;
            // 
            // wyszukaj
            // 
            this.wyszukaj.Controls.Add(this.richTextBox_wynik);
            this.wyszukaj.Controls.Add(this.szukaj);
            this.wyszukaj.Controls.Add(this.kryteria_tekst);
            this.wyszukaj.Controls.Add(this.kryteria_1);
            this.wyszukaj.Controls.Add(this.dane);
            this.wyszukaj.Controls.Add(this.label1);
            this.wyszukaj.Location = new System.Drawing.Point(4, 22);
            this.wyszukaj.Name = "wyszukaj";
            this.wyszukaj.Padding = new System.Windows.Forms.Padding(3);
            this.wyszukaj.Size = new System.Drawing.Size(588, 339);
            this.wyszukaj.TabIndex = 0;
            this.wyszukaj.Text = "wyszukaj ucznia/uczniów";
            this.wyszukaj.UseVisualStyleBackColor = true;
            this.wyszukaj.Click += new System.EventHandler(this.wyszukaj_Click);
            // 
            // richTextBox_wynik
            // 
            this.richTextBox_wynik.Location = new System.Drawing.Point(3, 152);
            this.richTextBox_wynik.Name = "richTextBox_wynik";
            this.richTextBox_wynik.Size = new System.Drawing.Size(578, 181);
            this.richTextBox_wynik.TabIndex = 6;
            this.richTextBox_wynik.Text = "";
            this.richTextBox_wynik.TextChanged += new System.EventHandler(this.richTextBox_wynik_TextChanged);
            // 
            // szukaj
            // 
            this.szukaj.Location = new System.Drawing.Point(358, 124);
            this.szukaj.Name = "szukaj";
            this.szukaj.Size = new System.Drawing.Size(126, 27);
            this.szukaj.TabIndex = 5;
            this.szukaj.Text = "Szukaj";
            this.szukaj.UseVisualStyleBackColor = true;
            this.szukaj.Click += new System.EventHandler(this.szukaj_Click);
            // 
            // kryteria_tekst
            // 
            this.kryteria_tekst.Location = new System.Drawing.Point(339, 77);
            this.kryteria_tekst.Name = "kryteria_tekst";
            this.kryteria_tekst.Size = new System.Drawing.Size(160, 20);
            this.kryteria_tekst.TabIndex = 3;
            this.kryteria_tekst.TextChanged += new System.EventHandler(this.kryteria_tekst_TextChanged);
            // 
            // kryteria_1
            // 
            this.kryteria_1.FormattingEnabled = true;
            this.kryteria_1.Items.AddRange(new object[] {
            "równe",
            "zawiera",
            "rozpoczyna się od"});
            this.kryteria_1.Location = new System.Drawing.Point(191, 77);
            this.kryteria_1.Name = "kryteria_1";
            this.kryteria_1.Size = new System.Drawing.Size(121, 21);
            this.kryteria_1.TabIndex = 2;
            // 
            // dane
            // 
            this.dane.FormattingEnabled = true;
            this.dane.Items.AddRange(new object[] {
            "Imie",
            "Nazwisko",
            "Klasa"});
            this.dane.Location = new System.Drawing.Point(38, 77);
            this.dane.Name = "dane";
            this.dane.Size = new System.Drawing.Size(121, 21);
            this.dane.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wczytaj kryteria wyszukiwania";
            // 
            // dodaj
            // 
            this.dodaj.Controls.Add(this.button_dodaj);
            this.dodaj.Controls.Add(this.textBox_klasa);
            this.dodaj.Controls.Add(this.textBox_nazwisko);
            this.dodaj.Controls.Add(this.textBox_imie);
            this.dodaj.Controls.Add(this.klasa);
            this.dodaj.Controls.Add(this.nazwisko);
            this.dodaj.Controls.Add(this.imie);
            this.dodaj.Location = new System.Drawing.Point(4, 22);
            this.dodaj.Name = "dodaj";
            this.dodaj.Padding = new System.Windows.Forms.Padding(3);
            this.dodaj.Size = new System.Drawing.Size(588, 339);
            this.dodaj.TabIndex = 1;
            this.dodaj.Text = "Dodaj ucznia";
            this.dodaj.UseVisualStyleBackColor = true;
            // 
            // button_dodaj
            // 
            this.button_dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_dodaj.Location = new System.Drawing.Point(382, 188);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(110, 37);
            this.button_dodaj.TabIndex = 6;
            this.button_dodaj.Text = "Dodaj";
            this.button_dodaj.UseVisualStyleBackColor = true;
            this.button_dodaj.Click += new System.EventHandler(this.button_dodaj_Click);
            // 
            // textBox_klasa
            // 
            this.textBox_klasa.Location = new System.Drawing.Point(244, 136);
            this.textBox_klasa.Name = "textBox_klasa";
            this.textBox_klasa.Size = new System.Drawing.Size(200, 20);
            this.textBox_klasa.TabIndex = 5;
            // 
            // textBox_nazwisko
            // 
            this.textBox_nazwisko.Location = new System.Drawing.Point(244, 90);
            this.textBox_nazwisko.Name = "textBox_nazwisko";
            this.textBox_nazwisko.Size = new System.Drawing.Size(200, 20);
            this.textBox_nazwisko.TabIndex = 4;
            // 
            // textBox_imie
            // 
            this.textBox_imie.Location = new System.Drawing.Point(244, 46);
            this.textBox_imie.Name = "textBox_imie";
            this.textBox_imie.Size = new System.Drawing.Size(200, 20);
            this.textBox_imie.TabIndex = 3;
            // 
            // klasa
            // 
            this.klasa.AutoSize = true;
            this.klasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.klasa.Location = new System.Drawing.Point(51, 136);
            this.klasa.Name = "klasa";
            this.klasa.Size = new System.Drawing.Size(67, 25);
            this.klasa.TabIndex = 2;
            this.klasa.Text = "Klasa";
            // 
            // nazwisko
            // 
            this.nazwisko.AutoSize = true;
            this.nazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwisko.Location = new System.Drawing.Point(49, 90);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(104, 25);
            this.nazwisko.TabIndex = 1;
            this.nazwisko.Text = "Nazwisko";
            // 
            // imie
            // 
            this.imie.AutoSize = true;
            this.imie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imie.Location = new System.Drawing.Point(51, 42);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(52, 25);
            this.imie.TabIndex = 0;
            this.imie.Text = "Imię";
            // 
            // wyszukaj_ucznia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "wyszukaj_ucznia";
            this.Text = "wyszukaj_ucznia";
            this.tabControl1.ResumeLayout(false);
            this.wyszukaj.ResumeLayout(false);
            this.wyszukaj.PerformLayout();
            this.dodaj.ResumeLayout(false);
            this.dodaj.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage wyszukaj;
        private System.Windows.Forms.TextBox kryteria_tekst;
        private System.Windows.Forms.ComboBox kryteria_1;
        private System.Windows.Forms.ComboBox dane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage dodaj;
        private System.Windows.Forms.Button szukaj;
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.TextBox textBox_klasa;
        private System.Windows.Forms.TextBox textBox_nazwisko;
        private System.Windows.Forms.TextBox textBox_imie;
        private System.Windows.Forms.Label klasa;
        private System.Windows.Forms.Label nazwisko;
        private System.Windows.Forms.Label imie;
        private System.Windows.Forms.RichTextBox richTextBox_wynik;
    }
}