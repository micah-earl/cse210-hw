using System;

class Program
{
    static void Main(string[] args)
    {
       Random randomGenerator = new Random();
       int number = randomGenerator.Next(1, 11);

        Console.WriteLine(" welcome to guessing number game");
        Console.WriteLine($"Guess the magic number? {number}");
        int user_guess = int.Parse(Console.ReadLine());
        if(user_guess > number)
            {
                Console.WriteLine("lower");
            }
            else if (user_guess < number)
            {
                Console.WriteLine("higher");
            }
        while (user_guess != number)
        {
              Console.WriteLine($"Guess the magic number? {number}");
              user_guess = int.Parse(Console.ReadLine());

            if(user_guess > number)
            {
                Console.WriteLine("lower");
            }
            else if (user_guess < number)
            {
                Console.WriteLine("higher");
            }
        }
    Console.WriteLine("you guessed the number.");
    }
}