namespace AgileProd
{
    partial class PersonForm
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
            this.personTabMenu = new System.Windows.Forms.TabControl();
            this.MenuTab = new System.Windows.Forms.TabPage();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.BankTab = new System.Windows.Forms.TabPage();
            this.MessageTab = new System.Windows.Forms.TabPage();
            this.VoteButton = new System.Windows.Forms.Button();
            this.VoterCheckBox = new System.Windows.Forms.CheckBox();
            this.InfoGrid = new System.Windows.Forms.DataGridView();
            this.IDcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personTabMenu.SuspendLayout();
            this.MenuTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // personTabMenu
            // 
            this.personTabMenu.Controls.Add(this.MenuTab);
            this.personTabMenu.Controls.Add(this.SettingsTab);
            this.personTabMenu.Controls.Add(this.BankTab);
            this.personTabMenu.Controls.Add(this.MessageTab);
            this.personTabMenu.Location = new System.Drawing.Point(1, 1);
            this.personTabMenu.Name = "personTabMenu";
            this.personTabMenu.SelectedIndex = 0;
            this.personTabMenu.Size = new System.Drawing.Size(610, 260);
            this.personTabMenu.TabIndex = 0;
            // 
            // MenuTab
            // 
            this.MenuTab.Controls.Add(this.InfoGrid);
            this.MenuTab.Controls.Add(this.VoterCheckBox);
            this.MenuTab.Controls.Add(this.VoteButton);
            this.MenuTab.Location = new System.Drawing.Point(4, 22);
            this.MenuTab.Name = "MenuTab";
            this.MenuTab.Padding = new System.Windows.Forms.Padding(3);
            this.MenuTab.Size = new System.Drawing.Size(602, 234);
            this.MenuTab.TabIndex = 0;
            this.MenuTab.Text = "Menu";
            this.MenuTab.UseVisualStyleBackColor = true;
            // 
            // SettingsTab
            // 
            this.SettingsTab.Location = new System.Drawing.Point(4, 22);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(602, 234);
            this.SettingsTab.TabIndex = 1;
            this.SettingsTab.Text = "Setting";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // BankTab
            // 
            this.BankTab.Location = new System.Drawing.Point(4, 22);
            this.BankTab.Name = "BankTab";
            this.BankTab.Size = new System.Drawing.Size(602, 234);
            this.BankTab.TabIndex = 2;
            this.BankTab.Text = "Bank";
            this.BankTab.UseVisualStyleBackColor = true;
            // 
            // MessageTab
            // 
            this.MessageTab.Location = new System.Drawing.Point(4, 22);
            this.MessageTab.Name = "MessageTab";
            this.MessageTab.Size = new System.Drawing.Size(602, 234);
            this.MessageTab.TabIndex = 3;
            this.MessageTab.Text = "Messages";
            this.MessageTab.UseVisualStyleBackColor = true;
            // 
            // VoteButton
            // 
            this.VoteButton.Location = new System.Drawing.Point(7, 6);
            this.VoteButton.Name = "VoteButton";
            this.VoteButton.Size = new System.Drawing.Size(75, 23);
            this.VoteButton.TabIndex = 0;
            this.VoteButton.Text = "Vote";
            this.VoteButton.UseVisualStyleBackColor = true;
            this.VoteButton.Click += new System.EventHandler(this.VoteButton_Click);
            // 
            // VoterCheckBox
            // 
            this.VoterCheckBox.AutoSize = true;
            this.VoterCheckBox.Location = new System.Drawing.Point(496, 210);
            this.VoterCheckBox.Name = "VoterCheckBox";
            this.VoterCheckBox.Size = new System.Drawing.Size(96, 17);
            this.VoterCheckBox.TabIndex = 1;
            this.VoterCheckBox.Text = "Registed Voter";
            this.VoterCheckBox.UseVisualStyleBackColor = true;
            // 
            // InfoGrid
            // 
            this.InfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDcolumn,
            this.NameColumn});
            this.InfoGrid.Location = new System.Drawing.Point(88, 6);
            this.InfoGrid.Name = "InfoGrid";
            this.InfoGrid.Size = new System.Drawing.Size(495, 198);
            this.InfoGrid.TabIndex = 2;
            // 
            // IDcolumn
            // 
            this.IDcolumn.HeaderText = "ID";
            this.IDcolumn.Name = "IDcolumn";
            this.IDcolumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 262);
            this.Controls.Add(this.personTabMenu);
            this.Name = "PersonForm";
            this.Text = "PersonForm";
            this.personTabMenu.ResumeLayout(false);
            this.MenuTab.ResumeLayout(false);
            this.MenuTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl personTabMenu;
        private System.Windows.Forms.TabPage MenuTab;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.TabPage BankTab;
        private System.Windows.Forms.CheckBox VoterCheckBox;
        private System.Windows.Forms.Button VoteButton;
        private System.Windows.Forms.TabPage MessageTab;
        private System.Windows.Forms.DataGridView InfoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
    }
}