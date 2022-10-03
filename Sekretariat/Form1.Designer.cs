namespace Sekretariat
{
    partial class zdjecia_view
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zdjecia_view));
            this.uzytkownik_tekst = new System.Windows.Forms.Label();
            this.haslo_tekst = new System.Windows.Forms.Label();
            this.weryfikacja_tekst = new System.Windows.Forms.Label();
            this.wpisz_tekst = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.haslo = new System.Windows.Forms.TextBox();
            this.weryfikacja = new System.Windows.Forms.TextBox();
            this.zaloguj = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.random = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uzytkownik_tekst
            // 
            this.uzytkownik_tekst.AutoSize = true;
            this.uzytkownik_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uzytkownik_tekst.Location = new System.Drawing.Point(92, 41);
            this.uzytkownik_tekst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uzytkownik_tekst.Name = "uzytkownik_tekst";
            this.uzytkownik_tekst.Size = new System.Drawing.Size(200, 39);
            this.uzytkownik_tekst.TabIndex = 0;
            this.uzytkownik_tekst.Text = "Użytkownik";
            // 
            // haslo_tekst
            // 
            this.haslo_tekst.AutoSize = true;
            this.haslo_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.haslo_tekst.Location = new System.Drawing.Point(192, 107);
            this.haslo_tekst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.haslo_tekst.Name = "haslo_tekst";
            this.haslo_tekst.Size = new System.Drawing.Size(110, 39);
            this.haslo_tekst.TabIndex = 1;
            this.haslo_tekst.Text = "Hasło";
            // 
            // weryfikacja_tekst
            // 
            this.weryfikacja_tekst.AutoSize = true;
            this.weryfikacja_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weryfikacja_tekst.Location = new System.Drawing.Point(93, 217);
            this.weryfikacja_tekst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weryfikacja_tekst.Name = "weryfikacja_tekst";
            this.weryfikacja_tekst.Size = new System.Drawing.Size(180, 36);
            this.weryfikacja_tekst.TabIndex = 2;
            this.weryfikacja_tekst.Text = "Weryfikacja";
            // 
            // wpisz_tekst
            // 
            this.wpisz_tekst.AutoSize = true;
            this.wpisz_tekst.Location = new System.Drawing.Point(196, 263);
            this.wpisz_tekst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wpisz_tekst.Name = "wpisz_tekst";
            this.wpisz_tekst.Size = new System.Drawing.Size(404, 16);
            this.wpisz_tekst.TabIndex = 3;
            this.wpisz_tekst.Text = "Wpisz znaki, które widzisz na poniższym obrazku, aby kontynuować";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(379, 54);
            this.login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(308, 22);
            this.login.TabIndex = 4;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // haslo
            // 
            this.haslo.Location = new System.Drawing.Point(379, 121);
            this.haslo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(308, 22);
            this.haslo.TabIndex = 5;
            this.haslo.TextChanged += new System.EventHandler(this.haslo_TextChanged);
            // 
            // weryfikacja
            // 
            this.weryfikacja.Location = new System.Drawing.Point(379, 326);
            this.weryfikacja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.weryfikacja.Name = "weryfikacja";
            this.weryfikacja.Size = new System.Drawing.Size(308, 22);
            this.weryfikacja.TabIndex = 6;
            // 
            // zaloguj
            // 
            this.zaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zaloguj.Location = new System.Drawing.Point(633, 394);
            this.zaloguj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zaloguj.Name = "zaloguj";
            this.zaloguj.Size = new System.Drawing.Size(181, 48);
            this.zaloguj.TabIndex = 7;
            this.zaloguj.Text = "Zaloguj";
            this.zaloguj.UseVisualStyleBackColor = true;
            this.zaloguj.Click += new System.EventHandler(this.zaloguj_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(128, 326);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(160, 38);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // random
            // 
            this.random.BackColor = System.Drawing.SystemColors.Control;
            this.random.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.random.Location = new System.Drawing.Point(339, 394);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(181, 23);
            this.random.TabIndex = 10;
            this.random.Text = "losuj nowy";
            this.random.UseVisualStyleBackColor = false;
            // 
            // zdjecia_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.random);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.zaloguj);
            this.Controls.Add(this.weryfikacja);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.login);
            this.Controls.Add(this.wpisz_tekst);
            this.Controls.Add(this.weryfikacja_tekst);
            this.Controls.Add(this.haslo_tekst);
            this.Controls.Add(this.uzytkownik_tekst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "zdjecia_view";
            this.Text = "Sekretariat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uzytkownik_tekst;
        private System.Windows.Forms.Label haslo_tekst;
        private System.Windows.Forms.Label weryfikacja_tekst;
        private System.Windows.Forms.Label wpisz_tekst;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox haslo;
        private System.Windows.Forms.TextBox weryfikacja;
        private System.Windows.Forms.Button zaloguj;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button random;
    }
}

