namespace HastahaneIU.Areas.Personal.Models
{
    public class Appointment
{
    public string UserName { get; set; }
    public DateTime DateInAppointment { get; set; }
    public bool Active { get; set; }
    public int EntitySectionId { get; set; }
    public int EntityAppointmentId { get; set; }
}
}