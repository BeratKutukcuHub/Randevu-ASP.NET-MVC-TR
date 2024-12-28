using Business.Abstract;
using Entities.Dto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HastahaneIU.Controllers
{
    public class AccountRegisterController : Controller
    {
        private SignInManager<IdentityUser> _signIn;
        private IManagerService _manager;

        public AccountRegisterController(SignInManager<IdentityUser> singIn, IManagerService manager)
        {
            _signIn = singIn;
            _manager = manager;
            
        }

        public IActionResult Login()
        {
            return View(new RegisterDto());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(RegisterDto RegisterLogin)
        {
            await _signIn.SignOutAsync();
            var user = await _manager._authManager.GetOneUser(RegisterLogin.UserName);
            var result = await _signIn.PasswordSignInAsync(user, RegisterLogin.Password,false,false);
            if(!result.Succeeded)
            {
                return View();
            }
            
            return RedirectToAction("Index","Home");
        }
        [HttpGet]
        public IActionResult CreateUser()
        {
            return View(new UserDtoForCreate()
            {
                Roles = new HashSet<string>(){"User"}
            });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUser(UserDtoForCreate User)
        {
            if(User.Password == User.ConfirmPassword)
            {
                User.Roles = new HashSet<string>(){"User"};
                var result = await _manager._authManager.CreateUser(User);
                if(!result.Succeeded)
                {
                    return View("Login");
                }
                return RedirectToAction("Index","Home");
            }
            
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await _signIn.SignOutAsync();
            return RedirectToAction("Index","Home");
        }
    }
}