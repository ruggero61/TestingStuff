using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses;

public class DependencyInversion
{
}

public interface IPerson
{
  public string GetInfo();
  public string GetName();
  public int GetAge();
}

public class Person : IPerson
{
  private string _name;
  private int _age;

  public Person(string name, int age)
  {
    _name = name;
    _age = age;
  }

  public int GetAge()
  {
    return _age;
  }

  public string GetInfo()
  {
    return $"{_name} is {_age} years old and is a {this.GetType()}";
  }

  public string GetName()
  {
    return _name;
  }
  public string GetType()
  { 
    return "Normal Person";
  }
}

public class Teacher : IPerson
{
  private string _name;
  private int _age;

  public Teacher(string name, int age)
  {
    _name = name;
    _age = age;
  }

  public int GetAge()
  {
    return _age;
  }

  public string GetInfo()
  {
    return $"{_name} is {_age} years old and is a {this.GetType()}";
  }

  public string GetName()
  {
    return _name;
  }
  public string GetType()
  { 
    return "Teacher";
  }
}

public class Student : IPerson
{
  private string _name;
  private int _age;

  public Student(string name, int age)
  {
    _name = name;
    _age = age;
  }

  public int GetAge()
  {
    return _age;
  }

  public string GetInfo()
  {
    return $"{_name} is {_age} years old and is a {this.GetType()}";
  }

  public string GetName()
  {
    return _name;
  }
  public string GetType()
  { 
    return "Student";
  }
}

public class HeadMaster : IPerson
{
  private string _name;
  private int _age;

  public HeadMaster(string name, int age)
  {
    _name = name;
    _age = age;
  }

  public int GetAge()
  {
    return _age;
  }

  public string GetInfo()
  {
    return $"{_name} is {_age} years old and is a {this.GetType()}";
  }

  public string GetName()
  {
    return _name;
  }
  public string GetType()
  { 
    return "HeadMaster";
  }
}


public class School
{
  private List<IPerson> _people;

  public School()
  {
    _people = new List<IPerson>();
  }

  public void AddPerson(IPerson person)
  {
    _people.Add(person);
  }

  public string GetPeopleInfo()
  {
    var sb = new StringBuilder();
    foreach (var person in _people)
    {
      sb.AppendLine(person.GetInfo());
    }
    return sb.ToString();
  }

  public void PrintPeople()
  {
    foreach (var person in _people)
    {
      Console.WriteLine(person.GetInfo());
    }
  }
}

public class Document
{
  private int _id;
  private string _documentDescription;
  private IPerson _person;

  public Document(int id, string documentDescription, IPerson person)
  {
    _id = id;
    _documentDescription = documentDescription;
    _person = person;
  }

  public string DocPerson()
  {
    string result = $"{_person.GetAge()} is the age of {_person.GetName()} and Id Doc is {_id} and Document is {_documentDescription}";
    Console.WriteLine(_person.GetInfo());
    Console.WriteLine(result);
    return result;
  }
}
