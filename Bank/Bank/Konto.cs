using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Osoba
    {
        /// <summary>
        /// Set class Osoba data
        /// </summary>
        public string Imie;
        public string Nazwisko;

    }
    class Konto
    {
        /// <summary>
        /// Set class Konto data
        /// </summary>
        public Osoba Wlasciciel;
        private decimal saldo = 0;
        private int pin = 0;

        /// <summary>
        /// Method to verify if PIN is correct
        /// </summary>
        /// <param name="pin"></param>
        /// <returns></returns>
        private bool SprawdzPin(int pin)
        {
            if (this.pin == pin)
                return true;
            return false;
        }

        /// <summary>
        /// Method set up the payment on account
        /// </summary>
        /// <param name="kwota"></param>
        public void DokonajWplaty(decimal kwota)
        {
            if(kwota < 0)
                throw new ArgumentException("Wpłacana kwota nie może być mniejsza od zera");
            saldo += kwota;
        }

        /// <summary>
        /// Method set up the withdraw from the account
        /// </summary>
        /// <param name="kwota"></param>
        /// <param name="pin"></param>
        /// <returns></returns>
        public string DokonajWyplaty(decimal kwota, int pin)
        {
            if (!SprawdzPin(pin) || saldo < kwota)
                return "Operacja anulowana";
            saldo -= kwota;
            return "Operacje zakonczono pomyślnie";
        }

        /// <summary>
        /// Method to changed to PIN. Returns bool.
        /// </summary>
        /// <param name="nowy"></param>
        /// <param name="stary"></param>
        /// <returns></returns>
        public bool ZmienPin(int nowy, int stary)
        {
            if(SprawdzPin(stary)){
                pin = nowy;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Method returns acccount balance, if Pin is corects
        /// </summary>
        /// <param name="pin"></param>
        /// <returns></returns>
        public string PobierzInformacje (int pin)
        {
            if (SprawdzPin(pin))
                return string.Format("Pan(i) {0} {1} posiada na koncie {2}", Wlasciciel.Imie, Wlasciciel.Nazwisko, saldo);
            return "Brak dostepu ";
        }
    }
}
