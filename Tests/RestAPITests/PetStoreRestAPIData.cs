using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace MagentoLv553SET.Tests.RestAPITests
{
    class PetStoreRestAPIData
    {
        public static string pathToNewPetFile = @"D:\MagentoTestProject\Tests\RestAPITests\newPetInfo.txt";
        public static string pathToUpdatePetFile = @"D:\MagentoTestProject\Tests\RestAPITests\updatedPetInfo.txt";
        public static string pathToNewOrderFile = "..\\..\\..\\Tests\\RestAPITests\\OrderInfo.txt";
        public static string petStoreAPIUrl = "https://petstore.swagger.io";
        public static string createNewPetRequest = "/v2/pet";
        public static string createNewOrderResult = "\"complete\":true";
        public static string createNewPetResult = "Jack";
        public static string updatePetRequest = "/v2/pet";
        public static string updatePetResult = "Bob";
        public static string createNewOrderRequest = "/v2/store/order";
        public static string orderId = "8";
        public static string findOrderRequest = $"/v2/store/order/{orderId}";
        public static string findOrderResult = $"\"id\":{orderId}";
        public static string deleteOrderRequest = findOrderRequest;
        public static string errorFindOrderMessage = "\"message\":\"Order not found\"";

        public static string ReadInfoFromTheFile(string pathToPetFile)
        {
            string information = "";

            try
            {
                using (var file = new StreamReader(pathToPetFile))
                {
                    information = file.ReadToEnd();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return information;
        }
    }
}
