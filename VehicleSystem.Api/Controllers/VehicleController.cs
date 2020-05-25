using System.Web.Mvc;
using VehicleSystem.Core;
using VehicleSystem.Core.Entities;

namespace VehicleSystem.Api.Controllers
{
    [RoutePrefix("vehicle")]
    public class VehicleController : Controller
    {
        [HttpGet]
        public string HealthCheck()
        {
            return "up";
        }

        [HttpPost]
        [Route("create")]
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
