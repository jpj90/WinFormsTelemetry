namespace TelemetryPoC
{
  partial class Main
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.ArgumentsButton = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.GenericErrorButton = new System.Windows.Forms.Button();
      this.DivideZeroButton = new System.Windows.Forms.Button();
      this.NullReferenceButton = new System.Windows.Forms.Button();
      this.GoToDrillDownButton = new System.Windows.Forms.Button();
      this.CrashButton = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(53, 43);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(84, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Hello user!";
      // 
      // ArgumentsButton
      // 
      this.ArgumentsButton.Location = new System.Drawing.Point(19, 39);
      this.ArgumentsButton.Name = "ArgumentsButton";
      this.ArgumentsButton.Size = new System.Drawing.Size(139, 64);
      this.ArgumentsButton.TabIndex = 1;
      this.ArgumentsButton.Text = "Argument Exception";
      this.ArgumentsButton.UseVisualStyleBackColor = true;
      this.ArgumentsButton.Click += new System.EventHandler(this.ArgumentsButton_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.GenericErrorButton);
      this.groupBox1.Controls.Add(this.DivideZeroButton);
      this.groupBox1.Controls.Add(this.NullReferenceButton);
      this.groupBox1.Controls.Add(this.ArgumentsButton);
      this.groupBox1.Location = new System.Drawing.Point(57, 114);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(320, 202);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Create errors";
      // 
      // GenericErrorButton
      // 
      this.GenericErrorButton.Location = new System.Drawing.Point(164, 109);
      this.GenericErrorButton.Name = "GenericErrorButton";
      this.GenericErrorButton.Size = new System.Drawing.Size(139, 64);
      this.GenericErrorButton.TabIndex = 4;
      this.GenericErrorButton.Text = "Generic Error";
      this.GenericErrorButton.UseVisualStyleBackColor = true;
      this.GenericErrorButton.Click += new System.EventHandler(this.GenericErrorButton_Click);
      // 
      // DivideZeroButton
      // 
      this.DivideZeroButton.Location = new System.Drawing.Point(19, 109);
      this.DivideZeroButton.Name = "DivideZeroButton";
      this.DivideZeroButton.Size = new System.Drawing.Size(139, 64);
      this.DivideZeroButton.TabIndex = 3;
      this.DivideZeroButton.Text = "Divide By Zero";
      this.DivideZeroButton.UseVisualStyleBackColor = true;
      this.DivideZeroButton.Click += new System.EventHandler(this.DivideZeroButton_Click);
      // 
      // NullReferenceButton
      // 
      this.NullReferenceButton.Location = new System.Drawing.Point(164, 39);
      this.NullReferenceButton.Name = "NullReferenceButton";
      this.NullReferenceButton.Size = new System.Drawing.Size(139, 64);
      this.NullReferenceButton.TabIndex = 2;
      this.NullReferenceButton.Text = "Null Reference";
      this.NullReferenceButton.UseVisualStyleBackColor = true;
      this.NullReferenceButton.Click += new System.EventHandler(this.NullReferenceButton_Click);
      // 
      // GoToDrillDownButton
      // 
      this.GoToDrillDownButton.Location = new System.Drawing.Point(568, 176);
      this.GoToDrillDownButton.Name = "GoToDrillDownButton";
      this.GoToDrillDownButton.Size = new System.Drawing.Size(139, 80);
      this.GoToDrillDownButton.TabIndex = 3;
      this.GoToDrillDownButton.Text = "Launch Drilldown";
      this.GoToDrillDownButton.UseVisualStyleBackColor = true;
      this.GoToDrillDownButton.Click += new System.EventHandler(this.GoToDrillDownButton_Click);
      // 
      // CrashButton
      // 
      this.CrashButton.BackColor = System.Drawing.Color.DarkRed;
      this.CrashButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CrashButton.ForeColor = System.Drawing.SystemColors.ControlLight;
      this.CrashButton.Location = new System.Drawing.Point(568, 292);
      this.CrashButton.Name = "CrashButton";
      this.CrashButton.Size = new System.Drawing.Size(139, 80);
      this.CrashButton.TabIndex = 4;
      this.CrashButton.Text = "CRASH!";
      this.CrashButton.UseVisualStyleBackColor = false;
      this.CrashButton.Click += new System.EventHandler(this.CrashButton_Click);
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.CrashButton);
      this.Controls.Add(this.GoToDrillDownButton);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label1);
      this.Name = "Main";
      this.Text = "Main Form";
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button ArgumentsButton;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button DivideZeroButton;
    private System.Windows.Forms.Button NullReferenceButton;
    private System.Windows.Forms.Button GenericErrorButton;
    private System.Windows.Forms.Button GoToDrillDownButton;
    private System.Windows.Forms.Button CrashButton;
  }
}

