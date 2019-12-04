using Microsoft.AppCenter.Analytics;
using System;
using System.Windows.Forms;

namespace TelemetryPoC
{
  public partial class DrillDown : Form
  {
    public DrillDown()
    {
      InitializeComponent();
      this.Visible = false;
    }

    private void CloseButton_Click(object sender, EventArgs e)
    {
      Analytics.TrackEvent($"Click on [CloseButton] in {System.Reflection.MethodBase.GetCurrentMethod().DeclaringType}");
      this.Close();
    }
  }
}
