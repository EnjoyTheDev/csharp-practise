using System;

namespace Task1
{
  class Program
  {
    static void Main(string[] args)
    {
      object box = (short)365;
      sbyte unbox = (sbyte)(short)box;
    }
  }
}
