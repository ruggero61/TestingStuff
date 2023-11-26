using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses.Adapter;


public interface IPerson
{
  public void WalkingPerson();
}


public class Person : IPerson
{
  public void WalkingPerson()
  {
    Console.WriteLine("WalkingPerson");
  }
}

public class Student : IPerson
{
  public void WalkingPerson()
  {
    Console.WriteLine("Student is Walking");
  }
}


public interface ISubject
{
  public void Walk();
}

public class PersonAdapter : ISubject
{
  private IPerson _person;
  public PersonAdapter(IPerson person)
  {
    _person = person;
  }

  public void Walk()
  {
    _person.WalkingPerson();
  }
}

public class Client
{
  public void WalkingCode(ISubject subject)
  {
    subject.Walk();
  }
}

