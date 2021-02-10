using NUnit.Allure.Core;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Tests.RestAPITests
{
    [TestFixture]
    [AllureNUnit]
    [Parallelizable]
    class PetStoreRestAPITests
    {
        [Test]
        public void CreateNewPet()
        {
            var client = new RestClient(PetStoreRestAPIData.petStoreAPIUrl);
            var request = new RestRequest(PetStoreRestAPIData.createNewPetRequest, Method.POST);
            request.AddParameter("application/json",
                PetStoreRestAPIData.ReadInfoFromTheFile(PetStoreRestAPIData.pathToNewPetFile),
                ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            var content = response.Content;
            Console.WriteLine($"Content : {content}");

            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
            Assert.IsTrue(content.Contains(PetStoreRestAPIData.createNewPetResult));
        }

        [Test]
        public void UpdateCreatedPet()
        {
            var client = new RestClient(PetStoreRestAPIData.petStoreAPIUrl);
            var request = new RestRequest(PetStoreRestAPIData.createNewPetRequest, Method.PUT);

            request.AddParameter("application/json", 
                PetStoreRestAPIData.ReadInfoFromTheFile(PetStoreRestAPIData.pathToUpdatePetFile),
                ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            var content = response.Content;
            Console.WriteLine($"Content : {content}");

            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
            Assert.IsTrue(content.Contains(PetStoreRestAPIData.updatePetResult));
        }
    }
}
