namespace Business.Abstract
{
    public interface IManagerService
    {
        IDepartmentService _departmentManager {get;}
        ISectionService _sectionManager {get;}
        IPersonService _personManager {get;}
        IRepositoryService _repositoryManager {get;}
        IAuthService _authManager {get;}
        IAppointmentService _appointmentManager {get;}
    }
}