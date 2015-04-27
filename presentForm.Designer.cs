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
            // presentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 638);
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
    }
}