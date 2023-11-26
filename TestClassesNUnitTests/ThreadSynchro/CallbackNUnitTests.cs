using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassesNUnitTests.ThreadSynchro
{
  [TestFixture]
  public class CallbackNUnitTests
  {
    [Test]
    public void CallBackMainTest()
    {
      CallBackMain cbm = new();
      cbm.cb += num => { Console.WriteLine("This is a test with Nunit Test..."); };
      CallBackFn cbf = new();
      CallBackFn2 cbf2 = new();

      Thread tM1 = new(() => cbf.Method(cbm.cb));
      Thread tM2 = new(() => cbf2.Method(cbm.cb));

      tM1.Start();
      tM2.Start();
    } 
  }
}
