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
      uint sideOne = 0;
      uint sideTwo = 0;
      uint sideThree = 0;
      string[] places = { "first", "second", "third" };
      const int NUM_OF_SIDES = 3;
      for (int i = 0; i < NUM_OF_SIDES; i++)
      {
        uint side = 0;
        var parsedSide = false;
        do
        {
          Console.Write($"Enter {places[i]} length: ");
          var entry = Console.ReadLine();
          parsedSide = UInt32.TryParse(entry, out side);
        } while (!parsedSide);
        if (i == 0)
          sideOne = side;
        if (i == 1)
          sideTwo = side;
        if (i == 2)
          sideThree = side;
      }
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
