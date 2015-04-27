namespace AgileProd
{
    partial class BaseForm
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
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.blankTab = new System.Windows.Forms.TabPage();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.bankTab = new System.Windows.Forms.TabPage();
            this.messageTab = new System.Windows.Forms.TabPage();
            this.tabMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.blankTab);
            this.tabMenu.Controls.Add(this.bankTab);
            this.tabMenu.Controls.Add(this.messageTab);
            this.tabMenu.Controls.Add(this.settingsTab);
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(680, 310);
            this.tabMenu.TabIndex = 0;
            // 
            // blankTab
            // 
            this.blankTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.blankTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.blankTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.blankTab.Location = new System.Drawing.Point(4, 22);
            this.blankTab.Name = "blankTab";
            this.blankTab.Padding = new System.Windows.Forms.Padding(3);
            this.blankTab.Size = new System.Drawing.Size(672, 284);
            this.blankTab.TabIndex = 1;
            this.blankTab.Text = "Blank";
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.settingsTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(672, 284);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Settings";
            // 
            // bankTab
            // 
            this.bankTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bankTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bankTab.Location = new System.Drawing.Point(4, 22);
            this.bankTab.Name = "bankTab";
            this.bankTab.Size = new System.Drawing.Size(672, 284);
            this.bankTab.TabIndex = 3;
            this.bankTab.Text = "Bank Account";
            // 
            // messageTab
            // 
            this.messageTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.messageTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.messageTab.Location = new System.Drawing.Point(4, 22);
            this.messageTab.Name = "messageTab";
            this.messageTab.Size = new System.Drawing.Size(672, 284);
            this.messageTab.TabIndex = 4;
            this.messageTab.Text = "Messages";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 312);
            this.Controls.Add(this.tabMenu);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.tabMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage blankTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.TabPage bankTab;
        private System.Windows.Forms.TabPage messageTab;

    }
}