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
            this.slogenBox.Location = new System.Drawing.Point(32, 73);
            this.slogenBox.Name = "slogenBox";
            this.slogenBox.Size = new System.Drawing.Size(222, 20);
            this.slogenBox.TabIndex = 0;
            this.slogenBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // slogandirections
            // 
            this.slogandirections.AutoSize = true;
            this.slogandirections.Location = new System.Drawing.Point(29, 41);
            this.slogandirections.Name = "slogandirections";
            this.slogandirections.Size = new System.Drawing.Size(115, 13);
            this.slogandirections.TabIndex = 1;
            this.slogandirections.Text = "Enter your new slogen:";

            // 
            // Submmit
            // 
            this.Submmit.Location = new System.Drawing.Point(98, 116);
            this.Submmit.Name = "Submmit";
            this.Submmit.Size = new System.Drawing.Size(75, 23);
            this.Submmit.TabIndex = 2;
            this.Submmit.Text = "Submmit";
            this.Submmit.UseVisualStyleBackColor = true;
            this.Submmit.Click += new System.EventHandler(this.Submmit_Click);
            // 
            // SlogenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.Submmit);
            this.Controls.Add(this.slogandirections);
            this.Controls.Add(this.slogenBox);
            this.Name = "SlogenForm";
            this.Text = "Chenge The Slogen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox slogenBox;
        private System.Windows.Forms.Label slogandirections;
        private System.Windows.Forms.Button Submmit;
    }
}