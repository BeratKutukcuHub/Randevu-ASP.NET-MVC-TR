using Entities;

namespace HastahaneIU.Models
{
    public class SelectDepartmentsForSection
    {
        public List<EntitySection> SectionList {get; set;}
        public IEnumerable<EntityDepartment> DepartmentsList {get; set;}
    }
}