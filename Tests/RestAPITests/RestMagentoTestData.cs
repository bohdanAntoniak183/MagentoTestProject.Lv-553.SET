using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MagentoLv553SET.Rest
{
    class RestMagentoTestData
    {
        public static string url = "https://magento2.demo.ubertheme.com/index.php/rest/all";
        public static string getCountryWithIdRequest = "/V1/directory/countries/AE";
        public static string fullNameOfCountry = "United Arab Emirates";
        public static string deletePaymentOrderInfoRequest = "/V1/amazon/order-ref";
        public static string resultAfterDeleteingOfOrederInfo = "[]";
        public static string createNewCartRequest = "/V1/guest-carts";
        public static int expectedLengthOfCartId = 34;
        public static string expextedPaymentMethod = "checkmo";
        public static char charForTrim = '"';
        public static int expectedLengthOfToken = 34;

        public static string GetAdminBody()
        {
            string pathToAdminBodyFile = @"D:\C#_Projects\MagentoSet\Tests\RestAPITests\BodyForCreatingAdminToken.txt";
            string adminBody = String.Empty;
            using (var file = new StreamReader(pathToAdminBodyFile))
            {
                adminBody= file.ReadToEnd();
            }
            return adminBody;
        }
    }
}
