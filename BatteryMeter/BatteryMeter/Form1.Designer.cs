namespace BatteryMeter
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
            this.components = new System.ComponentModel.Container();
            this.PercentageProgressBar = new System.Windows.Forms.ProgressBar();
            this.PercentageLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PercentageProgressBar
            // 
            this.PercentageProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PercentageProgressBar.Location = new System.Drawing.Point(12, 12);
            this.PercentageProgressBar.Name = "PercentageProgressBar";
            this.PercentageProgressBar.Size = new System.Drawing.Size(703, 25);
            this.PercentageProgressBar.TabIndex = 0;
            // 
            // PercentageLabel
            // 
            this.PercentageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PercentageLabel.Location = new System.Drawing.Point(721, 12);
            this.PercentageLabel.Name = "PercentageLabel";
            this.PercentageLabel.Size = new System.Drawing.Size(67, 25);
            this.PercentageLabel.TabIndex = 1;
            this.PercentageLabel.Text = "0%";
            this.PercentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(12, 40);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(174, 17);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "Time Remaining: 00:00:00";
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 1000;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 66);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.PercentageLabel);
            this.Controls.Add(this.PercentageProgressBar);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar PercentageProgressBar;
        private System.Windows.Forms.Label PercentageLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer UpdateTimer;
    }
}

