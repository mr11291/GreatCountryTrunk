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
            this.partyList = new System.Windows.Forms.ComboBox();
            this.updateInfoButton = new System.Windows.Forms.Button();
            this.rvkbtn = new System.Windows.Forms.Button();
            this.addtoprty = new System.Windows.Forms.Button();
            this.AddToParty = new System.Windows.Forms.ComboBox();
            this.tabMenu.SuspendLayout();
            this.blankTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // blankTab
            // 
            this.blankTab.Controls.Add(this.AddToParty);
            this.blankTab.Controls.Add(this.addtoprty);
            this.blankTab.Controls.Add(this.rvkbtn);
            this.blankTab.Controls.Add(this.updateInfoButton);
            this.blankTab.Controls.Add(this.partyList);
            this.blankTab.Controls.Add(this.voteButton);
            this.blankTab.Text = "Person";
            // 
            // voteButton
            // 
            this.voteButton.Location = new System.Drawing.Point(16, 16);
            this.voteButton.Name = "voteButton";
            this.voteButton.Size = new System.Drawing.Size(75, 23);
            this.voteButton.TabIndex = 0;
            this.voteButton.Text = "Vote";
            this.voteButton.UseVisualStyleBackColor = true;
            this.voteButton.Click += new System.EventHandler(this.voteButton_Click);
            // 
            // partyList
            // 
            this.partyList.FormattingEnabled = true;
            this.partyList.Location = new System.Drawing.Point(119, 18);
            this.partyList.Name = "partyList";
            this.partyList.Size = new System.Drawing.Size(169, 21);
            this.partyList.TabIndex = 13;
            this.partyList.Text = "select...";
            // 
            // updateInfoButton
            // 
            this.updateInfoButton.Location = new System.Drawing.Point(16, 58);
            this.updateInfoButton.Name = "updateInfoButton";
            this.updateInfoButton.Size = new System.Drawing.Size(75, 23);
            this.updateInfoButton.TabIndex = 14;
            this.updateInfoButton.Text = "Update info";
            this.updateInfoButton.UseVisualStyleBackColor = true;
            this.updateInfoButton.Click += new System.EventHandler(this.updateInfoButton_Click);
            // 
            // rvkbtn
            // 
            this.rvkbtn.Location = new System.Drawing.Point(16, 98);
            this.rvkbtn.Name = "rvkbtn";
            this.rvkbtn.Size = new System.Drawing.Size(86, 23);
            this.rvkbtn.TabIndex = 15;
            this.rvkbtn.Text = "Revoke Voting";
            this.rvkbtn.UseVisualStyleBackColor = true;
            this.rvkbtn.Click += new System.EventHandler(this.rvkbtn_Click);
            // 
            // addtoprty
            // 
            this.addtoprty.Location = new System.Drawing.Point(16, 139);
            this.addtoprty.Name = "addtoprty";
            this.addtoprty.Size = new System.Drawing.Size(86, 23);
            this.addtoprty.TabIndex = 16;
            this.addtoprty.Text = "Add To Party";
            this.addtoprty.UseVisualStyleBackColor = true;
            this.addtoprty.Click += new System.EventHandler(this.addtoprty_Click);
            // 
            // AddToParty
            // 
            this.AddToParty.FormattingEnabled = true;
            this.AddToParty.Location = new System.Drawing.Point(119, 139);
            this.AddToParty.Name = "AddToParty";
            this.AddToParty.Size = new System.Drawing.Size(169, 21);
            this.AddToParty.TabIndex = 17;
            this.AddToParty.Text = "select...";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button voteButton;
        private System.Windows.Forms.ComboBox partyList;
        private System.Windows.Forms.Button updateInfoButton;
        private System.Windows.Forms.Button rvkbtn;
        private System.Windows.Forms.Button addtoprty;
        private System.Windows.Forms.ComboBox AddToParty;
    }
}