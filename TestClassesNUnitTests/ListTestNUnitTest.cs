﻿using System;
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
<<<<<<< HEAD
    List<int> l = listTest.TestAddRange();
=======
    List<int> l = listTest.Test();
>>>>>>> aaa523f3e5f75d464f8152e378f3b29e709c5b70
    //int y = 3;

    // Assert
    Assert.Pass("Just getting the console output here...");
    //Assert.AreEqual(y, l.Count);
  }
}
