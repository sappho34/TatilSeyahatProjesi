﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahat.Models.Classes
{
    public class Main
    {
      
        public int MainId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}