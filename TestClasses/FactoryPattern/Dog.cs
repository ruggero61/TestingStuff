public class Dog : IAnimal
{
  public void Move(int distance)
  {
    Console.WriteLine("Dog moved " + distance.ToString() + " meters");
  }
}
