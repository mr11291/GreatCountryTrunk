﻿namespace AgileProd
{
    partial class LoginForm
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblCreateVol = new System.Windows.Forms.LinkLabel();
            this.inputWarning = new System.Windows.Forms.Label();
            this.enterperson = new System.Windows.Forms.Button();
            this.entercommittee = new System.Windows.Forms.Button();
            this.entermember = new System.Windows.Forms.Button();
            this.enteradmin = new System.Windows.Forms.Button();
            this.userNameTip = new System.Windows.Forms.ToolTip(this.components);
            this.passwordTip = new System.Windows.Forms.ToolTip(this.components);
            this.infoBox2 = new System.Windows.Forms.PictureBox();
            this.infoBox1 = new System.Windows.Forms.PictureBox();
            this.HandShakeImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.infoBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HandShakeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(51, 18);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(63, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "User Name:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(51, 44);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(56, 13);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(120, 15);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(120, 41);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 3;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnEnter.Location = new System.Drawing.Point(120, 104);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Log in";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblCreateVol
            // 
            this.lblCreateVol.AutoSize = true;
            this.lblCreateVol.Location = new System.Drawing.Point(12, 474);
            this.lblCreateVol.Name = "lblCreateVol";
            this.lblCreateVol.Size = new System.Drawing.Size(63, 13);
            this.lblCreateVol.TabIndex = 5;
            this.lblCreateVol.TabStop = true;
            this.lblCreateVol.Text = "Create User";
            // 
            // inputWarning
            // 
            this.inputWarning.AutoSize = true;
            this.inputWarning.ForeColor = System.Drawing.Color.Red;
            this.inputWarning.Location = new System.Drawing.Point(51, 74);
            this.inputWarning.Name = "inputWarning";
            this.inputWarning.Size = new System.Drawing.Size(170, 13);
            this.inputWarning.TabIndex = 6;
            this.inputWarning.Text = "username or password is incorrect!";
            this.inputWarning.Visible = false;
            // 
            // enterperson
            // 
            this.enterperson.Location = new System.Drawing.Point(234, 166);
            this.enterperson.Name = "enterperson";
            this.enterperson.Size = new System.Drawing.Size(47, 23);
            this.enterperson.TabIndex = 8;
            this.enterperson.Text = "person";
            this.enterperson.UseVisualStyleBackColor = true;
            this.enterperson.Click += new System.EventHandler(this.enterperson_Click);
            // 
            // entercommittee
            // 
            this.entercommittee.Location = new System.Drawing.Point(216, 224);
            this.entercommittee.Name = "entercommittee";
            this.entercommittee.Size = new System.Drawing.Size(65, 23);
            this.entercommittee.TabIndex = 9;
            this.entercommittee.Text = "committee";
            this.entercommittee.UseVisualStyleBackColor = true;
            this.entercommittee.Click += new System.EventHandler(this.entercommittee_Click);
            // 
            // entermember
            // 
            this.entermember.Location = new System.Drawing.Point(226, 195);
            this.entermember.Name = "entermember";
            this.entermember.Size = new System.Drawing.Size(55, 23);
            this.entermember.TabIndex = 10;
            this.entermember.Text = "member";
            this.entermember.UseVisualStyleBackColor = true;
            this.entermember.Click += new System.EventHandler(this.entermember_Click);
            // 
            // enteradmin
            // 
            this.enteradmin.Location = new System.Drawing.Point(234, 139);
            this.enteradmin.Name = "enteradmin";
            this.enteradmin.Size = new System.Drawing.Size(47, 21);
            this.enteradmin.TabIndex = 11;
            this.enteradmin.Text = "admin";
            this.enteradmin.UseVisualStyleBackColor = true;
            this.enteradmin.Click += new System.EventHandler(this.enteradmin_Click);
            // 
            // userNameTip
            // 
            this.userNameTip.IsBalloon = true;
            this.userNameTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // passwordTip
            // 
            this.passwordTip.IsBalloon = true;
            this.passwordTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // infoBox2
            // 
            this.infoBox2.Image = global::AgileProd.Properties.Resources.InfoIcon;
            this.infoBox2.Location = new System.Drawing.Point(226, 44);
            this.infoBox2.Name = "infoBox2";
            this.infoBox2.Size = new System.Drawing.Size(25, 20);
            this.infoBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoBox2.TabIndex = 13;
            this.infoBox2.TabStop = false;
            this.infoBox2.Click += new System.EventHandler(this.infoBox2_Click);
            // 
            // infoBox1
            // 
            this.infoBox1.Image = global::AgileProd.Properties.Resources.InfoIcon;
            this.infoBox1.Location = new System.Drawing.Point(226, 18);
            this.infoBox1.Name = "infoBox1";
            this.infoBox1.Size = new System.Drawing.Size(25, 20);
            this.infoBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoBox1.TabIndex = 12;
            this.infoBox1.TabStop = false;
            this.infoBox1.Click += new System.EventHandler(this.infoBox1_Click);
            // 
            // HandShakeImage
            // 
            this.HandShakeImage.Image = global::AgileProd.Properties.Resources.KimLogoSmaller;
            this.HandShakeImage.Location = new System.Drawing.Point(-37, 130);
            this.HandShakeImage.Name = "HandShakeImage";
            this.HandShakeImage.Size = new System.Drawing.Size(369, 341);
            this.HandShakeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HandShakeImage.TabIndex = 7;
            this.HandShakeImage.TabStop = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(284, 492);
            this.Controls.Add(this.infoBox2);
            this.Controls.Add(this.infoBox1);
            this.Controls.Add(this.enteradmin);
            this.Controls.Add(this.entermember);
            this.Controls.Add(this.entercommittee);
            this.Controls.Add(this.enterperson);
            this.Controls.Add(this.inputWarning);
            this.Controls.Add(this.lblCreateVol);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.HandShakeImage);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.infoBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HandShakeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.LinkLabel lblCreateVol;
        private System.Windows.Forms.Label inputWarning;
        private System.Windows.Forms.PictureBox HandShakeImage;
        private System.Windows.Forms.Button enterperson;
        private System.Windows.Forms.Button entercommittee;
        private System.Windows.Forms.Button entermember;
        private System.Windows.Forms.Button enteradmin;
        private System.Windows.Forms.ToolTip userNameTip;
        private System.Windows.Forms.ToolTip passwordTip;
        private System.Windows.Forms.PictureBox infoBox1;
        private System.Windows.Forms.PictureBox infoBox2;
    }
}

