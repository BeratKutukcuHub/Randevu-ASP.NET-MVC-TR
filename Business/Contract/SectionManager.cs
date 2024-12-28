using Business.Abstract;
using Entities;

namespace Business.Contract
{
    public class SectionManager : ISectionService
    {
        IRepositoryService _service;

        public SectionManager(IRepositoryService service)
        {
            _service = service;
        }

        public List<EntitySection> GetAllSection()
        {
            return _service._sectionRepository.GetAllSection();
        }

        public EntitySection GetSection(int Id)
        {
            return _service._sectionRepository.GetSection(Id);
        }
    }
}