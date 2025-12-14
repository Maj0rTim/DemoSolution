using DemoFrontEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoFrontEnd.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public JsonResult ValidateLogin(SystemUser model)
        {
            var result = new Dictionary<string, bool>();
            result.Add("username", model.Username == "admin" ? true : false);
            result.Add("password", model.Password == "1234" ? true : false);
            return Json(result);
        }
    }
}
