using MegaFit.Business.AppointmentHourManagers;
using MegaFit.Business.CustomerDetailsManagers;
using MegaFit.Business.CustomerHistoryManagers;
using MegaFit.Business.CustomerManagers;
using MegaFit.Business.DealAppointmentManagers;
using MegaFit.Business.TherapyPackagesManagers;
using MegaFit.DTOs.CustomerProcessDtos;
using MegaFit.DTOs.DealAppointmentProcessDtos;
using MegaFit.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MegaFit.WebApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly ICustomerVisitService _customerVisitService;
        private readonly ICustomerAssessmentService _customerAssessmentService;
        private readonly IPackageService _packageService;
        private readonly IAppointmentHourService _appointmentHourService;
        private readonly IDealService _dealService;

        public CustomerController(
            ICustomerService customerService,
            ICustomerVisitService customerVisitService,
            ICustomerAssessmentService customerAssessment,
            IPackageService packageService,
            IAppointmentHourService appointmentHourService,
            IDealService dealService)
        {
            _customerService = customerService;
            _customerVisitService = customerVisitService;
            _customerAssessmentService = customerAssessment;
            _packageService = packageService;
            _appointmentHourService = appointmentHourService;
            _dealService = dealService;
        }

        public IActionResult Index()
        {
            var infos = _customerAssessmentService.GetAllInfos();
            return View(infos);
        }
        public IActionResult Create()
        {
            if (TempData["Hata"] != null)
            {
                ViewBag.Error = TempData["Hata"];
            }
            return View();
        }
        [HttpPost]
        public IActionResult Create(CustomerDto dto)
        {
            if (dto == null)
            {
                return View();
            }
            var customerId = _customerService.Create(dto);
            return RedirectToAction("AddCustomerDetails", new {customerId});
        }
        public IActionResult AddCustomerDetails(int customerId)
        {
            if ( customerId != 0)
            {
                ViewBag.CustomerKimlik = customerId;
                return View();
            }
            TempData["Hata"] = "Danışan eklemeden diğer işlemleri yapamazsınız"; 
            return RedirectToAction("Create");
        }
        [HttpPost]
        public IActionResult AddCustomerDetails(CustomerVisitDto dto) 
        {
            if (dto==null)
            {
                return View();
            }
            var customerVisitId = _customerVisitService.Create(dto);
            return RedirectToAction("AddCustomerAssessment", new { customerVisitId });
        }
        public IActionResult AddCustomerAssessment(int customerVisitId)
        {
            if (customerVisitId != 0)
            {
                ViewBag.CustomerVisitKimlik = customerVisitId;
            }
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomerAssessment(CustomerAssessmentDto dto)
        {
            if (dto == null)
            {
                return View();
            }
            var assessmentId = _customerAssessmentService.Create(dto);
            return RedirectToAction("SelectDeal", new {assessmentId});
        }
        public IActionResult SelectDeal(int assessmentId)
        {
            var values = _packageService.GetAll();
            ViewBag.Packs = new SelectList(values,"Id","Package");
            var hours = _appointmentHourService.GetAll();
            ViewBag.Hours = new SelectList(hours, "Id", "Hour");
            ViewBag.Assessment = assessmentId;
            return View();
        }
        [HttpPost]
        public IActionResult SelectDeal(DealDto dto)
        {
            if(dto == null)
            {
                return NotFound();
            }
            _dealService.DealDone(dto);
            return RedirectToAction("Index","Appointment");

        }
        public IActionResult AddDealExistedCustomer()
        {
            var customers = _customerAssessmentService.GetBasicInfos();
            ViewBag.Customers = new SelectList(customers, "CustomerAssessmentId", "CustomerFullName");
            var values = _packageService.GetAll();
            ViewBag.Packs = new SelectList(values, "Id", "Package");
            var hours = _appointmentHourService.GetAll();
            ViewBag.Hours = new SelectList(hours, "Id", "Hour");

            return View();
        }
        public IActionResult ViewDetail(int id)
        {
            var result = _customerAssessmentService.GetDetails(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var result = _dealService.Delete(id);
            return Json(result);
        }



    }
}





