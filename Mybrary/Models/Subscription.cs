using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mybrary.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Subscription
    {
        public int SubscriptionID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

     
    }
}