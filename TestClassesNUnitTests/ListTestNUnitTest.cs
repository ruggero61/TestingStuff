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
  public void TestAddRange_TestingConsoleOutput()
  {
    // Arrange
    ListTest listTest = new ListTest();

    // Act
    List<int> l = listTest.TestAddRange();
    //int y = 3;

    // Assert
    Assert.Pass("Just getting the console output here...");
    //Assert.AreEqual(y, l.Count);
  }
  [Test]
  public void TestInsertRange_TestingConsoleOutput()
  {
    // Arrange
    ListTest listTest = new ListTest();

    // Act
    List<int> l = listTest.TesInsertRange();
    //int y = 3;

    // Assert
    Assert.Pass("Just getting the console output here...");
    //Assert.AreEqual(y, l.Count);
  }
  [Test]
  public void TestRemoveRange_TestingConsoleOutput()
  {
    // Arrange
    ListTest listTest = new ListTest();

    // Act
    List<int> l = listTest.TestRemoveRange();
    //int y = 3;

    // Assert
    Assert.Pass("Just getting the console output here...");
    //Assert.AreEqual(y, l.Count);
  }
}
