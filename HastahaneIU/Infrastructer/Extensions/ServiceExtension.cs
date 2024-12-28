using System.Reflection;
using Business.Abstract;
using Business.Contract;
using DataAccess.Abstract;
using DataAccess.Contract;
using DataAccess.DbContextEfCore;
using HastahaneIU.Areas.Personal.Models;
using HastahaneIU.Controllers;
using HastahaneIU.Models;
using Microsoft.AspNetCore.Identity;

namespace HastahaneIU.Extensions
{
    public static class ServiceExtension
    {
        public static void Scoped(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<EntityFrameworkDbContext>();
            builder.Services.AddScoped<IManagerService , ServiceManager>();
            builder.Services.AddScoped<IAuthService, AuthManager>();
            builder.Services.AddScoped<IDepartmentService , DepartmentManager>();
            builder.Services.AddScoped<ISectionService , SectionManager>();
            builder.Services.AddScoped<IPersonService, PersonManager>();
            builder.Services.AddScoped<IAppointmentService, AppointmentManager>();

            builder.Services.AddScoped<IRepositoryService , RepositoryManager>();
            builder.Services.AddScoped<IDepartmentRepository , DepartmentRepository>();
            builder.Services.AddScoped<ISectionRepository , SectionRepository>();
            builder.Services.AddScoped<IAppointmentRepository , AppointmentRepository>();
            builder.Services.AddScoped<IPersonRepository, PersonRepository>();
            builder.Services.AddScoped<PersonMessageCrud>();

            builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => 
            {
                options.Password.RequireNonAlphanumeric = false;
                options.User.AllowedUserNameCharacters = "abcdefgğhıijklmnoöpqrstuüvwxyzABCDEFGĞHIİJKLMNOÖPQRSTUÜVWXYZ0123456789-._@+";
            })
            .AddEntityFrameworkStores<EntityFrameworkDbContext>()
            .AddDefaultTokenProviders();
        }
        public static void MapperScoped(this IServiceCollection services)
        {
            services.AddScoped<SessionMessage>();
            services.AddScoped<DateModelForAppointment>();
            services.AddScoped<DateModelForAppointmentCrud>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddHttpContextAccessor();
            services.AddSingleton<IHttpContextAccessor , HttpContextAccessor>();
            services.AddDistributedMemoryCache(); 
            services.AddSession(option => 
            {
                option.Cookie.HttpOnly = true; 
                option.Cookie.IsEssential = true;
            });

            services.AddRouting(x => {
                x.LowercaseUrls = true;
                x.LowercaseQueryStrings = true;
            });
            
        }
    }
}