# Neetcode Arrays & Hashing 🚀

Colección de soluciones en **C# (.NET 8)** para todos los problemas del módulo **Arrays & Hashing** de [NeetCode](https://neetcode.io/).

![build](https://github.com/<usuario>/<repo>/actions/workflows/dotnet.yml/badge.svg)

---

## Requisitos
- [.NET SDK 8.0 o superior](https://dotnet.microsoft.com/)
- VS Code + extensión **C#** (o cualquier IDE .NET)

---

## Añadir un ejercicio

1. Crear `Solutions/<Id>_<Nombre>.cs` dentro del proyecto **Neetcode.ArraysHashing**.  
2. Crear su prueba en `Tests/<Nombre>Tests.cs`.  
3. Ejecutar:

   ```bash
   dotnet test           # todos los tests deben quedar en verde

## Ejecutar manualmente

El proyecto Runner es opcional, pero muy útil para depurar o ver la salida “a mano”.

# Ejecutar el runner con el ejemplo que tengas en Program.cs
dotnet run --project Runner

# (Opcional) Si tu Program.cs admite argumentos, por ejemplo:
dotnet run --project Runner -- TwoSum

## ----Estructura del repositorio----

NeetcodeArraysHashing.sln          ← **Solución** (índice que agrupa proyectos)

├── Neetcode.ArraysHashing/        ← **Proyecto 1 – Class Library**
│   ├── Neetcode.ArraysHashing.csproj
│   └── Solutions/                 ← aquí va **cada ejercicio**
│       ├── ContainsDuplicate.cs
│       ├── TwoSum.cs
│       └── …
│              ↳ Compila a *Neetcode.ArraysHashing.dll*
│
├── Neetcode.ArraysHashing.Tests/  ← **Proyecto 2 – xUnit Tests**
│   ├── Neetcode.ArraysHashing.Tests.csproj
│   └── ContainsDuplicateTests.cs
│              ↳ Referencia la DLL anterior para probarla
│
└── Runner/                        ← **Proyecto 3 – Console App** (opcional)
    ├── Runner.csproj
    └── Program.cs                 ↳ `using Neetcode.ArraysHashing.Solutions`
                                     Imprime/depura resultados


### Glosario

Solución (.sln)	Índice que agrupa proyectos y sus relaciones.
Proyecto (.csproj)	Unidad de compilación. Puede generar DLL (Library) o EXE (Console/App).
Class Library	Proyecto sin Main(). Contiene la lógica reutilizable; se compila a DLL.
Console App	Proyecto con Main(). Se ejecuta con dotnet run.
DLL	Binario resultante de una Class Library; otros proyectos lo cargan.
ProjectReference	Entrada en un .csproj que indica “este proyecto depende de aquel otro”.


## Workflow típico:

Añade un archivo en Solutions/ con la nueva función.

Añade su prueba en Tests/.

Ejecuta dotnet test → todo verde.

(Opc.) Lanza dotnet run --project Runner para ver resultados manualmente.