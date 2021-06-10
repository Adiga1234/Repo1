using BestBuyApplicationTest.Request;
using CommonLibs.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace BestBuyApplicationTest.Tests.ProdctAPITest
{
    [TestClass]
   public class ProductAPITest
    {

        private string baseUrl = "http://ec2-18-223-213-189.us-east-2.compute.amazonaws.com";

        private int portNumber = 3030;
        private string productEndpointUrl = "/products";
        private string endpointUrl;
        Requestfactory productRequestFactory;

       [TestInitialize]

       public void Setup()
        {
            endpointUrl = ($"{baseUrl}:{portNumber}productEndpointUrl");
            productRequestFactory = new Requestfactory();

        }

        [TestMethod]

        public void VerifyGetProductAPI()

        {

                      //IRestRequest restRequest = new RestRequest(endpointUrl);

            IRestResponse restResponse = productRequestFactory.GetAllProduct();
            Console.WriteLine(restResponse.Content);
            Assert.AreEqual(HttpStatusCode.OK, restResponse.StatusCode);
            Assert.AreEqual(200, (int)restResponse.StatusCode);

        }
    }
}
