namespace Vaultrix.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.vaultPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.viewVaultPasswordButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vaultUsernameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vaultPasswordTextBox
            // 
            this.vaultPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.vaultPasswordTextBox.Location = new System.Drawing.Point(12, 174);
            this.vaultPasswordTextBox.Name = "vaultPasswordTextBox";
            this.vaultPasswordTextBox.Size = new System.Drawing.Size(259, 23);
            this.vaultPasswordTextBox.TabIndex = 2;
            this.vaultPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(79, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter your Vault Credentials";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(160, 203);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(142, 23);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(12, 203);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(142, 23);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // viewVaultPasswordButton
            // 
            this.viewVaultPasswordButton.BackgroundImage = global::Vaultrix.Properties.Resources.closed_eye;
            this.viewVaultPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewVaultPasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.viewVaultPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewVaultPasswordButton.Location = new System.Drawing.Point(277, 174);
            this.viewVaultPasswordButton.Name = "viewVaultPasswordButton";
            this.viewVaultPasswordButton.Size = new System.Drawing.Size(25, 23);
            this.viewVaultPasswordButton.TabIndex = 3;
            this.viewVaultPasswordButton.UseVisualStyleBackColor = true;
            this.viewVaultPasswordButton.Click += new System.EventHandler(this.viewvaultPasswordButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vaultrix.Properties.Resources.icon100;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // vaultUsernameTextBox
            // 
            this.vaultUsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.vaultUsernameTextBox.Location = new System.Drawing.Point(12, 145);
            this.vaultUsernameTextBox.Name = "vaultUsernameTextBox";
            this.vaultUsernameTextBox.Size = new System.Drawing.Size(290, 23);
            this.vaultUsernameTextBox.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 238);
            this.Controls.Add(this.vaultUsernameTextBox);
            this.Controls.Add(this.viewVaultPasswordButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vaultPasswordTextBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vaultrix | Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox vaultPasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button viewVaultPasswordButton;
        private System.Windows.Forms.TextBox vaultUsernameTextBox;
    }
}