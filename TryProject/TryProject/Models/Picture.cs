using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TryProject.Models
{
    public class Picture
    {
        public int ID { get; set; }
        public byte[] BitMap { get; set; }
        public Session Session { get; set; }
        public Location Location { get; set; }

    }
}