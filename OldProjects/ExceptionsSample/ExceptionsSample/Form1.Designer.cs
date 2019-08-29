namespace ExceptionsSample
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblAgeErrMsg = new System.Windows.Forms.Label();
            this.btnValidateUsername = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(103, 52);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 1;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(46, 136);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(157, 23);
            this.btnValidate.TabIndex = 2;
            this.btnValidate.Text = "Validate Input";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.BtnValidate_Click);
            // 
            // lblAgeErrMsg
            // 
            this.lblAgeErrMsg.AutoSize = true;
            this.lblAgeErrMsg.ForeColor = System.Drawing.Color.Red;
            this.lblAgeErrMsg.Location = new System.Drawing.Point(225, 52);
            this.lblAgeErrMsg.Name = "lblAgeErrMsg";
            this.lblAgeErrMsg.Size = new System.Drawing.Size(0, 13);
            this.lblAgeErrMsg.TabIndex = 3;
            // 
            // btnValidateUsername
            // 
            this.btnValidateUsername.Location = new System.Drawing.Point(228, 86);
            this.btnValidateUsername.Name = "btnValidateUsername";
            this.btnValidateUsername.Size = new System.Drawing.Size(108, 23);
            this.btnValidateUsername.TabIndex = 4;
            this.btnValidateUsername.Text = "Validate Username";
            this.btnValidateUsername.UseVisualStyleBackColor = true;
            this.btnValidateUsername.Click += new System.EventHandler(this.btnValidateUsername_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(103, 88);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 196);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnValidateUsername);
            this.Controls.Add(this.lblAgeErrMsg);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Exception Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblAgeErrMsg;
        private System.Windows.Forms.Button btnValidateUsername;
        private System.Windows.Forms.TextBox txtUserName;
    }
}

