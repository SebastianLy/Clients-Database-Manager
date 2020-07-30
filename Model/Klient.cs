using System;
using System.Linq;
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
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }

        public Klient()
        { }

        public Klient(int id, string imie, string nazwisko, string adres, string telefon, string email, string status)
        {
            KlientID = id;
            Imie = imie;
            Nazwisko = nazwisko;
            Adres = adres;
            Telefon = telefon;
            Email = email;
            Status = status;
        }

        public Klient(string imie, string nazwisko, string adres, string telefon, string email, string status)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Adres = adres;
            Telefon = telefon;
            Email = email;
            Status = status;
        }

        public async static Task Dodaj(Klient klient)
        {
            using (var db = new KlientContext())
            {
                db.Klients.Add(klient);
                await db.SaveChangesAsync();
            }
        }

        public async static Task Usun(Klient klient)
        {
            using (var db = new KlientContext())
            {
                var result = db.Klients.SingleOrDefault(b => b.KlientID == klient.KlientID);
                if (result != null)
                {
                    Klient k = db.Klients.First(id => id.KlientID == klient.KlientID);
                    db.Entry(k).State = EntityState.Deleted;
                    await db.SaveChangesAsync();
                }
            }
        }

        public static async Task Wyswietl(DataTable table)
        {
            using (var db = new KlientContext())
            {
                var klienci = await (from klient in db.Klients orderby klient.KlientID select klient).ToListAsync();
                table.Clear();
                foreach (var klient in klienci)
                {
                    table.Rows.Add(klient.KlientID, klient.Imie, klient.Nazwisko, klient.Adres, klient.Telefon, klient.Email, klient.Status);
                }
            }
        }

        public async static Task Wyszukaj(string ciag, string kolumna, DataTable table)
        {
            using (var db = new KlientContext())
            {
                table.Clear();
                switch (kolumna)
                {
                    case "ID":
                        int id = Convert.ToInt32(ciag);
                        var klienci = await (from klient in db.Klients where id == klient.KlientID orderby klient.KlientID select klient).ToListAsync();
                        foreach (var klient in klienci)
                            table.Rows.Add(klient.KlientID, klient.Imie, klient.Nazwisko, klient.Adres, klient.Telefon, klient.Email, klient.Status);
                        break;
                    case "Imię":
                         klienci = await (from klient in db.Klients where ciag == klient.Imie orderby klient.KlientID select klient).ToListAsync();
                        foreach (var klient in klienci)
                            table.Rows.Add(klient.KlientID, klient.Imie, klient.Nazwisko, klient.Adres, klient.Telefon, klient.Email, klient.Status);
                        break;
                    case "Nazwisko":
                        klienci = await (from klient in db.Klients where ciag == klient.Nazwisko orderby klient.KlientID select klient).ToListAsync();
                        foreach (var klient in klienci)
                            table.Rows.Add(klient.KlientID, klient.Imie, klient.Nazwisko, klient.Adres, klient.Telefon, klient.Email, klient.Status);
                        break;
                    case "Adres":
                        klienci = await (from klient in db.Klients where ciag == klient.Adres orderby klient.KlientID select klient).ToListAsync();
                        foreach (var klient in klienci)
                            table.Rows.Add(klient.KlientID, klient.Imie, klient.Nazwisko, klient.Adres, klient.Telefon, klient.Email, klient.Status);
                        break;
                    case "Telefon":
                        klienci = await (from klient in db.Klients where ciag == klient.Telefon orderby klient.KlientID select klient).ToListAsync();
                        foreach (var klient in klienci)
                            table.Rows.Add(klient.KlientID, klient.Imie, klient.Nazwisko, klient.Adres, klient.Telefon, klient.Email, klient.Status);
                        break;
                    case "Email":
                        klienci = await (from klient in db.Klients where ciag == klient.Email orderby klient.KlientID select klient).ToListAsync();
                        foreach (var klient in klienci)
                            table.Rows.Add(klient.KlientID, klient.Imie, klient.Nazwisko, klient.Adres, klient.Telefon, klient.Email, klient.Status);
                        break;
                    case "Status":
                        klienci = await (from klient in db.Klients where ciag == klient.Status orderby klient.KlientID select klient).ToListAsync();
                        foreach (var klient in klienci)
                            table.Rows.Add(klient.KlientID, klient.Imie, klient.Nazwisko, klient.Adres, klient.Telefon, klient.Email, klient.Status);
                        break;
                    case "Bez telefonu i emailu":
                        klienci = await (from klient in db.Klients where (ciag == klient.Imie || ciag == klient.Nazwisko || ciag == klient.Adres ||
                                         ciag == klient.Status) && klient.Telefon == "" && klient.Email == "" orderby klient.KlientID
                                         select klient).ToListAsync();
                        foreach (var klient in klienci)
                            table.Rows.Add(klient.KlientID, klient.Imie, klient.Nazwisko, klient.Adres, klient.Telefon, klient.Email, klient.Status);
                        break;
                    default:
                        klienci = await (from klient in db.Klients where ciag == klient.Imie || ciag == klient.Nazwisko || ciag == klient.Adres ||
                                         ciag == klient.Telefon || ciag == klient.Email || ciag == klient.Status orderby klient.KlientID
                                         select klient).ToListAsync();
                        foreach (var klient in klienci)
                            table.Rows.Add(klient.KlientID, klient.Imie, klient.Nazwisko, klient.Adres, klient.Telefon, klient.Email, klient.Status);
                        break;
                }
            }
        }

        public async static Task Edytuj(Klient klient)
        {
            using (var db = new KlientContext())
            {
                var result = db.Klients.SingleOrDefault(k => k.KlientID == klient.KlientID);
                if (result != null)
                {
                    Klient k = db.Klients.First(id => id.KlientID == klient.KlientID);
                    k.Imie = klient.Imie;
                    k.Nazwisko = klient.Nazwisko;
                    k.Adres = klient.Adres;
                    k.Telefon = klient.Telefon;
                    k.Email = klient.Email;
                    k.Status = klient.Status;
                    db.Entry(k).State = EntityState.Modified;
                    await db.SaveChangesAsync();
                }              
            }
        }
    }

    public class KlientContext : DbContext
    {
        public DbSet<Klient> Klients { get; set; }
    }
}
