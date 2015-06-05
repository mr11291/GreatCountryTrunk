namespace AgileProd
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
            this.userNameTip = new System.Windows.Forms.ToolTip(this.components);
            this.passwordTip = new System.Windows.Forms.ToolTip(this.components);
            this.muteButton = new System.Windows.Forms.PictureBox();
            this.infoBox2 = new System.Windows.Forms.PictureBox();
            this.infoBox1 = new System.Windows.Forms.PictureBox();
            this.HandShakeImage = new System.Windows.Forms.PictureBox();
            this.wrongToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.muteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HandShakeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.username.BackColor = System.Drawing.Color.Snow;
            this.username.Location = new System.Drawing.Point(120, 15);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 2;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Snow;
            this.password.Location = new System.Drawing.Point(120, 41);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 3;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Yellow;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnEnter.Location = new System.Drawing.Point(120, 67);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Log in";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // userNameTip
            // 
            this.userNameTip.AutoPopDelay = 5000;
            this.userNameTip.InitialDelay = 500;
            this.userNameTip.IsBalloon = true;
            this.userNameTip.ReshowDelay = 100;
            // 
            // passwordTip
            // 
            this.passwordTip.AutoPopDelay = 5000;
            this.passwordTip.InitialDelay = 500;
            this.passwordTip.IsBalloon = true;
            this.passwordTip.ReshowDelay = 100;
            // 
            // muteButton
            // 
            this.muteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muteButton.Image = global::AgileProd.Properties.Resources.MuteButton;
            this.muteButton.Location = new System.Drawing.Point(248, 422);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(33, 29);
            this.muteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.muteButton.TabIndex = 14;
            this.muteButton.TabStop = false;
            this.muteButton.Click += new System.EventHandler(this.muteButton_Click);
            // 
            // infoBox2
            // 
            this.infoBox2.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.infoBox1.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.HandShakeImage.Location = new System.Drawing.Point(-48, 96);
            this.HandShakeImage.Name = "HandShakeImage";
            this.HandShakeImage.Size = new System.Drawing.Size(369, 341);
            this.HandShakeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HandShakeImage.TabIndex = 7;
            this.HandShakeImage.TabStop = false;
            // 
            // wrongToolTip
            // 
            this.wrongToolTip.IsBalloon = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::AgileProd.Properties.Resources.NewIcon2;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 412);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(284, 454);
            this.Controls.Add(this.muteButton);
            this.Controls.Add(this.infoBox2);
            this.Controls.Add(this.infoBox1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HandShakeImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.muteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HandShakeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPass;
        public System.Windows.Forms.TextBox username;
        public System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.PictureBox HandShakeImage;
        private System.Windows.Forms.ToolTip userNameTip;
        private System.Windows.Forms.ToolTip passwordTip;
        private System.Windows.Forms.PictureBox infoBox1;
        private System.Windows.Forms.PictureBox infoBox2;
        private System.Windows.Forms.PictureBox muteButton;
        private System.Windows.Forms.ToolTip wrongToolTip;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

