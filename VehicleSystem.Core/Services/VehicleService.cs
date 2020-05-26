using System.Linq;
using VehicleSystem.Core.Entities;
using VehicleSystem.Core.Models;

namespace VehicleSystem.Core.Services
{
    public interface IVehicleService
    {
        long Create(VehicleModel vm);
        bool Update(long id, VehicleModel vm);
        bool Delete(long id);
    }

    public class VehicleService : IVehicleService
    {
        public long Create(VehicleModel vm)
        {
            using (var context = new VehicleSystemContext())
            {
                var vehicle = new Vehicle
                {
                    Make = vm.Make,
                    Longitude = vm.Longitude,
                    Latitude = vm.Latitude
                };
                context.Vehicles.Add(vehicle);
                context.SaveChanges();
                return vehicle.Id;
            }
        }

        public bool Update(long id, VehicleModel vm)
        {
            using (var context = new VehicleSystemContext())
            {
                var savedVehicle = context.Vehicles.FirstOrDefault(c => c.Id == id);
                if (savedVehicle == null)
                {
                    //To be handled better
                    return false;
                }

                savedVehicle.Make = vm.Make;
                savedVehicle.Longitude = vm.Longitude;
                savedVehicle.Latitude = vm.Latitude;
                context.SaveChanges();
                return true;
            }
        }

        public bool Delete(long id)
        {
            using (var context = new VehicleSystemContext())
            {
                var savedVehicle = context.Vehicles.FirstOrDefault(c => c.Id == id);
                if (savedVehicle == null)
                {
                    //To be handled better
                    return false;
                }
                ;
                context.Vehicles.Remove(savedVehicle);
                context.SaveChanges();
            }
            return true;
        }
    }
}
