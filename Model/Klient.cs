using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;

namespace Model
{
    public class Klient
    {
        public int KlientID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Adres { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }

        public Klient()
        { }
        public Klient(string imie, string nazwisko, string adres, int telefon, string email, string status)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Adres = adres;
            Telefon = telefon;
            Email = email;
            Status = status;
        }
        public static void Dodaj(Klient klient)
        {
            using (var db = new KlientContext())
            {
                db.Klients.Add(klient);
                db.SaveChanges();
                var query = from b in db.Klients
                            orderby b.KlientID
                            select b;
            }
        }

        public static async Task<DataTable> Wyswietl()
        {
            using (var db = new KlientContext())
            {
                var klienci = await Task.Factory.StartNew(() => from klient in db.Klients orderby klient.KlientID select klient);
                DataTable table = new DataTable("Klienci");
                table.Columns.Add("Imię", typeof(string));
                table.Columns.Add("Nazwisko", typeof(string));
                table.Columns.Add("Adres", typeof(string));
                table.Columns.Add("Telefon", typeof(int));
                table.Columns.Add("Email", typeof(string));
                table.Columns.Add("Status", typeof(string));
                foreach (var klient in klienci)
                {
                    table.Rows.Add(klient.Imie, klient.Nazwisko, klient.Adres, klient.Telefon, klient.Email, klient.Status);
                }
                return table;
            }
        }
    }

    public class KlientContext : DbContext
    {
        public DbSet<Klient> Klients { get; set; }
    }
}
