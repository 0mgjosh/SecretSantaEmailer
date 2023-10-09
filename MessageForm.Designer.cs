namespace SecretSantaMailer
{
    partial class MessageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomMessageTextBox = new System.Windows.Forms.TextBox();
            this.MessagePreviewTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SendEmailButton = new System.Windows.Forms.Button();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email Creation";
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Location = new System.Drawing.Point(276, 168);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(228, 23);
            this.SubjectTextBox.TabIndex = 1;
            this.SubjectTextBox.Text = "🎁🎅Secret Santa🎅🎁";
            this.SubjectTextBox.TextChanged += new System.EventHandler(this.SubjectTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subject:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Custom Message:";
            // 
            // CustomMessageTextBox
            // 
            this.CustomMessageTextBox.Location = new System.Drawing.Point(276, 199);
            this.CustomMessageTextBox.Multiline = true;
            this.CustomMessageTextBox.Name = "CustomMessageTextBox";
            this.CustomMessageTextBox.Size = new System.Drawing.Size(228, 108);
            this.CustomMessageTextBox.TabIndex = 6;
            this.CustomMessageTextBox.TextChanged += new System.EventHandler(this.CustomMessageTextBox_TextChanged);
            // 
            // MessagePreviewTextBox
            // 
            this.MessagePreviewTextBox.Location = new System.Drawing.Point(740, 199);
            this.MessagePreviewTextBox.Multiline = true;
            this.MessagePreviewTextBox.Name = "MessagePreviewTextBox";
            this.MessagePreviewTextBox.ReadOnly = true;
            this.MessagePreviewTextBox.Size = new System.Drawing.Size(359, 176);
            this.MessagePreviewTextBox.TabIndex = 7;
            this.MessagePreviewTextBox.Visible = false;
            this.MessagePreviewTextBox.TextChanged += new System.EventHandler(this.MessagePreviewTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(740, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Message Preview";
            this.label5.Visible = false;
            // 
            // SendEmailButton
            // 
            this.SendEmailButton.Location = new System.Drawing.Point(253, 404);
            this.SendEmailButton.Name = "SendEmailButton";
            this.SendEmailButton.Size = new System.Drawing.Size(234, 34);
            this.SendEmailButton.TabIndex = 9;
            this.SendEmailButton.Text = "Send Email";
            this.SendEmailButton.UseVisualStyleBackColor = true;
            this.SendEmailButton.Click += new System.EventHandler(this.SendEmailButton_Click);
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.BackColor = System.Drawing.Color.IndianRed;
            this.WarningLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WarningLabel.Location = new System.Drawing.Point(528, 410);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(233, 20);
            this.WarningLabel.TabIndex = 10;
            this.WarningLabel.Text = "Something went wrong. Try again.";
            this.WarningLabel.Visible = false;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.SendEmailButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MessagePreviewTextBox);
            this.Controls.Add(this.CustomMessageTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.label1);
            this.Name = "MessageForm";
            this.Text = "MessageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox SubjectTextBox;
        private Label label3;
        private Label label4;
        private TextBox CustomMessageTextBox;
        private TextBox MessagePreviewTextBox;
        private Label label5;
        private Button SendEmailButton;
        private Label WarningLabel;
    }
}