using Business.Abstract;
using HastahaneIU.Areas.Personal.Models;
using HastahaneIU.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HastahaneIU.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class HomeController : Controller
    {
        SessionMessage _session;
        IManagerService _service;
        public HomeController(SessionMessage session, IManagerService service)
        {
            _session = session;
            _service = service;
        }

        public IActionResult Index()
        {
            var departments = _service._departmentManager.GetAllDepartment();
            var departs = departments.Where(x => x.EntityDepartmentId < 4).ToList();
            var sections = _service._sectionManager.GetAllSection();
            var section = sections.Where(x => x.EntitySectionId < 4).ToList();
            var persons = _service._personManager.GetAllPerson();
            var person = persons.Where(x => x.EntityPersonId < 4).ToList();
            var users = _service._authManager.GetAllUsers();
            var user = users.Take(4);
            return View(new{departments = departments,
             departmentsInfo = departs ,
              sections = sections,
              sectionInfo = section,
               persons = persons,
               personInfo = person,
                users = users,
                userInfo = user
            });
        }
        [HttpGet]
        public IActionResult GetMessagesForAdmin()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetMessagesForAdmin(int Id)
        {
            PersonMessageForAdmin personMessage = _session.ListForMessage()[Id];
            personMessage.Approve = false;
            return RedirectToAction("Index");
        }
        
    }
}