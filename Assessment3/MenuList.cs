﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment3
{
    public partial class MenuList : Form
    {
        public MenuList()
        {
            InitializeComponent();
            Menu menu = new Menu();

            foreach (string item in menu.menuList)
            {
                listBox1.Items.Add(item);
                //MessageBox.Show(item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Menu menu = new Menu();


            foreach (string item in menu.menuList)
            {

                listBox1.Items.Add(item);
                MessageBox.Show(item);
            }*/
            /*string filePath = "Menu.txt";
            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText("Menu.txt");
                richTextBox1.Text = fileContent;
            }
            else
            {
                richTextBox1.Text = "No File Found";
            }*/

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
