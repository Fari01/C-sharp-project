using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class customer
    {
        public string First_name { get; set; }
        public string Last_name{ get; set; }
        public string Email  { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}