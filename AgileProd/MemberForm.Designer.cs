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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnAddMem = new System.Windows.Forms.Button();
            this.quitPartyButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PartySlogenBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PartyNameBox = new System.Windows.Forms.TextBox();
            this.MySlogenBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.partyList = new System.Windows.Forms.ListView();
            this.suggestSlogenButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pickSlogenButton = new System.Windows.Forms.Button();
            this.voteToYourSelfButton = new System.Windows.Forms.Button();
            this.VoteToYourParty = new System.Windows.Forms.Button();
            this.tabMenu.SuspendLayout();
            this.blankTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.ImageList = this.imageList1;
            // 
            // blankTab
            // 
            this.blankTab.Controls.Add(this.VoteToYourParty);
            this.blankTab.Controls.Add(this.voteToYourSelfButton);
            this.blankTab.Controls.Add(this.pickSlogenButton);
            this.blankTab.Controls.Add(this.suggestSlogenButton);
            this.blankTab.Controls.Add(this.partyList);
            this.blankTab.Controls.Add(this.label6);
            this.blankTab.Controls.Add(this.label5);
            this.blankTab.Controls.Add(this.MySlogenBox);
            this.blankTab.Controls.Add(this.PartyNameBox);
            this.blankTab.Controls.Add(this.label3);
            this.blankTab.Controls.Add(this.PartySlogenBox);
            this.blankTab.Controls.Add(this.label2);
            this.blankTab.Controls.Add(this.quitPartyButton);
            this.blankTab.Controls.Add(this.pictureBox1);
            this.blankTab.Text = "Party Member";
            this.blankTab.Controls.SetChildIndex(this.username, 0);
            this.blankTab.Controls.SetChildIndex(this.pictureBox1, 0);
            this.blankTab.Controls.SetChildIndex(this.quitPartyButton, 0);
            this.blankTab.Controls.SetChildIndex(this.label2, 0);
            this.blankTab.Controls.SetChildIndex(this.PartySlogenBox, 0);
            this.blankTab.Controls.SetChildIndex(this.label3, 0);
            this.blankTab.Controls.SetChildIndex(this.PartyNameBox, 0);
            this.blankTab.Controls.SetChildIndex(this.MySlogenBox, 0);
            this.blankTab.Controls.SetChildIndex(this.label5, 0);
            this.blankTab.Controls.SetChildIndex(this.label6, 0);
            this.blankTab.Controls.SetChildIndex(this.partyList, 0);
            this.blankTab.Controls.SetChildIndex(this.suggestSlogenButton, 0);
            this.blankTab.Controls.SetChildIndex(this.pickSlogenButton, 0);
            this.blankTab.Controls.SetChildIndex(this.voteToYourSelfButton, 0);
            this.blankTab.Controls.SetChildIndex(this.VoteToYourParty, 0);
            // 
            // bankTab
            // 
            this.bankTab.ImageIndex = 0;
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
            // quitPartyButton
            // 
            this.quitPartyButton.BackColor = System.Drawing.Color.Red;
            this.quitPartyButton.ForeColor = System.Drawing.Color.Black;
            this.quitPartyButton.Location = new System.Drawing.Point(592, 256);
            this.quitPartyButton.Name = "quitPartyButton";
            this.quitPartyButton.Size = new System.Drawing.Size(75, 23);
            this.quitPartyButton.TabIndex = 2;
            this.quitPartyButton.Text = "Quit Party";
            this.quitPartyButton.UseVisualStyleBackColor = false;
            this.quitPartyButton.Click += new System.EventHandler(this.quitPartyButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Party Slogen:";
            // 
            // PartySlogenBox
            // 
            this.PartySlogenBox.Location = new System.Drawing.Point(506, 35);
            this.PartySlogenBox.Name = "PartySlogenBox";
            this.PartySlogenBox.ReadOnly = true;
            this.PartySlogenBox.Size = new System.Drawing.Size(154, 20);
            this.PartySlogenBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Party Name:";
            // 
            // PartyNameBox
            // 
            this.PartyNameBox.Location = new System.Drawing.Point(506, 8);
            this.PartyNameBox.Name = "PartyNameBox";
            this.PartyNameBox.ReadOnly = true;
            this.PartyNameBox.Size = new System.Drawing.Size(154, 20);
            this.PartyNameBox.TabIndex = 6;
            // 
            // MySlogenBox
            // 
            this.MySlogenBox.Location = new System.Drawing.Point(506, 61);
            this.MySlogenBox.Name = "MySlogenBox";
            this.MySlogenBox.ReadOnly = true;
            this.MySlogenBox.Size = new System.Drawing.Size(154, 20);
            this.MySlogenBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "My Slogen:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(135, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Your Colleagues:";
            // 
            // partyList
            // 
            this.partyList.BackColor = System.Drawing.Color.Snow;
            this.partyList.Location = new System.Drawing.Point(138, 126);
            this.partyList.Name = "partyList";
            this.partyList.Size = new System.Drawing.Size(92, 131);
            this.partyList.TabIndex = 12;
            this.partyList.UseCompatibleStateImageBehavior = false;
            this.partyList.View = System.Windows.Forms.View.List;
            // 
            // suggestSlogenButton
            // 
            this.suggestSlogenButton.BackColor = System.Drawing.Color.Yellow;
            this.suggestSlogenButton.Location = new System.Drawing.Point(6, 32);
            this.suggestSlogenButton.Name = "suggestSlogenButton";
            this.suggestSlogenButton.Size = new System.Drawing.Size(109, 23);
            this.suggestSlogenButton.TabIndex = 13;
            this.suggestSlogenButton.Text = "Suggest Slogen";
            this.suggestSlogenButton.UseVisualStyleBackColor = false;
            this.suggestSlogenButton.Visible = false;
            this.suggestSlogenButton.Click += new System.EventHandler(this.slogenChangeButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "RedDot.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgileProd.Properties.Resources.HappyKim;
            this.pictureBox1.Location = new System.Drawing.Point(182, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pickSlogenButton
            // 
            this.pickSlogenButton.BackColor = System.Drawing.Color.Yellow;
            this.pickSlogenButton.Location = new System.Drawing.Point(506, 91);
            this.pickSlogenButton.Name = "pickSlogenButton";
            this.pickSlogenButton.Size = new System.Drawing.Size(107, 23);
            this.pickSlogenButton.TabIndex = 33;
            this.pickSlogenButton.Text = "Pick Slogen";
            this.pickSlogenButton.UseVisualStyleBackColor = false;
            this.pickSlogenButton.Visible = false;
            // 
            // voteToYourSelfButton
            // 
            this.voteToYourSelfButton.BackColor = System.Drawing.Color.Yellow;
            this.voteToYourSelfButton.Location = new System.Drawing.Point(6, 5);
            this.voteToYourSelfButton.Name = "voteToYourSelfButton";
            this.voteToYourSelfButton.Size = new System.Drawing.Size(109, 23);
            this.voteToYourSelfButton.TabIndex = 34;
            this.voteToYourSelfButton.Text = "Vote to yourself";
            this.voteToYourSelfButton.UseVisualStyleBackColor = false;
            this.voteToYourSelfButton.Click += new System.EventHandler(this.voteToYourSelfButton_Click);
            // 
            // VoteToYourParty
            // 
            this.VoteToYourParty.BackColor = System.Drawing.Color.Yellow;
            this.VoteToYourParty.Location = new System.Drawing.Point(6, 59);
            this.VoteToYourParty.Name = "VoteToYourParty";
            this.VoteToYourParty.Size = new System.Drawing.Size(109, 23);
            this.VoteToYourParty.TabIndex = 35;
            this.VoteToYourParty.Text = "Vote to your party";
            this.VoteToYourParty.UseVisualStyleBackColor = false;
            this.VoteToYourParty.Click += new System.EventHandler(this.VoteToYourParty_Click);
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
            this.Text = "Member";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblWelcome, 0);
            this.Controls.SetChildIndex(this.btnAddMem, 0);
            this.Controls.SetChildIndex(this.tabMenu, 0);
            this.tabMenu.ResumeLayout(false);
            this.blankTab.ResumeLayout(false);
            this.blankTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnAddMem;
        private System.Windows.Forms.Button quitPartyButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PartySlogenBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MySlogenBox;
        private System.Windows.Forms.TextBox PartyNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView partyList;
        private System.Windows.Forms.Button suggestSlogenButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button pickSlogenButton;
        private System.Windows.Forms.Button voteToYourSelfButton;
        private System.Windows.Forms.Button VoteToYourParty;
    }
}