using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        string letter = "Unknown";

        int lastDigit = number % 10;
        string gradeSign = "";
    if (number < 93 && number >= 60)
        {
            if (lastDigit >= 7)
            {
                gradeSign = "+";
            }
            else if (lastDigit < 3)
            {
                gradeSign = "-";
            }
        }

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}{gradeSign}.");

        if (number >= 70)
        {
            Console.WriteLine("You have passed this course!");
        }
        else if (number < 70)
        {
            Console.WriteLine("You did not pass this course.");
        }

    }
}
