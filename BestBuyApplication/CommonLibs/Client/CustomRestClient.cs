using RestSharp;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CommonLibs.Client
{
    public class CustomRestClient
    {
        public IRestClient RestClient { get;  }

        public CustomRestClient()
        {

            RestClient = new RestClient();
        }

        public IRestResponse SendGetRequest(string endpointUrl)
        {
            RestRequest restrequest = new RestRequest(endpointUrl);
            IRestResponse restResponse= RestClient.Get(restrequest);
            return restResponse;
        }
        public IRestResponse SendGetRequest(string endpointUrl, Dictionary<string,object> queryParam)
        {
            RestRequest restrequest = new RestRequest(endpointUrl);
            IRestResponse restResponse = RestClient.Get(restrequest);
            return restResponse;
        }


        public IRestResponse SendGetRequest(string endpointUrl, Dictionary<string, object> queryParam,Dictionary<string,object> headers)
        {
            RestRequest restrequest = new RestRequest(endpointUrl);

            IRestResponse restResponse = RestClient.Get(restrequest);
            return restResponse;
        }

        private void addHeaders(RestRequest restRequest,Dictionary<string, object> headers)
        {

            foreach(var header in headers)
            {
                restRequest.AddParameter(header.Key, header.Value);
            }
        }





        /*


        public IRestResponse SendPostRequest(RestRequest, requestDictionary<string, object> queryParam, Dictionary<string, object> headers)
        {
            foreach (var param in queryParam)
            {
                request.AddParameter(param.Key, param.Value);
            }

            foreach (var header in headers)
            {
                request.AddParameter(header.Key, header.Value);
            }

            IRestResponse restResponse = RestClient.Get(request);
            return restResponse;)
    {


    }
    public IRestResponse SendPutRequest(RestRequest request)
    {


    }

    public IRestResponse SendPatchRequest(RestRequest request)
    {


    }

    public IRestResponse SendDeletetRequest(RestRequest request)
    {


    }*/




    }
}
