// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main()
    {
        // Create a new instance of the Random class
        Random random = new Random();

        // Generate a random number
        int randomNumber = random.Next(1,100); // You can specify a range if needed, e.g., random.Next(0, 100)

        // Print the random number
        Console.WriteLine("Your random number is " + randomNumber);
    }
}

