using System;

class Program
{
    static void Main(string[] args)
    {   
        int txt = promptusernumber();
        Console.WriteLine($"your number is {txt}");
    }

    static int promptusernumber()
    {
        Console.WriteLine("please enter your favorite number.");
        int txt = int.Parse(Console.ReadLine());
        return txt;

    }
}