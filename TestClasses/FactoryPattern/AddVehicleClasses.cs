public class AddVehicleClasses : IAddClasses<VehicleType, IVehicle>
{
  public Dictionary<VehicleType, IVehicle> GetClasses()
  { 
    return new()
    {
      { VehicleType.Car, new Car() },
      { VehicleType.Truck, new Truck() },
      { VehicleType.Bus, new Bus() }
    };
  }
}


