using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using Vaultrix.Forms;
using Vaultrix.Helpers;

namespace Vaultrix {
    public partial class Main : Form {
        private List<ListViewItem> allItemsList = new List<ListViewItem>();  // store all entries
        private Dictionary<int, int> originalColumnWidths = new Dictionary<int, int>(); // store the original widths of each column
        string vaultName = "", vaultPassword = "";

        public Main(string vaultName, string vaultPassword) {
            InitializeComponent();
            this.vaultName = vaultName;
            this.vaultPassword = vaultPassword;
        }

        private void logoutButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e) {
            searchComboBox.SelectedIndex = 0;
            vaultNameLabel.Text = vaultName;

            // event handlers for visibility checkboxes
            dateColumnDisplayCheckBox.CheckedChanged += (s, ev) => ToggleColumnVisibility(0, dateColumnDisplayCheckBox.Checked);
            nameColumnDisplayCheckBox.CheckedChanged += (s, ev) => ToggleColumnVisibility(1, nameColumnDisplayCheckBox.Checked);
            emailColumnDisplayCheckBox.CheckedChanged += (s, ev) => ToggleColumnVisibility(2, emailColumnDisplayCheckBox.Checked);
            passwordColumnDisplayCheckBox.CheckedChanged += (s, ev) => ToggleColumnVisibility(3, passwordColumnDisplayCheckBox.Checked);
            linkColumnDisplayCheckBox.CheckedChanged += (s, ev) => ToggleColumnVisibility(4, linkColumnDisplayCheckBox.Checked);
            detailsColumnDisplayCheckBox.CheckedChanged += (s, ev) => ToggleColumnVisibility(5, detailsColumnDisplayCheckBox.Checked);

            // load data from vault
            string vaultFilePath = $"vaults\\{vaultName}.vault";

            if (File.Exists(vaultFilePath)) {
                string[] encryptedEntries = File.ReadAllLines(vaultFilePath);
                foreach (string encryptedEntry in encryptedEntries) {
                    // decrypt
                    string decryptedEntry = EncryptionHelper.DecryptString(encryptedEntry, vaultName, vaultPassword);

                    // split entry in 6 parts - date, website, email, password, link, details
                    string[] entryParts = decryptedEntry.Split(';');

                    if (entryParts.Length == 6) {
                        ListViewItem newEntryItem = null;
                        if (!string.IsNullOrEmpty(entryParts[3])) {
                            newEntryItem = new ListViewItem(new[] { entryParts[0], entryParts[1], entryParts[2], Utils.PasswordReplace, entryParts[4], entryParts[5] });
                            newEntryItem.Tag = new { Password = entryParts[3] };
                        } else 
                            newEntryItem = new ListViewItem(new[] { entryParts[0], entryParts[1], entryParts[2], entryParts[3], entryParts[4], entryParts[5] });

                        entriesListView.Items.Add(newEntryItem);
                        allItemsList.Add(newEntryItem);
                    }
                }
            }

            AdjustListViewColumnWidths();
        }

        private void AdjustListViewColumnWidths() {
            foreach (ColumnHeader column in entriesListView.Columns) {
                int maxWidth = TextRenderer.MeasureText(column.Text, entriesListView.Font).Width + 10; // padding

                foreach (ListViewItem item in entriesListView.Items) {
                    int contentWidth = TextRenderer.MeasureText(item.SubItems[column.Index].Text, entriesListView.Font).Width + 10; // padding

                    if (contentWidth > maxWidth)
                        maxWidth = contentWidth;
                }

                // set the width of column
                column.Width = maxWidth;
            }

            // store the widths
            for (int i = 0; i < entriesListView.Columns.Count; i++) {
                originalColumnWidths[i] = entriesListView.Columns[i].Width;
            }
        }

        private void ToggleColumnVisibility(int columnIndex, bool isVisible) {
            if (isVisible) {
                // restore the column width from the original width
                entriesListView.Columns[columnIndex].Width = originalColumnWidths[columnIndex];
            } else {
                // set the column width to 0 to "hide" it
                entriesListView.Columns[columnIndex].Width = 0;
            }
        }

