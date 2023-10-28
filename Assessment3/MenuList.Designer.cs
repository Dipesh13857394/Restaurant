namespace Assessment3
{
    partial class MenuList
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
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            menuStrip1 = new MenuStrip();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(662, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(50, 20);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Home";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(718, 9);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(46, 20);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Login";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(23, 115);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(741, 284);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // MenuList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuList";
            Text = "MenuList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private MenuStrip menuStrip1;
        private ListBox listBox1;
    }
}