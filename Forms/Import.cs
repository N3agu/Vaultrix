using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Vaultrix.Properties;
using Vaultrix.Helpers;

namespace Vaultrix.Forms
{
    public partial class Import : Form
    {
        private string vaultFilePath = "";
        public List<ListViewItem> importedEntriesList = new List<ListViewItem>();
        public Import(string vaultFilePath)
        {
            InitializeComponent();
            this.vaultFilePath = vaultFilePath;
        }

        private void Import_Load(object sender, EventArgs e)
        {
            selectedVaultFilePathTextBox.Text = vaultFilePath;
        }

        private void viewVaultPasswordButton_Click(object sender, EventArgs e) {
            if (vaultPasswordTextBox.UseSystemPasswordChar == false) {
                vaultPasswordTextBox.UseSystemPasswordChar = true;
                viewVaultPasswordButton.BackgroundImage = Resources.closed_eye;
            } else {
                vaultPasswordTextBox.UseSystemPasswordChar = false;
                viewVaultPasswordButton.BackgroundImage = Resources.opened_eye;
            }
        }

        private void importButton_Click(object sender, EventArgs e) {
            string enteredVaultPassword = vaultPasswordTextBox.Text;
            string vaultName = Path.GetFileNameWithoutExtension(vaultFilePath);
            string keyFilePath = Path.GetDirectoryName(vaultFilePath) + "\\" + vaultName + ".key";

            if (!File.Exists(vaultFilePath)) {
                MessageBox.Show("Vault wasn't found!", "Vaultrix | Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(keyFilePath)) {
                MessageBox.Show("Key wasn't found. Make sure to keep the key in the same directory as the vault!", "Vaultrix | Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isVaultPasswordCorrect = PasswordHelper.ValidatePassword(enteredVaultPassword, keyFilePath);

            if (!isVaultPasswordCorrect) {
                MessageBox.Show("Invalid password! Please try again.", "Vaultrix | Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (File.Exists(vaultFilePath)) {
                string[] encryptedEntries = File.ReadAllLines(vaultFilePath);
                foreach (string encryptedEntry in encryptedEntries) {
                    // decrypt
                    string decryptedEntry = EncryptionHelper.DecryptString(encryptedEntry, vaultName, enteredVaultPassword);

                    // split entry in 6 parts - date, website, email, password, link, details
                    string[] entryParts = decryptedEntry.Split(';');

                    if (entryParts.Length == 6) {
                        ListViewItem item = new ListViewItem(new[] { entryParts[0], entryParts[1], entryParts[2], entryParts[3], entryParts[4], entryParts[5] });

                        importedEntriesList.Add(item);
                    }
                }
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
