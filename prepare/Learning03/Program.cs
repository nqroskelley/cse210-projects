using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fractionOne = new Fraction();
        Fraction fractionTwo = new Fraction(5);
        Fraction fractionThree = new Fraction(3, 4);
        Console.WriteLine(fractionOne.GetFractionString());
        Console.WriteLine(fractionOne.GetDecimalValue());
        Console.WriteLine(fractionTwo.GetFractionString());
        Console.WriteLine(fractionTwo.GetDecimalValue());
        Console.WriteLine(fractionThree.GetFractionString());
        Console.WriteLine(fractionThree.GetDecimalValue());
        fractionThree.SetTop(1);
        fractionThree.SetBottom(3);
        Console.WriteLine(fractionThree.GetFractionString());
        Console.WriteLine(fractionThree.GetDecimalValue());
    }
}