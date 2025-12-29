using System;

//https://spectreconsole.net/quick-start
using Spectre.Console;


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

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}




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
}