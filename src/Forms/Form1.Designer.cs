namespace src;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

	#region Windows Form Designer generated code

	private void InitializeComponent()
	{
		oPlotView = new OxyPlot.WindowsForms.PlotView();
		NumberInput = new TextBox();
		AutogenerateCheckbox = new CheckBox();
		GenerateButton = new Button();
		SuspendLayout();
		// 
		// NumberInput
		// 
		NumberInput.Location = new Point(40, 12);
		NumberInput.Name = "NumberInput";
		NumberInput.Size = new Size(248, 23);
		NumberInput.TabIndex = 0;
		NumberInput.TextChanged += NumberInput_TextChanged;
		NumberInput.KeyDown += OwnKeyDown;
		// 
		// AutogenerateCheckbox
		// 
		AutogenerateCheckbox.AutoSize = true;
		AutogenerateCheckbox.Location = new Point(690, 16);
		AutogenerateCheckbox.Name = "AutogenerateCheckbox";
		AutogenerateCheckbox.Size = new Size(98, 19);
		AutogenerateCheckbox.TabIndex = 1;
		AutogenerateCheckbox.Text = "Autogenerate";
		AutogenerateCheckbox.UseVisualStyleBackColor = true;
		AutogenerateCheckbox.CheckedChanged += checkBox1_CheckedChanged;
		// 
		// GenerateButton
		// 
		GenerateButton.Location = new Point(571, 12);
		GenerateButton.Name = "GenerateButton";
		GenerateButton.Size = new Size(108, 23);
		GenerateButton.TabIndex = 2;
		GenerateButton.Text = "Create Graph";
		GenerateButton.UseVisualStyleBackColor = true;
		GenerateButton.Click += button1_Click;
		// 
      // Plot-View
      // 
      //this.oPlotView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.oPlotView.Location = new System.Drawing.Point(0, 40);
      this.oPlotView.Name = "Collatz-Problem";
      this.oPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
      this.oPlotView.Size = new System.Drawing.Size(800, 400);
      this.oPlotView.TabIndex = 0;
      this.oPlotView.Text = "Collatz-Problem";
      this.oPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
      this.oPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
      this.oPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
		// 
		// Form1
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		KeyDown += OwnKeyDown;
		ClientSize = new Size(800, 450);
		Controls.Add(oPlotView);
		Controls.Add(GenerateButton);
		Controls.Add(AutogenerateCheckbox);
		Controls.Add(NumberInput);
		Name = "Form1";
		Text = "Collatz-Problem Visualization - by Reduzer";
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private TextBox NumberInput;
	private CheckBox AutogenerateCheckbox;
	private Button GenerateButton;
	private OxyPlot.WindowsForms.PlotView oPlotView;
}
