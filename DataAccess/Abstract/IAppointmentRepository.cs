using Entities;

namespace DataAccess.Abstract
{
    public interface IAppointmentRepository : IRepository<EntityAppointment>
    {
        public IEnumerable<EntityAppointment> GetAllAppointment();
        public EntityAppointment GetAppointment(int Id);
        public void SaveAppointment(EntityAppointment entityAppointment);
        public void UpdateAppointment(EntityAppointment entityAppointment);
        public void RemoveAppointment(int Id);
    }
}