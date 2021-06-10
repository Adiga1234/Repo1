using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using SpotifyAPITest.SpotModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;





namespace SpotifyAPITest

{
    [TestClass]
    public class SpotifyAPI
    {

        private string playlistEndpoint = "https://api.spotify.com/v1/users/ohlwq5x132vjuyfmlbv4d49rd/playlists";


        private string accesstoken = "Bearer BQDey26rRsNBaM7R8ZSzyavRPSqVc4Ngb3jwdc0w6142CUVYCHT4TYLf7LcEiV-KJsoEsVpLdNyPyL2J-u3b_x-vQlLC_vj0ill3x1BDTkxtTHI34k1SlVaTeBoFtfgSiAdEPX2jpyvXCHzrJePnuUtN124-CAJx5NFVpnc38Y5DhqWgZpuNAqa2BnBlLxBdmcR4WJFQoihlP7vgA-XipEJ39SxkQoELYln6lOiIaEtP";


        IRestClient restClient;

        [TestInitialize]

        public void SetUp()

        {
            restClient = new RestClient();
          

        }
        [TestMethod]

        public void CreatePlalist()
        {

            IRestRequest restRequest = new RestRequest(playlistEndpoint);
            restRequest.AddHeader("Authorization",accesstoken);
            string requestPayload = File.ReadAllText("C:/Users/G748/source/repos/BestBuyAPITest/SpotifyAPITest/Spotify/Playlistname.json");
            restRequest.AddJsonBody(requestPayload);
            IRestResponse restResponse = restClient.Post(restRequest);
            Assert.AreEqual(HttpStatusCode.Created, restResponse.StatusCode);
              

        }

        [TestMethod]
        public void GetPlalist()
        {

            IRestRequest restRequest = new RestRequest(playlistEndpoint);
            restRequest.AddHeader("Authorization", accesstoken);
          
            //IRestResponse restResponse = restClient.Get(restRequest);


            IRestResponse<PDto> restResponse = restClient.Get<PDto>(restRequest);
            Assert.AreEqual(HttpStatusCode.OK, restResponse.StatusCode);
            Console.WriteLine(restResponse.Data.limit);
            Console.WriteLine(restResponse.Data.items[0].name); 

        }


    }
}
