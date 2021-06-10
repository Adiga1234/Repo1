using CommonLibs.Client;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuyApplicationTest.Request
{
  public  class Requestfactory
    {

        private CustomRestClient restClient;

        public Requestfactory(String endpointUrl)

        {
        this. endpointUrl=endpointUrl;
        restClient = new CustomRestClient();

        }

        public IRestResponse GetAllProduct()
        {
            IRestResponse response = restClient.SendGetRequest(endpointUrl);
            return response;
        }

      /*  public IRestResponse GetAllProduct(String endpointUrl,int limit,int skip)
        {
            Dictionary<string, object> queryParam = new Dictionay<string, object>();
            queryParam.Add("$limit", limit);
            queryParam.Add("$skip", skip);
            IRestResponse response = restClient.SendGetRequest(endpointUrl,queryParam);
        }*/


    }
}
