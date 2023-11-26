using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassesNUnitTests.FactoryPattern
{
  [TestFixture]
  public class FactoryPatternSampleNUnitTests
  {
    [Test]
    public void FactoryPatternSampleTestOne()
    {
      Factory<AnimalType, IAnimal> animalFactory = new(new AddAnimalClasses());
      var doggy = animalFactory.Create(AnimalType.Dog);
      doggy.Move(123);
      Factory<VehicleType, IVehicle> vehicleFactory = new(new AddVehicleClasses());
      var myCar = vehicleFactory.Create(VehicleType.Car);
      myCar.Drive(56);
    }
  }
}
