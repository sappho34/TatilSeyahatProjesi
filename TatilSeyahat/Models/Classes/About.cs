﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahat.Models.Classes
{
    public class About
    {
       
        public int AboutId { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}