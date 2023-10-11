using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Concrete;
using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
    public class MyLastProcessController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICustomerAccountProcessService _customerAccountProcessService;
        public MyLastProcessController(UserManager<AppUser> userManager, ICustomerAccountProcessService customerAccountProcessService)
        {
            _userManager = userManager;
            _customerAccountProcessService = customerAccountProcessService;
        }
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var context = new Context();
            int id=context.CustomerAccounts.Where(x=>x.AppUserID==user.Id && x.CustomerAccountCurrency=="Türk Lirası").Select(y=>y.CustomerAccountID).FirstOrDefault();
            var values = _customerAccountProcessService.TMyLastProcess(id);
            return View(values);
        }
    }
}
