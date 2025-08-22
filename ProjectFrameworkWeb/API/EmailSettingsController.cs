using ProjectFrameworkWeb.BLL;
using ProjectFrameworkWeb.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectFrameworkWeb.API
{
    public class EmailSettingsController : TokenCheckController
    {
        private EmailSettingsBLL _emailSettingsBLL = new EmailSettingsBLL();

        [HttpGet]
        public HttpResponseMessage GetEmailSettingsInfo()
        {
            try
            {
                var settings = _emailSettingsBLL.GetSettings();
                var message = Request.CreateResponse(HttpStatusCode.OK, settings);
                message.Headers.Location = new Uri(Request.RequestUri.ToString());
                return message;
            }
            catch (Exception Ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, Ex.Message);
            }
        }

        [HttpPost]
        public HttpResponseMessage UpdateEmailSettingsInfo(EmailSettings settings)
        {
            try
            {
                _emailSettingsBLL.SetSettings(settings);
                var message = Request.CreateResponse(HttpStatusCode.OK, "E-Mail Settings Updated Successfully");
                message.Headers.Location = new Uri(Request.RequestUri.ToString());
                return message;
            }
            catch (Exception Ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, Ex.Message);
            }
        }
    }
}