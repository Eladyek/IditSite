using System;
using TryProject.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TryProject.DAL
{
    public class PhotoContext : DbContext
    {

        public PhotoContext() : base("PhotoContext")
        {
        }

        public DbSet<Picture> Pictures{ get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}