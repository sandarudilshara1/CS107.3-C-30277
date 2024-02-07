using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");

        // Read user input and convert it to an integer
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write("Enter a number: ");
        }

        // Display the multiplication table using a loop
        Console.WriteLine($"Multiplication table for {number}:");
        for (int i = 1; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
        }

        Console.ReadLine(); // To keep the console window open
    }
}