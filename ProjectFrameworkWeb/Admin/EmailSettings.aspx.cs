using ProjectFrameworkWeb.BLL;
using ProjectFrameworkWeb.Models;
using System;
using System.Web.UI;

namespace ProjectFrameworkWeb.Admin
{
    public partial class EmailSettings : BasePage
    {
        private EmailSettingsBLL _emailSettingsBLL = new EmailSettingsBLL();
        private SettingsBLL _settingsBLL = new SettingsBLL();

        protected new void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadSettings();
            }
        }

        private void LoadSettings()
        {
            try
            {
                var settings = _emailSettingsBLL.GetSettings();
                TextBoxSmtpServer.Text = settings.SMTPServer;
                TextBoxSmtpPort.Text = settings.SMTPPort.ToString();
                TextBoxEmail.Text = settings.EMail;
                TextBoxPassword.Text = settings.Password;
                CheckEnableSSL.Checked = settings.EnableSSL;
            }
            catch (Exception ex)
            {
                LabelStatus.Text = "Failed to load settings: " + ex.Message;
            }
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var settings = new Models.EmailSettings
                {
                    SMTPServer = TextBoxSmtpServer.Text,
                    SMTPPort = Convert.ToInt32(TextBoxSmtpPort.Text),
                    EMail = TextBoxEmail.Text,
                    Password = TextBoxPassword.Text,
                    EnableSSL = CheckEnableSSL.Checked
                };
                _emailSettingsBLL.SetSettings(settings);
                LabelStatus.Text = "E-Mail Settings Updated Successfully...";
            }
            catch (Exception Ex)
            {
                LabelStatus.Text = Ex.Message;
            }
        }
    }
}