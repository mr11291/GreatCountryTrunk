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
            this.voteButton = new System.Windows.Forms.Button();
            this.CommitteListLabel = new System.Windows.Forms.Label();
            this.MemberListLabel = new System.Windows.Forms.Label();
            this.ListOf2 = new System.Windows.Forms.ListView();
            this.ListOf = new System.Windows.Forms.ListView();
            this.tabMenu.SuspendLayout();
            this.blankTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // blankTab
            // 
            this.blankTab.Controls.Add(this.ListOf2);
            this.blankTab.Controls.Add(this.ListOf);
            this.blankTab.Controls.Add(this.MemberListLabel);
            this.blankTab.Controls.Add(this.CommitteListLabel);
            this.blankTab.Controls.Add(this.voteButton);
            this.blankTab.Text = "Person";
            // 
            // voteButton
            // 
            this.voteButton.Location = new System.Drawing.Point(6, 6);
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
            this.CommitteListLabel.Location = new System.Drawing.Point(149, 9);
            this.CommitteListLabel.Name = "CommitteListLabel";
            this.CommitteListLabel.Size = new System.Drawing.Size(75, 13);
            this.CommitteListLabel.TabIndex = 18;
            this.CommitteListLabel.Text = "Committee List";
            // 
            // MemberListLabel
            // 
            this.MemberListLabel.AutoSize = true;
            this.MemberListLabel.Location = new System.Drawing.Point(308, 8);
            this.MemberListLabel.Name = "MemberListLabel";
            this.MemberListLabel.Size = new System.Drawing.Size(64, 13);
            this.MemberListLabel.TabIndex = 19;
            this.MemberListLabel.Text = "Member List";
            // 
            // ListOf2
            // 
            this.ListOf2.Location = new System.Drawing.Point(273, 25);
            this.ListOf2.Name = "ListOf2";
            this.ListOf2.Size = new System.Drawing.Size(142, 216);
            this.ListOf2.TabIndex = 21;
            this.ListOf2.UseCompatibleStateImageBehavior = false;
            this.ListOf2.View = System.Windows.Forms.View.List;
            this.ListOf2.SelectedIndexChanged += new System.EventHandler(this.ListOf2_SelectedIndexChanged);
            // 
            // ListOf
            // 
            this.ListOf.Location = new System.Drawing.Point(116, 25);
            this.ListOf.Name = "ListOf";
            this.ListOf.Size = new System.Drawing.Size(141, 216);
            this.ListOf.TabIndex = 20;
            this.ListOf.UseCompatibleStateImageBehavior = false;
            this.ListOf.View = System.Windows.Forms.View.List;
            this.ListOf.SelectedIndexChanged += new System.EventHandler(this.ListOf_SelectedIndexChanged_1);
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
    }
}