        private void addNewEntryButton_Click(object sender, EventArgs e) {
            EntryView createEntry = new EntryView();

            if (createEntry.ShowDialog() == DialogResult.OK) {
                // get data from the form
                string lastModifiedDate = DateTime.Today.ToString();
                string websiteName = createEntry.WebsiteName;
                string emailUsername = createEntry.EmailUsername;
                string password = createEntry.Password;
                string url = createEntry.Url;
                string details = createEntry.Details;

                // save to file
                string entryString = $"{lastModifiedDate};{websiteName};{emailUsername};{password};{url};{details}";
                string encryptedEntry = EncryptionHelper.EncryptString(entryString, vaultName, vaultPassword);
                string vaultPath = $"vaults/{vaultName}.vault";

                File.AppendAllText(vaultPath, encryptedEntry + Environment.NewLine);

                // add the data to the ListView
                ListViewItem newEntryItem = null;
                if (!string.IsNullOrEmpty(password)) { 
                    newEntryItem = new ListViewItem(new[] { lastModifiedDate, websiteName, emailUsername, Utils.PasswordReplace, url, details });
                    newEntryItem.Tag = new { Password = password };
                } else 
                    newEntryItem = new ListViewItem(new[] { lastModifiedDate, websiteName, emailUsername, password, url, details });
                
                entriesListView.Items.Add(newEntryItem);
                allItemsList.Add(newEntryItem);

                AdjustListViewColumnWidths();
            }
        }

