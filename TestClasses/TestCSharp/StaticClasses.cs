using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses.TestCSharp
{
  public class StaticClasses
  {
    public static int i;
    public int j;

    public static void Print()
    {
      Console.WriteLine($"{i} ");
    }

    public void Print2()
    {
      Console.WriteLine($"{j}");
    }
  }
}
