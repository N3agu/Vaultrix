namespace Vaultrix.Forms
{
    partial class Import
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
            this.selectedVaultFilePathTextBox = new System.Windows.Forms.TextBox();
            this.viewVaultPasswordButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.vaultPasswordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectedVaultFilePathTextBox
            // 
            this.selectedVaultFilePathTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.selectedVaultFilePathTextBox.Location = new System.Drawing.Point(12, 12);
            this.selectedVaultFilePathTextBox.Multiline = true;
            this.selectedVaultFilePathTextBox.Name = "selectedVaultFilePathTextBox";
            this.selectedVaultFilePathTextBox.ReadOnly = true;
            this.selectedVaultFilePathTextBox.Size = new System.Drawing.Size(360, 23);
            this.selectedVaultFilePathTextBox.TabIndex = 0;
            // 
            // viewVaultPasswordButton
            // 
            this.viewVaultPasswordButton.BackgroundImage = global::Vaultrix.Properties.Resources.closed_eye;
            this.viewVaultPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewVaultPasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.viewVaultPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewVaultPasswordButton.Location = new System.Drawing.Point(347, 79);
            this.viewVaultPasswordButton.Name = "viewVaultPasswordButton";
            this.viewVaultPasswordButton.Size = new System.Drawing.Size(25, 23);
            this.viewVaultPasswordButton.TabIndex = 15;
            this.viewVaultPasswordButton.UseVisualStyleBackColor = true;
            this.viewVaultPasswordButton.Click += new System.EventHandler(this.viewVaultPasswordButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enter Imported Vault Credentials";
            // 
            // vaultPasswordTextBox
            // 
            this.vaultPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vaultPasswordTextBox.Location = new System.Drawing.Point(12, 79);
            this.vaultPasswordTextBox.Name = "vaultPasswordTextBox";
            this.vaultPasswordTextBox.Size = new System.Drawing.Size(329, 23);
            this.vaultPasswordTextBox.TabIndex = 14;
            this.vaultPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.loginButton.Location = new System.Drawing.Point(119, 108);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(154, 23);
            this.loginButton.TabIndex = 17;
            this.loginButton.Text = "Import";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 135);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.viewVaultPasswordButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vaultPasswordTextBox);
            this.Controls.Add(this.selectedVaultFilePathTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Import";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Vault";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Import_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox selectedVaultFilePathTextBox;
        private System.Windows.Forms.Button viewVaultPasswordButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vaultPasswordTextBox;
        private System.Windows.Forms.Button loginButton;
    }
}