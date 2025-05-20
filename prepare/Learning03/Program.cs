using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.getfractionstring());
        Console.WriteLine(f1.getdecimal());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.getfractionstring());
        Console.WriteLine(f2.getdecimal());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.getfractionstring());
        Console.WriteLine(f3.getdecimal());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.getfractionstring());
        Console.WriteLine(f4.getdecimal());
    }
}