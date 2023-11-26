public class AddAnimalClasses : IAddClasses<AnimalType, IAnimal>
{
  public Dictionary<AnimalType, IAnimal> GetClasses()
  { 
    return new()
    {
      { AnimalType.Dog, new Dog() },
      { AnimalType.Cat, new Cat() },
      { AnimalType.Eagle, new Eagle() }
    };
  }
}


