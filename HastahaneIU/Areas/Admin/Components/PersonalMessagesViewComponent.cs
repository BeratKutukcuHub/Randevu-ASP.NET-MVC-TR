using Business.Abstract;
using HastahaneIU.Areas.Personal.Models;
using Microsoft.AspNetCore.Mvc;

namespace HastahaneIU.Areas.Admin.Components
{
    public class PersonalMessagesViewComponent : ViewComponent
        
    {
        IManagerService _service;
        SessionMessage _session;
        public PersonalMessagesViewComponent(IManagerService service, SessionMessage session)
        {
            _service = service;
            _session = session;
        }

        public IViewComponentResult Invoke()
        {
            var personsMessages = _service._personManager.GetAllPerson();
            if(personsMessages is not null)
            {
                foreach(var item in personsMessages)
                {
                    var messages = _session.ListForMessage().Where(x => x.Person.EntityPersonId.Equals(item.EntityPersonId)).ToList();
                    return View(messages);
                }
            }
            return View();
        }
    }
}