﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password  { get; set; }
        public string NameSurname { get; set; }
        public string PhoneNumber { get; set; }
        public string Address{ get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public int BestScore = 0;
    }
}