using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MagentoLv553SET.Rest
{
    class RestPetstoreTestData
    {
        //public static string GetNewPetBody()
        //{
        //    string pathToPetBodyFile = @"D:\C#_Projects\MagentoSet\RestAPITests\BodyForCreatingNewPet.txt";
        //    string petBody = String.Empty;
        //    using (var file = new StreamReader(pathToPetBodyFile))
        //    {
        //        petBody = file.ReadToEnd();
        //    }
        //    return petBody;
        //}

        public static string GetBodyForCreatingOrUpdatingPetInformation(string pathToPetFile)
        {
            string petInformation = "";
            try
            {
                using (var file = new StreamReader(pathToPetFile))
                {
                    petInformation = file.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return petInformation;
        }

        //public static string GetNewBodyForPetUpdate()
        //{
        //    string pathToBodyForUpdateFile = @"D:\C#_Projects\MagentoSet\RestAPITests\BodyForUpdatingPetInfo.txt";
        //    string bodyForPetUpdate = String.Empty;
        //    using (var file = new StreamReader(pathToBodyForUpdateFile))
        //    {
        //        bodyForPetUpdate = file.ReadToEnd();
        //    }
        //    return bodyForPetUpdate;
        //}
        public static string pathToPetBodyFile = @"D:\C#_Projects\MagentoSet\Tests\RestAPITests\BodyForCreatingNewPet.txt";
        public static string pathToBodyForUpdateFile = @"D:\C#_Projects\MagentoSet\Tests\RestAPITests\BodyForUpdatingPetInfo.txt";

        public static string url = "https://petstore.swagger.io/v2";
        public static string requestForCreatingAndUpdating = "/pet";
        public static string requestForGettingInfoAboutPetByID = "/pet/111";
        public static string expectedName = "Tomas";
        public static string expectedNameAfterUpdate = "Edward";
    }
}
