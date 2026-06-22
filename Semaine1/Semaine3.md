### Troisème Semaine : Validation des Exemples

En faisant tourner le dernier exemple de la semaine dernière, notre console nous donne : 

![Screen1](ScreenConsoleSemaine3.1.jpg)

Pour pouvoir faire d'autres tests, il faut créer des kernels CUDA, donc je vais suivre les étapes suivantes : 

Depuis VS Code:

Ouvre un dossier de travail dans VS Code (par exemple un dossier tests-cuda que tu crées à côté de ton projet Hybridizer)

Clic droit dans l'explorateur de fichiers → Nouveau fichier → tape vectorAdd.cu
Colle le contenu du kernel dedans
Ctrl+S pour sauvegarder

le contenu en question : 
```csharp

ppextern "C" __global__ void VectorAdd(float* a, float* b, float* result, int n)
{
    int i = blockIdx.x * blockDim.x + threadIdx.x;
    if (i < n) result[i] = a[i] + b[i];
}

```

