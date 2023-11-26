public class VehicleFactory
{
  private Dictionary<VehicleType, IVehicle> _vehicles = new();

  public VehicleFactory()
  {
    _vehicles = new()
    {
      { VehicleType.Car, new Car() },
      { VehicleType.Truck, new Truck() },
      { VehicleType.Bus, new Bus() }
    };

  }
  public IVehicle? CreateVehicle(VehicleType vehicleType)
  {
    return _vehicles.ContainsKey(vehicleType) ? _vehicles[vehicleType] : null;
  }
}
