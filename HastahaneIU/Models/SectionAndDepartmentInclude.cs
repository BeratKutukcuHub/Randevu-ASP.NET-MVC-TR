using Entities;

namespace HastahaneIU.Models
{
    public class SectionAndDepartmentInclude
    {
        public EntityAppointment Appointment {get; set;}
        public string SectionName { get; set; }
        public string DepartmentName { get; set; }
        public string PersonName {get; set;}
        public string PersonLastName {get; set;}
    }
}