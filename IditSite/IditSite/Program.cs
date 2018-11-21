using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using IditSite.DBObjects;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace IditSite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var ctx = new PhotoDBContext())
            {
                var location = new Location() {Adress = "gidoon 2//7", LocationID = "123456"};
                var session = new Session() {Location = location, SessionID = "ParkHaYarkon"};
                ctx.Locations.Add(location);
                ctx.Sessions.Add(session);
                ctx.SaveChanges();

            }
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
