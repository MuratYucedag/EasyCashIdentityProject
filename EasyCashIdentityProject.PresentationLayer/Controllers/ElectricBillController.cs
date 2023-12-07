using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
    public class ElectricBillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
