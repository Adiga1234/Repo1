using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuyAPITest.Model
{
    public class JsonDictionary
    {

public void JsonDicti()

        {

     
               Dictionary<string, object> product = new Dictionary<string, object>();

            Dictionary<string, object> data1 = new Dictionary<string, object>();
            Dictionary<string, object> data2 = new Dictionary<string, object>();
            Dictionary<string, object> category1 = new Dictionary<string, object>();
            Dictionary<string, object> category2 = new Dictionary<string, object>();


            List<Dictionary<string, object>> allCategories = new List<Dictionary<string, object>>();
            
            data1.Add("id", 150115);
                       
            data1.Add("updatedAt", 2016-11-17);
            data1.Add("categories", allCategories);
            allCategories.Add(category1);

                 List<Dictionary<string, object>> allData = new List<Dictionary<string, object>>();
            allData.Add(data1);

            product.Add("total", 51967);
            product.Add("limit", 1);
            product.Add("data",allData);
            
            data1.Add("categories", allCategories);
            category1.Add("id","abcat0208002");
            category1.Add("name", "Alkaline Batteries");
            category1.Add("createdAt", "2016-11-17T17:57:04.285Z");
            category1.Add("updatedAt", "2016-11-17T17:57:04.285Z");
            


        }


    }
}
