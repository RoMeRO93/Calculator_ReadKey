using System;

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("Introdu primul număr:");
        int numar1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introdu al doilea număr:");
        double numar2 = double.Parse(Console.ReadLine());

        calculator.Calculate(numar1, numar2);

        Console.WriteLine("Apasă orice tastă pentru a ieși.");
        Console.ReadKey();
    }
}

class Calculator
{
    private int numar1;
    private double numar2;

    public void Calculate(int num1, double num2)
    {
        numar1 = num1;
        numar2 = num2;

        AfiseazaOperatiiAritmetice();
        AfiseazaExpresiiAditionale();
    }

    private void AfiseazaOperatiiAritmetice()
    {
        Console.WriteLine("Calcularea operațiilor aritmetice...");
        Console.WriteLine($"Suma: {Aduna()}");
        Console.WriteLine($"Diferența: {Scade()}");
        Console.WriteLine($"Înmulțirea: {Inmulteste()}");
        Console.WriteLine($"Diviziunea: {Imparte()}");
        Console.WriteLine($"Suma din nou: {Aduna()}");

        Console.WriteLine();
    }

    private double Aduna()
    {
        return numar1 + numar2;
    }

    private double Scade()
    {
        return numar1 - numar2;
    }

    private double Inmulteste()
    {
        return numar1 * numar2;
    }

    private double Imparte()
    {
        return numar1 / numar2;
    }

    private void AfiseazaExpresiiAditionale()
    {
        Console.WriteLine("Calcularea expresiilor adiționale...");
        Console.WriteLine($"Rezultat: {CalculeazaExpresie()}");
        Console.WriteLine($"Restul: {CalculeazaRest()}");
        Console.WriteLine("Calculare finalizată.");
    }

    private double CalculeazaExpresie()
    {
        return numar1 + numar2 * 2 / 3;
    }

    private double CalculeazaRest()
    {
        return numar1 % 4;
    }
}
