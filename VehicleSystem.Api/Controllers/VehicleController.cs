using System.Web.Mvc;
using VehicleSystem.Core;
using VehicleSystem.Core.Entities;
using VehicleSystem.Core.Services;

namespace VehicleSystem.Api.Controllers
{
    [RoutePrefix("vehicle")]
    public class VehicleController : Controller
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet]
        public string HealthCheck()
        {
            return "up";
        }

        [HttpPost]
        [Route("create")]
        public long Create()
        {
            var vehicleId = _vehicleService.Create();
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
