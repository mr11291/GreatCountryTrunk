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
            this.VoteButton = new System.Windows.Forms.Button();
            this.ListOf = new System.Windows.Forms.ListView();
            this.ListOf2 = new System.Windows.Forms.ListView();
            this.CommitteListLabel = new System.Windows.Forms.Label();
            this.MemberListLabel = new System.Windows.Forms.Label();
            this.AddPartyButton = new System.Windows.Forms.Button();
            this.TextName = new System.Windows.Forms.TextBox();
            this.Name1 = new System.Windows.Forms.Label();
            this.EnterB = new System.Windows.Forms.Button();
            this.Partynamelabel = new System.Windows.Forms.Label();
            this.TextParty = new System.Windows.Forms.TextBox();
            this.EnterB2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Delete_Party = new System.Windows.Forms.Button();
            this.End_Election = new System.Windows.Forms.Button();
            this.tabMenu.SuspendLayout();
            this.blankTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // blankTab
            // 
            this.blankTab.Controls.Add(this.End_Election);
            this.blankTab.Controls.Add(this.Delete_Party);
            this.blankTab.Controls.Add(this.button1);
            this.blankTab.Controls.Add(this.EnterB2);
            this.blankTab.Controls.Add(this.TextParty);
            this.blankTab.Controls.Add(this.Partynamelabel);
            this.blankTab.Controls.Add(this.EnterB);
            this.blankTab.Controls.Add(this.Name1);
            this.blankTab.Controls.Add(this.TextName);
            this.blankTab.Controls.Add(this.AddPartyButton);
            this.blankTab.Controls.Add(this.MemberListLabel);
            this.blankTab.Controls.Add(this.CommitteListLabel);
            this.blankTab.Controls.Add(this.ListOf2);
            this.blankTab.Controls.Add(this.ListOf);
            this.blankTab.Controls.Add(this.VoteButton);
            // 
            // VoteButton
            // 
            this.VoteButton.Location = new System.Drawing.Point(6, 6);
            this.VoteButton.Name = "VoteButton";
            this.VoteButton.Size = new System.Drawing.Size(92, 23);
            this.VoteButton.TabIndex = 0;
            this.VoteButton.Text = "Vote";
            this.VoteButton.UseVisualStyleBackColor = true;
            this.VoteButton.Click += new System.EventHandler(this.VoteButton_Click);
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
            // CommitteListLabel
            // 
            this.CommitteListLabel.AutoSize = true;
            this.CommitteListLabel.Location = new System.Drawing.Point(149, 9);
            this.CommitteListLabel.Name = "CommitteListLabel";
            this.CommitteListLabel.Size = new System.Drawing.Size(75, 13);
            this.CommitteListLabel.TabIndex = 3;
            this.CommitteListLabel.Text = "Committee List";
            // 
            // MemberListLabel
            // 
            this.MemberListLabel.AutoSize = true;
            this.MemberListLabel.Location = new System.Drawing.Point(308, 9);
            this.MemberListLabel.Name = "MemberListLabel";
            this.MemberListLabel.Size = new System.Drawing.Size(64, 13);
            this.MemberListLabel.TabIndex = 4;
            this.MemberListLabel.Text = "Member List";
            // 
            // AddPartyButton
            // 
            this.AddPartyButton.Location = new System.Drawing.Point(6, 35);
            this.AddPartyButton.Name = "AddPartyButton";
            this.AddPartyButton.Size = new System.Drawing.Size(92, 23);
            this.AddPartyButton.TabIndex = 5;
            this.AddPartyButton.Text = "Add Party";
            this.AddPartyButton.UseVisualStyleBackColor = true;
            this.AddPartyButton.Click += new System.EventHandler(this.AddPartyButton_Click);
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(270, 42);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(142, 20);
            this.TextName.TabIndex = 6;
            this.TextName.TextChanged += new System.EventHandler(this.TextName_TextChanged);
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Location = new System.Drawing.Point(127, 45);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(117, 13);
            this.Name1.TabIndex = 7;
            this.Name1.Text = "Enter the head party id:";
            // 
            // EnterB
            // 
            this.EnterB.Location = new System.Drawing.Point(438, 42);
            this.EnterB.Name = "EnterB";
            this.EnterB.Size = new System.Drawing.Size(76, 20);
            this.EnterB.TabIndex = 8;
            this.EnterB.Text = "Enter";
            this.EnterB.UseVisualStyleBackColor = true;
            this.EnterB.Click += new System.EventHandler(this.EnterB_Click_1);
            // 
            // Partynamelabel
            // 
            this.Partynamelabel.AutoSize = true;
            this.Partynamelabel.Location = new System.Drawing.Point(127, 69);
            this.Partynamelabel.Name = "Partynamelabel";
            this.Partynamelabel.Size = new System.Drawing.Size(131, 13);
            this.Partynamelabel.TabIndex = 9;
            this.Partynamelabel.Text = "Enter the new party name:";
            // 
            // TextParty
            // 
            this.TextParty.Location = new System.Drawing.Point(270, 66);
            this.TextParty.Name = "TextParty";
            this.TextParty.Size = new System.Drawing.Size(142, 20);
            this.TextParty.TabIndex = 10;
            // 
            // EnterB2
            // 
            this.EnterB2.Location = new System.Drawing.Point(438, 65);
            this.EnterB2.Name = "EnterB2";
            this.EnterB2.Size = new System.Drawing.Size(75, 21);
            this.EnterB2.TabIndex = 11;
            this.EnterB2.Text = "Enter";
            this.EnterB2.UseVisualStyleBackColor = true;
            this.EnterB2.Click += new System.EventHandler(this.EnterB2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Finish primeris";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete_Party
            // 
            this.Delete_Party.ForeColor = System.Drawing.Color.Red;
            this.Delete_Party.Location = new System.Drawing.Point(6, 218);
            this.Delete_Party.Name = "Delete_Party";
            this.Delete_Party.Size = new System.Drawing.Size(75, 23);
            this.Delete_Party.TabIndex = 13;
            this.Delete_Party.Text = "Delete Party";
            this.Delete_Party.UseVisualStyleBackColor = true;
            this.Delete_Party.Click += new System.EventHandler(this.Delete_Party_Click);
            // 
            // End_Election
            // 
            this.End_Election.ForeColor = System.Drawing.Color.MidnightBlue;
            this.End_Election.Location = new System.Drawing.Point(438, 218);
            this.End_Election.Name = "End_Election";
            this.End_Election.Size = new System.Drawing.Size(75, 23);
            this.End_Election.TabIndex = 14;
            this.End_Election.Text = "End Election";
            this.End_Election.UseVisualStyleBackColor = true;
            this.End_Election.Click += new System.EventHandler(this.End_Election_Click);
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

        private System.Windows.Forms.Button VoteButton;
        private System.Windows.Forms.ListView ListOf;
        private System.Windows.Forms.ListView ListOf2;
        private System.Windows.Forms.Label MemberListLabel;
        private System.Windows.Forms.Label CommitteListLabel;
        private System.Windows.Forms.Button AddPartyButton;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Button EnterB;
        private System.Windows.Forms.TextBox TextParty;
        private System.Windows.Forms.Label Partynamelabel;
        private System.Windows.Forms.Button EnterB2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Delete_Party;
        private System.Windows.Forms.Button End_Election;
    }
}