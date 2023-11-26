using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClasses.TestCSharp;

namespace TestClassesNUnitTests
{
  [TestFixture]
  public class StaticClassesNUnitTests
  {
    [Test]
    public void PrintStaticValues()
    {
      StaticClasses.i = 1;
      StaticClasses.Print();

      StaticClasses staticClasses1 = new();
      staticClasses1.j = 2;
      staticClasses1.Print2();
    }
  }
}
