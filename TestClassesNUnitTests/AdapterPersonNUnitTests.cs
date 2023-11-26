using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TestClasses;
using TestClasses.Adapter;

namespace TestClassesNUnitTests;

[TestFixture]
public class AdapterPersonNUnitTests
{
  [Test]
  public void AdapterPersonTest()
  {
    TestClasses.Adapter.Student person = new();
    PersonAdapter personAdapter = new(person);
    
    Client client = new();
    client.WalkingCode(personAdapter);
  }
}
