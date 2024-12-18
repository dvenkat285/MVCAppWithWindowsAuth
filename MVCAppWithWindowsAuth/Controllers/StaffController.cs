using System.Web.Mvc;

namespace MVCAppWithWindowsAuth.Controllers
{
    [Authorize(Roles = "EE043\\StaffGroup")]
    public class StaffController : Controller
    {
        //[Authorize(Users = "EE043\\Staff1, EE043\\Staff2, EE043\\Staff3, EE043\\Staff4")]
        //[Authorize(Roles = "EE043\\StaffGroup")]
        public ViewResult Home()
        {
            return View();
        }
        [AllowAnonymous] //allowed access all
        public ViewResult Help()
        {
            return View();
        }
    }
}