namespace ProcessLunchOrders
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
            this.gboxMainCourse = new System.Windows.Forms.GroupBox();
            this.rbtnSalad = new System.Windows.Forms.RadioButton();
            this.rbtnPizza = new System.Windows.Forms.RadioButton();
            this.rbtnHamburger = new System.Windows.Forms.RadioButton();
            this.gboxAddOnItems = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gboxOrderTotal = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gboxMainCourse.SuspendLayout();
            this.gboxAddOnItems.SuspendLayout();
            this.gboxOrderTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxMainCourse
            // 
            this.gboxMainCourse.Controls.Add(this.rbtnSalad);
            this.gboxMainCourse.Controls.Add(this.rbtnPizza);
            this.gboxMainCourse.Controls.Add(this.rbtnHamburger);
            this.gboxMainCourse.Location = new System.Drawing.Point(42, 30);
            this.gboxMainCourse.Name = "gboxMainCourse";
            this.gboxMainCourse.Size = new System.Drawing.Size(165, 96);
            this.gboxMainCourse.TabIndex = 0;
            this.gboxMainCourse.TabStop = false;
            this.gboxMainCourse.Text = "Main course";
            // 
            // rbtnSalad
            // 
            this.rbtnSalad.AutoSize = true;
            this.rbtnSalad.Location = new System.Drawing.Point(24, 65);
            this.rbtnSalad.Name = "rbtnSalad";
            this.rbtnSalad.Size = new System.Drawing.Size(88, 17);
            this.rbtnSalad.TabIndex = 2;
            this.rbtnSalad.TabStop = true;
            this.rbtnSalad.Text = "Salad - $4.95";
            this.rbtnSalad.UseVisualStyleBackColor = true;
            this.rbtnSalad.CheckedChanged += new System.EventHandler(this.RbtnSalad_CheckedChanged);
            // 
            // rbtnPizza
            // 
            this.rbtnPizza.AutoSize = true;
            this.rbtnPizza.Location = new System.Drawing.Point(24, 42);
            this.rbtnPizza.Name = "rbtnPizza";
            this.rbtnPizza.Size = new System.Drawing.Size(86, 17);
            this.rbtnPizza.TabIndex = 1;
            this.rbtnPizza.TabStop = true;
            this.rbtnPizza.Text = "Pizza - $5.95";
            this.rbtnPizza.UseVisualStyleBackColor = true;
            this.rbtnPizza.CheckedChanged += new System.EventHandler(this.RbtnPizza_CheckedChanged);
            // 
            // rbtnHamburger
            // 
            this.rbtnHamburger.AutoSize = true;
            this.rbtnHamburger.Location = new System.Drawing.Point(24, 19);
            this.rbtnHamburger.Name = "rbtnHamburger";
            this.rbtnHamburger.Size = new System.Drawing.Size(113, 17);
            this.rbtnHamburger.TabIndex = 0;
            this.rbtnHamburger.TabStop = true;
            this.rbtnHamburger.Text = "Hamburger - $6.95";
            this.rbtnHamburger.UseVisualStyleBackColor = true;
            this.rbtnHamburger.CheckedChanged += new System.EventHandler(this.RbtnHamburger_CheckedChanged);
            // 
            // gboxAddOnItems
            // 
            this.gboxAddOnItems.Controls.Add(this.checkBox3);
            this.gboxAddOnItems.Controls.Add(this.checkBox2);
            this.gboxAddOnItems.Controls.Add(this.checkBox1);
            this.gboxAddOnItems.Location = new System.Drawing.Point(213, 30);
            this.gboxAddOnItems.Name = "gboxAddOnItems";
            this.gboxAddOnItems.Size = new System.Drawing.Size(257, 96);
            this.gboxAddOnItems.TabIndex = 1;
            this.gboxAddOnItems.TabStop = false;
            this.gboxAddOnItems.Text = "Add-on Items ($.75/each)";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 65);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(81, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "French fries";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(161, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Ketchup, mustard, and mayo";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Lettuce, tomato, and onions";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // gboxOrderTotal
            // 
            this.gboxOrderTotal.Controls.Add(this.label4);
            this.gboxOrderTotal.Controls.Add(this.label3);
            this.gboxOrderTotal.Controls.Add(this.label1);
            this.gboxOrderTotal.Controls.Add(this.txtOrderTotal);
            this.gboxOrderTotal.Controls.Add(this.txtTax);
            this.gboxOrderTotal.Controls.Add(this.txtSubtotal);
            this.gboxOrderTotal.Location = new System.Drawing.Point(42, 151);
            this.gboxOrderTotal.Name = "gboxOrderTotal";
            this.gboxOrderTotal.Size = new System.Drawing.Size(257, 100);
            this.gboxOrderTotal.TabIndex = 2;
            this.gboxOrderTotal.TabStop = false;
            this.gboxOrderTotal.Text = "Order total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Order Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tax (7.75%):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subtotal:";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(129, 71);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(100, 20);
            this.txtOrderTotal.TabIndex = 2;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(129, 45);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 1;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(129, 19);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 0;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(336, 151);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(113, 39);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.BtnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(336, 222);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 29);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 279);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.gboxOrderTotal);
            this.Controls.Add(this.gboxAddOnItems);
            this.Controls.Add(this.gboxMainCourse);
            this.Name = "Form1";
            this.Text = "Lunch Order";
            this.gboxMainCourse.ResumeLayout(false);
            this.gboxMainCourse.PerformLayout();
            this.gboxAddOnItems.ResumeLayout(false);
            this.gboxAddOnItems.PerformLayout();
            this.gboxOrderTotal.ResumeLayout(false);
            this.gboxOrderTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxMainCourse;
        private System.Windows.Forms.RadioButton rbtnSalad;
        private System.Windows.Forms.RadioButton rbtnPizza;
        private System.Windows.Forms.RadioButton rbtnHamburger;
        private System.Windows.Forms.GroupBox gboxAddOnItems;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox gboxOrderTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
    }
}

