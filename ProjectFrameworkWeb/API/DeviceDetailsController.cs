using ProjectFrameworkWeb.BLL;
using ProjectFrameworkWeb.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectFrameworkWeb.API
{
    public class DeviceDetailsController : TokenCheckController
    {
        private DeviceDetailsBLL _deviceDetailsBLL = new DeviceDetailsBLL();

        [HttpPost]
        public HttpResponseMessage ReceiveDeviceDetails(DeviceDetails details)
        {
            try
            {
                _deviceDetailsBLL.SaveDeviceDetails(details);
                var message = Request.CreateResponse(HttpStatusCode.OK, "Device details received successfully.");
                message.Headers.Location = new Uri(Request.RequestUri.ToString());
                return message;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}