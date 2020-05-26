using System.Web.Mvc;
using VehicleSystem.Core;
using VehicleSystem.Core.Entities;
using VehicleSystem.Core.Models;
using VehicleSystem.Core.Services;

namespace VehicleSystem.Api.Controllers
{
    [RoutePrefix("vehicle")]
    public class VehicleController : Controller
    {
        public VehicleController()
        {
        }

        [HttpGet]
        public string HealthCheck()
        {
            return "up";
        }

        [HttpPost]
        [Route("create")]
        public long Create(VehicleModel vehicle)
        {
            var vehicleId = new VehicleService().Create(vehicle);
            return vehicleId;
        }


        [HttpPut]
        [Route("update/{id:long}")]
        public bool Update(long id)
        {
            return true;
        }

        [HttpDelete]
        [Route("delete/{id:long}")]
        public bool Delete(long id)
        {
            return true;
        }
    }
}
