using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Data
{
    public class TestsDataGenerator
    {
        public static string GenerateRandomUserName(int size, bool lowerCase = true)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();
            char character;
            for (int i = 0; i < size; i++)
            {
                character = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                stringBuilder.Append(character);
            }
            if (lowerCase)

                return stringBuilder.ToString().ToLower();
            return stringBuilder.ToString();


        }
        public static string GenerateRandomEmail(string nameDomen, int size = 10)
        {
            string randomMail = GenerateRandomUserName(size) + nameDomen;
            return randomMail;
        }
        public static string GenerateRandomData(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            string randomData = "";
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(33, 125);
                randomData += (char)array[i];
            }
            return randomData;
        }
        public static string GenerateRandomPassword(int size)
        {
            string randomPassword = GenerateRandomData(size);
            return randomPassword;
        }     
        

    }
}
