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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_losuj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uzytkownik_tekst
            // 
            this.uzytkownik_tekst.AutoSize = true;
            this.uzytkownik_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uzytkownik_tekst.Location = new System.Drawing.Point(69, 33);
            this.uzytkownik_tekst.Name = "uzytkownik_tekst";
            this.uzytkownik_tekst.Size = new System.Drawing.Size(164, 31);
            this.uzytkownik_tekst.TabIndex = 0;
            this.uzytkownik_tekst.Text = "Użytkownik";
            // 
            // haslo_tekst
            // 
            this.haslo_tekst.AutoSize = true;
            this.haslo_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.haslo_tekst.Location = new System.Drawing.Point(144, 87);
            this.haslo_tekst.Name = "haslo_tekst";
            this.haslo_tekst.Size = new System.Drawing.Size(89, 31);
            this.haslo_tekst.TabIndex = 1;
            this.haslo_tekst.Text = "Hasło";
            // 
            // weryfikacja_tekst
            // 
            this.weryfikacja_tekst.AutoSize = true;
            this.weryfikacja_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weryfikacja_tekst.Location = new System.Drawing.Point(70, 176);
            this.weryfikacja_tekst.Name = "weryfikacja_tekst";
            this.weryfikacja_tekst.Size = new System.Drawing.Size(147, 29);
            this.weryfikacja_tekst.TabIndex = 2;
            this.weryfikacja_tekst.Text = "Weryfikacja";
            // 
            // wpisz_tekst
            // 
            this.wpisz_tekst.AutoSize = true;
            this.wpisz_tekst.Location = new System.Drawing.Point(147, 214);
            this.wpisz_tekst.Name = "wpisz_tekst";
            this.wpisz_tekst.Size = new System.Drawing.Size(327, 13);
            this.wpisz_tekst.TabIndex = 3;
            this.wpisz_tekst.Text = "Wpisz znaki, które widzisz na poniższym obrazku, aby kontynuować";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(284, 44);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(232, 20);
            this.login.TabIndex = 4;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // haslo
            // 
            this.haslo.Location = new System.Drawing.Point(284, 98);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(232, 20);
            this.haslo.TabIndex = 5;
            this.haslo.TextChanged += new System.EventHandler(this.haslo_TextChanged);
            // 
            // weryfikacja
            // 
            this.weryfikacja.Location = new System.Drawing.Point(284, 265);
            this.weryfikacja.Name = "weryfikacja";
            this.weryfikacja.Size = new System.Drawing.Size(232, 20);
            this.weryfikacja.TabIndex = 6;
            // 
            // zaloguj
            // 
            this.zaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zaloguj.Location = new System.Drawing.Point(475, 320);
            this.zaloguj.Name = "zaloguj";
            this.zaloguj.Size = new System.Drawing.Size(136, 39);
            this.zaloguj.TabIndex = 7;
            this.zaloguj.Text = "Zaloguj";
            this.zaloguj.UseVisualStyleBackColor = true;
            this.zaloguj.Click += new System.EventHandler(this.zaloguj_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(150, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label_losuj
            // 
            this.label_losuj.AutoSize = true;
            this.label_losuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_losuj.Location = new System.Drawing.Point(336, 320);
            this.label_losuj.Name = "label_losuj";
            this.label_losuj.Size = new System.Drawing.Size(56, 13);
            this.label_losuj.TabIndex = 9;
            this.label_losuj.Text = "losuj nowy";
            this.label_losuj.Click += new System.EventHandler(this.label_losuj_Click);
            // 
            // zdjecia_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 497);
            this.Controls.Add(this.label_losuj);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.zaloguj);
            this.Controls.Add(this.weryfikacja);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.login);
            this.Controls.Add(this.wpisz_tekst);
            this.Controls.Add(this.weryfikacja_tekst);
            this.Controls.Add(this.haslo_tekst);
            this.Controls.Add(this.uzytkownik_tekst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "zdjecia_view";
            this.Text = "Sekretariat";
            this.Load += new System.EventHandler(this.zdjecia_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_losuj;
    }
}

