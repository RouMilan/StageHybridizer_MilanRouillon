using ManagedCuda;
using ManagedCuda.NVRTC;

class Program
{
    static void Main()
    {
        int deviceCount = CudaContext.GetDeviceCount();
        Console.WriteLine($"Nombre de GPU détectés : {deviceCount}");

        if (deviceCount > 0)
        {
            var ctx = new CudaContext(0);
            Console.WriteLine($"GPU utilisé : {ctx.GetDeviceName()}");
        }
        Console.WriteLine("Voulez vous faire l'exemple 1 ? (o/n)");
                if (Console.ReadLine()?.ToLower() == "o")
        {
            Exo1();
        }
    }
    static void Exo1()
    {

    }
}