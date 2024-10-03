namespace Vaultrix.Forms
{
    partial class EntryView
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
            this.saveEntryButton = new System.Windows.Forms.Button();
            this.websiteNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameEmailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.linkTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.passwordTipsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.allowLettersCheckBox = new System.Windows.Forms.CheckBox();
            this.allowDigitsCheckBox = new System.Windows.Forms.CheckBox();
            this.allowSymbolsCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveEntryButton
            // 
            this.saveEntryButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveEntryButton.Location = new System.Drawing.Point(191, 420);
            this.saveEntryButton.Name = "saveEntryButton";
            this.saveEntryButton.Size = new System.Drawing.Size(138, 37);
            this.saveEntryButton.TabIndex = 0;
            this.saveEntryButton.Text = "Save Entry in Vault";
            this.saveEntryButton.UseVisualStyleBackColor = true;
            this.saveEntryButton.Click += new System.EventHandler(this.saveEntryButton_Click);
            // 
            // websiteNameTextBox
            // 
            this.websiteNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.websiteNameTextBox.Location = new System.Drawing.Point(12, 24);
            this.websiteNameTextBox.Multiline = true;
            this.websiteNameTextBox.Name = "websiteNameTextBox";
            this.websiteNameTextBox.Size = new System.Drawing.Size(353, 21);
            this.websiteNameTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Website Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameEmailTextBox
            // 
            this.usernameEmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameEmailTextBox.Location = new System.Drawing.Point(12, 70);
            this.usernameEmailTextBox.Multiline = true;
            this.usernameEmailTextBox.Name = "usernameEmailTextBox";
            this.usernameEmailTextBox.Size = new System.Drawing.Size(353, 21);
            this.usernameEmailTextBox.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(12, 116);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(353, 21);
            this.passwordTextBox.TabIndex = 10;
            // 
            // linkTextBox
            // 
            this.linkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkTextBox.Location = new System.Drawing.Point(12, 188);
            this.linkTextBox.Multiline = true;
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(353, 21);
            this.linkTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username / Email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(9, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Link";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(9, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Details";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsTextBox.Location = new System.Drawing.Point(12, 237);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(353, 177);
            this.detailsTextBox.TabIndex = 16;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.Location = new System.Drawing.Point(47, 420);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(138, 37);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generateButton.Location = new System.Drawing.Point(290, 143);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 19;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // passwordTipsLinkLabel
            // 
            this.passwordTipsLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTipsLinkLabel.Location = new System.Drawing.Point(12, 100);
            this.passwordTipsLinkLabel.Name = "passwordTipsLinkLabel";
            this.passwordTipsLinkLabel.Size = new System.Drawing.Size(353, 13);
            this.passwordTipsLinkLabel.TabIndex = 20;
            this.passwordTipsLinkLabel.TabStop = true;
            this.passwordTipsLinkLabel.Text = "Password";
            this.passwordTipsLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordTipsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.passwordTipsLinkLabel_LinkClicked);
            // 
            // allowLettersCheckBox
            // 
            this.allowLettersCheckBox.AutoSize = true;
            this.allowLettersCheckBox.Checked = true;
            this.allowLettersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allowLettersCheckBox.Location = new System.Drawing.Point(50, 147);
            this.allowLettersCheckBox.Name = "allowLettersCheckBox";
            this.allowLettersCheckBox.Size = new System.Drawing.Size(60, 17);
            this.allowLettersCheckBox.TabIndex = 21;
            this.allowLettersCheckBox.Text = "Letters";
            this.allowLettersCheckBox.UseVisualStyleBackColor = true;
            // 
            // allowDigitsCheckBox
            // 
            this.allowDigitsCheckBox.AutoSize = true;
            this.allowDigitsCheckBox.Checked = true;
            this.allowDigitsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allowDigitsCheckBox.Location = new System.Drawing.Point(114, 147);
            this.allowDigitsCheckBox.Name = "allowDigitsCheckBox";
            this.allowDigitsCheckBox.Size = new System.Drawing.Size(56, 17);
            this.allowDigitsCheckBox.TabIndex = 22;
            this.allowDigitsCheckBox.Text = "Digits";
            this.allowDigitsCheckBox.UseVisualStyleBackColor = true;
            // 
            // allowSymbolsCheckBox
            // 
            this.allowSymbolsCheckBox.AutoSize = true;
            this.allowSymbolsCheckBox.Checked = true;
            this.allowSymbolsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allowSymbolsCheckBox.Location = new System.Drawing.Point(172, 147);
            this.allowSymbolsCheckBox.Name = "allowSymbolsCheckBox";
            this.allowSymbolsCheckBox.Size = new System.Drawing.Size(68, 17);
            this.allowSymbolsCheckBox.TabIndex = 23;
            this.allowSymbolsCheckBox.Text = "Symbols";
            this.allowSymbolsCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Allow:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EntryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 469);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.allowSymbolsCheckBox);
            this.Controls.Add(this.allowDigitsCheckBox);
            this.Controls.Add(this.allowLettersCheckBox);
            this.Controls.Add(this.passwordTipsLinkLabel);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameEmailTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.websiteNameTextBox);
            this.Controls.Add(this.saveEntryButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(393, 449);
            this.Name = "EntryView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entry View | Vaultrix";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveEntryButton;
        private System.Windows.Forms.TextBox websiteNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameEmailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox linkTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.LinkLabel passwordTipsLinkLabel;
        private System.Windows.Forms.CheckBox allowLettersCheckBox;
        private System.Windows.Forms.CheckBox allowDigitsCheckBox;
        private System.Windows.Forms.CheckBox allowSymbolsCheckBox;
        private System.Windows.Forms.Label label3;
    }
}