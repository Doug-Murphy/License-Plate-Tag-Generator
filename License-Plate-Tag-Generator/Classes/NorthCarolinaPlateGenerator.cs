using License_Plate_Tag_Generator.Interfaces;
using System;

namespace License_Plate_Tag_Generator.Classes
{
    class NorthCarolinaPlateGenerator : IStatePlateGenerator
    {
        public string Format => "XXX-####";

        public string GeneratePlate()
        {
            return "ABC-1234";
        }
    }
}
