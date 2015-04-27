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
            this.bankTab = new System.Windows.Forms.TabPage();
            this.messageTab = new System.Windows.Forms.TabPage();
            this.fromList = new System.Windows.Forms.ListView();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.tabMenu.SuspendLayout();
            this.messageTab.SuspendLayout();
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
            // bankTab
            // 
            this.bankTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bankTab.BackgroundImage = global::AgileProd.Properties.Resources.cashstack_op10;
            this.bankTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
            this.messageTab.BackgroundImage = global::AgileProd.Properties.Resources.cashenvelope_op15;
            this.messageTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.messageTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.messageTab.Controls.Add(this.fromList);
            this.messageTab.Location = new System.Drawing.Point(4, 22);
            this.messageTab.Name = "messageTab";
            this.messageTab.Size = new System.Drawing.Size(672, 284);
            this.messageTab.TabIndex = 4;
            this.messageTab.Text = "Messages";
            // 
            // fromList
            // 
            this.fromList.GridLines = true;
            this.fromList.Location = new System.Drawing.Point(1, 3);
            this.fromList.Name = "fromList";
            this.fromList.Size = new System.Drawing.Size(160, 276);
            this.fromList.TabIndex = 0;
            this.fromList.UseCompatibleStateImageBehavior = false;
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.settingsTab.BackgroundImage = global::AgileProd.Properties.Resources.wrench_op10;
            this.settingsTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(672, 284);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Settings";
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
            this.messageTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TabControl tabMenu;
        protected System.Windows.Forms.TabPage blankTab;
        protected System.Windows.Forms.TabPage settingsTab;
        protected System.Windows.Forms.TabPage bankTab;
        protected System.Windows.Forms.TabPage messageTab;
        private System.Windows.Forms.ListView fromList;

    }
}