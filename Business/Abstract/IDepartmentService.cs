using Entities;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        EntityDepartment GetDepartment(int Id);
        IEnumerable<EntityDepartment> GetAllDepartment();
        
    }
}