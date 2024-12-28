using Entities;
using Microsoft.AspNetCore.Identity;

namespace HastahaneIU.Areas.Model
{
    public class UserAndRole
    {
        public IdentityUser User {get; set;}
        public string? Role {get; set;}
        public EntityPerson? PersonInfo {get; set;} = null;
        public string? SectionName {get; set;}
        public string? DepartmentName {get; set;}
    }
}