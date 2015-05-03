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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PartySlogenBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PartyNameBox = new System.Windows.Forms.TextBox();
            this.MySlogenBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.button6 = new System.Windows.Forms.Button();
            this.tabMenu.SuspendLayout();
            this.blankTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // blankTab
            // 
            this.blankTab.Controls.Add(this.button6);
            this.blankTab.Controls.Add(this.listView2);
            this.blankTab.Controls.Add(this.label6);
            this.blankTab.Controls.Add(this.button5);
            this.blankTab.Controls.Add(this.button4);
            this.blankTab.Controls.Add(this.label5);
            this.blankTab.Controls.Add(this.MySlogenBox);
            this.blankTab.Controls.Add(this.PartyNameBox);
            this.blankTab.Controls.Add(this.label3);
            this.blankTab.Controls.Add(this.PartySlogenBox);
            this.blankTab.Controls.Add(this.label2);
            this.blankTab.Controls.Add(this.button3);
            this.blankTab.Controls.Add(this.button2);
            this.blankTab.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vote";
            this.button1.UseVisualStyleBackColor = true;
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
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(8, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Quit Party";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Party Slogen:";
            // 
            // PartySlogenBox
            // 
            this.PartySlogenBox.Location = new System.Drawing.Point(268, 35);
            this.PartySlogenBox.Name = "PartySlogenBox";
            this.PartySlogenBox.Size = new System.Drawing.Size(154, 20);
            this.PartySlogenBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Party Name:";
            // 
            // PartyNameBox
            // 
            this.PartyNameBox.Location = new System.Drawing.Point(268, 10);
            this.PartyNameBox.Name = "PartyNameBox";
            this.PartyNameBox.Size = new System.Drawing.Size(154, 20);
            this.PartyNameBox.TabIndex = 6;
            // 
            // MySlogenBox
            // 
            this.MySlogenBox.Location = new System.Drawing.Point(268, 61);
            this.MySlogenBox.Name = "MySlogenBox";
            this.MySlogenBox.Size = new System.Drawing.Size(154, 20);
            this.MySlogenBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "My Slogen:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(446, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 20);
            this.button4.TabIndex = 9;
            this.button4.Text = "Suggest To Leader";
            this.button4.UseVisualStyleBackColor = true;
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
            this.label6.Location = new System.Drawing.Point(285, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Your Party Members:";
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(234, 111);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(227, 131);
            this.listView2.TabIndex = 12;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(446, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Change My Slogen";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PartySlogenBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MySlogenBox;
        private System.Windows.Forms.TextBox PartyNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button button6;
    }
}