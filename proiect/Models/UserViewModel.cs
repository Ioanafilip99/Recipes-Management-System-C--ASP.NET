﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace proiect.Models
{
    public class UserViewModel
    {
        public ApplicationUser User { get; set; }
        public string RoleName { get; set; }
    }
}