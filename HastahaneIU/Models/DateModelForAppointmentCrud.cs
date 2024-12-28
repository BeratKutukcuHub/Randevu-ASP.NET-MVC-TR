using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using HastahaneIU.Models;
using Entities;

namespace HastahaneIU.Controllers;

public class DateModelForAppointmentCrud
{
    
    public List<DateModelForAppointment> MonthAndDateList(DateModelForAppointment Model)
    {
        List<DateModelForAppointment> DayOfWeek = new();
        
        var MountForDays = DateTime.DaysInMonth(DateTime.Today.Year , Model.MonthId);
       for(int i = 1 ; i<= MountForDays; i++)
       {
            string DayName = new DateTime(DateTime.Today.Year, Model.MonthId, i).DayOfWeek.ToString();
            DayOfWeek.Add(new DateModelForAppointment()
            {
                MonthId = Model.MonthId,
                DayName = DayName,
                DayId = i,
                MountName = DateTime.Today.Month.ToString(),
            });
       }
       return DayOfWeek.Where(x => x.MonthId == Model.MonthId).ToList();
    }
    
   
}
    
    
