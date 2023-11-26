using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses.Prototype;

public interface IPerson : ICloneable
{
  string Name { get; set; }
  IAddress Address { get; set; }
}


public class Person : IPerson
{
  public string Name { get; set; }
  public IAddress Address { get; set; }
  public Person(string name, IAddress address)
  {
    Name = name;
    Address = address;
  }

  public object Clone()
  {
    return new Person(Name, (IAddress)Address.Clone());
  }
}

public interface IAddress : ICloneable
{
  string StreetName { get; set; }
  int HouseNumber { get; set; }
  public void TestMethod();
}


public class Address : IAddress
{
  public string StreetName { get; set; }
  public int HouseNumber { get; set; }
  public Address(string streetName, int houseNumber)
  {
    StreetName = streetName;
    HouseNumber = houseNumber;
  }

  public object Clone()
  {
    return new Address(StreetName, HouseNumber);
  }

  public void TestMethod()
  {
    Console.WriteLine("TestMethod from Address");
    }
}

public class AddressExtended : IAddress
{
  public string StreetName { get; set; }
  public int HouseNumber { get; set; }
  public AddressExtended(string streetName, int houseNumber)
  {
    StreetName = streetName;
    HouseNumber = houseNumber;
  }

  public void TestMethod()
  {
    Console.WriteLine("TestMethod from Extended Address");
  }

  public object Clone()
  {
    return new AddressExtended(StreetName, HouseNumber);
  }
}


