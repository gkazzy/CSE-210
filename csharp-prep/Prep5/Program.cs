using System;
using System.Configuration.Assemblies;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favNum = PromptUserNumber();
        int squareNumber = SquareNumber(favNum);
        Console.WriteLine($"{name}, the square of your number is {squareNumber}.");
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            return Console.ReadLine();
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("Pelase enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquareNumber(int number)
        {
            return number*number;
        }

    }
}