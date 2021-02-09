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
        public static string petStoreAPIUrl = "https://petstore.swagger.io";
        public static string createNewPetRequest = "/v2/pet";
        public static string createNewPetResult = "Jack";
        public static string updatePetRequest = "/v2/pet";
        public static string updatePetResult = "Bob";

        public static string PetInformation(string pathToPetFile)
        {
            string petInformation = "";

            try
            {
                using (var file = new StreamReader(pathToPetFile))
                {
                    petInformation = file.ReadToEnd();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return petInformation;
        }
    }
}
