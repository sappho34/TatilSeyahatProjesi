using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TatilSeyahat.Models.Classes
{
    public class Adress
    {
        public int AdressId { get; set; }
        public string Title { get; set;}
        public string Description { get; set;}
        public string AdressInfo { get; set;}
        public string Mail {  get; set;}
        public string Phone {  get; set;}
        public string Location { get; set;}
    }
}