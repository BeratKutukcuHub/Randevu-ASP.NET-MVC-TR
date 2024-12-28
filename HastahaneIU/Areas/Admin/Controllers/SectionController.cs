using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HastahaneIU.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class SectionController : Controller
    {
        IManagerService _service;

        public SectionController(IManagerService service)
        {
            _service = service;
        }

        public IActionResult Index(int IdForSections = 0)
        {
            if(IdForSections != 0)
            {
            var selected = _service._repositoryManager._sectionRepository.SelectDepartmentForSection(IdForSections);
            return View(selected);
            }
            var sections = _service._sectionManager.GetAllSection();
            return View(sections);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FilterSections(int Id = 0)
        {
            return RedirectToAction("Index" , new { IdForSections = Id });
        }
        [HttpGet]
        public IActionResult AddSection()
        {
            ViewBag.departments = _service._departmentManager.GetAllDepartment();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddSection(EntitySection entitySection)
        {
            if(ModelState.IsValid)
            {
                _service._repositoryManager._sectionRepository.AddEntity(entitySection);
                return RedirectToAction("Index");
            }
            ViewBag.departments = _service._departmentManager.GetAllDepartment();
            return View(entitySection);
        }
        public IActionResult RemoveSection(int Id)
        {
            var perSection = _service._sectionManager.GetSection(Id);
            _service._repositoryManager._sectionRepository.RemoveEntity(perSection);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateSection(int Idies)
        {
            var perSection = _service._sectionManager.GetSection(Idies);
            ViewBag.departments = _service._departmentManager.GetAllDepartment();
            return View(perSection);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateSection(EntitySection entitySection)
        {
            if(ModelState.IsValid)
            {
            _service._repositoryManager._sectionRepository.UpdateEntity(entitySection);
            return RedirectToAction("Index");
            }
            return View();
        }
    }
}