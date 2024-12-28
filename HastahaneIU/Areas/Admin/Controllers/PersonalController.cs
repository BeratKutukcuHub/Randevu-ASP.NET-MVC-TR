using Business.Abstract;
using Entities;
using Entities.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HastahaneIU.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class PersonalController : Controller
    {
        UserManager<IdentityUser> _role;
        SignInManager<IdentityUser> _signIn;
        IManagerService _service;

        public PersonalController(IManagerService service, UserManager<IdentityUser> role, SignInManager<IdentityUser> signIn)
        {
            _service = service;
            _role = role;
            _signIn = signIn;
        }

        public IActionResult Index()
        {
            var item = _service._repositoryManager._personRepository.GetAllDtoPerson();
           
            return View(item);
        }     
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Sections = _service._sectionManager.GetAllSection();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(EntityPerson entityPerson)
        {
            entityPerson.ProfileImage = "/Images/default.png";
            await _service._repositoryManager._personRepository.AddAsyncEntityAsync(entityPerson);
            entityPerson.RegisterDto = new RegisterDto()
            {
                UserName = entityPerson.PersonName+entityPerson.PersonLastName,
                Password = "Personal1"
            };
            if(ModelState.IsValid)
            {
                await _service._authManager.CreateUser(new UserDtoForCreate()
                {
                    Password = "Personal1",
                    UserName = entityPerson.PersonName+entityPerson.PersonLastName,
                    Roles = new HashSet<string>(){"Personal"}
                });
                var getAPerson = _service._authManager.GetOneUser(entityPerson.PersonName+entityPerson.PersonLastName);
                await _role.AddToRoleAsync(await getAPerson, "Personal");
                return RedirectToAction("Index");
            }
            return View();
            
        } 
        public IActionResult Remove(int Id)
        {
            EntityPerson person =  _service._personManager.GetPerson(Id);
            _service._repositoryManager._personRepository.RemoveEntity(person);
            _service._authManager.RemoveUser(person.PersonName+person.PersonLastName);
            return RedirectToAction("Index");
        }    
        [HttpGet]
        public IActionResult Update(int Id)
        {
            EntityPerson person =  _service._personManager.GetPerson(Id);
            ViewBag.Sections = _service._sectionManager.GetAllSection();
            return View(person);
        } 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(EntityPerson entity)
        {
            _service._repositoryManager._personRepository.UpdateEntity(entity);
            return RedirectToAction("Index");
        }
        
    }
}