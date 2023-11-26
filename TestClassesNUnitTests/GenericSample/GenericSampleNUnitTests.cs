using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassesNUnitTests.GenericSample
{

  [TestFixture]
  public class GenericSampleNUnitTests
  {
    [Test]
    public void GenericSampleTestOne()
    {
      GenericTestClass<int> classNameInt = new();
      classNameInt.MethodName(10);

      GenericTestClass<string> classNameString = new();
      classNameString.MethodName("Hello World");

      GenericTestClass<bool> classNameBool = new();
      classNameBool.MethodName(true);

      Assert.IsInstanceOf<GenericTestClass<int>>(classNameInt);
      Assert.IsInstanceOf<GenericTestClass<string>>(classNameString);
      Assert.IsInstanceOf<GenericTestClass<bool>>(classNameBool);
    }
  }
}
