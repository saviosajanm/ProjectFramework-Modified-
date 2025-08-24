using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectFramework.Web.BLL;
using ProjectFramework.Web.Models;
using System;

namespace ProjectFramework.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly SettingsBLL _settingsBll = new SettingsBLL();
        private readonly EmailSettingsBLL _emailSettingsBLL = new EmailSettingsBLL();
        private readonly DeviceDetailsBLL _deviceDetailsBLL = new DeviceDetailsBLL();

        private bool CheckAdminAndSetViewBag()
        {
            var settings = new SettingsBLL();
            ViewBag.AppName = settings.GetValue("AppName");

            var strUserID = HttpContext.Session.GetString("UserID");
            var role = HttpContext.Session.GetString("Role");
            bool isAdmin = !string.IsNullOrEmpty(strUserID) && role == "Admin";
            ViewBag.IsAdmin = isAdmin;
            return isAdmin;
        }

        public IActionResult Settings()
        {
            if (!CheckAdminAndSetViewBag()) return RedirectToAction("Login", "Home");

            var model = new AdminViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Settings(AdminViewModel model)
        {
            if (!CheckAdminAndSetViewBag()) return RedirectToAction("Login", "Home");

            model.EnableMobAuth = model.IsChecked.ToString();
            if (model.UpdateSettings())
            {
                model.StatusString = "Settings Updated Successfully...";
            }
            else
            {
                model.StatusString = "Failed to update settings.";
            }

            return View(model);
        }

        public IActionResult EmailSettings()
        {
            if (!CheckAdminAndSetViewBag()) return RedirectToAction("Login", "Home");

            var settings = _emailSettingsBLL.GetSettings();
            return View(settings);
        }

        [HttpPost]
        public IActionResult EmailSettings(EmailSettings settings)
        {
            if (!CheckAdminAndSetViewBag()) return RedirectToAction("Login", "Home");
            try
            {
                _emailSettingsBLL.SetSettings(settings);
                ViewBag.StatusMessage = "E-Mail Settings Updated Successfully...";
            }
            catch (Exception ex)
            {
                ViewBag.StatusMessage = "Error: " + ex.Message;
            }

            return View(settings);
        }

        public IActionResult DeviceDetails()
        {
            if (!CheckAdminAndSetViewBag()) return RedirectToAction("Login", "Home");

            var details = _deviceDetailsBLL.GetDeviceDetails();
            return View(details);
        }
    }
}