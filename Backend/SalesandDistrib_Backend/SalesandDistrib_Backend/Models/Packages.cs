﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesandDistrib_Backend.Models
{
    public class Packages
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int TotalUsers { get; set; }
        public int DurationPerMonth { get; set; }
        public int Bandwidth { get; set; }
    }
}
