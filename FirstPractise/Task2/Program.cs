using System;
using System.Collections;

namespace Task2
{
  class Program
  {
    static void Main(string[] args)
    {
      ArrayList arrayList = new ArrayList();
      // Int32
      arrayList.Add(45); //true, boxing
      // Boolean
      arrayList.Add(true); //true, boxing
      // String
      arrayList.Add("Hello!"); // false
      // Double
      arrayList.Add(23.45); //true, boxing
    }
  }
}
