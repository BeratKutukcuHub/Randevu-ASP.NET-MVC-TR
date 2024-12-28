using Business.Abstract;
using Entities;

namespace Business.Contract
{
    public class PersonManager : IPersonService
    {
        IRepositoryService _service;

        public PersonManager(IRepositoryService service)
        {
            _service = service;
        }

        public IEnumerable<EntityPerson> GetAllPerson()
        {
            return _service._personRepository.GetAllPerson();
        }

        public EntityPerson GetPerson(int Id)
        {
            return _service._personRepository.GetPerson(Id);
        }

        
    }
}