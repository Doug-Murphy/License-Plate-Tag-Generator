using License_Plate_Tag_Generator.Helpers;
using License_Plate_Tag_Generator.Interfaces;

namespace License_Plate_Tag_Generator.Classes
{
    class RhodeIslandPlateGenerator : IStatePlateGenerator
    {
        public string Format => "######";

        public string GeneratePlate()
        {
            return RandomGenerator.GeneratePlate(Format);
        }
    }
}
