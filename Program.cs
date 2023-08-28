using TransporteG2_2024_1;

internal class Program
{
    private static void Main(string[] args)
    {
        string marca = Console.ReadLine();
        if (marca == "BMW")
        {
            var miAutomovil = new Automovil();
        }
        if (marca == "Kubota")
        {
            var miTractor = new Tractor();
        }
    }
}