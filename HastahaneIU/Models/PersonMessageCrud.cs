using Business.Abstract;
using Entities;
using HastahaneIU.Extensions;

namespace HastahaneIU.Models
{
    public class PersonMessageCrud
    {
        List<PersonMessageForAdmin>? _messages {get; set;} = new();
        private IManagerService _service;
        private ISession? _session {get; set;}
        public PersonMessageCrud(IManagerService service)
        {
            _service = service;
        }
        public static PersonMessageForAdmin GetCard(IServiceProvider options)
        {
            ISession? session = options.GetRequiredService<IHttpContextAccessor>().HttpContext?.Session;
            var message = session.GetJson<PersonMessageForAdmin>("1");
            return message;
        }
        public void AddMessage(int Id , string format)
        {
            EntityPerson personMessage = _service._personManager.GetPerson(Id);
            PersonMessageForAdmin? _person = new PersonMessageForAdmin()
            {
                Person = personMessage,
                Message = format,
            };
            _messages.Add(_person);
            _session.SetJson(Id.ToString() , format);
        }
    }
}