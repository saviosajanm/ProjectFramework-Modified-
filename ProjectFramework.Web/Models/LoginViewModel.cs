using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace ProjectFramework.Web.Models
{
    public class LoginViewModel : ViewModelBase
    {
        public BLL.UserBLL UserBLLObj = new BLL.UserBLL();

        // ADD THESE PROPERTIES
        public string UserName { get; set; }
        public string Password { get; set; }

        public LoginViewModel()
        {
            StatusString = "";
        }
    }
}