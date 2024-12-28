
using Business.Abstract;

namespace Business.Contract
{
    public class ServiceManager : IManagerService
    {
        private IDepartmentService departmentService;
        private ISectionService sectionService;
        private IPersonService personService;
        private IRepositoryService _repositoryService;
        private IAppointmentService _appointmentService;
        private IAuthService _authService;

        public ServiceManager(IDepartmentService departmentService, ISectionService sectionService, IPersonService personService, IRepositoryService repositoryService, IAuthService authService, IAppointmentService appointmentService)
        {
            this.departmentService = departmentService;
            this.sectionService = sectionService;
            this.personService = personService;
            _repositoryService = repositoryService;
            _authService = authService;
            _appointmentService = appointmentService;
        }

        public IDepartmentService _departmentManager => departmentService;

        public ISectionService _sectionManager => sectionService;
        public IPersonService _personManager => personService;

        public IRepositoryService _repositoryManager => _repositoryService;

        public IAuthService _authManager => _authService;

        public IAppointmentService _appointmentManager => _appointmentService;
    }
}