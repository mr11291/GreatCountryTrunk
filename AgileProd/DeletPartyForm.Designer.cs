namespace AgileProd
{
    partial class DeletPartyForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inputWarning = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.inputWarning2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "please enter the name of the party:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inputWarning
            // 
            this.inputWarning.AutoSize = true;
            this.inputWarning.ForeColor = System.Drawing.Color.Brown;
            this.inputWarning.Location = new System.Drawing.Point(53, 72);
            this.inputWarning.Name = "inputWarning";
            this.inputWarning.Size = new System.Drawing.Size(242, 13);
            this.inputWarning.TabIndex = 2;
            this.inputWarning.Text = "that party dosn\'t ecxist please insert another name";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Yellow;
            this.Delete.Location = new System.Drawing.Point(120, 88);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // inputWarning2
            // 
            this.inputWarning2.AutoSize = true;
            this.inputWarning2.ForeColor = System.Drawing.Color.Brown;
            this.inputWarning2.Location = new System.Drawing.Point(256, 56);
            this.inputWarning2.Name = "inputWarning2";
            this.inputWarning2.Size = new System.Drawing.Size(70, 13);
            this.inputWarning2.TabIndex = 4;
            this.inputWarning2.Text = "insert a party ";
            // 
            // DeletPartyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(342, 131);
            this.Controls.Add(this.inputWarning2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.inputWarning);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "DeletPartyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Party";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label inputWarning;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label inputWarning2;
    }
}