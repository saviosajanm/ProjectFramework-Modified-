using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFrameworkCommonLib
{
    public class AppSettings
    {
        public string AppName { get; set; }
        public string MainHeading { get; set; }

        public string MainDesc { get; set; }

        public AppSettings()
        {
            AppName = "";
            MainHeading = "";
            MainDesc = "";
        }
    }
}
