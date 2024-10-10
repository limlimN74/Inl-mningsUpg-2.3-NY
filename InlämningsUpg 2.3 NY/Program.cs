using System;
namespace inlämnings_upg_2._3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("skriv hur många dagar du vill hyra bilen: ");
            int dagar = int.Parse(Console.ReadLine());

            Console.Write("Skriv hur månka kilometer du kommer köra: ");
            int kilometer = int.Parse(Console.ReadLine());

            int startavgift = 300;
            int kostnadPerKilometer = kilometer;
            int extraDagKostnad = (dagar - 1) * 500;

            int totalKostnad = startavgift + kostnadPerKilometer + extraDagKostnad;

            Console.WriteLine("Den totala kostnaden för är: " + totalKostnad + "kr");

        }
    }
}
