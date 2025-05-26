using System;
using System.Text;
using Wisej.Web;

namespace WisejPWAWebApplicationExample
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Navigate("https://developer.mozilla.org/en-US/docs/Web/Progressive_web_apps", "_blank");
        }
    }
}
