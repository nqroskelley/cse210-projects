using System;
//The following features have been implemented to exceed requirements:
//The program always selects unhidden words to hide.
class Program
{
    static void Main(string[] args)
    {
        string _input = "";
        Reference _reference = new Reference("James", 1, 5, 6);
        Scripture _scripture = new Scripture(_reference.GetReference(), "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.");

        while (_input != "quit")
        {
          _scripture.Display();
          Console.WriteLine("");
          Console.WriteLine("Press enter to continue or type 'quit' to exit.");
          _input = Console.ReadLine();
          if (_input != "quit")
          {
            _input = _scripture.HideWords();
          }
        }
    }
}