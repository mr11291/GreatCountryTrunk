namespace AgileProd
{
    partial class PeopleForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balanceBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.voterCheckBox = new System.Windows.Forms.CheckBox();
            this.voteButton = new System.Windows.Forms.Button();
            this.updateInfoButton = new System.Windows.Forms.Button();
            this.partyList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 107);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 133);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "ID:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(12, 159);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(29, 13);
            this.ageLabel.TabIndex = 3;
            this.ageLabel.Text = "Age:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(12, 185);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(49, 13);
            this.balanceLabel.TabIndex = 4;
            this.balanceLabel.Text = "Balance:";
            // 
            // balanceBox
            // 
            this.balanceBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.balanceBox.Location = new System.Drawing.Point(67, 182);
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.ReadOnly = true;
            this.balanceBox.Size = new System.Drawing.Size(100, 20);
            this.balanceBox.TabIndex = 5;
            
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idBox.Location = new System.Drawing.Point(67, 130);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(100, 20);
            this.idBox.TabIndex = 6;
            // 
            // ageBox
            // 
            this.ageBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ageBox.Location = new System.Drawing.Point(67, 156);
            this.ageBox.Name = "ageBox";
            this.ageBox.ReadOnly = true;
            this.ageBox.Size = new System.Drawing.Size(100, 20);
            this.ageBox.TabIndex = 7;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameBox.Location = new System.Drawing.Point(67, 104);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 8;
            // 
            // voterCheckBox
            // 
            this.voterCheckBox.AutoSize = true;
            this.voterCheckBox.Location = new System.Drawing.Point(295, 185);
            this.voterCheckBox.Name = "voterCheckBox";
            this.voterCheckBox.Size = new System.Drawing.Size(115, 17);
            this.voterCheckBox.TabIndex = 9;
            this.voterCheckBox.Text = "Register as a voter";
            this.voterCheckBox.UseVisualStyleBackColor = true;
            // 
            // voteButton
            // 
            this.voteButton.Location = new System.Drawing.Point(15, 12);
            this.voteButton.Name = "voteButton";
            this.voteButton.Size = new System.Drawing.Size(75, 23);
            this.voteButton.TabIndex = 10;
            this.voteButton.Text = "Vote";
            this.voteButton.UseVisualStyleBackColor = true;
            this.voteButton.Click += new System.EventHandler(this.voteButton_Click);
            // 
            // updateInfoButton
            // 
            this.updateInfoButton.Location = new System.Drawing.Point(15, 41);
            this.updateInfoButton.Name = "updateInfoButton";
            this.updateInfoButton.Size = new System.Drawing.Size(75, 23);
            this.updateInfoButton.TabIndex = 11;
            this.updateInfoButton.Text = "Update info";
            this.updateInfoButton.UseVisualStyleBackColor = true;
            this.updateInfoButton.Click += new System.EventHandler(this.updateInfoButton_Click);
            // 
            // partyList
            // 
            this.partyList.FormattingEnabled = true;
            this.partyList.Location = new System.Drawing.Point(96, 14);
            this.partyList.Name = "partyList";
            this.partyList.Size = new System.Drawing.Size(169, 21);
            this.partyList.TabIndex = 12;
            this.partyList.Text = "select...";
            this.partyList.SelectedIndexChanged += new System.EventHandler(this.partyList_SelectedIndexChanged);
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 211);
            this.Controls.Add(this.partyList);
            this.Controls.Add(this.updateInfoButton);
            this.Controls.Add(this.voteButton);
            this.Controls.Add(this.voterCheckBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.balanceBox);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "PeopleForm";
            this.Text = "PeopleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox balanceBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.CheckBox voterCheckBox;
        private System.Windows.Forms.Button voteButton;
        private System.Windows.Forms.Button updateInfoButton;
        private System.Windows.Forms.ComboBox partyList;

    }
}