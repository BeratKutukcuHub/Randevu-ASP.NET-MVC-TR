using Business.Abstract;
using Entities;
using HastahaneIU.Areas.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HastahaneIU.Areas.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        IManagerService _service;
        public UserController(IManagerService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
        var users = await _service._authManager.GetAllUserAsync();
        var userRoleList = new List<UserAndRole>();
        foreach(var user in users)
        {
        var role = await _service._authManager.GetUserRole(user.UserName);
        
            UserAndRole userRoleModel = new UserAndRole()
        {
            User = user,
            Role = role,
            PersonInfo = role == "Personal"? 
            await _service._repositoryManager._personRepository.GetOnePersonForUserName(user.UserName)
            : default
        };
        userRoleList.Add(userRoleModel);
        }

        return View(userRoleList);
        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetUser(string Id)
        {
            var _user = await _service._authManager.GetUserForId(Id);
            var person = await _service._repositoryManager._personRepository.GetPersonForFullName(_user.UserName);
            var isRole = await _service._authManager.GetUserRole(_user.UserName);
                return View("GetUser",new UserAndRole()
                {
                    User = _user,
                    Role = isRole,
                    PersonInfo = person != null? person : default,
                    DepartmentName = person != null? _service._sectionManager.GetSection(person.EntitySectionId).SectionName : default,
                    SectionName = person != null? _service._departmentManager.GetDepartment(person.EntitySection.EntityDepartmentId).DepartmentName : default 
                });
        }
       
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetRemove(string Id)
        {
            var User = await _service._authManager.GetUserForId(Id); // Get
            if(await _service._repositoryManager._personRepository.GetPersonForFullName(User.UserName) is not null)
            {
                var Person = await _service._repositoryManager._personRepository.GetPersonForFullName(User.UserName);
                _service._repositoryManager._personRepository.RemoveEntity(Person);
                await _service._authManager.RemoveUser(User.UserName);
            }
            else
            {
                await _service._authManager.RemoveUser(User.UserName);
            }
            return RedirectToAction("Index");
        }
    }
}