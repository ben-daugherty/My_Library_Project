using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mybrary.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublishDate { get; set; }

        public virtual ICollection<Subscription> Subscriptions { get; set; }




    }
}