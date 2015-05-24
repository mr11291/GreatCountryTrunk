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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonForm));
            this.voteButton = new System.Windows.Forms.Button();
            this.partyListLabel = new System.Windows.Forms.Label();
            this.MemberListLabel = new System.Windows.Forms.Label();
            this.ListOf2 = new System.Windows.Forms.ListView();
            this.ListOf = new System.Windows.Forms.ListView();
            this.InfoParty = new System.Windows.Forms.Button();
            this.partyNameComboBox = new System.Windows.Forms.ComboBox();
            this.InfoAboutParty = new System.Windows.Forms.ListView();
            this.VoteParty = new System.Windows.Forms.Button();
            this.retrunToPartyButton = new System.Windows.Forms.Button();
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
            this.blankTab.Controls.Add(this.retrunToPartyButton);
            this.blankTab.Controls.Add(this.VoteParty);
            this.blankTab.Controls.Add(this.InfoAboutParty);
            this.blankTab.Controls.Add(this.partyNameComboBox);
            this.blankTab.Controls.Add(this.InfoParty);
            this.blankTab.Controls.Add(this.ListOf2);
            this.blankTab.Controls.Add(this.ListOf);
            this.blankTab.Controls.Add(this.MemberListLabel);
            this.blankTab.Controls.Add(this.partyListLabel);
            this.blankTab.Controls.Add(this.voteButton);
            this.blankTab.Text = "Person";
            // 
            // voteButton
            // 
            this.voteButton.Location = new System.Drawing.Point(6, 74);
            this.voteButton.Name = "voteButton";
            this.voteButton.Size = new System.Drawing.Size(90, 23);
            this.voteButton.TabIndex = 0;
            this.voteButton.Text = "Vote to member";
            this.voteButton.UseVisualStyleBackColor = true;
            this.voteButton.Click += new System.EventHandler(this.voteButton_Click);
            // 
            // partyListLabel
            // 
            this.partyListLabel.AutoSize = true;
            this.partyListLabel.Location = new System.Drawing.Point(332, 21);
            this.partyListLabel.Name = "partyListLabel";
            this.partyListLabel.Size = new System.Drawing.Size(53, 13);
            this.partyListLabel.TabIndex = 18;
            this.partyListLabel.Text = "Party List:";
            // 
            // MemberListLabel
            // 
            this.MemberListLabel.AutoSize = true;
            this.MemberListLabel.Location = new System.Drawing.Point(504, 21);
            this.MemberListLabel.Name = "MemberListLabel";
            this.MemberListLabel.Size = new System.Drawing.Size(67, 13);
            this.MemberListLabel.TabIndex = 19;
            this.MemberListLabel.Text = "Member List:";
            // 
            // ListOf2
            // 
            this.ListOf2.Location = new System.Drawing.Point(507, 43);
            this.ListOf2.Name = "ListOf2";
            this.ListOf2.Size = new System.Drawing.Size(142, 204);
            this.ListOf2.TabIndex = 21;
            this.ListOf2.UseCompatibleStateImageBehavior = false;
            this.ListOf2.View = System.Windows.Forms.View.List;
            this.ListOf2.SelectedIndexChanged += new System.EventHandler(this.ListOf2_SelectedIndexChanged);
            // 
            // ListOf
            // 
            this.ListOf.Location = new System.Drawing.Point(335, 43);
            this.ListOf.Name = "ListOf";
            this.ListOf.Size = new System.Drawing.Size(141, 204);
            this.ListOf.TabIndex = 20;
            this.ListOf.UseCompatibleStateImageBehavior = false;
            this.ListOf.View = System.Windows.Forms.View.List;
            this.ListOf.SelectedIndexChanged += new System.EventHandler(this.ListOf_SelectedIndexChanged_1);
            // 
            // InfoParty
            // 
            this.InfoParty.Location = new System.Drawing.Point(6, 16);
            this.InfoParty.Name = "InfoParty";
            this.InfoParty.Size = new System.Drawing.Size(90, 23);
            this.InfoParty.TabIndex = 22;
            this.InfoParty.Text = "Info about Party";
            this.InfoParty.UseVisualStyleBackColor = true;
            this.InfoParty.Click += new System.EventHandler(this.InfoParty_Click);
            // 
            // partyNameComboBox
            // 
            this.partyNameComboBox.FormattingEnabled = true;
            this.partyNameComboBox.Items.AddRange(new object[] {
            "select..."});
            this.partyNameComboBox.Location = new System.Drawing.Point(167, 16);
            this.partyNameComboBox.Name = "partyNameComboBox";
            this.partyNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.partyNameComboBox.TabIndex = 23;
            this.partyNameComboBox.SelectedIndexChanged += new System.EventHandler(this.partyNameComboBox_SelectedIndexChanged);
            // 
            // InfoAboutParty
            // 
            this.InfoAboutParty.Location = new System.Drawing.Point(167, 43);
            this.InfoAboutParty.Name = "InfoAboutParty";
            this.InfoAboutParty.Size = new System.Drawing.Size(136, 204);
            this.InfoAboutParty.TabIndex = 24;
            this.InfoAboutParty.UseCompatibleStateImageBehavior = false;
            this.InfoAboutParty.View = System.Windows.Forms.View.List;
            // 
            // VoteParty
            // 
            this.VoteParty.Location = new System.Drawing.Point(6, 45);
            this.VoteParty.Name = "VoteParty";
            this.VoteParty.Size = new System.Drawing.Size(90, 23);
            this.VoteParty.TabIndex = 25;
            this.VoteParty.Text = "Vote to party";
            this.VoteParty.UseVisualStyleBackColor = true;
            this.VoteParty.Click += new System.EventHandler(this.VoteParty_Click);
            // 
            // retrunToPartyButton
            // 
            this.retrunToPartyButton.Location = new System.Drawing.Point(6, 103);
            this.retrunToPartyButton.Name = "retrunToPartyButton";
            this.retrunToPartyButton.Size = new System.Drawing.Size(97, 23);
            this.retrunToPartyButton.TabIndex = 27;
            this.retrunToPartyButton.Text = "Return to a party";
            this.retrunToPartyButton.UseVisualStyleBackColor = true;
            this.retrunToPartyButton.Visible = false;
            this.retrunToPartyButton.Click += new System.EventHandler(this.BtnBckLastPrty_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "RedDot.png");
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 312);
            this.Name = "PersonForm";
            this.Text = "PersonForm";
            this.tabMenu.ResumeLayout(false);
            this.blankTab.ResumeLayout(false);
            this.blankTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button voteButton;
        private System.Windows.Forms.Label partyListLabel;
        private System.Windows.Forms.Label MemberListLabel;
        private System.Windows.Forms.ListView ListOf2;
        private System.Windows.Forms.ListView ListOf;
        private System.Windows.Forms.Button InfoParty;
        private System.Windows.Forms.ComboBox partyNameComboBox;
        private System.Windows.Forms.ListView InfoAboutParty;
        private System.Windows.Forms.Button VoteParty;
        private System.Windows.Forms.Button retrunToPartyButton;
        private System.Windows.Forms.ImageList imageList1;
    }
}