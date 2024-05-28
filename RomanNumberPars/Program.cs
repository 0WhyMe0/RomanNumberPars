using RomanNumberPars;

class Program
{
    static void Main(string[] args)
    {
        RomNumber romNumber = new RomNumber();

        Console.WriteLine(romNumber.Parse("IV"));
    }
}