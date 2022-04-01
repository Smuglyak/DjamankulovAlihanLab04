namespace UserDefinedControls
{
    partial class Clock
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
            this.clockUserControl1 = new UserDefinedControls.ClockUserControl();
            this.SuspendLayout();
            // 
            // clockUserControl1
            // 
            this.clockUserControl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.clockUserControl1.Location = new System.Drawing.Point(40, 27);
            this.clockUserControl1.Name = "clockUserControl1";
            this.clockUserControl1.Size = new System.Drawing.Size(328, 206);
            this.clockUserControl1.TabIndex = 0;
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(408, 261);
            this.Controls.Add(this.clockUserControl1);
            this.Name = "Clock";
            this.Text = "Clock";
            this.ResumeLayout(false);

        }

        #endregion

        private ClockUserControl clockUserControl1;
    }
}

