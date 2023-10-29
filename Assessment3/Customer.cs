using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    public class Customer
    {
        public string name { get; set; }
        public string email { get; set; } 
        public int phone { get; set; }
        public int id { get; set; }

        /*public Customer(string name, string email, int phone, int id) 
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.id = id;
        }*/
    }
}
