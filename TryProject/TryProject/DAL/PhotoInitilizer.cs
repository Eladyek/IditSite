using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TryProject.Models;

namespace TryProject.DAL
{
    public class PhotoInitilizer : DropCreateDatabaseIfModelChanges<PhotoContext>
    {
        protected override void Seed(PhotoContext context)
        {
            var bitMap = new byte[] {0xAA, 0xBB, 0xCC};
            var pictures = new List<Picture>
            {
            new Picture{BitMap = bitMap,},
            new Picture{BitMap = bitMap, },
            new Picture{BitMap = bitMap, },
            new Picture{BitMap = bitMap,},
            new Picture{BitMap = bitMap, },
            };

            pictures.ForEach(s => context.Pictures.Add(s));
            context.SaveChanges();
            var location = new Location{Address = "ParkHayarkon"};
            var session = new Session { ID = 6, Date = DateTime.Now };

            location.Sessions.Add(session);
            session.Locations.Add(location);
            pictures.ForEach(pic=> session.Pictures.Add((pic)));
            context.Locations.Add(location);
            context.SaveChanges();

            context.Sessions.Add(session);
            context.SaveChanges();
        }
    }
}