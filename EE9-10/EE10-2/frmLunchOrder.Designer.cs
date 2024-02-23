namespace EE10_2
{
    partial class frmLunchOrder
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
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbMainCourses = new System.Windows.Forms.GroupBox();
            this.radSalad = new System.Windows.Forms.RadioButton();
            this.radPizza = new System.Windows.Forms.RadioButton();
            this.radBurger = new System.Windows.Forms.RadioButton();
            this.gbAddOns = new System.Windows.Forms.GroupBox();
            this.chkAddOn3 = new System.Windows.Forms.CheckBox();
            this.chkAddOn2 = new System.Windows.Forms.CheckBox();
            this.chkAddOn1 = new System.Windows.Forms.CheckBox();
            this.gbOrderTotal = new System.Windows.Forms.GroupBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.gbMainCourses.SuspendLayout();
            this.gbAddOns.SuspendLayout();
            this.gbOrderTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(140, 601);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(206, 68);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Place &Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(482, 601);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(206, 68);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(835, 601);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(206, 68);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbMainCourses
            // 
            this.gbMainCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gbMainCourses.Controls.Add(this.radSalad);
            this.gbMainCourses.Controls.Add(this.radPizza);
            this.gbMainCourses.Controls.Add(this.radBurger);
            this.gbMainCourses.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMainCourses.Location = new System.Drawing.Point(140, 45);
            this.gbMainCourses.Name = "gbMainCourses";
            this.gbMainCourses.Size = new System.Drawing.Size(423, 230);
            this.gbMainCourses.TabIndex = 0;
            this.gbMainCourses.TabStop = false;
            this.gbMainCourses.Text = "Main Courses";
            // 
            // radSalad
            // 
            this.radSalad.AutoSize = true;
            this.radSalad.Location = new System.Drawing.Point(92, 159);
            this.radSalad.Name = "radSalad";
            this.radSalad.Size = new System.Drawing.Size(176, 35);
            this.radSalad.TabIndex = 2;
            this.radSalad.TabStop = true;
            this.radSalad.Text = " Salad  - $6.75";
            this.radSalad.UseVisualStyleBackColor = true;
            this.radSalad.CheckedChanged += new System.EventHandler(this.radSalad_CheckedChanged);
            // 
            // radPizza
            // 
            this.radPizza.AutoSize = true;
            this.radPizza.Location = new System.Drawing.Point(89, 106);
            this.radPizza.Name = "radPizza";
            this.radPizza.Size = new System.Drawing.Size(178, 35);
            this.radPizza.TabIndex = 1;
            this.radPizza.TabStop = true;
            this.radPizza.Text = " Pizza   - $6.95";
            this.radPizza.UseVisualStyleBackColor = true;
            this.radPizza.CheckedChanged += new System.EventHandler(this.radPizza_CheckedChanged);
            // 
            // radBurger
            // 
            this.radBurger.AutoSize = true;
            this.radBurger.Location = new System.Drawing.Point(89, 52);
            this.radBurger.Name = "radBurger";
            this.radBurger.Size = new System.Drawing.Size(179, 35);
            this.radBurger.TabIndex = 0;
            this.radBurger.TabStop = true;
            this.radBurger.Text = "Burger - $7.95";
            this.radBurger.UseVisualStyleBackColor = true;
            this.radBurger.CheckedChanged += new System.EventHandler(this.radBurger_CheckedChanged);
            // 
            // gbAddOns
            // 
            this.gbAddOns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gbAddOns.Controls.Add(this.chkAddOn3);
            this.gbAddOns.Controls.Add(this.chkAddOn2);
            this.gbAddOns.Controls.Add(this.chkAddOn1);
            this.gbAddOns.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddOns.Location = new System.Drawing.Point(618, 45);
            this.gbAddOns.Name = "gbAddOns";
            this.gbAddOns.Size = new System.Drawing.Size(423, 230);
            this.gbAddOns.TabIndex = 1;
            this.gbAddOns.TabStop = false;
            this.gbAddOns.Text = "Add-Ons";
            // 
            // chkAddOn3
            // 
            this.chkAddOn3.AutoSize = true;
            this.chkAddOn3.Location = new System.Drawing.Point(51, 159);
            this.chkAddOn3.Name = "chkAddOn3";
            this.chkAddOn3.Size = new System.Drawing.Size(167, 35);
            this.chkAddOn3.TabIndex = 2;
            this.chkAddOn3.Text = "French Fries";
            this.chkAddOn3.UseVisualStyleBackColor = true;
            // 
            // chkAddOn2
            // 
            this.chkAddOn2.AutoSize = true;
            this.chkAddOn2.Location = new System.Drawing.Point(51, 106);
            this.chkAddOn2.Name = "chkAddOn2";
            this.chkAddOn2.Size = new System.Drawing.Size(324, 35);
            this.chkAddOn2.TabIndex = 1;
            this.chkAddOn2.Text = "ketchup, Mustard and Mayo";
            this.chkAddOn2.UseVisualStyleBackColor = true;
            // 
            // chkAddOn1
            // 
            this.chkAddOn1.AutoSize = true;
            this.chkAddOn1.Location = new System.Drawing.Point(51, 52);
            this.chkAddOn1.Name = "chkAddOn1";
            this.chkAddOn1.Size = new System.Drawing.Size(333, 35);
            this.chkAddOn1.TabIndex = 0;
            this.chkAddOn1.Text = "Lettuce, Tomato and Onions";
            this.chkAddOn1.UseVisualStyleBackColor = true;
            // 
            // gbOrderTotal
            // 
            this.gbOrderTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gbOrderTotal.Controls.Add(this.txtOrderTotal);
            this.gbOrderTotal.Controls.Add(this.txtTax);
            this.gbOrderTotal.Controls.Add(this.txtSubtotal);
            this.gbOrderTotal.Controls.Add(this.lblOrderTotal);
            this.gbOrderTotal.Controls.Add(this.lblTax);
            this.gbOrderTotal.Controls.Add(this.lblSubtotal);
            this.gbOrderTotal.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderTotal.Location = new System.Drawing.Point(265, 328);
            this.gbOrderTotal.Name = "gbOrderTotal";
            this.gbOrderTotal.Size = new System.Drawing.Size(673, 230);
            this.gbOrderTotal.TabIndex = 2;
            this.gbOrderTotal.TabStop = false;
            this.gbOrderTotal.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(343, 169);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(181, 38);
            this.txtOrderTotal.TabIndex = 2;
            this.txtOrderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(343, 107);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(181, 38);
            this.txtTax.TabIndex = 1;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(343, 42);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(181, 38);
            this.txtSubtotal.TabIndex = 0;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOrderTotal.Location = new System.Drawing.Point(126, 172);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(170, 41);
            this.lblOrderTotal.TabIndex = 5;
            this.lblOrderTotal.Text = "Order Total:";
            this.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTax
            // 
            this.lblTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTax.Location = new System.Drawing.Point(126, 107);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(170, 41);
            this.lblTax.TabIndex = 4;
            this.lblTax.Text = "Tax (7.75%)";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSubtotal.Location = new System.Drawing.Point(126, 42);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(170, 41);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLunchOrder
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1121, 698);
            this.Controls.Add(this.gbOrderTotal);
            this.Controls.Add(this.gbAddOns);
            this.Controls.Add(this.gbMainCourses);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPlaceOrder);
            this.Name = "frmLunchOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch Order - Extra Exercise 10-2";
            this.Load += new System.EventHandler(this.frmLunchOrder_Load);
            this.gbMainCourses.ResumeLayout(false);
            this.gbMainCourses.PerformLayout();
            this.gbAddOns.ResumeLayout(false);
            this.gbAddOns.PerformLayout();
            this.gbOrderTotal.ResumeLayout(false);
            this.gbOrderTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbMainCourses;
        private System.Windows.Forms.RadioButton radSalad;
        private System.Windows.Forms.RadioButton radPizza;
        private System.Windows.Forms.RadioButton radBurger;
        private System.Windows.Forms.GroupBox gbAddOns;
        private System.Windows.Forms.GroupBox gbOrderTotal;
        private System.Windows.Forms.CheckBox chkAddOn3;
        private System.Windows.Forms.CheckBox chkAddOn2;
        private System.Windows.Forms.CheckBox chkAddOn1;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
    }
}

