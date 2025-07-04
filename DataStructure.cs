using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    internal class DataStructure
    {
    }
    public class Province
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<City> Cities { get; set; } = new List<City>();
    }

    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<District> Districts { get; set; } = new List<District>();
    }

    public class District
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class PostInfo
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ReplyCount { get; set; }
        public string Url { get; set; }
    }
    public class LicensePlateResult
    {
        public string PlateNumber { get; set; }
        public Mat ProcessedImage { get; set; }
    }
}
