using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifyAPITest.SpotModel
{
  public class DataDto
    {
        public bool collaborative { get; set; }
        public string description { get; set; }
        public ExternalUrls external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public List<object> images { get; set; }
        public string name { get; set; }
        public Owner owner { get; set; }
        public object primary_color { get; set; }
        public bool @public { get; set; }
        public string snapshot_id { get; set; }
        public Tracks tracks { get; set; }
        public string type { get; set; }
        public string uri { get; set; }

    }
}
