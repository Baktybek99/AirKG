using System.Collections.Generic;
using System;
using AirKG.Entity;
using System.Security.Permissions;

namespace AirKG.ViewModels.Markers
{
    public class MapModel
    {
        public List<Tuple<int, int, string>> Markers { get; set; }

        public IEnumerable<SensorVM> Sensors { get; set; }
        

        public MapModel()
        {
            Markers = new List<Tuple<int, int, string>>();
            Markers.Add(Tuple.Create(100, 200, "https://example.com/street1"));
            Markers.Add(Tuple.Create(300, 400, "https://example.com/street2"));
        }
    }
}
