namespace EE9_1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.lblAveragePricePerNight = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblNumberOfNights = new System.Windows.Forms.Label();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtAveragePricePerNight = new System.Windows.Forms.TextBox();
            this.txtNumberOfNights = new System.Windows.Forms.TextBox();
            this.dtpArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(68, 520);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(165, 60);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(317, 520);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(165, 60);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(573, 520);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(165, 60);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblArrivalDate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalDate.ForeColor = System.Drawing.Color.White;
            this.lblArrivalDate.Location = new System.Drawing.Point(154, 33);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(234, 37);
            this.lblArrivalDate.TabIndex = 8;
            this.lblArrivalDate.Text = "Arrival Date:";
            this.lblArrivalDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAveragePricePerNight
            // 
            this.lblAveragePricePerNight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblAveragePricePerNight.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAveragePricePerNight.ForeColor = System.Drawing.Color.White;
            this.lblAveragePricePerNight.Location = new System.Drawing.Point(154, 434);
            this.lblAveragePricePerNight.Name = "lblAveragePricePerNight";
            this.lblAveragePricePerNight.Size = new System.Drawing.Size(234, 37);
            this.lblAveragePricePerNight.TabIndex = 12;
            this.lblAveragePricePerNight.Text = "Avg Price Per Night:";
            this.lblAveragePricePerNight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTotalPrice.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Location = new System.Drawing.Point(154, 334);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(234, 37);
            this.lblTotalPrice.TabIndex = 11;
            this.lblTotalPrice.Text = "Total Price:";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberOfNights
            // 
            this.lblNumberOfNights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblNumberOfNights.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfNights.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfNights.Location = new System.Drawing.Point(154, 233);
            this.lblNumberOfNights.Name = "lblNumberOfNights";
            this.lblNumberOfNights.Size = new System.Drawing.Size(234, 37);
            this.lblNumberOfNights.TabIndex = 10;
            this.lblNumberOfNights.Text = "Number Of Nights:";
            this.lblNumberOfNights.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblDepartureDate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureDate.ForeColor = System.Drawing.Color.White;
            this.lblDepartureDate.Location = new System.Drawing.Point(154, 138);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(234, 37);
            this.lblDepartureDate.TabIndex = 9;
            this.lblDepartureDate.Text = "Departure Date:";
            this.lblDepartureDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(420, 331);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(165, 38);
            this.txtTotalPrice.TabIndex = 6;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAveragePricePerNight
            // 
            this.txtAveragePricePerNight.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAveragePricePerNight.Location = new System.Drawing.Point(420, 431);
            this.txtAveragePricePerNight.Name = "txtAveragePricePerNight";
            this.txtAveragePricePerNight.ReadOnly = true;
            this.txtAveragePricePerNight.Size = new System.Drawing.Size(165, 38);
            this.txtAveragePricePerNight.TabIndex = 7;
            this.txtAveragePricePerNight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumberOfNights
            // 
            this.txtNumberOfNights.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfNights.Location = new System.Drawing.Point(427, 230);
            this.txtNumberOfNights.Name = "txtNumberOfNights";
            this.txtNumberOfNights.ReadOnly = true;
            this.txtNumberOfNights.Size = new System.Drawing.Size(165, 38);
            this.txtNumberOfNights.TabIndex = 5;
            this.txtNumberOfNights.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.CalendarFont = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpArrivalDate.Location = new System.Drawing.Point(409, 33);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.Size = new System.Drawing.Size(200, 20);
            this.dtpArrivalDate.TabIndex = 0;
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.CalendarFont = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDepartureDate.Location = new System.Drawing.Point(409, 138);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDepartureDate.TabIndex = 1;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(785, 643);
            this.Controls.Add(this.dtpDepartureDate);
            this.Controls.Add(this.dtpArrivalDate);
            this.Controls.Add(this.txtNumberOfNights);
            this.Controls.Add(this.txtAveragePricePerNight);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.lblDepartureDate);
            this.Controls.Add(this.lblNumberOfNights);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblAveragePricePerNight);
            this.Controls.Add(this.lblArrivalDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations - Extra Exercises 9-1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.Label lblAveragePricePerNight;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblNumberOfNights;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtAveragePricePerNight;
        private System.Windows.Forms.TextBox txtNumberOfNights;
        private System.Windows.Forms.DateTimePicker dtpArrivalDate;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
    }
}

