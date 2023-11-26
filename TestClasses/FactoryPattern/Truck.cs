public class Truck : ITruck
{
  public void Drive(int miles)
  {
    Console.WriteLine("Drive the Truck : " + miles.ToString() + "km");
  }
  public void LoadCargo(int cargoWeight)
  {
    Console.WriteLine("Load Cargo : " + cargoWeight.ToString() + "kg");
  }
}
