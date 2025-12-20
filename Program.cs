using System;

//https://spectreconsole.net/quick-start
using Spectre.Console;

namespace Mix_Calculator
{
    public class Product
    {
        public string Name;
        public string Tank;
        public double BF;
        public double TS;

        public void Calc()
        {
            Console.WriteLine("Calculating...\n\n");

            Console.WriteLine("=============\n" + Name + "\n=============");
            Console.WriteLine("BF: " + BF + "\nSNF: " + (TS - BF) + "\nTS: " + TS);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.Title = "Mix Calculations";
            /*
            Product RawMilk = new Product();
            RawMilk.Name = "Raw Milk";
            RawMilk.BF = 4.17;
            RawMilk.TS = 13.89;
            RawMilk.Calc();

            Product RawCream = new Product();
            RawCream.Name = "Raw Cream";
            RawCream.BF = 43.17;
            RawCream.TS = 48.89;
            RawCream.Calc();

            Console.ReadKey();
            */

            AnsiConsole.Markup("[underline red]Hello[/] World!");

            Console.ReadKey();
        }
    }
}