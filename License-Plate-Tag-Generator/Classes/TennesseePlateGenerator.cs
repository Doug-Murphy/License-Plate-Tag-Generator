﻿using License_Plate_Tag_Generator.Helpers;
using License_Plate_Tag_Generator.Interfaces;

namespace License_Plate_Tag_Generator.Classes
{
    class TennesseePlateGenerator : IStatePlateGenerator
    {
        public string Format => "#X#-#X#";

        public string GeneratePlate()
        {
            return RandomGenerator.GeneratePlate(Format);
        }
    }
}
