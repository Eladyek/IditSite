using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TryProject.Models
{
    public class Session
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int ID { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
    }
}