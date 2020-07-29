using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Prezentacja
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Klient klient = new Klient(imie.Text, nazwisko.Text, adres.Text, Convert.ToInt32(telefon.Text), email.Text, status.Text);
            Klient.Dodaj(klient);
            Close();
        }
    }
}
