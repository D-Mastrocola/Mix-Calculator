using System;

//https://spectreconsole.net/quick-start
using Spectre.Console;



namespace Mix_Calculator
{
    public class Tank
    {
        public string Name;
        public bool isEmpty = false;
        public string Contents;

        public double BF;
        public double SNF;
        public double TS;

        public Tank(string name, string contents, double bf, double ts )
        {
            this.Name = name;
            this.Contents = contents;
            this.BF = bf;
            this.TS = ts;
             //Compute Solids Non Fat
            this.SNF = Math.Round((this.TS - this.BF), 2);
            

            if(contents == null)
            {
                this.isEmpty = true;
                Console.WriteLine(this.isEmpty);
            }
        }


        public void Calc()
        {

            if (!isEmpty)
            {
               
                

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Mix Calculations";

            Tank RawMilk = new Tank("RT1", "Raw Milk", 4.17, 13.89);
            RawMilk.Calc();

            Tank RawCream = new Tank("CT1", "Raw Cream", 43.17, 48.89);
            RawCream.Calc();






            // Create a table
            var table = new Table();

            // Add some columns
            table.AddColumn("Tank");
            table.AddColumn(new TableColumn("Contents").Centered());
            table.AddColumn("Quantity");
            table.AddColumn("%BF");
            table.AddColumn("%SNF");
            table.AddColumn("%TS");

            // Add some rows
            table.AddRow("RT1", "Raw Milk", "", "4.17", "", "13.89");
            table.AddRow("PT7", "Raw Cream", "", "43.17", "", "48.89");


            //Makes Table take up as much width as possible.
            //Affected by a change in window size
            table.Expand();

            //Shows Row Seperators
            table.ShowRowSeparators();


            // Render the table to the console
            AnsiConsole.Write(table);

            Console.ReadKey();
        }
    }
}