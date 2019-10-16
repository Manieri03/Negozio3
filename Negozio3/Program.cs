using System;

namespace Negozio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double spesatotale;
            Console.WriteLine("Quanto costa il primo prodotto?");
            double spesa1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quanto costa il secondo prodotto?");
            double spesa2 = double.Parse(Console.ReadLine());

            if (spesa1 > spesa2)
            {
                spesa2 = spesa2 / 2;
                spesatotale = spesa2 + spesa1;
                

            }
            else
            {
                spesa1 = spesa1 / 2;
                spesatotale = spesa2 + spesa1;
            }
            Console.WriteLine($"Il prezzo totale da pagare è di {spesatotale} ");
            Console.ReadLine();
        }
    }
}
