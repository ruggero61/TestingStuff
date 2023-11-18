using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses
{
  public class ListTest
  {
<<<<<<< HEAD
    public List<int> TestAddRange()
=======
    public List<int> Test()
>>>>>>> aaa523f3e5f75d464f8152e378f3b29e709c5b70
    {
      Action<int> action = (i) => Console.WriteLine($"Hello Default Action...{i}");
      action += (i) => Console.WriteLine($"Hello FirstAction...{i}");
      action += (i) => Console.WriteLine($"Hello SecondAction...{i}");
      List<int> list = new List<int>();
      list.Add(1);
      list.Add(2);
      list.Add(3);
      list.ForEach(action);

      List<int> list2 = new() { 10, 20, 30 };
      list2.ForEach(x => Console.WriteLine(x));

      list.AddRange(list2);
      list.ForEach(x => Console.WriteLine(x));

      IEnumerable<int> ints = new int[] { 100, 200, 300 };
      list.AddRange(ints);  
      list.ForEach(x => Console.WriteLine(x));


      return list;
    }
  }
}
