using VehicleSystem.Core.Entities;
using VehicleSystem.Core.Models;

namespace VehicleSystem.Core.Services
{
    public interface IVehicleService
    {
        long Create(VehicleModel vm);
    }

    public class VehicleService: IVehicleService
    {
        public long Create(VehicleModel vm)
        {
            using (var context = new VehicleSystemContext())
            {
                var vehicle = new Vehicle
                {
                    Make =  vm.Make,
                    Longitude = vm.Longitude,
                    Latitude = vm.Latitude
                };
                context.Vehicles.Add(vehicle);
                context.SaveChanges();
                return vehicle.Id;
            }
        }
    }
}