        private void deleteEntryButton_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to delete the selected entry/entries?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (entriesListView.SelectedItems.Count > 0) {
                foreach (ListViewItem selectedItem in entriesListView.SelectedItems) {
                    entriesListView.Items.Remove(selectedItem);
                    allItemsList.Remove(selectedItem);
                }
                AdjustListViewColumnWidths();
            } else {
                MessageBox.Show("Please select at least an entry to delete.", "Warning | Vaultrix", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SaveEntriesToVault();
        }

        private void modifyEntryButton_Click(object sender, EventArgs e) {
            if (entriesListView.SelectedItems.Count == 0) {
                MessageBox.Show("Please select an entry to edit.", "Warning | Vaultrix", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (entriesListView.SelectedItems.Count > 1) {
                MessageBox.Show("Please select only one entry to edit.", "Warning | Vaultrix", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = entriesListView.SelectedItems[0];

            // find the corresponding item in the allItemsList to sync modifications
            ListViewItem originalItem = allItemsList.Find(item => item == selectedItem);

            modifyEntry(selectedItem, originalItem);
        }

        private void modifyEntry(ListViewItem selectedItem, ListViewItem originalItem) {
            if (originalItem == null) {
                MessageBox.Show("Could not find the original entry.", "Error | Vaultrix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // open form with pre-filled data
            EntryView modifyEntry = new EntryView();
            modifyEntry.WebsiteName = selectedItem.SubItems[1].Text;
            modifyEntry.EmailUsername = selectedItem.SubItems[2].Text;
            dynamic selectedItemTag = selectedItem.Tag;
            modifyEntry.Password = selectedItemTag.Password;
            modifyEntry.Url = selectedItem.SubItems[4].Text;
            modifyEntry.Details = selectedItem.SubItems[5].Text;

            if (modifyEntry.ShowDialog() == DialogResult.OK) {
                // update the selected ListView item with new values
                selectedItem.SubItems[0].Text = DateTime.Today.ToString();
                selectedItem.SubItems[1].Text = modifyEntry.WebsiteName;
                selectedItem.SubItems[2].Text = modifyEntry.EmailUsername;
                selectedItem.SubItems[4].Text = modifyEntry.Url;
                selectedItem.SubItems[5].Text = modifyEntry.Details;

                // sync the same changes in allItemsList
                originalItem.SubItems[1].Text = modifyEntry.WebsiteName;
                originalItem.SubItems[2].Text = modifyEntry.EmailUsername;
                originalItem.SubItems[4].Text = modifyEntry.Url;
                originalItem.SubItems[5].Text = modifyEntry.Details;

                if (!string.IsNullOrEmpty(modifyEntry.Password)) {
                    selectedItem.SubItems[3].Text = Utils.PasswordReplace;
                    originalItem.SubItems[3].Text = Utils.PasswordReplace;

                    selectedItem.Tag = new { Password = modifyEntry.Password };
                    originalItem.Tag = new { Password = modifyEntry.Password };
                }

                AdjustListViewColumnWidths();
            }

            // save all entries
            SaveEntriesToVault();
        }

        private void SaveEntriesToVault() {
            string vaultPath = $"vaults/{vaultName}.vault";

            // clear vault file
            File.WriteAllText(vaultPath, string.Empty);

            foreach (ListViewItem item in entriesListView.Items) {
                string entryString, encryptedEntry;
                if (!string.IsNullOrEmpty(item.SubItems[3].Text))
                {
                    dynamic selectedItemTag = item.Tag;
                    entryString = $"{item.SubItems[0].Text};{item.SubItems[1].Text};{item.SubItems[2].Text};{selectedItemTag.Password};{item.SubItems[4].Text};{item.SubItems[5].Text}";
                } else 
                    entryString = $"{item.SubItems[0].Text};{item.SubItems[1].Text};{item.SubItems[2].Text};{item.SubItems[3].Text};{item.SubItems[4].Text};{item.SubItems[5].Text}";
                encryptedEntry = EncryptionHelper.EncryptString(entryString, vaultName, vaultPassword);
                File.AppendAllText(vaultPath, encryptedEntry + Environment.NewLine);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e) {
            ApplySearchFilter();
        }

        private void searchComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            ApplySearchFilter();
        }

        private void ApplySearchFilter() {
            string searchText = searchTextBox.Text.ToLower();
            int selectedIndex = searchComboBox.SelectedIndex;

            // clear the ListView before repopulating it with the filtered items
            entriesListView.Items.Clear();

            // searchTextBox empty
            if (string.IsNullOrEmpty(searchText)) {
                foreach (ListViewItem item in allItemsList) {
                    entriesListView.Items.Add(item);
                }
                return;
            }

            foreach (ListViewItem item in allItemsList) {
                bool matchesSearch = false;

                if (selectedIndex == 0) {
                    for (int i = 0; i < item.SubItems.Count; i++) {
                        if (item.SubItems[i].Text.ToLower().Contains(searchText)) {
                            matchesSearch = true;
                            break;
                        }
                    }
                } else {
                    int columnIndex = selectedIndex - 1;  // adjusting index

                    if (columnIndex >= 0 && columnIndex < item.SubItems.Count)
                        matchesSearch = item.SubItems[columnIndex].Text.ToLower().Contains(searchText);
                }

                // add the item back to the ListView if it matches the search
                if (matchesSearch)
                    entriesListView.Items.Add(item);
            }
        }

        private void importButton_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                Filter = "Vault Files (*.vault)|*.vault",
                Title = "Select Vault File to Import",
                Multiselect = false // make sure only one file is selected
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string selectedFilePath = openFileDialog.FileName;

                Import import = new Import(selectedFilePath);
                if(import.ShowDialog() == DialogResult.OK) {
                    allItemsList.AddRange(import.importedEntriesList);
                    entriesListView.Items.AddRange(import.importedEntriesList.ToArray());
                    entriesListView.Refresh();
                    AdjustListViewColumnWidths();
                    SaveEntriesToVault();
                }
            }
        }

        private void entriesListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // get double click item
            ListViewHitTestInfo hitTestInfo = entriesListView.HitTest(e.Location);

            // check if the double clicked row is valid
            if (hitTestInfo.Item != null) {
                if (entriesListView.SelectedItems.Count == 0) {
                    MessageBox.Show("Please select an entry to edit.", "Warning | Vaultrix", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (entriesListView.SelectedItems.Count > 1) {
                    MessageBox.Show("Please select only one entry to edit.", "Warning | Vaultrix", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ListViewItem selectedItem = entriesListView.SelectedItems[0];

                // sync modifications
                ListViewItem originalItem = allItemsList.Find(item => item == selectedItem);

                modifyEntry(selectedItem, originalItem);
            }
        }

        private void entriesListView_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                ListViewHitTestInfo hitTestInfo = entriesListView.HitTest(e.Location);
                if (hitTestInfo.Item != null) {
                    if(entriesListView.SelectedItems.Count == 1)
                        rightClickSingleContextMenu.Show(entriesListView, e.Location);
                    else
                        rightClickMultipleContextMenu.Show(entriesListView, e.Location);
                }
            }
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e) {
            ListViewItem selectedItem = entriesListView.SelectedItems[0];

            // sync modifications
            ListViewItem originalItem = allItemsList.Find(item => item == selectedItem);

            modifyEntry(selectedItem, originalItem);
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the selected entry?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            ListViewItem selectedItem = entriesListView.SelectedItems[0];

            entriesListView.Items.Remove(selectedItem);
            allItemsList.Remove(selectedItem);
            AdjustListViewColumnWidths();

            SaveEntriesToVault();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the selected entries?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (entriesListView.SelectedItems.Count > 0) {
                foreach (ListViewItem selectedItem in entriesListView.SelectedItems)
                {
                    entriesListView.Items.Remove(selectedItem);
                    allItemsList.Remove(selectedItem);
                }
                AdjustListViewColumnWidths();
            }
            else
                MessageBox.Show("Please select at least an entry to delete.", "Warning | Vaultrix", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            SaveEntriesToVault();
        }

        private void visitWebsiteToolStripMenuItem_Click(object sender, EventArgs e) {
            ListViewItem selectedItem = entriesListView.SelectedItems[0];
            string urlToVisit = selectedItem.SubItems[4].Text; // column 4 is "Link"

            if (!string.IsNullOrEmpty(urlToVisit)) {
                try {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo {
                        FileName = urlToVisit,
                        UseShellExecute = true // default browser
                    });
                } catch (Exception ex) {
                    MessageBox.Show($"Failed to open the link: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                // Inform the user if no URL is found in the "Link" column
                MessageBox.Show("The selected item does not contain a valid link.", "No Link Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void showPasswordToolStripMenuItem_Click(object sender, EventArgs e) {
            ListViewItem selectedItem = entriesListView.SelectedItems[0];
            if (selectedItem.SubItems[3].Text == Utils.PasswordReplace) {
                try {
                    // get the password from the tag
                    dynamic tag = selectedItem.Tag;
                    selectedItem.SubItems[3].Text = tag.Password;
                }
                catch { }
            } else {
                try {
                    // hide the password
                    selectedItem.SubItems[3].Text = Utils.PasswordReplace;
                }
                catch { }
            }
            AdjustListViewColumnWidths();
        }

        private void showPasswordsToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (ListViewItem selectedItem in entriesListView.SelectedItems) {
                if (selectedItem.SubItems[3].Text == Utils.PasswordReplace) {
                    // show item
                    try {
                        // get the password from the tag
                        dynamic tag = selectedItem.Tag;
                        selectedItem.SubItems[3].Text = tag.Password;
                    }
                    catch { }
                }
            }
            AdjustListViewColumnWidths();
        }
        private void hidePasswordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in entriesListView.SelectedItems)
                if (selectedItem.SubItems[3].Text != Utils.PasswordReplace && !string.IsNullOrEmpty(selectedItem.SubItems[3].Text))
                    selectedItem.SubItems[3].Text = Utils.PasswordReplace;
            AdjustListViewColumnWidths();
        }

        private void rightClickSingleContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e) {
            ListViewItem selectedItem = entriesListView.SelectedItems[0];
            if (selectedItem.SubItems[3].Text == Utils.PasswordReplace) rightClickSingleContextMenu.Items[2].Text = "Show Password";
            else rightClickSingleContextMenu.Items[2].Text = "Hide Password";
        }

        private void exportButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog {
                Description = "Select a directory to save the vault file",
                ShowNewFolderButton = true  // Optionally allow users to create a new folder
            };

            bool zipFiles = false;
            DialogResult zipDialogResult = MessageBox.Show("Would you like to export as zip?", "Export vault options", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            
            if (zipDialogResult == DialogResult.Cancel) return;
            else if (zipDialogResult == DialogResult.Yes) zipFiles = true;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                string destinationPath = folderBrowserDialog.SelectedPath;
                string vaultPath = $"vaults/{vaultName}.vault";
                string keyPath = $"vaults/{vaultName}.key";

                string vaultDestinationPath = destinationPath + "/" + vaultName + ".vault";
                string keyDestinationPath = destinationPath + "/" + vaultName + ".key";

                try {
                    if (zipFiles)
                    {
                        string zipFilePath = Path.Combine(destinationPath, vaultName + ".zip");

                        using (ZipArchive zipArchive = ZipFile.Open(zipFilePath, ZipArchiveMode.Create)) {
                            // add files to ZIP
                            zipArchive.CreateEntryFromFile(vaultPath, Path.GetFileName(vaultPath));
                            zipArchive.CreateEntryFromFile(keyPath, Path.GetFileName(keyPath));
                        }
                        MessageBox.Show("Vault ZIP exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else {
                        File.Copy(keyPath, keyDestinationPath, true);
                        File.Copy(vaultPath, vaultDestinationPath, true);
                        MessageBox.Show("Vault files exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } catch (Exception ex) {
                    MessageBox.Show($"An error occurred while exporting the vault: {ex.Message}", "Error | Vaultrix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
