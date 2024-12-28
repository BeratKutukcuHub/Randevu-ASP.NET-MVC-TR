namespace Entities.Dto
{
    public class UserDtoForCreate
    {
        public string UserName {get; set;}
        public string Password {get; set;}
        public string ConfirmPassword {get; set;}
        public HashSet<string> Roles {get; set;}
    }
}