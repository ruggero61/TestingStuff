using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClasses.Prototype;

namespace TestClassesNUnitTests
{
  [TestFixture]
  public class PersonAddressNUnitTests
  {
    [Test]
    public void PersonAddressTest()
    {
      Person john = new Person("John", new AddressExtended("London Road", 123));
      Person jane = john.Clone() as Person;

      jane.Name = "Jane";
      jane.Address.HouseNumber = 321;
      jane.Address.StreetName = "Edimburgh Road";

      Console.WriteLine(jane.Name);
      Console.WriteLine(john.Name);
      Console.WriteLine(jane.Address.StreetName);
      Console.WriteLine(john.Address.StreetName);
      john.Address.TestMethod();
    }
  }
}
