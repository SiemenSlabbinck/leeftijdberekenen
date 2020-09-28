using System;
using System.Security.Cryptography.X509Certificates;

namespace Leeftijdberekenen
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datenow = DateTime.Now;
            Console.WriteLine("Dit is een programma om uw leeftijd te berekenen");
            Console.WriteLine("Geef je geboortedatum in. (DD/MM/YYYY)");
            string geboortedatum = Console.ReadLine();
            DateTime geboorte = Convert.ToDateTime(geboortedatum);
            double leeftijd = (datenow - geboorte).TotalDays;
            Console.WriteLine(leeftijd/365);
        }
    }
}
