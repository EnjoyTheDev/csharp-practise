using System;

namespace lecture_8
{
  class Program
  {
    static void Main(string[] args)
    {
      // Task 1 Create empty array
      int[] myArray = new int[0] { };

      // Task 2 Create array with int, char, string
      object[] myObj = { 32, 'A', "Hello" };
      Console.WriteLine("\n Input array:");
      foreach (var item in myObj)
      {
        Console.WriteLine(item);
      }

      myObj[0] = Convert.ToInt32(myObj[0]) + 10;
      myObj[2] = Convert.ToString(myObj[2] + ", guys!");
      Console.WriteLine("\n Array after some manipulations:");
      foreach (var itemNew in myObj)
      {
        Console.WriteLine(itemNew);
      }
      Random rand = new Random();
      int min = 1;
      int max = 100;
      int[] arrayNumb = new int[13];
      for (int i = 0; i < arrayNumb.Length; i++)
      {
        arrayNumb[i] = rand.Next(min, max);
      }

      Console.WriteLine("\n Random array:");
      foreach (var item in arrayNumb)
      {
        Console.WriteLine(item);
      }
      Array.Sort(arrayNumb);

      Console.WriteLine($"\n Min number of array: {arrayNumb[0]}");
    }
  }
}

