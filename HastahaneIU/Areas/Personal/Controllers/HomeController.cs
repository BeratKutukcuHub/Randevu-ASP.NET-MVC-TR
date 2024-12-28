using Business.Abstract;
using Entities;
using Entities.Dto;
using HastahaneIU.Areas.Personal.Models;
using HastahaneIU.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HastahaneIU.Areas.Personal.Controllers
{
    [Authorize(Roles = "Personal")]
    [Area("Personal")]
    public class HomeController : Controller
    {
        IManagerService _service;
        public HomeController(IManagerService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var userInfo = await _service._authManager.GetOneUser(User.Identity.Name);
            var person = await _service._repositoryManager._personRepository.GetPersonForFullName(User.Identity.Name);
            ViewBag.Appointment = _service._appointmentManager.GetAllAppointment().Where(x => x.EntitySectionId == person.EntitySectionId).Count();
            
            ViewBag.SectionName = _service._sectionManager.GetSection(person.EntitySectionId).SectionName;
            UserAndPerson Model = new UserAndPerson()
            {
                User = userInfo,
                Person = person
            };
            return View(Model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetAppointments(int entityPersonId)
        {
            return View("GetAppointments",new {entityperson = entityPersonId});
        }
        [HttpGet]
        public IActionResult UpdatePassword(string UserName)
        {
            return View(new {UserName = UserName});
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdatePassword(string UserName, 
        string BeforePassword, string NextPassword, string ConfirmPassword)
        {
            if(NextPassword == ConfirmPassword)
            {
                 if(await _service._authManager.PasswordCheck(UserName ,BeforePassword))
                {
                await _service._authManager.UpdateUserNameAsync(UserName, NextPassword);
                    return RedirectToAction("Index");
                }   
                return View();
            }
            return View();
        }
    }
}