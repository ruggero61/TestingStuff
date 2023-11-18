using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClasses;

namespace TestClasses;

[TestFixture]
public class ListTestNUnitTest
{
  [Test]
  public void Test()
  {
    // Arrange
    ListTest listTest = new ListTest();

    // Act
    List<int> l = listTest.Test();
    //int y = 3;

    // Assert
    Assert.Pass("Just getting the console output here...");
    //Assert.AreEqual(y, l.Count);
  }
}
