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
            this.tabMenu.SuspendLayout();
            this.blankTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // blankTab
            // 
            this.blankTab.Controls.Add(this.ListOf2);
            this.blankTab.Controls.Add(this.ListOf);
            this.blankTab.Controls.Add(this.VoteButton);
            // 
            // VoteButton
            // 
            this.VoteButton.Location = new System.Drawing.Point(6, 6);
            this.VoteButton.Name = "VoteButton";
            this.VoteButton.Size = new System.Drawing.Size(75, 23);
            this.VoteButton.TabIndex = 0;
            this.VoteButton.Text = "Vote";
            this.VoteButton.UseVisualStyleBackColor = true;
            this.VoteButton.Click += new System.EventHandler(this.VoteButton_Click);
            // 
            // ListOf
            // 
            this.ListOf.Location = new System.Drawing.Point(104, 6);
            this.ListOf.Name = "ListOf";
            this.ListOf.Size = new System.Drawing.Size(141, 216);
            this.ListOf.TabIndex = 1;
            this.ListOf.UseCompatibleStateImageBehavior = false;
            this.ListOf.View = System.Windows.Forms.View.List;
            this.ListOf.SelectedIndexChanged += new System.EventHandler(this.ListOf_SelectedIndexChanged);
            // 
            // ListOf2
            // 
            this.ListOf2.Location = new System.Drawing.Point(251, 6);
            this.ListOf2.Name = "ListOf2";
            this.ListOf2.Size = new System.Drawing.Size(142, 216);
            this.ListOf2.TabIndex = 2;
            this.ListOf2.UseCompatibleStateImageBehavior = false;
            this.ListOf2.View = System.Windows.Forms.View.List;
            this.ListOf2.SelectedIndexChanged += new System.EventHandler(this.ListOf2_SelectedIndexChanged);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VoteButton;
        private System.Windows.Forms.ListView ListOf;
        private System.Windows.Forms.ListView ListOf2;
    }
}