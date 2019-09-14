using License_Plate_Tag_Generator.Helpers;
using License_Plate_Tag_Generator.Interfaces;

namespace License_Plate_Tag_Generator.Classes
{
    class IllinoisPlateGenerator : IStatePlateGenerator
    {
        public string Format => "XX #####";
    }
}
