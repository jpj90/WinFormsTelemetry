using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelemetryPoC
{
  public partial class Main : Form
  {
    private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    private readonly string errorMessage = "\n\noh, the horror, a ";

    public Main()
    {
      InitializeComponent();
    }

    private void ArgumentsButton_Click(object sender, EventArgs e)
    {
      ThrowButLog(new ArgumentException(errorMessage + "faulty argument!"));
    }

    private void NullReferenceButton_Click(object sender, EventArgs e)
    {
      ThrowButLog(new NullReferenceException(errorMessage + "null reference!"));
    }

    private void DivideZeroButton_Click(object sender, EventArgs e)
    {
      ThrowButLog(new DivideByZeroException(errorMessage + "dividing by zero case!"));
    }

    private void GenericErrorButton_Click(object sender, EventArgs e)
    {
      ThrowButLog(new Exception(errorMessage + "generic exception!"));
    }

    private void ThrowButLog(Exception exception)
    {
      try
      {
        throw exception;
      }
      catch(Exception e)
      {
        var message = "Something terrible appears to have happened: " + e.Message;
        logger.Error(message);
        MessageBox.Show(message,"Error!!");
      }
    }

    private void GoToDrillDownButton_Click(object sender, EventArgs e)
    {
      var drillDown = new DrillDown();
      drillDown.Show();
    }
  }
}
