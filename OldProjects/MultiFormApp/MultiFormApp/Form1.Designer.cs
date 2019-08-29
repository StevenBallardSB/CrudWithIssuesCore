namespace MultiFormApp
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
            this.btnOpenAddStudentForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenAddStudentForm
            // 
            this.btnOpenAddStudentForm.Location = new System.Drawing.Point(66, 53);
            this.btnOpenAddStudentForm.Name = "btnOpenAddStudentForm";
            this.btnOpenAddStudentForm.Size = new System.Drawing.Size(157, 37);
            this.btnOpenAddStudentForm.TabIndex = 0;
            this.btnOpenAddStudentForm.Text = "Open Add Student Form";
            this.btnOpenAddStudentForm.UseVisualStyleBackColor = true;
            this.btnOpenAddStudentForm.Click += new System.EventHandler(this.btnOpenAddStudentForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenAddStudentForm);
            this.Name = "Form1";
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenAddStudentForm;
    }
}

