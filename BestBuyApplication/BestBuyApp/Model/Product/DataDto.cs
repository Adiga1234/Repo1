using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuyApp.Model.Product
{
   public  class DataDto
    {
        public class DataDto
        {
            public int id { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public double price { get; set; }
            public string upc { get; set; }
            public int shipping { get; set; }
            public string description { get; set; }
            public string manufacturer { get; set; }
            public string model { get; set; }
            public string url { get; set; }
            public string image { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime updatedAt { get; set; }
            public List<CategoryDto> categories { get; set; }
        }
    }
}
