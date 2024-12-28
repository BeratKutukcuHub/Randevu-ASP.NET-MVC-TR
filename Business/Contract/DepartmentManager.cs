
using Business.Abstract;
using Entities;

namespace Business.Contract
{
    public class DepartmentManager : IDepartmentService
    {
        IRepositoryService _repoServices;

        public DepartmentManager(IRepositoryService repoServices)
        {
            _repoServices = repoServices;
        }
        public IEnumerable<EntityDepartment> GetAllDepartment()
        {
            return _repoServices._departmentRepository.GetAllDepartments();
        }
        public EntityDepartment GetDepartment(int Id)
        {
            return _repoServices._departmentRepository.GetDepartment(Id);
        }
       
    }
}