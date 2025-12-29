namespace Mix_Calculator.Models;

public class Tank
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Product { get; set; }
    public double BF { get; set; }
    public double TS { get; set; }


    public void Calc()
    {
        Console.WriteLine("Calculating...\n\n");

        Console.WriteLine("=============\n" + Name + "\n=============");
        Console.WriteLine("BF: " + BF + "\nSNF: " + (TS - BF) + "\nTS: " + TS);
    }
}