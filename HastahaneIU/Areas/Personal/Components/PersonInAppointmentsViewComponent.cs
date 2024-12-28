using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace HastahaneIU.Areas.Personal.Components
{
    public class PersonInAppointmentsViewComponent : ViewComponent
    {
        IManagerService _service;

        public PersonInAppointmentsViewComponent(IManagerService service)
        {
            _service = service;
        }

        public IViewComponentResult Invoke(int entityPersonId)
        {
            var appointment = _service._appointmentManager.GetAllAppointment()
            .Where(x => x.EntitySectionId == entityPersonId)
            .ToList();
            return View(appointment);
        }
    }
}