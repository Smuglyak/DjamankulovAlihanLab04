namespace DateTimePicker
{
    partial class DateTimePickerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dropOffDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dropOffDateLabel = new System.Windows.Forms.Label();
            this.estimatedDeliveryDate = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dropOffDateTimePicker
            // 
            this.dropOffDateTimePicker.Location = new System.Drawing.Point(12, 32);
            this.dropOffDateTimePicker.Name = "dropOffDateTimePicker";
            this.dropOffDateTimePicker.Size = new System.Drawing.Size(284, 27);
            this.dropOffDateTimePicker.TabIndex = 0;
            this.dropOffDateTimePicker.ValueChanged += new System.EventHandler(this.dropOffDateTimePicker_ValueChanged);
            // 
            // dropOffDateLabel
            // 
            this.dropOffDateLabel.AutoSize = true;
            this.dropOffDateLabel.Location = new System.Drawing.Point(12, 9);
            this.dropOffDateLabel.Name = "dropOffDateLabel";
            this.dropOffDateLabel.Size = new System.Drawing.Size(107, 20);
            this.dropOffDateLabel.TabIndex = 1;
            this.dropOffDateLabel.Text = "Drop Off Date:";
            // 
            // estimatedDeliveryDate
            // 
            this.estimatedDeliveryDate.AutoSize = true;
            this.estimatedDeliveryDate.Location = new System.Drawing.Point(12, 80);
            this.estimatedDeliveryDate.Name = "estimatedDeliveryDate";
            this.estimatedDeliveryDate.Size = new System.Drawing.Size(172, 20);
            this.estimatedDeliveryDate.TabIndex = 2;
            this.estimatedDeliveryDate.Text = "Estimated Delivery Date:";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Location = new System.Drawing.Point(12, 100);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(284, 29);
            this.outputLabel.TabIndex = 3;
            // 
            // DateTimePickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 161);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.estimatedDeliveryDate);
            this.Controls.Add(this.dropOffDateLabel);
            this.Controls.Add(this.dropOffDateTimePicker);
            this.Name = "DateTimePickerForm";
            this.Text = "DateTimePicker";
            this.Load += new System.EventHandler(this.DateTimePickerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dropOffDateTimePicker;
        private Label dropOffDateLabel;
        private Label estimatedDeliveryDate;
        private Label outputLabel;
    }
}