using DataAccess.Abstract;
using DataAccess.DbContextEfCore;
using Entities;

namespace DataAccess.Contract
{
    public class DepartmentRepository : Repository<EntityDepartment> , IDepartmentRepository 
    {
        public DepartmentRepository(EntityFrameworkDbContext context) : base(context)
        {
            
        }

        public List<EntityDepartment> GetAllDepartments()
        {
            return _context.Set<EntityDepartment>().ToList();
        }


        public EntityDepartment GetDepartment(int Id)
        {
            return _context.Set<EntityDepartment>().FirstOrDefault(x => x.EntityDepartmentId.Equals(Id));
        }
    }
}