using License_Plate_Tag_Generator.Interfaces;
using System;
using System.Text;

namespace License_Plate_Tag_Generator.Helpers
{
    public class RandomGenerator
    {
        private IStatePlateGenerator _statePlateGenerator;

        public RandomGenerator(IStatePlateGenerator statePlateGenerator)
        {
            _statePlateGenerator = statePlateGenerator;
        }

        public string GeneratePlate()
        {
            var returnString = new StringBuilder();
            var randomizer = new Random();

            foreach (var character in _statePlateGenerator.Format)
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
