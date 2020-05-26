using System.Web.Http;
using System.Web.Mvc;
using VehicleSystem.Core.Models;
using VehicleSystem.Core.Services;

namespace VehicleSystem.Api.Controllers
{
    [System.Web.Mvc.RoutePrefix("vehicle")]
    public class VehicleController : Controller
    {
        public VehicleController()
        {
        }

        [System.Web.Mvc.HttpGet]
        public string HealthCheck()
        {
            return "up";
        }

        [System.Web.Mvc.HttpPost]
        [System.Web.Mvc.Route("create")]
        public long Create(VehicleModel vehicle)
        {
            var vehicleId = new VehicleService().Create(vehicle);
            return vehicleId;
        }


        [System.Web.Mvc.HttpPut]
        [System.Web.Mvc.Route("update/{id:long}")]
        public bool Update([FromUri]long id, VehicleModel vehicle)
        {
            return new VehicleService().Update(id, vehicle); ;
        }

        [System.Web.Mvc.HttpDelete]
        [System.Web.Mvc.Route("delete/{id:long}")]
        public bool Delete([FromUri] long id)
        {
            return new VehicleService().Delete(id);
        }
    }
}
