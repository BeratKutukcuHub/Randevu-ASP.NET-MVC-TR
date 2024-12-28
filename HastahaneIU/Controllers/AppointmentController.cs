using AutoMapper;
using Business.Abstract;
using Entities;
using HastahaneIU.Models;
using Microsoft.AspNetCore.Mvc;

namespace HastahaneIU.Controllers
{
    public class AppointmentController : Controller
    {
        List<SectionAndDepartmentInclude> SectionDepartment {get; set;} = new();
        DateModelForAppointmentCrud _model;
        IManagerService _service;
        IMapper _mapper;

        public AppointmentController(IManagerService service, DateModelForAppointmentCrud model, IMapper mapper)
        {
            _service = service;
            _model = model;
            _mapper = mapper;
        }
        public void SetAppointment(DateModelForAppointment Model , DateTime Date)
        {
            EntityAppointment appointment = _mapper.Map<EntityAppointment>(Model);
            appointment.DateInAppointment = Date;
            appointment.UserName = User.Identity.Name;
            _service._appointmentManager.SaveAppointment(appointment);
        }
        [HttpGet]
        public IActionResult Index(DateModelForAppointment Model)
        {
            ViewBag.Departments = _service._departmentManager.GetAllDepartment();
            ViewBag.Sections = _service._repositoryManager._sectionRepository.SelectDepartmentForSection(Model.EntityDepartmentId);
            ViewBag.ThisModel = _model.MonthAndDateList(Model);
            return View(Model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Appointment(DateModelForAppointment Model , int EntityDepartmentId, int EntitySectionId , int MonthId , int DayId , int HourId, string Forms , int MinuteId)
        {
            DateModelForAppointment DateModel = new DateModelForAppointment()
            {
                EntityDepartmentId = Forms is "form1"?  EntityDepartmentId : Model.EntityDepartmentId,
                EntitySectionId = Forms is "form3"? EntitySectionId : Model.EntitySectionId,
                DayId =  Forms is "form3"? DayId : Model.DayId,
                MonthId = Forms is "form2"? MonthId : Model.MonthId ,
                HourId = Forms is "form4"? HourId : Model.HourId,
                MinuteId = Forms is "form5"? MinuteId : Model.MinuteId
            };
            
            if(Forms == "formfinish")
            {
               
                if(Model.EntitySectionId != 0 && Model.DayId != 0 && Model.HourId !=0 && Model.MinuteId != 0)
                {
                    double decimalPart = Model.HourId - (int)Model.HourId; 
                    int Minute = decimalPart > 0 ? 30 : 0;
                    var Date = new DateTime(DateTime.Today.Year, Model.MonthId , Model.DayId , Model.HourId, Model.MinuteId , 0);
                    Console.WriteLine(Date);
                    SetAppointment(Model, Date);
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    return RedirectToAction("Index",DateModel);
                }
            }
            return RedirectToAction("Index",DateModel);
        }
        [HttpGet]
        public IActionResult GetAppointment()
        {   
            
            IEnumerable<EntityAppointment> List = 
            _service._appointmentManager.GetAllAppointment().Where(x => x.UserName == User.Identity.Name).ToList();
            
            foreach(var item in List)
            {
                var DepartmentName = _service._departmentManager.GetDepartment(item.EntityDepartmentId).DepartmentName;
                var SectionName = _service._sectionManager.GetSection(item.EntitySectionId);
                var s = _service._personManager.GetAllPerson().First(x => x.EntitySectionId == SectionName.EntitySectionId);
                
                SectionAndDepartmentInclude sectionDep = new SectionAndDepartmentInclude()
                {
                Appointment = item,
                SectionName = SectionName.SectionName,
                DepartmentName = DepartmentName,
                PersonName = s.PersonName,
                PersonLastName = s.PersonLastName
                };
                SectionDepartment.Add(sectionDep);
            }
            return View(SectionDepartment);
        }
    }
}