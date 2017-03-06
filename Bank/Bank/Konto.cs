using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Osoba
    {
        public string Imie;
        public string Nazwisko;

    }
    class Konto
    {
        public Osoba Wlasciciel;
        private decimal saldo = 0;
        private int pin = 0;

        private bool sprawdzPin(int pin)
        {
            if (this.pin == pin)
                return true;
            return false;

        }
    }
}
