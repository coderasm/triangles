using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangles
{
  class Program
  {
    static void Main(string[] args)
    {
      var entryOne = "";
      var entryTwo = "";
      var entryThree = "";
      UInt32 sideOne = 0;
      do
      {
        Console.Write("Enter first length: ");
        entryOne = Console.ReadLine();
        UInt32.TryParse(entryOne, out sideOne);
      } while (sideOne == 0);
      UInt32 sideTwo = 0;
      do
      {
        Console.Write("Enter second length: ");
        entryTwo = Console.ReadLine();
        UInt32.TryParse(entryTwo, out sideTwo);
      } while (sideTwo == 0);
      UInt32 sideThree = 0;
      do
      {
        Console.Write("Enter third length: ");
        entryThree = Console.ReadLine();
        UInt32.TryParse(entryThree, out sideThree);
      } while (sideThree == 0);
      //Test if triangle
      if (!isTriangle(sideOne, sideTwo, sideThree))
      {
        Console.WriteLine("Not a triangle.");
        Console.ReadKey();
        return;
      }
      //Sort sides
      var sides = getSortedSides(sideOne, sideTwo, sideThree);
      //Test if right triangle
      if (isRightTriangle(sides))
      {
        Console.WriteLine("Is a right triangle.");
      }
      //Test if acute triangle
      if (isAcute(sides))
      {
        Console.WriteLine("Is an acute triangle.");
      }
      //Test if acute triangle
      if (isObtuse(sides))
      {
        Console.WriteLine("Is an acute triangle.");
      }
      //Test if isosceles triangle
      if (isIsosceles(sideOne, sideTwo, sideThree))
      {
        Console.WriteLine("Is an isosceles triangle.");
      }
      //Test if equilateral triangle
      if (isEquilateral(sideOne, sideTwo, sideThree))
      {
        Console.WriteLine("Is an equilateral triangle.");
      }
      Console.ReadKey();
    }

    static bool isTriangle(UInt32 sideOne, UInt32 sideTwo, UInt32 sideThree)
    {
      return sideOne + sideTwo > sideThree &&
        sideOne + sideThree > sideTwo &&
        sideTwo + sideThree > sideOne;
    }

    static UInt32[] getSortedSides(uint sideOne, uint sideTwo, uint sideThree)
    {
      UInt32[] sideLengths = { sideOne, sideTwo, sideThree };
      return sideLengths.OrderBy(s => s).ToArray();
    }

    static bool isRightTriangle(uint[] sides)
    {
      return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
    }

    static bool isAcute(uint[] sides)
    {
      return Math.Pow(sides[2], 2) < Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
    }

    static bool isObtuse(uint[] sides)
    {
      return Math.Pow(sides[2], 2) > Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
    }

    static bool isIsosceles(UInt32 sideOne, UInt32 sideTwo, UInt32 sideThree)
    {
      return sideOne == sideTwo ||
        sideOne == sideThree ||
        sideTwo == sideThree;
    }

    static bool isEquilateral(UInt32 sideOne, UInt32 sideTwo, UInt32 sideThree)
    {
      return sideOne == sideTwo &&
        sideOne == sideThree &&
        sideTwo == sideThree;
    }
  }
}
