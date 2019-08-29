namespace NameList
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnDisplayName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Name Here";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(27, 71);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(200, 40);
            this.btnAddName.TabIndex = 2;
            this.btnAddName.Text = "Add Name to List";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.BtnAddName_Click);
            // 
            // btnDisplayName
            // 
            this.btnDisplayName.Location = new System.Drawing.Point(27, 156);
            this.btnDisplayName.Name = "btnDisplayName";
            this.btnDisplayName.Size = new System.Drawing.Size(200, 41);
            this.btnDisplayName.TabIndex = 3;
            this.btnDisplayName.Text = "Display Names";
            this.btnDisplayName.UseVisualStyleBackColor = true;
            this.btnDisplayName.Click += new System.EventHandler(this.btnDisplayName_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAddName;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 250);
            this.Controls.Add(this.btnDisplayName);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Name List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnDisplayName;
    }
}

