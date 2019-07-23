using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      using System;

public class Example
    {
      public static void Main()
      {
        Random rnd = new Random();
        int caseSwitch = rnd.Next(1, 10);

        switch (caseSwitch)
        {
          case 1:
            Console.WriteLine("Case 1");
            break;
          case 2:
          case 3:
            Console.WriteLine($"Case {caseSwitch}");
            break;
          default:
            Console.WriteLine($"An unexpected value ({caseSwitch})");
            break;
        }
      }
    }
 
  }
}
}
