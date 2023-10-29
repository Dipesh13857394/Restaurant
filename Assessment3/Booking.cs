namespace Assessment3
{
    public partial class Booking : Form
    {
        public Booking( )
        {
            InitializeComponent();
        }

        private void InitializeComponent( )
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(224, 125);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(559, 125);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(413, 259);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Booking
            // 
            ClientSize = new Size(910, 388);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Booking";
            Text = "Booking";
            Load += Booking_Load;
            ResumeLayout(false);
        }

        private void Booking_Load(object sender, EventArgs e)
        {

        }
    }
}
