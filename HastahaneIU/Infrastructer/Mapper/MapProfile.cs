using AutoMapper;
using Entities;
using Entities.Dto;
using Entities.Infrastructer;
using HastahaneIU.Models;
using Microsoft.AspNetCore.Identity;

namespace HastahaneIU.Infratructer.Mapper
{
    public class MapProfile : Profile
    {
       public MapProfile()
       {
            CreateMap<EntityPerson , EntityPersonItemDto>().ReverseMap();
            CreateMap<IdentityUser , UserDtoForCreate>().ReverseMap();
            CreateMap<DateModelForAppointment , EntityAppointment>().ReverseMap();
       }
    }
}