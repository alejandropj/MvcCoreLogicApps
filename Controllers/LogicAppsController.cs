using Microsoft.AspNetCore.Mvc;
using MvcCoreLogicApps.Services;

namespace MvcCoreLogicApps.Controllers
{
    public class LogicAppsController : Controller
    {
        private ServiceLogicApps service;
        public LogicAppsController(ServiceLogicApps service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
