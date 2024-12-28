using Entities;

namespace DataAccess.Abstract
{
    public interface IDepartmentRepository : IRepository<EntityDepartment>
    {
        EntityDepartment GetDepartment(int Id);
        List<EntityDepartment> GetAllDepartments();
        
    }
}