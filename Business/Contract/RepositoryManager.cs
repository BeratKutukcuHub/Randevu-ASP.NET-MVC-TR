using Business.Abstract;
using DataAccess.Abstract;

namespace Business.Contract
{
    public class RepositoryManager : IRepositoryService
    {
        private IDepartmentRepository departmentRepository;
        private ISectionRepository sectionRepository;
        private IPersonRepository personRepository;
        private IAppointmentRepository appointmentRepository;

        public RepositoryManager(IDepartmentRepository departmentRepository, ISectionRepository sectionRepository, IPersonRepository personRepository, IAppointmentRepository appointmentRepository)
        {
            this.departmentRepository = departmentRepository;
            this.sectionRepository = sectionRepository;
            this.personRepository = personRepository;
            this.appointmentRepository = appointmentRepository;
        }

        public IDepartmentRepository _departmentRepository => departmentRepository;

        public ISectionRepository _sectionRepository => sectionRepository;

        public IPersonRepository _personRepository => personRepository;

        public IAppointmentRepository _appointmentRepository => appointmentRepository;
    }
}