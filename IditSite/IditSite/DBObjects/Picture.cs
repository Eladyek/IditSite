using System;

namespace IditSite.DBObjects
{
    public class Picture
    {
        public byte[] BitMap { get; set; }
        public string Path { get; set; }
        public string PictureID { get; set; }
        public Location Location { get; set; }
        public Session Sassion { get; set; }
    }

}
