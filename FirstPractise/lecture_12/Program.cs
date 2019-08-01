using System;

namespace lecture_12
{
  class Program
  {
    static void Main(string[] args)
    {
      CreatArray();
      Console.ReadLine();
    }
    struct Reactangle
    {
      public int width;
      public int heigth;
    }
    static void CreatArray()
    {
      Random rand = new Random();
      int min = 1;
      int max = 10;
      Reactangle[] arrayRectangle = new Reactangle[100];
      for (int i = 0; i < arrayRectangle.Length; i++)
      {
        arrayRectangle[i].heigth = rand.Next(min, max);
        arrayRectangle[i].width = rand.Next(min, max);
        Console.Write($"\n Heigth: {arrayRectangle[i].heigth}, Width : {arrayRectangle[i].width}");
      }
      var equalNumbers = 0;
      for (int i = 1; i < arrayRectangle.Length; i++)
      {
        if (arrayRectangle[i].Equals(arrayRectangle[0]))
        {
          equalNumbers++;
        }
      }
      Console.WriteLine($"\n\t Equals: {equalNumbers}");
    }
  }
}


