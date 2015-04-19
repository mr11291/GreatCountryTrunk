namespace AgileProd
{
    partial class AdminForm
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
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.ViewPeopleList = new System.Windows.Forms.TabPage();
            this.dataGridPeople = new System.Windows.Forms.DataGridView();
            this.dataGridID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isVoting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewPeople = new System.Windows.Forms.Button();
            this.IDlabel = new System.Windows.Forms.Label();
            this.IDtextbox = new System.Windows.Forms.TextBox();
            this.DeletePerson = new System.Windows.Forms.Button();
            this.AddPerson = new System.Windows.Forms.Button();
            this.RevokeVoter = new System.Windows.Forms.Button();
            this.RegisterVoter = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.MessageTab = new System.Windows.Forms.TabPage();
            this.MessageList = new System.Windows.Forms.ListBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ReadButton = new System.Windows.Forms.Button();
            this.tabMenu.SuspendLayout();
            this.ViewPeopleList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPeople)).BeginInit();
            this.MessageTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.ViewPeopleList);
            this.tabMenu.Controls.Add(this.tabPage2);
            this.tabMenu.Controls.Add(this.tabPage3);
            this.tabMenu.Controls.Add(this.tabPage4);
            this.tabMenu.Controls.Add(this.MessageTab);
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(885, 261);
            this.tabMenu.TabIndex = 0;
            // 
            // ViewPeopleList
            // 
            this.ViewPeopleList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ViewPeopleList.Controls.Add(this.dataGridPeople);
            this.ViewPeopleList.Controls.Add(this.ViewPeople);
            this.ViewPeopleList.Controls.Add(this.IDlabel);
            this.ViewPeopleList.Controls.Add(this.IDtextbox);
            this.ViewPeopleList.Controls.Add(this.DeletePerson);
            this.ViewPeopleList.Controls.Add(this.AddPerson);
            this.ViewPeopleList.Controls.Add(this.RevokeVoter);
            this.ViewPeopleList.Controls.Add(this.RegisterVoter);
            this.ViewPeopleList.Location = new System.Drawing.Point(4, 22);
            this.ViewPeopleList.Name = "ViewPeopleList";
            this.ViewPeopleList.Padding = new System.Windows.Forms.Padding(3);
            this.ViewPeopleList.Size = new System.Drawing.Size(877, 235);
            this.ViewPeopleList.TabIndex = 0;
            this.ViewPeopleList.Text = "Person";
            // 
            // dataGridPeople
            // 
            this.dataGridPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridID,
            this.dataGridName,
            this.dataGridAge,
            this.dataGridUserName,
            this.dataGridPassword,
            this.isVoting});
            this.dataGridPeople.Location = new System.Drawing.Point(282, 7);
            this.dataGridPeople.Name = "dataGridPeople";
            this.dataGridPeople.Size = new System.Drawing.Size(586, 222);
            this.dataGridPeople.TabIndex = 8;
            // 
            // dataGridID
            // 
            this.dataGridID.HeaderText = "ID";
            this.dataGridID.Name = "dataGridID";
            this.dataGridID.ReadOnly = true;
            // 
            // dataGridName
            // 
            this.dataGridName.HeaderText = "Name";
            this.dataGridName.Name = "dataGridName";
            this.dataGridName.ReadOnly = true;
            // 
            // dataGridAge
            // 
            this.dataGridAge.HeaderText = "Age";
            this.dataGridAge.Name = "dataGridAge";
            this.dataGridAge.ReadOnly = true;
            this.dataGridAge.Width = 40;
            // 
            // dataGridUserName
            // 
            this.dataGridUserName.HeaderText = "Username";
            this.dataGridUserName.Name = "dataGridUserName";
            this.dataGridUserName.ReadOnly = true;
            // 
            // dataGridPassword
            // 
            this.dataGridPassword.HeaderText = "Password";
            this.dataGridPassword.Name = "dataGridPassword";
            this.dataGridPassword.ReadOnly = true;
            // 
            // isVoting
            // 
            this.isVoting.HeaderText = "Registered Voter";
            this.isVoting.Name = "isVoting";
            // 
            // ViewPeople
            // 
            this.ViewPeople.Location = new System.Drawing.Point(140, 64);
            this.ViewPeople.Name = "ViewPeople";
            this.ViewPeople.Size = new System.Drawing.Size(100, 23);
            this.ViewPeople.TabIndex = 7;
            this.ViewPeople.Text = "View people list";
            this.ViewPeople.UseVisualStyleBackColor = true;
            this.ViewPeople.Click += new System.EventHandler(this.ViewPeople_Click);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(116, 40);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(21, 13);
            this.IDlabel.TabIndex = 6;
            this.IDlabel.Text = "ID:";
            // 
            // IDtextbox
            // 
            this.IDtextbox.Location = new System.Drawing.Point(140, 35);
            this.IDtextbox.Multiline = true;
            this.IDtextbox.Name = "IDtextbox";
            this.IDtextbox.Size = new System.Drawing.Size(100, 23);
            this.IDtextbox.TabIndex = 5;
            // 
            // DeletePerson
            // 
            this.DeletePerson.Location = new System.Drawing.Point(8, 35);
            this.DeletePerson.Name = "DeletePerson";
            this.DeletePerson.Size = new System.Drawing.Size(102, 23);
            this.DeletePerson.TabIndex = 2;
            this.DeletePerson.Text = "Delete Person";
            this.DeletePerson.UseVisualStyleBackColor = true;
            this.DeletePerson.Click += new System.EventHandler(this.DeletePerson_Click);
            // 
            // AddPerson
            // 
            this.AddPerson.Location = new System.Drawing.Point(8, 6);
            this.AddPerson.Name = "AddPerson";
            this.AddPerson.Size = new System.Drawing.Size(102, 23);
            this.AddPerson.TabIndex = 1;
            this.AddPerson.Text = "Add New Person";
            this.AddPerson.UseVisualStyleBackColor = true;
            this.AddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // RevokeVoter
            // 
            this.RevokeVoter.Location = new System.Drawing.Point(8, 93);
            this.RevokeVoter.Name = "RevokeVoter";
            this.RevokeVoter.Size = new System.Drawing.Size(102, 23);
            this.RevokeVoter.TabIndex = 4;
            this.RevokeVoter.Text = "Revoke a voter";
            this.RevokeVoter.UseVisualStyleBackColor = true;
            // 
            // RegisterVoter
            // 
            this.RegisterVoter.Location = new System.Drawing.Point(8, 64);
            this.RegisterVoter.Name = "RegisterVoter";
            this.RegisterVoter.Size = new System.Drawing.Size(102, 23);
            this.RegisterVoter.TabIndex = 3;
            this.RegisterVoter.Text = "Register a voter";
            this.RegisterVoter.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(877, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Party Member";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(877, 235);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Committee Member";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(877, 235);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Admin";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // MessageTab
            // 
            this.MessageTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MessageTab.Controls.Add(this.ReadButton);
            this.MessageTab.Controls.Add(this.DeleteButton);
            this.MessageTab.Controls.Add(this.MessageList);
            this.MessageTab.Location = new System.Drawing.Point(4, 22);
            this.MessageTab.Name = "MessageTab";
            this.MessageTab.Padding = new System.Windows.Forms.Padding(3);
            this.MessageTab.Size = new System.Drawing.Size(877, 235);
            this.MessageTab.TabIndex = 4;
            this.MessageTab.Text = "Messages";
            // 
            // MessageList
            // 
            this.MessageList.FormattingEnabled = true;
            this.MessageList.Location = new System.Drawing.Point(3, 6);
            this.MessageList.Name = "MessageList";
            this.MessageList.Size = new System.Drawing.Size(205, 225);
            this.MessageList.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(213, 35);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(213, 6);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(75, 23);
            this.ReadButton.TabIndex = 2;
            this.ReadButton.Text = "Read";
            this.ReadButton.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 262);
            this.Controls.Add(this.tabMenu);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.tabMenu.ResumeLayout(false);
            this.ViewPeopleList.ResumeLayout(false);
            this.ViewPeopleList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPeople)).EndInit();
            this.MessageTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage ViewPeopleList;
        private System.Windows.Forms.Button DeletePerson;
        private System.Windows.Forms.Button AddPerson;
        private System.Windows.Forms.Button RevokeVoter;
        private System.Windows.Forms.Button RegisterVoter;
        private System.Windows.Forms.TabPage MessageTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox IDtextbox;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Button ViewPeople;
        private System.Windows.Forms.DataGridView dataGridPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn isVoting;
        private System.Windows.Forms.ListBox MessageList;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button DeleteButton;
       

    }
}