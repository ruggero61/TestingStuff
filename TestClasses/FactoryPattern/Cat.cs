public class Cat : IAnimal
{
  public void Move(int distance)
  {
    Console.WriteLine("Cat moved " + distance.ToString() + " meters");
  }
}
