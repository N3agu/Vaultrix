namespace Vaultrix
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.passwordsTabPage = new System.Windows.Forms.TabPage();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.versionLabel = new System.Windows.Forms.Label();
            this.vaultNameLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.addNewEntryButton = new System.Windows.Forms.Button();
            this.modifyEntryButton = new System.Windows.Forms.Button();
            this.deleteEntryButton = new System.Windows.Forms.Button();
            this.entriesListView = new System.Windows.Forms.ListView();
            this.dateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.passwordColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linkColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.detailsColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.detailsColumnDisplayCheckBox = new System.Windows.Forms.CheckBox();
            this.linkColumnDisplayCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordColumnDisplayCheckBox = new System.Windows.Forms.CheckBox();
            this.emailColumnDisplayCheckBox = new System.Windows.Forms.CheckBox();
            this.nameColumnDisplayCheckBox = new System.Windows.Forms.CheckBox();
            this.dateColumnDisplayCheckBox = new System.Windows.Forms.CheckBox();
            this.licenseTabPage = new System.Windows.Forms.TabPage();
            this.githubPageLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rightClickSingleContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.visitWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rightClickMultipleContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showPasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hidePasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.passwordsTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.licenseTabPage.SuspendLayout();
            this.rightClickSingleContextMenu.SuspendLayout();
            this.rightClickMultipleContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.passwordsTabPage);
            this.tabControl1.Controls.Add(this.settingsTabPage);
            this.tabControl1.Controls.Add(this.licenseTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 391);
            this.tabControl1.TabIndex = 1;
            // 
            // passwordsTabPage
            // 
            this.passwordsTabPage.Controls.Add(this.searchComboBox);
            this.passwordsTabPage.Controls.Add(this.searchTextBox);
            this.passwordsTabPage.Controls.Add(this.panel1);
            this.passwordsTabPage.Controls.Add(this.entriesListView);
            this.passwordsTabPage.Location = new System.Drawing.Point(4, 22);
            this.passwordsTabPage.Name = "passwordsTabPage";
            this.passwordsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.passwordsTabPage.Size = new System.Drawing.Size(676, 365);
            this.passwordsTabPage.TabIndex = 0;
            this.passwordsTabPage.Text = "Passwords";
            this.passwordsTabPage.UseVisualStyleBackColor = true;
            // 
            // searchComboBox
            // 
            this.searchComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.ItemHeight = 13;
            this.searchComboBox.Items.AddRange(new object[] {
            "All",
            "Date",
            "Name",
            "Username / Email",
            "Password",
            "Link",
            "Details"});
            this.searchComboBox.Location = new System.Drawing.Point(549, 6);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(119, 21);
            this.searchComboBox.TabIndex = 7;
            this.searchComboBox.SelectedIndexChanged += new System.EventHandler(this.searchComboBox_SelectedIndexChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(177, 6);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(366, 21);
            this.searchTextBox.TabIndex = 5;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.versionLabel);
            this.panel1.Controls.Add(this.vaultNameLabel);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.exportButton);
            this.panel1.Controls.Add(this.importButton);
            this.panel1.Controls.Add(this.addNewEntryButton);
            this.panel1.Controls.Add(this.modifyEntryButton);
            this.panel1.Controls.Add(this.deleteEntryButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 359);
            this.panel1.TabIndex = 4;
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.versionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(5, 339);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(156, 18);
            this.versionLabel.TabIndex = 8;
            this.versionLabel.Text = "Version: 0.3A";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vaultNameLabel
            // 
            this.vaultNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaultNameLabel.Location = new System.Drawing.Point(5, 246);
            this.vaultNameLabel.Name = "vaultNameLabel";
            this.vaultNameLabel.Size = new System.Drawing.Size(156, 18);
            this.vaultNameLabel.TabIndex = 7;
            this.vaultNameLabel.Text = "-";
            this.vaultNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(5, 208);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(156, 35);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.Location = new System.Drawing.Point(5, 167);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(156, 35);
            this.exportButton.TabIndex = 5;
            this.exportButton.Text = "Export Vault";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // importButton
            // 
            this.importButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.Location = new System.Drawing.Point(5, 126);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(156, 35);
            this.importButton.TabIndex = 4;
            this.importButton.Text = "Import Vault";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // addNewEntryButton
            // 
            this.addNewEntryButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewEntryButton.Location = new System.Drawing.Point(5, 3);
            this.addNewEntryButton.Name = "addNewEntryButton";
            this.addNewEntryButton.Size = new System.Drawing.Size(156, 35);
            this.addNewEntryButton.TabIndex = 1;
            this.addNewEntryButton.Text = "Add New Entry";
            this.addNewEntryButton.UseVisualStyleBackColor = true;
            this.addNewEntryButton.Click += new System.EventHandler(this.addNewEntryButton_Click);
            // 
            // modifyEntryButton
            // 
            this.modifyEntryButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyEntryButton.Location = new System.Drawing.Point(5, 85);
            this.modifyEntryButton.Name = "modifyEntryButton";
            this.modifyEntryButton.Size = new System.Drawing.Size(156, 35);
            this.modifyEntryButton.TabIndex = 3;
            this.modifyEntryButton.Text = "Modify Entry";
            this.modifyEntryButton.UseVisualStyleBackColor = true;
            this.modifyEntryButton.Click += new System.EventHandler(this.modifyEntryButton_Click);
            // 
            // deleteEntryButton
            // 
            this.deleteEntryButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEntryButton.Location = new System.Drawing.Point(5, 44);
            this.deleteEntryButton.Name = "deleteEntryButton";
            this.deleteEntryButton.Size = new System.Drawing.Size(156, 35);
            this.deleteEntryButton.TabIndex = 2;
            this.deleteEntryButton.Text = "Delete Entry";
            this.deleteEntryButton.UseVisualStyleBackColor = true;
            this.deleteEntryButton.Click += new System.EventHandler(this.deleteEntryButton_Click);
            // 
            // entriesListView
            // 
            this.entriesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entriesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dateColumnHeader,
            this.nameColumnHeader,
            this.emailColumnHeader,
            this.passwordColumnHeader,
            this.linkColumnHeader,
            this.detailsColumnHeader});
            this.entriesListView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entriesListView.FullRowSelect = true;
            this.entriesListView.GridLines = true;
            this.entriesListView.HideSelection = false;
            this.entriesListView.Location = new System.Drawing.Point(177, 33);
            this.entriesListView.Name = "entriesListView";
            this.entriesListView.Size = new System.Drawing.Size(499, 329);
            this.entriesListView.TabIndex = 0;
            this.entriesListView.UseCompatibleStateImageBehavior = false;
            this.entriesListView.View = System.Windows.Forms.View.Details;
            this.entriesListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.entriesListView_MouseClick);
            this.entriesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.entriesListView_MouseDoubleClick);
            // 
            // dateColumnHeader
            // 
            this.dateColumnHeader.Text = "Date";
            this.dateColumnHeader.Width = 125;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 70;
            // 
            // emailColumnHeader
            // 
            this.emailColumnHeader.Text = "Email";
            this.emailColumnHeader.Width = 83;
            // 
            // passwordColumnHeader
            // 
            this.passwordColumnHeader.Text = "Password";
            this.passwordColumnHeader.Width = 87;
            // 
            // linkColumnHeader
            // 
            this.linkColumnHeader.Text = "Link";
            this.linkColumnHeader.Width = 77;
            // 
            // detailsColumnHeader
            // 
            this.detailsColumnHeader.Text = "Details";
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.groupBox1);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTabPage.Size = new System.Drawing.Size(676, 365);
            this.settingsTabPage.TabIndex = 1;
            this.settingsTabPage.Text = "Settings";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.detailsColumnDisplayCheckBox);
            this.groupBox1.Controls.Add(this.linkColumnDisplayCheckBox);
            this.groupBox1.Controls.Add(this.passwordColumnDisplayCheckBox);
            this.groupBox1.Controls.Add(this.emailColumnDisplayCheckBox);
            this.groupBox1.Controls.Add(this.nameColumnDisplayCheckBox);
            this.groupBox1.Controls.Add(this.dateColumnDisplayCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display Columns";
            // 
            // detailsColumnDisplayCheckBox
            // 
            this.detailsColumnDisplayCheckBox.AutoSize = true;
            this.detailsColumnDisplayCheckBox.Checked = true;
            this.detailsColumnDisplayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detailsColumnDisplayCheckBox.Location = new System.Drawing.Point(78, 65);
            this.detailsColumnDisplayCheckBox.Name = "detailsColumnDisplayCheckBox";
            this.detailsColumnDisplayCheckBox.Size = new System.Drawing.Size(61, 17);
            this.detailsColumnDisplayCheckBox.TabIndex = 5;
            this.detailsColumnDisplayCheckBox.Text = "Details";
            this.detailsColumnDisplayCheckBox.UseVisualStyleBackColor = true;
            // 
            // linkColumnDisplayCheckBox
            // 
            this.linkColumnDisplayCheckBox.AutoSize = true;
            this.linkColumnDisplayCheckBox.Checked = true;
            this.linkColumnDisplayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.linkColumnDisplayCheckBox.Location = new System.Drawing.Point(78, 42);
            this.linkColumnDisplayCheckBox.Name = "linkColumnDisplayCheckBox";
            this.linkColumnDisplayCheckBox.Size = new System.Drawing.Size(47, 17);
            this.linkColumnDisplayCheckBox.TabIndex = 4;
            this.linkColumnDisplayCheckBox.Text = "Link";
            this.linkColumnDisplayCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordColumnDisplayCheckBox
            // 
            this.passwordColumnDisplayCheckBox.AutoSize = true;
            this.passwordColumnDisplayCheckBox.Checked = true;
            this.passwordColumnDisplayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.passwordColumnDisplayCheckBox.Location = new System.Drawing.Point(78, 19);
            this.passwordColumnDisplayCheckBox.Name = "passwordColumnDisplayCheckBox";
            this.passwordColumnDisplayCheckBox.Size = new System.Drawing.Size(75, 17);
            this.passwordColumnDisplayCheckBox.TabIndex = 3;
            this.passwordColumnDisplayCheckBox.Text = "Password";
            this.passwordColumnDisplayCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailColumnDisplayCheckBox
            // 
            this.emailColumnDisplayCheckBox.AutoSize = true;
            this.emailColumnDisplayCheckBox.Checked = true;
            this.emailColumnDisplayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.emailColumnDisplayCheckBox.Location = new System.Drawing.Point(6, 65);
            this.emailColumnDisplayCheckBox.Name = "emailColumnDisplayCheckBox";
            this.emailColumnDisplayCheckBox.Size = new System.Drawing.Size(53, 17);
            this.emailColumnDisplayCheckBox.TabIndex = 2;
            this.emailColumnDisplayCheckBox.Text = "Email";
            this.emailColumnDisplayCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameColumnDisplayCheckBox
            // 
            this.nameColumnDisplayCheckBox.AutoSize = true;
            this.nameColumnDisplayCheckBox.Checked = true;
            this.nameColumnDisplayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nameColumnDisplayCheckBox.Location = new System.Drawing.Point(6, 42);
            this.nameColumnDisplayCheckBox.Name = "nameColumnDisplayCheckBox";
            this.nameColumnDisplayCheckBox.Size = new System.Drawing.Size(55, 17);
            this.nameColumnDisplayCheckBox.TabIndex = 1;
            this.nameColumnDisplayCheckBox.Text = "Name";
            this.nameColumnDisplayCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateColumnDisplayCheckBox
            // 
            this.dateColumnDisplayCheckBox.AutoSize = true;
            this.dateColumnDisplayCheckBox.Checked = true;
            this.dateColumnDisplayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dateColumnDisplayCheckBox.Location = new System.Drawing.Point(6, 19);
            this.dateColumnDisplayCheckBox.Name = "dateColumnDisplayCheckBox";
            this.dateColumnDisplayCheckBox.Size = new System.Drawing.Size(50, 17);
            this.dateColumnDisplayCheckBox.TabIndex = 0;
            this.dateColumnDisplayCheckBox.Text = "Date";
            this.dateColumnDisplayCheckBox.UseVisualStyleBackColor = true;
            // 
            // licenseTabPage
            // 
            this.licenseTabPage.Controls.Add(this.githubPageLinkLabel);
            this.licenseTabPage.Controls.Add(this.label2);
            this.licenseTabPage.Controls.Add(this.label1);
            this.licenseTabPage.Location = new System.Drawing.Point(4, 22);
            this.licenseTabPage.Name = "licenseTabPage";
            this.licenseTabPage.Size = new System.Drawing.Size(676, 365);
            this.licenseTabPage.TabIndex = 2;
            this.licenseTabPage.Text = "License";
            this.licenseTabPage.UseVisualStyleBackColor = true;
            // 
            // githubPageLinkLabel
            // 
            this.githubPageLinkLabel.AutoSize = true;
            this.githubPageLinkLabel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.githubPageLinkLabel.Location = new System.Drawing.Point(6, 4);
            this.githubPageLinkLabel.Name = "githubPageLinkLabel";
            this.githubPageLinkLabel.Size = new System.Drawing.Size(69, 25);
            this.githubPageLinkLabel.TabIndex = 2;
            this.githubPageLinkLabel.TabStop = true;
            this.githubPageLinkLabel.Text = "Vaultrix";
            this.githubPageLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubPageLinkLabel_LinkClicked);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(655, 326);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.Location = new System.Drawing.Point(67, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "- An Open-Source Password Manager";
            // 
            // rightClickSingleContextMenu
            // 
            this.rightClickSingleContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitWebsiteToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.showPasswordToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.deleteToolStripMenuItem1});
            this.rightClickSingleContextMenu.Name = "rightClickContextMenu";
            this.rightClickSingleContextMenu.Size = new System.Drawing.Size(157, 114);
            this.rightClickSingleContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.rightClickSingleContextMenu_Opening);
            // 
            // visitWebsiteToolStripMenuItem
            // 
            this.visitWebsiteToolStripMenuItem.Name = "visitWebsiteToolStripMenuItem";
            this.visitWebsiteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.visitWebsiteToolStripMenuItem.Text = "Visit Website";
            this.visitWebsiteToolStripMenuItem.Click += new System.EventHandler(this.visitWebsiteToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullRowToolStripMenuItem,
            this.dateToolStripMenuItem,
            this.nameToolStripMenuItem,
            this.emailToolStripMenuItem,
            this.passwordToolStripMenuItem,
            this.linkToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // fullRowToolStripMenuItem
            // 
            this.fullRowToolStripMenuItem.Name = "fullRowToolStripMenuItem";
            this.fullRowToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.fullRowToolStripMenuItem.Text = "Full Row";
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.dateToolStripMenuItem.Text = "Date";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.nameToolStripMenuItem.Text = "Name";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.emailToolStripMenuItem.Text = "Email";
            // 
            // passwordToolStripMenuItem
            // 
            this.passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
            this.passwordToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.passwordToolStripMenuItem.Text = "Password";
            // 
            // linkToolStripMenuItem
            // 
            this.linkToolStripMenuItem.Name = "linkToolStripMenuItem";
            this.linkToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.linkToolStripMenuItem.Text = "Link";
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            // 
            // showPasswordToolStripMenuItem
            // 
            this.showPasswordToolStripMenuItem.Name = "showPasswordToolStripMenuItem";
            this.showPasswordToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.showPasswordToolStripMenuItem.Text = "Show Password";
            this.showPasswordToolStripMenuItem.Click += new System.EventHandler(this.showPasswordToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // rightClickMultipleContextMenu
            // 
            this.rightClickMultipleContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.showPasswordsToolStripMenuItem,
            this.hidePasswordsToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.rightClickMultipleContextMenu.Name = "rightClickContextMenu";
            this.rightClickMultipleContextMenu.Size = new System.Drawing.Size(162, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem1.Text = "Copy Rows";
            // 
            // showPasswordsToolStripMenuItem
            // 
            this.showPasswordsToolStripMenuItem.Name = "showPasswordsToolStripMenuItem";
            this.showPasswordsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.showPasswordsToolStripMenuItem.Text = "Show Passwords";
            this.showPasswordsToolStripMenuItem.Click += new System.EventHandler(this.showPasswordsToolStripMenuItem_Click);
            // 
            // hidePasswordsToolStripMenuItem
            // 
            this.hidePasswordsToolStripMenuItem.Name = "hidePasswordsToolStripMenuItem";
            this.hidePasswordsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.hidePasswordsToolStripMenuItem.Text = "Hide Passwords";
            this.hidePasswordsToolStripMenuItem.Click += new System.EventHandler(this.hidePasswordsToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 391);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 430);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vaultrix | Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.passwordsTabPage.ResumeLayout(false);
            this.passwordsTabPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.settingsTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.licenseTabPage.ResumeLayout(false);
            this.licenseTabPage.PerformLayout();
            this.rightClickSingleContextMenu.ResumeLayout(false);
            this.rightClickMultipleContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage passwordsTabPage;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.TabPage licenseTabPage;
        private System.Windows.Forms.ListView entriesListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader emailColumnHeader;
        private System.Windows.Forms.ColumnHeader passwordColumnHeader;
        private System.Windows.Forms.ColumnHeader linkColumnHeader;
        private System.Windows.Forms.ColumnHeader detailsColumnHeader;
        private System.Windows.Forms.Button addNewEntryButton;
        private System.Windows.Forms.Button deleteEntryButton;
        private System.Windows.Forms.Button modifyEntryButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.ColumnHeader dateColumnHeader;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label vaultNameLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox dateColumnDisplayCheckBox;
        private System.Windows.Forms.CheckBox linkColumnDisplayCheckBox;
        private System.Windows.Forms.CheckBox passwordColumnDisplayCheckBox;
        private System.Windows.Forms.CheckBox emailColumnDisplayCheckBox;
        private System.Windows.Forms.CheckBox nameColumnDisplayCheckBox;
        private System.Windows.Forms.CheckBox detailsColumnDisplayCheckBox;
        private System.Windows.Forms.ContextMenuStrip rightClickSingleContextMenu;
        private System.Windows.Forms.ToolStripMenuItem visitWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip rightClickMultipleContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPasswordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hidePasswordsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel githubPageLinkLabel;
    }
}

