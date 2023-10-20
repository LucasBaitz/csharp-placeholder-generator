using System;
using System.Text;

namespace PlaceholderImageAPI.Helpers
{
    public class RandomColors
    {
        private static readonly Random _random = new Random();

        public static string GenerateRandomHexColor()
        {
            byte[] rgb = new byte[3];
            _random.NextBytes(rgb);

            string hexColor = "#" + BitConverter.ToString(rgb).Replace("-", string.Empty);
            return hexColor;
        }
    }
}
