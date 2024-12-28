using AutoMapper;
using DataAccess.Abstract;
using DataAccess.DbContextEfCore;
using Entities;
using Entities.Infrastructer;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contract
{
    public class PersonRepository : Repository<EntityPerson> , IPersonRepository 
    {
        private IMapper _mapper;
        public PersonRepository(EntityFrameworkDbContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public List<EntityPersonDto> GetAllDtoPerson()
        {
            var personDto = new List<EntityPersonDto>();
            foreach (var item in GetAllPerson())
            {
                var section = _context.Set<EntitySection>()
                          .SingleOrDefault(x => x.EntitySectionId == item.EntitySectionId);
                var personssss = new EntityPersonDto 
                {
                    EntityPersonId = item.EntityPersonId,
                    EntitySectionId = item.EntitySectionId,
                    PersonName = item.PersonName,
                    PersonLastName = item.PersonLastName,
                    PersonSectionName = section.SectionName,
                    Role = item.Role,
                    CreateTime = item.CreateTime,
                    EntitySection = item.EntitySection
                };
                personDto.Add(personssss);
                
            }
                return personDto;
        }

        public List<EntityPerson> GetAllPerson()
        {
            return _context.Set<EntityPerson>().ToList();
        }


        public EntityPerson GetPerson(int Id)
        {
            return _context.Set<EntityPerson>().Where(x => x.EntityPersonId == Id).FirstOrDefault();
        }

        public async Task AsyncUpdateFile(EntityPerson entityPerson)
        {
            _context.Set<EntityPerson>().Update(entityPerson);
            await _context.SaveChangesAsync();
        }

        public async Task<EntityPerson> GetOnePersonForUserName(string UserName)
        {
            var PersonInfo = await _context.Set<EntityPerson>().FirstOrDefaultAsync(x => x.PersonName+x.PersonLastName == UserName);
            return PersonInfo;
        }

        public async Task<EntityPerson> GetPersonForFullName(string UserName)
        {
            var Person = await _context.Set<EntityPerson>().FirstOrDefaultAsync(x => x.PersonName+x.PersonLastName==UserName);
            return Person;
        }

        
    }
}