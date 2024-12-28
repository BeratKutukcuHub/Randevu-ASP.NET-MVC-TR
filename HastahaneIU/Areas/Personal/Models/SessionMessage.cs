using Business.Abstract;
using Entities;
using HastahaneIU.Extensions;
using HastahaneIU.Models;

namespace HastahaneIU.Areas.Personal.Models
{
    public class SessionMessage
    {
        IManagerService _service;
        static List<PersonMessageForAdmin> SessionList {get; set;} = new();
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession? _mysession => _httpContextAccessor.HttpContext?.Session;
        public SessionMessage(IHttpContextAccessor httpContextAccessor, IManagerService service)
        {
            _httpContextAccessor = httpContextAccessor;
            _service = service;
        }

        public List<PersonMessageForAdmin> ListForMessage()
        {
            _mysession.GetJson<PersonMessageForAdmin>("PersonMessages");
            return SessionList;
        }
        public void Clear(int Id, string Message)
        {
            var PersonMessages = SessionList.Where(x => x.Person.EntityPersonId == Id).ToList();
            var Person = PersonMessages.First(x => x.Message == Message);
            Person.Message = null;
           
        }
       
        public void SetPerson(int Id , string Name)
        {
            EntityPerson person = _service._personManager.GetPerson(Id);
            PersonMessageForAdmin variable = new PersonMessageForAdmin()
            {
                Message = Name,
                Approve = true,
                Person = person
            };
            _mysession.SetJson<PersonMessageForAdmin>("PersonMessages", variable);
            SessionList.Add(variable);
        }
    }
}