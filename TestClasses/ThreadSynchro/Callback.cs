using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses.ThreadSynchro
{
  public class Callback
  {
  }
}

public class CallBackMain
{
  public Action<int> cb = num => { Console.WriteLine(num); };
}

public class CallBackFn
{
  public void Method(Action<int> cb)
  {
    Console.WriteLine("Thread One Start...");
    Console.WriteLine("Do some stuff by Fn...");
    Console.WriteLine("Thread One End...");
    cb(1);
  }
}

public class CallBackFn2
{
  public void Method(Action<int> cb)
  {
    Console.WriteLine("Thread Two Start...");
    Console.WriteLine("Do some stuff by Fn2...");
    Console.WriteLine("Thread Two End...");
    cb(2);
  }
}
