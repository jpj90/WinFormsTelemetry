using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System.Configuration;


namespace TelemetryPoC
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      AppCenter.Start(ConfigurationManager.AppSettings.Get("AppId"),
        typeof(Analytics), typeof(Crashes));

      Application.Run(new Main());
    }
  }
}

;