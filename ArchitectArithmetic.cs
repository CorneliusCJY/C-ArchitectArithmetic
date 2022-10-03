using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Which monument would you like to calculate the total cost of the floor plan for?");
      Console.WriteLine("Choose Teotihuacan, Taj Mahal, or Great Mosque of Mecca: ");
      string choice = Console.ReadLine();
      double totalArea;

      switch (choice.ToLower())
      {
        case "teotihuacan":
          totalArea = Rectangle(2500, 1500) + Triangle(750, 500) + 0.5 * Circle(375);
          break;
        case "taj mahal":
          totalArea = Rectangle(90.5, 90.5) - 4 * Triangle(24, 24);
          break;
        case "great mosque of mecca":
          totalArea = Rectangle(180, 106) + Rectangle(284, 264) - Triangle(264, 84);
          break;
        default:
          totalArea = 0;
          break;
      }
      double totalCost = totalArea * 180;
      Console.WriteLine($"The total cost of the floor plan for {choice} is: {Math.Round(totalCost, 2)} pesos.");
    }

    static double Rectangle(double length, double width)
    {
      return length * width;
    }

    static double Circle(double radius)
    {
      return Math.PI * Math.Pow(radius, 2);
    }

    static double Triangle(double bottom, double height)
    {
      return 0.5 * bottom * height;
    }
  }
}