using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Assessment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();

        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenuList menuList = new MenuList();
            //below code works
            /*string filePath = "Menu.txt";
            if(File.Exists(filePath))
            {
                string[] menuItems = File.ReadAllLines(filePath);
                MessageBox.Show(menuItems[0]);

            }
            else
            {
                MessageBox.Show("File not found");
            }*/

            this.Hide();
            menuList.Show();



        }


        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();

        }

       
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}