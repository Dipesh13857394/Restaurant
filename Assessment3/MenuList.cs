using System;
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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            Console.WriteLine("Here");
            foreach (string item in menu.menuList)
            {

                listBox1.Items.Add(item);
                MessageBox.Show("Adding data from file");
            }
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
    }
}
