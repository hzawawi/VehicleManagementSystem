using VehicleSystem.Core.Entities;

namespace VehicleSystem.Core.Services
{
    public interface IVehicleService
    {
        long Create();
    }

    public class VehicleService: IVehicleService
    {
        public long Create()
        {
            using (var context = new VehicleSystemContext())
            {
                var vehicle = new Vehicle
                {
                    Make = "BMW",
                    Longitude = 20.2f,
                    Latitude = 25.4f
                };
                context.Vehicles.Add(vehicle);
                context.SaveChanges();
                return vehicle.Id;
            }
        }
    }
}
