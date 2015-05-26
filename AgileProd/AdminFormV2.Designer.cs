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
            this.tabControl.SuspendLayout();
            this.person.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.person);
            this.tabControl.Controls.Add(this.memberTab);
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
    }
}