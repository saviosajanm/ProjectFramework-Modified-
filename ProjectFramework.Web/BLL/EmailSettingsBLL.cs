using ProjectFramework.Web.Models;
using System;
namespace ProjectFramework.Web.BLL
{
    public class EmailSettingsBLL : BLLBase
    {
        public EmailSettings GetSettings()
        {
            try
            {
                var settings = new EmailSettings
                {
                    SMTPServer = GetValue("SMTPServer"),
                    SMTPPort = Convert.ToInt32(GetValue("SMTPPort")),
                    EMail = GetValue("EMail"),
                    EnableSSL = Convert.ToBoolean(GetValue("EnableSSL"))
                };

                string encryptedPassword = GetValue("EmailPassword");
                try
                {
                    // Decrypt will handle empty string, but this prevents an error on null.
                    settings.Password = !string.IsNullOrEmpty(encryptedPassword) ? Decrypt(encryptedPassword) : "";
                }
                catch
                {
                    // If decryption fails, it might be a plain-text value from the initial script.
                    // We can't display it, so we'll show an empty field. The user can then set a new password.
                    settings.Password = "";
                }
                return settings;
            }
            catch (Exception)
            {
                // Fallback for other parsing errors (like port number)
                return new EmailSettings();
            }
        }
        public void SetSettings(EmailSettings settings)
        {
            SetValue("SMTPServer", settings.SMTPServer);
            SetValue("SMTPPort", settings.SMTPPort.ToString());
            SetValue("EMail", settings.EMail);
            // Handle null password to avoid encryption error.
            SetValue("EmailPassword", Encrypt(settings.Password ?? string.Empty));
            SetValue("EnableSSL", settings.EnableSSL.ToString());
        }
    }
}