using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Contract
{
    public class AppointmentManager : IAppointmentService
    {
        IAppointmentRepository _appointmentRepository;

        public AppointmentManager(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public IEnumerable<EntityAppointment> GetAllAppointment()
        {
            return _appointmentRepository.GetAllAppointment();
        }

        public EntityAppointment GetAppointment(int Id)
        {
            return _appointmentRepository.GetAppointment(Id);
        }

        public void RemoveAppointment(int Id)
        {
            _appointmentRepository.RemoveAppointment(Id);
        }

        public void SaveAppointment(EntityAppointment entityAppointment)
        {
            _appointmentRepository.SaveAppointment(entityAppointment);
            
        }

        public void UpdateAppointment(EntityAppointment entityAppointment)
        {
            _appointmentRepository.UpdateAppointment(entityAppointment);
        }
    }
}