namespace KairosApp
{
    partial class presentationForm
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
            this.SuspendLayout();
            // 
            // sermonTitleLabel
            // 
            this.sermonTitleLabel.AutoSize = true;
            this.sermonTitleLabel.Location = new System.Drawing.Point(35, 40);
            this.sermonTitleLabel.Name = "sermonTitleLabel";
            this.sermonTitleLabel.Size = new System.Drawing.Size(30, 13);
            this.sermonTitleLabel.TabIndex = 0;
            this.sermonTitleLabel.Text = "Title:";
            // 
            // presentationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 626);
            this.Controls.Add(this.sermonTitleLabel);
            this.Name = "presentationForm";
            this.Text = "presentationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sermonTitleLabel;
    }
}