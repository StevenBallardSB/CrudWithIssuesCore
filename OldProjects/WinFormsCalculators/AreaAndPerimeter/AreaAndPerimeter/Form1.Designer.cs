namespace AreaAndPerimeter
{
    partial class AreaPerimeter
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
            this.Length = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.Label();
            this.Perimeter = new System.Windows.Forms.Label();
            this.AreaOutput = new System.Windows.Forms.MaskedTextBox();
            this.PerimeterOutput = new System.Windows.Forms.MaskedTextBox();
            this.LengthInput = new System.Windows.Forms.TextBox();
            this.WidthInput = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Location = new System.Drawing.Point(37, 31);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(43, 13);
            this.Length.TabIndex = 0;
            this.Length.Text = "Length:";
            // 
            // Width
            // 
            this.Width.AutoSize = true;
            this.Width.Location = new System.Drawing.Point(37, 57);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(38, 13);
            this.Width.TabIndex = 1;
            this.Width.Text = "Width:";
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Location = new System.Drawing.Point(37, 83);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(32, 13);
            this.Area.TabIndex = 2;
            this.Area.Text = "Area:";
            // 
            // Perimeter
            // 
            this.Perimeter.AutoSize = true;
            this.Perimeter.Location = new System.Drawing.Point(37, 109);
            this.Perimeter.Name = "Perimeter";
            this.Perimeter.Size = new System.Drawing.Size(54, 13);
            this.Perimeter.TabIndex = 3;
            this.Perimeter.Text = "Perimeter:";
            // 
            // AreaOutput
            // 
            this.AreaOutput.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.AreaOutput.Enabled = false;
            this.AreaOutput.Location = new System.Drawing.Point(111, 83);
            this.AreaOutput.Name = "AreaOutput";
            this.AreaOutput.Size = new System.Drawing.Size(126, 20);
            this.AreaOutput.TabIndex = 4;
            // 
            // PerimeterOutput
            // 
            this.PerimeterOutput.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PerimeterOutput.Enabled = false;
            this.PerimeterOutput.Location = new System.Drawing.Point(111, 109);
            this.PerimeterOutput.Name = "PerimeterOutput";
            this.PerimeterOutput.Size = new System.Drawing.Size(126, 20);
            this.PerimeterOutput.TabIndex = 5;
            // 
            // LengthInput
            // 
            this.LengthInput.Location = new System.Drawing.Point(111, 28);
            this.LengthInput.Name = "LengthInput";
            this.LengthInput.Size = new System.Drawing.Size(126, 20);
            this.LengthInput.TabIndex = 6;
            // 
            // WidthInput
            // 
            this.WidthInput.Location = new System.Drawing.Point(111, 54);
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(126, 20);
            this.WidthInput.TabIndex = 7;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(40, 144);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(73, 23);
            this.Calculate.TabIndex = 8;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(156, 144);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(81, 23);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AreaPerimeter
            // 
            this.AcceptButton = this.Calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 194);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.WidthInput);
            this.Controls.Add(this.LengthInput);
            this.Controls.Add(this.PerimeterOutput);
            this.Controls.Add(this.AreaOutput);
            this.Controls.Add(this.Perimeter);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.Length);
            this.Name = "AreaPerimeter";
            this.Text = "Area And Perimeter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Length;
        private System.Windows.Forms.Label Width;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Label Perimeter;
        private System.Windows.Forms.MaskedTextBox AreaOutput;
        private System.Windows.Forms.MaskedTextBox PerimeterOutput;
        private System.Windows.Forms.TextBox LengthInput;
        private System.Windows.Forms.TextBox WidthInput;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Exit;
    }
}

