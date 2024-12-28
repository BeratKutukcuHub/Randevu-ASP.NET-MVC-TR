namespace Entities
{
    public class EntitySection 
    {
        public int EntitySectionId { get; set; }
        public EntityDepartment? EntityDepartment { get; set; }
        public int EntityDepartmentId { get; set; }
        public string SectionName { get; set; }
        public List<EntityPerson> Persons { get; set; } = new();
    }
}