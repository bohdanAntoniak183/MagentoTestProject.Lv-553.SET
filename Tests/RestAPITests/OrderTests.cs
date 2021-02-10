using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using RestSharp;

namespace MagentoLv553SET.Tests.RestAPITests
{
    [TestFixture]
    class OrderTests
    {
        [Test]
        public void CreateNewOrderTest()
        {
            RestClient client = new RestClient(PetStoreRestAPIData.petStoreAPIUrl);
            RestRequest request = new RestRequest(PetStoreRestAPIData.createNewOrderRequest, Method.POST);

            request.AddParameter("application/json",
                PetStoreRestAPIData.ReadInfoFromTheFile(PetStoreRestAPIData.pathToNewOrderFile), 
                ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            Console.WriteLine(response.Content);

            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
            Assert.IsTrue(response.Content.Contains(PetStoreRestAPIData.createNewOrderResult));
        }

        [Test]
        public void FindOrderByIdTest()
        {
            RestClient client = new RestClient(PetStoreRestAPIData.petStoreAPIUrl);
            RestRequest request = new RestRequest(PetStoreRestAPIData.findOrderRequest, Method.GET);

            IRestResponse response = client.Execute(request);

            Console.WriteLine(response.Content);

            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
            Assert.IsTrue(response.Content.Contains(PetStoreRestAPIData.findOrderResult));
        }

        [Test]
        public void DeleteOrderByIdTest()
        {
            RestClient client = new RestClient(PetStoreRestAPIData.petStoreAPIUrl);
            RestRequest request = new RestRequest(PetStoreRestAPIData.createNewOrderRequest, Method.POST);

            request.AddParameter("application/json",
                PetStoreRestAPIData.ReadInfoFromTheFile(PetStoreRestAPIData.pathToNewOrderFile),
                ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);

            request = new RestRequest(PetStoreRestAPIData.deleteOrderRequest, Method.DELETE);

            response = client.Execute(request);

            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);

            request = new RestRequest(PetStoreRestAPIData.findOrderRequest, Method.GET);
            response = client.Execute(request);

            Assert.IsTrue(response.Content.Contains(PetStoreRestAPIData.errorFindOrderMessage));
        }
    }
}
