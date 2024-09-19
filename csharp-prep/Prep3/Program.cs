using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1,101);

        int guessNumber = 200;

        while (guessNumber != magicNumber)
        {
        Console.WriteLine("What is your guess? ");
        string guess = Console.ReadLine();

            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.Write("You guessed it!");
            }
        }
    }
}