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
                case StatesEnum.Alabama:
                    return new AlabamaPlateGenerator();
                    break;
                case StatesEnum.Alaska:
                    return new AlaskaPlateGenerator();
                    break;
                default:
                    return new NorthCarolinaPlateGenerator();
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
                Console.WriteLine(((IStatePlateGenerator)GetStatePlateGenerator((StatesEnum)Enum.Parse(typeof(StatesEnum), stateSelection))).GeneratePlate());
            }
        }
    }
}
