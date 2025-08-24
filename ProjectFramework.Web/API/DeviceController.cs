using Microsoft.AspNetCore.Mvc;
using ProjectFramework.Web.BLL;
using ProjectFramework.Web.Models;
using System;

namespace ProjectFramework.Web.API
{
    [Route("api/DeviceDetails")]
    public class DeviceDetailsController : ControllerBase
    {
        private DeviceDetailsBLL _deviceDetailsBLL = new DeviceDetailsBLL();

        [HttpPost("ReceiveDeviceDetails")]
        public IActionResult ReceiveDeviceDetails([FromBody] DeviceDetails details)
        {
            try
            {
                _deviceDetailsBLL.SaveDeviceDetails(details);
                return Ok("Device details received successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}