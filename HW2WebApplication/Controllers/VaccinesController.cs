using HW2WebApplication.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW2WebApplication.Controllers
{
    public class VaccinesController : Controller
    {
        
        private readonly IVaccineService _vaccineService;

        public VaccinesController(IVaccineService vaccineService)
        {
            _vaccineService = vaccineService;
        }

        public IActionResult Index()
        {
            return View();

        }
        public IActionResult VaccineListDetails()
        {
            return View(_vaccineService.GetVaccine());
            
        }
       

       /* public IActionResult Details(int id)
        {
            return View(_vaccineService.GetVaccine(id));
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

       /* [HttpPost]
        public IActionResult Add(Vaccine vaccine)
        {
            _vaccineService.AddEmployee(employee);
            return RedirectToAction("Index");
        }*/

       /* [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Supervisors = _vaccineService.GetEmployees()
                .Where(e => e.Id != id)
                .Select(e => new SelectListItem(e.Name, e.Id.ToString()))
                .ToList();
            return View(_vaccineService.GetEmployee(id));
        }*/

       /* [HttpPost]
        public IActionResult Edit(int id, Vaccine update)
        {
            var employee = _vaccineService.GetEmployee(id);
            employee.Name = update.Name;
            employee.DateHired = update.DateHired;
            employee.SupervisorId = update.SupervisorId;
            _vaccineService.SaveChanges();
            return RedirectToAction("Index");
        }*/
    }
}

