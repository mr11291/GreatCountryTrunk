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
            this.updateInfoButton = new System.Windows.Forms.Button();
            this.userInfoGrid = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.votingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletePersonButton = new System.Windows.Forms.Button();
            this.createPersonButton = new System.Windows.Forms.Button();
            this.memberTab = new System.Windows.Forms.TabPage();
            this.committeeTab = new System.Windows.Forms.TabPage();
            this.adminTab = new System.Windows.Forms.TabPage();
            this.memberInfoGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyTab = new System.Windows.Forms.TabPage();
            this.committeeInfoGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.person.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoGrid)).BeginInit();
            this.memberTab.SuspendLayout();
            this.committeeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberInfoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.committeeInfoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.person);
            this.tabControl.Controls.Add(this.memberTab);
            this.tabControl.Controls.Add(this.partyTab);
            this.tabControl.Controls.Add(this.committeeTab);
            this.tabControl.Controls.Add(this.adminTab);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(744, 265);
            this.tabControl.TabIndex = 0;
            // 
            // person
            // 
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
            // updateInfoButton
            // 
            this.updateInfoButton.Location = new System.Drawing.Point(6, 64);
            this.updateInfoButton.Name = "updateInfoButton";
            this.updateInfoButton.Size = new System.Drawing.Size(94, 23);
            this.updateInfoButton.TabIndex = 5;
            this.updateInfoButton.Text = "Update Info";
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
            this.votingColumn});
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
            // adminTab
            // 
            this.adminTab.Location = new System.Drawing.Point(4, 22);
            this.adminTab.Name = "adminTab";
            this.adminTab.Size = new System.Drawing.Size(736, 239);
            this.adminTab.TabIndex = 3;
            this.adminTab.Text = "Admin";
            this.adminTab.UseVisualStyleBackColor = true;
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
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Loc. in party";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // partyColumn
            // 
            this.partyColumn.HeaderText = "Party";
            this.partyColumn.Name = "partyColumn";
            this.partyColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Password";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Username";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Age";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // partyTab
            // 
            this.partyTab.Location = new System.Drawing.Point(4, 22);
            this.partyTab.Name = "partyTab";
            this.partyTab.Size = new System.Drawing.Size(736, 239);
            this.partyTab.TabIndex = 4;
            this.partyTab.Text = "Party";
            this.partyTab.UseVisualStyleBackColor = true;
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
            this.committeeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memberInfoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.committeeInfoGrid)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn votingColumn;
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
    }
}