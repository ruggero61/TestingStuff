using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses
{
  public class ListTest
  {
    private List<int> list = new List<int>();
    private List<int> list2 = new() { 10, 20, 30 };
    private Action<int> action = (i) => Console.WriteLine($"Hello Default Action...{i}");
    public ListTest()
    {
      action += (i) => Console.WriteLine($"Hello FirstAction...{i}");
      action += (i) => Console.WriteLine($"Hello SecondAction...{i}");
      list.Add(1);
      list.Add(2);
      list.Add(3);
      list.Add(4);
      list.Add(5);
      list.Add(6);
    }
    public List<int> TestAddRange()
    {
      list.ForEach(action);
      list2.ForEach(x => Console.WriteLine(x));

      list.AddRange(list2);
      list.ForEach(x => Console.WriteLine(x));

      IEnumerable<int> ints = new int[] { 100, 200, 300 };
      list.AddRange(ints);
      list.ForEach(x => Console.WriteLine(x));

      return list;
    }

    public List<int> TesInsertRange()
    {
      list.InsertRange(1, list2);
      list.ForEach(x => Console.WriteLine(x));

      IEnumerable<int> ints = new int[] { 100, 200, 300 };
      list.InsertRange(1, ints);
      list.ForEach(x => Console.WriteLine(x));
      
      return list;
    }
    public List<int> TestRemoveRange()
    {
      list.RemoveRange(1, 2);
      list.ForEach(x => Console.WriteLine(x));

      Console.WriteLine($"value of list-0 : {list[0]}");
      list.Remove(list[0]);
      
      return list;
    }

  }
}
