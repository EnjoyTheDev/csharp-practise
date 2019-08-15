using System;
using System.Threading;

namespace lecture_14
{
  public class UniqueItem
  {
    public readonly int Id = 3;
    private static int InstanceCounter;

    public UniqueItem()
    {
      Id = Id + InstanceCounter;
      ++InstanceCounter;
    }

    public int UniqueId
    {
      get { return Id; }
    }
  }
}
