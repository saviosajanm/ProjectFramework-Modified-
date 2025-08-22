using ProjectFrameworkWeb.BLL;
using System;

namespace ProjectFrameworkWeb.Admin
{
    public partial class DeviceDetails : BasePage
    {
        private readonly DeviceDetailsBLL _deviceDetailsBLL = new DeviceDetailsBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDeviceDetails();
            }
        }

        private void LoadDeviceDetails()
        {
            var details = _deviceDetailsBLL.GetDeviceDetails();
            LabelProcessorCount.Text = details.ProcessorCount.ToString();
            LabelTotalMemory.Text = details.TotalMemory;
            LabelMemoryLeft.Text = details.MemoryLeft;
            LabelTotalSpace.Text = details.TotalSpace;
            LabelSpaceLeft.Text = details.SpaceLeft;
        }
    }
}