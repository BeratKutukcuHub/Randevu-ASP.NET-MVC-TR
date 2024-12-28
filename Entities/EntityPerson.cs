using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Dto;

namespace Entities
{
    public class EntityPerson
    {
        [Key]
        public int EntityPersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonLastName { get; set; }
        public EntitySection? EntitySection {get; set;} 
        public int EntitySectionId { get; set; }
        public string Role {get; set;}
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public string? Age { get; set; } = string.Empty;
        public string? ProfileImage {get; set;}    
        public string? E_Mail { get; set; } = string.Empty;
        public string? SocialMedia1 { get; set; } = string.Empty;
        public string? SocialMedia2 { get; set; } = string.Empty;
        public bool? Active { get; set; } = true;
        [NotMapped]
        public RegisterDto? RegisterDto {get; set;} = null;

    }
}