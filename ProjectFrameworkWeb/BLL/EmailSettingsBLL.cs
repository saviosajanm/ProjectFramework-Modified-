using ProjectFrameworkWeb.Models;
using System;

namespace ProjectFrameworkWeb.BLL
{
    public class EmailSettingsBLL : BLLBase
    {
        public EmailSettings GetSettings()
        {
            try
            {
                return new EmailSettings
                {
                    SMTPServer = GetValue("SMTPServer"),
                    SMTPPort = Convert.ToInt32(GetValue("SMTPPort")),
                    EMail = GetValue("EMail"),
                    Password = Decrypt(GetValue("EmailPassword")),
                    EnableSSL = Convert.ToBoolean(GetValue("EnableSSL"))
                };
            }
            catch (Exception)
            {
                return new EmailSettings();
            }
        }

        public void SetSettings(EmailSettings settings)
        {
            SetValue("SMTPServer", settings.SMTPServer);
            SetValue("SMTPPort", settings.SMTPPort.ToString());
            SetValue("EMail", settings.EMail);
            SetValue("EmailPassword", Encrypt(settings.Password ?? string.Empty));
            SetValue("EnableSSL", settings.EnableSSL.ToString());
        }
    }
}