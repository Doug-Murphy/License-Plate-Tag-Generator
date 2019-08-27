using License_Plate_Tag_Generator.Interfaces;
using System;

namespace License_Plate_Tag_Generator.Classes
{
    class AlabamaPlateGenerator : IStatePlateGenerator
    {
        public string Format => "##XX###";

        public string GeneratePlate()
        {
            return "00AB123";
        }
    }
}
