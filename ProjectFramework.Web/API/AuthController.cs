using Microsoft.AspNetCore.Mvc;
using ProjectFramework.Web.BLL;
using ProjectFrameworkCommonLib;
using System;

namespace ProjectFramework.Web.API
{
    [Route("api/Auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserBLL _userBll = new UserBLL();

        [HttpGet("ValidateUser")]
        public ActionResult ValidateUser([FromQuery] string UserID, [FromQuery] string Password)
        {
            try
            {
                if (string.IsNullOrEmpty(UserID) || string.IsNullOrEmpty(Password))
                {
                    return BadRequest("UserID and Password cannot be empty.");
                }

                AuthInfo info = _userBll.GetUserInfo(UserID, Password);

                if (info.UserID > 0)
                {
                    return Ok(info);
                }
                else
                {
                    // Return 401 Unauthorized for a failed login attempt.
                    return Unauthorized(info.AuthenticationToken);
                }
            }
            catch (Exception ex)
            {
                // Return 500 Internal Server Error for any unexpected exceptions.
                return StatusCode(500, "An internal server error occurred: " + ex.Message);
            }
        }
    }
}