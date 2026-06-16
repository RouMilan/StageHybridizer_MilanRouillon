using System;
using Hybridizer.Runtime.CUDAImports;

class Program
{
    [EntryPoint]
    public static void TestKernel(int[] output, int N)
    {
        for (int i = threadIdx.x + blockDim.x * blockIdx.x;
             i < N;
             i += blockDim.x * gridDim.x)
        {
            output[i] = i * 2;
        }
    }

    static void Main()
    {
        // Check GPU
        cuda.GetDeviceProperties(out cudaDeviceProp prop, 0);
        Console.WriteLine($"GPU: {new string(prop.name)}");
        Console.WriteLine($"SMs: {prop.multiProcessorCount}");
        Console.WriteLine($"Memory: {(ulong)prop.totalGlobalMem / (1024ul * 1024ul)} MB");

        // Run kernel
        int N = 1024;
        int[] output = new int[N];

        dynamic wrapper = HybRunner.Cuda()
            .SetDistrib(32, 256);
        wrapper.TestKernel(output, N);
        cuda.DeviceSynchronize();

        // Verify
        bool ok = true;
        for (int i = 0; i < N; i++)
        {
            if (output[i] != i * 2) { ok = false; break; }
        }

        Console.WriteLine(ok ? "✅ Hybridizer is working!" : "❌ Something went wrong");
    }
}
