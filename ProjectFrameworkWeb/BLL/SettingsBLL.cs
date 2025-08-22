using System;

namespace ProjectFrameworkWeb.BLL
{
    public class SettingsBLL : BLLBase
    {
        public static bool UseAuthToken { get; set; } = false;

        public static void SetAuthToken(bool bEnable)
        {
            UseAuthToken = bEnable;
        }
    }
}