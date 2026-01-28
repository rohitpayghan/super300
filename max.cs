using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (a > b)
            Console.WriteLine("Maximum number is: " + a);
        else
            Console.WriteLine("Maximum number is: " + b);
    }
}
