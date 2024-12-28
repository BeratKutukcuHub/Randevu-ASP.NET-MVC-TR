using Business.Abstract;
using Entities;
using HastahaneIU.Areas.Personal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HastahaneIU.Areas.Personal.Controllers
{
    [Authorize(Roles = "Personal")]
    [Area("Personal")]
    public class SessionController : Controller
    {
        SessionMessage _messageOrMessages;
        IManagerService _services;

        public SessionController(SessionMessage messageOrMessages, IManagerService services)
        {
            _messageOrMessages = messageOrMessages;
            _services = services;
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SetMessage(int Id , string format)
        {
            if(format != null)
            {
                _messageOrMessages.SetPerson(Id, format);
            }
            return RedirectToAction("Message","Personal",new {Id = Id});
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MyGetMessagesForAdmin(int Id)
        {
            var messagesListed = _messageOrMessages.ListForMessage().Where(x => x.Person.EntityPersonId == Id).ToList();
            return View(messagesListed);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Clear(int Id , string Message)
        {
            _messageOrMessages.Clear(Id, Message);
            var messagesListed = _messageOrMessages.ListForMessage().Where(x => x.Person.EntityPersonId == Id).ToList();
            return View("MyGetMessagesForAdmin", messagesListed);
        }
    }
}