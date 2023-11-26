public class Eagle : IAnimal
{
  public void Move(int distance)
  {
    Console.WriteLine("Eagle moved " + distance.ToString() + " meters");
  }
}
