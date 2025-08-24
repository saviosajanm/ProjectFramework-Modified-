using Microsoft.AspNetCore.Mvc;
using ProjectFramework.Web.BLL;
using ProjectFramework.Web.Models;
using System;

namespace ProjectFramework.Web.API
{
    [Route("api/EmailSettings")]
    public class EmailSettingsController : ApiBaseController
    {
        private EmailSettingsBLL _emailSettingsBLL = new EmailSettingsBLL();

        [HttpGet("GetEmailSettingsInfo")]
        public IActionResult GetEmailSettingsInfo()
        {
            try
            {
                var settings = _emailSettingsBLL.GetSettings();
                return Ok(settings);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("UpdateEmailSettingsInfo")]
        public IActionResult UpdateEmailSettingsInfo([FromBody] EmailSettings settings)
        {
            try
            {
                _emailSettingsBLL.SetSettings(settings);
                return Ok("E-Mail Settings Updated Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}