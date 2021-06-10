using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuyAPITest.SampleData
{
   public  class DemoJsontoDic
    {

        public void JsonDict()

        {

            Dictionary<string, object> data = new Dictionary<string, object>();
            Dictionary<string, string> address = new Dictionary<string, string>();
            Dictionary<string, string> phonenumber1 = new Dictionary<string, string>();
            Dictionary<string, string> phonenumber2 = new Dictionary<string, string>();

           phonenumber1.Add("type", "iphone");



         List < Dictionary<string,string>> allPhoneNumbers = new List<Dictionary<string, string>>();

            allPhoneNumbers.Add(phonenumber1);
            allPhoneNumbers.Add(phonenumber2);

            address.Add("streetAddress", "naist street");
            address.Add("city", "Nara");
                address.Add("postalCode", "630-0192");
  

            data.Add("firstName", "John");
            data.Add("lastName", "doe");
            data.Add("age", 26);
            data.Add("address",address);
            data.Add("phonenumber", allPhoneNumbers);
        }
    }
}
