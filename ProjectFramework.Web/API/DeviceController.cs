using Microsoft.AspNetCore.Mvc;
using ProjectFramework.Web.BLL;
using ProjectFramework.Web.Models;
using System;

namespace ProjectFramework.Web.API
{
    [Route("api/DeviceDetails")]
    [ApiController]
    public class DeviceDetailsController : ApiBaseController // Inherit from ApiBaseController
    {
        private readonly DeviceDetailsBLL _deviceDetailsBLL = new DeviceDetailsBLL();

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

        // Add this new method to get device details
        [HttpGet("GetDeviceDetails")]
        public IActionResult GetDeviceDetails()
        {
            try
            {
                var details = _deviceDetailsBLL.GetDeviceDetails();
                return Ok(details);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}