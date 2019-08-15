using System;

namespace lecture_14
{
  class Program
  {
    static void Main(string[] args)
    {
      UniqueItem uniqueItemOne = new UniqueItem();
      UniqueItem uniqueItemTwo = new UniqueItem();
      UniqueItem uniqueItemThree = new UniqueItem();
      UniqueItem uniqueItemFour = new UniqueItem();


      Console.WriteLine(uniqueItemOne.Id);
      Console.WriteLine(uniqueItemTwo.Id);
      Console.WriteLine(uniqueItemThree.Id);
      Console.WriteLine(uniqueItemFour.Id);
    }
  }
}
