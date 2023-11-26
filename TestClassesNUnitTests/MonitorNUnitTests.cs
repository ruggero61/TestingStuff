using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClasses.MonitorThread;

namespace TestClassesNUnitTests
{
  [TestFixture]
  public class MonitorNUnitTests
  {
    [Test]
    public void TestQueue()
    {
      Producer2 producer = new();
      Consumer2 consumer = new();

      Thread threadProducer = new Thread(producer.Produce);
      Thread threadConsumer = new Thread(consumer.Consume);

      threadProducer.Start();
      threadConsumer.Start();

      threadProducer.Join();
      threadConsumer.Join();
      

      Assert.Pass();
    }
  }
}
