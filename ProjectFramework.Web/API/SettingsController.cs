using Microsoft.AspNetCore.Mvc;
using ProjectFramework.Web.BLL;
using System;
using System.Collections.Generic;

namespace ProjectFramework.Web.API
{
    [Route("api/Settings")]
    public class SettingsController : ControllerBase
    {
        private SettingsBLL settingsBll = new SettingsBLL();

        [Route("GetSettingsInfo")]
        [HttpGet]
        public ActionResult GetSettingsInfo()
        {
            try
            {
                var settings = new
                {
                    AppName = settingsBll.GetValue("AppName"),
                    MainHeading = settingsBll.GetValue("MainHeading"),
                    MainDesc = settingsBll.GetValue("MainDesc")
                };
                return Ok(settings);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("GetSettingsInfoEx")]
        [HttpGet]
        public ActionResult GetSettingsInfoEx(string Key)
        {
            return Ok(settingsBll.GetValue(Key));
        }

        [Route("UpdateSettingsInfo")]
        [HttpPost]
        public ActionResult UpdateSettingsInfo([FromBody] Dictionary<string, string> dict)
        {
            try
            {
                foreach (var kvp in dict)
                {
                    settingsBll.SetValue(kvp.Key, kvp.Value);
                }
                return Ok("Settings Updated Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
