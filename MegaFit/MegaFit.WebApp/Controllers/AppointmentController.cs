using MegaFit.Business.DealAppointmentManagers;
using Microsoft.AspNetCore.Mvc;

namespace MegaFit.WebApp.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IDealService _dealService;

        public AppointmentController(IDealService dealService)
        {
            _dealService = dealService;
        }

        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult GetAppointments()
        {
            var data = _dealService.GetAppointmentSummaries();
            return Json(data);
        }
        
        public IActionResult MakeCompleted(int id)
        {
            _dealService.GetCompleted(id);
            return RedirectToAction("GetAppointments");
        }

    }
}
