using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClasses.Prototype;

namespace TestClassesNUnitTests;

[TestFixture]
public class CopySampleNUnitTest
{
  [Test]
  public void CSNUT_01_CopySample()
  {
    var copySample = new CopySample();
    copySample.Age = 10;
    copySample.Name = "John";

    //CopySample sample = copySample; 
    var sample = copySample.Clone() as CopySample;
    sample.Age = 20;
    sample.Name = "Mary";
    Console.WriteLine(copySample.Age);
    Console.WriteLine(copySample.Name);



    Assert.AreEqual(10, copySample.Age);
    Assert.AreEqual("John", copySample.Name);
  }
}
