using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuyAPITest.Model
{
    public class ProductDTO
    {

        public int total { get; set; }
        public int limit { get; set; }
        public int skip { get; set; }
        public List<DataDTO> data { get; set; }

    }
}
