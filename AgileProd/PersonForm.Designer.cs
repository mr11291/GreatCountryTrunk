﻿namespace AgileProd
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
            this.partyInfoButton = new System.Windows.Forms.Button();
            this.partyNameComboBox = new System.Windows.Forms.ComboBox();
            this.InfoAboutParty = new System.Windows.Forms.ListView();
            this.VoteParty = new System.Windows.Forms.Button();
            this.retrunToPartyButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sittingPutin = new System.Windows.Forms.PictureBox();
            this.happySittingPutin = new System.Windows.Forms.PictureBox();
            this.suspiciusPutin = new System.Windows.Forms.PictureBox();
            this.DancingPuting = new System.Windows.Forms.PictureBox();
            this.dancingPutinTimer = new System.Windows.Forms.Timer(this.components);
            this.tabMenu.SuspendLayout();
            this.blankTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sittingPutin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.happySittingPutin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suspiciusPutin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DancingPuting)).BeginInit();
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
            this.blankTab.Controls.Add(this.partyInfoButton);
            this.blankTab.Controls.Add(this.ListOf2);
            this.blankTab.Controls.Add(this.ListOf);
            this.blankTab.Controls.Add(this.MemberListLabel);
            this.blankTab.Controls.Add(this.partyListLabel);
            this.blankTab.Controls.Add(this.voteButton);
            this.blankTab.Controls.Add(this.sittingPutin);
            this.blankTab.Controls.Add(this.happySittingPutin);
            this.blankTab.Controls.Add(this.suspiciusPutin);
            this.blankTab.Controls.Add(this.DancingPuting);
            this.blankTab.Text = "Person";
            this.blankTab.Controls.SetChildIndex(this.username, 0);
            this.blankTab.Controls.SetChildIndex(this.DancingPuting, 0);
            this.blankTab.Controls.SetChildIndex(this.suspiciusPutin, 0);
            this.blankTab.Controls.SetChildIndex(this.happySittingPutin, 0);
            this.blankTab.Controls.SetChildIndex(this.sittingPutin, 0);
            this.blankTab.Controls.SetChildIndex(this.voteButton, 0);
            this.blankTab.Controls.SetChildIndex(this.partyListLabel, 0);
            this.blankTab.Controls.SetChildIndex(this.MemberListLabel, 0);
            this.blankTab.Controls.SetChildIndex(this.ListOf, 0);
            this.blankTab.Controls.SetChildIndex(this.ListOf2, 0);
            this.blankTab.Controls.SetChildIndex(this.partyInfoButton, 0);
            this.blankTab.Controls.SetChildIndex(this.partyNameComboBox, 0);
            this.blankTab.Controls.SetChildIndex(this.InfoAboutParty, 0);
            this.blankTab.Controls.SetChildIndex(this.VoteParty, 0);
            this.blankTab.Controls.SetChildIndex(this.retrunToPartyButton, 0);
            // 
            // username
            // 
            this.username.ForeColor = System.Drawing.Color.Black;
            // 
            // voteButton
            // 
            this.voteButton.BackColor = System.Drawing.Color.Yellow;
            this.voteButton.Location = new System.Drawing.Point(5, 65);
            this.voteButton.Name = "voteButton";
            this.voteButton.Size = new System.Drawing.Size(97, 23);
            this.voteButton.TabIndex = 0;
            this.voteButton.Text = "Vote to member";
            this.voteButton.UseVisualStyleBackColor = false;
            this.voteButton.Click += new System.EventHandler(this.voteButton_Click);
            // 
            // partyListLabel
            // 
            this.partyListLabel.AutoSize = true;
            this.partyListLabel.Location = new System.Drawing.Point(327, 10);
            this.partyListLabel.Name = "partyListLabel";
            this.partyListLabel.Size = new System.Drawing.Size(53, 13);
            this.partyListLabel.TabIndex = 18;
            this.partyListLabel.Text = "Party List:";
            // 
            // MemberListLabel
            // 
            this.MemberListLabel.AutoSize = true;
            this.MemberListLabel.Location = new System.Drawing.Point(504, 10);
            this.MemberListLabel.Name = "MemberListLabel";
            this.MemberListLabel.Size = new System.Drawing.Size(67, 13);
            this.MemberListLabel.TabIndex = 19;
            this.MemberListLabel.Text = "Member List:";
            // 
            // ListOf2
            // 
            this.ListOf2.BackColor = System.Drawing.Color.Snow;
            this.ListOf2.Location = new System.Drawing.Point(507, 32);
            this.ListOf2.Name = "ListOf2";
            this.ListOf2.Size = new System.Drawing.Size(142, 204);
            this.ListOf2.TabIndex = 21;
            this.ListOf2.UseCompatibleStateImageBehavior = false;
            this.ListOf2.View = System.Windows.Forms.View.List;
            this.ListOf2.SelectedIndexChanged += new System.EventHandler(this.ListOf2_SelectedIndexChanged);
            // 
            // ListOf
            // 
            this.ListOf.BackColor = System.Drawing.Color.Snow;
            this.ListOf.Location = new System.Drawing.Point(316, 32);
            this.ListOf.Name = "ListOf";
            this.ListOf.Size = new System.Drawing.Size(141, 204);
            this.ListOf.TabIndex = 20;
            this.ListOf.UseCompatibleStateImageBehavior = false;
            this.ListOf.View = System.Windows.Forms.View.List;
            this.ListOf.SelectedIndexChanged += new System.EventHandler(this.ListOf_SelectedIndexChanged_1);
            // 
            // partyInfoButton
            // 
            this.partyInfoButton.BackColor = System.Drawing.Color.Yellow;
            this.partyInfoButton.Location = new System.Drawing.Point(5, 5);
            this.partyInfoButton.Name = "partyInfoButton";
            this.partyInfoButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.partyInfoButton.Size = new System.Drawing.Size(97, 23);
            this.partyInfoButton.TabIndex = 22;
            this.partyInfoButton.Text = "Party list";
            this.partyInfoButton.UseVisualStyleBackColor = false;
            this.partyInfoButton.Click += new System.EventHandler(this.InfoParty_Click);
            // 
            // partyNameComboBox
            // 
            this.partyNameComboBox.FormattingEnabled = true;
            this.partyNameComboBox.Items.AddRange(new object[] {
            "select..."});
            this.partyNameComboBox.Location = new System.Drawing.Point(155, 5);
            this.partyNameComboBox.Name = "partyNameComboBox";
            this.partyNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.partyNameComboBox.TabIndex = 23;
            this.partyNameComboBox.SelectedIndexChanged += new System.EventHandler(this.partyNameComboBox_SelectedIndexChanged);
            // 
            // InfoAboutParty
            // 
            this.InfoAboutParty.BackColor = System.Drawing.Color.Snow;
            this.InfoAboutParty.GridLines = true;
            this.InfoAboutParty.Location = new System.Drawing.Point(155, 32);
            this.InfoAboutParty.MultiSelect = false;
            this.InfoAboutParty.Name = "InfoAboutParty";
            this.InfoAboutParty.Size = new System.Drawing.Size(121, 204);
            this.InfoAboutParty.TabIndex = 24;
            this.InfoAboutParty.UseCompatibleStateImageBehavior = false;
            this.InfoAboutParty.View = System.Windows.Forms.View.List;
            // 
            // VoteParty
            // 
            this.VoteParty.BackColor = System.Drawing.Color.Yellow;
            this.VoteParty.Location = new System.Drawing.Point(5, 35);
            this.VoteParty.Name = "VoteParty";
            this.VoteParty.Size = new System.Drawing.Size(97, 23);
            this.VoteParty.TabIndex = 25;
            this.VoteParty.Text = "Vote to party";
            this.VoteParty.UseVisualStyleBackColor = false;
            this.VoteParty.Click += new System.EventHandler(this.VoteParty_Click);
            // 
            // retrunToPartyButton
            // 
            this.retrunToPartyButton.BackColor = System.Drawing.Color.Yellow;
            this.retrunToPartyButton.Location = new System.Drawing.Point(5, 95);
            this.retrunToPartyButton.Name = "retrunToPartyButton";
            this.retrunToPartyButton.Size = new System.Drawing.Size(97, 23);
            this.retrunToPartyButton.TabIndex = 27;
            this.retrunToPartyButton.Text = "Return to a party";
            this.retrunToPartyButton.UseVisualStyleBackColor = false;
            this.retrunToPartyButton.Visible = false;
            this.retrunToPartyButton.Click += new System.EventHandler(this.BtnBckLastPrty_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "RedDot.png");
            // 
            // sittingPutin
            // 
            this.sittingPutin.Image = global::AgileProd.Properties.Resources.MadSittingPutinRoteted;
            this.sittingPutin.Location = new System.Drawing.Point(211, 117);
            this.sittingPutin.Name = "sittingPutin";
            this.sittingPutin.Size = new System.Drawing.Size(275, 169);
            this.sittingPutin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sittingPutin.TabIndex = 28;
            this.sittingPutin.TabStop = false;
            // 
            // happySittingPutin
            // 
            this.happySittingPutin.Image = global::AgileProd.Properties.Resources.HappySittingPutin;
            this.happySittingPutin.Location = new System.Drawing.Point(211, 116);
            this.happySittingPutin.Name = "happySittingPutin";
            this.happySittingPutin.Size = new System.Drawing.Size(275, 170);
            this.happySittingPutin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.happySittingPutin.TabIndex = 29;
            this.happySittingPutin.TabStop = false;
            // 
            // suspiciusPutin
            // 
            this.suspiciusPutin.Image = global::AgileProd.Properties.Resources.suspiciusPutin;
            this.suspiciusPutin.Location = new System.Drawing.Point(305, 10);
            this.suspiciusPutin.Name = "suspiciusPutin";
            this.suspiciusPutin.Size = new System.Drawing.Size(302, 319);
            this.suspiciusPutin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.suspiciusPutin.TabIndex = 32;
            this.suspiciusPutin.TabStop = false;
            this.suspiciusPutin.Visible = false;
            // 
            // DancingPuting
            // 
            this.DancingPuting.Enabled = false;
            this.DancingPuting.Image = global::AgileProd.Properties.Resources.DancingPutin;
            this.DancingPuting.Location = new System.Drawing.Point(70, 24);
            this.DancingPuting.Name = "DancingPuting";
            this.DancingPuting.Size = new System.Drawing.Size(195, 305);
            this.DancingPuting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DancingPuting.TabIndex = 33;
            this.DancingPuting.TabStop = false;
            this.DancingPuting.Visible = false;
            // 
            // dancingPutinTimer
            // 
            this.dancingPutinTimer.Interval = 14000;
            this.dancingPutinTimer.Tick += new System.EventHandler(this.dancingPutinTimer_Tick);
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 305);
            this.Name = "PersonForm";
            this.Text = "Person";
            this.tabMenu.ResumeLayout(false);
            this.blankTab.ResumeLayout(false);
            this.blankTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sittingPutin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.happySittingPutin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suspiciusPutin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DancingPuting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button voteButton;
        private System.Windows.Forms.Label partyListLabel;
        private System.Windows.Forms.Label MemberListLabel;
        private System.Windows.Forms.ListView ListOf2;
        private System.Windows.Forms.ListView ListOf;
        private System.Windows.Forms.Button partyInfoButton;
        private System.Windows.Forms.ComboBox partyNameComboBox;
        private System.Windows.Forms.ListView InfoAboutParty;
        private System.Windows.Forms.Button VoteParty;
        private System.Windows.Forms.Button retrunToPartyButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox sittingPutin;
        private System.Windows.Forms.PictureBox happySittingPutin;
        private System.Windows.Forms.PictureBox suspiciusPutin;
        private System.Windows.Forms.PictureBox DancingPuting;
        public System.Windows.Forms.Timer dancingPutinTimer;
    }
}