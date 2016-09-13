using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication85.Models
{
    public class User
    {
        public string name { get; set; }
        public int old { get; set; }

        public User()
        {
            name = string.Empty;
            old = 0;
        }
    }
}