/// <summary>
/// The App is dedicated to a Banks
/// There is two class and variables initialized value of zero.
/// The withdraw from the account and payment on account are possible only if the PIN is correct.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto[] konta = new Konto[2];
            konta[0] = new Konto();
            konta[1] = new Konto();

            konta[0].Wlasciciel = new Osoba();
            konta[1].Wlasciciel = new Osoba();

            konta[0].Wlasciciel.Imie = "Jan";
            konta[0].Wlasciciel.Nazwisko = "Kowalski";
            konta[1].Wlasciciel.Imie = "Ala";
            konta[1].Wlasciciel.Nazwisko = "Nowak";

            Console.WriteLine("Proba zmiany PIN: {0}", konta[0].ZmienPin(1111, 0));
            Console.WriteLine("Proba zmiany PIN: {0}", konta[1].ZmienPin(2222, 0));

            Console.WriteLine("Dokonujemy wpłat:");
            konta[0].DokonajWplaty(1200);
            konta[1].DokonajWplaty(2200);

            Console.WriteLine("Dokonyjemy wyplaty: {0}", konta[0].DokonajWyplaty(300, 1111));
            Console.WriteLine("Dokonyjemy wyplaty: {0}", konta[0].DokonajWyplaty(3000, 1111));
            Console.WriteLine("Dokonyjemy wyplaty: {0}", konta[1].DokonajWyplaty(200, 2222));
            Console.WriteLine("Dokonyjemy wyplaty: {0}", konta[1].DokonajWyplaty(200, 1111));

            Console.WriteLine("Informacje o koncie: {0}", konta[0].PobierzInformacje(1111));
            Console.WriteLine("Informacje o koncie: {0}", konta[1].PobierzInformacje(2222));
            Console.WriteLine("Informacje o koncie: {0}", konta[1].PobierzInformacje(0));
        }
    }
}
