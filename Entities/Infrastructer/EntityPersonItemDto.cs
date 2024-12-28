namespace Entities.Infrastructer
{
    public class EntityPersonItemDto : EntityPerson
    {
        public int EntityPersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonLastName { get; set; }
        public EntitySection? EntitySection {get; set;} 
        public int EntitySectionId { get; set; }
        public string Role {get; set;}
        public DateTime CreateTime { get; set; }
        public string? Age { get; set; }
        public string? ProfileImage {get; set;}
        public string? E_Mail { get; set; }
        public string? SocialMedia1 { get; set; }
        public string? SocialMedia2 { get; set; }
        public bool Active { get; set; } = true;
    }
}