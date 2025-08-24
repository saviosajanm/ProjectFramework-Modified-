using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectFramework.Web.BLL;
using ProjectFramework.Web.Models;
using ProjectFrameworkCommonLib;

namespace ProjectFramework.Web.Controllers
{
    public class HomeController : AppControllerBase // Make sure it inherits from AppControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserBLL _userBll = new UserBLL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private void SetViewBagData()
        {
            var settings = new SettingsBLL();
            ViewBag.AppName = settings.GetValue("AppName");
            var strUserID = HttpContext.Session.GetString("UserID");
            var role = HttpContext.Session.GetString("Role");
            ViewBag.IsAdmin = !string.IsNullOrEmpty(strUserID) && role == "Admin";
        }

        public IActionResult Index()
        {
            SetViewBagData();
            var model = new HomeViewModel(); // This will load MainHeading and MainDesc
            return View(model);
        }

        public IActionResult About()
        {
            SetViewBagData();
            return View(new ViewModelBase()); // Pass base model for layout properties
        }

        public IActionResult Contact()
        {
            SetViewBagData();
            return View(new ViewModelBase()); // Pass base model
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login()
        {
            HttpContext.Session.Clear();
            SetViewBagData();
            var model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            SetViewBagData();
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (string.IsNullOrEmpty(model.UserName) || string.IsNullOrEmpty(model.Password))
            {
                model.StatusString = "Please Enter Valid User Name | E Mail and Password";
                return View(model);
            }

            AuthInfo info = _userBll.GetUserInfo(model.UserName, model.Password);

            if (info.UserID > 0)
            {
                UserRole role = _userBll.GetUserRole(info.UserID);
                HttpContext.Session.SetString("UserID", info.UserID.ToString());
                HttpContext.Session.SetString("UserName", model.UserName);
                HttpContext.Session.SetString("Role", role.ToString());
                return RedirectToAction("Settings", "Admin");
            }
            else
            {
                model.StatusString = $"Login Failed: {info.AuthenticationToken}";
                return View(model);
            }
        }
    }
}