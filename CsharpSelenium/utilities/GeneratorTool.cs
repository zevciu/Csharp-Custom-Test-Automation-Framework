using System;
using System.Linq;
using System.Text;

namespace CsharpSelenium.utilities
{
    public class GeneratorTool
    {
        private static char[] baseChars = "qwertyuiopasdfghjklzxcvbnm".ToCharArray();

        private static char[] baseDigits = "1234567890".ToCharArray();

        private static char[] baseCharsDigits = baseChars.Concat(baseDigits).ToArray();


        public string RandomString(int length, string type)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                if (type == "alphabetic")
                {
                    char c = baseChars[random.Next(baseChars.Length)];
                    sb.Append(c);
                }
                else if (type == "numeric")
                {
                    char c = baseDigits[random.Next(baseDigits.Length)];
                    sb.Append(c);
                }
                else if (type == "aplhanumeric")
                {
                    char c = baseCharsDigits[random.Next(baseCharsDigits.Length)];
                    sb.Append(c);
                }
            }
            return sb.ToString();        
        }

    }
}
