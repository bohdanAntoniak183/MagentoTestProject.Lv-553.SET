using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NLog;
using RestSharp;
using NUnit.Allure.Core;
using Allure.Commons;
using NUnit.Allure.Attributes;
using System.ComponentModel;


namespace MagentoLv553SET.Rest
{
    [TestFixture]
    [AllureNUnit]
    class RestPetstoreTest
    {
        [Test]
        public void CreateNewPet()
        {
            var client = new RestClient(RestPetstoreTestData.url);
            var request = new RestRequest(RestPetstoreTestData.requestForCreatingAndUpdating, Method.POST);
            request.AddParameter("application/json",
                RestPetstoreTestData.GetBodyForCreatingOrUpdatingPetInformation(RestPetstoreTestData.pathToPetBodyFile),
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var actualResult = response.Content;
            Console.WriteLine($"Content : {actualResult}");
            var expectedResult = RestPetstoreTestData.expectedName;
            
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
            Assert.IsTrue(actualResult.Contains(expectedResult));
        }

        [Test]
        public void UpdatePet()
        {
            var client = new RestClient(RestPetstoreTestData.url);
            var request = new RestRequest(RestPetstoreTestData.requestForCreatingAndUpdating, Method.PUT);
            request.AddParameter("application/json",
                RestPetstoreTestData.GetBodyForCreatingOrUpdatingPetInformation(RestPetstoreTestData.pathToBodyForUpdateFile),
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var actualResult = response.Content;
            Console.WriteLine($"Content : {actualResult}");
            var expectedResult = RestPetstoreTestData.expectedNameAfterUpdate;
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
            Assert.IsTrue(actualResult.Contains(expectedResult));
        }

        [Test]
        public void GetPetWithId()
        {
            var client = new RestClient(RestPetstoreTestData.url);
            var request = new RestRequest(RestPetstoreTestData.requestForGettingInfoAboutPetByID, Method.GET);
            IRestResponse response = client.Execute(request);
            var actualResult = response.Content;
            Console.WriteLine($"Content : {actualResult}");
            var expectedResult = RestPetstoreTestData.expectedName;
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
            Assert.IsTrue(actualResult.Contains(expectedResult));
        }

    }
}
