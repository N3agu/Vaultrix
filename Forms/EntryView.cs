using System;
using System.Windows.Forms;
using Vaultrix.Helpers;

namespace Vaultrix.Forms
{
    public partial class EntryView : Form
    {
        public string WebsiteName {
            get { return websiteNameTextBox.Text; }
            set { websiteNameTextBox.Text = value; }
        }
        public string EmailUsername {
            get { return usernameEmailTextBox.Text; }
            set { usernameEmailTextBox.Text = value; }
        }
        public string Password {
            get { return passwordTextBox.Text; }
            set { passwordTextBox.Text = value; }
        }
        public string Url {
            get { return linkTextBox.Text; }
            set { linkTextBox.Text = value; }
        }
        public string Details {
            get { return detailsTextBox.Text; }
            set { detailsTextBox.Text = value; }
        }

        public EntryView() {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            // Close the form without saving data
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveEntryButton_Click(object sender, EventArgs e) {
            // Validate
            if(websiteNameTextBox.Text == string.Empty) {
                MessageBox.Show("Website Name can not be empty.", "Error | Vaultrix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(linkTextBox.Text != string.Empty) // link is not mandatory
                if (!Utils.IsValidUrl(linkTextBox.Text)) {
                    MessageBox.Show("Link is not valid.", "Error | Vaultrix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
