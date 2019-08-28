using License_Plate_Tag_Generator.Classes;
using License_Plate_Tag_Generator.Interfaces;
using System;

namespace License_Plate_Tag_Generator
{
    class Program
    {
        static object GetStatePlateGenerator(StatesEnum stateSelection)
        {
            switch (stateSelection)
            {
                case StatesEnum.Alabama: return new AlabamaPlateGenerator(); break;
                case StatesEnum.Alaska: return new AlaskaPlateGenerator(); break;
                case StatesEnum.Arizona: return new ArizonaPlateGenerator(); break;
                case StatesEnum.Arkansas: return new ArkansasPlateGenerator(); break;
                case StatesEnum.California: return new CaliforniaPlateGenerator(); break;
                case StatesEnum.Colorado: return new ColoradoPlateGenerator(); break;
                case StatesEnum.Connecticut: return new ConnecticutPlateGenerator(); break;
                case StatesEnum.Delaware: return new DelawarePlateGenerator(); break;
                case StatesEnum.Florida: return new FloridaPlateGenerator(); break;
                case StatesEnum.Georgia: return new GeorgiaPlateGenerator(); break;
                case StatesEnum.Hawaii: return new HawaiiPlateGenerator(); break;
                case StatesEnum.Idaho: return new IdahoPlateGenerator(); break;
                case StatesEnum.Illinois: return new IllinoisPlateGenerator(); break;
                case StatesEnum.Indiana: return new IndianaPlateGenerator(); break;
                case StatesEnum.Iowa: return new IowaPlateGenerator(); break;
                case StatesEnum.Kansas: return new KansasPlateGenerator(); break;
                case StatesEnum.Kentucky: return new KentuckyPlateGenerator(); break;
                case StatesEnum.Louisiana: return new LouisianaPlateGenerator(); break;
                case StatesEnum.Maine: return new MainePlateGenerator(); break;
                case StatesEnum.Maryland: return new MarylandPlateGenerator(); break;
                case StatesEnum.Massachusetts: return new MassachusettsPlateGenerator(); break;
                case StatesEnum.Michigan: return new MichiganPlateGenerator(); break;
                case StatesEnum.Minnesota: return new MinnesotaPlateGenerator(); break;
                case StatesEnum.Mississippi: return new MississippiPlateGenerator(); break;
                case StatesEnum.Missouri: return new MissouriPlateGenerator(); break;
                case StatesEnum.Montana: return new MontanaPlateGenerator(); break;
                case StatesEnum.Nebraska: return new NebraskaPlateGenerator(); break;
                case StatesEnum.Nevada: return new NevadaPlateGenerator(); break;
                case StatesEnum.New_Hampshire: return new NewHampshirePlateGenerator(); break;
                case StatesEnum.New_Jersey: return new NewJerseyPlateGenerator(); break;
                case StatesEnum.New_Mexico: return new NewMexicoPlateGenerator(); break;
                case StatesEnum.New_York: return new NewYorkPlateGenerator(); break;
                case StatesEnum.North_Carolina: return new NorthCarolinaPlateGenerator(); break;
                case StatesEnum.North_Dakota: return new NorthDakotaPlateGenerator(); break;
                case StatesEnum.Ohio: return new OhioPlateGenerator(); break;
                case StatesEnum.Oklahoma: return new OklahomaPlateGenerator(); break;
                case StatesEnum.Oregon: return new OregonPlateGenerator(); break;
                case StatesEnum.Pennsylvania: return new PennsylvaniaPlateGenerator(); break;
                case StatesEnum.Rhode_Island: return new RhodeIslandPlateGenerator(); break;
                case StatesEnum.South_Carolina: return new SouthCarolinaPlateGenerator(); break;
                case StatesEnum.South_Dakota: return new SouthDakotaPlateGenerator(); break;
                case StatesEnum.Tennessee: return new TennesseePlateGenerator(); break;
                case StatesEnum.Texas: return new TexasPlateGenerator(); break;
                case StatesEnum.Utah: return new UtahPlateGenerator(); break;
                case StatesEnum.Vermont: return new VermontPlateGenerator(); break;
                case StatesEnum.Virginia: return new VirginiaPlateGenerator(); break;
                case StatesEnum.Washington: return new WashingtonPlateGenerator(); break;
                case StatesEnum.West_Virginia: return new WestVirginiaPlateGenerator(); break;
                case StatesEnum.Wisconsin: return new WisconsinPlateGenerator(); break;
                case StatesEnum.Wyoming: return new WyomingPlateGenerator(); break;
                default:
                    throw new ArgumentException($"{stateSelection} could not be parsed into a valid value.");
                    break;
            }
        }

        static void Main(string[] args)
        {
            var stateIndex = 0;

            foreach (var state in Enum.GetValues(typeof(StatesEnum)))
            {
                stateIndex++;
                Console.WriteLine($"{stateIndex} - {state.ToString().Replace("_", " ")}");
            }

            Console.Write($"Enter a comma-delimited list of the states that you would like a license plate generated for: ");
            var stateSelections = Console.ReadLine();
            foreach (var stateSelection in stateSelections.Split(',', StringSplitOptions.RemoveEmptyEntries))
            {
                Console.WriteLine($"{Enum.GetName(typeof(StatesEnum), Convert.ToInt32(stateSelection))} - {((IStatePlateGenerator)GetStatePlateGenerator((StatesEnum)Enum.Parse(typeof(StatesEnum), stateSelection))).GeneratePlate()}");
            }
        }
    }
}
