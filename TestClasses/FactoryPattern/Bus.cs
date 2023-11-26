public class Bus : IVehicle
{
  public void Drive(int miles)
  {
    Console.WriteLine("Drive the Bus : " + miles.ToString() + "km");
  }
}
