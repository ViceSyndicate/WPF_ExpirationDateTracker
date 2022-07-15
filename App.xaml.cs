using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Forms = System.Windows.Forms;

namespace WPF_ExpirationDateTracker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Forms.NotifyIcon notifyIcon;

        public App()
        {
            notifyIcon = new Forms.NotifyIcon();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            notifyIcon.Icon = new System.Drawing.Icon("canned-food-icon.ico");
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(3000, "Food Expiry Warning", "One or more foods have already or will expire soon", Forms.ToolTipIcon.Info);
            base.OnStartup(e);
        }
        protected override void OnExit(ExitEventArgs e)
        {
            notifyIcon.Dispose();
            base.OnExit(e);
        }
    }
}
