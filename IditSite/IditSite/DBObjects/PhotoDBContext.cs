using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IditSite.DBObjects
{
    public class PhotoDBContext : DbContext
    {
        public PhotoDBContext() : base()
        {
        }

        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Session> Sessions { get; set; }
    }
}
