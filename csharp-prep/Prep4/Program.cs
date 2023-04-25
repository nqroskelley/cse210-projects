using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finsished.");
        int input = 1;
        string numberString;
        List<int> numbers = new List<int>();

        while (input != 0)
        {
          Console.Write("Enter a number: ");
          numberString = Console.ReadLine();
          input = int.Parse(numberString);
          if (input != 0)
          {
            numbers.Add(input);
          }
        }

        int sum = 0;

        foreach (int number in numbers)
        {
          sum = sum + number;
        }

        String sumString = sum.ToString();
        Console.WriteLine($"The sum is: {sumString}");
        int average = sum / numbers.Count;
        String averageString = average.ToString();
        Console.WriteLine($"The average is: {averageString}");
        int max = numbers.Max();
        String maxString = max.ToString();
        Console.WriteLine($"The largest number is: {maxString}");
    }
}