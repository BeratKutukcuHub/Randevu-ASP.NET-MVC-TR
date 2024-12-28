using Entities;

namespace Business.Abstract
{
    public interface ISectionService 
    {
        List<EntitySection> GetAllSection();
        EntitySection GetSection(int Id);
    }
}