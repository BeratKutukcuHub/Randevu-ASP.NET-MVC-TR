using Entities;
using Entities.Infrastructer;

namespace DataAccess.Abstract
{
    public interface IPersonRepository : IRepository<EntityPerson>
    {
        Task<EntityPerson> GetPersonForFullName(string UserName);
        EntityPerson GetPerson(int Id);
        List<EntityPerson> GetAllPerson();
        List<EntityPersonDto> GetAllDtoPerson();
        public Task AsyncUpdateFile(EntityPerson entityPerson);
        public Task<EntityPerson> GetOnePersonForUserName(string UserName);
    }
}