namespace Prezentacja
{
    partial class Form1
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
            this.listaKlientow = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.wyszukajWartosc = new System.Windows.Forms.TextBox();
            this.wyszukaj = new System.Windows.Forms.Button();
            this.dodajKlienta = new System.Windows.Forms.Button();
            this.wyszukajWKolumnie = new DevExpress.XtraEditors.ComboBoxEdit();
            this.odswiez = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaKlientow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyszukajWKolumnie.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listaKlientow
            // 
            this.listaKlientow.BackgroundColor = System.Drawing.Color.White;
            this.listaKlientow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.listaKlientow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaKlientow.Location = new System.Drawing.Point(0, 68);
            this.listaKlientow.Name = "listaKlientow";
            this.listaKlientow.ReadOnly = true;
            this.listaKlientow.RowHeadersVisible = false;
            this.listaKlientow.RowHeadersWidth = 51;
            this.listaKlientow.RowTemplate.Height = 24;
            this.listaKlientow.Size = new System.Drawing.Size(1000, 407);
            this.listaKlientow.TabIndex = 0;
            this.listaKlientow.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaKlientow_CellDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 15);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Klienci w bazie:";
            // 
            // wyszukajWartosc
            // 
            this.wyszukajWartosc.Location = new System.Drawing.Point(722, 12);
            this.wyszukajWartosc.Name = "wyszukajWartosc";
            this.wyszukajWartosc.Size = new System.Drawing.Size(160, 22);
            this.wyszukajWartosc.TabIndex = 2;
            // 
            // wyszukaj
            // 
            this.wyszukaj.Location = new System.Drawing.Point(888, 19);
            this.wyszukaj.Name = "wyszukaj";
            this.wyszukaj.Size = new System.Drawing.Size(100, 30);
            this.wyszukaj.TabIndex = 3;
            this.wyszukaj.Text = "Wyszukaj";
            this.wyszukaj.UseVisualStyleBackColor = true;
            this.wyszukaj.Click += new System.EventHandler(this.wyszukaj_Click);
            // 
            // dodajKlienta
            // 
            this.dodajKlienta.Location = new System.Drawing.Point(513, 481);
            this.dodajKlienta.Name = "dodajKlienta";
            this.dodajKlienta.Size = new System.Drawing.Size(200, 30);
            this.dodajKlienta.TabIndex = 4;
            this.dodajKlienta.Text = "Dodaj nowego klienta";
            this.dodajKlienta.UseVisualStyleBackColor = true;
            this.dodajKlienta.Click += new System.EventHandler(this.dodajKlienta_Click);
            // 
            // wyszukajWKolumnie
            // 
            this.wyszukajWKolumnie.Location = new System.Drawing.Point(722, 40);
            this.wyszukajWKolumnie.Name = "wyszukajWKolumnie";
            this.wyszukajWKolumnie.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.wyszukajWKolumnie.Properties.Items.AddRange(new object[] {
            "ID",
            "Imię",
            "Nazwisko",
            "Adres",
            "Telefon",
            "Email",
            "Status",
            "Bez telefonu i emailu"});
            this.wyszukajWKolumnie.Properties.NullValuePrompt = "Wybierz kolumnę";
            this.wyszukajWKolumnie.Size = new System.Drawing.Size(160, 22);
            this.wyszukajWKolumnie.TabIndex = 5;
            // 
            // odswiez
            // 
            this.odswiez.Location = new System.Drawing.Point(307, 481);
            this.odswiez.Name = "odswiez";
            this.odswiez.Size = new System.Drawing.Size(200, 30);
            this.odswiez.TabIndex = 6;
            this.odswiez.Text = "Odśwież";
            this.odswiez.UseVisualStyleBackColor = true;
            this.odswiez.Click += new System.EventHandler(this.odswiez_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 523);
            this.Controls.Add(this.odswiez);
            this.Controls.Add(this.wyszukajWKolumnie);
            this.Controls.Add(this.dodajKlienta);
            this.Controls.Add(this.wyszukaj);
            this.Controls.Add(this.wyszukajWartosc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listaKlientow);
            this.Name = "Form1";
            this.Text = "Lista Klientów";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaKlientow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyszukajWKolumnie.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listaKlientow;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox wyszukajWartosc;
        private System.Windows.Forms.Button wyszukaj;
        private System.Windows.Forms.Button dodajKlienta;
        private DevExpress.XtraEditors.ComboBoxEdit wyszukajWKolumnie;
        private System.Windows.Forms.Button odswiez;
    }
}

