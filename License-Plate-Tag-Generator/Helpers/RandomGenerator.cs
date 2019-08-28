using System;
using System.Text;

namespace License_Plate_Tag_Generator.Helpers
{
    public static class RandomGenerator
    {
        public static string GeneratePlate(string plateFormat)
        {
            var returnString = new StringBuilder();
            var randomizer = new Random();

            foreach (var character in plateFormat)
            {
                switch (character)
                {
                    case '#':
                        returnString.Append((char)randomizer.Next(48, 58));
                        break;
                    case 'X':
                        returnString.Append((char)randomizer.Next(65, 91));
                        break;
                    default:
                        returnString.Append(character);
                        break;
                }
            }

            return returnString.ToString();
        }
    }
}
