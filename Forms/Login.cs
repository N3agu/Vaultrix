using System;
using System.IO;
using System.Windows.Forms;
using Vaultrix.Properties;
using Vaultrix.Helpers;

namespace Vaultrix.Forms {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private int failedLoginAttempts = 0;
        private DateTime lockoutEndTime = DateTime.MinValue;

        private void loginButton_Click(object sender, EventArgs e) {
            // check if user is locked out
            if (DateTime.Now < lockoutEndTime) {
                TimeSpan remainingLockout = lockoutEndTime - DateTime.Now;
                MessageBox.Show($"Too many failed attempts! Please wait {remainingLockout.Minutes} minute(s) and {remainingLockout.Seconds} second(s) before trying again.", "Vaultrix | Locked Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string enteredVaultUsername = vaultUsernameTextBox.Text;
            string enteredVaultPassword = vaultPasswordTextBox.Text;

            if (PasswordHelper.UsernameContainsInvalidCharacters(enteredVaultUsername)) {
                MessageBox.Show("Username can not contain invalid characters, spaces or be empty!", "Vaultrix | Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string keyFilePath = "vaults/" + enteredVaultUsername + ".key";
            string vaultFilePath = "vaults/" + enteredVaultUsername + ".vault";

            if (!(File.Exists(keyFilePath) && File.Exists(vaultFilePath))) {
                MessageBox.Show("No Vault found with this name, please create one first.", "Vaultrix | Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isVaultPasswordCorrect = PasswordHelper.ValidatePassword(enteredVaultPassword, keyFilePath);

            if (!isVaultPasswordCorrect) {
                failedLoginAttempts++; // Increment failed attempts

                if (failedLoginAttempts >= 5) {
                    lockoutEndTime = DateTime.Now.AddMinutes(3); // 3 minute lockout after 5 failed attempts
                    MessageBox.Show($"Too many failed attempts ({failedLoginAttempts.ToString()})! You are locked out for 3 minutes.", "Vaultrix | Locked Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (failedLoginAttempts >= 3) {
                    lockoutEndTime = DateTime.Now.AddMinutes(1); // 1 minute lockout after 3 failed attempts
                    MessageBox.Show($"Too many failed attempts ({failedLoginAttempts.ToString()})! You are locked out for 1 minute.", "Vaultrix | Locked Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Invalid password! Please try again.", "Vaultrix | Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            
            Main mainForm = new Main(enteredVaultUsername, enteredVaultPassword);
            vaultPasswordTextBox.Text = string.Empty;
            this.Hide();
            mainForm.ShowDialog();
            this.Show();
        }

        private void registerButton_Click(object sender, EventArgs e) {
            Register registerForm = new Register();
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }

        private void viewvaultPasswordButton_Click(object sender, EventArgs e) {
            if(vaultPasswordTextBox.UseSystemPasswordChar == false) {
                vaultPasswordTextBox.UseSystemPasswordChar = true;
                viewVaultPasswordButton.BackgroundImage = Resources.closed_eye;
            } else {
                vaultPasswordTextBox.UseSystemPasswordChar = false;
                viewVaultPasswordButton.BackgroundImage = Resources.opened_eye;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
