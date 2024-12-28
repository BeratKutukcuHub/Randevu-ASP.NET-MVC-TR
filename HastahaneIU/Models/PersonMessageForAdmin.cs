using Entities;

namespace HastahaneIU.Models
{
    public class PersonMessageForAdmin
    {
        public EntityPerson Person {get; set;}
        public string Message {get; set;}
        public bool Approve {get; set;} = false;
    }
}