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

        private void loginButton_Click(object sender, EventArgs e) {
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
