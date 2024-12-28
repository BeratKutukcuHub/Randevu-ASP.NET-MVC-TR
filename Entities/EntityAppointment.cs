namespace Entities
{
    public class EntityAppointment
    {
        public int EntityAppointmentId { get; set; }
        public string UserName { get; set; }
        public EntityDepartment EntityDepartment {get; set;}
        public int EntityDepartmentId { get; set; }
        public int EntitySectionId { get; set; }
        public DateTime DateInAppointment { get; set; }
        public bool Active { get; set; } = true;

    }
}