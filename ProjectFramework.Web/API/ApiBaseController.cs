using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ProjectFramework.Web.BLL;
using ProjectFrameworkCommonLib;
using System;

namespace ProjectFramework.Web.API
{
    // CORRECTED: Inherit from Controller instead of ControllerBase
    public class ApiBaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            // The AuthController is exempt from this check as it's used for logging in.
            if (context.Controller.GetType() == typeof(AuthController))
            {
                return;
            }

            // This check respects the "EnableMobAuth" setting from your database.
            if (!SettingsBLL.UseAuthToken)
            {
                return;
            }

            string authHeader = HttpContext.Request.Headers["Authorization"];

            if (authHeader != null && authHeader.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
            {
                string token = authHeader.Substring("Bearer ".Length).Trim();
                try
                {
                    string decryptedToken = PFCrypt.Decrypt(token);
                    string[] parts = decryptedToken.Split(':');
                    if (parts.Length == 2)
                    {
                        string email = parts[0];
                        string userId = parts[1];
                        UserBLL userBll = new UserBLL();
                        if (userBll.CheckValidUser(email, userId))
                        {
                            // If the user and token are valid, allow the request to proceed.
                            return;
                        }
                    }
                }
                catch (Exception)
                {
                    // If decryption fails or token is invalid, deny access.
                    context.Result = new UnauthorizedResult();
                    return;
                }
            }

            // If no valid token is found, deny access.
            context.Result = new UnauthorizedResult();
        }
    }
}