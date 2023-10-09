namespace SecretSantaMailer
{
    partial class CreationForm
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
            this.CreateListPanel = new System.Windows.Forms.Panel();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.SelectedPanel = new System.Windows.Forms.Panel();
            this.SelectedAddress = new System.Windows.Forms.TextBox();
            this.SelectedEmail = new System.Windows.Forms.TextBox();
            this.SelectedName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NoRemoveButton = new System.Windows.Forms.Button();
            this.YesRemoveButton = new System.Windows.Forms.Button();
            this.RemovePersonLabel = new System.Windows.Forms.Label();
            this.ProceedButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateListPanel.SuspendLayout();
            this.SelectedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateListPanel
            // 
            this.CreateListPanel.Controls.Add(this.SelectedPanel);
            this.CreateListPanel.Controls.Add(this.WarningLabel);
            this.CreateListPanel.Controls.Add(this.ProceedButton);
            this.CreateListPanel.Controls.Add(this.label7);
            this.CreateListPanel.Controls.Add(this.AddButton);
            this.CreateListPanel.Controls.Add(this.label6);
            this.CreateListPanel.Controls.Add(this.label5);
            this.CreateListPanel.Controls.Add(this.label4);
            this.CreateListPanel.Controls.Add(this.AddressTextBox);
            this.CreateListPanel.Controls.Add(this.EmailTextBox);
            this.CreateListPanel.Controls.Add(this.NameTextBox);
            this.CreateListPanel.Controls.Add(this.ListBox);
            this.CreateListPanel.Controls.Add(this.label3);
            this.CreateListPanel.Location = new System.Drawing.Point(12, 12);
            this.CreateListPanel.Margin = new System.Windows.Forms.Padding(12);
            this.CreateListPanel.Name = "CreateListPanel";
            this.CreateListPanel.Size = new System.Drawing.Size(776, 426);
            this.CreateListPanel.TabIndex = 7;
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.BackColor = System.Drawing.Color.IndianRed;
            this.WarningLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WarningLabel.Location = new System.Drawing.Point(479, 47);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(116, 15);
            this.WarningLabel.TabIndex = 12;
            this.WarningLabel.Text = "Add at least 3 parties";
            this.WarningLabel.Visible = false;
            // 
            // SelectedPanel
            // 
            this.SelectedPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SelectedPanel.Controls.Add(this.SelectedAddress);
            this.SelectedPanel.Controls.Add(this.SelectedEmail);
            this.SelectedPanel.Controls.Add(this.SelectedName);
            this.SelectedPanel.Controls.Add(this.label8);
            this.SelectedPanel.Controls.Add(this.label2);
            this.SelectedPanel.Controls.Add(this.label1);
            this.SelectedPanel.Controls.Add(this.NoRemoveButton);
            this.SelectedPanel.Controls.Add(this.YesRemoveButton);
            this.SelectedPanel.Controls.Add(this.RemovePersonLabel);
            this.SelectedPanel.Location = new System.Drawing.Point(103, 100);
            this.SelectedPanel.Margin = new System.Windows.Forms.Padding(12);
            this.SelectedPanel.Name = "SelectedPanel";
            this.SelectedPanel.Size = new System.Drawing.Size(553, 263);
            this.SelectedPanel.TabIndex = 11;
            this.SelectedPanel.Visible = false;
            // 
            // SelectedAddress
            // 
            this.SelectedAddress.Location = new System.Drawing.Point(163, 130);
            this.SelectedAddress.Multiline = true;
            this.SelectedAddress.Name = "SelectedAddress";
            this.SelectedAddress.ReadOnly = true;
            this.SelectedAddress.Size = new System.Drawing.Size(271, 72);
            this.SelectedAddress.TabIndex = 8;
            // 
            // SelectedEmail
            // 
            this.SelectedEmail.Location = new System.Drawing.Point(163, 79);
            this.SelectedEmail.Name = "SelectedEmail";
            this.SelectedEmail.ReadOnly = true;
            this.SelectedEmail.Size = new System.Drawing.Size(271, 23);
            this.SelectedEmail.TabIndex = 7;
            // 
            // SelectedName
            // 
            this.SelectedName.Location = new System.Drawing.Point(163, 29);
            this.SelectedName.Name = "SelectedName";
            this.SelectedName.ReadOnly = true;
            this.SelectedName.Size = new System.Drawing.Size(271, 23);
            this.SelectedName.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // NoRemoveButton
            // 
            this.NoRemoveButton.Location = new System.Drawing.Point(359, 212);
            this.NoRemoveButton.Name = "NoRemoveButton";
            this.NoRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.NoRemoveButton.TabIndex = 2;
            this.NoRemoveButton.Text = "No";
            this.NoRemoveButton.UseVisualStyleBackColor = true;
            this.NoRemoveButton.Click += new System.EventHandler(this.NoRemoveButton_Click);
            // 
            // YesRemoveButton
            // 
            this.YesRemoveButton.Location = new System.Drawing.Point(278, 212);
            this.YesRemoveButton.Name = "YesRemoveButton";
            this.YesRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.YesRemoveButton.TabIndex = 1;
            this.YesRemoveButton.Text = "Yes";
            this.YesRemoveButton.UseVisualStyleBackColor = true;
            this.YesRemoveButton.Click += new System.EventHandler(this.YesRemoveButton_Click);
            // 
            // RemovePersonLabel
            // 
            this.RemovePersonLabel.AutoSize = true;
            this.RemovePersonLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemovePersonLabel.Location = new System.Drawing.Point(108, 205);
            this.RemovePersonLabel.Name = "RemovePersonLabel";
            this.RemovePersonLabel.Size = new System.Drawing.Size(164, 30);
            this.RemovePersonLabel.TabIndex = 0;
            this.RemovePersonLabel.Text = "Remove Person?";
            // 
            // ProceedButton
            // 
            this.ProceedButton.Location = new System.Drawing.Point(698, 400);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(75, 23);
            this.ProceedButton.TabIndex = 10;
            this.ProceedButton.Text = "Proceed >";
            this.ProceedButton.UseVisualStyleBackColor = true;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(527, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Current Email List";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(164, 323);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(275, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "+ Add Person";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(164, 230);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(275, 72);
            this.AddressTextBox.TabIndex = 4;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(164, 181);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(275, 23);
            this.EmailTextBox.TabIndex = 3;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(164, 132);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(275, 23);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 15;
            this.ListBox.Location = new System.Drawing.Point(513, 132);
            this.ListBox.Name = "ListBox";
            this.ListBox.ScrollAlwaysVisible = true;
            this.ListBox.Size = new System.Drawing.Size(135, 214);
            this.ListBox.TabIndex = 1;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(194, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Create Email List";
            // 
            // CreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateListPanel);
            this.Name = "CreationForm";
            this.Text = "CreationForm";
            this.CreateListPanel.ResumeLayout(false);
            this.CreateListPanel.PerformLayout();
            this.SelectedPanel.ResumeLayout(false);
            this.SelectedPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel CreateListPanel;
        private Button ProceedButton;
        private Label label7;
        private Button AddButton;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox AddressTextBox;
        private TextBox EmailTextBox;
        private TextBox NameTextBox;
        private ListBox ListBox;
        private Label label3;
        private Panel SelectedPanel;
        private Button NoRemoveButton;
        private Button YesRemoveButton;
        private Label RemovePersonLabel;
        private Label label8;
        private Label label2;
        private Label label1;
        private TextBox SelectedAddress;
        private TextBox SelectedEmail;
        private TextBox SelectedName;
        private Label WarningLabel;
    }
}