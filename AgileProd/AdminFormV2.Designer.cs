namespace AgileProd
{
    partial class AdminFormV2
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.person = new System.Windows.Forms.TabPage();
            this.personToPlartyButton = new System.Windows.Forms.Button();
            this.updateInfoButton = new System.Windows.Forms.Button();
            this.userInfoGrid = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.votingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.votesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletePersonButton = new System.Windows.Forms.Button();
            this.createPersonButton = new System.Windows.Forms.Button();
            this.memberTab = new System.Windows.Forms.TabPage();
            this.memberInfoGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyTab = new System.Windows.Forms.TabPage();
            this.deletePartyButton = new System.Windows.Forms.Button();
            this.partyInfoGrid = new System.Windows.Forms.DataGridView();
            this.partyNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partySizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfVotesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.committeeTab = new System.Windows.Forms.TabPage();
            this.committeeInfoGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankTab = new System.Windows.Forms.TabPage();
            this.updateBankInfoButton = new System.Windows.Forms.Button();
            this.bankInfoGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminTab = new System.Windows.Forms.TabPage();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminInfoGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateAdminInfoButton = new System.Windows.Forms.Button();
            this.runElectionsButton = new System.Windows.Forms.Button();
            this.runPrimeriesButton = new System.Windows.Forms.Button();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.logoutButton = new System.Windows.Forms.Button();
            this.runPraimeriesWorker = new System.ComponentModel.BackgroundWorker();
            this.runElectionsWorker = new System.ComponentModel.BackgroundWorker();
            this.tabControl.SuspendLayout();
            this.person.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoGrid)).BeginInit();
            this.memberTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberInfoGrid)).BeginInit();
            this.partyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partyInfoGrid)).BeginInit();
            this.committeeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.committeeInfoGrid)).BeginInit();
            this.bankTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankInfoGrid)).BeginInit();
            this.adminTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminInfoGrid)).BeginInit();
            this.settingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.person);
            this.tabControl.Controls.Add(this.memberTab);
            this.tabControl.Controls.Add(this.partyTab);
            this.tabControl.Controls.Add(this.committeeTab);
            this.tabControl.Controls.Add(this.bankTab);
            this.tabControl.Controls.Add(this.adminTab);
            this.tabControl.Controls.Add(this.settingsTab);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(744, 265);
            this.tabControl.TabIndex = 0;
            // 
            // person
            // 
            this.person.Controls.Add(this.personToPlartyButton);
            this.person.Controls.Add(this.updateInfoButton);
            this.person.Controls.Add(this.userInfoGrid);
            this.person.Controls.Add(this.deletePersonButton);
            this.person.Controls.Add(this.createPersonButton);
            this.person.Location = new System.Drawing.Point(4, 22);
            this.person.Name = "person";
            this.person.Padding = new System.Windows.Forms.Padding(3);
            this.person.Size = new System.Drawing.Size(736, 239);
            this.person.TabIndex = 0;
            this.person.Text = "Person";
            this.person.UseVisualStyleBackColor = true;
            // 
            // personToPlartyButton
            // 
            this.personToPlartyButton.Location = new System.Drawing.Point(6, 93);
            this.personToPlartyButton.Name = "personToPlartyButton";
            this.personToPlartyButton.Size = new System.Drawing.Size(94, 35);
            this.personToPlartyButton.TabIndex = 6;
            this.personToPlartyButton.Text = "Add Person To Party";
            this.personToPlartyButton.UseVisualStyleBackColor = true;
            this.personToPlartyButton.Click += new System.EventHandler(this.personToPlartyButton_Click);
            // 
            // updateInfoButton
            // 
            this.updateInfoButton.Location = new System.Drawing.Point(6, 64);
            this.updateInfoButton.Name = "updateInfoButton";
            this.updateInfoButton.Size = new System.Drawing.Size(94, 23);
            this.updateInfoButton.TabIndex = 5;
            this.updateInfoButton.Text = "Update Info.";
            this.updateInfoButton.UseVisualStyleBackColor = true;
            this.updateInfoButton.Click += new System.EventHandler(this.updateInfoButton_Click);
            // 
            // userInfoGrid
            // 
            this.userInfoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userInfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.ageColumn,
            this.usernameColumn,
            this.passwordColumn,
            this.votingColumn,
            this.votesColumn});
            this.userInfoGrid.Location = new System.Drawing.Point(107, 6);
            this.userInfoGrid.Name = "userInfoGrid";
            this.userInfoGrid.Size = new System.Drawing.Size(623, 227);
            this.userInfoGrid.TabIndex = 4;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // ageColumn
            // 
            this.ageColumn.HeaderText = "Age";
            this.ageColumn.Name = "ageColumn";
            this.ageColumn.ReadOnly = true;
            // 
            // usernameColumn
            // 
            this.usernameColumn.HeaderText = "Username";
            this.usernameColumn.Name = "usernameColumn";
            this.usernameColumn.ReadOnly = true;
            // 
            // passwordColumn
            // 
            this.passwordColumn.HeaderText = "Password";
            this.passwordColumn.Name = "passwordColumn";
            this.passwordColumn.ReadOnly = true;
            // 
            // votingColumn
            // 
            this.votingColumn.HeaderText = "Voter";
            this.votingColumn.Name = "votingColumn";
            this.votingColumn.ReadOnly = true;
            // 
            // votesColumn
            // 
            this.votesColumn.HeaderText = "Times Voted";
            this.votesColumn.Name = "votesColumn";
            this.votesColumn.ReadOnly = true;
            // 
            // deletePersonButton
            // 
            this.deletePersonButton.Location = new System.Drawing.Point(6, 35);
            this.deletePersonButton.Name = "deletePersonButton";
            this.deletePersonButton.Size = new System.Drawing.Size(94, 23);
            this.deletePersonButton.TabIndex = 1;
            this.deletePersonButton.Text = "Delete Person";
            this.deletePersonButton.UseVisualStyleBackColor = true;
            this.deletePersonButton.Click += new System.EventHandler(this.deletePersonButton_Click);
            // 
            // createPersonButton
            // 
            this.createPersonButton.Location = new System.Drawing.Point(6, 6);
            this.createPersonButton.Name = "createPersonButton";
            this.createPersonButton.Size = new System.Drawing.Size(94, 23);
            this.createPersonButton.TabIndex = 0;
            this.createPersonButton.Text = "Create Person";
            this.createPersonButton.UseVisualStyleBackColor = true;
            this.createPersonButton.Click += new System.EventHandler(this.createPersonButton_Click);
            // 
            // memberTab
            // 
            this.memberTab.Controls.Add(this.memberInfoGrid);
            this.memberTab.Location = new System.Drawing.Point(4, 22);
            this.memberTab.Name = "memberTab";
            this.memberTab.Padding = new System.Windows.Forms.Padding(3);
            this.memberTab.Size = new System.Drawing.Size(736, 239);
            this.memberTab.TabIndex = 1;
            this.memberTab.Text = "Party Member";
            this.memberTab.UseVisualStyleBackColor = true;
            // 
            // memberInfoGrid
            // 
            this.memberInfoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.memberInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberInfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.partyColumn,
            this.dataGridViewTextBoxColumn6});
            this.memberInfoGrid.Location = new System.Drawing.Point(107, 6);
            this.memberInfoGrid.Name = "memberInfoGrid";
            this.memberInfoGrid.Size = new System.Drawing.Size(623, 227);
            this.memberInfoGrid.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Age";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Username";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Password";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // partyColumn
            // 
            this.partyColumn.HeaderText = "Party";
            this.partyColumn.Name = "partyColumn";
            this.partyColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Loc. in party";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // partyTab
            // 
            this.partyTab.Controls.Add(this.deletePartyButton);
            this.partyTab.Controls.Add(this.partyInfoGrid);
            this.partyTab.Location = new System.Drawing.Point(4, 22);
            this.partyTab.Name = "partyTab";
            this.partyTab.Size = new System.Drawing.Size(736, 239);
            this.partyTab.TabIndex = 4;
            this.partyTab.Text = "Party";
            this.partyTab.UseVisualStyleBackColor = true;
            // 
            // deletePartyButton
            // 
            this.deletePartyButton.Location = new System.Drawing.Point(6, 6);
            this.deletePartyButton.Name = "deletePartyButton";
            this.deletePartyButton.Size = new System.Drawing.Size(94, 23);
            this.deletePartyButton.TabIndex = 8;
            this.deletePartyButton.Text = "Delete Party";
            this.deletePartyButton.UseVisualStyleBackColor = true;
            this.deletePartyButton.Click += new System.EventHandler(this.deletePartyButton_Click);
            // 
            // partyInfoGrid
            // 
            this.partyInfoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partyInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partyInfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partyNameColumn,
            this.partySizeColumn,
            this.numOfVotesColumn});
            this.partyInfoGrid.Location = new System.Drawing.Point(107, 6);
            this.partyInfoGrid.Name = "partyInfoGrid";
            this.partyInfoGrid.Size = new System.Drawing.Size(623, 227);
            this.partyInfoGrid.TabIndex = 7;
            // 
            // partyNameColumn
            // 
            this.partyNameColumn.HeaderText = "Party Name";
            this.partyNameColumn.Name = "partyNameColumn";
            this.partyNameColumn.ReadOnly = true;
            // 
            // partySizeColumn
            // 
            this.partySizeColumn.HeaderText = "Party size";
            this.partySizeColumn.Name = "partySizeColumn";
            this.partySizeColumn.ReadOnly = true;
            // 
            // numOfVotesColumn
            // 
            this.numOfVotesColumn.HeaderText = "Votes";
            this.numOfVotesColumn.Name = "numOfVotesColumn";
            this.numOfVotesColumn.ReadOnly = true;
            // 
            // committeeTab
            // 
            this.committeeTab.Controls.Add(this.committeeInfoGrid);
            this.committeeTab.Location = new System.Drawing.Point(4, 22);
            this.committeeTab.Name = "committeeTab";
            this.committeeTab.Padding = new System.Windows.Forms.Padding(3);
            this.committeeTab.Size = new System.Drawing.Size(736, 239);
            this.committeeTab.TabIndex = 2;
            this.committeeTab.Text = "Committee";
            this.committeeTab.UseVisualStyleBackColor = true;
            // 
            // committeeInfoGrid
            // 
            this.committeeInfoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.committeeInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.committeeInfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.committeeInfoGrid.Location = new System.Drawing.Point(107, 6);
            this.committeeInfoGrid.Name = "committeeInfoGrid";
            this.committeeInfoGrid.Size = new System.Drawing.Size(623, 227);
            this.committeeInfoGrid.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Age";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // bankTab
            // 
            this.bankTab.Controls.Add(this.updateBankInfoButton);
            this.bankTab.Controls.Add(this.bankInfoGrid);
            this.bankTab.Location = new System.Drawing.Point(4, 22);
            this.bankTab.Name = "bankTab";
            this.bankTab.Size = new System.Drawing.Size(736, 239);
            this.bankTab.TabIndex = 6;
            this.bankTab.Text = "Bank";
            this.bankTab.UseVisualStyleBackColor = true;
            // 
            // updateBankInfoButton
            // 
            this.updateBankInfoButton.Location = new System.Drawing.Point(6, 6);
            this.updateBankInfoButton.Name = "updateBankInfoButton";
            this.updateBankInfoButton.Size = new System.Drawing.Size(94, 23);
            this.updateBankInfoButton.TabIndex = 8;
            this.updateBankInfoButton.Text = "Update Ac.";
            this.updateBankInfoButton.UseVisualStyleBackColor = true;
            this.updateBankInfoButton.Click += new System.EventHandler(this.updateBankInfoButton_Click);
            // 
            // bankInfoGrid
            // 
            this.bankInfoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bankInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bankInfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.bankInfoGrid.Location = new System.Drawing.Point(107, 6);
            this.bankInfoGrid.Name = "bankInfoGrid";
            this.bankInfoGrid.Size = new System.Drawing.Size(623, 227);
            this.bankInfoGrid.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Name";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // adminTab
            // 
            this.adminTab.Controls.Add(this.progressBar);
            this.adminTab.Controls.Add(this.pictureBox1);
            this.adminTab.Controls.Add(this.adminInfoGrid);
            this.adminTab.Controls.Add(this.updateAdminInfoButton);
            this.adminTab.Controls.Add(this.runElectionsButton);
            this.adminTab.Controls.Add(this.runPrimeriesButton);
            this.adminTab.Location = new System.Drawing.Point(4, 22);
            this.adminTab.Name = "adminTab";
            this.adminTab.Size = new System.Drawing.Size(736, 239);
            this.adminTab.TabIndex = 3;
            this.adminTab.Text = "Admin";
            this.adminTab.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(107, 218);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(623, 15);
            this.progressBar.TabIndex = 16;
            this.progressBar.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgileProd.Properties.Resources.DancingPutin2;
            this.pictureBox1.Location = new System.Drawing.Point(8, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // adminInfoGrid
            // 
            this.adminInfoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adminInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminInfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.adminInfoGrid.Location = new System.Drawing.Point(107, 6);
            this.adminInfoGrid.Name = "adminInfoGrid";
            this.adminInfoGrid.Size = new System.Drawing.Size(623, 227);
            this.adminInfoGrid.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "ID";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Name";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Username";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Password";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // updateAdminInfoButton
            // 
            this.updateAdminInfoButton.Location = new System.Drawing.Point(6, 6);
            this.updateAdminInfoButton.Name = "updateAdminInfoButton";
            this.updateAdminInfoButton.Size = new System.Drawing.Size(94, 23);
            this.updateAdminInfoButton.TabIndex = 13;
            this.updateAdminInfoButton.Text = "Update Info.";
            this.updateAdminInfoButton.UseVisualStyleBackColor = true;
            this.updateAdminInfoButton.Click += new System.EventHandler(this.updateAdminInfoButton_Click);
            // 
            // runElectionsButton
            // 
            this.runElectionsButton.Location = new System.Drawing.Point(6, 64);
            this.runElectionsButton.Name = "runElectionsButton";
            this.runElectionsButton.Size = new System.Drawing.Size(94, 23);
            this.runElectionsButton.TabIndex = 10;
            this.runElectionsButton.Text = "Run Elections";
            this.runElectionsButton.UseVisualStyleBackColor = true;
            this.runElectionsButton.Click += new System.EventHandler(this.runElectionsButton_Click);
            // 
            // runPrimeriesButton
            // 
            this.runPrimeriesButton.Location = new System.Drawing.Point(6, 35);
            this.runPrimeriesButton.Name = "runPrimeriesButton";
            this.runPrimeriesButton.Size = new System.Drawing.Size(94, 23);
            this.runPrimeriesButton.TabIndex = 9;
            this.runPrimeriesButton.Text = "Run Praimeries";
            this.runPrimeriesButton.UseVisualStyleBackColor = true;
            this.runPrimeriesButton.Click += new System.EventHandler(this.runPrimeriesButton_Click);
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.logoutButton);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(736, 239);
            this.settingsTab.TabIndex = 5;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(639, 213);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(94, 23);
            this.logoutButton.TabIndex = 14;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // runPraimeriesWorker
            // 
            this.runPraimeriesWorker.WorkerReportsProgress = true;
            this.runPraimeriesWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.runPraimeriesWorker_DoWork);
            // 
            // runElectionsWorker
            // 
            this.runElectionsWorker.WorkerReportsProgress = true;
            this.runElectionsWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.runElectionsWorker_DoWork);
            // 
            // AdminFormV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 262);
            this.Controls.Add(this.tabControl);
            this.Name = "AdminFormV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.tabControl.ResumeLayout(false);
            this.person.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userInfoGrid)).EndInit();
            this.memberTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memberInfoGrid)).EndInit();
            this.partyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.partyInfoGrid)).EndInit();
            this.committeeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.committeeInfoGrid)).EndInit();
            this.bankTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bankInfoGrid)).EndInit();
            this.adminTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminInfoGrid)).EndInit();
            this.settingsTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage person;
        private System.Windows.Forms.TabPage memberTab;
        private System.Windows.Forms.TabPage committeeTab;
        private System.Windows.Forms.TabPage adminTab;
        private System.Windows.Forms.Button deletePersonButton;
        private System.Windows.Forms.Button createPersonButton;
        private System.Windows.Forms.DataGridView userInfoGrid;
        private System.Windows.Forms.Button updateInfoButton;
        private System.Windows.Forms.DataGridView memberInfoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TabPage partyTab;
        private System.Windows.Forms.DataGridView committeeInfoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridView partyInfoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partySizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfVotesColumn;
        private System.Windows.Forms.Button deletePartyButton;
        private System.Windows.Forms.Button runElectionsButton;
        private System.Windows.Forms.Button runPrimeriesButton;
        private System.Windows.Forms.TabPage bankTab;
        private System.Windows.Forms.DataGridView bankInfoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.Button updateBankInfoButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView adminInfoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.Button updateAdminInfoButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button personToPlartyButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn votingColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn votesColumn;
        private System.ComponentModel.BackgroundWorker runPraimeriesWorker;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker runElectionsWorker;
    }
}