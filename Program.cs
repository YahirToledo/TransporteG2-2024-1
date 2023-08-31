using TransporteG2_2024_1;
using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido!");
        Thread.Sleep(1000);
        var miAutomovil = new Automovil();
        Thread.Sleep(1000);
        Console.Clear();
        var miTractor = new Tractor();
        Console.ReadLine();
    }
}