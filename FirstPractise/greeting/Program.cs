using System;

namespace greeting
{
  class Program
  {
    static void Main(string[] args)
    {
      var time = DateTime.Now.TimeOfDay;
      var timeNow = DateTime.Now;

      if (time.Hours >= 9 && time.Hours <= 12)
      {
        Console.WriteLine($"{timeNow} Good mogning, guys");
      }
      else if (time.Hours >= 12 && time.Hours <= 15)
      {
        Console.WriteLine($"{timeNow} Good day, guys");
      }
      else if (time.Hours >= 15 && time.Hours <= 22)
      {
        Console.WriteLine($"{timeNow} Good evening, guys");
      }
      else
      {
        return;
      }
     }
  }
}
