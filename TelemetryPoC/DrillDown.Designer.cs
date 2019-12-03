namespace TelemetryPoC
{
  partial class DrillDown
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
      this.WelcomeLabel = new System.Windows.Forms.Label();
      this.CloseButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // WelcomeLabel
      // 
      this.WelcomeLabel.AutoSize = true;
      this.WelcomeLabel.Location = new System.Drawing.Point(28, 47);
      this.WelcomeLabel.Name = "WelcomeLabel";
      this.WelcomeLabel.Size = new System.Drawing.Size(193, 20);
      this.WelcomeLabel.TabIndex = 0;
      this.WelcomeLabel.Text = "Welcome to the drill down!";
      // 
      // CloseButton
      // 
      this.CloseButton.Location = new System.Drawing.Point(606, 348);
      this.CloseButton.Name = "CloseButton";
      this.CloseButton.Size = new System.Drawing.Size(143, 68);
      this.CloseButton.TabIndex = 1;
      this.CloseButton.Text = "Close me";
      this.CloseButton.UseVisualStyleBackColor = true;
      this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
      // 
      // DrillDown
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.CloseButton);
      this.Controls.Add(this.WelcomeLabel);
      this.Name = "DrillDown";
      this.Text = "DrillDown";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label WelcomeLabel;
    private System.Windows.Forms.Button CloseButton;
  }
}