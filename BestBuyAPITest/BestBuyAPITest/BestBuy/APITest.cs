using BestBuyAPITest.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;

namespace BestBuyAPITest.BestBuy
{

    [TestClass]
    public class APITest
    {

       private string baseUrl = "http://ec2-18-223-213-189.us-east-2.compute.amazonaws.com";

        private int portNumber = 3030;
        private string productEndpointUrl = "/products";
        private string endpointUrl;

        IRestClient restClient;

        [TestInitialize]

        public void SetUp()

        {
            restClient = new RestClient();
            endpointUrl = $"{baseUrl}:{portNumber}{productEndpointUrl}";

        }

        [TestMethod]

        public void VerifyGetProductAPI()

        {

            //1. IresrClient--->RestCleint ---->this is the client which send the request

            //2, IRestrequest--->RestRequest--->this is used to prepare RestRequest
            //3. IRestResponse-->RestResponse --->it represents the response

            //process

            //1. Initialize IRestClient and IRestRequest
            //2. Prepare the request
            //3. Send the request
            // 4. Receive the Response
            //5. Process the response
            //6. validate(add assertion) the response.
            IRestRequest restRequest = new RestRequest(endpointUrl);

           IRestResponse restResponse= restClient.Get(restRequest);
            Console.WriteLine(restResponse.Content);
            Assert.AreEqual(HttpStatusCode.OK,restResponse.StatusCode);
            Assert.AreEqual(200, (int)restResponse.StatusCode);

        }

        [TestMethod]


        public void VerifygetproductWithQueryParam()

        {

            int limit = 5;
            IRestRequest restRequest = new RestRequest(endpointUrl);
            restRequest.AddParameter("$limit", limit);
            IRestResponse restResponse = restClient.Get(restRequest);
            Assert.AreEqual(HttpStatusCode.OK, restResponse.StatusCode);
        }


       /* [TestMethod]
        public void VerifygetproductWithQuerypathParam()

        {

            //int limit = 5;
            int productID = 52029;
            IRestRequest restRequest = new RestRequest($"{endpointUrl}/{productID}");
           //restRequest.AddParameter("$limit", limit);
            IRestResponse restResponse = restClient.Get(restRequest);
            Assert.AreEqual(HttpStatusCode.OK, restResponse.StatusCode);
        }
        */
        [TestMethod]


        public void VerifygetproductWithQueryParamAndDeserialiseResponse()

        {

            int limit = 5;
            IRestRequest restRequest = new RestRequest(endpointUrl);
            restRequest.AddParameter("$limit", limit);
            IRestResponse<ProductDTO> restResponse = restClient.Get<ProductDTO>(restRequest);
            Assert.AreEqual(HttpStatusCode.OK, restResponse.StatusCode);
            Assert.AreEqual(limit, restResponse.Data.limit);
            Console.WriteLine(restResponse.Data.data[0].id);


        }

        [TestMethod]
        public void VerifyPostProduct()
        {
            IRestRequest restRequest = new RestRequest(endpointUrl);
            string requestPayload = "{\r\n \"name\": \"Samsung Mobile Model 0001\",\r\n \"type\": \"Mobile\",\r\n \"price\": 100,\r\n \"shipping\": 10,\r\n \"upc\": \"Best Mobile\",\r\n \"description\": \"Best Samsung Mobile\",\r\n \"manufacturer\": \"string\",\r\n \"model\": \"string\",\r\n \"url\": \"string\",\r\n \"image\": \"string\"\r\n}";

            restRequest.AddJsonBody(requestPayload);
            
            
            IRestResponse<DataDTO> restResponse = restClient.Post<DataDTO>(restRequest);
            Assert.AreEqual(HttpStatusCode.Created, restResponse.StatusCode);
            Console.WriteLine(restResponse.Data.id);
        }

        [TestMethod]
        public void VerifyPostProductWithRequestPayloadAsDictionary()
        {
            IRestRequest restRequest = new RestRequest(endpointUrl);
            Dictionary<string, object> requestpayload = new Dictionary<string, object>();
            requestpayload.Add("name", "Samsung Mobile Model 3333");
            requestpayload.Add("type", "Mobile");
            requestpayload.Add("price", 100);
            requestpayload.Add("shipping", 10);
            requestpayload.Add("upc", "Best Mobile");
            requestpayload.Add("description", "Best Samsung Mobile");
            requestpayload.Add("manufacturer", "string");
            requestpayload.Add("model", "string");
            requestpayload.Add("url", "string");
            requestpayload.Add("image", "string");
            restRequest.AddJsonBody(requestpayload);
            IRestResponse <DataDTO>restResponse = restClient.Post<DataDTO>(restRequest);
            Assert.AreEqual(HttpStatusCode.Created, restResponse.StatusCode);
           // IRestResponse<Data> restResponse = restClient.Post<Data>(restRequest);
            //Console.WriteLine(restResponse.Data.id);
        }
        [TestMethod]
        public void VerifypostproductRequestwithPayloadasDTO()//classobject

        {
            

            IRestRequest restRequest = new RestRequest(endpointUrl);
            ParentdataDTO requestpayload = new ParentdataDTO();
            requestpayload.name = "Test1";
            requestpayload.type = "Iphone";
            restRequest.AddJsonBody(requestpayload);
            IRestResponse<DataDTO> restResponse = restClient.Post<DataDTO>(restRequest);
            Assert.AreEqual(HttpStatusCode.Created, restResponse.StatusCode);
            Console.WriteLine(restResponse.Data.id);

        }
        [TestMethod]

        public void VerifypostproductRequestinaFile()

        {


            IRestRequest restRequest = new RestRequest(endpointUrl);
            string requestpayload = File.ReadAllText("C:/Users/G748/source/repos/BestBuyAPITest/BestBuyAPITest/Testdata/productfile.json");
            
            restRequest.AddJsonBody(requestpayload);
            IRestResponse<DataDTO> restResponse = restClient.Post<DataDTO>(restRequest);
            Assert.AreEqual(HttpStatusCode.Created, restResponse.StatusCode);
            Console.WriteLine(restResponse.Data.id);

        }

        [TestMethod]

        public void VerifypostproductRequestFile()

        {


            IRestRequest restRequest = new RestRequest(endpointUrl);
            string requestpayload = File.ReadAllText("C:/Users/G748/source/repos/BestBuyAPITest/BestBuyAPITest/Testdata/productfile.json");

            restRequest.AddJsonBody(requestpayload);
            IRestResponse<DataDTO> restResponse = restClient.Post<DataDTO>(restRequest);
            Assert.AreEqual(HttpStatusCode.Created, restResponse.StatusCode);
            Console.WriteLine(restResponse.Data.id);

        }
    }
}
