using DataAccess.Abstract;
using DataAccess.DbContextEfCore;
using Entities;

namespace DataAccess.Contract
{
    public class AppointmentRepository : Repository<EntityAppointment>, IAppointmentRepository
    {
        public AppointmentRepository(EntityFrameworkDbContext context) : base(context)
        {
        }

        public IEnumerable<EntityAppointment> GetAllAppointment()
        {
            return _context.Set<EntityAppointment>().ToList();
        }

        public EntityAppointment GetAppointment(int Id)
        {
            return _context.Set<EntityAppointment>().SingleOrDefault(x => x.EntityAppointmentId.Equals(Id));
        }

        public void RemoveAppointment(int Id)
        {
            var Appointment = GetAppointment(Id);
            _context.Set<EntityAppointment>().Remove(Appointment);
            _context.SaveChanges();
        }

        public void SaveAppointment(EntityAppointment entityAppointment)
        {
            _context.Set<EntityAppointment>().Add(entityAppointment);
            _context.SaveChanges();
        }

        public void UpdateAppointment(EntityAppointment entityAppointment)
        {
            _context.Set<EntityAppointment>().Update(entityAppointment);
            _context.SaveChanges();
        }
    }
}