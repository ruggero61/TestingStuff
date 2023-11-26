using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClasses;

namespace TestClassesNUnitTests
{
  [TestFixture]
  public class DocumentNUnitTest
  {
    [Test]
    [TestCase(2, "Passport", "Irina Pavlov", 21)]
    [TestCase(3, "Driving License", "Taylor Swift", 33)]
    [TestCase(4, "Passport", "Dua Lipa", 29)]
    public void Document_ShouldReturn_Id_Age_Name_OfTeacher(int id, string docType, string person, int age)
    {
      // Arrange
      IPerson p = new Teacher(person, age);
      Document d = new Document(id, docType, p);

      // Act
      string expected = $"{age} is the age of {person} and Id Doc is {id} and Document is {docType}";
      string actual = d.DocPerson();

      // Assert
      Assert.AreEqual(expected, actual);

    }
    [Test]
    [TestCase(2, "Passport", "Irina Pavlov", 21)]
    [TestCase(3, "Driving License", "Taylor Swift", 33)]
    [TestCase(4, "Passport", "Dua Lipa", 29)]
    public void Document_ShouldReturn_Id_Age_Name_OfStudent(int id, string docType, string person, int age)
    {
      // Arrange
      IPerson p = new Student(person, age);
      Document d = new Document(id, docType, p);

      // Act
      string expected = $"{age} is the age of {person} and Id Doc is {id} and Document is {docType}";
      string actual = d.DocPerson();

      // Assert
      Assert.AreEqual(expected, actual);

    }
    [Test]
    [TestCaseSource("GenerateTestCases")]
    public void Document_ShouldReturn_Id_Age_Name_OfPerson(int id, string docType, IPerson person)
    {
      // Arrange
      Document d = new Document(id, docType, person);

      // Act
      string expected = $"{person.GetAge()} is the age of {person.GetName()} and Id Doc is {id} and Document is {docType}";
      string actual = d.DocPerson();

      // Assert
      Assert.AreEqual(expected, actual);
    }
    public static IEnumerable<object[]> GenerateTestCases()
    {
      yield return new object[] { 2, "Passport", new Teacher("Irina Pavlov", 21) };
      yield return new object[] { 3, "Driving License", new Student("Taylor Swift", 33) };
      yield return new object[] { 4, "Passport", new HeadMaster("Dua Lipa", 29) };
    }
    [Test]
    [TestCaseSource("GeneratePersonCases")]
    public void Document_ShouldReturn_Id_Age_Name_OfPerson(IPerson person)
    {
      // Arrange
      Document d = new Document(1, "Passport", person);

      // Act
      string expected = $"{person.GetAge()} is the age of {person.GetName()} and Id Doc is 1 and Document is Passport";
      string actual = d.DocPerson();

      // Assert
      Assert.AreEqual(expected, actual);
    }
    public static IPerson[] GeneratePersonCases()
    {
      return new IPerson[] { new Teacher("Irina Pavlov", 21), new Student("Taylor Swift", 33), new HeadMaster("Dua Lipa", 29) };
    }
  }
}
