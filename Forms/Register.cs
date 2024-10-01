using System;
using System.IO;
using System.Windows.Forms;
using Vaultrix.Properties;
using Vaultrix.Helpers;

namespace Vaultrix.Forms {
    public partial class Register : Form {
        public Register() {
            InitializeComponent();
        }

        private void vaultPasswordTextBox_TextChanged(object sender, EventArgs e) {
            string vaultPassword = vaultPasswordTextBox.Text;
            int strengthScore = PasswordStrength.EvaluatePasswordStrength(vaultPassword);

            passwordStrengthLabel.Text = PasswordStrength.GetPasswordStrengthDescription(strengthScore);
            passwordStrengthProgressBar.Value = strengthScore;
        }

        private void passwordTipsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            MessageBox.Show("Vault password should:\n- be at least 8 characters long (preferably 20);\n- contain at least 1 uppercase letter;\n- contain at least 1 digit;\n- contain at least one special character;\n\nVault password should score at least \"Strong\" to be created.", "Vaultrix | Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void registerButton_Click(object sender, EventArgs e) {
            string vaultUsername = vaultUsernameTextBox.Text;
            string vaultPassword = vaultPasswordTextBox.Text;

            if (PasswordHelper.UsernameContainsInvalidCharacters(vaultUsername)) {
                MessageBox.Show("Vault name can not contain invalid characters, spaces or be empty!", "Vaultrix | Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PasswordStrength.EvaluatePasswordStrength(vaultPassword) < 80) {
                MessageBox.Show("Vault password should score at least \"Strong\" to be able to register on Vaultrix.", "Vaultrix | Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string keyFilePath = "vaults/" + vaultUsername + ".key";
            string vaultFilePath = "vaults/" + vaultUsername + ".vault";

            if (File.Exists(keyFilePath) || File.Exists(vaultFilePath)) {
                DialogResult messageBoxResult = MessageBox.Show("A Vault already exists with this name. Proceeding will DELETE the old one. Are you sure you want to continue?", "Vaultrix | Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (messageBoxResult == DialogResult.No)
                    return;
            }

            // Hash and store the vault password
            Directory.CreateDirectory("vaults");
            PasswordHelper.StoreHashedPassword(vaultPassword, keyFilePath, vaultFilePath);

            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void viewvaultPasswordButton_Click(object sender, EventArgs e) {
            if (vaultPasswordTextBox.UseSystemPasswordChar == false) {
                vaultPasswordTextBox.UseSystemPasswordChar = true;
                viewVaultPasswordButton.BackgroundImage = Resources.closed_eye;
            } else {
                vaultPasswordTextBox.UseSystemPasswordChar = false;
                viewVaultPasswordButton.BackgroundImage = Resources.opened_eye;
            }
        }
    }
}
