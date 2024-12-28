using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using HastahaneIU.Models;
using Entities.Dto;

namespace HastahaneIU.Controllers;

public class HomeController : Controller
{
    
    IManagerService _service;

    public HomeController(IManagerService service)
    {
        _service = service;
        
    }

    public  IActionResult Index()
    {
       
        return View();
    }
    

}

