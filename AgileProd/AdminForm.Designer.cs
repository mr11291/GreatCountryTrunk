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
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDelParty = new System.Windows.Forms.TextBox();
            this.btnDelParty = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnWithdrwl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWthdrwl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmntdrwl = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.ViewPeopleList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPeople)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ViewPeopleList);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(885, 261);
            this.tabControl1.TabIndex = 0;
            // 
            // ViewPeopleList
            // 
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
            this.ViewPeopleList.Size = new System.Drawing.Size(877, 235);
            this.ViewPeopleList.TabIndex = 0;
            this.ViewPeopleList.Text = "Person";
            this.ViewPeopleList.UseVisualStyleBackColor = true;
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
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txtDelParty);
            this.tabPage3.Controls.Add(this.btnDelParty);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(877, 235);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Committee Member";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.tabPage4.Size = new System.Drawing.Size(877, 235);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Admin";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID:";
            // 
            // txtWthdrwl
            // 
            this.txtWthdrwl.Location = new System.Drawing.Point(140, 122);
            this.txtWthdrwl.Multiline = true;
            this.txtWthdrwl.Name = "txtWthdrwl";
            this.txtWthdrwl.Size = new System.Drawing.Size(100, 23);
            this.txtWthdrwl.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Amount:";
            // 
            // txtAmntdrwl
            // 
            this.txtAmntdrwl.Location = new System.Drawing.Point(155, 151);
            this.txtAmntdrwl.Multiline = true;
            this.txtAmntdrwl.Name = "txtAmntdrwl";
            this.txtAmntdrwl.Size = new System.Drawing.Size(85, 23);
            this.txtAmntdrwl.TabIndex = 13;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 262);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.tabControl1.ResumeLayout(false);
            this.ViewPeopleList.ResumeLayout(false);
            this.ViewPeopleList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPeople)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ViewPeopleList;
        private System.Windows.Forms.Button DeletePerson;
        private System.Windows.Forms.Button AddPerson;
        private System.Windows.Forms.Button RevokeVoter;
        private System.Windows.Forms.Button RegisterVoter;
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

    }
}