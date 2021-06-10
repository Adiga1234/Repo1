using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuyAPITest.Model
{
   public class DataDTO: ParentdataDTO
    {
        public int id { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public List<CategoryDTO> categories { get; set; }

    }
}
