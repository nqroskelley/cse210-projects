using System;

class Menu
{
  public void UnitMenu ()
  {
    Console.WriteLine("What kind of unit unit do you want to convert?");
    Console.WriteLine("1. Length");
    Console.WriteLine("2. Mass");
    Console.WriteLine("3. Time");
  }

  public void LengthMenu ()
  {
    Console.WriteLine("1. Inches");
    Console.WriteLine("2. Feet");
    Console.WriteLine("3. Yards");
    Console.WriteLine("4. Miles");
    Console.WriteLine("5. Millimeters");
    Console.WriteLine("6. Centimeters");
    Console.WriteLine("7. Meters");
    Console.WriteLine("8. Kilometers");
  }

  public void MassMenu ()
  {
    Console.WriteLine("1. Ounces");
    Console.WriteLine("2. Pounds");
    Console.WriteLine("3. Tons");
    Console.WriteLine("4. Milligrams");
    Console.WriteLine("5. Grams");
    Console.WriteLine("6. Kilograms");
  }

  public void TimeMenu ()
  {
    Console.WriteLine("1. Seconds");
    Console.WriteLine("2. Minutes");
    Console.WriteLine("3. Hours");
    Console.WriteLine("4. Days");
    Console.WriteLine("5. Weeks");
    Console.WriteLine("6. Months");
    Console.WriteLine("7. Years");
  }
}