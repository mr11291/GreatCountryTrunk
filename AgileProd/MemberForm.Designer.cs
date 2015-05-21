namespace AgileProd
{
    partial class MemberForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnAddMem = new System.Windows.Forms.Button();
            this.MmberVote = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.quitPartyButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PartySlogenBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PartyNameBox = new System.Windows.Forms.TextBox();
            this.MySlogenBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.partyList = new System.Windows.Forms.ListView();
            this.changeSlogenButton = new System.Windows.Forms.Button();
            this.lblttlmoney = new System.Windows.Forms.Label();
            this.tabMenu.SuspendLayout();
            this.blankTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // blankTab
            // 
            this.blankTab.Controls.Add(this.lblttlmoney);
            this.blankTab.Controls.Add(this.changeSlogenButton);
            this.blankTab.Controls.Add(this.partyList);
            this.blankTab.Controls.Add(this.label6);
            this.blankTab.Controls.Add(this.button5);
            this.blankTab.Controls.Add(this.label5);
            this.blankTab.Controls.Add(this.MySlogenBox);
            this.blankTab.Controls.Add(this.PartyNameBox);
            this.blankTab.Controls.Add(this.label3);
            this.blankTab.Controls.Add(this.PartySlogenBox);
            this.blankTab.Controls.Add(this.label2);
            this.blankTab.Controls.Add(this.quitPartyButton);
            this.blankTab.Controls.Add(this.button2);
            this.blankTab.Controls.Add(this.MmberVote);
            this.blankTab.Text = "Party Member";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Green;
            this.lblWelcome.Location = new System.Drawing.Point(43, 18);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 25);
            this.lblWelcome.TabIndex = 1;
            // 
            // btnAddMem
            // 
            this.btnAddMem.Location = new System.Drawing.Point(12, 150);
            this.btnAddMem.Name = "btnAddMem";
            this.btnAddMem.Size = new System.Drawing.Size(109, 23);
            this.btnAddMem.TabIndex = 2;
            this.btnAddMem.Text = "Add Party Member";
            this.btnAddMem.UseVisualStyleBackColor = true;
            this.btnAddMem.Click += new System.EventHandler(this.btnAddMem_Click);
            // 
            // MmberVote
            // 
            this.MmberVote.Location = new System.Drawing.Point(8, 8);
            this.MmberVote.Name = "MmberVote";
            this.MmberVote.Size = new System.Drawing.Size(75, 23);
            this.MmberVote.TabIndex = 0;
            this.MmberVote.Text = "Vote";
            this.MmberVote.UseVisualStyleBackColor = true;
            this.MmberVote.Click += new System.EventHandler(this.MmberVote_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Member";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // quitPartyButton
            // 
            this.quitPartyButton.ForeColor = System.Drawing.Color.Red;
            this.quitPartyButton.Location = new System.Drawing.Point(8, 250);
            this.quitPartyButton.Name = "quitPartyButton";
            this.quitPartyButton.Size = new System.Drawing.Size(75, 23);
            this.quitPartyButton.TabIndex = 2;
            this.quitPartyButton.Text = "Quit Party";
            this.quitPartyButton.UseVisualStyleBackColor = true;
            this.quitPartyButton.Click += new System.EventHandler(this.quitPartyButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Party Slogen:";
            // 
            // PartySlogenBox
            // 
            this.PartySlogenBox.Location = new System.Drawing.Point(508, 37);
            this.PartySlogenBox.Name = "PartySlogenBox";
            this.PartySlogenBox.ReadOnly = true;
            this.PartySlogenBox.Size = new System.Drawing.Size(154, 20);
            this.PartySlogenBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Party Name:";
            // 
            // PartyNameBox
            // 
            this.PartyNameBox.Location = new System.Drawing.Point(508, 10);
            this.PartyNameBox.Name = "PartyNameBox";
            this.PartyNameBox.ReadOnly = true;
            this.PartyNameBox.Size = new System.Drawing.Size(154, 20);
            this.PartyNameBox.TabIndex = 6;
            // 
            // MySlogenBox
            // 
            this.MySlogenBox.Location = new System.Drawing.Point(508, 63);
            this.MySlogenBox.Name = "MySlogenBox";
            this.MySlogenBox.ReadOnly = true;
            this.MySlogenBox.Size = new System.Drawing.Size(154, 20);
            this.MySlogenBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "My Slogen:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 36);
            this.button5.TabIndex = 10;
            this.button5.Text = "Remove Member";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(432, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Your Colleagues:";
            // 
            // partyList
            // 
            this.partyList.Location = new System.Drawing.Point(435, 148);
            this.partyList.Name = "partyList";
            this.partyList.Size = new System.Drawing.Size(227, 131);
            this.partyList.TabIndex = 12;
            this.partyList.UseCompatibleStateImageBehavior = false;
            this.partyList.View = System.Windows.Forms.View.List;
            // 
            // changeSlogenButton
            // 
            this.changeSlogenButton.Location = new System.Drawing.Point(508, 89);
            this.changeSlogenButton.Name = "changeSlogenButton";
            this.changeSlogenButton.Size = new System.Drawing.Size(98, 23);
            this.changeSlogenButton.TabIndex = 13;
            this.changeSlogenButton.Text = "Suggest Slogen";
            this.changeSlogenButton.UseVisualStyleBackColor = true;
            this.changeSlogenButton.Click += new System.EventHandler(this.slogenChangeButton_Click);
            // 
            // lblttlmoney
            // 
            this.lblttlmoney.AutoSize = true;
            this.lblttlmoney.Location = new System.Drawing.Point(6, 136);
            this.lblttlmoney.Name = "lblttlmoney";
            this.lblttlmoney.Size = new System.Drawing.Size(68, 13);
            this.lblttlmoney.TabIndex = 15;
            this.lblttlmoney.Text = "Total money:";
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 309);
            this.Controls.Add(this.btnAddMem);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.label1);
            this.Name = "MemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberForm";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblWelcome, 0);
            this.Controls.SetChildIndex(this.btnAddMem, 0);
            this.Controls.SetChildIndex(this.tabMenu, 0);
            this.tabMenu.ResumeLayout(false);
            this.blankTab.ResumeLayout(false);
            this.blankTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnAddMem;
        private System.Windows.Forms.Button quitPartyButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button MmberVote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PartySlogenBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MySlogenBox;
        private System.Windows.Forms.TextBox PartyNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView partyList;
        private System.Windows.Forms.Button changeSlogenButton;
        private System.Windows.Forms.Label lblttlmoney;
    }
}