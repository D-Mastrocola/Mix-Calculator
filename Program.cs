using System;

//https://spectreconsole.net/quick-start
//using Spectre.Console;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();






/*namespace Mix_Calculator
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
            
      



            // Create a table
            var table = new Table();

            // Add some columns
            table.AddColumn("Tank");
            table.AddColumn(new TableColumn("Contents").Centered());
            table.AddColumn("%BF");
            table.AddColumn("%SNF");
            table.AddColumn("%TS");

            // Add some rows
            table.AddRow("RT1", "Raw Milk", "4.17", "", "13.89");
            table.AddRow("PT7", "Raw Cream", "43.17", "", "48.89");


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
}*/