using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    internal class Menu
    {
        public List<string> menuList;
        public Menu()
        {
            menuList = new List<string>();
            if (File.Exists("Menu.txt"))
            {
                string[] filesContent = File.ReadAllLines("Menu.txt");
                foreach (string file in filesContent)
                {
                    menuList.Add(file);
                    

                }
            }
            else
            {
                MessageBox.Show("No file found");
            }
        }
    }
}
