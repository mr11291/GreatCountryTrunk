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
            this.voteButton = new System.Windows.Forms.Button();
            this.CommitteListLabel = new System.Windows.Forms.Label();
            this.MemberListLabel = new System.Windows.Forms.Label();
            this.ListOf2 = new System.Windows.Forms.ListView();
            this.ListOf = new System.Windows.Forms.ListView();
            this.InfoParty = new System.Windows.Forms.Button();
            this.cmbxInfoParty = new System.Windows.Forms.ComboBox();
            this.InfoAboutParty = new System.Windows.Forms.ListView();
            this.VoteParty = new System.Windows.Forms.Button();
            this.lblttlmoney = new System.Windows.Forms.Label();
            this.BtnBckLastPrty = new System.Windows.Forms.Button();
            this.tabMenu.SuspendLayout();
            this.blankTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // blankTab
            // 
            this.blankTab.Controls.Add(this.BtnBckLastPrty);
            this.blankTab.Controls.Add(this.lblttlmoney);
            this.blankTab.Controls.Add(this.VoteParty);
            this.blankTab.Controls.Add(this.InfoAboutParty);
            this.blankTab.Controls.Add(this.cmbxInfoParty);
            this.blankTab.Controls.Add(this.InfoParty);
            this.blankTab.Controls.Add(this.ListOf2);
            this.blankTab.Controls.Add(this.ListOf);
            this.blankTab.Controls.Add(this.MemberListLabel);
            this.blankTab.Controls.Add(this.CommitteListLabel);
            this.blankTab.Controls.Add(this.voteButton);
            this.blankTab.Text = "Person";
            // 
            // voteButton
            // 
            this.voteButton.Location = new System.Drawing.Point(233, 11);
            this.voteButton.Name = "voteButton";
            this.voteButton.Size = new System.Drawing.Size(92, 23);
            this.voteButton.TabIndex = 0;
            this.voteButton.Text = "Vote";
            this.voteButton.UseVisualStyleBackColor = true;
            this.voteButton.Click += new System.EventHandler(this.voteButton_Click);
            // 
            // CommitteListLabel
            // 
            this.CommitteListLabel.AutoSize = true;
            this.CommitteListLabel.Location = new System.Drawing.Point(361, 16);
            this.CommitteListLabel.Name = "CommitteListLabel";
            this.CommitteListLabel.Size = new System.Drawing.Size(75, 13);
            this.CommitteListLabel.TabIndex = 18;
            this.CommitteListLabel.Text = "Committee List";
            // 
            // MemberListLabel
            // 
            this.MemberListLabel.AutoSize = true;
            this.MemberListLabel.Location = new System.Drawing.Point(548, 16);
            this.MemberListLabel.Name = "MemberListLabel";
            this.MemberListLabel.Size = new System.Drawing.Size(64, 13);
            this.MemberListLabel.TabIndex = 19;
            this.MemberListLabel.Text = "Member List";
            // 
            // ListOf2
            // 
            this.ListOf2.Location = new System.Drawing.Point(507, 45);
            this.ListOf2.Name = "ListOf2";
            this.ListOf2.Size = new System.Drawing.Size(142, 204);
            this.ListOf2.TabIndex = 21;
            this.ListOf2.UseCompatibleStateImageBehavior = false;
            this.ListOf2.View = System.Windows.Forms.View.List;
            this.ListOf2.SelectedIndexChanged += new System.EventHandler(this.ListOf2_SelectedIndexChanged);
            // 
            // ListOf
            // 
            this.ListOf.Location = new System.Drawing.Point(335, 45);
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
            this.InfoParty.Size = new System.Drawing.Size(75, 23);
            this.InfoParty.TabIndex = 22;
            this.InfoParty.Text = "Info about Party";
            this.InfoParty.UseVisualStyleBackColor = true;
            this.InfoParty.Click += new System.EventHandler(this.InfoParty_Click);
            // 
            // cmbxInfoParty
            // 
            this.cmbxInfoParty.FormattingEnabled = true;
            this.cmbxInfoParty.Items.AddRange(new object[] {
            "select..."});
            this.cmbxInfoParty.Location = new System.Drawing.Point(102, 30);
            this.cmbxInfoParty.Name = "cmbxInfoParty";
            this.cmbxInfoParty.Size = new System.Drawing.Size(121, 21);
            this.cmbxInfoParty.TabIndex = 23;
            // 
            // InfoAboutParty
            // 
            this.InfoAboutParty.Location = new System.Drawing.Point(102, 57);
            this.InfoAboutParty.Name = "InfoAboutParty";
            this.InfoAboutParty.Size = new System.Drawing.Size(136, 192);
            this.InfoAboutParty.TabIndex = 24;
            this.InfoAboutParty.UseCompatibleStateImageBehavior = false;
            this.InfoAboutParty.View = System.Windows.Forms.View.List;
            // 
            // VoteParty
            // 
            this.VoteParty.Location = new System.Drawing.Point(6, 45);
            this.VoteParty.Name = "VoteParty";
            this.VoteParty.Size = new System.Drawing.Size(75, 23);
            this.VoteParty.TabIndex = 25;
            this.VoteParty.Text = "Vote to party";
            this.VoteParty.UseVisualStyleBackColor = true;
            this.VoteParty.Click += new System.EventHandler(this.VoteParty_Click);
            // 
            // lblttlmoney
            // 
            this.lblttlmoney.AutoSize = true;
            this.lblttlmoney.Location = new System.Drawing.Point(6, 264);
            this.lblttlmoney.Name = "lblttlmoney";
            this.lblttlmoney.Size = new System.Drawing.Size(68, 13);
            this.lblttlmoney.TabIndex = 26;
            this.lblttlmoney.Text = "Total money:";
            // 
            // BtnBckLastPrty
            // 
            this.BtnBckLastPrty.Location = new System.Drawing.Point(244, 256);
            this.BtnBckLastPrty.Name = "BtnBckLastPrty";
            this.BtnBckLastPrty.Size = new System.Drawing.Size(405, 23);
            this.BtnBckLastPrty.TabIndex = 27;
            this.BtnBckLastPrty.Text = "Return last party";
            this.BtnBckLastPrty.UseVisualStyleBackColor = true;
            this.BtnBckLastPrty.Visible = false;
            this.BtnBckLastPrty.Click += new System.EventHandler(this.BtnBckLastPrty_Click);
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
        private System.Windows.Forms.Label CommitteListLabel;
        private System.Windows.Forms.Label MemberListLabel;
        private System.Windows.Forms.ListView ListOf2;
        private System.Windows.Forms.ListView ListOf;
        private System.Windows.Forms.Button InfoParty;
        private System.Windows.Forms.ComboBox cmbxInfoParty;
        private System.Windows.Forms.ListView InfoAboutParty;
        private System.Windows.Forms.Button VoteParty;
        private System.Windows.Forms.Label lblttlmoney;
        private System.Windows.Forms.Button BtnBckLastPrty;
    }
}