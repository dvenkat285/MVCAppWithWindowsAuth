using System.Web.Mvc;

namespace MVCAppWithWindowsAuth.Controllers
{
    [Authorize(Roles = "EE043\\ManagerGroup")]
    public class ManagerController : Controller
    {
        //[Authorize(Users = "EE043\\Manager1, EE043\\Manager2")]
        //[Authorize(Roles = "EE043\\ManagerGroup")]
        public ViewResult Home()
        {
            return View();
        }
        [AllowAnonymous]//allowed access all
        public ViewResult Help()
        {
            return View();
        }
    }
}