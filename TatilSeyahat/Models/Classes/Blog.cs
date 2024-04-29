using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahat.Models.Classes
{
    public class Blog
    {

       
        public int BlogId { get; set; }
        public string Title { get; set;}
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string BlogImage { get; set; }
        public List<Comment> Comments { get; set; }  
    }
}