using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine("what is your first name?");
        string first_name = Console.ReadLine();
        Console.WriteLine("what is your last name?");
        string last_name =   Console.ReadLine();
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}");

        Console.WriteLine("what is your grade percent: Ex: 85");
        int grade = int.Parse(Console.ReadLine());
        if (grade >= 90)
        {
            Console.WriteLine("your grade is an A");

        }
        else if (grade >= 80)
        {
            Console.WriteLine("your grade is a B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("your grade is a C");
        }
         else if (grade >= 60)
        {
            Console.WriteLine("your grade is a d");
        }
        else 
        {
            Console.WriteLine("you faild the class and recived an F");
        }

    }
}

