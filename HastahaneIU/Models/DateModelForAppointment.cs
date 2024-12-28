namespace HastahaneIU.Models
{
    public class DateModelForAppointment
    {
        private string _dayName;
        private string _mounthName;
        public int EntityDepartmentId {get; set;}
        public int EntitySectionId {get; set;}
        public int MonthId {get; set;} = DateTime.Today.Month;
        public int DayId {get; set;}
        public int HourId {get; set;} 
        public int MinuteId {get; set;} 
        public string MountName 
        {
            get => _mounthName; 
            set 
            {
             if (value == "1") { _mounthName = "Ocak"; }
        else if (value == "2") { _mounthName = "Şubat"; }
        else if (value == "3") { _mounthName = "Mart"; }
        else if (value == "4") { _mounthName = "Nisan"; }
        else if (value == "5") { _mounthName = "Mayıs"; }
        else if (value == "6") { _mounthName = "Haziran"; }
        else if (value == "7") { _mounthName = "Temmuz"; }
        else if (value == "8") { _mounthName = "Ağustos"; }
        else if (value == "9") { _mounthName = "Eylül"; }
        else if (value == "10") { _mounthName = "Ekim"; }
        else if (value == "11") { _mounthName = "Kasım"; }
        else if (value == "12") { _mounthName = "Aralık"; }
            }
        }
        
        public string DayName
        {
        get => _dayName;
        set
        {
        switch (value)
        {
            case "Friday":
                _dayName = "Cuma";
                break;
            case "Monday":
                _dayName = "Pazartesi";
                break;
            case "Saturday":
                _dayName = "Cumartesi";
                break;
            case "Sunday":
                _dayName = "Pazar";
                break;
            case "Thursday":
                _dayName = "Perşembe";
                break;
            case "Tuesday":
                _dayName = "Salı";
                break;
            case "Wednesday":
                _dayName = "Çarşamba";
                break;
            default:
                _dayName = value; 
                break;
            }
            }
}
    }
}