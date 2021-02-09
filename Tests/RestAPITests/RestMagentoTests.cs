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
    class RestMagentoTests
    {
        public Logger log = LogManager.GetCurrentClassLogger();
        [Test]
        public void GetCountryWithIdTest()
        {
            log.Info("Start");
            string url = RestMagentoTestData.url;
            var client = new RestClient(url);
            var request = new RestRequest(RestMagentoTestData.getCountryWithIdRequest, Method.GET);
            IRestResponse response = client.Execute(request);
            var actualResult = response.Content;
            Console.WriteLine("Content:" + actualResult);
            var expectedResult = RestMagentoTestData.fullNameOfCountry;
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
            Assert.IsTrue(actualResult.Contains(expectedResult));
            log.Info("Content:" + actualResult);
        }

        [Test]
        public void DeletePaymentOrderInfoTest()
        {
            log.Info("Start");
            string url = RestMagentoTestData.url;
            var client = new RestClient(url);
            var request = new RestRequest(RestMagentoTestData.deletePaymentOrderInfoRequest, Method.DELETE);
            IRestResponse response = client.Execute(request);
            var actualResult = response.Content;
            Console.WriteLine("Content:" + actualResult);
            var expectedResult = RestMagentoTestData.resultAfterDeleteingOfOrederInfo;
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
            Assert.AreEqual(expectedResult, actualResult, "Incorrect request");
            log.Info("Content:" + actualResult);
        }

        [Test]
        public void CreateAnEmptyCartTest()
        {
            log.Info("Start");
            string url = RestMagentoTestData.url;
            var client = new RestClient(url);
            var request = new RestRequest(RestMagentoTestData.createNewCartRequest, Method.POST);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            var actualResult = content.Length;
            Console.WriteLine("Content:" + actualResult);
            var expectedResult = RestMagentoTestData.expectedLengthOfCartId;
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
            Assert.AreEqual(expectedResult, actualResult, "Incorrect request");
            log.Info("Content:" + actualResult);
        }

        [Test]
        public void GetPaymentMethodsForNewCartTest()
        {
            log.Info("Start");
            string url = RestMagentoTestData.url;
            var client = new RestClient(url);
            var request = new RestRequest(RestMagentoTestData.createNewCartRequest, Method.POST);
            IRestResponse creatingNewCartResponse = client.Execute(request);
            var contentOfCreatingNewCartResponse = creatingNewCartResponse.Content;
            contentOfCreatingNewCartResponse = contentOfCreatingNewCartResponse.Trim(RestMagentoTestData.charForTrim);
            Console.WriteLine(contentOfCreatingNewCartResponse);
            var requestForPaymentMethods = new RestRequest("/V1/guest-carts/" + contentOfCreatingNewCartResponse +"/payment-methods");
            IRestResponse paymentMethodsResponse = client.Execute(requestForPaymentMethods);
            var contentOfPaymentMethodsResponse = paymentMethodsResponse.Content;
            var actualResult = contentOfPaymentMethodsResponse;
            Console.WriteLine("Content:" + actualResult);
            var expectedResult = RestMagentoTestData.expextedPaymentMethod;
            Assert.IsTrue(paymentMethodsResponse.StatusCode == System.Net.HttpStatusCode.OK);
            Assert.True(actualResult.Contains(expectedResult), "Incorrect request");
            log.Info("Content:" + actualResult);
        }

        [Test]
        public void CreateTockenForAdminTest()
        {
            log.Info("Start");
            string url = RestMagentoTestData.url;
            var client = new RestClient(url);
            var request = new RestRequest("/V1/guest-carts", Method.POST);
            request.AddParameter("application/json", RestMagentoTestData.GetAdminBody(), ParameterType.RequestBody);
            IRestResponse creatingAdminTokenResponse = client.Execute(request);
            var contentOfCreatingAdminTokenResponse = creatingAdminTokenResponse.Content;
            var actualResult = contentOfCreatingAdminTokenResponse.Length;
            Console.WriteLine("Content:" + actualResult);
            var expectedResult = RestMagentoTestData.expectedLengthOfToken;
            Assert.IsTrue(creatingAdminTokenResponse.StatusCode == System.Net.HttpStatusCode.OK);
            Assert.AreEqual(expectedResult, actualResult, "Incorrect request");
            log.Info("Content:" + actualResult);
        }

    }
}

