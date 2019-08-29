namespace FactorialCalculator
{
    partial class Form1
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
            this.NumberLbl = new System.Windows.Forms.Label();
            this.FactorialLbl = new System.Windows.Forms.Label();
            this.NumberTxt = new System.Windows.Forms.TextBox();
            this.FactorialTxt = new System.Windows.Forms.TextBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumberLbl
            // 
            this.NumberLbl.AutoSize = true;
            this.NumberLbl.Location = new System.Drawing.Point(41, 34);
            this.NumberLbl.Name = "NumberLbl";
            this.NumberLbl.Size = new System.Drawing.Size(47, 13);
            this.NumberLbl.TabIndex = 0;
            this.NumberLbl.Text = "Number:";
            // 
            // FactorialLbl
            // 
            this.FactorialLbl.AutoSize = true;
            this.FactorialLbl.Location = new System.Drawing.Point(38, 73);
            this.FactorialLbl.Name = "FactorialLbl";
            this.FactorialLbl.Size = new System.Drawing.Size(50, 13);
            this.FactorialLbl.TabIndex = 1;
            this.FactorialLbl.Text = "Factorial:";
            // 
            // NumberTxt
            // 
            this.NumberTxt.Location = new System.Drawing.Point(96, 31);
            this.NumberTxt.Name = "NumberTxt";
            this.NumberTxt.Size = new System.Drawing.Size(27, 20);
            this.NumberTxt.TabIndex = 2;
            // 
            // FactorialTxt
            // 
            this.FactorialTxt.Enabled = false;
            this.FactorialTxt.Location = new System.Drawing.Point(96, 70);
            this.FactorialTxt.Name = "FactorialTxt";
            this.FactorialTxt.Size = new System.Drawing.Size(171, 20);
            this.FactorialTxt.TabIndex = 3;
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(73, 126);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(86, 23);
            this.CalcBtn.TabIndex = 4;
            this.CalcBtn.Text = "Calculate";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(186, 126);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(81, 23);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.CalcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 190);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.FactorialTxt);
            this.Controls.Add(this.NumberTxt);
            this.Controls.Add(this.FactorialLbl);
            this.Controls.Add(this.NumberLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumberLbl;
        private System.Windows.Forms.Label FactorialLbl;
        private System.Windows.Forms.TextBox NumberTxt;
        private System.Windows.Forms.TextBox FactorialTxt;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

