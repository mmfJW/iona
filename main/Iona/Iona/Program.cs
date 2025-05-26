using System;
using System.Collections.Specialized;
using Wisej.Web;

namespace Iona
{
    internal static class Program
    {
        /**
    	* PWA Template
    	* 
    	* This template includes a ready-made InstallAppPanel that you can use
    	* to show a custom PWA installation prompt (works only in Chrome) and a
    	* set of 8 flavors of the Offline pages.
    	* 
    	* Rename the "Offline-#" style that you want to use to just "Offline" and
    	* delete the others. Wisej will only use the file in "/Offline".
    	* 
    	* If you set "offlineUrl" to "" or delete it from Default.json, Wisej will
    	* show a simple "Offline" toast instead of the full offline page.
    	* 
    	* Don't forget to update the version AssemblyInfo/AssemblyFileVersion when
    	* you want to update the offline cache.
    	*/

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">Arguments from the URL.</param>
        static void Main(NameValueCollection args)
        {
            new Page1().Show();

            // NOTE: this event fires only in Chrome at this time. Other browsers, including
            // Edge/Chrome don't seem to support it yet.
            Application.BeforeInstallPrompt += Application_BeforeInstallPrompt;
        }

        private static void Application_BeforeInstallPrompt(object sender, EventArgs e)
        {
            Application.BeforeInstallPrompt -= Application_BeforeInstallPrompt;

            new InstallAppPanel()
            {
                Parent = Application.MainPage
            };
        }
    }
}