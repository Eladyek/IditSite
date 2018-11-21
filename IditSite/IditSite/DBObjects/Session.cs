using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IditSite.DBObjects
{
    public class Session
    {
        public string SessionID { get; set; }
        public Location Location { get; set; }
        public ICollection<Picture> Pictures { get; set; }
    }
}
