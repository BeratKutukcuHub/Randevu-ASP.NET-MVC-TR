using DataAccess.Abstract;

namespace Business.Abstract
{
    public interface IRepositoryService 
    {
        IDepartmentRepository _departmentRepository {get;}
        ISectionRepository _sectionRepository {get;}
        IPersonRepository _personRepository {get;}
        IAppointmentRepository _appointmentRepository {get;}
    }
}