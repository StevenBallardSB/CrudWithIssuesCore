namespace BookRegistrationSystem
{
    partial class frmBookRegistration
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
            this.cboxCustomer = new System.Windows.Forms.ComboBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.cboxBook = new System.Windows.Forms.ComboBox();
            this.dtpDateRegistered = new System.Windows.Forms.DateTimePicker();
            this.btnRegisterBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboxCustomer
            // 
            this.cboxCustomer.FormattingEnabled = true;
            this.cboxCustomer.Location = new System.Drawing.Point(62, 43);
            this.cboxCustomer.Name = "cboxCustomer";
            this.cboxCustomer.Size = new System.Drawing.Size(222, 21);
            this.cboxCustomer.TabIndex = 0;
            this.cboxCustomer.Text = "Choose a Customer";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(337, 43);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(187, 79);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(337, 154);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(187, 78);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // cboxBook
            // 
            this.cboxBook.FormattingEnabled = true;
            this.cboxBook.Location = new System.Drawing.Point(62, 101);
            this.cboxBook.Name = "cboxBook";
            this.cboxBook.Size = new System.Drawing.Size(222, 21);
            this.cboxBook.TabIndex = 3;
            this.cboxBook.Text = "Choose a Book";
            // 
            // dtpDateRegistered
            // 
            this.dtpDateRegistered.Location = new System.Drawing.Point(62, 154);
            this.dtpDateRegistered.Name = "dtpDateRegistered";
            this.dtpDateRegistered.Size = new System.Drawing.Size(222, 20);
            this.dtpDateRegistered.TabIndex = 4;
            // 
            // btnRegisterBook
            // 
            this.btnRegisterBook.Location = new System.Drawing.Point(62, 211);
            this.btnRegisterBook.Name = "btnRegisterBook";
            this.btnRegisterBook.Size = new System.Drawing.Size(222, 71);
            this.btnRegisterBook.TabIndex = 5;
            this.btnRegisterBook.Text = "Register Book";
            this.btnRegisterBook.UseVisualStyleBackColor = true;
            this.btnRegisterBook.Click += new System.EventHandler(this.BtnRegisterBook_Click);
            // 
            // frmBookRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 340);
            this.Controls.Add(this.btnRegisterBook);
            this.Controls.Add(this.dtpDateRegistered);
            this.Controls.Add(this.cboxBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.cboxCustomer);
            this.Name = "frmBookRegistration";
            this.Text = "Book Registration";
            this.Load += new System.EventHandler(this.FrmBookRegistration_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.ComboBox cboxBook;
        private System.Windows.Forms.DateTimePicker dtpDateRegistered;
        private System.Windows.Forms.Button btnRegisterBook;
    }
}

