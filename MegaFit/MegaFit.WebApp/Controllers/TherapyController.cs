using MegaFit.Business.TherapyPackagesManagers;
using MegaFit.DTOs.TherapyProcessDtos;
using Microsoft.AspNetCore.Mvc;

namespace MegaFit.WebApp.Controllers
{
    public class TherapyController : Controller
    {
        private readonly IPackageService _packageService;

        public TherapyController(IPackageService packageService)
        {
            _packageService = packageService;
        }

        public IActionResult Index()
        {
            var therapyList = _packageService.GetAll();
            return View(therapyList);
        }
        public IActionResult CreateTherapy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTherapy(TherapyDto therapyDto)
        {
            var therapy = _packageService.AddNewTherapy(therapyDto);
            return Json(therapy);
        }
    }
}
