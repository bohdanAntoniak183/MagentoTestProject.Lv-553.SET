using NLog;
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
    public class MagentoRestAPITests
    {

        [Test]
        public void GetCountryWithIdTest()
        {
            var client = new RestClient(MagentoRestAPIData.magentoAPIUrl);
            var request = new RestRequest(MagentoRestAPIData.getCountryWithIdRequest, Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.WriteLine($"Content : {content}");


            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
            Assert.IsTrue(content.Contains(MagentoRestAPIData.getCountryWithIdResult));
        }

        [Test]
        public void GreateEmptyCart()
        {
            var client = new RestClient(MagentoRestAPIData.magentoAPIUrl);
            var request = new RestRequest(MagentoRestAPIData.createEmptyCartRequest, Method.POST);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.WriteLine($"Content : {content}");

            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
            Assert.IsTrue(content.Length == MagentoRestAPIData.createEmptyCartResultLength);
        }

        [Test]
        public void DeletePaymentOrderInformation()
        {
            var client = new RestClient(MagentoRestAPIData.magentoAPIUrl);
            var request = new RestRequest(MagentoRestAPIData.deletePaymentOrderInformationRequest, Method.DELETE);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.WriteLine($"Content : {content}");

            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
            Assert.AreEqual(content,MagentoRestAPIData.deletePaymentOrderInformationResult);
        }
    }
}
