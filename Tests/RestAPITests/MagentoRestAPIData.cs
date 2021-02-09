using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Tests.RestAPITests
{
    class MagentoRestAPIData
    {
        public static string magentoAPIUrl = "https://magento.nublue.co.uk/rest/all";
        public static string getCountryWithIdRequest = "/V1/directory/countries/CN";
        public static string getCountryWithIdResult = "China";
        public static string deletePaymentOrderInformationRequest = "/V1/amazon/order-ref";
        public static string deletePaymentOrderInformationResult = "[]";
        public static string createEmptyCartRequest = "/V1/guest-carts";
        public static int createEmptyCartResultLength = 34;
    }
}
