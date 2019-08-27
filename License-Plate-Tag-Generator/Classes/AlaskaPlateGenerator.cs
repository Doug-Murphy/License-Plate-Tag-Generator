using License_Plate_Tag_Generator.Interfaces;
using System;

namespace License_Plate_Tag_Generator.Classes
{
    class AlaskaPlateGenerator : IStatePlateGenerator
    {
        public string Format => "XXX ###";

        public string GeneratePlate()
        {
            return "ABC 123";
        }
    }
}
