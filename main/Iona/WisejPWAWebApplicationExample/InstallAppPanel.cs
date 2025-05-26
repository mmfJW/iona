using System;
using System.Drawing;

namespace WisejPWAWebApplicationExample
{
    /// <summary>
    /// Displays a custom panel at the bottom of the parent with an "Install" button that
    /// triggers the PWA install prompt on the browser.
    /// </summary>
    public partial class InstallAppPanel : Wisej.Web.UserControl
    {
        public InstallAppPanel()
        {
            InitializeComponent();
        }

        private void InstallAppPanel_Load(object sender, EventArgs e)
        {
            var parentSize = this.Parent.Size;
            this.Location = new Point(
                (parentSize.Width - Width) / 2,
                (parentSize.Height - Height - 5));

            BringToFront();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonInstall_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
