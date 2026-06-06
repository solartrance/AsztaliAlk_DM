using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Adj meg egy pozitív egész számot: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Adj meg még egy pozitív egész számot: ");
        int b = int.Parse(Console.ReadLine());

        double atlag = (a + b) / 2.0;
        double mertani = Math.Sqrt(a * b);

        Console.WriteLine($"Számtani közép: {atlag}");
        Console.WriteLine($"Mértani közép: {mertani}");

        Console.ReadKey();
    }
}