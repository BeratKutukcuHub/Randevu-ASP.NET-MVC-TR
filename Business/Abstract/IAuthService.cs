using Entities.Dto;
using Microsoft.AspNetCore.Identity;

namespace Business.Abstract
{
    public interface IAuthService 
    {
        public Task<bool> PasswordCheck(string User,string Password);
        public Task UpdateUserNameAsync(string User,string Password);
        public Task<IdentityUser> GetUserForId(string Id);
        public Task<string> GetUserRole(string UserName);
        public Task<IEnumerable<IdentityUser>> GetAllUserAsync();
        public Task<IdentityResult> CreateUser(UserDtoForCreate UserInfo);
        public Task UpdateUser(UserDtoForCreate UserName);
        public Task<IdentityResult> RemoveUser(string UserName);
        public IEnumerable<IdentityUser> GetAllUsers();
        public Task<IdentityUser> GetOneUser(string UserName);
    }
}