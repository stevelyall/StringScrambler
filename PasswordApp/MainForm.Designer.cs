namespace PasswordApp
{
    partial class MainForm
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
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordPromptLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(57, 90);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(231, 37);
            this.passwordTextBox.TabIndex = 0;
            // 
            // passwordPromptLabel
            // 
            this.passwordPromptLabel.AutoSize = true;
            this.passwordPromptLabel.Location = new System.Drawing.Point(83, 25);
            this.passwordPromptLabel.Name = "passwordPromptLabel";
            this.passwordPromptLabel.Size = new System.Drawing.Size(183, 30);
            this.passwordPromptLabel.TabIndex = 1;
            this.passwordPromptLabel.Text = "Enter a password:";
            // 
            // submitButton
            // 
            this.submitButton.AutoSize = true;
            this.submitButton.Location = new System.Drawing.Point(77, 172);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(91, 40);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "&Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(191, 173);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 40);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(382, 260);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.passwordPromptLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "MainForm";
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordPromptLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button exitButton;
    }
}

