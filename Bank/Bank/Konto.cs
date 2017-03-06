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

        private bool SprawdzPin(int pin)
        {
            if (this.pin == pin)
                return true;
            return false;
        }

        public void DokonajWplaty(decimal kwota)
        {
            if(kwota < 0)
                throw new ArgumentException("Wpłacana kwota nie może być mniejsza od zera");
            saldo += kwota;
        }

        public string DokonajWyplaty(decimal kwota, int pin)
        {
            if (!SprawdzPin(pin) || saldo < kwota)
                return "Operacja anulowana";
            saldo -= kwota;
            return "Operacje zakonczono pomyślnie";
        }

        public bool ZmienPin(int nowy, int stary)
        {
            if(SprawdzPin(stary)){
                pin = nowy;
                return true;
            }
            return false;
        }
    }
}
