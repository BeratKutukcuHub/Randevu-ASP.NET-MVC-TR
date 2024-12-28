using Business.Abstract;
using Entities;
using HastahaneIU.Extensions;
using HastahaneIU.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HastahaneIU.Areas.Personal.Controllers
{
    [Authorize(Roles = "Personal")]
    [Area("Personal")]
    public class PersonalController : Controller
    {
        private PersonMessageCrud _personMessageCrud;
        private IManagerService _service;

        public PersonalController(IManagerService service, PersonMessageCrud personMessageCrud)
        {
            _service = service;
            _personMessageCrud = personMessageCrud;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Message(int Id)
        {
            var personel = _service._personManager.GetPerson(Id);
            return View(personel);
        }
        [HttpGet]
        public async Task<IActionResult> Update()
        {
            var personel = await _service._repositoryManager._personRepository.GetPersonForFullName(User.Identity.Name);
            return View(personel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(EntityPerson person , IFormFile file, string files)
        {
            
            
                if(file is not null)
                {
                    string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images");
                string uniqueFileName = file.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                    person.ProfileImage = "/Images/"+file.FileName;
                }
                     await _service._repositoryManager._personRepository.AsyncUpdateFile(person);
                return RedirectToAction("Index");
                }
                else 
                {
                    person.ProfileImage = files;
                    await _service._repositoryManager._personRepository.AsyncUpdateFile(person);
                return View(person);
                }
                
            }
            
    }
}
