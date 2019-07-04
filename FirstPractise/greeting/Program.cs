using System;

namespace greeting
{
  class Program
  {
    static void Main(string[] args)
    {
      TimeSpan time = DateTime.Now.TimeOfDay;

      if (time.Hours >= 9 && time.Hours <= 12)
      {
        Console.WriteLine("Good mogning, guys");
      }
      else if (time.Hours >= 12 && time.Hours <= 15)
      {
        Console.WriteLine("Good day, guys");
      }
      else if (time.Hours >= 15 && time.Hours <= 22)
      {
        Console.WriteLine("Good evening, guys");
      }
      else
      {
        return;
      }
    }
  }
}
