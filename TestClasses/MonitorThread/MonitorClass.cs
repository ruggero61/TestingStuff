using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TestClasses.MonitorThread;

public class MonitorClass
{

}


public class Shared
{
  public static object LockObject = new object();
  public static Queue<int> Buffer = new();
  public const int BufferCapacity = 5;
  public static AutoResetEvent ProducerSignal = new AutoResetEvent(false);
  public static AutoResetEvent ConsumerSignal = new AutoResetEvent(false);

  public static void Print()
  {
    Console.WriteLine("Buffer: ");
    foreach (int item in Buffer)
    {
      Console.Write($"{item}, ");
    }
    Console.WriteLine();
  }
}

public class Producer
{
  public void Produce()
  {
    //Console.WriteLine("Producer Started");
    for (int i = 0; i < 10; i++)
    {
      lock (Shared.LockObject)
      {
        if (Shared.Buffer.Count == Shared.BufferCapacity)
        {
      //    Console.WriteLine("Buffer is full. Witing for signal from Consumer");
          Monitor.Wait(Shared.LockObject);
        }
        Thread.Sleep(1000);
        Shared.Buffer.Enqueue(i);
        Console.WriteLine($"Producer produced: {i}");
        //Shared.Print();
        Monitor.Pulse(Shared.LockObject);
      }
    }
    //Console.WriteLine("Production Completed");
  }
}

public class Consumer
{
  public void Consume()
  {
    //Console.WriteLine("Consumer Started");
    for (int i = 0; i < 10; i++)
    {
      lock (Shared.LockObject)
      {
        if (Shared.Buffer.Count == 0)
        {
     //     Console.WriteLine("Buffer is empty. Witing for signal from Producer");
          Monitor.Wait(Shared.LockObject);
        }
        int val = Shared.Buffer.Dequeue();
        Console.WriteLine($"Consumer consumed: {val}");
        Monitor.Pulse(Shared.LockObject);
      }
    }
    //Console.WriteLine("Consumer: Processing Data");
  }
}

public class Producer2
{
  public void Produce()
  {
    //Console.WriteLine("Producer Started");
    for (int i = 0; i < 10; i++)
    {
      lock (Shared.LockObject)
      {
        while (Shared.Buffer.Count == Shared.BufferCapacity)
        {
          //    Console.WriteLine("Buffer is full. Witing for signal from Consumer");
          //Monitor.Wait(Shared.LockObject);
          Shared.ConsumerSignal.Set();    
          Shared.ProducerSignal.WaitOne();    
        }
        Shared.Buffer.Enqueue(i);
        Console.WriteLine($"Producer produced: {i}");
        //Shared.Print();
        //Monitor.Pulse(Shared.LockObject);
        Shared.ConsumerSignal.Set();
      }
    }
    //Console.WriteLine("Production Completed");
  }
}

public class Consumer2
{
  public void Consume()
  {
    AutoResetEvent autoResetEvent = new AutoResetEvent(false);
    //Console.WriteLine("Consumer Started");
    for (int i = 0; i < 10; i++)
    {
      lock (Shared.LockObject)
      {
        while (Shared.Buffer.Count == 0)
        {
          //     Console.WriteLine("Buffer is empty. Witing for signal from Producer");
          //Monitor.Wait(Shared.LockObject);
          Shared.ProducerSignal.Set();
          Shared.ConsumerSignal.WaitOne();
        }
        int val = Shared.Buffer.Dequeue();
        Console.WriteLine($"Consumer consumed: {val}");
        //Monitor.Pulse(Shared.LockObject);
        Shared.ProducerSignal.Set();
      }
    }
    //Console.WriteLine("Consumer: Processing Data");
  }
}

