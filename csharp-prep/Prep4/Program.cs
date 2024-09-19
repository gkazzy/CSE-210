using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        do
        {
        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        if (number != 0)
        {
            numbers.Add(number);
        }

        } while (number != 0);
        
        Console.WriteLine("Numbers in list: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        float sum = 0;
        foreach (int num in numbers)
        {
            sum = sum += num;
        }
        Console.WriteLine($"The sum of your numbers is {sum}.");

        float average = average = sum / numbers.Count;
        Console.WriteLine($"The average of your numbers is {average}.");
        
        int largest = 0;
        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }
        Console.WriteLine($"The largest number in the list is {largest}.");
    }
}