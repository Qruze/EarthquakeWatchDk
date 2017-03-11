using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace EarthquakeWatchDk.Data
{
    public class GeusDataHelper
    {

        public List<Geuss> LoadJson()
        {
            List<Geuss> geuss = new List<Geuss>();
            
            using (StreamReader r = new StreamReader(@"D:\Documents\GitHub\EarthquakeWatchDk\EarthquakeWatchDk\Data\GeussData.json"))
            {
                string json = r.ReadToEnd();
                geuss = JsonConvert.DeserializeObject<List<Geuss>>(json);
            }

            return geuss;
        }

    }

    public class GeussData
    {
        public Geuss[] data { get; set; }
    }

    public class Geuss
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Min { get; set; }
        public float Second { get; set; }
        public float North { get; set; }
        public float East { get; set; }
        public float Depthkm { get; set; }
        public float Richtertal { get; set; }
    }

   
}