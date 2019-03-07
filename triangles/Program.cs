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
      int sideOne = 0;
      int sideTwo = 0;
      int sideThree = 0;
      string[] places = { "first", "second", "third" };
      const int NUM_OF_SIDES = 3;
      for (int i = 0; i < NUM_OF_SIDES; i++)
      {
        int side = 0;
        Console.Write($"Enter {places[i]} length: ");
        side = int.Parse(Console.ReadLine());
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
      int[] sides = { sideOne, sideTwo, sideThree };
      Array.Sort(sides);
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

    static bool isTriangle(int sideOne, int sideTwo, int sideThree)
    {
      return sideOne + sideTwo > sideThree &&
        sideOne + sideThree > sideTwo &&
        sideTwo + sideThree > sideOne;
    }

    static bool isRightTriangle(int[] sides)
    {
      return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
    }

    static bool isAcute(int[] sides)
    {
      return Math.Pow(sides[2], 2) < Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
    }

    static bool isObtuse(int[] sides)
    {
      return Math.Pow(sides[2], 2) > Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
    }

    static bool isIsosceles(int sideOne, int sideTwo, int sideThree)
    {
      return sideOne == sideTwo ||
        sideOne == sideThree ||
        sideTwo == sideThree;
    }

    static bool isEquilateral(int sideOne, int sideTwo, int sideThree)
    {
      return sideOne == sideTwo &&
        sideOne == sideThree &&
        sideTwo == sideThree;
    }
  }
}
