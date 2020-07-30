using System;
using System.Windows.Forms;
using Model;

namespace Prezentacja
{
    public partial class Form2 : Form
    {
        Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        public Form2(Form1 form1, int id, string imie, string nazwisko, string adres, string telefon, string email, string status)
        {
            InitializeComponent();
            this.form1 = form1;
            this.id.Text = Convert.ToString(id);
            this.imie.Text = imie;
            this.nazwisko.Text = nazwisko;
            this.adres.Text = adres;
            this.telefon.Text = telefon;
            this.email.Text = email;
            this.status.SelectedItem = status;
            Text = "Edycja Klienta";
            edytuj.Visible = true;
            dodaj.Visible = false;
            usun.Visible = true;
        }

        private async void edytuj_Click(object sender, EventArgs e)
        {
            Klient klient = new Klient(Convert.ToInt32(id.Text), imie.Text, nazwisko.Text, adres.Text, telefon.Text, email.Text, status.Text);
            if (klient.Status == "Potencjalny" || klient.Status == "Obecny")
            {
                try
                {
                    await Klient.Edytuj(klient);
                }
                catch (Exception)
                {
                    MessageBox.Show("Błąd zapisu edytowanego klienta");
                }
                await Klient.Wyswietl(form1.ListaKlientow);
                form1.szukaj = false;
                Close();
            }
            else
                MessageBox.Show("Błędny status klienta");            
        }

        private async void usun_Click(object sender, EventArgs e)
        {
            Klient klient = new Klient(Convert.ToInt32(id.Text), imie.Text, nazwisko.Text, adres.Text, telefon.Text, email.Text, status.Text);
            try
            {
                await Klient.Usun(klient);
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd usuwania klienta");
            }
            await Klient.Wyswietl(form1.ListaKlientow);
            form1.szukaj = false;
            Close();
        }

        private void anuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void dodaj_Click(object sender, EventArgs e)
        {
            Klient klient = new Klient(imie.Text, nazwisko.Text, adres.Text, telefon.Text, email.Text, status.Text);
            if (klient.Status == "Potencjalny" || klient.Status == "Obecny")
            {
                try
                {
                    await Klient.Dodaj(klient);
                }
                catch (Exception)
                {
                    MessageBox.Show("Błąd zapisu klienta do bazy danych");
                }
                await Klient.Wyswietl(form1.ListaKlientow);
                form1.szukaj = false;
                Close();
            }
            else
                MessageBox.Show("Błędny status klienta");
        }
    }
}
