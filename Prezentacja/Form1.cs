using System;
using System.Data;
using System.Windows.Forms;
using Model;

namespace Prezentacja
{
    public partial class Form1 : Form
    {
        public DataTable ListaKlientow = new DataTable("Klienci");
        public bool szukaj = false;
        string szukanaWartosc;
        string szukaWKolumnie;

        public Form1()
        {
            InitializeComponent();
        }

        private void dodajKlienta_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            ListaKlientow.Columns.Add("ID", typeof(int));
            ListaKlientow.Columns.Add("Imię", typeof(string));
            ListaKlientow.Columns.Add("Nazwisko", typeof(string));
            ListaKlientow.Columns.Add("Adres", typeof(string));
            ListaKlientow.Columns.Add("Telefon", typeof(string));
            ListaKlientow.Columns.Add("Email", typeof(string));
            ListaKlientow.Columns.Add("Status", typeof(string));
            await Klient.Wyswietl(ListaKlientow);
            listaKlientow.DataSource = ListaKlientow;
            listaKlientow.Columns[0].Width = 30;
            listaKlientow.Columns[3].Width = 197;
            listaKlientow.Columns[5].Width = 150;
            listaKlientow.Columns[6].Width = 70;
        }

        private async void wyszukaj_Click(object sender, EventArgs e)
        {
            try
            {
                await Klient.Wyszukaj(wyszukajWartosc.Text, wyszukajWKolumnie.Text, ListaKlientow);               
            }
            catch (FormatException)
            {
                MessageBox.Show("Błędny format");
            }
            szukaj = true;
            szukanaWartosc = wyszukajWartosc.Text;
            szukaWKolumnie = wyszukajWKolumnie.Text;
        }

        private async void odswiez_Click(object sender, EventArgs e)
        {
            if (szukaj)
            {
                try
                {
                    await Klient.Wyszukaj(szukanaWartosc, szukaWKolumnie, ListaKlientow);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Błędny format");
                }
            }
            else
            {
                try
                {
                    await Klient.Wyswietl(ListaKlientow);
                }
                catch (Exception)
                {
                    MessageBox.Show("Błąd połączenia z bazą");
                }
            }
        }

        private void listaKlientow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Form2 form2 = new Form2(this, (int)listaKlientow.Rows[e.RowIndex].Cells[0].Value,
                listaKlientow.Rows[e.RowIndex].Cells[1].Value.ToString(),
                listaKlientow.Rows[e.RowIndex].Cells[2].Value.ToString(),
                listaKlientow.Rows[e.RowIndex].Cells[3].Value.ToString(),
                listaKlientow.Rows[e.RowIndex].Cells[4].Value.ToString(),
                listaKlientow.Rows[e.RowIndex].Cells[5].Value.ToString(),
                listaKlientow.Rows[e.RowIndex].Cells[6].Value.ToString());
                form2.ShowDialog();
            }
            catch (NullReferenceException) { }
            catch (InvalidCastException) { }
        }
    }
}
