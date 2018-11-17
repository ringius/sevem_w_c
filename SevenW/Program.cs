using System;

namespace SevenW
{
    class Program
    {
        static void Main(string[] args)
        {
            Player pelle = new Player(@"Pelle");
            Player olle = new Player("Olle");
            Player kalle = new Player("Kalle");

            pelle.EastPlayer = olle;
            pelle.WestPlayer = kalle;
            
            Console.WriteLine(pelle.ToString());
            Console.ReadKey();
        }
    }
}
