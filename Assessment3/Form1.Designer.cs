namespace Assessment3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(552, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(50, 20);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Home";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(608, 9);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(46, 20);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Menu";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(660, 9);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(46, 20);
            linkLabel3.TabIndex = 2;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Login";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Location = new Point(712, 9);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(63, 20);
            linkLabel4.TabIndex = 3;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Register";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // label1
            // 
            label1.Font = new Font("Arial Black", 25.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(488, 147);
            label1.TabIndex = 4;
            label1.Text = "FLAMINGO RESTAURANT";
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(125, 170);
            label2.Name = "label2";
            label2.Size = new Size(518, 171);
            label2.TabIndex = 5;
            label2.Text = resources.GetString("label2.Text");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
        private Label label1;
        private Label label2;
    }
}