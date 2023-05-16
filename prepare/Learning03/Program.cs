using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fractionOne = new Fraction();
        Fraction fractionTwo = new Fraction(6);
        Fraction fractionThree = new Fraction(6, 7);
        fractionOne.SetTop(2);
        fractionOne.SetBottom(3);
        Console.WriteLine(fractionOne.GetTop());
        Console.WriteLine(fractionOne.GetBottom());
    }
}