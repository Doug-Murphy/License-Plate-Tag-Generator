namespace License_Plate_Tag_Generator.Interfaces
{
    interface IStatePlateGenerator
    {
        string Format { get; }

        string GeneratePlate();
    }
}
