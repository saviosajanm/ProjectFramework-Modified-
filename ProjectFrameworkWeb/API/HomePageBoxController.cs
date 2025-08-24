using ProjectFrameworkWeb.BLL;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectFrameworkWeb.API
{
    public class HomePageBoxController : TokenCheckController
    {
        private readonly HomePageBoxBLL _homePageBoxBLL = new HomePageBoxBLL();

        [HttpGet]
        public HttpResponseMessage GetHomePageBoxes()
        {
            try
            {
                var boxes = _homePageBoxBLL.GetHomePageBoxes();
                return Request.CreateResponse(HttpStatusCode.OK, boxes);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        public HttpResponseMessage UpdateOrder([FromBody] List<int> orderedIds)
        {
            try
            {
                _homePageBoxBLL.UpdateOrder(orderedIds);
                return Request.CreateResponse(HttpStatusCode.OK, "Order updated successfully.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}