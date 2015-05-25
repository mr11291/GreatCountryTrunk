namespace AgileProd
{
    partial class BaseForm
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
            this.blankTab = new System.Windows.Forms.TabPage();
            this.username = new System.Windows.Forms.TextBox();
            this.bankTab = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lastTransactionsLabel = new System.Windows.Forms.Label();
            this.balanceBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.messageTab = new System.Windows.Forms.TabPage();
            this.readBtn = new System.Windows.Forms.Button();
            this.btnAllMsg = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.fromLabel = new System.Windows.Forms.Label();
            this.fromList = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.logoutButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.settingsPasswordBox = new System.Windows.Forms.TextBox();
            this.settingsUserNameBox = new System.Windows.Forms.TextBox();
            this.settingsIdBox = new System.Windows.Forms.TextBox();
            this.settingsNameBox = new System.Windows.Forms.TextBox();
            this.settingsPasswordLabel = new System.Windows.Forms.Label();
            this.settingsUserNameLabel = new System.Windows.Forms.Label();
            this.settingsIdLabel = new System.Windows.Forms.Label();
            this.settingNameLabel = new System.Windows.Forms.Label();
            this.tabMenu.SuspendLayout();
            this.blankTab.SuspendLayout();
            this.bankTab.SuspendLayout();
            this.messageTab.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.blankTab);
            this.tabMenu.Controls.Add(this.bankTab);
            this.tabMenu.Controls.Add(this.messageTab);
            this.tabMenu.Controls.Add(this.settingsTab);
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(680, 310);
            this.tabMenu.TabIndex = 0;
            // 
            // blankTab
            // 
            this.blankTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.blankTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.blankTab.Controls.Add(this.username);
            this.blankTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.blankTab.Location = new System.Drawing.Point(4, 22);
            this.blankTab.Name = "blankTab";
            this.blankTab.Padding = new System.Windows.Forms.Padding(3);
            this.blankTab.Size = new System.Drawing.Size(672, 284);
            this.blankTab.TabIndex = 1;
            this.blankTab.Text = "Blank";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.ControlLight;
            this.username.ForeColor = System.Drawing.Color.Red;
            this.username.Location = new System.Drawing.Point(6, 259);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(126, 20);
            this.username.TabIndex = 31;
            this.username.Text = "User:";
            // 
            // bankTab
            // 
            this.bankTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bankTab.BackgroundImage = global::AgileProd.Properties.Resources.cashstack_op10;
            this.bankTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bankTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bankTab.Controls.Add(this.listView1);
            this.bankTab.Controls.Add(this.lastTransactionsLabel);
            this.bankTab.Controls.Add(this.balanceBox);
            this.bankTab.Controls.Add(this.idBox);
            this.bankTab.Controls.Add(this.nameBox);
            this.bankTab.Controls.Add(this.balanceLabel);
            this.bankTab.Controls.Add(this.idLabel);
            this.bankTab.Controls.Add(this.nameLabel);
            this.bankTab.Location = new System.Drawing.Point(4, 22);
            this.bankTab.Name = "bankTab";
            this.bankTab.Size = new System.Drawing.Size(672, 284);
            this.bankTab.TabIndex = 3;
            this.bankTab.Text = "Bank";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(480, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(185, 235);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lastTransactionsLabel
            // 
            this.lastTransactionsLabel.AutoSize = true;
            this.lastTransactionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lastTransactionsLabel.Location = new System.Drawing.Point(477, 22);
            this.lastTransactionsLabel.Name = "lastTransactionsLabel";
            this.lastTransactionsLabel.Size = new System.Drawing.Size(135, 16);
            this.lastTransactionsLabel.TabIndex = 8;
            this.lastTransactionsLabel.Text = "Last Transactions:";
            // 
            // balanceBox
            // 
            this.balanceBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.balanceBox.Location = new System.Drawing.Point(70, 80);
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.ReadOnly = true;
            this.balanceBox.Size = new System.Drawing.Size(100, 20);
            this.balanceBox.TabIndex = 6;
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.idBox.Location = new System.Drawing.Point(70, 50);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(100, 20);
            this.idBox.TabIndex = 5;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.nameBox.Location = new System.Drawing.Point(70, 20);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 4;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(20, 83);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(49, 13);
            this.balanceLabel.TabIndex = 2;
            this.balanceLabel.Text = "Balance:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(20, 53);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(20, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // messageTab
            // 
            this.messageTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.messageTab.BackgroundImage = global::AgileProd.Properties.Resources.cashenvelope_op15;
            this.messageTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.messageTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.messageTab.Controls.Add(this.readBtn);
            this.messageTab.Controls.Add(this.btnAllMsg);
            this.messageTab.Controls.Add(this.readButton);
            this.messageTab.Controls.Add(this.fromLabel);
            this.messageTab.Controls.Add(this.fromList);
            this.messageTab.Location = new System.Drawing.Point(4, 22);
            this.messageTab.Name = "messageTab";
            this.messageTab.Size = new System.Drawing.Size(672, 284);
            this.messageTab.TabIndex = 4;
            this.messageTab.Text = "Messages";
            // 
            // readBtn
            // 
            this.readBtn.Location = new System.Drawing.Point(248, 54);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(121, 23);
            this.readBtn.TabIndex = 6;
            this.readBtn.Text = "Read Next Message";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // btnAllMsg
            // 
            this.btnAllMsg.Location = new System.Drawing.Point(248, 83);
            this.btnAllMsg.Name = "btnAllMsg";
            this.btnAllMsg.Size = new System.Drawing.Size(121, 23);
            this.btnAllMsg.TabIndex = 5;
            this.btnAllMsg.Text = "Show All Messages";
            this.btnAllMsg.UseVisualStyleBackColor = true;
            this.btnAllMsg.Click += new System.EventHandler(this.btnAllMsg_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(248, 25);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 23);
            this.readButton.TabIndex = 2;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fromLabel.Location = new System.Drawing.Point(6, 6);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(47, 16);
            this.fromLabel.TabIndex = 1;
            this.fromLabel.Text = "From:";
            // 
            // fromList
            // 
            this.fromList.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.fromList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.idHeader});
            this.fromList.GridLines = true;
            this.fromList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.fromList.Location = new System.Drawing.Point(6, 25);
            this.fromList.Name = "fromList";
            this.fromList.Size = new System.Drawing.Size(236, 254);
            this.fromList.TabIndex = 0;
            this.fromList.UseCompatibleStateImageBehavior = false;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            // 
            // idHeader
            // 
            this.idHeader.Text = "ID";
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.settingsTab.BackgroundImage = global::AgileProd.Properties.Resources.wrench_op10;
            this.settingsTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settingsTab.Controls.Add(this.logoutButton);
            this.settingsTab.Controls.Add(this.saveButton);
            this.settingsTab.Controls.Add(this.settingsPasswordBox);
            this.settingsTab.Controls.Add(this.settingsUserNameBox);
            this.settingsTab.Controls.Add(this.settingsIdBox);
            this.settingsTab.Controls.Add(this.settingsNameBox);
            this.settingsTab.Controls.Add(this.settingsPasswordLabel);
            this.settingsTab.Controls.Add(this.settingsUserNameLabel);
            this.settingsTab.Controls.Add(this.settingsIdLabel);
            this.settingsTab.Controls.Add(this.settingNameLabel);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(672, 284);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Settings";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(587, 251);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 10;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(70, 124);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // settingsPasswordBox
            // 
            this.settingsPasswordBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.settingsPasswordBox.Location = new System.Drawing.Point(70, 98);
            this.settingsPasswordBox.Name = "settingsPasswordBox";
            this.settingsPasswordBox.Size = new System.Drawing.Size(100, 20);
            this.settingsPasswordBox.TabIndex = 8;
            // 
            // settingsUserNameBox
            // 
            this.settingsUserNameBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.settingsUserNameBox.Location = new System.Drawing.Point(70, 72);
            this.settingsUserNameBox.Name = "settingsUserNameBox";
            this.settingsUserNameBox.Size = new System.Drawing.Size(100, 20);
            this.settingsUserNameBox.TabIndex = 7;
            // 
            // settingsIdBox
            // 
            this.settingsIdBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.settingsIdBox.Location = new System.Drawing.Point(70, 46);
            this.settingsIdBox.Name = "settingsIdBox";
            this.settingsIdBox.ReadOnly = true;
            this.settingsIdBox.Size = new System.Drawing.Size(100, 20);
            this.settingsIdBox.TabIndex = 6;
            this.settingsIdBox.TextChanged += new System.EventHandler(this.settingsIdBox_TextChanged);
            // 
            // settingsNameBox
            // 
            this.settingsNameBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.settingsNameBox.Location = new System.Drawing.Point(70, 20);
            this.settingsNameBox.Name = "settingsNameBox";
            this.settingsNameBox.Size = new System.Drawing.Size(100, 20);
            this.settingsNameBox.TabIndex = 5;
            this.settingsNameBox.TextChanged += new System.EventHandler(this.settingsNameBox_TextChanged);
            // 
            // settingsPasswordLabel
            // 
            this.settingsPasswordLabel.AutoSize = true;
            this.settingsPasswordLabel.Location = new System.Drawing.Point(6, 101);
            this.settingsPasswordLabel.Name = "settingsPasswordLabel";
            this.settingsPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.settingsPasswordLabel.TabIndex = 3;
            this.settingsPasswordLabel.Text = "Password:";
            // 
            // settingsUserNameLabel
            // 
            this.settingsUserNameLabel.AutoSize = true;
            this.settingsUserNameLabel.Location = new System.Drawing.Point(6, 75);
            this.settingsUserNameLabel.Name = "settingsUserNameLabel";
            this.settingsUserNameLabel.Size = new System.Drawing.Size(61, 13);
            this.settingsUserNameLabel.TabIndex = 2;
            this.settingsUserNameLabel.Text = "User name:";
            // 
            // settingsIdLabel
            // 
            this.settingsIdLabel.AutoSize = true;
            this.settingsIdLabel.Location = new System.Drawing.Point(6, 49);
            this.settingsIdLabel.Name = "settingsIdLabel";
            this.settingsIdLabel.Size = new System.Drawing.Size(21, 13);
            this.settingsIdLabel.TabIndex = 1;
            this.settingsIdLabel.Text = "ID:";
            // 
            // settingNameLabel
            // 
            this.settingNameLabel.AutoSize = true;
            this.settingNameLabel.Location = new System.Drawing.Point(6, 23);
            this.settingNameLabel.Name = "settingNameLabel";
            this.settingNameLabel.Size = new System.Drawing.Size(38, 13);
            this.settingNameLabel.TabIndex = 0;
            this.settingNameLabel.Text = "Name:";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 312);
            this.Controls.Add(this.tabMenu);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.tabMenu.ResumeLayout(false);
            this.blankTab.ResumeLayout(false);
            this.blankTab.PerformLayout();
            this.bankTab.ResumeLayout(false);
            this.bankTab.PerformLayout();
            this.messageTab.ResumeLayout(false);
            this.messageTab.PerformLayout();
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TabControl tabMenu;
        protected System.Windows.Forms.TabPage blankTab;
        protected System.Windows.Forms.TabPage settingsTab;
        protected System.Windows.Forms.TabPage bankTab;
        protected System.Windows.Forms.TabPage messageTab;
        private System.Windows.Forms.ListView fromList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lastTransactionsLabel;
        private System.Windows.Forms.TextBox balanceBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader idHeader;
        private System.Windows.Forms.TextBox settingsPasswordBox;
        private System.Windows.Forms.TextBox settingsUserNameBox;
        private System.Windows.Forms.TextBox settingsIdBox;
        private System.Windows.Forms.TextBox settingsNameBox;
        private System.Windows.Forms.Label settingsPasswordLabel;
        private System.Windows.Forms.Label settingsUserNameLabel;
        private System.Windows.Forms.Label settingsIdLabel;
        private System.Windows.Forms.Label settingNameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button btnAllMsg;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.TextBox username;

    }
}