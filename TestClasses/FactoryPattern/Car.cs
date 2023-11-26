public class Car : IVehicle
{
  public void Drive(int miles)
  {
    Console.WriteLine("Drive the Car : " + miles.ToString() + "km");
  }
}
