using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifyAPITest.SpotModel
{
    public class PDto
    {
        public string href { get; set; }
        public List<DataDto> items { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
        public int offset { get; set; }
        public object previous { get; set; }
        public int total { get; set; }

    }
}
