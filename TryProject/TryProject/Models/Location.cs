using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TryProject.Models
{
    public class Location
    {
        public int ID { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }
    }
}