﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstWebApp.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
    }
}