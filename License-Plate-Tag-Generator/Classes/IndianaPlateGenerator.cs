using License_Plate_Tag_Generator.Helpers;
using License_Plate_Tag_Generator.Interfaces;

namespace License_Plate_Tag_Generator.Classes
{
    class IndianaPlateGenerator : IStatePlateGenerator
    {
        public string Format => "XXX###";
    }
}
