using MagentoLv553SET.Data;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using NUnit.Allure.Core;

namespace MagentoLv553SET.Tests
{
    [TestFixture]
    [AllureNUnit]
    class CreateCustomerAPITests
{
    [Test]
    public void CreateCustomer_Test()
    {
        string randomEmailValue = TestsDataGenerator.GenerateRandomEmail(DomenName.UkrNet,10);
        string randomFirstNameValue = TestsDataGenerator.GenerateRandomUserName(8, true);
        string randomLastNameValue = TestsDataGenerator.GenerateRandomUserName(12, true);

            var client = new RestClient("https://magento.nublue.co.uk/rest/all/V1/customers")
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
        request.AddHeader("Content-Type", "application/json");
        request.AddHeader("Cookie", "PHPSESSID=914gea9lgsjouk0j0hb5j0d28k");
        var data = new Dictionary<string, Dictionary<string, string>>
            {
                {
                     "customer", new Dictionary<string, string>
                        {
                            {"email", randomEmailValue },
                            {"firstname", randomFirstNameValue },
                            {"lastname", randomLastNameValue }
                        }
                }
            };
        var jsonData = JsonConvert.SerializeObject(data);
        Console.WriteLine(jsonData);
        request.AddParameter("application/json", jsonData, ParameterType.RequestBody);
        IRestResponse response = client.Execute(request);
        var result = response.StatusCode;
        var expected = HttpStatusCode.OK;
        Assert.AreEqual(expected, result);
    }
}
}
