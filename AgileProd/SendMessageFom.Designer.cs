namespace AgileProd
{
    partial class SendMessageFom
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
            this.bribeOfferBox = new System.Windows.Forms.TextBox();
            this.moneytrackBar = new System.Windows.Forms.TrackBar();
            this.currentMoneyBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.messageMenu = new System.Windows.Forms.TabControl();
            this.bribeTab = new System.Windows.Forms.TabPage();
            this.jobTab = new System.Windows.Forms.TabPage();
            this.jobOfferBox = new System.Windows.Forms.TextBox();
            this.regularMessageBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.moneytrackBar)).BeginInit();
            this.messageMenu.SuspendLayout();
            this.bribeTab.SuspendLayout();
            this.jobTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // bribeOfferBox
            // 
            this.bribeOfferBox.BackColor = System.Drawing.Color.Snow;
            this.bribeOfferBox.Location = new System.Drawing.Point(3, 4);
            this.bribeOfferBox.Multiline = true;
            this.bribeOfferBox.Name = "bribeOfferBox";
            this.bribeOfferBox.ReadOnly = true;
            this.bribeOfferBox.Size = new System.Drawing.Size(467, 113);
            this.bribeOfferBox.TabIndex = 1;
            this.bribeOfferBox.Visible = false;
            // 
            // moneytrackBar
            // 
            this.moneytrackBar.Location = new System.Drawing.Point(213, 166);
            this.moneytrackBar.Name = "moneytrackBar";
            this.moneytrackBar.Size = new System.Drawing.Size(280, 45);
            this.moneytrackBar.TabIndex = 2;
            this.moneytrackBar.Visible = false;
            this.moneytrackBar.Scroll += new System.EventHandler(this.moneytrackBar_Scroll);
            // 
            // currentMoneyBox
            // 
            this.currentMoneyBox.BackColor = System.Drawing.Color.Snow;
            this.currentMoneyBox.Location = new System.Drawing.Point(317, 195);
            this.currentMoneyBox.Name = "currentMoneyBox";
            this.currentMoneyBox.Size = new System.Drawing.Size(70, 20);
            this.currentMoneyBox.TabIndex = 5;
            this.currentMoneyBox.Visible = false;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.Yellow;
            this.sendButton.Location = new System.Drawing.Point(12, 192);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Yellow;
            this.cancelButton.Location = new System.Drawing.Point(93, 192);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(220, 198);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(13, 13);
            this.minLabel.TabIndex = 8;
            this.minLabel.Text = "1";
            this.minLabel.Visible = false;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(449, 198);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(52, 13);
            this.maxLabel.TabIndex = 9;
            this.maxLabel.Text = "maxLabel";
            this.maxLabel.Visible = false;
            // 
            // messageMenu
            // 
            this.messageMenu.Controls.Add(this.bribeTab);
            this.messageMenu.Controls.Add(this.jobTab);
            this.messageMenu.Location = new System.Drawing.Point(12, 13);
            this.messageMenu.Name = "messageMenu";
            this.messageMenu.SelectedIndex = 0;
            this.messageMenu.Size = new System.Drawing.Size(480, 147);
            this.messageMenu.TabIndex = 10;
            this.messageMenu.Visible = false;
            // 
            // bribeTab
            // 
            this.bribeTab.Controls.Add(this.bribeOfferBox);
            this.bribeTab.Location = new System.Drawing.Point(4, 22);
            this.bribeTab.Name = "bribeTab";
            this.bribeTab.Padding = new System.Windows.Forms.Padding(3);
            this.bribeTab.Size = new System.Drawing.Size(472, 121);
            this.bribeTab.TabIndex = 0;
            this.bribeTab.Text = "Bribe";
            this.bribeTab.UseVisualStyleBackColor = true;
            // 
            // jobTab
            // 
            this.jobTab.Controls.Add(this.jobOfferBox);
            this.jobTab.Location = new System.Drawing.Point(4, 22);
            this.jobTab.Name = "jobTab";
            this.jobTab.Padding = new System.Windows.Forms.Padding(3);
            this.jobTab.Size = new System.Drawing.Size(472, 121);
            this.jobTab.TabIndex = 1;
            this.jobTab.Text = "Job Offer";
            this.jobTab.UseVisualStyleBackColor = true;
            // 
            // jobOfferBox
            // 
            this.jobOfferBox.BackColor = System.Drawing.Color.Snow;
            this.jobOfferBox.Location = new System.Drawing.Point(3, 4);
            this.jobOfferBox.Multiline = true;
            this.jobOfferBox.Name = "jobOfferBox";
            this.jobOfferBox.ReadOnly = true;
            this.jobOfferBox.Size = new System.Drawing.Size(467, 113);
            this.jobOfferBox.TabIndex = 2;
            this.jobOfferBox.Visible = false;
            // 
            // regularMessageBox
            // 
            this.regularMessageBox.BackColor = System.Drawing.Color.Red;
            this.regularMessageBox.Location = new System.Drawing.Point(12, 12);
            this.regularMessageBox.Multiline = true;
            this.regularMessageBox.Name = "regularMessageBox";
            this.regularMessageBox.Size = new System.Drawing.Size(481, 148);
            this.regularMessageBox.TabIndex = 11;
            this.regularMessageBox.Visible = false;
            // 
            // SendMessageFom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(504, 222);
            this.Controls.Add(this.messageMenu);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.currentMoneyBox);
            this.Controls.Add(this.moneytrackBar);
            this.Controls.Add(this.regularMessageBox);
            this.Name = "SendMessageFom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendMessageFom";
            ((System.ComponentModel.ISupportInitialize)(this.moneytrackBar)).EndInit();
            this.messageMenu.ResumeLayout(false);
            this.bribeTab.ResumeLayout(false);
            this.bribeTab.PerformLayout();
            this.jobTab.ResumeLayout(false);
            this.jobTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bribeOfferBox;
        private System.Windows.Forms.TrackBar moneytrackBar;
        private System.Windows.Forms.TextBox currentMoneyBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TabControl messageMenu;
        private System.Windows.Forms.TabPage bribeTab;
        private System.Windows.Forms.TabPage jobTab;
        private System.Windows.Forms.TextBox jobOfferBox;
        private System.Windows.Forms.TextBox regularMessageBox;
    }
}