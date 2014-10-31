namespace PasswordApp
{
    partial class newPassForm
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
            this.startOverButton = new System.Windows.Forms.Button();
            this.newPassLabel = new System.Windows.Forms.Label();
            this.newPassResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startOverButton
            // 
            this.startOverButton.AutoSize = true;
            this.startOverButton.Location = new System.Drawing.Point(119, 147);
            this.startOverButton.Name = "startOverButton";
            this.startOverButton.Size = new System.Drawing.Size(142, 67);
            this.startOverButton.TabIndex = 0;
            this.startOverButton.Text = "Go &Back";
            this.startOverButton.UseVisualStyleBackColor = true;
            this.startOverButton.Click += new System.EventHandler(this.startOverButton_Click);
            // 
            // newPassLabel
            // 
            this.newPassLabel.AutoSize = true;
            this.newPassLabel.Location = new System.Drawing.Point(97, 29);
            this.newPassLabel.Name = "newPassLabel";
            this.newPassLabel.Size = new System.Drawing.Size(207, 30);
            this.newPassLabel.TabIndex = 1;
            this.newPassLabel.Text = "Your new password:";
            // 
            // newPassResult
            // 
            this.newPassResult.AutoSize = true;
            this.newPassResult.Location = new System.Drawing.Point(153, 87);
            this.newPassResult.Name = "newPassResult";
            this.newPassResult.Size = new System.Drawing.Size(0, 30);
            this.newPassResult.TabIndex = 2;
            this.newPassResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 259);
            this.Controls.Add(this.newPassResult);
            this.Controls.Add(this.newPassLabel);
            this.Controls.Add(this.startOverButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "newPassForm";
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startOverButton;
        private System.Windows.Forms.Label newPassLabel;
        private System.Windows.Forms.Label newPassResult;
    }
}