namespace KairosApp
{
    partial class presentForm
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
            this.sermonTitleLabel = new System.Windows.Forms.Label();
            this.incomingSermonTitleLabel = new System.Windows.Forms.Label();
            this.sermonTextTextbox = new System.Windows.Forms.RichTextBox();
            this.stopwatchStartButton = new System.Windows.Forms.Button();
            this.stopwatchStopButton = new System.Windows.Forms.Button();
            this.stopwatchResetButton = new System.Windows.Forms.Button();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.currentSWvalueLabel = new System.Windows.Forms.Label();
            this.goalLabel = new System.Windows.Forms.Label();
            this.goalSWLabel = new System.Windows.Forms.Label();
            this.currentSermonTitleLabel = new System.Windows.Forms.Label();
            this.bibleVerseTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // sermonTitleLabel
            // 
            this.sermonTitleLabel.AutoSize = true;
            this.sermonTitleLabel.Location = new System.Drawing.Point(13, 13);
            this.sermonTitleLabel.Name = "sermonTitleLabel";
            this.sermonTitleLabel.Size = new System.Drawing.Size(30, 13);
            this.sermonTitleLabel.TabIndex = 0;
            this.sermonTitleLabel.Text = "Title:";
            // 
            // incomingSermonTitleLabel
            // 
            this.incomingSermonTitleLabel.AutoSize = true;
            this.incomingSermonTitleLabel.Location = new System.Drawing.Point(85, 13);
            this.incomingSermonTitleLabel.Name = "incomingSermonTitleLabel";
            this.incomingSermonTitleLabel.Size = new System.Drawing.Size(0, 13);
            this.incomingSermonTitleLabel.TabIndex = 1;
            // 
            // sermonTextTextbox
            // 
            this.sermonTextTextbox.Location = new System.Drawing.Point(12, 60);
            this.sermonTextTextbox.Name = "sermonTextTextbox";
            this.sermonTextTextbox.Size = new System.Drawing.Size(464, 566);
            this.sermonTextTextbox.TabIndex = 2;
            this.sermonTextTextbox.Text = "";
            // 
            // stopwatchStartButton
            // 
            this.stopwatchStartButton.Location = new System.Drawing.Point(507, 60);
            this.stopwatchStartButton.Name = "stopwatchStartButton";
            this.stopwatchStartButton.Size = new System.Drawing.Size(75, 23);
            this.stopwatchStartButton.TabIndex = 3;
            this.stopwatchStartButton.Text = "Start";
            this.stopwatchStartButton.UseVisualStyleBackColor = true;
            // 
            // stopwatchStopButton
            // 
            this.stopwatchStopButton.Location = new System.Drawing.Point(507, 89);
            this.stopwatchStopButton.Name = "stopwatchStopButton";
            this.stopwatchStopButton.Size = new System.Drawing.Size(75, 23);
            this.stopwatchStopButton.TabIndex = 4;
            this.stopwatchStopButton.Text = "Stop";
            this.stopwatchStopButton.UseVisualStyleBackColor = true;
            // 
            // stopwatchResetButton
            // 
            this.stopwatchResetButton.Location = new System.Drawing.Point(507, 118);
            this.stopwatchResetButton.Name = "stopwatchResetButton";
            this.stopwatchResetButton.Size = new System.Drawing.Size(75, 23);
            this.stopwatchResetButton.TabIndex = 5;
            this.stopwatchResetButton.Text = "Reset";
            this.stopwatchResetButton.UseVisualStyleBackColor = true;
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Location = new System.Drawing.Point(610, 60);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(44, 13);
            this.currentTimeLabel.TabIndex = 6;
            this.currentTimeLabel.Text = "Current:";
            // 
            // currentSWvalueLabel
            // 
            this.currentSWvalueLabel.AutoSize = true;
            this.currentSWvalueLabel.Location = new System.Drawing.Point(661, 60);
            this.currentSWvalueLabel.Name = "currentSWvalueLabel";
            this.currentSWvalueLabel.Size = new System.Drawing.Size(49, 13);
            this.currentSWvalueLabel.TabIndex = 7;
            this.currentSWvalueLabel.Text = "00:00:00";
            // 
            // goalLabel
            // 
            this.goalLabel.AutoSize = true;
            this.goalLabel.Location = new System.Drawing.Point(610, 89);
            this.goalLabel.Name = "goalLabel";
            this.goalLabel.Size = new System.Drawing.Size(32, 13);
            this.goalLabel.TabIndex = 8;
            this.goalLabel.Text = "Goal:";
            // 
            // goalSWLabel
            // 
            this.goalSWLabel.AutoSize = true;
            this.goalSWLabel.Location = new System.Drawing.Point(661, 89);
            this.goalSWLabel.Name = "goalSWLabel";
            this.goalSWLabel.Size = new System.Drawing.Size(34, 13);
            this.goalSWLabel.TabIndex = 9;
            this.goalSWLabel.Text = "45:00";
            // 
            // currentSermonTitleLabel
            // 
            this.currentSermonTitleLabel.AutoSize = true;
            this.currentSermonTitleLabel.Location = new System.Drawing.Point(76, 13);
            this.currentSermonTitleLabel.Name = "currentSermonTitleLabel";
            this.currentSermonTitleLabel.Size = new System.Drawing.Size(0, 13);
            this.currentSermonTitleLabel.TabIndex = 10;
            // 
            // bibleVerseTextBox
            // 
            this.bibleVerseTextBox.Location = new System.Drawing.Point(483, 180);
            this.bibleVerseTextBox.Name = "bibleVerseTextBox";
            this.bibleVerseTextBox.Size = new System.Drawing.Size(298, 432);
            this.bibleVerseTextBox.TabIndex = 11;
            this.bibleVerseTextBox.Text = "";
            // 
            // presentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 638);
            this.Controls.Add(this.bibleVerseTextBox);
            this.Controls.Add(this.currentSermonTitleLabel);
            this.Controls.Add(this.goalSWLabel);
            this.Controls.Add(this.goalLabel);
            this.Controls.Add(this.currentSWvalueLabel);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.stopwatchResetButton);
            this.Controls.Add(this.stopwatchStopButton);
            this.Controls.Add(this.stopwatchStartButton);
            this.Controls.Add(this.sermonTextTextbox);
            this.Controls.Add(this.incomingSermonTitleLabel);
            this.Controls.Add(this.sermonTitleLabel);
            this.Name = "presentForm";
            this.Text = "presentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sermonTitleLabel;
        private System.Windows.Forms.Label incomingSermonTitleLabel;
        private System.Windows.Forms.RichTextBox sermonTextTextbox;
        private System.Windows.Forms.Button stopwatchStartButton;
        private System.Windows.Forms.Button stopwatchStopButton;
        private System.Windows.Forms.Button stopwatchResetButton;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Label currentSWvalueLabel;
        private System.Windows.Forms.Label goalLabel;
        private System.Windows.Forms.Label goalSWLabel;
        private System.Windows.Forms.Label currentSermonTitleLabel;
        private System.Windows.Forms.RichTextBox bibleVerseTextBox;
    }
}