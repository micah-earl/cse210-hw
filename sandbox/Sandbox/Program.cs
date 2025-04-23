using System;

class Program
{
    static void Main(string[] args)
    {
        // this is a program to compute the area of a circle. 
        // get the radius from the user
        Console.Write("please enter the radius:");
        string text = Console.ReadLine();
        double radius = double.Parse(text);

        //compute time 

        double area = Math.PI * radius * radius;
      
        

       Console.WriteLine($"Area of the circle: {Math.Round(area, 2)}");
    }
}