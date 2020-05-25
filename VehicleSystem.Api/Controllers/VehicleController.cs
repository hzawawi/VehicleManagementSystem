using System.Web.Mvc;

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
    }
}
