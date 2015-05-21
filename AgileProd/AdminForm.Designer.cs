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
            this.label6 = new System.Windows.Forms.Label();
            this.txtPartyNameForPerson = new System.Windows.Forms.TextBox();
            this.btnPersonToParty = new System.Windows.Forms.Button();
            this.txtAmntdrwl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWthdrwl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnWithdrwl = new System.Windows.Forms.Button();
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
            this.partychange = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cngprty = new System.Windows.Forms.Button();
            this.txtIDForMember = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridMember = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMemberList = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnChangePStatus = new System.Windows.Forms.Button();
            this.btnPraimeriesStatus = new System.Windows.Forms.Button();
            this.dataGridParty = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDelParty = new System.Windows.Forms.TextBox();
            this.btnDelParty = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.MessageTab = new System.Windows.Forms.TabPage();
            this.ReadButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MessageList = new System.Windows.Forms.ListBox();
            this.tabMenu.SuspendLayout();
            this.ViewPeopleList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPeople)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMember)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParty)).BeginInit();
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
            this.tabMenu.Size = new System.Drawing.Size(885, 385);
            this.tabMenu.TabIndex = 0;
            // 
            // ViewPeopleList
            // 
            this.ViewPeopleList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ViewPeopleList.Controls.Add(this.label6);
            this.ViewPeopleList.Controls.Add(this.txtPartyNameForPerson);
            this.ViewPeopleList.Controls.Add(this.btnPersonToParty);
            this.ViewPeopleList.Controls.Add(this.txtAmntdrwl);
            this.ViewPeopleList.Controls.Add(this.label3);
            this.ViewPeopleList.Controls.Add(this.txtWthdrwl);
            this.ViewPeopleList.Controls.Add(this.label2);
            this.ViewPeopleList.Controls.Add(this.btnWithdrwl);
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
            this.ViewPeopleList.Size = new System.Drawing.Size(877, 359);
            this.ViewPeopleList.TabIndex = 0;
            this.ViewPeopleList.Text = "Person";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Party name:";
            // 
            // txtPartyNameForPerson
            // 
            this.txtPartyNameForPerson.Location = new System.Drawing.Point(206, 194);
            this.txtPartyNameForPerson.Multiline = true;
            this.txtPartyNameForPerson.Name = "txtPartyNameForPerson";
            this.txtPartyNameForPerson.Size = new System.Drawing.Size(70, 23);
            this.txtPartyNameForPerson.TabIndex = 15;
            // 
            // btnPersonToParty
            // 
            this.btnPersonToParty.Location = new System.Drawing.Point(8, 192);
            this.btnPersonToParty.Name = "btnPersonToParty";
            this.btnPersonToParty.Size = new System.Drawing.Size(115, 23);
            this.btnPersonToParty.TabIndex = 14;
            this.btnPersonToParty.Text = "Add Person ToParty";
            this.btnPersonToParty.UseVisualStyleBackColor = true;
            // 
            // txtAmntdrwl
            // 
            this.txtAmntdrwl.Location = new System.Drawing.Point(166, 151);
            this.txtAmntdrwl.Multiline = true;
            this.txtAmntdrwl.Name = "txtAmntdrwl";
            this.txtAmntdrwl.Size = new System.Drawing.Size(85, 23);
            this.txtAmntdrwl.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Amount:";
            // 
            // txtWthdrwl
            // 
            this.txtWthdrwl.Location = new System.Drawing.Point(152, 122);
            this.txtWthdrwl.Multiline = true;
            this.txtWthdrwl.Name = "txtWthdrwl";
            this.txtWthdrwl.Size = new System.Drawing.Size(100, 23);
            this.txtWthdrwl.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID:";
            // 
            // btnWithdrwl
            // 
            this.btnWithdrwl.Location = new System.Drawing.Point(8, 122);
            this.btnWithdrwl.Name = "btnWithdrwl";
            this.btnWithdrwl.Size = new System.Drawing.Size(102, 23);
            this.btnWithdrwl.TabIndex = 9;
            this.btnWithdrwl.Text = "withdrawal";
            this.btnWithdrwl.UseVisualStyleBackColor = true;
            this.btnWithdrwl.Click += new System.EventHandler(this.btnWithdrwl_Click);
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
            this.dataGridPeople.Location = new System.Drawing.Point(280, 5);
            this.dataGridPeople.Name = "dataGridPeople";
            this.dataGridPeople.Size = new System.Drawing.Size(586, 346);
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
            this.tabPage2.Controls.Add(this.partychange);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.cngprty);
            this.tabPage2.Controls.Add(this.txtIDForMember);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dataGridMember);
            this.tabPage2.Controls.Add(this.btnMemberList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(877, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Party Member";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // partychange
            // 
            this.partychange.Location = new System.Drawing.Point(172, 57);
            this.partychange.Multiline = true;
            this.partychange.Name = "partychange";
            this.partychange.Size = new System.Drawing.Size(100, 23);
            this.partychange.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Party:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "back to previous party";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cngprty
            // 
            this.cngprty.Location = new System.Drawing.Point(18, 50);
            this.cngprty.Name = "cngprty";
            this.cngprty.Size = new System.Drawing.Size(93, 23);
            this.cngprty.TabIndex = 12;
            this.cngprty.Text = "change party";
            this.cngprty.UseVisualStyleBackColor = true;
           // this.cngprty.Click += new System.EventHandler(this.cngprty_Click);
            // 
            // txtIDForMember
            // 
            this.txtIDForMember.Location = new System.Drawing.Point(53, 15);
            this.txtIDForMember.Multiline = true;
            this.txtIDForMember.Name = "txtIDForMember";
            this.txtIDForMember.Size = new System.Drawing.Size(100, 23);
            this.txtIDForMember.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID:";
            // 
            // dataGridMember
            // 
            this.dataGridMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Location,
            this.PartyName});
            this.dataGridMember.Location = new System.Drawing.Point(320, 5);
            this.dataGridMember.Name = "dataGridMember";
            this.dataGridMember.Size = new System.Drawing.Size(483, 222);
            this.dataGridMember.TabIndex = 9;
            this.dataGridMember.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Age";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            // 
            // PartyName
            // 
            this.PartyName.HeaderText = "PartyName";
            this.PartyName.Name = "PartyName";
            // 
            // btnMemberList
            // 
            this.btnMemberList.Location = new System.Drawing.Point(156, 125);
            this.btnMemberList.Name = "btnMemberList";
            this.btnMemberList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMemberList.Size = new System.Drawing.Size(102, 23);
            this.btnMemberList.TabIndex = 2;
            this.btnMemberList.Text = "Members List";
            this.btnMemberList.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnChangePStatus);
            this.tabPage3.Controls.Add(this.btnPraimeriesStatus);
            this.tabPage3.Controls.Add(this.dataGridParty);
            this.tabPage3.Controls.Add(this.btnListP);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txtDelParty);
            this.tabPage3.Controls.Add(this.btnDelParty);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(877, 359);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Committee Member";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnChangePStatus
            // 
            this.btnChangePStatus.Location = new System.Drawing.Point(8, 114);
            this.btnChangePStatus.Name = "btnChangePStatus";
            this.btnChangePStatus.Size = new System.Drawing.Size(148, 23);
            this.btnChangePStatus.TabIndex = 12;
            this.btnChangePStatus.Text = "Change Praimeries Status";
            this.btnChangePStatus.UseVisualStyleBackColor = true;
            // 
            // btnPraimeriesStatus
            // 
            this.btnPraimeriesStatus.Location = new System.Drawing.Point(8, 76);
            this.btnPraimeriesStatus.Name = "btnPraimeriesStatus";
            this.btnPraimeriesStatus.Size = new System.Drawing.Size(103, 23);
            this.btnPraimeriesStatus.TabIndex = 11;
            this.btnPraimeriesStatus.Text = "Praimeries Status";
            this.btnPraimeriesStatus.UseVisualStyleBackColor = true;
            // 
            // dataGridParty
            // 
            this.dataGridParty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dataGridParty.Location = new System.Drawing.Point(334, 6);
            this.dataGridParty.Name = "dataGridParty";
            this.dataGridParty.Size = new System.Drawing.Size(145, 222);
            this.dataGridParty.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // btnListP
            // 
            this.btnListP.Location = new System.Drawing.Point(162, 89);
            this.btnListP.Name = "btnListP";
            this.btnListP.Size = new System.Drawing.Size(103, 23);
            this.btnListP.TabIndex = 3;
            this.btnListP.Text = "List Of Parties";
            this.btnListP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Party name:";
            // 
            // txtDelParty
            // 
            this.txtDelParty.Location = new System.Drawing.Point(162, 39);
            this.txtDelParty.Name = "txtDelParty";
            this.txtDelParty.Size = new System.Drawing.Size(121, 20);
            this.txtDelParty.TabIndex = 1;
            // 
            // btnDelParty
            // 
            this.btnDelParty.Location = new System.Drawing.Point(8, 36);
            this.btnDelParty.Name = "btnDelParty";
            this.btnDelParty.Size = new System.Drawing.Size(75, 23);
            this.btnDelParty.TabIndex = 0;
            this.btnDelParty.Text = "Delete party";
            this.btnDelParty.UseVisualStyleBackColor = true;
            this.btnDelParty.Click += new System.EventHandler(this.btnDelParty_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(877, 359);
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
            this.MessageTab.Size = new System.Drawing.Size(877, 359);
            this.MessageTab.TabIndex = 4;
            this.MessageTab.Text = "Messages";
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(507, 6);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(75, 23);
            this.ReadButton.TabIndex = 2;
            this.ReadButton.Text = "Read";
            this.ReadButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(507, 35);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // MessageList
            // 
            this.MessageList.FormattingEnabled = true;
            this.MessageList.Location = new System.Drawing.Point(3, 6);
            this.MessageList.Name = "MessageList";
            this.MessageList.Size = new System.Drawing.Size(498, 225);
            this.MessageList.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 387);
            this.Controls.Add(this.tabMenu);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.tabMenu.ResumeLayout(false);
            this.ViewPeopleList.ResumeLayout(false);
            this.ViewPeopleList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPeople)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMember)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParty)).EndInit();
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDelParty;
        private System.Windows.Forms.Button btnDelParty;
        private System.Windows.Forms.TextBox txtWthdrwl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnWithdrwl;
        private System.Windows.Forms.TextBox txtAmntdrwl;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.ListBox MessageList;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button btnListP;
        private System.Windows.Forms.DataGridView dataGridParty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnPraimeriesStatus;
        private System.Windows.Forms.Button btnChangePStatus;
        private System.Windows.Forms.TextBox txtIDForMember;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyName;
        private System.Windows.Forms.Button btnMemberList;
        private System.Windows.Forms.Button btnPersonToParty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPartyNameForPerson;
        private System.Windows.Forms.TextBox partychange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cngprty;
    }
}