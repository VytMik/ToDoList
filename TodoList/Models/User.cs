﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Models
{
    public class User : IdentityUser
    {
        public List<Record> Records { get; set; }
    }
}
