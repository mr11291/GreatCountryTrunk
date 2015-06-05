namespace AgileProd
{
    partial class SlogenForm
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
            this.slogenBox = new System.Windows.Forms.TextBox();
            this.slogandirections = new System.Windows.Forms.Label();
            this.Submmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // slogenBox
            // 
            this.slogenBox.Location = new System.Drawing.Point(15, 34);
            this.slogenBox.Name = "slogenBox";
            this.slogenBox.Size = new System.Drawing.Size(222, 20);
            this.slogenBox.TabIndex = 0;
            this.slogenBox.TextChanged += new System.EventHandler(this.slogenBox_TextChanged);
            // 
            // slogandirections
            // 
            this.slogandirections.AutoSize = true;
            this.slogandirections.Location = new System.Drawing.Point(12, 9);
            this.slogandirections.Name = "slogandirections";
            this.slogandirections.Size = new System.Drawing.Size(149, 13);
            this.slogandirections.TabIndex = 1;
            this.slogandirections.Text = "Enter your new slogen please:";
            // 
            // Submmit
            // 
            this.Submmit.BackColor = System.Drawing.Color.Yellow;
            this.Submmit.Location = new System.Drawing.Point(97, 60);
            this.Submmit.Name = "Submmit";
            this.Submmit.Size = new System.Drawing.Size(75, 23);
            this.Submmit.TabIndex = 2;
            this.Submmit.Text = "Submit";
            this.Submmit.UseVisualStyleBackColor = false;
            this.Submmit.Click += new System.EventHandler(this.Submmit_Click);
            // 
            // SlogenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(252, 90);
            this.Controls.Add(this.Submmit);
            this.Controls.Add(this.slogandirections);
            this.Controls.Add(this.slogenBox);
            this.Name = "SlogenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slogen Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox slogenBox;
        private System.Windows.Forms.Label slogandirections;
        private System.Windows.Forms.Button Submmit;
    }
}