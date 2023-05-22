using System;

class Program
{
    static void Main(string[] args)
    {
        string _input = "";
        Reference _reference = new Reference();
        Scripture _scripture = new Scripture();

        while (_input != "quit")
        {
          Console.WriteLine("Press enter to continue or type 'quit' to exit.");
          _input = Console.ReadLine();
        }
    }
}