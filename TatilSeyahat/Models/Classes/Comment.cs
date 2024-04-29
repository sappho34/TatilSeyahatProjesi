using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahat.Models.Classes
{
    public class Comment
    {
       
        public int CommentId { get; set; }
        public string UserName { get; set; }    
        public string UserEmail { get; set; }
        public string Comments { get; set; }  
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
        
    }
}