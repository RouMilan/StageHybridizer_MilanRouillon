using ManagedCuda;

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
    }
}