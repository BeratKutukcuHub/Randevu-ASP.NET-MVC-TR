using Entities;

namespace DataAccess.Abstract
{
    public interface ISectionRepository : IRepository<EntitySection>
    {
        public EntitySection GetSection(int Id);
        public List<EntitySection> GetAllSection();
        public List<EntitySection> SelectDepartmentForSection(int Id);
    }
}