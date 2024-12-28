using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HastahaneIU.Areas.Admin.Components
{
    public class FilterSectionViewComponent : ViewComponent
    {
        private IManagerService _service;

        public FilterSectionViewComponent(IManagerService service)
        {
            _service = service;
        }

        public IViewComponentResult Invoke()
        {
            var departments = _service._departmentManager.GetAllDepartment();
            return View(departments);
        }
        

    }
}