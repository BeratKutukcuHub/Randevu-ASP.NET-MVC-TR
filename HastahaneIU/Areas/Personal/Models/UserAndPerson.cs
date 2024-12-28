using Entities;
using Microsoft.AspNetCore.Identity;

namespace HastahaneIU.Areas.Personal.Models
{
    public class UserAndPerson
    {
        public IdentityUser User {get; set;}
        public EntityPerson Person {get; set;}
    }
}