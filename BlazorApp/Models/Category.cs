﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class Category
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
    }
}
