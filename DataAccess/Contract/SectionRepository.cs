using DataAccess.Abstract;
using DataAccess.DbContextEfCore;
using Entities;

namespace DataAccess.Contract
{
    public class SectionRepository : Repository<EntitySection>, ISectionRepository
    {
        public SectionRepository(EntityFrameworkDbContext context) : base(context)
        {
        }
        List<EntitySection> ISectionRepository.GetAllSection()
        {
            return _context.Set<EntitySection>().ToList();
        }

        EntitySection ISectionRepository.GetSection(int Id)
        {
            return _context.Set<EntitySection>().FirstOrDefault(x => x.EntitySectionId.Equals(Id));
        }
        public List<EntitySection> SelectDepartmentForSection(int Id)
        {
            return _context.Sections.Where(x => x.EntityDepartmentId == Id).ToList();
        }
    }
}