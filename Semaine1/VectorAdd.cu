extern "C" __global__ void VectorAdd(float* a, float* b, float* result, int n)
{
    int i = blockIdx.x * blockDim.x + threadIdx.x;
    if (i < n) result[i] = a[i] + b[i];
}