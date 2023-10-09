namespace SecretSantaMailer
{
    partial class LoginForm
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
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.InvalidLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTitleLable = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.InvalidLabel);
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.label2);
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Controls.Add(this.LoginTitleLable);
            this.LoginPanel.Controls.Add(this.PasswordInput);
            this.LoginPanel.Controls.Add(this.EmailInput);
            this.LoginPanel.Location = new System.Drawing.Point(12, 12);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(12);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(776, 426);
            this.LoginPanel.TabIndex = 0;
            // 
            // InvalidLabel
            // 
            this.InvalidLabel.AutoSize = true;
            this.InvalidLabel.BackColor = System.Drawing.Color.IndianRed;
            this.InvalidLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InvalidLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InvalidLabel.Location = new System.Drawing.Point(288, 63);
            this.InvalidLabel.Name = "InvalidLabel";
            this.InvalidLabel.Size = new System.Drawing.Size(216, 21);
            this.InvalidLabel.TabIndex = 6;
            this.InvalidLabel.Text = "Try Again... Credentials Invalid";
            this.InvalidLabel.Visible = false;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(360, 293);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email:";
            // 
            // LoginTitleLable
            // 
            this.LoginTitleLable.AutoSize = true;
            this.LoginTitleLable.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginTitleLable.Location = new System.Drawing.Point(320, 124);
            this.LoginTitleLable.Name = "LoginTitleLable";
            this.LoginTitleLable.Size = new System.Drawing.Size(115, 30);
            this.LoginTitleLable.TabIndex = 2;
            this.LoginTitleLable.Text = "Login Page";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(320, 237);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '#';
            this.PasswordInput.Size = new System.Drawing.Size(169, 23);
            this.PasswordInput.TabIndex = 1;
            this.PasswordInput.TextChanged += new System.EventHandler(this.PasswordInput_TextChanged);
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(320, 186);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(169, 23);
            this.EmailInput.TabIndex = 0;
            this.EmailInput.TextChanged += new System.EventHandler(this.EmailInput_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginPanel);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel LoginPanel;
        private Button LoginButton;
        private Label label2;
        private Label label1;
        private Label LoginTitleLable;
        private TextBox PasswordInput;
        private TextBox EmailInput;
        private Label InvalidLabel;
    }
}