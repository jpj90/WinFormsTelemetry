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
  public partial class DrillDown : Form
  {
    public DrillDown()
    {
      InitializeComponent();
      this.Visible = false;
    }

    private void CloseButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
