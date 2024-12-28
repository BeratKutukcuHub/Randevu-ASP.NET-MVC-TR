using AutoMapper;
using Business.Abstract;
using Entities.Dto;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Business.Contract
{
    public class AuthManager : IAuthService
    {
        private UserManager<IdentityUser> _userManager;
        private IMapper _mapper;

        public AuthManager(UserManager<IdentityUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
            
        }

        public async Task<IdentityResult> CreateUser(UserDtoForCreate UserInfo)
        {
            var user = _mapper.Map<IdentityUser>(UserInfo);            
            var result = await _userManager.CreateAsync(user, UserInfo.Password);
            
            if(!result.Succeeded)
            {
                throw new Exception("Hata, Kayıt Gerçekleşmedi.");
            }
            if(UserInfo.Roles.Count > 0)
            {
                if(UserInfo.Roles.First() == "Personal" )
                {
                    var rolePersonResult = await _userManager.AddToRoleAsync(user, "Personal");
                    if(!rolePersonResult.Succeeded)
                    {
                    throw new Exception("Hata, Rol Hastaı Mevcuttur.");
                    }   
                }
                else if(UserInfo.Roles.First() == "User" )
                {
                    var roleResult = await _userManager.AddToRoleAsync(user, "User");
                    if(!roleResult.Succeeded)
                    {
                    throw new Exception("Hata, Rol Hastaı Mevcuttur.");
                    }
                }
                else
                {
                    var roleResult = await _userManager.AddToRoleAsync(user, "Admin");
                    if(!roleResult.Succeeded)
                    {
                    throw new Exception("Hata, Rol Hastaı Mevcuttur.");
                    }
                }
                
            }
            return result;
        }
        public async Task<string> GetUserRole(string UserName)
        {
            var User =await GetOneUser(UserName);
            var IsRole = await _userManager.GetRolesAsync(User);
            return IsRole.First();
        }
        public  IEnumerable<IdentityUser> GetAllUsers()
        {
            return  _userManager.Users.ToList();
        }
        public async Task<IEnumerable<IdentityUser>> GetAllUserAsync()
        {
            return await _userManager.Users.ToListAsync();
        }
        public async Task<IdentityUser> GetOneUser(string UserName)
        {
            return await _userManager.FindByNameAsync(UserName);
        }

        public async Task<IdentityResult> RemoveUser(string UserName)
        {
            IdentityUser user = await GetOneUser(UserName);
            var result = await _userManager.DeleteAsync(user);
            if(!result.Succeeded)
            {
                throw new Exception("Silinemedi, Bir Sorunla Karşılaşıldı.");
            }
            return result;
        }
        public async Task<IdentityUser> GetUserForId(string Id)
        {
            var User = await _userManager.FindByIdAsync(Id.ToString());
            return User;
        }
        public async Task UpdateUser(UserDtoForCreate UserName)
        {
            var getUser = await GetOneUser(UserName.UserName);
            var user = _mapper.Map<IdentityUser>(UserName);
            if(getUser is not null)
            {
                var result = await _userManager.UpdateAsync(user);
                

                if(!result.Succeeded)
                {
                throw new Exception("Güncellenemedi, Bir Sorun Mevcut");
                }
            }
        }
        public async Task<bool> PasswordCheck(string User,string Password)
        {
            var user = await GetOneUser(User);
            return await _userManager.CheckPasswordAsync(user, Password);
            
        } 
        public async Task UpdateUserNameAsync(string User, string Password)
        {
            var user = await _userManager.FindByNameAsync(User);
            await _userManager.RemovePasswordAsync(user);
            await _userManager.AddPasswordAsync(user, Password);
        }  
    }
}