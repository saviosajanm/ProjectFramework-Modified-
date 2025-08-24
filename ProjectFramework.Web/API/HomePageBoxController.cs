using Microsoft.AspNetCore.Mvc;
using ProjectFramework.Web.BLL;
using System;
using System.Collections.Generic;
using ProjectFramework.Web.Models;

namespace ProjectFramework.Web.API
{
    [Route("api/HomePageBox")]
    [ApiController]
    public class HomePageBoxController : ApiBaseController
    {
        private readonly HomePageBoxBLL _homePageBoxBLL = new HomePageBoxBLL();

        [HttpGet("GetHomePageBoxes")]
        public ActionResult<IEnumerable<HomePageBox>> GetHomePageBoxes()
        {
            try
            {
                var boxes = _homePageBoxBLL.GetHomePageBoxes();
                return Ok(boxes);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An internal server error occurred: " + ex.Message);
            }
        }
    }
}