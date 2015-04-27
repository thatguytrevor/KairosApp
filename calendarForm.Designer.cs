namespace KairosApp
{
    partial class calendarForm
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.sermonLabel = new System.Windows.Forms.Label();
            this.whatIsLoveLabel = new System.Windows.Forms.Label();
            this.christHasRisenLabel = new System.Windows.Forms.Label();
            this.alphaAndOmegaSermonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(29, 18);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TrailingForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // sermonLabel
            // 
            this.sermonLabel.AutoSize = true;
            this.sermonLabel.Location = new System.Drawing.Point(93, 189);
            this.sermonLabel.Name = "sermonLabel";
            this.sermonLabel.Size = new System.Drawing.Size(46, 13);
            this.sermonLabel.TabIndex = 1;
            this.sermonLabel.Text = "Sermon:";
            // 
            // whatIsLoveLabel
            // 
            this.whatIsLoveLabel.AutoSize = true;
            this.whatIsLoveLabel.Location = new System.Drawing.Point(93, 218);
            this.whatIsLoveLabel.Name = "whatIsLoveLabel";
            this.whatIsLoveLabel.Size = new System.Drawing.Size(95, 13);
            this.whatIsLoveLabel.TabIndex = 2;
            this.whatIsLoveLabel.Text = "4/5: What is love?";
            // 
            // christHasRisenLabel
            // 
            this.christHasRisenLabel.AutoSize = true;
            this.christHasRisenLabel.Location = new System.Drawing.Point(93, 241);
            this.christHasRisenLabel.Name = "christHasRisenLabel";
            this.christHasRisenLabel.Size = new System.Drawing.Size(112, 13);
            this.christHasRisenLabel.TabIndex = 3;
            this.christHasRisenLabel.Text = "4/12: Christ has Risen";
            // 
            // alphaAndOmegaSermonLabel
            // 
            this.alphaAndOmegaSermonLabel.AutoSize = true;
            this.alphaAndOmegaSermonLabel.Location = new System.Drawing.Point(93, 266);
            this.alphaAndOmegaSermonLabel.Name = "alphaAndOmegaSermonLabel";
            this.alphaAndOmegaSermonLabel.Size = new System.Drawing.Size(121, 13);
            this.alphaAndOmegaSermonLabel.TabIndex = 4;
            this.alphaAndOmegaSermonLabel.Text = "4/19: Alpha and Omega";
            this.alphaAndOmegaSermonLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // calendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 315);
            this.Controls.Add(this.alphaAndOmegaSermonLabel);
            this.Controls.Add(this.christHasRisenLabel);
            this.Controls.Add(this.whatIsLoveLabel);
            this.Controls.Add(this.sermonLabel);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "calendarForm";
            this.Text = "calendarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label sermonLabel;
        private System.Windows.Forms.Label whatIsLoveLabel;
        private System.Windows.Forms.Label christHasRisenLabel;
        private System.Windows.Forms.Label alphaAndOmegaSermonLabel;
    }
}