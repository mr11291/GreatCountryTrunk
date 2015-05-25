namespace AgileProd
{
    partial class CommitteeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommitteeForm));
            this.voteToMemberButton = new System.Windows.Forms.Button();
            this.ListOf = new System.Windows.Forms.ListView();
            this.ListOf2 = new System.Windows.Forms.ListView();
            this.partyListLabel = new System.Windows.Forms.Label();
            this.memberListLabel = new System.Windows.Forms.Label();
            this.addPartyButton = new System.Windows.Forms.Button();
            this.paryLeaderIdTextBox = new System.Windows.Forms.TextBox();
            this.partyLeaderIdLabel = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.partyNameLabel = new System.Windows.Forms.Label();
            this.partyNameTextBox = new System.Windows.Forms.TextBox();
            this.EnterButton2 = new System.Windows.Forms.Button();
            this.finishPraimeriesButton = new System.Windows.Forms.Button();
            this.deletePartyButton = new System.Windows.Forms.Button();
            this.endElectionsButton = new System.Windows.Forms.Button();
            this.voteToPartyButton = new System.Windows.Forms.Button();
            this.lvotetoparty2 = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabMenu.SuspendLayout();
            this.blankTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.ImageList = this.imageList1;
            // 
            // blankTab
            // 
            this.blankTab.Controls.Add(this.lvotetoparty2);
            this.blankTab.Controls.Add(this.voteToPartyButton);
            this.blankTab.Controls.Add(this.endElectionsButton);
            this.blankTab.Controls.Add(this.deletePartyButton);
            this.blankTab.Controls.Add(this.finishPraimeriesButton);
            this.blankTab.Controls.Add(this.EnterButton2);
            this.blankTab.Controls.Add(this.partyNameTextBox);
            this.blankTab.Controls.Add(this.partyNameLabel);
            this.blankTab.Controls.Add(this.EnterButton);
            this.blankTab.Controls.Add(this.partyLeaderIdLabel);
            this.blankTab.Controls.Add(this.paryLeaderIdTextBox);
            this.blankTab.Controls.Add(this.addPartyButton);
            this.blankTab.Controls.Add(this.memberListLabel);
            this.blankTab.Controls.Add(this.partyListLabel);
            this.blankTab.Controls.Add(this.ListOf2);
            this.blankTab.Controls.Add(this.ListOf);
            this.blankTab.Controls.Add(this.voteToMemberButton);
            this.blankTab.Text = "Committee";
            // 
            // voteToMemberButton
            // 
            this.voteToMemberButton.Location = new System.Drawing.Point(5, 5);
            this.voteToMemberButton.Name = "voteToMemberButton";
            this.voteToMemberButton.Size = new System.Drawing.Size(95, 25);
            this.voteToMemberButton.TabIndex = 0;
            this.voteToMemberButton.Text = "Vote to member";
            this.voteToMemberButton.UseVisualStyleBackColor = true;
            this.voteToMemberButton.Click += new System.EventHandler(this.VoteButton_Click);
            // 
            // ListOf
            // 
            this.ListOf.Location = new System.Drawing.Point(113, 25);
            this.ListOf.Name = "ListOf";
            this.ListOf.Size = new System.Drawing.Size(141, 216);
            this.ListOf.TabIndex = 1;
            this.ListOf.UseCompatibleStateImageBehavior = false;
            this.ListOf.View = System.Windows.Forms.View.List;
            this.ListOf.SelectedIndexChanged += new System.EventHandler(this.ListOf_SelectedIndexChanged);
            // 
            // ListOf2
            // 
            this.ListOf2.Location = new System.Drawing.Point(270, 25);
            this.ListOf2.Name = "ListOf2";
            this.ListOf2.Size = new System.Drawing.Size(142, 216);
            this.ListOf2.TabIndex = 2;
            this.ListOf2.UseCompatibleStateImageBehavior = false;
            this.ListOf2.View = System.Windows.Forms.View.List;
            this.ListOf2.SelectedIndexChanged += new System.EventHandler(this.ListOf2_SelectedIndexChanged);
            // 
            // partyListLabel
            // 
            this.partyListLabel.AutoSize = true;
            this.partyListLabel.Location = new System.Drawing.Point(110, 9);
            this.partyListLabel.Name = "partyListLabel";
            this.partyListLabel.Size = new System.Drawing.Size(53, 13);
            this.partyListLabel.TabIndex = 3;
            this.partyListLabel.Text = "Party List:";
            // 
            // memberListLabel
            // 
            this.memberListLabel.AutoSize = true;
            this.memberListLabel.Location = new System.Drawing.Point(267, 9);
            this.memberListLabel.Name = "memberListLabel";
            this.memberListLabel.Size = new System.Drawing.Size(67, 13);
            this.memberListLabel.TabIndex = 4;
            this.memberListLabel.Text = "Member List:";
            // 
            // addPartyButton
            // 
            this.addPartyButton.Location = new System.Drawing.Point(5, 65);
            this.addPartyButton.Name = "addPartyButton";
            this.addPartyButton.Size = new System.Drawing.Size(95, 25);
            this.addPartyButton.TabIndex = 5;
            this.addPartyButton.Text = "Add Party";
            this.addPartyButton.UseVisualStyleBackColor = true;
            this.addPartyButton.Click += new System.EventHandler(this.AddPartyButton_Click);
            // 
            // paryLeaderIdTextBox
            // 
            this.paryLeaderIdTextBox.Location = new System.Drawing.Point(119, 185);
            this.paryLeaderIdTextBox.Name = "paryLeaderIdTextBox";
            this.paryLeaderIdTextBox.Size = new System.Drawing.Size(142, 20);
            this.paryLeaderIdTextBox.TabIndex = 6;
            this.paryLeaderIdTextBox.TextChanged += new System.EventHandler(this.TextName_TextChanged);
            // 
            // partyLeaderIdLabel
            // 
            this.partyLeaderIdLabel.AutoSize = true;
            this.partyLeaderIdLabel.Location = new System.Drawing.Point(6, 188);
            this.partyLeaderIdLabel.Name = "partyLeaderIdLabel";
            this.partyLeaderIdLabel.Size = new System.Drawing.Size(107, 13);
            this.partyLeaderIdLabel.TabIndex = 7;
            this.partyLeaderIdLabel.Text = "New Party Leader Id:";
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(267, 185);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(76, 20);
            this.EnterButton.TabIndex = 8;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterB_Click_1);
            // 
            // partyNameLabel
            // 
            this.partyNameLabel.AutoSize = true;
            this.partyNameLabel.Location = new System.Drawing.Point(6, 213);
            this.partyNameLabel.Name = "partyNameLabel";
            this.partyNameLabel.Size = new System.Drawing.Size(90, 13);
            this.partyNameLabel.TabIndex = 9;
            this.partyNameLabel.Text = "New Party Name:";
            // 
            // partyNameTextBox
            // 
            this.partyNameTextBox.Location = new System.Drawing.Point(119, 210);
            this.partyNameTextBox.Name = "partyNameTextBox";
            this.partyNameTextBox.Size = new System.Drawing.Size(142, 20);
            this.partyNameTextBox.TabIndex = 10;
            // 
            // EnterButton2
            // 
            this.EnterButton2.Location = new System.Drawing.Point(267, 211);
            this.EnterButton2.Name = "EnterButton2";
            this.EnterButton2.Size = new System.Drawing.Size(75, 21);
            this.EnterButton2.TabIndex = 11;
            this.EnterButton2.Text = "Enter";
            this.EnterButton2.UseVisualStyleBackColor = true;
            this.EnterButton2.Click += new System.EventHandler(this.EnterB2_Click_1);
            // 
            // finishPraimeriesButton
            // 
            this.finishPraimeriesButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.finishPraimeriesButton.Location = new System.Drawing.Point(5, 95);
            this.finishPraimeriesButton.Name = "finishPraimeriesButton";
            this.finishPraimeriesButton.Size = new System.Drawing.Size(95, 25);
            this.finishPraimeriesButton.TabIndex = 12;
            this.finishPraimeriesButton.Text = "Finish Primeries";
            this.finishPraimeriesButton.UseVisualStyleBackColor = true;
            this.finishPraimeriesButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deletePartyButton
            // 
            this.deletePartyButton.ForeColor = System.Drawing.Color.Red;
            this.deletePartyButton.Location = new System.Drawing.Point(5, 125);
            this.deletePartyButton.Name = "deletePartyButton";
            this.deletePartyButton.Size = new System.Drawing.Size(95, 25);
            this.deletePartyButton.TabIndex = 13;
            this.deletePartyButton.Text = "Delete Party";
            this.deletePartyButton.UseVisualStyleBackColor = true;
            this.deletePartyButton.Click += new System.EventHandler(this.Delete_Party_Click);
            // 
            // endElectionsButton
            // 
            this.endElectionsButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.endElectionsButton.Location = new System.Drawing.Point(5, 155);
            this.endElectionsButton.Name = "endElectionsButton";
            this.endElectionsButton.Size = new System.Drawing.Size(95, 25);
            this.endElectionsButton.TabIndex = 14;
            this.endElectionsButton.Text = "End Elections";
            this.endElectionsButton.UseVisualStyleBackColor = true;
            this.endElectionsButton.Click += new System.EventHandler(this.End_Election_Click);
            // 
            // voteToPartyButton
            // 
            this.voteToPartyButton.Location = new System.Drawing.Point(5, 35);
            this.voteToPartyButton.Name = "voteToPartyButton";
            this.voteToPartyButton.Size = new System.Drawing.Size(95, 25);
            this.voteToPartyButton.TabIndex = 15;
            this.voteToPartyButton.Text = "Vote to party";
            this.voteToPartyButton.UseVisualStyleBackColor = true;
            this.voteToPartyButton.Click += new System.EventHandler(this.VoteToParty_Click);
            // 
            // lvotetoparty2
            // 
            this.lvotetoparty2.Location = new System.Drawing.Point(521, 23);
            this.lvotetoparty2.Name = "lvotetoparty2";
            this.lvotetoparty2.Size = new System.Drawing.Size(141, 218);
            this.lvotetoparty2.TabIndex = 16;
            this.lvotetoparty2.UseCompatibleStateImageBehavior = false;
            this.lvotetoparty2.View = System.Windows.Forms.View.List;
            this.lvotetoparty2.SelectedIndexChanged += new System.EventHandler(this.lvotetoparty2_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "RedDot.png");
            // 
            // CommitteeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 312);
            this.Name = "CommitteeForm";
            this.Text = "CommitteeForm";
            this.tabMenu.ResumeLayout(false);
            this.blankTab.ResumeLayout(false);
            this.blankTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button voteToMemberButton;
        private System.Windows.Forms.ListView ListOf;
        private System.Windows.Forms.ListView ListOf2;
        private System.Windows.Forms.Label memberListLabel;
        private System.Windows.Forms.Label partyListLabel;
        private System.Windows.Forms.Button addPartyButton;
        private System.Windows.Forms.Label partyLeaderIdLabel;
        private System.Windows.Forms.TextBox paryLeaderIdTextBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.TextBox partyNameTextBox;
        private System.Windows.Forms.Label partyNameLabel;
        private System.Windows.Forms.Button EnterButton2;
        private System.Windows.Forms.Button finishPraimeriesButton;
        private System.Windows.Forms.Button deletePartyButton;
        private System.Windows.Forms.Button endElectionsButton;
        private System.Windows.Forms.Button voteToPartyButton;
        private System.Windows.Forms.ListView lvotetoparty2;
        
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
    }
}