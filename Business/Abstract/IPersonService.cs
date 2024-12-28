using Entities;

namespace Business.Abstract
{
    public interface IPersonService 
    {
        IEnumerable<EntityPerson> GetAllPerson();
        EntityPerson GetPerson(int Id);

    }
}