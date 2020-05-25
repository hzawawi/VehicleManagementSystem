using System.Web.Mvc;

namespace VehicleSystem.Api.Controllers
{
    [RoutePrefix("api/vehicle")]
    public class VehicleController : Controller
    {
        public string HealthCheck()
        {
            return "up";
        }
    }
}
